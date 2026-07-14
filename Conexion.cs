using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EduCafeProyecto
{
    internal class Conexion
    {

        private readonly string Cadena;

        //constructor
        public Conexion()
        {
            Cadena = "Server=127.0.0.1; Database=CafeteriaEscolar; Uid=root; Pwd=; Port=3306;";
        }

        //metodo para conectar a la base de datos
        public MySqlConnection GetConeccion()
        {
            try
            {
                MySqlConnection con = new MySqlConnection(Cadena);
                con.Open();
                MessageBox.Show("Conexion Exitosa...");
                return con;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("error al conectarse con la base de datos \n" + ex.Message);
                return null;
            }
        }
    }
}
