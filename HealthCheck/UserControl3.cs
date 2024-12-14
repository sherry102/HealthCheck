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

namespace HealthCheck
{
    public partial class UserControl3 : UserControl
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string strDBConnectionString = "";
        List<int> searchIDs = new List<int>();
        int DGV筆數 = 0; 
        public UserControl3()
        {
            InitializeComponent();
        }

        private void UserControl3_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @"."; 
            scsb.InitialCatalog = "healthcheck"; 
            scsb.IntegratedSecurity = true;

            strDBConnectionString = scsb.ConnectionString.ToString();

            cbox欄位名稱.Items.Add("身分證字號");
            cbox欄位名稱.Items.Add("姓名");
            cbox欄位名稱.Items.Add("電話");
            cbox欄位名稱.Items.Add("地址");
            cbox欄位名稱.Items.Add("email");
            cbox欄位名稱.SelectedIndex = 0;

            cbox性別.Items.Add("男");
            cbox性別.Items.Add("女");
            cbox性別.Items.Add("不詳");
            cbox性別.SelectedIndex = 0;
        }

        private void btn修改會員資料_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(txtID.Text, out intID);

            if ((intID > 0) && (txt身分證字號.Text != "") && (txt密碼.Text != "") && (txt姓名.Text != "") && (txt電話.Text != "") && (txtEmail.Text != ""))
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "update users set 身分證字號=@NewPassId, 密碼=@NewPassWord, 姓名=@NewName, 性別=@NewGender, 電話=@NewPhone, email=@NewEmail, 地址=@NewAddress, 生日= @NewBirthday, 公司特約=@NewDiscount where UserID = @SearchId;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchId", intID);
                cmd.Parameters.AddWithValue("@NewPassId", txt身分證字號.Text);
                cmd.Parameters.AddWithValue("@NewPassWord", txt密碼.Text);
                cmd.Parameters.AddWithValue("@NewName", txt姓名.Text);
                cmd.Parameters.AddWithValue("@NewGender", cbox性別.Text);
                cmd.Parameters.AddWithValue("@NewPhone", txt電話.Text);
                cmd.Parameters.AddWithValue("@NewEmail", txtEmail.Text);
                cmd.Parameters.AddWithValue("@NewAddress", txt地址.Text);
                cmd.Parameters.AddWithValue("@NewBirthday", dtp生日.Value);
                cmd.Parameters.AddWithValue("@NewDiscount", chk公司特約.Checked);
                
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"資料修改成功");
            }
            else
            {
                MessageBox.Show($"欄位資料不齊全");
            }

        }
        private void btn刪除會員資料_Click(object sender, EventArgs e)
        {
            try
            {
                int intID = 0;
                Int32.TryParse(txtID.Text, out intID);

                if (intID > 0)
                {
                    SqlConnection con = new SqlConnection(strDBConnectionString);
                    con.Open();
                    string strSQL = "delete from users where UserID = @DeleteID;";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@DeleteID", intID);

                    int rows = cmd.ExecuteNonQuery();
                    con.Close();
                    清空欄位();
                    MessageBox.Show($"資料刪除成功");
                }
                else
                {
                    MessageBox.Show($"欄位資料不齊全");
                }
            }
            catch {
                MessageBox.Show($"已有預約資料無法刪除");
            }
        }

        void 清空欄位()
        {
            txtID.Clear();
            txt身分證字號.Clear();
            txt密碼.Clear();
            txt姓名.Clear();
            cbox性別.Items.Clear();
            txt電話.Clear();
            txtEmail.Clear();
            txt地址.Clear();
            dtp生日.Value = DateTime.Now;
            chk公司特約.Checked = false;
        }

        private void btn清空欄位_Click(object sender, EventArgs e)
        {
            清空欄位();
        }

        private void btn會員搜尋_Click(object sender, EventArgs e)
        {
            if (txt欄位關鍵字.Text != "")
            {
                searchIDs.Clear();
                string str欄位名稱 = cbox欄位名稱.SelectedItem.ToString();
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = $"select * from users where {str欄位名稱} like @SearchKeyword;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchKeyword", $"%{txt欄位關鍵字.Text.Trim()}%");
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows == true)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    DGV筆數 = dt.Rows.Count;

                    dgv會員資料列表.DataSource = dt;
                }
                else
                {
                    dgv會員資料列表.DataSource = null;
                    MessageBox.Show($"查無此人");
                }
                reader.Close();
                con.Close();
            }
        }

        void 顯示會員欄位詳細資訊(int myId)
        {
            if (myId > 0)
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "select * from users where UserID = @SearchId;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchId", myId);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read() == true)
                {
                    txtID.Text = reader["UserID"].ToString();
                    txt身分證字號.Text = (string)reader["身分證字號"];
                    txt密碼.Text = (string)reader["密碼"];
                    txt姓名.Text = (string)reader["姓名"];
                    cbox性別.Text = (string)reader["性別"];
                    txt電話.Text = (string)reader["電話"];
                    txtEmail.Text = (string)reader["email"];
                    txt地址.Text = (string)reader["地址"];
                    dtp生日.Value = (DateTime)reader["生日"];
                    chk公司特約.Checked = (bool)reader["公司特約"];
                }
                else
                {
                    MessageBox.Show("查無此人");
                }
                reader.Close();
                con.Close();
            }
        }
        private void dgv會員資料列表_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex >= 0) && (e.RowIndex < DGV筆數))
            {
                string strID = dgv會員資料列表.Rows[e.RowIndex].Cells[0].Value.ToString();
                Console.WriteLine(strID);

                int intselId = 0;
                Int32.TryParse(strID, out intselId);
                顯示會員欄位詳細資訊(intselId);
            }
        }

        private void btn顯示全部資料_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL = "select top 500 UserID as 會員編號,身分證字號, 密碼, 姓名, 性別, 生日, 電話, email as 電子郵件, 地址, 公司特約 from users;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows == true)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                DGV筆數 = dt.Rows.Count;
                dgv會員資料列表.DataSource = dt;

            }
            reader.Close();
            con.Close();
        }
    }
}
