using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace gerenciamento_de_funcionario
{
    public partial class addfunc : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\matto\OneDrive\Documentos\employee.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");
        public addfunc()
        {
            InitializeComponent();
            displayEmplyeeData();
        }
        public void displayEmplyeeData()
        {
            employeeData ed = new employeeData();
            List<employeeData> listData = ed.employeeListData();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void addbtn_adddunc_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(id_func_adddunc.Text) ||
                String.IsNullOrEmpty(nome_completo_adddunc.Text) ||
                String.IsNullOrEmpty(genero_adddunc.Text) ||
                String.IsNullOrEmpty(telefone_adddunc.Text) ||
                String.IsNullOrEmpty(status_adddunc.Text) ||
                fotos_adddunc.Image == null) 

            {
                MessageBox.Show("Favor preencher algo que esteja faltando", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed) 
                {
                    try
                    {
                        connect.Open();
                        string checkEmId = "select * form emplyees where id_funcionario = @EmId ";

                        using (SqlCommand cmd = new SqlCommand(checkEmId, connect))
                        {

                            int count =  (int)cmd.ExecuteScalar();
                            if (count > 1)
                            {

                                MessageBox.Show(id_func_adddunc.Text.Trim() + "erro", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);


                            }
                            else
                            {
                                DateTime today = DateTime.Today;
                                string insertData = "insert into emplyees" + "(id_funcionario, full_name, genero, numero_contato" +
                                    "posisao, image, salario, insert_date, status )"+
                                    "values(@idfunc, @fullname,@genero, @numeroContato, @posisao, @image, @salario, @insertData, @status)";

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@idfunc", id_func_adddunc.Text.Trim());
                                    cmd.Parameters.AddWithValue("@fullname", nome_completo_adddunc.Text.Trim());
                                    cmd.Parameters.AddWithValue(",@genero", genero_adddunc.Text.Trim());
                                    cmd.Parameters.AddWithValue("@numeroContato", telefone_adddunc.Text.Trim());
                                    cmd.Parameters.AddWithValue("@posisao", posisao_addfunc.Text.Trim());
                                    cmd.Parameters.AddWithValue("@image", importar_adddunc.Text.Trim());
                                    cmd.Parameters.AddWithValue("@insertData", today);
                                    cmd.Parameters.AddWithValue("@status", status_adddunc.Text.Trim());
                                }
                            }

                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Error connection" + ex );
                    }
                    finally 
                    {
                        connect.Close();

                    }




                };
            }
        }
    }
}
