using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desarrollo_Semana_7_IDS345L
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDCajaDataSet.tblCliente' table. You can move, or remove it, as needed.
            this.tblClienteTableAdapter.Fill(this.bDCajaDataSet.tblCliente);

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Form1 primeraForm = new Form1();
            primeraForm.Show();

            this.Hide();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 primeraForm = new Form1();
            primeraForm.Show();

            this.Hide();
        }
    }
}
