namespace WinForm_Example
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.RechargePage = new System.Windows.Forms.TabPage();
            this.RechargePage_stuInfoBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.RechargePage_MoneyBlock = new System.Windows.Forms.Label();
            this.RechargePage_CurrentMoneyLable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RechargePage_HiddenLable = new System.Windows.Forms.Label();
            this.RechargePage_Button1 = new System.Windows.Forms.Button();
            this.RechargePage_TextBox = new System.Windows.Forms.TextBox();
            this.BorrowPage = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.BorrowPage_NameLable = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BorrowPage_DepartTextBlock = new System.Windows.Forms.Label();
            this.BorrowPage_NameTextBlock = new System.Windows.Forms.Label();
            this.BorrowPage_ClassTextBlock = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.书名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.作者DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.出版社DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.借阅时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSet1 = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.BorrowPage_StatusBlock = new System.Windows.Forms.Label();
            this.BookInfo_TextBox = new System.Windows.Forms.TextBox();
            this.BorrowPage_StuInfoBlock = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.ReturnPage = new System.Windows.Forms.TabPage();
            this.ReturnPage_HiddenBox_bookInfo = new System.Windows.Forms.TextBox();
            this.ReturnPage_HiddenBox_stuInfo = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ReturnPage_NameContent = new System.Windows.Forms.Label();
            this.ReturnPage_ClassContent = new System.Windows.Forms.Label();
            this.ReturnPage_DepartContent = new System.Windows.Forms.Label();
            this.ReturnPage_NameLable = new System.Windows.Forms.Label();
            this.ReturnPage_ClassLabel = new System.Windows.Forms.Label();
            this.ReturnPage_DepartLabel = new System.Windows.Forms.Label();
            this.ReturnPage_ReturnButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataSet2 = new System.Data.DataSet();
            this.dataTable2 = new System.Data.DataTable();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dataColumn7 = new System.Data.DataColumn();
            this.dataColumn8 = new System.Data.DataColumn();
            this.dataColumn9 = new System.Data.DataColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.书名DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.作者DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.出版社DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.借阅时间DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabControl.SuspendLayout();
            this.RechargePage.SuspendLayout();
            this.BorrowPage.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            this.ReturnPage.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.RechargePage);
            this.TabControl.Controls.Add(this.BorrowPage);
            this.TabControl.Controls.Add(this.ReturnPage);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1001, 652);
            this.TabControl.TabIndex = 0;
            this.TabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // RechargePage
            // 
            this.RechargePage.Controls.Add(this.RechargePage_stuInfoBox);
            this.RechargePage.Controls.Add(this.label6);
            this.RechargePage.Controls.Add(this.RechargePage_MoneyBlock);
            this.RechargePage.Controls.Add(this.RechargePage_CurrentMoneyLable);
            this.RechargePage.Controls.Add(this.label1);
            this.RechargePage.Controls.Add(this.RechargePage_HiddenLable);
            this.RechargePage.Controls.Add(this.RechargePage_Button1);
            this.RechargePage.Controls.Add(this.RechargePage_TextBox);
            this.RechargePage.Location = new System.Drawing.Point(4, 22);
            this.RechargePage.Name = "RechargePage";
            this.RechargePage.Padding = new System.Windows.Forms.Padding(3);
            this.RechargePage.Size = new System.Drawing.Size(993, 626);
            this.RechargePage.TabIndex = 0;
            this.RechargePage.Text = "充值";
            this.RechargePage.UseVisualStyleBackColor = true;
            // 
            // RechargePage_stuInfoBox
            // 
            this.RechargePage_stuInfoBox.Location = new System.Drawing.Point(718, 573);
            this.RechargePage_stuInfoBox.Name = "RechargePage_stuInfoBox";
            this.RechargePage_stuInfoBox.Size = new System.Drawing.Size(100, 21);
            this.RechargePage_stuInfoBox.TabIndex = 7;
            this.RechargePage_stuInfoBox.TextChanged += new System.EventHandler(this.RechargePage_stuInfoBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(111, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "label6";
            // 
            // RechargePage_MoneyBlock
            // 
            this.RechargePage_MoneyBlock.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.RechargePage_MoneyBlock.BackColor = System.Drawing.SystemColors.Window;
            this.RechargePage_MoneyBlock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RechargePage_MoneyBlock.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RechargePage_MoneyBlock.ForeColor = System.Drawing.Color.Black;
            this.RechargePage_MoneyBlock.Location = new System.Drawing.Point(273, 123);
            this.RechargePage_MoneyBlock.Name = "RechargePage_MoneyBlock";
            this.RechargePage_MoneyBlock.Size = new System.Drawing.Size(233, 77);
            this.RechargePage_MoneyBlock.TabIndex = 3;
            // 
            // RechargePage_CurrentMoneyLable
            // 
            this.RechargePage_CurrentMoneyLable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.RechargePage_CurrentMoneyLable.AutoSize = true;
            this.RechargePage_CurrentMoneyLable.BackColor = System.Drawing.Color.Transparent;
            this.RechargePage_CurrentMoneyLable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RechargePage_CurrentMoneyLable.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RechargePage_CurrentMoneyLable.ForeColor = System.Drawing.Color.Black;
            this.RechargePage_CurrentMoneyLable.Location = new System.Drawing.Point(559, 125);
            this.RechargePage_CurrentMoneyLable.Name = "RechargePage_CurrentMoneyLable";
            this.RechargePage_CurrentMoneyLable.Size = new System.Drawing.Size(256, 75);
            this.RechargePage_CurrentMoneyLable.TabIndex = 0;
            this.RechargePage_CurrentMoneyLable.Text = "当前余额";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(559, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 75);
            this.label1.TabIndex = 4;
            this.label1.Text = "充值金额";
            // 
            // RechargePage_HiddenLable
            // 
            this.RechargePage_HiddenLable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RechargePage_HiddenLable.AutoSize = true;
            this.RechargePage_HiddenLable.Location = new System.Drawing.Point(496, 573);
            this.RechargePage_HiddenLable.Name = "RechargePage_HiddenLable";
            this.RechargePage_HiddenLable.Size = new System.Drawing.Size(149, 12);
            this.RechargePage_HiddenLable.TabIndex = 0;
            this.RechargePage_HiddenLable.Text = "RechargePage_HiddenLable";
            this.RechargePage_HiddenLable.TextChanged += new System.EventHandler(this.RechargePage_HiddenLable_TextChanged);
            // 
            // RechargePage_Button1
            // 
            this.RechargePage_Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.RechargePage_Button1.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RechargePage_Button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RechargePage_Button1.Location = new System.Drawing.Point(384, 436);
            this.RechargePage_Button1.Name = "RechargePage_Button1";
            this.RechargePage_Button1.Size = new System.Drawing.Size(215, 74);
            this.RechargePage_Button1.TabIndex = 2;
            this.RechargePage_Button1.Text = "充值";
            this.RechargePage_Button1.UseVisualStyleBackColor = true;
            this.RechargePage_Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // RechargePage_TextBox
            // 
            this.RechargePage_TextBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.RechargePage_TextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.RechargePage_TextBox.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RechargePage_TextBox.Location = new System.Drawing.Point(273, 273);
            this.RechargePage_TextBox.Name = "RechargePage_TextBox";
            this.RechargePage_TextBox.Size = new System.Drawing.Size(233, 81);
            this.RechargePage_TextBox.TabIndex = 1;
            this.RechargePage_TextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BorrowPage
            // 
            this.BorrowPage.Controls.Add(this.groupBox3);
            this.BorrowPage.Controls.Add(this.groupBox1);
            this.BorrowPage.Controls.Add(this.BorrowPage_StatusBlock);
            this.BorrowPage.Controls.Add(this.BookInfo_TextBox);
            this.BorrowPage.Controls.Add(this.BorrowPage_StuInfoBlock);
            this.BorrowPage.Controls.Add(this.button2);
            this.BorrowPage.Location = new System.Drawing.Point(4, 22);
            this.BorrowPage.Name = "BorrowPage";
            this.BorrowPage.Padding = new System.Windows.Forms.Padding(3);
            this.BorrowPage.Size = new System.Drawing.Size(993, 626);
            this.BorrowPage.TabIndex = 1;
            this.BorrowPage.Text = "借书";
            this.BorrowPage.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBox);
            this.groupBox3.Controls.Add(this.BorrowPage_NameLable);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.BorrowPage_DepartTextBlock);
            this.groupBox3.Controls.Add(this.BorrowPage_NameTextBlock);
            this.groupBox3.Controls.Add(this.BorrowPage_ClassTextBlock);
            this.groupBox3.Font = new System.Drawing.Font("微软雅黑", 15.75F);
            this.groupBox3.Location = new System.Drawing.Point(87, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(545, 198);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "学生信息";
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox.Location = new System.Drawing.Point(334, 25);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(135, 162);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // BorrowPage_NameLable
            // 
            this.BorrowPage_NameLable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BorrowPage_NameLable.AutoSize = true;
            this.BorrowPage_NameLable.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BorrowPage_NameLable.ForeColor = System.Drawing.Color.Black;
            this.BorrowPage_NameLable.Location = new System.Drawing.Point(86, 31);
            this.BorrowPage_NameLable.Name = "BorrowPage_NameLable";
            this.BorrowPage_NameLable.Size = new System.Drawing.Size(59, 28);
            this.BorrowPage_NameLable.TabIndex = 0;
            this.BorrowPage_NameLable.Text = "姓名:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(86, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "班级:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(86, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "系别:";
            // 
            // BorrowPage_DepartTextBlock
            // 
            this.BorrowPage_DepartTextBlock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BorrowPage_DepartTextBlock.AutoSize = true;
            this.BorrowPage_DepartTextBlock.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BorrowPage_DepartTextBlock.ForeColor = System.Drawing.Color.Black;
            this.BorrowPage_DepartTextBlock.Location = new System.Drawing.Point(182, 145);
            this.BorrowPage_DepartTextBlock.Name = "BorrowPage_DepartTextBlock";
            this.BorrowPage_DepartTextBlock.Size = new System.Drawing.Size(0, 28);
            this.BorrowPage_DepartTextBlock.TabIndex = 7;
            // 
            // BorrowPage_NameTextBlock
            // 
            this.BorrowPage_NameTextBlock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BorrowPage_NameTextBlock.AutoSize = true;
            this.BorrowPage_NameTextBlock.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BorrowPage_NameTextBlock.ForeColor = System.Drawing.Color.Black;
            this.BorrowPage_NameTextBlock.Location = new System.Drawing.Point(180, 31);
            this.BorrowPage_NameTextBlock.Name = "BorrowPage_NameTextBlock";
            this.BorrowPage_NameTextBlock.Size = new System.Drawing.Size(0, 28);
            this.BorrowPage_NameTextBlock.TabIndex = 5;
            this.BorrowPage_NameTextBlock.UseWaitCursor = true;
            // 
            // BorrowPage_ClassTextBlock
            // 
            this.BorrowPage_ClassTextBlock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BorrowPage_ClassTextBlock.AutoSize = true;
            this.BorrowPage_ClassTextBlock.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BorrowPage_ClassTextBlock.ForeColor = System.Drawing.Color.Black;
            this.BorrowPage_ClassTextBlock.Location = new System.Drawing.Point(182, 90);
            this.BorrowPage_ClassTextBlock.Name = "BorrowPage_ClassTextBlock";
            this.BorrowPage_ClassTextBlock.Size = new System.Drawing.Size(0, 28);
            this.BorrowPage_ClassTextBlock.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(81, 229);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(820, 348);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "图书信息";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.书名DataGridViewTextBoxColumn,
            this.作者DataGridViewTextBoxColumn,
            this.出版社DataGridViewTextBoxColumn,
            this.借阅时间});
            this.dataGridView1.DataMember = "T_Book";
            this.dataGridView1.DataSource = this.dataSet1;
            this.dataGridView1.Location = new System.Drawing.Point(3, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 50;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(806, 300);
            this.dataGridView1.TabIndex = 0;
            // 
            // 书名DataGridViewTextBoxColumn
            // 
            this.书名DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.书名DataGridViewTextBoxColumn.DataPropertyName = "书名";
            this.书名DataGridViewTextBoxColumn.HeaderText = "书名";
            this.书名DataGridViewTextBoxColumn.Name = "书名DataGridViewTextBoxColumn";
            this.书名DataGridViewTextBoxColumn.ReadOnly = true;
            this.书名DataGridViewTextBoxColumn.Width = 300;
            // 
            // 作者DataGridViewTextBoxColumn
            // 
            this.作者DataGridViewTextBoxColumn.DataPropertyName = "作者";
            this.作者DataGridViewTextBoxColumn.HeaderText = "作者";
            this.作者DataGridViewTextBoxColumn.Name = "作者DataGridViewTextBoxColumn";
            this.作者DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 出版社DataGridViewTextBoxColumn
            // 
            this.出版社DataGridViewTextBoxColumn.DataPropertyName = "出版社";
            this.出版社DataGridViewTextBoxColumn.HeaderText = "出版社";
            this.出版社DataGridViewTextBoxColumn.Name = "出版社DataGridViewTextBoxColumn";
            this.出版社DataGridViewTextBoxColumn.ReadOnly = true;
            this.出版社DataGridViewTextBoxColumn.Width = 200;
            // 
            // 借阅时间
            // 
            this.借阅时间.DataPropertyName = "借阅时间";
            this.借阅时间.HeaderText = "借阅时间";
            this.借阅时间.Name = "借阅时间";
            this.借阅时间.ReadOnly = true;
            this.借阅时间.Width = 200;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1});
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4});
            this.dataTable1.TableName = "T_Book";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "书名";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "作者";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "出版社";
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "借阅时间";
            // 
            // BorrowPage_StatusBlock
            // 
            this.BorrowPage_StatusBlock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BorrowPage_StatusBlock.AutoSize = true;
            this.BorrowPage_StatusBlock.Location = new System.Drawing.Point(143, 483);
            this.BorrowPage_StatusBlock.Name = "BorrowPage_StatusBlock";
            this.BorrowPage_StatusBlock.Size = new System.Drawing.Size(0, 12);
            this.BorrowPage_StatusBlock.TabIndex = 19;
            // 
            // BookInfo_TextBox
            // 
            this.BookInfo_TextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BookInfo_TextBox.Location = new System.Drawing.Point(747, 597);
            this.BookInfo_TextBox.Name = "BookInfo_TextBox";
            this.BookInfo_TextBox.Size = new System.Drawing.Size(100, 21);
            this.BookInfo_TextBox.TabIndex = 18;
            this.BookInfo_TextBox.TextChanged += new System.EventHandler(this.BookInfo_TextBox_TextChanged);
            // 
            // BorrowPage_StuInfoBlock
            // 
            this.BorrowPage_StuInfoBlock.Location = new System.Drawing.Point(532, 597);
            this.BorrowPage_StuInfoBlock.Name = "BorrowPage_StuInfoBlock";
            this.BorrowPage_StuInfoBlock.Size = new System.Drawing.Size(100, 21);
            this.BorrowPage_StuInfoBlock.TabIndex = 4;
            this.BorrowPage_StuInfoBlock.TextChanged += new System.EventHandler(this.BorrowHidden_TextChanged);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(647, 115);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(254, 97);
            this.button2.TabIndex = 3;
            this.button2.Text = "借阅";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Borrow_Button_Click);
            // 
            // ReturnPage
            // 
            this.ReturnPage.Controls.Add(this.ReturnPage_HiddenBox_bookInfo);
            this.ReturnPage.Controls.Add(this.ReturnPage_HiddenBox_stuInfo);
            this.ReturnPage.Controls.Add(this.groupBox4);
            this.ReturnPage.Controls.Add(this.ReturnPage_ReturnButton);
            this.ReturnPage.Controls.Add(this.label2);
            this.ReturnPage.Controls.Add(this.groupBox2);
            this.ReturnPage.Controls.Add(this.label5);
            this.ReturnPage.Location = new System.Drawing.Point(4, 22);
            this.ReturnPage.Name = "ReturnPage";
            this.ReturnPage.Padding = new System.Windows.Forms.Padding(3);
            this.ReturnPage.Size = new System.Drawing.Size(993, 626);
            this.ReturnPage.TabIndex = 2;
            this.ReturnPage.Text = "还书";
            this.ReturnPage.UseVisualStyleBackColor = true;
            // 
            // ReturnPage_HiddenBox_bookInfo
            // 
            this.ReturnPage_HiddenBox_bookInfo.Location = new System.Drawing.Point(788, 180);
            this.ReturnPage_HiddenBox_bookInfo.Name = "ReturnPage_HiddenBox_bookInfo";
            this.ReturnPage_HiddenBox_bookInfo.Size = new System.Drawing.Size(100, 21);
            this.ReturnPage_HiddenBox_bookInfo.TabIndex = 36;
            this.ReturnPage_HiddenBox_bookInfo.TextChanged += new System.EventHandler(this.ReturnPage_HiddenBox_bookInfo_TextChanged);
            // 
            // ReturnPage_HiddenBox_stuInfo
            // 
            this.ReturnPage_HiddenBox_stuInfo.Location = new System.Drawing.Point(788, 214);
            this.ReturnPage_HiddenBox_stuInfo.Name = "ReturnPage_HiddenBox_stuInfo";
            this.ReturnPage_HiddenBox_stuInfo.Size = new System.Drawing.Size(100, 21);
            this.ReturnPage_HiddenBox_stuInfo.TabIndex = 35;
            this.ReturnPage_HiddenBox_stuInfo.TextChanged += new System.EventHandler(this.ReturnPage_HiddenBox_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pictureBox1);
            this.groupBox4.Controls.Add(this.ReturnPage_NameContent);
            this.groupBox4.Controls.Add(this.ReturnPage_ClassContent);
            this.groupBox4.Controls.Add(this.ReturnPage_DepartContent);
            this.groupBox4.Controls.Add(this.ReturnPage_NameLable);
            this.groupBox4.Controls.Add(this.ReturnPage_ClassLabel);
            this.groupBox4.Controls.Add(this.ReturnPage_DepartLabel);
            this.groupBox4.Font = new System.Drawing.Font("微软雅黑", 15.75F);
            this.groupBox4.Location = new System.Drawing.Point(73, 20);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(611, 216);
            this.groupBox4.TabIndex = 34;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "学生信息";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(424, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 175);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ReturnPage_NameContent
            // 
            this.ReturnPage_NameContent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ReturnPage_NameContent.AutoSize = true;
            this.ReturnPage_NameContent.BackColor = System.Drawing.Color.Transparent;
            this.ReturnPage_NameContent.Font = new System.Drawing.Font("微软雅黑", 15.75F);
            this.ReturnPage_NameContent.ForeColor = System.Drawing.Color.Black;
            this.ReturnPage_NameContent.Location = new System.Drawing.Point(101, 46);
            this.ReturnPage_NameContent.Name = "ReturnPage_NameContent";
            this.ReturnPage_NameContent.Size = new System.Drawing.Size(59, 28);
            this.ReturnPage_NameContent.TabIndex = 24;
            this.ReturnPage_NameContent.Text = "姓名:";
            // 
            // ReturnPage_ClassContent
            // 
            this.ReturnPage_ClassContent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ReturnPage_ClassContent.AutoSize = true;
            this.ReturnPage_ClassContent.BackColor = System.Drawing.Color.Transparent;
            this.ReturnPage_ClassContent.Font = new System.Drawing.Font("微软雅黑", 15.75F);
            this.ReturnPage_ClassContent.ForeColor = System.Drawing.Color.Black;
            this.ReturnPage_ClassContent.Location = new System.Drawing.Point(101, 99);
            this.ReturnPage_ClassContent.Name = "ReturnPage_ClassContent";
            this.ReturnPage_ClassContent.Size = new System.Drawing.Size(59, 28);
            this.ReturnPage_ClassContent.TabIndex = 23;
            this.ReturnPage_ClassContent.Text = "班级:";
            // 
            // ReturnPage_DepartContent
            // 
            this.ReturnPage_DepartContent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ReturnPage_DepartContent.AutoSize = true;
            this.ReturnPage_DepartContent.BackColor = System.Drawing.Color.Transparent;
            this.ReturnPage_DepartContent.Font = new System.Drawing.Font("微软雅黑", 15.75F);
            this.ReturnPage_DepartContent.ForeColor = System.Drawing.Color.Black;
            this.ReturnPage_DepartContent.Location = new System.Drawing.Point(101, 160);
            this.ReturnPage_DepartContent.Name = "ReturnPage_DepartContent";
            this.ReturnPage_DepartContent.Size = new System.Drawing.Size(59, 28);
            this.ReturnPage_DepartContent.TabIndex = 22;
            this.ReturnPage_DepartContent.Text = "系别:";
            // 
            // ReturnPage_NameLable
            // 
            this.ReturnPage_NameLable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ReturnPage_NameLable.AutoSize = true;
            this.ReturnPage_NameLable.BackColor = System.Drawing.Color.Transparent;
            this.ReturnPage_NameLable.Font = new System.Drawing.Font("微软雅黑", 15.75F);
            this.ReturnPage_NameLable.ForeColor = System.Drawing.Color.Black;
            this.ReturnPage_NameLable.Location = new System.Drawing.Point(195, 46);
            this.ReturnPage_NameLable.Name = "ReturnPage_NameLable";
            this.ReturnPage_NameLable.Size = new System.Drawing.Size(0, 28);
            this.ReturnPage_NameLable.TabIndex = 26;
            this.ReturnPage_NameLable.UseWaitCursor = true;
            // 
            // ReturnPage_ClassLabel
            // 
            this.ReturnPage_ClassLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ReturnPage_ClassLabel.AutoSize = true;
            this.ReturnPage_ClassLabel.BackColor = System.Drawing.Color.Transparent;
            this.ReturnPage_ClassLabel.Font = new System.Drawing.Font("微软雅黑", 15.75F);
            this.ReturnPage_ClassLabel.ForeColor = System.Drawing.Color.Black;
            this.ReturnPage_ClassLabel.Location = new System.Drawing.Point(197, 99);
            this.ReturnPage_ClassLabel.Name = "ReturnPage_ClassLabel";
            this.ReturnPage_ClassLabel.Size = new System.Drawing.Size(0, 28);
            this.ReturnPage_ClassLabel.TabIndex = 27;
            // 
            // ReturnPage_DepartLabel
            // 
            this.ReturnPage_DepartLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ReturnPage_DepartLabel.AutoSize = true;
            this.ReturnPage_DepartLabel.BackColor = System.Drawing.Color.Transparent;
            this.ReturnPage_DepartLabel.Font = new System.Drawing.Font("微软雅黑", 15.75F);
            this.ReturnPage_DepartLabel.ForeColor = System.Drawing.Color.Black;
            this.ReturnPage_DepartLabel.Location = new System.Drawing.Point(197, 160);
            this.ReturnPage_DepartLabel.Name = "ReturnPage_DepartLabel";
            this.ReturnPage_DepartLabel.Size = new System.Drawing.Size(0, 28);
            this.ReturnPage_DepartLabel.TabIndex = 28;
            // 
            // ReturnPage_ReturnButton
            // 
            this.ReturnPage_ReturnButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ReturnPage_ReturnButton.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ReturnPage_ReturnButton.Location = new System.Drawing.Point(730, 58);
            this.ReturnPage_ReturnButton.Name = "ReturnPage_ReturnButton";
            this.ReturnPage_ReturnButton.Size = new System.Drawing.Size(185, 89);
            this.ReturnPage_ReturnButton.TabIndex = 32;
            this.ReturnPage_ReturnButton.Text = "归还";
            this.ReturnPage_ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnPage_ReturnButton.Click += new System.EventHandler(this.ReturnPage_ReturnButton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(693, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 99);
            this.label2.TabIndex = 31;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 15.75F);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(73, 258);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(832, 325);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "图书信息";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.书名DataGridViewTextBoxColumn1,
            this.作者DataGridViewTextBoxColumn1,
            this.出版社DataGridViewTextBoxColumn1,
            this.借阅时间DataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn});
            this.dataGridView2.DataMember = "T_Book";
            this.dataGridView2.DataSource = this.dataSet2;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 31);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 50;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(826, 291);
            this.dataGridView2.TabIndex = 0;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "NewDataSet";
            this.dataSet2.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable2});
            // 
            // dataTable2
            // 
            this.dataTable2.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn5,
            this.dataColumn6,
            this.dataColumn7,
            this.dataColumn8,
            this.dataColumn9});
            this.dataTable2.TableName = "T_Book";
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "书名";
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "作者";
            // 
            // dataColumn7
            // 
            this.dataColumn7.ColumnName = "出版社";
            // 
            // dataColumn8
            // 
            this.dataColumn8.ColumnName = "借阅时间";
            // 
            // dataColumn9
            // 
            this.dataColumn9.ColumnName = "ID";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(157, 479);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 12);
            this.label5.TabIndex = 29;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // 书名DataGridViewTextBoxColumn1
            // 
            this.书名DataGridViewTextBoxColumn1.DataPropertyName = "书名";
            this.书名DataGridViewTextBoxColumn1.HeaderText = "书名";
            this.书名DataGridViewTextBoxColumn1.Name = "书名DataGridViewTextBoxColumn1";
            this.书名DataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // 作者DataGridViewTextBoxColumn1
            // 
            this.作者DataGridViewTextBoxColumn1.DataPropertyName = "作者";
            this.作者DataGridViewTextBoxColumn1.HeaderText = "作者";
            this.作者DataGridViewTextBoxColumn1.Name = "作者DataGridViewTextBoxColumn1";
            this.作者DataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // 出版社DataGridViewTextBoxColumn1
            // 
            this.出版社DataGridViewTextBoxColumn1.DataPropertyName = "出版社";
            this.出版社DataGridViewTextBoxColumn1.HeaderText = "出版社";
            this.出版社DataGridViewTextBoxColumn1.Name = "出版社DataGridViewTextBoxColumn1";
            this.出版社DataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // 借阅时间DataGridViewTextBoxColumn
            // 
            this.借阅时间DataGridViewTextBoxColumn.DataPropertyName = "借阅时间";
            this.借阅时间DataGridViewTextBoxColumn.HeaderText = "借阅时间";
            this.借阅时间DataGridViewTextBoxColumn.Name = "借阅时间DataGridViewTextBoxColumn";
            this.借阅时间DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1001, 652);
            this.Controls.Add(this.TabControl);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "智能校园一卡通系统";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.TabControl.ResumeLayout(false);
            this.RechargePage.ResumeLayout(false);
            this.RechargePage.PerformLayout();
            this.BorrowPage.ResumeLayout(false);
            this.BorrowPage.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            this.ReturnPage.ResumeLayout(false);
            this.ReturnPage.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage RechargePage;
        private System.Windows.Forms.Button RechargePage_Button1;
        private System.Windows.Forms.TextBox RechargePage_TextBox;
        private System.Windows.Forms.Label RechargePage_CurrentMoneyLable;
        private System.Windows.Forms.TabPage BorrowPage;
        private System.Windows.Forms.TextBox BorrowPage_StuInfoBlock;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label BorrowPage_NameLable;
        private System.Windows.Forms.TabPage ReturnPage;
        private System.Windows.Forms.Label BorrowPage_DepartTextBlock;
        private System.Windows.Forms.Label BorrowPage_ClassTextBlock;
        private System.Windows.Forms.Label BorrowPage_NameTextBlock;
        private System.Windows.Forms.TextBox BookInfo_TextBox;
        private System.Windows.Forms.Label BorrowPage_StatusBlock;
        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Data.DataSet dataSet1;
        private System.Data.DataTable dataTable1;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Windows.Forms.Label RechargePage_MoneyBlock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label RechargePage_HiddenLable;
        private System.Windows.Forms.Button ReturnPage_ReturnButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ReturnPage_DepartLabel;
        private System.Windows.Forms.Label ReturnPage_ClassLabel;
        private System.Windows.Forms.Label ReturnPage_NameLable;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ReturnPage_DepartContent;
        private System.Windows.Forms.Label ReturnPage_ClassContent;
        private System.Windows.Forms.Label ReturnPage_NameContent;
        private System.Windows.Forms.Label label6;
        private System.Data.DataColumn dataColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn 书名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 作者DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 出版社DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 借阅时间;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox ReturnPage_HiddenBox_stuInfo;
        private System.Windows.Forms.TextBox ReturnPage_HiddenBox_bookInfo;
        private System.Data.DataSet dataSet2;
        private System.Data.DataTable dataTable2;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
        private System.Data.DataColumn dataColumn7;
        private System.Data.DataColumn dataColumn8;
        private System.Data.DataColumn dataColumn9;
        private System.Windows.Forms.TextBox RechargePage_stuInfoBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn 书名DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 作者DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 出版社DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 借阅时间DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
    }
}

