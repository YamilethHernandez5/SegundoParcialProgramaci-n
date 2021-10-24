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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Acceso account = new Acceso();



            dataGridView1.Columns.Add("_codUser", "codUser");
            dataGridView1.Columns.Add("_firtname", "firtname");
            dataGridView1.Columns.Add("_lastname", "lastname");
            dataGridView1.Columns.Add("_email", "email");
            dataGridView1.Columns.Add("_registerDate", "registerDate");
            dataGridView1.Columns.Add("_username", "username");
            dataGridView1.Columns.Add("_password", "password");

            if (button1.Enabled)
            {
                MySqlDataReader dataReader = Acceso.LogWithoutAdmin();

                while (dataReader.Read())
                {
                    dataGridView1.Rows.Add(

                            dataReader.GetValue(0),
                            dataReader.GetValue(1),
                            dataReader.GetValue(2),
                            dataReader.GetValue(3),
                            dataReader.GetValue(4),
                            dataReader.GetValue(5),
                            dataReader.GetValue(6)

                           );
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menú menú = new Menú();
            menú.Show();
            this.Hide();
        }
    }
}
