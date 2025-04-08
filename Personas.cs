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
    public partial class Personas : Form
    {
        public Personas()
        {
            InitializeComponent();
        }

        private void Personas_Load(object sender, EventArgs e)
        {
            GetData();
        }


        private void gvPersonas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Seleccionar numero de fila de la celda seleccionada
            int selectdrowindex = gvPersonas.SelectedCells[0].RowIndex;
            //Por medio del index seleciona toda la fila
            DataGridViewRow selectRow = gvPersonas.Rows[selectdrowindex];
            //Extrae el valor de todas las celdas 
            string idPersona = selectRow.Cells["id"].Value.ToString();
            string nombre = selectRow.Cells["nombre"].Value.ToString();
            string apellidos = selectRow.Cells["apellidos"].Value.ToString();
            string ciudad = selectRow.Cells["ciudad"].Value.ToString();

            tbNombre.Text = nombre;
            tbApellidos.Text = apellidos;
            tbCiudad.Text = ciudad;
            lbID2.Text = idPersona;
        }

        private void tbActualizar_Click(object sender, EventArgs e)
        {
            string nombre = tbNombre.Text;
            string apellidos = tbApellidos.Text;
            string ciudad = tbCiudad.Text;
            string id = lbID2.Text;

            MySqlConnection conn = new MySqlConnection("server=127.0.0.1;uid=root;pwd=1102;database=pruebas");
            MySqlCommand comm = new MySqlCommand($"update personas set nombre='{nombre}',apellidos='{apellidos}',ciudad='{ciudad}'" + 
                $"where id={id};",conn);
            comm.CommandType = CommandType.Text;
            try
            {
                conn.Open();
                comm.ExecuteNonQuery();
                GetData();
                MessageBox.Show("Actualizado Correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();

            }
        }

        private void GetData()
        {

            MySqlConnection conn = new MySqlConnection("server=127.0.0.1;uid=root;pwd=1102;database=pruebas");
            MySqlCommand comm = new MySqlCommand("select * from personas;", conn);
            comm.CommandType = CommandType.Text;
            try
            {
                //Abrir conexion de bate de datos
                DataTable DTPersonas = new DataTable();
                conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(comm);
                //Llenar tabla de datos 
                da.Fill(DTPersonas);
                //Llenar el DataGridView con informacion 
                gvPersonas.DataSource = DTPersonas;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {   //Cerrar conexion base de datos
                conn.Close();
            }

        }


    }
}
