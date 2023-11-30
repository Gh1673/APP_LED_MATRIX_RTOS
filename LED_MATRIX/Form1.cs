using System.Windows.Forms;
using System;
using System.Reflection.Emit;


namespace LED_MATRIX
{
    public partial class LEDMATRIX : Form
    {
        public LEDMATRIX()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            controll.BackColor = System.Drawing.Color.Transparent;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.BackColor = System.Drawing.Color.Transparent;
        }

        private void backgroundWorker2_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void LEDMATRIX_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.BorderStyle = BorderStyle.FixedSingle;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}