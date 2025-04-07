using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace Practica_base_de_datos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btRegistrar_Click(object sender, EventArgs e)
        {
            string nombre = tbNombre.Text;
            string apellidos = tbApellidos.Text;
            string ciudad = tbCiudad.Text;

            MySqlConnection conn = new MySqlConnection("server=127.0.0.1;uid=root;pwd=1102;database=pruebas");
            MySqlCommand comm = new MySqlCommand("insert into personas(nombre,apellidos,ciudad)" + $"values ('{nombre}','{apellidos}','{ciudad}');", conn);
            comm.CommandType = CommandType.Text;
            try
            {
                conn.Open();
                comm.ExecuteNonQuery();
                MessageBox.Show("Guardado Correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();

            }
            
            

        }
    }
}
