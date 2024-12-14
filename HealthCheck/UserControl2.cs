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
    public partial class UserControl2 : UserControl
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string strDBConnectionString = "";
        int DGV筆數 = 0;
        public UserControl2()
        {
            InitializeComponent();

        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";
            scsb.InitialCatalog = "healthcheck";
            scsb.IntegratedSecurity = true;

            strDBConnectionString = scsb.ConnectionString.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex >= 0) && (e.RowIndex < DGV筆數))
            {
                string strID = dgv訂單資料列表.Rows[e.RowIndex].Cells[0].Value.ToString();
                Console.WriteLine(strID);

                int intselId = 0;
                Int32.TryParse(strID, out intselId);
               
            }
        }

        private void btn顯示預約資料_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL = "select OrderID as 訂單編號,Orderdate as 預約日期,TotalAmount as 訂單總金額,Users.UserID as 會員編號,身分證字號, 姓名, 性別, 生日, 電話, 地址, email as 電子郵件 from orders join Users on orders.UserID = Users.UserID;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows == true)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                DGV筆數 = dt.Rows.Count;
                dgv訂單資料列表.DataSource = dt;

            }
            reader.Close();
            con.Close();
        }

        private void btn搜尋_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL = "select OrderID as 訂單編號,Orderdate as 預約日期,TotalAmount as 訂單總金額,Users.UserID as 會員編號,身分證字號, 姓名, 性別, 生日, 電話, 地址, email as 電子郵件 from orders join Users on orders.UserID = Users.UserID where Orderdate > @StartBirthday and Orderdate < @EndBirthday;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            
            cmd.Parameters.AddWithValue("@StartBirthday", dtp開始時間.Value);
            cmd.Parameters.AddWithValue("@EndBirthday", dtp結束時間.Value);
           
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows == true)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                DGV筆數 = dt.Rows.Count;
                dgv訂單資料列表.DataSource = dt;

            }
            reader.Close();
            con.Close();
        }
    }
}
