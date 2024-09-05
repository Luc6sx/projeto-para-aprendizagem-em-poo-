using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace gerenciamento_de_funcionario
{
    public partial class Form1 : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\matto\OneDrive\Documentos\employee.mdf;Integrated Security=True;Connect Timeout=30");

        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void login_singup_Click(object sender, EventArgs e)
        {
            telaregistro telareg = new telaregistro();
            telareg.Show();
            this.Hide();
        }

        private void login_showp_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_showp.Checked ? '\0' : '*' ;
        }

        private void login_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(login_password.Text) || string.IsNullOrEmpty(login_username.Text))
            {
                MessageBox.Show("Favor prencher os campos de username e password"
                    , "Error message" , MessageBoxButtons.OK , MessageBoxIcon.Error) ;
            }
            else
            {
                if(connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();

                        string selectData = "SELECT * FROM funcionarios WHERE username = @username AND password = @password";

                        using(SqlCommand cmd = new SqlCommand(selectData, connect)) 
                        {
                            cmd.Parameters.AddWithValue("@username", login_username.Text.Trim());
                            cmd.Parameters.AddWithValue("@password", login_password.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if(table.Rows.Count >= 1)
                            {
                                MessageBox.Show("Logado com sucesso" , "Information Message" , MessageBoxButtons.OK , MessageBoxIcon.Information);

                                Form2 form2 = new Form2();
                                form2.Show();
                                this.Hide();

                            }
                            else
                            {
                                MessageBox.Show("Usuario ou senha Incorretas" , "Information Message" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
                
                
            }
        }
    }
}
