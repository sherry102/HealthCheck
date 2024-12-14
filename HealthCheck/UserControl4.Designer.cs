namespace HealthCheck
{
    partial class UserControl4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl4));
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn刪除 = new System.Windows.Forms.Button();
            this.btn修改 = new System.Windows.Forms.Button();
            this.btn新增 = new System.Windows.Forms.Button();
            this.btn清空欄位 = new System.Windows.Forms.Button();
            this.btn套餐搜尋 = new System.Windows.Forms.Button();
            this.lbl健檢套餐維護 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.btn顯示全部套餐 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dgv套餐資料列表 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv套餐資料列表)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDescription.Location = new System.Drawing.Point(50, 200);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(400, 275);
            this.txtDescription.TabIndex = 33;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPrice.Location = new System.Drawing.Point(350, 150);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(102, 32);
            this.txtPrice.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(50, 150);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 24);
            this.label5.TabIndex = 30;
            this.label5.Text = "健檢項目簡介";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(275, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 24);
            this.label4.TabIndex = 29;
            this.label4.Text = "價格";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(50, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 28;
            this.label3.Text = "健檢套餐";
            // 
            // btn刪除
            // 
            this.btn刪除.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn刪除.Location = new System.Drawing.Point(52, 565);
            this.btn刪除.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.btn刪除.Name = "btn刪除";
            this.btn刪除.Size = new System.Drawing.Size(175, 45);
            this.btn刪除.TabIndex = 38;
            this.btn刪除.Text = "刪除套餐";
            this.btn刪除.UseVisualStyleBackColor = true;
            this.btn刪除.Click += new System.EventHandler(this.btn刪除_Click);
            // 
            // btn修改
            // 
            this.btn修改.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn修改.Location = new System.Drawing.Point(270, 500);
            this.btn修改.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.btn修改.Name = "btn修改";
            this.btn修改.Size = new System.Drawing.Size(175, 45);
            this.btn修改.TabIndex = 39;
            this.btn修改.Text = "修改套餐";
            this.btn修改.UseVisualStyleBackColor = true;
            this.btn修改.Click += new System.EventHandler(this.btn修改_Click);
            // 
            // btn新增
            // 
            this.btn新增.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn新增.Location = new System.Drawing.Point(52, 500);
            this.btn新增.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.btn新增.Name = "btn新增";
            this.btn新增.Size = new System.Drawing.Size(175, 45);
            this.btn新增.TabIndex = 40;
            this.btn新增.Text = "新增套餐";
            this.btn新增.UseVisualStyleBackColor = true;
            this.btn新增.Click += new System.EventHandler(this.btn新增_Click);
            // 
            // btn清空欄位
            // 
            this.btn清空欄位.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn清空欄位.Location = new System.Drawing.Point(270, 565);
            this.btn清空欄位.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.btn清空欄位.Name = "btn清空欄位";
            this.btn清空欄位.Size = new System.Drawing.Size(175, 45);
            this.btn清空欄位.TabIndex = 66;
            this.btn清空欄位.Text = "清空欄位";
            this.btn清空欄位.UseVisualStyleBackColor = true;
            this.btn清空欄位.Click += new System.EventHandler(this.btn清空欄位_Click);
            // 
            // btn套餐搜尋
            // 
            this.btn套餐搜尋.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn套餐搜尋.Location = new System.Drawing.Point(800, 40);
            this.btn套餐搜尋.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn套餐搜尋.Name = "btn套餐搜尋";
            this.btn套餐搜尋.Size = new System.Drawing.Size(156, 40);
            this.btn套餐搜尋.TabIndex = 68;
            this.btn套餐搜尋.Text = "套餐搜尋";
            this.btn套餐搜尋.UseVisualStyleBackColor = true;
            this.btn套餐搜尋.Click += new System.EventHandler(this.btn套餐搜尋_Click);
            // 
            // lbl健檢套餐維護
            // 
            this.lbl健檢套餐維護.AutoSize = true;
            this.lbl健檢套餐維護.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbl健檢套餐維護.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl健檢套餐維護.ForeColor = System.Drawing.Color.White;
            this.lbl健檢套餐維護.Location = new System.Drawing.Point(50, 25);
            this.lbl健檢套餐維護.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl健檢套餐維護.Name = "lbl健檢套餐維護";
            this.lbl健檢套餐維護.Size = new System.Drawing.Size(209, 40);
            this.lbl健檢套餐維護.TabIndex = 95;
            this.lbl健檢套餐維護.Text = "健檢套餐維護";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(150, 100);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(300, 32);
            this.txtName.TabIndex = 106;
            // 
            // txtFilter
            // 
            this.txtFilter.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtFilter.Location = new System.Drawing.Point(520, 40);
            this.txtFilter.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(249, 32);
            this.txtFilter.TabIndex = 107;
            // 
            // btn顯示全部套餐
            // 
            this.btn顯示全部套餐.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn顯示全部套餐.Location = new System.Drawing.Point(650, 570);
            this.btn顯示全部套餐.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.btn顯示全部套餐.Name = "btn顯示全部套餐";
            this.btn顯示全部套餐.Size = new System.Drawing.Size(200, 40);
            this.btn顯示全部套餐.TabIndex = 109;
            this.btn顯示全部套餐.Text = "顯示全部套餐";
            this.btn顯示全部套餐.UseVisualStyleBackColor = true;
            this.btn顯示全部套餐.Click += new System.EventHandler(this.btn顯示全部套餐_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1020, 680);
            this.pictureBox1.TabIndex = 110;
            this.pictureBox1.TabStop = false;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtID.Location = new System.Drawing.Point(350, 40);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 33);
            this.txtID.TabIndex = 112;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(275, 40);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 24);
            this.label12.TabIndex = 111;
            this.label12.Text = "套餐ID";
            // 
            // dgv套餐資料列表
            // 
            this.dgv套餐資料列表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv套餐資料列表.Location = new System.Drawing.Point(520, 100);
            this.dgv套餐資料列表.Margin = new System.Windows.Forms.Padding(2);
            this.dgv套餐資料列表.Name = "dgv套餐資料列表";
            this.dgv套餐資料列表.RowHeadersWidth = 51;
            this.dgv套餐資料列表.RowTemplate.Height = 27;
            this.dgv套餐資料列表.Size = new System.Drawing.Size(436, 445);
            this.dgv套餐資料列表.TabIndex = 113;
            this.dgv套餐資料列表.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv套餐資料列表_CellContentClick_1);
            // 
            // UserControl4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.dgv套餐資料列表);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btn顯示全部套餐);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbl健檢套餐維護);
            this.Controls.Add(this.btn套餐搜尋);
            this.Controls.Add(this.btn清空欄位);
            this.Controls.Add(this.btn新增);
            this.Controls.Add(this.btn修改);
            this.Controls.Add(this.btn刪除);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.Name = "UserControl4";
            this.Size = new System.Drawing.Size(1020, 680);
            this.Load += new System.EventHandler(this.UserControl4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv套餐資料列表)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn刪除;
        private System.Windows.Forms.Button btn修改;
        private System.Windows.Forms.Button btn新增;
        private System.Windows.Forms.Button btn清空欄位;
        private System.Windows.Forms.Button btn套餐搜尋;
        private System.Windows.Forms.Label lbl健檢套餐維護;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Button btn顯示全部套餐;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgv套餐資料列表;
    }
}
