using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Desarrollo_Semana_8_IDSL345
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Obtener el DataSet con los datos
            DataSet dataSet = GetDataSet();

            // Establecer la fuente del informe RDLC
            reportViewer1.LocalReport.ReportPath = "D:\\3D Objects\\C#\\Desarrollo_Software_III\\Desarrollo-de-Software-III\\Desarrollo Semana 8 IDSL345\\Desarrollo Semana 8 IDSL345\\ReporteComprobante.rdlc";

            // Crear un objeto ReportDataSource con el DataSet completo
            ReportDataSource reportDataSource = new ReportDataSource("DataSet1", dataSet.Tables[0]);

            // Establecer el origen de datos en el ReportViewer
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);

            // Actualizar el informe RDLC
            reportViewer1.RefreshReport();
        }

        private DataSet GetDataSet()
        {
            // Crea y llena el DataSet con los datos desde tu fuente de datos
            DataSet dataSet = new DataSet();

            // Aquí debes agregar código para llenar el DataSet con los datos necesarios
            // Puedes usar una conexión a base de datos, un servicio web u otra fuente de datos

            // Por ejemplo, si los datos provienen de una base de datos utilizando SqlConnection y SqlDataAdapter:
            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\3D Objects\\C#\\Desarrollo_Software_III\\Desarrollo-de-Software-III\\Desarrollo Semana 8 IDSL345\\Desarrollo Semana 8 IDSL345\\BDAdmision.mdf\";Integrated Security=True"))
            {
                string query = "SELECT TOP 1 * FROM tblEstudiantes ORDER BY id DESC"; // Reemplaza "TuTabla" con el nombre de tu tabla y "TuColumna" con la columna que define el orden

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(dataSet);
            }

            return dataSet;
        }

    }
}
