using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_base_de_datos
{
    public partial class Interfaz : Form
    {
        public Interfaz()
        {
            InitializeComponent();
        }

        private void Interfaz_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 add = new Form1();
            add.Show();
        }

        private void Personas_Click(object sender, EventArgs e)
        {
            Personas personas = new Personas();
            personas.Show();
        }
    }
}
