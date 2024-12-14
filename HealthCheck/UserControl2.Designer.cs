namespace HealthCheck
{
    partial class UserControl2
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl2));
            this.dgv訂單資料列表 = new System.Windows.Forms.DataGridView();
            this.btn顯示預約資料 = new System.Windows.Forms.Button();
            this.lbl全部預約管理 = new System.Windows.Forms.Label();
            this.lbl健檢預約時間查詢 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.dtp結束時間 = new System.Windows.Forms.DateTimePicker();
            this.dtp開始時間 = new System.Windows.Forms.DateTimePicker();
            this.btn搜尋 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv訂單資料列表)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv訂單資料列表
            // 
            this.dgv訂單資料列表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv訂單資料列表.Location = new System.Drawing.Point(50, 92);
            this.dgv訂單資料列表.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.dgv訂單資料列表.Name = "dgv訂單資料列表";
            this.dgv訂單資料列表.RowHeadersWidth = 82;
            this.dgv訂單資料列表.RowTemplate.Height = 38;
            this.dgv訂單資料列表.Size = new System.Drawing.Size(900, 485);
            this.dgv訂單資料列表.TabIndex = 12;
            this.dgv訂單資料列表.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn顯示預約資料
            // 
            this.btn顯示預約資料.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn顯示預約資料.Location = new System.Drawing.Point(380, 600);
            this.btn顯示預約資料.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn顯示預約資料.Name = "btn顯示預約資料";
            this.btn顯示預約資料.Size = new System.Drawing.Size(209, 48);
            this.btn顯示預約資料.TabIndex = 65;
            this.btn顯示預約資料.Text = "顯示預約資料";
            this.btn顯示預約資料.UseVisualStyleBackColor = true;
            this.btn顯示預約資料.Click += new System.EventHandler(this.btn顯示預約資料_Click);
            // 
            // lbl全部預約管理
            // 
            this.lbl全部預約管理.AutoSize = true;
            this.lbl全部預約管理.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbl全部預約管理.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl全部預約管理.ForeColor = System.Drawing.Color.White;
            this.lbl全部預約管理.Location = new System.Drawing.Point(50, 25);
            this.lbl全部預約管理.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl全部預約管理.Name = "lbl全部預約管理";
            this.lbl全部預約管理.Size = new System.Drawing.Size(209, 40);
            this.lbl全部預約管理.TabIndex = 89;
            this.lbl全部預約管理.Text = "全部預約管理";
            // 
            // lbl健檢預約時間查詢
            // 
            this.lbl健檢預約時間查詢.AutoSize = true;
            this.lbl健檢預約時間查詢.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl健檢預約時間查詢.ForeColor = System.Drawing.Color.Black;
            this.lbl健檢預約時間查詢.Location = new System.Drawing.Point(275, 40);
            this.lbl健檢預約時間查詢.Name = "lbl健檢預約時間查詢";
            this.lbl健檢預約時間查詢.Size = new System.Drawing.Size(162, 24);
            this.lbl健檢預約時間查詢.TabIndex = 94;
            this.lbl健檢預約時間查詢.Text = "健檢預約時間查詢";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(625, 40);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(29, 24);
            this.label20.TabIndex = 93;
            this.label20.Text = "至";
            // 
            // dtp結束時間
            // 
            this.dtp結束時間.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp結束時間.Location = new System.Drawing.Point(659, 35);
            this.dtp結束時間.Name = "dtp結束時間";
            this.dtp結束時間.Size = new System.Drawing.Size(170, 33);
            this.dtp結束時間.TabIndex = 91;
            this.dtp結束時間.Value = new System.DateTime(2024, 11, 30, 23, 59, 0, 0);
            // 
            // dtp開始時間
            // 
            this.dtp開始時間.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp開始時間.Location = new System.Drawing.Point(445, 35);
            this.dtp開始時間.Name = "dtp開始時間";
            this.dtp開始時間.Size = new System.Drawing.Size(170, 33);
            this.dtp開始時間.TabIndex = 90;
            this.dtp開始時間.Value = new System.DateTime(2024, 11, 1, 0, 1, 0, 0);
            // 
            // btn搜尋
            // 
            this.btn搜尋.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn搜尋.Location = new System.Drawing.Point(836, 33);
            this.btn搜尋.Margin = new System.Windows.Forms.Padding(4);
            this.btn搜尋.Name = "btn搜尋";
            this.btn搜尋.Size = new System.Drawing.Size(109, 37);
            this.btn搜尋.TabIndex = 97;
            this.btn搜尋.Text = "搜尋";
            this.btn搜尋.UseVisualStyleBackColor = true;
            this.btn搜尋.Click += new System.EventHandler(this.btn搜尋_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1020, 680);
            this.pictureBox1.TabIndex = 98;
            this.pictureBox1.TabStop = false;
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.btn搜尋);
            this.Controls.Add(this.lbl健檢預約時間查詢);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.dtp結束時間);
            this.Controls.Add(this.dtp開始時間);
            this.Controls.Add(this.lbl全部預約管理);
            this.Controls.Add(this.btn顯示預約資料);
            this.Controls.Add(this.dgv訂單資料列表);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(1020, 680);
            this.Load += new System.EventHandler(this.UserControl2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv訂單資料列表)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv訂單資料列表;
        private System.Windows.Forms.Button btn顯示預約資料;
        private System.Windows.Forms.Label lbl全部預約管理;
        private System.Windows.Forms.Label lbl健檢預約時間查詢;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DateTimePicker dtp結束時間;
        private System.Windows.Forms.DateTimePicker dtp開始時間;
        private System.Windows.Forms.Button btn搜尋;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
