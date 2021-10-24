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
    public partial class Registros : Form
    {
        public Registros()
        {
            InitializeComponent();
        }

        private void Registros_Load(object sender, EventArgs e)
        {
            filldata();
        }

        public void filldata()
        {
            cleardatagrid();

            Acceso acceso = new Acceso();
            dataGridView1.Columns.Add("_username", "username");
            dataGridView1.Columns.Add("_timeLoggedIn", "timeLoggedIn");

            if (metroToggle1.Checked)
            {
                MySqlDataReader dataReader = acceso.getLog();
                while (dataReader.Read())
                {
                    dataGridView1.Rows.Add(
                        dataReader.GetValue(1),
                        dataReader.GetValue(2)
                        );
                }
            }
            else
            {
                MySqlDataReader dataReader = acceso.getLogWithoutAdmin();
                while (dataReader.Read())
                {
                    dataGridView1.Rows.Add(
                        dataReader.GetValue(1),
                        dataReader.GetValue(2)
                        );


                }

            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroToggle1_CheckedChanged(object sender, EventArgs e)
        {
            filldata();
        }

        private void cleardatagrid()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menú menú = new Menú();
            menú.Show();
            this.Hide();
        }
    }
  
}

