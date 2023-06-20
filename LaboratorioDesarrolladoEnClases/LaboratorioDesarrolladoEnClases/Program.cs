using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioDesarrolladoEnClases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Adamg\\Desktop\\3D Objects\\C#\\Desarrollo_Software_III\\LaboratorioDesarrolladoEnClases\\LaboratorioDesarrolladoEnClases\\BDRevisionColegios.mdf\";Integrated Security=True";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                    Console.WriteLine("Conexión a la base de datos establecida.");

                    while (true)
                    {
                        Console.Write("Codigo del colegio: ");
                        string codigoColegio = Console.ReadLine();

                        Console.Write("Nombre Colegio: ");
                        string nombreColegio = Console.ReadLine();

                        Console.Write("Fecha de Ingreso Registro: ");
                        string fechaIngresoRegistro = Console.ReadLine();

                        Console.Write("Fecha Fundacion Colegio: ");
                        string fechaFundacionColegio = Console.ReadLine();

                        Console.Write("Direccion Colegio: ");
                        string direccionColegio = Console.ReadLine();

                        Console.Write("Telefono_Colegio: ");
                        string telefonoColegio = Console.ReadLine();

                        Console.Write("Fecha Ultima Revision: ");
                        string fechaUltimaRevision = Console.ReadLine();

                        Console.Write("Estado: ");
                        string estado = Console.ReadLine();

                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = sqlConnection;
                        cmd.CommandText = "Procedure_Colegio";
                        cmd.Parameters.AddWithValue("@Codigo_Colegio", codigoColegio);
                        cmd.Parameters.AddWithValue("@Nombre_Colegio", nombreColegio);
                        cmd.Parameters.AddWithValue("@Fecha_IngresoRegistro", fechaIngresoRegistro);
                        cmd.Parameters.AddWithValue("@Fecha_FundacionColegio", fechaFundacionColegio);
                        cmd.Parameters.AddWithValue("@Direccion_Colegio", direccionColegio);
                        cmd.Parameters.AddWithValue("@Telefono_Colegio", telefonoColegio);
                        cmd.Parameters.AddWithValue("@Fecha_UltimaRevision", fechaUltimaRevision);
                        cmd.Parameters.AddWithValue("@Estado", estado);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        int resultado = cmd.ExecuteNonQuery();

                        Console.WriteLine(resultado);
                        Console.ReadKey();
                        Console.Clear();

                        string Codigo_Colegio1 = "", Descripcion_Encontrado = "", Tipo = "", Fecha_Allanamiento = "", Responsable = "", Nota = "", Estado1 = "";


                        Console.Write("Codigo del Colegio: ");
                        Codigo_Colegio1 = Console.ReadLine();

                        Console.Write("Descripcion Encontrado: ");
                        Descripcion_Encontrado = Console.ReadLine();

                        Console.Write("Tipo: ");
                        Tipo = Console.ReadLine();

                        Console.Write("Fecha Allanamiento: ");
                        Fecha_Allanamiento = Console.ReadLine();

                        Console.Write("Responsable: ");
                        Responsable = Console.ReadLine();

                        Console.Write("Nota: ");
                        Nota = Console.ReadLine();

                        Console.Write("Estado: ");
                        Estado1 = Console.ReadLine();

                        cmd.Connection = sqlConnection;
                        cmd.CommandText = "Procedure_Allanamiento";
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@Codigo_Colegio1", Codigo_Colegio1);
                        cmd.Parameters.AddWithValue("@Descripcion_Encontrado", Descripcion_Encontrado);
                        cmd.Parameters.AddWithValue("@Tipo", Tipo);
                        cmd.Parameters.AddWithValue("@Fecha_Allanamiento", Fecha_Allanamiento);
                        cmd.Parameters.AddWithValue("@Responsable", Responsable);
                        cmd.Parameters.AddWithValue("@Nota", Nota);
                        cmd.Parameters.AddWithValue("@Estado", Estado1);

                        resultado = cmd.ExecuteNonQuery();

                        Console.WriteLine(resultado);
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al conectar con la base de datos: " + ex.Message);
                }
                finally
                {
                    sqlConnection.Close();
                    Console.WriteLine("Conexión cerrada.");
                }
            }

            Console.ReadKey();
        }
    }
}