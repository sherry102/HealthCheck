using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCheck
{
    public partial class Form2 : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string strDBConnectionString = "";
        public Form2()
        {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @"."; 
            scsb.InitialCatalog = "healthcheck"; 
            scsb.IntegratedSecurity = true; 

            strDBConnectionString = scsb.ConnectionString.ToString();

            cbox性別.Items.Add("男");
            cbox性別.Items.Add("女");
            cbox性別.Items.Add("不詳");
            cbox性別.SelectedIndex = 0;

        }

        private void btn新增會員資料_Click(object sender, EventArgs e)
        {
            if ((txt身分證字號.Text != "") && (txt密碼.Text != "") && (txt姓名.Text != "") && (txt電話.Text != "") && (txtEmail.Text != ""))
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();

                string strSQL = "INSERT INTO users (身分證字號, 密碼, 姓名, 電話, 性別, Email, 地址, 生日, 公司特約) " +
                                "VALUES (@NewPassId, @NewPassWord, @NewName, @NewPhone,  @NewGender,@NewEmail, @NewAddress, @NewBirthday, @NewDiscount);";

                SqlCommand cmd = new SqlCommand(strSQL, con);
               
                cmd.Parameters.AddWithValue("@NewPassId", txt身分證字號.Text.Trim());
                cmd.Parameters.AddWithValue("@NewPassWord", txt密碼.Text.Trim());
                cmd.Parameters.AddWithValue("@NewName", txt姓名.Text.Trim());
                cmd.Parameters.AddWithValue("@NewPhone", txt電話.Text.Trim());
                cmd.Parameters.AddWithValue("@NewGender", cbox性別.Text.Trim());
                cmd.Parameters.AddWithValue("@NewEmail", txtEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@NewAddress", txt地址.Text.Trim());
                cmd.Parameters.AddWithValue("@NewBirthday",dtp生日.Value);
                cmd.Parameters.AddWithValue("@NewDiscount",chk公司特約.Checked);

                int rows = cmd.ExecuteNonQuery();
                
                con.Close();
                MessageBox.Show($"會員註冊成功");
                清空欄位();
            }
            else
            {
                MessageBox.Show($"欄位資料不齊全");
                
            }
        }
        void 清空欄位()
        {
            txt身分證字號.Clear();
            txt密碼.Clear();
            txt姓名.Clear();
            txt電話.Clear();
            txtEmail.Clear();
            txt地址.Clear();
            dtp生日.Value = DateTime.Now;
            chk公司特約.Checked = false;
        }
        private void btn關閉視窗_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
