using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bem vindo ao programa");
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Deseja realmente sair?","Confirmação", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) {
                this.Close();            
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void FormMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'o' )
            {
                var Form = new Form1();
                Form.Show();
                this.Close();
            }
        }
    }
}
