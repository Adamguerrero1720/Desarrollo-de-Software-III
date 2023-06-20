using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.Diagnostics.Internal;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desarrollo_Semana_7_IDS345L
{
    public partial class Form2 : Form
    {
        private List<Registro> registros; // Tu lista de registros

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDCajaDataSet.tblCliente' table. You can move, or remove it, as needed.
            this.tblClienteTableAdapter.Fill(this.bDCajaDataSet.tblCliente);

            this.reportViewer1.RefreshReport();

            // Cargar todos los registros desde tu origen de datos
            registros = ObtenerRegistros();

            // Verificar si existen registros
            if (registros.Any())
            {
                // Obtener el último registro
                Registro ultimoRegistro = registros.Last();

                // Crear una lista con el último registro
                List<Registro> origenDatos = new List<Registro> { ultimoRegistro };

                // Asignar el origen de datos al ReportViewer
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", origenDatos)); // Reemplaza "NombreDataSet" con el nombre real de tu DataSet en el informe RDLC

                // Actualizar el informe del ReportViewer
                reportViewer1.RefreshReport();
            }
            else
            {
                MessageBox.Show("No se encontraron registros.");
            }
        }

        private List<Registro> ObtenerRegistros()
        {
            List<Registro> registros = new List<Registro>();

            // Consulta SQL para obtener los registros
            string query = "SELECT * FROM tblCliente"; // Reemplaza "NombreTabla" con el nombre real de tu tabla en la base de datos

            // Crear una conexión a la base de datos
            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\3D Objects\\C#\\Desarrollo_Software_III\\Desarrollo Semana 7 IDS345L\\Desarrollo Semana 7 IDS345L\\BDCaja.mdf\";Integrated Security=True"))
            {
                // Abrir la conexión
                connection.Open();

                // Crear un comando SQL
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Ejecutar la consulta y obtener un lector de datos
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Leer los registros y agregarlos a la lista
                        while (reader.Read())
                        {
                            // Aquí debes mapear los datos del lector de datos a una instancia de tu clase Registro
                            // Por ejemplo:
                            Registro registro = new Registro
                            {
                                Id_Cliente = (int)reader["Id_Cliente"],
                                Tipo_Documento = (string)reader["Tipo_Documento"],
                                Documento = (string)reader["Documento"],
                                Nombres = (string)reader["Nombres"],
                                Apellidos = (string)reader["Apellidos"],
                                Sexo = (string)reader["Sexo"],
                                FechaNacimiento = (DateTime)reader["FechaNacimiento"],
                                Nota = (string)reader["Nota"],
                                Estado = (string)reader["Estado"],
                                MetodoPago = (string)reader["MetodoPago"],
                                // Asigna las propiedades restantes según la estructura de tu tabla
                            };

                            registros.Add(registro);
                        }
                    }
                }
            }

            return registros;
        }
        public class Registro
        {
            public int Id_Cliente { get; set; }
            public string Tipo_Documento { get; set; }
            public string Documento { get; set; }
            public string Nombres { get; set; }
            public string Apellidos { get; set; }
            public string Sexo { get; set; }
            public DateTime FechaNacimiento { get; set; }
            public string Nota { get; set; }
            public string Estado { get; set; }
            public string MetodoPago { get; set; }
        }
    }
}
