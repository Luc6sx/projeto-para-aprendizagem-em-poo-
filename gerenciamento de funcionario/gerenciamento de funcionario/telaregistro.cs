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
using System.Runtime.Remoting.Contexts;

namespace gerenciamento_de_funcionario
{
    
    public partial class telaregistro : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\matto\OneDrive\Documentos\employee.mdf;Integrated Security=True;Connect Timeout=30");
        public telaregistro()
        {
            InitializeComponent();
        }
        private void login_showp_CheckedChanged(object sender, EventArgs e)
        {
            register_password.PasswordChar = register_showp.Checked ? '\0' : '*';
        }

        private void login_fecha_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void register_singin_Click(object sender, EventArgs e)
        {
            Form1 telalog = new Form1();
            telalog.Show();
            this.Hide();
        }

        private void register_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(register_username.Text) || string.IsNullOrEmpty(register_password.Text))  
            {
                MessageBox.Show("Favor preencher os campos de username e password", "Error Message",MessageBoxButtons.OK,MessageBoxIcon.Error );

            }
            else
            {
                if(connect.State != ConnectionState.Open)
                {
                    //Para conferir se o  usuario já é existente
                    try
                    {
                        connect.Open();

                        string selectUsername = "SELECT COUNT(id) FROM funcionarios WHERE username = @user ";

                        using (SqlCommand checkUser = new SqlCommand(selectUsername, connect))
                        {
                            checkUser.Parameters.AddWithValue("@user", register_username.Text.Trim());
                            int count = (int)checkUser.ExecuteScalar();

                            if (count > 0)
                            {
                                MessageBox.Show(register_username.Text.Trim() +"Usuario ja existente", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                DateTime today = DateTime.Today;

                                string insertData = "INSERT INTO funcionarios" +
                                    "( username,password,data_de_registro ) " +
                                    "VALUES (@username,@password, @dateReg)";

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@username", register_username.Text.Trim());
                                    cmd.Parameters.AddWithValue("@password", register_password.Text.Trim());
                                    cmd.Parameters.AddWithValue("@dateReg", today);

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Registrado com sucesso", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                                }
                            }
                        }


                            
                    }
                    catch(Exception ex)
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
