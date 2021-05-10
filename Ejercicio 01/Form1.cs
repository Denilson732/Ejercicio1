using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.Rows.Add();

            dataGridView1.Rows[0].Cells[0].Value = txtNombre.Text;
            dataGridView1.Rows[0].Cells[1].Value = txtEdad.Text;
        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
