using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gerenciamento_de_funcionario
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
                    
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            DialogResult check = MessageBox.Show("Tem certeza que queira sair?","Mensagem de Confirmação", MessageBoxButtons.YesNo,  MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                Form1 frm = new Form1();
                frm.Show();
                this.Hide();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addfunc1.Visible = false;
            salario1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addfunc1.Visible = true;
            salario1.Visible = false;
        }

        private void DashBoard_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = true;
            addfunc1.Visible = false;
            salario1.Visible= false;
        }
    }
}
