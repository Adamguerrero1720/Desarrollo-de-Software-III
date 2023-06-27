using Amazon.Rekognition;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Amazon.Rekognition.Model;
using System.Globalization;

namespace Desarrollo_Semana_8_IDSL345
{
    public partial class Form1 : Form
    {
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\3D Objects\\C#\\Desarrollo_Software_III\\Desarrollo-de-Software-III\\Desarrollo Semana 8 IDSL345\\Desarrollo Semana 8 IDSL345\\BDAdmision.mdf\";Integrated Security=True";
        private byte[] imagenBytes;
        private AmazonRekognitionClient rekognitionClient;
        public Form1()
        {
            InitializeComponent();

            var credentials = new Amazon.Runtime.BasicAWSCredentials("AKIAIE5LZMZN4CR6IO5Q", "xUtzMH5IxZmuZYrc9KSN83JE+pgf5J60+FajM65J");
            var config = new AmazonRekognitionConfig
            {
                RegionEndpoint = Amazon.RegionEndpoint.USWest2
            };
            rekognitionClient = new AmazonRekognitionClient(credentials, config);
        }

        private void bton_Registrar_Click(object sender, EventArgs e)
        {
            if (imagenBytes == null)
            {
                MessageBox.Show("Por favor, carga una imagen antes de registrar.");
                return;
            }

            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\3D Objects\\C#\\Desarrollo_Software_III\\Desarrollo-de-Software-III\\Desarrollo Semana 8 IDSL345\\Desarrollo Semana 8 IDSL345\\BDAdmision.mdf\";Integrated Security=True"))
            {
                using (SqlCommand command = new SqlCommand("InsertarRegistro", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Agregar los parámetros del stored procedure
                    command.Parameters.AddWithValue("@TipoDocumento", cb_TipoDocumento.Text);
                    command.Parameters.AddWithValue("@Documento", txt_Documento.Text);
                    command.Parameters.AddWithValue("@Nombres", txt_Nombre.Text);
                    command.Parameters.AddWithValue("@Apellidos", txt_Apellido.Text);
                    command.Parameters.AddWithValue("@FechaNacimiento", dtp_Fecha.Value);
                    command.Parameters.AddWithValue("@FechaIngreso", dtp_Fecha.Value);
                    command.Parameters.AddWithValue("@Carrera", txt_Carrera.Text);
                    command.Parameters.AddWithValue("@Sexo", cb_Sexo.Text);
                    command.Parameters.AddWithValue("@Estado", cbEstado.Text);
                    command.Parameters.AddWithValue("@MontoPagoInscripcion", txtMontoPagoInscripcion.Text);
                    command.Parameters.AddWithValue("@Foto", imagenBytes);

                    connection.Open();
                    command.ExecuteNonQuery();

                    MessageBox.Show("Los datos han sido insertados correctamente.");

                    Limpiar();

                    Form2 formulario = new Form2();
                    formulario.Show();
                    this.Hide();
                }
            }
        }

        private byte[] ObtenerBytesDeImagen()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif|Todos los archivos|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string rutaImagen = openFileDialog.FileName;
                    byte[] imagenBytes;

                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        using (FileStream fileStream = new FileStream(rutaImagen, FileMode.Open, FileAccess.Read))
                        {
                            fileStream.CopyTo(memoryStream);
                        }

                        imagenBytes = memoryStream.ToArray();
                    }

