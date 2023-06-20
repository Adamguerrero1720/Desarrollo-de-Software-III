using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using log4net;
using log4net.Config;
using System.Configuration;

namespace Laboratorio_Semana_4_IDS345
{
    internal class Program
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Program));
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;

        static void Main(string[] args)
        {
            XmlConfigurator.Configure(new System.IO.FileInfo("log4net.config"));

            bool running = true;

            while (running)
            {
                Console.WriteLine("=== Día de las Madres App ===");
                Console.WriteLine("1. Crear madre");
                Console.WriteLine("2. Crear cuenta");
                Console.WriteLine("3. Depositar monto");
                Console.WriteLine("4. Retirar monto");
                Console.WriteLine("5. Salir");
                Console.WriteLine("=============================");

                Console.Write("Ingrese una opción: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        CrearMadre();
                        break;
                    case "2":
                        CrearCuenta();
                        break;
                    case "3":
                        DepositarMonto();
                        break;
                    case "4":
                        RetirarMonto();
                        break;
                    case "5":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Por favor, ingrese una opción válida.");
                        break;
                }

                Console.WriteLine();
            }
        }

        private static void CrearMadre()
        {
            Console.WriteLine("=== Crear Madre ===");

            Console.Write("Tipo de documento: ");
            string tipoDocumento = Console.ReadLine();

            Console.Write("Número de documento: ");
            string documento = Console.ReadLine();

            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Apellido: ");
            string apellido = Console.ReadLine();

            Console.Write("Sexo: ");
            string sexo = Console.ReadLine();

            Console.Write("Fecha de ingreso (yyyy-mm-dd): ");
            DateTime fechaIngreso = DateTime.Parse(Console.ReadLine());

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("CrearMadre", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@tipoDocumento", tipoDocumento);
                    command.Parameters.AddWithValue("@documento", documento);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@apellido", apellido);
                    command.Parameters.AddWithValue("@sexo", sexo);
                    command.Parameters.AddWithValue("@fechaIngreso", fechaIngreso);

                    command.ExecuteNonQuery();

                    Console.WriteLine("Madre creada exitosamente.");
                    log.Info("Se ha creado una nueva madre: " + nombre + " " + apellido);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al crear la madre.");
                log.Error("Error al crear una nueva madre.");
            }
        }

        private static void CrearCuenta()
        {
            Console.WriteLine("=== Crear Cuenta ===");

            Console.Write("Tipo de documento de la madre: ");
            string tipoDocumento = Console.ReadLine();

            Console.Write("Número de documento de la madre: ");
            string documento = Console.ReadLine();

            Console.Write("Código de cuenta: ");
            string codigoCuenta = Console.ReadLine();

            Console.Write("Fecha de apertura (yyyy-mm-dd): ");
            DateTime fechaApertura = DateTime.Parse(Console.ReadLine());

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("CrearCuenta", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@tipoDocumento", tipoDocumento);
                    command.Parameters.AddWithValue("@documento", documento);
                    command.Parameters.AddWithValue("@codigo", codigoCuenta);
                    command.Parameters.AddWithValue("@fechaApertura", fechaApertura);

                    command.ExecuteNonQuery();

                    Console.WriteLine("Cuenta creada exitosamente.");
                    log.Info("Se ha creado una nueva cuenta: " + codigoCuenta);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al crear la cuenta.");
                log.Error("Error al crear una nueva cuenta.");
            }
        }

        private static void DepositarMonto()
        {
            Console.WriteLine("=== Depositar Monto ===");

            Console.Write("Código de cuenta: ");
            string codigoCuenta = Console.ReadLine();

            Console.Write("Monto a depositar: ");
            decimal monto = decimal.Parse(Console.ReadLine());

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("DepositarMonto", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@codigoCuenta", codigoCuenta);
                    command.Parameters.AddWithValue("@monto", monto);

                    command.ExecuteNonQuery();

                    Console.WriteLine("Monto depositado exitosamente.");
                    log.Info("Se ha depositado el monto " + monto + " en la cuenta " + codigoCuenta);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al depositar el monto.");
                log.Error("Error al depositar el monto.");
            }
        }

        private static void RetirarMonto()
        {
            Console.WriteLine("=== Retirar Monto ===");

            Console.Write("Código de cuenta: ");
            string codigoCuenta = Console.ReadLine();

            Console.Write("Monto a retirar: ");
            decimal monto = decimal.Parse(Console.ReadLine());

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("sp_RetirarMonto", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@codigoCuenta", codigoCuenta);
                    command.Parameters.AddWithValue("@monto", monto);

                    command.ExecuteNonQuery();

                    Console.WriteLine("Monto retirado exitosamente.");
                    log.Info("Se ha retirado el monto " + monto + " de la cuenta " + codigoCuenta);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al retirar el monto.");
                log.Error("Error al retirar el monto.");
            }
        }
    }
}
