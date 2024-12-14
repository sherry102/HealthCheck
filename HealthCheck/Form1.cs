using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HealthCheck
{
    public partial class Form1 : Form
    {
        
        private Panel[] panels;
        public Form1()
        {
            InitializeComponent();
           
            panels = new Panel[] { panel1, panel2, panel3, panel4, panel5 };

            // 預設顯示第一個 Panel
            ShowPanel(0);

            //設定按鈕的點擊事件
            btn健檢預約登記.Click += (s, e) => ShowPanel(0);
            btn全部預約管理.Click += (s, e) => ShowPanel(1);
            btn會員資料維護.Click += (s, e) => ShowPanel(2);
            btn健檢套餐維護.Click += (s, e) => ShowPanel(3);
            btn加購項目維護.Click += (s, e) => ShowPanel(4);
           
            

        }
        private void ShowPanel(int index)
        {
            for (int i = 0; i < panels.Length; i++)
            {
                panels[i].Visible = (i == index);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
            FormLogin myForLogi = new FormLogin();
            myForLogi.ShowDialog();

            顯示權限功能();

        }

        void 顯示權限功能()
        {
            
            if ((GlobalVar.使用者權限 >= 0) && (GlobalVar.使用者權限 <= 5))
            {
                label1.Text = $"Hello 管理者ID {GlobalVar.userId}";
                lblUserName.Text = $"{GlobalVar.userName}";
                btn健檢預約登記.Visible = true;
                btn全部預約管理.Visible = true;
                btn會員資料維護.Visible = true;
                btn健檢套餐維護.Visible = true;
                btn加購項目維護.Visible = true;
                
            }

            else if ((GlobalVar.使用者權限 >= 6) && (GlobalVar.使用者權限 <= 10))
            {
                label1.Text = $"Hello 員工ID {GlobalVar.userId}";
                lblUserName.Text = $"{GlobalVar.userName}";
                btn健檢預約登記.Visible = false;
                btn全部預約管理.Visible = true;
                btn會員資料維護.Visible = true;
                btn健檢套餐維護.Visible = true;
                btn加購項目維護.Visible = true;
            }

            else
            {
                label1.Text = $"Hello 會員ID {GlobalVar.userId}";
                lblUserName.Text = $"{GlobalVar.userName}";
                btn健檢預約登記.Visible = true;
                btn全部預約管理.Visible = false;
                btn會員資料維護.Visible = false;
                btn健檢套餐維護.Visible = false;
                btn加購項目維護.Visible = false;
                
            }
        }

        private void btn健檢預約登記_Click(object sender, EventArgs e)
        {

        }

        private void btn個人預約管理_Click(object sender, EventArgs e)
        {

        }

        private void btn會員資料維護_Click(object sender, EventArgs e)
        {
            
        }

        private void btn健檢套餐維護_Click(object sender, EventArgs e)
        {
            
        }

        private void btn加購項目維護_Click(object sender, EventArgs e)
        {

        }

        private void btn全部預約管理_Click(object sender, EventArgs e)
        {

        }

        private void btn登出_Click(object sender, EventArgs e)
        {
            GlobalVar.is登入成功 = false;
            GlobalVar.userName = "";
            GlobalVar.使用者權限 = 0;
            GlobalVar.userId = 0;

            label1.Text = "";
            lblUserName.Text = "";
            label2.Text = "";


            btn健檢預約登記.Visible = false;
            btn全部預約管理.Visible = false;
            btn會員資料維護.Visible = false;
            btn健檢套餐維護.Visible = false;
            btn加購項目維護.Visible = false;
            panel1.Visible = false;
            

            FormLogin myFormLogin = new FormLogin();
            myFormLogin.ShowDialog();

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            顯示權限功能();
        }

        
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