                    return imagenBytes;
                }
            }

            // Retorna null si no se seleccionó ninguna imagen
            return null;
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
        private void Form1_Load(object sender, EventArgs e)
        {
            cb_Sexo.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_TipoDocumento.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            CargarOpcionesTipoDoc();
            CargarOpcionesSexo();
            CargarOpcionesEstado();
        }

        private void CargarOpcionesTipoDoc()
        {
            // Aquí puedes cargar las opciones en el ComboBox desde alguna fuente de datos
            cb_TipoDocumento.Items.Add("Cédula");
            cb_TipoDocumento.Items.Add("Pasaporte");
        }

        private void CargarOpcionesSexo()
        {
            // Aquí puedes cargar las opciones en el ComboBox desde alguna fuente de datos
            cb_Sexo.Items.Add("Femenino");
            cb_Sexo.Items.Add("Masculino");
        }

        private void cb_TipoDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignora el carácter ingresado
            }
        }

        private void txt_Documento_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignora el carácter ingresado
            }
        }

        private void txt_Nombre_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Ignora el carácter ingresado
            }
        }

        private void txt_Apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Ignora el carácter ingresado
            }
        }

        private void txt_Carrera_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Ignora el carácter ingresado
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_Documento_TextChanged_1(object sender, EventArgs e)
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

        private void bton_Limpiar_Click(object sender, EventArgs e)
        {
            cb_TipoDocumento.SelectedIndex = -1;
            txt_Documento.Clear();
            txt_Nombre.Clear();
            txt_Apellido.Clear();
            dtp_Fecha.Value = DateTime.Today;
            dtp_FechaIngreso.Value = DateTime.Today;
            txt_Carrera.Clear();
            cb_Sexo.SelectedIndex = -1;
            txtMontoPagoInscripcion.Clear();
            cbEstado.SelectedIndex = -1;
        }

        private void Limpiar()
        {
            cb_TipoDocumento.SelectedIndex = -1;
            txt_Documento.Clear();
            txt_Nombre.Clear();
            txt_Apellido.Clear();
            txt_Carrera.Clear();
            cb_Sexo.SelectedIndex = -1;
            txtMontoPagoInscripcion.Clear();
            cbEstado.SelectedIndex = -1;
        }

        private void bton_Cargar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif|Todos los archivos|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string rutaImagen = openFileDialog.FileName;

                    try
                    {
                        // Llama a la función para detectar famosos
                        DetectarFamosos(openFileDialog.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cargar la imagen: " + ex.Message);
                    }

                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        using (FileStream fileStream = new FileStream(rutaImagen, FileMode.Open, FileAccess.Read))
                        {
                            fileStream.CopyTo(memoryStream);
                        }

                        imagenBytes = memoryStream.ToArray();
                    }

                    MessageBox.Show("La imagen se ha cargado correctamente.");
                }
            }
        }



        private void DetectarFamosos(string filePath)
        {
            try
            {
                // Lee la imagen desde el archivo
                byte[] imageData = File.ReadAllBytes(filePath);

                // Llama a la función RecognizeCelebrities
                RecognizeCelebritiesRequest request = new RecognizeCelebritiesRequest
                {
                    Image = new Amazon.Rekognition.Model.Image
                    {
                        Bytes = new MemoryStream(imageData)
                    }
                };

                RecognizeCelebritiesResponse response = rekognitionClient.RecognizeCelebrities(request);

                // Verifica si se detectó algún famoso
                if (response.CelebrityFaces.Count > 0)
                {
                    string famosos = string.Join(", ", response.CelebrityFaces.ConvertAll(x => x.Name));
                    MessageBox.Show("Se detectaron los siguientes famosos: " + famosos);

                    // Aplica el descuento del 10% al monto fijo de 10000
                    double montoFijo = 10000;
                    double descuento = montoFijo * 0.1;
                    double montoConDescuento = montoFijo - descuento;

                    MessageBox.Show("Se aplicó un descuento del 10%. Monto a pagar con descuento: $" + montoConDescuento);

                    // Establece el monto con descuento en el control TextBox
                    txtMontoPagoInscripcion.Text = montoConDescuento.ToString();
                }
                else
                {
                    MessageBox.Show("No se detectaron famosos en la imagen.");

                    // Cobra el monto fijo de 10000 sin aplicar descuento
                    double montoFijo = 10000;

                    MessageBox.Show("Monto a pagar: $" + montoFijo);

                    // Establece el monto sin descuento en el control TextBox
                    txtMontoPagoInscripcion.Text = montoFijo.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al detectar famosos: " + ex.Message);
            }
        }

        private void CargarOpcionesEstado()
        {
            // Aquí puedes cargar las opciones en el ComboBox desde alguna fuente de datos
            cbEstado.Items.Add("Aprobado");
            cbEstado.Items.Add("Rechazado");
        }

        private void txtMontoPagoInscripcion_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
