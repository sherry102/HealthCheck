using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HealthCheck
{
    public partial class UserControl4 : UserControl
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string strDBConnectionString = "";
        List<int> searchIDs = new List<int>();
        int DGV筆數 = 0; 

        public UserControl4()
        {
            InitializeComponent();
        }

        private void UserControl4_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @"."; 
            scsb.InitialCatalog = "healthcheck"; 
            scsb.IntegratedSecurity = true; 
            strDBConnectionString = scsb.ConnectionString.ToString();
        }


        private void btn新增_Click(object sender, EventArgs e)
        {
            if ((txtName.Text != "") && (txtPrice.Text != "") && (txtDescription.Text != ""))
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "insert into MainPackage values" +
                    "(@NewName, @NewPrice,@NewDescription)";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewName", txtName.Text);
                int intPrice = 0;
                Int32.TryParse(txtPrice.Text, out intPrice);
                cmd.Parameters.AddWithValue("@NewPrice", intPrice);
                cmd.Parameters.AddWithValue("@NewDescription", txtDescription.Text);
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"健檢套餐新增成功");
            }
            else
            {
                MessageBox.Show($"欄位資料不齊全");
            }
        }
        private void btn修改_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(txtID.Text, out intID);

            if ((intID > 0) && (txtName.Text != "") && (txtPrice.Text != "") && (txtDescription.Text != ""))
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "update MainPackage set Name = @NewName, Price = @NewPrice, Description = @NewDescription where PackageID = @SearchId;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchId", intID);
                cmd.Parameters.AddWithValue("@NewName", txtName.Text);
                int intPrice = 0;
                Int32.TryParse(txtPrice.Text, out intPrice);
                cmd.Parameters.AddWithValue("@NewPrice", intPrice); 
                cmd.Parameters.AddWithValue("@NewDescription", txtDescription.Text);
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"健檢套餐修改成功");
            }
            else
            {
                MessageBox.Show($"欄位資料不齊全");
            }
        }

        private void btn刪除_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(txtID.Text, out intID);

            if (intID > 0)
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "delete from MainPackage where PackageID = @DeleteID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@DeleteID", intID);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                清空欄位();
                MessageBox.Show($"健檢套餐刪除成功");
            }
            else
            {
                MessageBox.Show($"欄位資料不齊全");
            }
        }


        void 清空欄位()
        {
            txtID.Clear();
            txtName.Clear();
            txtPrice.Clear();
            txtDescription.Clear();
        }

        private void btn清空欄位_Click(object sender, EventArgs e)
        {

            清空欄位();
        }

        private void btn套餐搜尋_Click(object sender, EventArgs e)
        {
            if (txtFilter.Text != "")
            {
                searchIDs.Clear();
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = $"select * from MainPackage where Name like @SearchKeyword;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchKeyword", $"%{txtFilter.Text.Trim()}%");
                SqlDataReader reader = cmd.ExecuteReader();

               
                if (reader.HasRows == true)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    DGV筆數 = dt.Rows.Count;
                    dgv套餐資料列表.DataSource = dt;
                }
                else
                {
                    dgv套餐資料列表.DataSource = null;
                    MessageBox.Show($"查無健檢套餐");
                }
                reader.Close();
                con.Close();
            }
        }
        void 顯示套餐欄位詳細資訊(int myId)
        {
            if (myId > 0)
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "select * from MainPackage where PackageID = @SearchId;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchId", myId);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read() == true)
                {
                    txtID.Text = reader["PackageID"].ToString();
                    txtName.Text = (string)reader["Name"];
                    txtPrice.Text = reader["Price"].ToString();
                    txtDescription.Text = (string)reader["Description"];
                }
                else
                {
                    MessageBox.Show("查無健檢套餐");
                }
                reader.Close();
                con.Close();
            }
        }

        

        private void btn顯示全部套餐_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL = "select top 500 PackageID as 編號, Name as 名稱, Price as 價格, Description as 健檢套餐簡介 from MainPackage;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows == true)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                DGV筆數 = dt.Rows.Count;
                dgv套餐資料列表.DataSource = dt;
            }
            reader.Close();
            con.Close();
        }

        private void dgv套餐資料列表_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex >= 0) && (e.RowIndex < DGV筆數))
            {
                string strID = dgv套餐資料列表.Rows[e.RowIndex].Cells[0].Value.ToString();
                Console.WriteLine(strID);

                int intselId = 0;
                Int32.TryParse(strID, out intselId);
                顯示套餐欄位詳細資訊(intselId);
            }
        }
    }
}
