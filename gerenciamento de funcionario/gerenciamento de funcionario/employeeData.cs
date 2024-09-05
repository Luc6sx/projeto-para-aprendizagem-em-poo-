using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace gerenciamento_de_funcionario
{
    internal class employeeData
    {
        public int id { get; set; }
        public string id_funcionario { get; set; }
        public string full_name { get; set; }
        public string genero { get; set; }
        public string numero_contato { get; set; }

        public string posisao { get; set; }
        public string image { get; set; }
        public int salario { get; set; }
        public string status { get; set; }


        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\matto\OneDrive\Documentos\employee.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");

        public List<employeeData> employeeListData()
        {
            List<employeeData> listdata = new List<employeeData>();

            if(connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    
                    string selectData = "select * from emplyee where delete_date is null ";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            employeeData ed = new employeeData();
                            ed.id = (int)reader["id"];
                            ed.id_funcionario = reader["id_funcionario"].ToString();
                            ed.full_name = reader["full_name"].ToString();
                            ed.genero = reader["genero"].ToString();
                            ed.posisao = reader["posisao"].ToString();
                            ed.image = reader["image"].ToString();
                            ed.salario = (int)reader["salario"];
                            ed.status = reader["status"].ToString();

                            listdata.Add(ed);

                        }


                    }




                }
                catch(Exception ex)
                {
                    Console.WriteLine("Error: " + ex);
                }
                finally
                {

                }
                return listdata;
            }
        }
    }
}
