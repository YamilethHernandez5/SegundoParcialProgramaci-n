using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundoParcialProgramación
{
    public partial class Menú : Form
    {
        public Menú()
        {
            InitializeComponent();
        }

        private void iRALLOGINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Creacióndecuenta creacióndecuenta = new Creacióndecuenta();
            creacióndecuenta.Show();
            this.Hide();
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("¿DESEA SALIR?", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (opcion == DialogResult.OK)
            {

                Close();
            }
        }

        private void Menú_Load(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Perfiladministrador perfiladmi = new Perfiladministrador();
            perfiladmi.Show();
            this.Hide();
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios();
            usuarios.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Registros registros = new Registros();
            registros.Show();
            this.Hide();
        }
    }
}
