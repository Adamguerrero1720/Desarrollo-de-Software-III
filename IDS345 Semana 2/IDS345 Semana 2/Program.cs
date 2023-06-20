using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;

namespace IDS345_Semana_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Adamg\\Desktop\\3D Objects\\C#\\Desarrollo_Software_III\\IDS345 Semana 2\\IDS345 Semana 2\\BDRegistroSismoTurquia-Siria.mdf\";Integrated Security=True");

            string Codigo_V = "", Direccion = "", Ciudad = "", Pais = "", Tipo = "", Fecha_Ingreso = "";
            int CantidadPersonas = 0;

            sqlConnection.Open();
            while (true) 
            {
                Console.Write("Codigo_Vivienda: ");
                Codigo_V = Console.ReadLine();

                Console.Write("Direccion: ");
                Direccion = Console.ReadLine();

                Console.Write("Ciudad: ");
                Ciudad = Console.ReadLine();

                Console.Write("Pais: ");
                Pais = Console.ReadLine();

                Console.Write("Tipo: ");
                Tipo = Console.ReadLine();

                Console.Write("Cantidad de Personas encontradas en la vivienda: ");
                int.TryParse(Console.ReadLine(), out CantidadPersonas);

                Console.Write("Fecha Ingreso del Registro: ");
                Fecha_Ingreso = Console.ReadLine();

                SqlCommand cmd = new SqlCommand();

                cmd.Connection = sqlConnection;
                cmd.CommandText = "Procedure_Viviendas";
                cmd.Parameters.AddWithValue("@Codigo_V", Codigo_V);
                cmd.Parameters.AddWithValue("@Direccion", Direccion);
                cmd.Parameters.AddWithValue("@Ciudad", Ciudad);
                cmd.Parameters.AddWithValue("@Pais", Pais);
                cmd.Parameters.AddWithValue("@Tipo", Tipo);
                cmd.Parameters.AddWithValue("@CantidadPersonas", CantidadPersonas);
                cmd.Parameters.AddWithValue("@Fecha_Ingreso", Fecha_Ingreso);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                int resultado = cmd.ExecuteNonQuery();

                Console.WriteLine(resultado);
                Console.ReadKey();
                Console.Clear();

                for (int i = 1; i <= CantidadPersonas; i++)
                {
                    string Nombres = "", Apellidos = "", Sexo = "", Edad = "", Estado = "", Codigo_Persona = "";

                    Console.Write("Nombre de la persona: ");
                    Nombres = Console.ReadLine();

                    Console.Write("Apellidos de la persona: ");
                    Apellidos = Console.ReadLine();

                    Console.Write("Sexo de la persona: ");
                    Sexo = Console.ReadLine();

                    Console.Write("Edad de la persona: ");
                    Edad = Console.ReadLine();

                    Console.Write("Estado de la persona: ");
                    Estado = Console.ReadLine();

                    Console.Write("Codigo de Persona: ");
                    Codigo_Persona = Console.ReadLine();

                    Console.Write("Fecha Ingreso: ");
                    Fecha_Ingreso = Console.ReadLine();

                    cmd.CommandText = "Procedure_Personas";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@Nombres", Nombres);
                    cmd.Parameters.AddWithValue("@Apellidos", Apellidos);
                    cmd.Parameters.AddWithValue("@Sexo", Sexo);
                    cmd.Parameters.AddWithValue("@Edad", Edad);
                    cmd.Parameters.AddWithValue("@Estado", Estado);
                    cmd.Parameters.AddWithValue("@Codigo_Persona", Codigo_Persona);
                    cmd.Parameters.AddWithValue("@Fecha_Ingreso", Fecha_Ingreso);

                    resultado = cmd.ExecuteNonQuery();

                    Console.WriteLine(resultado);
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}
