using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {

            try
            {
                string sql = "INSERT INTO TESTTABLE(name,age) VALUES(@name,@age)";
                ExecuteInsert(sql,new string[] {"@name","@age"}, new string[] { name.Text, age.Text });
                MessageBox.Show("OK");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ExecuteInsert(string query, string[] ParamName, string[] values)
        {
            string connStr = "Data Source=" + Environment.MachineName + ";Initial Catalog = testdb;Integrated Security=SSPI; User ID = " + Environment.MachineName + @"\" + Environment.UserName + "; Password =";
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlParameter[] Param = new SqlParameter[ParamName.Length];
            SqlCommand cmd = new SqlCommand(query, conn);
            for (int c = 0; c < ParamName.Length; c++)
            {
                Param[c] = new SqlParameter();
            }

            for (int i = 0; i < ParamName.Length; i++)
            {
                Param[i].ParameterName = ParamName[i];
                Param[i].Value = values[i];
                cmd.Parameters.Add(Param[i]);
            }
            cmd.ExecuteNonQuery();

        }
    }
}
