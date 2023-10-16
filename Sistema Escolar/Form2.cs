using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Escolar
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void registroEstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registroDocenteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 fc = new Form1();
            this.Hide();
            fc.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 fc = new Form4();
            this.Hide();
            fc.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 fc = new Form5();
            this.Hide();
            fc.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 fc = new Form6();
            this.Hide();
            fc.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
