using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SegundoParcialProgramación
{
    public partial class Acceso : Form
    {
        public Acceso()
        {
            InitializeComponent();
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

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void Acceso_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Creacióndecuenta crearcuenta = new Creacióndecuenta();
            crearcuenta.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Account login = new Account();
            login._username = maskedTextBox1.Text;



            if (login.login())
            {
                MetroFramework.MetroMessageBox.Show(this,
                    "BIENVENIDO", "USUARIO YA REGISTRADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                login.Insertarlog();
                _username = maskedTextBox1.Text;

                Menu Menu = new Menu();
                Menu.Show();


            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this,
                   "NOMBBRE DE USUARIO O CONTRASEÑA NO REGISTRADOS ", "ENTRAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (maskedTextBox1.Text == "")
            {
                maskedTextBox1.Focus();
                errorProvider1.SetError(maskedTextBox1, "Escriba un nombre");
            }

            else if (maskedTextBox2.Text == "")
            {
                maskedTextBox1.Focus();
                errorProvider2.SetError(maskedTextBox1, "Escriba un nombre");
            }


        }

    }
}

