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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HealthCheck
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "healthcheck";
            scsb.IntegratedSecurity = true;


            GlobalVar.strDBConnectionString = scsb.ConnectionString.ToString();
        }

        private void btn登入系統_Click(object sender, EventArgs e)
        {

            string str身分證字號 = txt登入欄位1.Text.Trim();
            string str密碼 = txt登入欄位2.Text.Trim();

            if ((str身分證字號 != "") && (str密碼 != ""))
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();

                string strSQL = "select * from users where 身分證字號=@SearchPassId and 密碼=@SearchPassword;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
      
                cmd.Parameters.AddWithValue("@SearchPassId", str身分證字號);
                cmd.Parameters.AddWithValue("@SearchPassword", str密碼);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                { //登入成功
                    GlobalVar.is登入成功 = true;
                    GlobalVar.userId = (int)reader["UserID"];
                    GlobalVar.userName = reader["姓名"].ToString();
                    GlobalVar.使用者權限 = (int)reader["UserID"];
           
                    MessageBox.Show("登入成功");
                    reader.Close();
                    con.Close();
                    this.Close();
                }

                if (GlobalVar.is登入成功 == false)
                {
                    MessageBox.Show("登入資料有誤\n請重新登入");
                }
                reader.Close();
                con.Close();
            }

            else
            {
                MessageBox.Show("登入欄位必填 !!");
            }
        }

        private void btn會員註冊_Click(object sender, EventArgs e)
        {
            Form2 myForm2= new Form2();
            myForm2.ShowDialog();
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (GlobalVar.is登入成功)
            {
               
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
