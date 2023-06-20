using System;
using System.Data;
using System.Data.SqlClient;

namespace RegistroAccionesPersonas
{
    class Program
    {
        static string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Adamg\\Desktop\\3D Objects\\C#\\Desarrollo_Software_III\\Laboratorio Semana 3 IDS345\\Laboratorio Semana 3 IDS345\\BDRegistroLenguajesAmor.mdf\";Integrated Security=True";

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("MENU");
                Console.WriteLine("1. Registrar persona");
                Console.WriteLine("2. Registrar acción");
                Console.WriteLine("3. Salir");
                Console.WriteLine("Seleccione una opción:");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        RegistrarPersona();
                        break;
                    case "2":
                        RegistrarAccion();
                        break;
                    case "3":
                        Console.WriteLine("Saliendo del programa...");
                        return;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            }
        }

        static void RegistrarPersona()
        {
            Console.WriteLine("Ingrese los datos de la persona:");
            Console.WriteLine("Tipo de Documento:");
            string tipoDocumento = Console.ReadLine();
            Console.WriteLine("Documento:");
            string documento = Console.ReadLine();
            Console.WriteLine("Nombres:");
            string nombres = Console.ReadLine();
            Console.WriteLine("Apellidos:");
            string apellidos = Console.ReadLine();
            Console.WriteLine("Fecha de Nacimiento (YYYY-MM-DD):");
            DateTime fechaNacimiento = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Parentesco:");
            string parentesco = Console.ReadLine();
            Console.WriteLine("Fecha de Ingreso (YYYY-MM-DD):");
            DateTime fechaIngreso = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Sexo:");
            string sexo = Console.ReadLine();
            Console.WriteLine("Estado:");
            string estado = Console.ReadLine();
            Console.WriteLine("Fecha de Última Acción (YYYY-MM-DD):");
            DateTime fechaUltimaAccion = DateTime.Parse(Console.ReadLine());

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    InsertarPersona(connection, transaction, tipoDocumento, documento, nombres, apellidos, fechaNacimiento, parentesco, fechaIngreso, sexo, estado, fechaUltimaAccion);

                    transaction.Commit();

                    Console.WriteLine("Persona registrada exitosamente.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al registrar la persona: " + ex.Message);

                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception exRollback)
                    {
                        Console.WriteLine("Error al hacer rollback de la transacción: " + exRollback.Message);
                    }
                }
            }
        }

        static void RegistrarAccion()
        {
            Console.WriteLine("Ingrese los datos de la acción:");
            Console.WriteLine("Tipo de Documento:");
            string tipoDocumento = Console.ReadLine();
            Console.WriteLine("Documento:");
            string documento = Console.ReadLine();
            Console.WriteLine("Tipo de Acción:");
            string tipoAccion = Console.ReadLine();
            Console.WriteLine("Fecha de Ingreso (YYYY-MM-DD):");
            DateTime fechaIngreso = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Nota:");
            string nota = Console.ReadLine();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    InsertarAccion(connection, transaction, tipoDocumento, documento, tipoAccion, fechaIngreso, nota);

                    transaction.Commit();

                    Console.WriteLine("Acción registrada exitosamente.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al registrar la acción: " + ex.Message);

                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception exRollback)
                    {
                        Console.WriteLine("Error al hacer rollback de la transacción: " + exRollback.Message);
                    }
                }
            }
        }

        static void InsertarPersona(SqlConnection connection, SqlTransaction transaction, string tipoDocumento, string documento, string nombres, string apellidos, DateTime fechaNacimiento, string parentesco, DateTime fechaIngreso, string sexo, string estado, DateTime fechaUltimaAccion)
        {
            using (SqlCommand command = new SqlCommand("InsertarPersona", connection, transaction))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@TipoDocumento", tipoDocumento);
                command.Parameters.AddWithValue("@Documento", documento);
                command.Parameters.AddWithValue("@Nombres", nombres);
                command.Parameters.AddWithValue("@Apellidos", apellidos);
                command.Parameters.AddWithValue("@Fecha_Nacimiento", fechaNacimiento);
                command.Parameters.AddWithValue("@Parentesco", parentesco);
                command.Parameters.AddWithValue("@Fecha_Ingreso", fechaIngreso);
                command.Parameters.AddWithValue("@Sexo", sexo);
                command.Parameters.AddWithValue("@Estado", estado);
                command.Parameters.AddWithValue("@Fecha_UltimaAccion", fechaUltimaAccion);

                command.ExecuteNonQuery();
            }
        }

        static void InsertarAccion(SqlConnection connection, SqlTransaction transaction, string tipoDocumento, string documento, string tipoAccion, DateTime fechaIngreso, string nota)
        {
            using (SqlCommand command = new SqlCommand("InsertarAccion", connection, transaction))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@TipoDocumento", tipoDocumento);
                command.Parameters.AddWithValue("@Documento", documento);
                command.Parameters.AddWithValue("@TipoAccion", tipoAccion);
                command.Parameters.AddWithValue("@FechaIngreso", fechaIngreso);
                command.Parameters.AddWithValue("@Nota", nota);

                command.ExecuteNonQuery();
            }
        }
    }
}
