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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.Reporting.WinForms;
using log4net;

namespace Desarrollo_Semana_7_IDS345L
{
    
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void cb_TipoDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignora el carácter ingresado
            }
        }

        private void txt_Documento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignora el carácter ingresado
            }
        }

        private void txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Ignora el carácter ingresado
            }
        }

        private void txt_Apellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Ignora el carácter ingresado
            }
        }

        private void txt_Nota_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Ignora el carácter ingresado
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cb_TipoDoc.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_Estado.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_MetodoPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_Sexo.DropDownStyle = ComboBoxStyle.DropDownList;
            CargarOpcionesTipoDoc();
            CargarOpcionesSexo();
            CargarOpcionesEstado();
            CargarOpcionesPago();

        }

        private void CargarOpcionesTipoDoc()
        {
            // Aquí puedes cargar las opciones en el ComboBox desde alguna fuente de datos
            cb_TipoDoc.Items.Add("Cédula");
            cb_TipoDoc.Items.Add("Pasaporte");
        }

        private void CargarOpcionesSexo()
        {
            // Aquí puedes cargar las opciones en el ComboBox desde alguna fuente de datos
            cb_Sexo.Items.Add("Femenino");
            cb_Sexo.Items.Add("Masculino");
        }

        private void CargarOpcionesEstado()
        {
            // Aquí puedes cargar las opciones en el ComboBox desde alguna fuente de datos
            cb_Estado.Items.Add("Aprobado");
            cb_Estado.Items.Add("Denegado");
        }

        private void CargarOpcionesPago()
        {
            // Aquí puedes cargar las opciones en el ComboBox desde alguna fuente de datos
            cb_MetodoPago.Items.Add("Efectivo");
            cb_MetodoPago.Items.Add("Tarjeta");
        }

        private void bto_Pagar_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\3D Objects\\C#\\Desarrollo_Software_III\\Desarrollo Semana 7 IDS345L\\Desarrollo Semana 7 IDS345L\\BDCaja.mdf\";Integrated Security=True"))
            {
                using (SqlCommand command = new SqlCommand("InsertarDatosCliente", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Agrega los parámetros del stored procedure
                    command.Parameters.AddWithValue("@Tipo_Documento", cb_TipoDoc.Text);
                    command.Parameters.AddWithValue("@Documento", txt_Documento.Text);
                    command.Parameters.AddWithValue("@Nombres", txt_Nombre.Text);
                    command.Parameters.AddWithValue("@Apellidos", txt_Apellidos.Text);
                    command.Parameters.AddWithValue("@Sexo", cb_Sexo.Text);
                    command.Parameters.AddWithValue("@FechaNacimiento", DateTime.Parse(dtp_FechaNacimiento.Text));
                    command.Parameters.AddWithValue("@Nota", txt_Nota.Text);
                    command.Parameters.AddWithValue("@Estado", cb_Estado.Text);
                    command.Parameters.AddWithValue("@MetodoPago", cb_MetodoPago.Text);

                    connection.Open();
                    command.ExecuteNonQuery();
                
                    MessageBox.Show("Los datos han sido insertados correctamente.");

                    Form2 formulario = new Form2();
                    formulario.Show();
                    this.Hide();
                }
                log.Info("Se ha agregado un nuevo registro.");
            }
        }

        private void txt_Documento_TextChanged(object sender, EventArgs e)
        {
           
            string cedula = txt_Documento.Text.Replace("-", ""); // Obtener la cédula sin guiones
            string cedulaFormateada = "";

            for (int i = 0; i < cedula.Length; i++)
            {
                cedulaFormateada += cedula[i];

                // Agregar guion después de cada número según las posiciones específicas
                if (i == 2 || i == 9)
                {
                    cedulaFormateada += "-";
                }
            }

            int cursorPosition = txt_Documento.SelectionStart;
            txt_Documento.Text = cedulaFormateada; // Asignar la cédula formateada al TextBox

            // Ajustar la posición del cursor al eliminar guiones
            if (cursorPosition > 0 && cedulaFormateada.Length < cursorPosition && txt_Documento.Text.Length >= cursorPosition)
            {
                txt_Documento.SelectionStart = cursorPosition - 1;
            }
            else
            {
                txt_Documento.SelectionStart = cedulaFormateada.Length; // Establecer el cursor al final del texto
            }
        }

        private void bton_VerListado_Click(object sender, EventArgs e)
        {
            Form3 FormularioVer = new Form3();
            FormularioVer.Show();
            this.Hide();
        }

        private void cb_TipoDoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void bton_Imprimir_Click(object sender, EventArgs e)
        {
            Form2 FormularioImprimir = new Form2();
            FormularioImprimir.Show();

            this.Hide();
        }
        private static readonly ILog log = LogManager.GetLogger(typeof(Form1));

    }
}
