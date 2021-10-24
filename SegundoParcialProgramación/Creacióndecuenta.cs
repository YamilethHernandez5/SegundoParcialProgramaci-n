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
    public partial class Creacióndecuenta : Form
    {
        public Creacióndecuenta()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (maskedTextBox5.Text != maskedTextBox6.Text)
            {
                MetroFramework.MetroMessageBox.Show(this,
                    "Las contraseñas no son iguales", "Nueva cuenta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (maskedTextBox1.Text == "")
            {
                maskedTextBox1.Focus();
                errorProvider1.SetError(maskedTextBox1, "Escriba un nombre");
            }
            else if (maskedTextBox2.Text == "")
            {
                maskedTextBox2.Focus();
                errorProvider1.SetError(maskedTextBox2, "Escriba un apellido");
            }
            else if (maskedTextBox3.Text == "")
            {
                maskedTextBox3.Focus();
                errorProvider1.SetError(maskedTextBox3, "Escriba un correo");
            }
            else if (maskedTextBox4.Text == "")
            {
                maskedTextBox4.Focus();
                errorProvider1.SetError(maskedTextBox4, "Escriba un usuario");
            }
            else if (maskedTextBox5.Text == "")
            {
                maskedTextBox5.Focus();
                errorProvider1.SetError(maskedTextBox5, "Escriba una contraseña");
            }
            else if (maskedTextBox6.Text == "")
            {
                maskedTextBox6.Focus();
                errorProvider1.SetError(maskedTextBox6, "Escriba una contraseña");
            }
            else
            {
                Account Account = new Account();

                Account.getAll();
                Account._firtname = maskedTextBox1.Text;
                Account._lastname = maskedTextBox2.Text;
                Account._email = maskedTextBox3.Text;
                Account._registerDate = DateTime.Now.ToString("dddd, dd MMM yyy HH:mm:ss");
                Account._username = maskedTextBox4.Text;
                Account._password = maskedTextBox5.Text;
                Account.REGISTRARCUENTA();

                MetroFramework.MetroMessageBox.Show(this,
                    "Usuario registrado", "Nueva cuenta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 form1 = new Form1();
                form1.Show();



            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Creacióndecuenta creacióndecuenta = new Creacióndecuenta();
            creacióndecuenta.Show();
            this.Hide();
        }
    }
}
