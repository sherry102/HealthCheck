using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace HealthCheck
{
    public partial class UserControl1 : UserControl
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string strDBConnectionString = "";//資料庫連線字串

        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";
            scsb.InitialCatalog = "healthcheck";
            scsb.IntegratedSecurity = true;
            strDBConnectionString = scsb.ConnectionString.ToString();
            LoadPackageAndAddons();
        }

        private void LoadPackageAndAddons()
        {
            List<dynamic> packageList = new List<dynamic>();
            List<dynamic> addonList = new List<dynamic>();

            using (SqlConnection conn = new SqlConnection(strDBConnectionString))
            {
                conn.Open();

                // 加載主套餐
                SqlCommand cmdPackages = new SqlCommand("SELECT PackageID, Name FROM MainPackage", conn);
                SqlDataReader readerPackages = cmdPackages.ExecuteReader();
                while (readerPackages.Read())
                {
                    packageList.Add(new { PackageID = readerPackages["PackageID"], Name = readerPackages["Name"] });
                }
                readerPackages.Close();

                // 加載加購商品
                SqlCommand cmdAddons = new SqlCommand("SELECT AddonID, Name FROM AddonItem", conn);
                SqlDataReader readerAddons = cmdAddons.ExecuteReader();
                while (readerAddons.Read())
                {
                    addonList.Add(new { AddonID = readerAddons["AddonID"], Name = readerAddons["Name"] });
                }
            }

            // 設定ComboBox的DisplayMember和ValueMember
            cbox健檢套餐.DataSource = packageList;
            cbox健檢套餐.DisplayMember = "Name";  // 顯示套餐名稱
            cbox健檢套餐.ValueMember = "PackageID";  // 套餐ID

            cbox加購項目.DataSource = addonList;
            cbox加購項目.DisplayMember = "Name";  // 顯示加購名稱
            cbox加購項目.ValueMember = "AddonID";  // 加購ID
        }



        private void cbox健檢套餐_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            var selectedPackage = (dynamic)cbox健檢套餐.SelectedItem;
            if (selectedPackage != null)
            {
                int packageID = selectedPackage.PackageID;

                using (SqlConnection conn = new SqlConnection(strDBConnectionString))
                {
                    conn.Open();
                    string query = "SELECT Price, Description FROM MainPackage WHERE PackageID = @packageID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@packageID", packageID);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtPrice1.Text = reader["Price"].ToString();
                        txtDescription1.Text = reader["Description"].ToString();
                    }
                }
            }
        }

        private void cbox加購項目_SelectedIndexChanged(object sender, EventArgs e)
        {

            var selectedAddon = (dynamic)cbox加購項目.SelectedItem;
            if (selectedAddon != null)
            {
                int addonID = selectedAddon.AddonID;

                using (SqlConnection conn = new SqlConnection(strDBConnectionString))
                {
                    conn.Open();
                    string query = "SELECT Price, Description FROM AddonItem WHERE AddonID = @addonID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@addonID", addonID);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtPrice2.Text = reader["Price"].ToString();
                        txtDescription2.Text = reader["Description"].ToString();
                    }
                }
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            var selectedPackage = (dynamic)cbox健檢套餐.SelectedItem;
            var selectedAddon = (dynamic)cbox加購項目.SelectedItem;

            if (cbox健檢套餐.Text != "" || cbox加購項目.Text != "")
            {
                string name = selectedPackage.Name + " + " + selectedAddon.Name;
                int price = Convert.ToInt32(txtPrice1.Text) + Convert.ToInt32(txtPrice2.Text);

                // 加入購物車到DataGridView
                DataGridViewRow row = new DataGridViewRow();
                row.Cells.Add(new DataGridViewTextBoxCell() { Value = name });
                row.Cells.Add(new DataGridViewTextBoxCell() { Value = price });
                dataGridViewCart.Rows.Add(row);


                MessageBox.Show("加入購物車成功");
                return;
            }

            else 
            {
                MessageBox.Show("請選擇項目");
            }
            cbox健檢套餐.SelectedIndex = 0;
            cbox加購項目.SelectedIndex = 0;
        }

        private void btnclearmain_Click(object sender, EventArgs e)
        {
            cbox健檢套餐.SelectedIndex = 0;
           
        }
      
        private void btnclearadd_Click(object sender, EventArgs e)
        {
            cbox加購項目.SelectedIndex = 0;
            
        }

        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewCart.SelectedRows)
            {
                dataGridViewCart.Rows.RemoveAt(row.Index);
            }
        }


        private void btn計算總價_Click(object sender, EventArgs e)
        {

            int totalAmount = 0;

            // 計算總金額
            foreach (DataGridViewRow row in dataGridViewCart.Rows)
            {
                totalAmount += Convert.ToInt32(row.Cells[1].Value);
            }

            txt總價.Text = totalAmount.ToString();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "" )
            {
                if (txt總價.Text != "")
                {
                    int totalAmount = 0;

                    // 計算總金額
                    foreach (DataGridViewRow row in dataGridViewCart.Rows)
                    {
                        totalAmount += Convert.ToInt32(row.Cells[1].Value);
                    }
                    txt總價.Text = totalAmount.ToString();

                    // 插入訂單資料
                    using (SqlConnection conn = new SqlConnection(strDBConnectionString))
                    {

                        conn.Open();
                        string query = "INSERT INTO Orders VALUES (@userID, @orderdate, @totalAmount);SELECT SCOPE_IDENTITY();";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@userID", txtID.Text);
                        cmd.Parameters.AddWithValue("@orderdate", dtp預約日期.Value);
                        cmd.Parameters.AddWithValue("@totalAmount", totalAmount);
                        int orderID = Convert.ToInt32(cmd.ExecuteScalar());
                        cmd.ExecuteNonQuery();

                        foreach (DataGridViewRow row in dataGridViewCart.Rows)
                        {
                            string packageName = row.Cells[0].Value?.ToString()??"+";
                            int price = Convert.ToInt32(row.Cells[1].Value);

                            // 解析套餐名稱，假設名稱是 "主套餐 + 加購"
                            string[] packageParts = packageName.Split(new[] { " + " }, StringSplitOptions.None);
                            string mainPackageName = packageParts[0];
                            string addonName = packageParts.Length > 1 ? packageParts[1] : "";

                            // 插入訂單細節
                            query = "INSERT INTO OrderDetails (OrderID, PackageName, AddonName, Price) VALUES (@orderID, @mainPackageName, @addonName, @price)";
                            cmd = new SqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@orderID", orderID);
                            cmd.Parameters.AddWithValue("@mainPackageName", mainPackageName);
                            cmd.Parameters.AddWithValue("@addonName", addonName);
                            cmd.Parameters.AddWithValue("@price", price);
                            cmd.ExecuteNonQuery();
                        }


                        conn.Close();
                        MessageBox.Show($"您預約 {dtp預約日期.Value:d} 健檢已登記成功");
                        dataGridViewCart.Rows.Clear();
                        txtID.Clear();
                        txt姓名.Clear();
                        txt總價.Clear();
                    }
                }
                else
                {
                    MessageBox.Show($"請加入購物車並計算總價");
                } 
            }
            else 
            {
                MessageBox.Show($"請填寫會員ID及會員姓名");
            }
        }

        private void btn套餐搜尋_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL = "select * from MainPackage where Name like @SearchName;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchName", $"%{cbox健檢套餐.Text}%");
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read() == true)
            {
                cbox健檢套餐.Text = (string)reader["Name"];
                txtPrice1.Text = reader["Price"].ToString();
                txtDescription1.Text = (string)reader["Description"];
            }
            else
            {
                MessageBox.Show("查無套餐");
            }

            reader.Close();
            con.Close();
        }

        private void btn項目搜尋_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL = "select * from AddonItem where Name like @SearchName;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchName", $"%{cbox加購項目.Text}%");
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read() == true)
            {
                cbox加購項目.Text = (string)reader["Name"];
                txtPrice2.Text = reader["Price"].ToString();
                txtDescription2.Text = (string)reader["Description"];
            }
            else
            {
                MessageBox.Show("查無套餐");
            }

            reader.Close();
            con.Close();
        }
    }
}
