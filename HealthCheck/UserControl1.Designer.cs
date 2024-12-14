namespace HealthCheck
{
    partial class UserControl1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.lbl價格 = new System.Windows.Forms.Label();
            this.lbl會員ID = new System.Windows.Forms.Label();
            this.lbl加購項目 = new System.Windows.Forms.Label();
            this.cbox健檢套餐 = new System.Windows.Forms.ComboBox();
            this.cbox加購項目 = new System.Windows.Forms.ComboBox();
            this.btn計算總價 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.dtp預約日期 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrice1 = new System.Windows.Forms.TextBox();
            this.txtDescription2 = new System.Windows.Forms.TextBox();
            this.lbl項目介紹 = new System.Windows.Forms.Label();
            this.txtPrice2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescription1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.lbl健檢套餐 = new System.Windows.Forms.Label();
            this.dataGridViewCart = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt總價 = new System.Windows.Forms.TextBox();
            this.btnRemoveFromCart = new System.Windows.Forms.Button();
            this.txt姓名 = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnclearadd = new System.Windows.Forms.Button();
            this.btnclearmain = new System.Windows.Forms.Button();
            this.btn套餐搜尋 = new System.Windows.Forms.Button();
            this.btn項目搜尋 = new System.Windows.Forms.Button();
            this.lbl健檢預約登記 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl價格
            // 
            this.lbl價格.AutoSize = true;
            this.lbl價格.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl價格.Location = new System.Drawing.Point(345, 185);
            this.lbl價格.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl價格.Name = "lbl價格";
            this.lbl價格.Size = new System.Drawing.Size(48, 24);
            this.lbl價格.TabIndex = 13;
            this.lbl價格.Text = "價格";
            // 
            // lbl會員ID
            // 
            this.lbl會員ID.AutoSize = true;
            this.lbl會員ID.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl會員ID.Location = new System.Drawing.Point(50, 85);
            this.lbl會員ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl會員ID.Name = "lbl會員ID";
            this.lbl會員ID.Size = new System.Drawing.Size(67, 24);
            this.lbl會員ID.TabIndex = 11;
            this.lbl會員ID.Text = "會員ID";
            // 
            // lbl加購項目
            // 
            this.lbl加購項目.AutoSize = true;
            this.lbl加購項目.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl加購項目.Location = new System.Drawing.Point(50, 400);
            this.lbl加購項目.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl加購項目.Name = "lbl加購項目";
            this.lbl加購項目.Size = new System.Drawing.Size(86, 24);
            this.lbl加購項目.TabIndex = 20;
            this.lbl加購項目.Text = "加購項目";
            // 
            // cbox健檢套餐
            // 
            this.cbox健檢套餐.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbox健檢套餐.FormattingEnabled = true;
            this.cbox健檢套餐.Location = new System.Drawing.Point(150, 130);
            this.cbox健檢套餐.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.cbox健檢套餐.Name = "cbox健檢套餐";
            this.cbox健檢套餐.Size = new System.Drawing.Size(359, 32);
            this.cbox健檢套餐.TabIndex = 21;
            this.cbox健檢套餐.SelectedIndexChanged += new System.EventHandler(this.cbox健檢套餐_SelectedIndexChanged);
            // 
            // cbox加購項目
            // 
            this.cbox加購項目.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbox加購項目.FormattingEnabled = true;
            this.cbox加購項目.Location = new System.Drawing.Point(150, 395);
            this.cbox加購項目.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.cbox加購項目.Name = "cbox加購項目";
            this.cbox加購項目.Size = new System.Drawing.Size(359, 32);
            this.cbox加購項目.TabIndex = 22;
            this.cbox加購項目.SelectedIndexChanged += new System.EventHandler(this.cbox加購項目_SelectedIndexChanged);
            // 
            // btn計算總價
            // 
            this.btn計算總價.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn計算總價.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn計算總價.Location = new System.Drawing.Point(560, 610);
            this.btn計算總價.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.btn計算總價.Name = "btn計算總價";
            this.btn計算總價.Size = new System.Drawing.Size(97, 40);
            this.btn計算總價.TabIndex = 24;
            this.btn計算總價.Text = "計算總價";
            this.btn計算總價.UseVisualStyleBackColor = false;
            this.btn計算總價.Click += new System.EventHandler(this.btn計算總價_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(290, 85);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 24);
            this.label8.TabIndex = 25;
            this.label8.Text = "會員姓名";
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCheckout.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCheckout.Location = new System.Drawing.Point(858, 610);
            this.btnCheckout.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(109, 36);
            this.btnCheckout.TabIndex = 28;
            this.btnCheckout.Text = "確認預約";
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // dtp預約日期
            // 
            this.dtp預約日期.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp預約日期.Location = new System.Drawing.Point(715, 75);
            this.dtp預約日期.Margin = new System.Windows.Forms.Padding(4);
            this.dtp預約日期.Name = "dtp預約日期";
            this.dtp預約日期.Size = new System.Drawing.Size(241, 33);
            this.dtp預約日期.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(560, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 32;
            this.label1.Text = "健檢預約日期";
            // 
            // txtPrice1
            // 
            this.txtPrice1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPrice1.Location = new System.Drawing.Point(400, 180);
            this.txtPrice1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPrice1.Name = "txtPrice1";
            this.txtPrice1.Size = new System.Drawing.Size(109, 33);
            this.txtPrice1.TabIndex = 34;
            // 
            // txtDescription2
            // 
            this.txtDescription2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDescription2.Location = new System.Drawing.Point(50, 495);
            this.txtDescription2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDescription2.Multiline = true;
            this.txtDescription2.Name = "txtDescription2";
            this.txtDescription2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription2.Size = new System.Drawing.Size(459, 100);
            this.txtDescription2.TabIndex = 37;
            // 
            // lbl項目介紹
            // 
            this.lbl項目介紹.AutoSize = true;
            this.lbl項目介紹.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl項目介紹.Location = new System.Drawing.Point(50, 450);
            this.lbl項目介紹.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl項目介紹.Name = "lbl項目介紹";
            this.lbl項目介紹.Size = new System.Drawing.Size(86, 24);
            this.lbl項目介紹.TabIndex = 36;
            this.lbl項目介紹.Text = "項目介紹";
            // 
            // txtPrice2
            // 
            this.txtPrice2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPrice2.Location = new System.Drawing.Point(400, 445);
            this.txtPrice2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPrice2.Name = "txtPrice2";
            this.txtPrice2.Size = new System.Drawing.Size(109, 33);
            this.txtPrice2.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(340, 450);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 24);
            this.label2.TabIndex = 39;
            this.label2.Text = "價格";
            // 
            // txtDescription1
            // 
            this.txtDescription1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDescription1.Location = new System.Drawing.Point(50, 230);
            this.txtDescription1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDescription1.Multiline = true;
            this.txtDescription1.Name = "txtDescription1";
            this.txtDescription1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription1.Size = new System.Drawing.Size(459, 100);
            this.txtDescription1.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(50, 185);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 41;
            this.label3.Text = "健檢介紹";
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddToCart.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddToCart.Location = new System.Drawing.Point(560, 130);
            this.btnAddToCart.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(160, 44);
            this.btnAddToCart.TabIndex = 45;
            this.btnAddToCart.Text = "加入購物車";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // lbl健檢套餐
            // 
            this.lbl健檢套餐.AutoSize = true;
            this.lbl健檢套餐.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl健檢套餐.Location = new System.Drawing.Point(50, 135);
            this.lbl健檢套餐.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl健檢套餐.Name = "lbl健檢套餐";
            this.lbl健檢套餐.Size = new System.Drawing.Size(86, 24);
            this.lbl健檢套餐.TabIndex = 43;
            this.lbl健檢套餐.Text = "健檢套餐";
            // 
            // dataGridViewCart
            // 
            this.dataGridViewCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewCart.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewCart.ColumnHeadersHeight = 50;
            this.dataGridViewCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCart.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewCart.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewCart.Location = new System.Drawing.Point(560, 201);
            this.dataGridViewCart.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.dataGridViewCart.Name = "dataGridViewCart";
            this.dataGridViewCart.ReadOnly = true;
            this.dataGridViewCart.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCart.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewCart.RowHeadersWidth = 82;
            this.dataGridViewCart.RowTemplate.Height = 38;
            this.dataGridViewCart.Size = new System.Drawing.Size(407, 394);
            this.dataGridViewCart.TabIndex = 48;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "名稱";
            this.Column1.MinimumWidth = 10;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 52;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "價格";
            this.Column2.MinimumWidth = 10;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 52;
            // 
            // txt總價
            // 
            this.txt總價.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt總價.Location = new System.Drawing.Point(687, 613);
            this.txt總價.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt總價.Name = "txt總價";
            this.txt總價.Size = new System.Drawing.Size(138, 33);
            this.txt總價.TabIndex = 49;
            this.txt總價.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnRemoveFromCart
            // 
            this.btnRemoveFromCart.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRemoveFromCart.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRemoveFromCart.Location = new System.Drawing.Point(792, 130);
            this.btnRemoveFromCart.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.btnRemoveFromCart.Name = "btnRemoveFromCart";
            this.btnRemoveFromCart.Size = new System.Drawing.Size(175, 44);
            this.btnRemoveFromCart.TabIndex = 50;
            this.btnRemoveFromCart.Text = "刪除購物車項目";
            this.btnRemoveFromCart.UseVisualStyleBackColor = false;
            this.btnRemoveFromCart.Click += new System.EventHandler(this.btnRemoveFromCart_Click);
            // 
            // txt姓名
            // 
            this.txt姓名.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt姓名.Location = new System.Drawing.Point(390, 80);
            this.txt姓名.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt姓名.Name = "txt姓名";
            this.txt姓名.Size = new System.Drawing.Size(119, 33);
            this.txt姓名.TabIndex = 85;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtID.Location = new System.Drawing.Point(150, 80);
            this.txtID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(87, 33);
            this.txtID.TabIndex = 86;
            // 
            // btnclearadd
            // 
            this.btnclearadd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnclearadd.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnclearadd.Location = new System.Drawing.Point(370, 610);
            this.btnclearadd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnclearadd.Name = "btnclearadd";
            this.btnclearadd.Size = new System.Drawing.Size(139, 40);
            this.btnclearadd.TabIndex = 90;
            this.btnclearadd.Text = "清空加購項目";
            this.btnclearadd.UseVisualStyleBackColor = false;
            this.btnclearadd.Click += new System.EventHandler(this.btnclearadd_Click);
            // 
            // btnclearmain
            // 
            this.btnclearmain.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnclearmain.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnclearmain.Location = new System.Drawing.Point(370, 340);
            this.btnclearmain.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnclearmain.Name = "btnclearmain";
            this.btnclearmain.Size = new System.Drawing.Size(139, 36);
            this.btnclearmain.TabIndex = 91;
            this.btnclearmain.Text = "清空套餐欄位";
            this.btnclearmain.UseVisualStyleBackColor = false;
            this.btnclearmain.Click += new System.EventHandler(this.btnclearmain_Click);
            // 
            // btn套餐搜尋
            // 
            this.btn套餐搜尋.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn套餐搜尋.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn套餐搜尋.Location = new System.Drawing.Point(175, 180);
            this.btn套餐搜尋.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn套餐搜尋.Name = "btn套餐搜尋";
            this.btn套餐搜尋.Size = new System.Drawing.Size(121, 34);
            this.btn套餐搜尋.TabIndex = 92;
            this.btn套餐搜尋.Text = "套餐搜尋";
            this.btn套餐搜尋.UseVisualStyleBackColor = false;
            this.btn套餐搜尋.Click += new System.EventHandler(this.btn套餐搜尋_Click);
            // 
            // btn項目搜尋
            // 
            this.btn項目搜尋.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn項目搜尋.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn項目搜尋.Location = new System.Drawing.Point(175, 445);
            this.btn項目搜尋.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn項目搜尋.Name = "btn項目搜尋";
            this.btn項目搜尋.Size = new System.Drawing.Size(121, 35);
            this.btn項目搜尋.TabIndex = 93;
            this.btn項目搜尋.Text = "項目搜尋";
            this.btn項目搜尋.UseVisualStyleBackColor = false;
            this.btn項目搜尋.Click += new System.EventHandler(this.btn項目搜尋_Click);
            // 
            // lbl健檢預約登記
            // 
            this.lbl健檢預約登記.AutoSize = true;
            this.lbl健檢預約登記.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbl健檢預約登記.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl健檢預約登記.ForeColor = System.Drawing.Color.White;
            this.lbl健檢預約登記.Location = new System.Drawing.Point(50, 25);
            this.lbl健檢預約登記.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl健檢預約登記.Name = "lbl健檢預約登記";
            this.lbl健檢預約登記.Size = new System.Drawing.Size(209, 40);
            this.lbl健檢預約登記.TabIndex = 94;
            this.lbl健檢預約登記.Text = "健檢預約登記";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1020, 680);
            this.pictureBox1.TabIndex = 95;
            this.pictureBox1.TabStop = false;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.lbl健檢預約登記);
            this.Controls.Add(this.btn項目搜尋);
            this.Controls.Add(this.btn套餐搜尋);
            this.Controls.Add(this.btnclearmain);
            this.Controls.Add(this.btnclearadd);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txt姓名);
            this.Controls.Add(this.btnRemoveFromCart);
            this.Controls.Add(this.txt總價);
            this.Controls.Add(this.lbl加購項目);
            this.Controls.Add(this.lbl健檢套餐);
            this.Controls.Add(this.cbox加購項目);
            this.Controls.Add(this.dataGridViewCart);
            this.Controls.Add(this.txtPrice2);
            this.Controls.Add(this.cbox健檢套餐);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescription2);
            this.Controls.Add(this.lbl項目介紹);
            this.Controls.Add(this.txtPrice1);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.lbl價格);
            this.Controls.Add(this.dtp預約日期);
            this.Controls.Add(this.txtDescription1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn計算總價);
            this.Controls.Add(this.lbl會員ID);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1020, 680);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl價格;
        private System.Windows.Forms.Label lbl會員ID;
        private System.Windows.Forms.Label lbl加購項目;
        private System.Windows.Forms.ComboBox cbox健檢套餐;
        private System.Windows.Forms.ComboBox cbox加購項目;
        private System.Windows.Forms.Button btn計算總價;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.DateTimePicker dtp預約日期;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrice1;
        private System.Windows.Forms.TextBox txtDescription2;
        private System.Windows.Forms.Label lbl項目介紹;
        private System.Windows.Forms.TextBox txtPrice2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescription1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Label lbl健檢套餐;
        private System.Windows.Forms.DataGridView dataGridViewCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.TextBox txt總價;
        private System.Windows.Forms.Button btnRemoveFromCart;
        private System.Windows.Forms.TextBox txt姓名;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnclearadd;
        private System.Windows.Forms.Button btnclearmain;
        private System.Windows.Forms.Button btn套餐搜尋;
        private System.Windows.Forms.Button btn項目搜尋;
        private System.Windows.Forms.Label lbl健檢預約登記;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
