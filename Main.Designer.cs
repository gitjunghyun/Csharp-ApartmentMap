namespace TeamProject1
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel_Main = new System.Windows.Forms.TableLayoutPanel();
            this.top_panel_mainTitle = new System.Windows.Forms.Panel();
            this.tabControl_main = new System.Windows.Forms.TabControl();
            this.tabPage__data_sell = new System.Windows.Forms.TabPage();
            this.dataGridView_sell_data = new System.Windows.Forms.DataGridView();
            this.tabPage_data_rent = new System.Windows.Forms.TabPage();
            this.dataGridView_rent_data = new System.Windows.Forms.DataGridView();
            this.tabPage_sell_view = new System.Windows.Forms.TabPage();
            this.splitContainer_sell = new System.Windows.Forms.SplitContainer();
            this.splitContainer_sell_left = new System.Windows.Forms.SplitContainer();
            this.splitContainer_sell_left_top = new System.Windows.Forms.SplitContainer();
            this.groupBox_sell_address = new System.Windows.Forms.GroupBox();
            this.comboBox_sell_aptNm = new System.Windows.Forms.ComboBox();
            this.comboBox_sell_aptDong = new System.Windows.Forms.ComboBox();
            this.comboBox_sell_aptCity = new System.Windows.Forms.ComboBox();
            this.groupBox_sell_money = new System.Windows.Forms.GroupBox();
            this.comboBox_sell_aptAmt = new System.Windows.Forms.ComboBox();
            this.dataGridView_sell_view = new System.Windows.Forms.DataGridView();
            this.tabPage_rent_view = new System.Windows.Forms.TabPage();
            this.splitContainer_rent = new System.Windows.Forms.SplitContainer();
            this.splitContainer_rent_view_main = new System.Windows.Forms.SplitContainer();
            this.splitContainer_rent_left_top = new System.Windows.Forms.SplitContainer();
            this.groupBox_rent_address = new System.Windows.Forms.GroupBox();
            this.comboBox_rent_aptNm = new System.Windows.Forms.ComboBox();
            this.comboBox_rent_aptDong = new System.Windows.Forms.ComboBox();
            this.comboBox_rent_aptCity = new System.Windows.Forms.ComboBox();
            this.groupBox_rent_money = new System.Windows.Forms.GroupBox();
            this.comboBox_rent_aptDeposit = new System.Windows.Forms.ComboBox();
            this.comboBox_rent_aptLease = new System.Windows.Forms.ComboBox();
            this.dataGridView_rent_view = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bottom_panel_banner = new System.Windows.Forms.Panel();
            this.tableLayoutPanel_Main.SuspendLayout();
            this.top_panel_mainTitle.SuspendLayout();
            this.tabControl_main.SuspendLayout();
            this.tabPage__data_sell.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_sell_data)).BeginInit();
            this.tabPage_data_rent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_rent_data)).BeginInit();
            this.tabPage_sell_view.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_sell)).BeginInit();
            this.splitContainer_sell.Panel1.SuspendLayout();
            this.splitContainer_sell.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_sell_left)).BeginInit();
            this.splitContainer_sell_left.Panel1.SuspendLayout();
            this.splitContainer_sell_left.Panel2.SuspendLayout();
            this.splitContainer_sell_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_sell_left_top)).BeginInit();
            this.splitContainer_sell_left_top.Panel1.SuspendLayout();
            this.splitContainer_sell_left_top.Panel2.SuspendLayout();
            this.splitContainer_sell_left_top.SuspendLayout();
            this.groupBox_sell_address.SuspendLayout();
            this.groupBox_sell_money.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_sell_view)).BeginInit();
            this.tabPage_rent_view.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_rent)).BeginInit();
            this.splitContainer_rent.Panel1.SuspendLayout();
            this.splitContainer_rent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_rent_view_main)).BeginInit();
            this.splitContainer_rent_view_main.Panel1.SuspendLayout();
            this.splitContainer_rent_view_main.Panel2.SuspendLayout();
            this.splitContainer_rent_view_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_rent_left_top)).BeginInit();
            this.splitContainer_rent_left_top.Panel1.SuspendLayout();
            this.splitContainer_rent_left_top.Panel2.SuspendLayout();
            this.splitContainer_rent_left_top.SuspendLayout();
            this.groupBox_rent_address.SuspendLayout();
            this.groupBox_rent_money.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_rent_view)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_Main
            // 
            this.tableLayoutPanel_Main.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel_Main.ColumnCount = 1;
            this.tableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Main.Controls.Add(this.top_panel_mainTitle, 0, 0);
            this.tableLayoutPanel_Main.Controls.Add(this.bottom_panel_banner, 0, 2);
            this.tableLayoutPanel_Main.Controls.Add(this.tabControl_main, 0, 1);
            this.tableLayoutPanel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Main.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_Main.Name = "tableLayoutPanel_Main";
            this.tableLayoutPanel_Main.RowCount = 3;
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.90882F));
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.45289F));
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_Main.Size = new System.Drawing.Size(1180, 661);
            this.tableLayoutPanel_Main.TabIndex = 0;
            // 
            // top_panel_mainTitle
            // 
            this.top_panel_mainTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.top_panel_mainTitle.Controls.Add(this.panel1);
            this.top_panel_mainTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.top_panel_mainTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.top_panel_mainTitle.ForeColor = System.Drawing.Color.Transparent;
            this.top_panel_mainTitle.Location = new System.Drawing.Point(6, 6);
            this.top_panel_mainTitle.Name = "top_panel_mainTitle";
            this.top_panel_mainTitle.Size = new System.Drawing.Size(1168, 124);
            this.top_panel_mainTitle.TabIndex = 0;
            // 
            // tabControl_main
            // 
            this.tabControl_main.Controls.Add(this.tabPage__data_sell);
            this.tabControl_main.Controls.Add(this.tabPage_data_rent);
            this.tabControl_main.Controls.Add(this.tabPage_sell_view);
            this.tabControl_main.Controls.Add(this.tabPage_rent_view);
            this.tabControl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_main.Font = new System.Drawing.Font("휴먼편지체", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tabControl_main.HotTrack = true;
            this.tabControl_main.ItemSize = new System.Drawing.Size(100, 30);
            this.tabControl_main.Location = new System.Drawing.Point(6, 139);
            this.tabControl_main.Name = "tabControl_main";
            this.tabControl_main.SelectedIndex = 0;
            this.tabControl_main.Size = new System.Drawing.Size(1168, 447);
            this.tabControl_main.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl_main.TabIndex = 2;
            // 
            // tabPage__data_sell
            // 
            this.tabPage__data_sell.Controls.Add(this.dataGridView_sell_data);
            this.tabPage__data_sell.Location = new System.Drawing.Point(4, 34);
            this.tabPage__data_sell.Name = "tabPage__data_sell";
            this.tabPage__data_sell.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage__data_sell.Size = new System.Drawing.Size(1160, 409);
            this.tabPage__data_sell.TabIndex = 0;
            this.tabPage__data_sell.Text = "DB_Sell";
            this.tabPage__data_sell.UseVisualStyleBackColor = true;
            // 
            // dataGridView_sell_data
            // 
            this.dataGridView_sell_data.AllowUserToAddRows = false;
            this.dataGridView_sell_data.AllowUserToDeleteRows = false;
            this.dataGridView_sell_data.AllowUserToResizeRows = false;
            this.dataGridView_sell_data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_sell_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_sell_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_sell_data.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView_sell_data.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_sell_data.MultiSelect = false;
            this.dataGridView_sell_data.Name = "dataGridView_sell_data";
            this.dataGridView_sell_data.ReadOnly = true;
            this.dataGridView_sell_data.RowTemplate.Height = 23;
            this.dataGridView_sell_data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_sell_data.Size = new System.Drawing.Size(1154, 403);
            this.dataGridView_sell_data.TabIndex = 0;
            // 
            // tabPage_data_rent
            // 
            this.tabPage_data_rent.Controls.Add(this.dataGridView_rent_data);
            this.tabPage_data_rent.Location = new System.Drawing.Point(4, 34);
            this.tabPage_data_rent.Name = "tabPage_data_rent";
            this.tabPage_data_rent.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_data_rent.Size = new System.Drawing.Size(1160, 409);
            this.tabPage_data_rent.TabIndex = 1;
            this.tabPage_data_rent.Text = "DB_Rent";
            this.tabPage_data_rent.UseVisualStyleBackColor = true;
            // 
            // dataGridView_rent_data
            // 
            this.dataGridView_rent_data.AllowUserToAddRows = false;
            this.dataGridView_rent_data.AllowUserToDeleteRows = false;
            this.dataGridView_rent_data.AllowUserToResizeRows = false;
            this.dataGridView_rent_data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_rent_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_rent_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_rent_data.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView_rent_data.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_rent_data.MultiSelect = false;
            this.dataGridView_rent_data.Name = "dataGridView_rent_data";
            this.dataGridView_rent_data.ReadOnly = true;
            this.dataGridView_rent_data.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_rent_data.RowTemplate.Height = 23;
            this.dataGridView_rent_data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_rent_data.Size = new System.Drawing.Size(1154, 403);
            this.dataGridView_rent_data.TabIndex = 0;
            // 
            // tabPage_sell_view
            // 
            this.tabPage_sell_view.BackColor = System.Drawing.Color.Transparent;
            this.tabPage_sell_view.Controls.Add(this.splitContainer_sell);
            this.tabPage_sell_view.Location = new System.Drawing.Point(4, 34);
            this.tabPage_sell_view.Name = "tabPage_sell_view";
            this.tabPage_sell_view.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_sell_view.Size = new System.Drawing.Size(1160, 409);
            this.tabPage_sell_view.TabIndex = 2;
            this.tabPage_sell_view.Text = "매매";
            this.tabPage_sell_view.Enter += new System.EventHandler(this.tabPage_sell_view_Enter);
            // 
            // splitContainer_sell
            // 
            this.splitContainer_sell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_sell.Location = new System.Drawing.Point(3, 3);
            this.splitContainer_sell.Name = "splitContainer_sell";
            // 
            // splitContainer_sell.Panel1
            // 
            this.splitContainer_sell.Panel1.Controls.Add(this.splitContainer_sell_left);
            this.splitContainer_sell.Size = new System.Drawing.Size(1154, 403);
            this.splitContainer_sell.SplitterDistance = 768;
            this.splitContainer_sell.TabIndex = 0;
            // 
            // splitContainer_sell_left
            // 
            this.splitContainer_sell_left.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_sell_left.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_sell_left.Name = "splitContainer_sell_left";
            this.splitContainer_sell_left.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_sell_left.Panel1
            // 
            this.splitContainer_sell_left.Panel1.Controls.Add(this.splitContainer_sell_left_top);
            // 
            // splitContainer_sell_left.Panel2
            // 
            this.splitContainer_sell_left.Panel2.Controls.Add(this.dataGridView_sell_view);
            this.splitContainer_sell_left.Size = new System.Drawing.Size(768, 403);
            this.splitContainer_sell_left.SplitterDistance = 64;
            this.splitContainer_sell_left.TabIndex = 1;
            // 
            // splitContainer_sell_left_top
            // 
            this.splitContainer_sell_left_top.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_sell_left_top.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_sell_left_top.Name = "splitContainer_sell_left_top";
            // 
            // splitContainer_sell_left_top.Panel1
            // 
            this.splitContainer_sell_left_top.Panel1.Controls.Add(this.groupBox_sell_address);
            // 
            // splitContainer_sell_left_top.Panel2
            // 
            this.splitContainer_sell_left_top.Panel2.Controls.Add(this.groupBox_sell_money);
            this.splitContainer_sell_left_top.Size = new System.Drawing.Size(768, 64);
            this.splitContainer_sell_left_top.SplitterDistance = 481;
            this.splitContainer_sell_left_top.TabIndex = 0;
            // 
            // groupBox_sell_address
            // 
            this.groupBox_sell_address.AutoSize = true;
            this.groupBox_sell_address.Controls.Add(this.comboBox_sell_aptNm);
            this.groupBox_sell_address.Controls.Add(this.comboBox_sell_aptDong);
            this.groupBox_sell_address.Controls.Add(this.comboBox_sell_aptCity);
            this.groupBox_sell_address.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_sell_address.Location = new System.Drawing.Point(0, 0);
            this.groupBox_sell_address.Name = "groupBox_sell_address";
            this.groupBox_sell_address.Size = new System.Drawing.Size(481, 64);
            this.groupBox_sell_address.TabIndex = 4;
            this.groupBox_sell_address.TabStop = false;
            this.groupBox_sell_address.Text = "주소";
            // 
            // comboBox_sell_aptNm
            // 
            this.comboBox_sell_aptNm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_sell_aptNm.DropDownWidth = 150;
            this.comboBox_sell_aptNm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_sell_aptNm.FormattingEnabled = true;
            this.comboBox_sell_aptNm.Location = new System.Drawing.Point(285, 24);
            this.comboBox_sell_aptNm.Margin = new System.Windows.Forms.Padding(5);
            this.comboBox_sell_aptNm.Name = "comboBox_sell_aptNm";
            this.comboBox_sell_aptNm.Size = new System.Drawing.Size(185, 30);
            this.comboBox_sell_aptNm.TabIndex = 2;
            this.comboBox_sell_aptNm.SelectionChangeCommitted += new System.EventHandler(this.comboBox_sell_aptNm_SelectionChangeCommitted);
            // 
            // comboBox_sell_aptDong
            // 
            this.comboBox_sell_aptDong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_sell_aptDong.DropDownWidth = 150;
            this.comboBox_sell_aptDong.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_sell_aptDong.FormattingEnabled = true;
            this.comboBox_sell_aptDong.Location = new System.Drawing.Point(184, 24);
            this.comboBox_sell_aptDong.Margin = new System.Windows.Forms.Padding(5);
            this.comboBox_sell_aptDong.Name = "comboBox_sell_aptDong";
            this.comboBox_sell_aptDong.Size = new System.Drawing.Size(91, 30);
            this.comboBox_sell_aptDong.TabIndex = 0;
            this.comboBox_sell_aptDong.SelectionChangeCommitted += new System.EventHandler(this.comboBox_sell_aptDong_SelectionChangeCommitted);
            // 
            // comboBox_sell_aptCity
            // 
            this.comboBox_sell_aptCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_sell_aptCity.DropDownWidth = 150;
            this.comboBox_sell_aptCity.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_sell_aptCity.FormattingEnabled = true;
            this.comboBox_sell_aptCity.Location = new System.Drawing.Point(5, 24);
            this.comboBox_sell_aptCity.Margin = new System.Windows.Forms.Padding(5);
            this.comboBox_sell_aptCity.Name = "comboBox_sell_aptCity";
            this.comboBox_sell_aptCity.Size = new System.Drawing.Size(169, 30);
            this.comboBox_sell_aptCity.TabIndex = 1;
            this.comboBox_sell_aptCity.SelectionChangeCommitted += new System.EventHandler(this.comboBox_sell_aptCity_SelectionChangeCommitted);
            // 
            // groupBox_sell_money
            // 
            this.groupBox_sell_money.AutoSize = true;
            this.groupBox_sell_money.Controls.Add(this.comboBox_sell_aptAmt);
            this.groupBox_sell_money.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_sell_money.Location = new System.Drawing.Point(0, 0);
            this.groupBox_sell_money.Name = "groupBox_sell_money";
            this.groupBox_sell_money.Size = new System.Drawing.Size(283, 64);
            this.groupBox_sell_money.TabIndex = 5;
            this.groupBox_sell_money.TabStop = false;
            this.groupBox_sell_money.Text = "거래가격(만원)";
            // 
            // comboBox_sell_aptAmt
            // 
            this.comboBox_sell_aptAmt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_sell_aptAmt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_sell_aptAmt.FormattingEnabled = true;
            this.comboBox_sell_aptAmt.Location = new System.Drawing.Point(45, 24);
            this.comboBox_sell_aptAmt.Name = "comboBox_sell_aptAmt";
            this.comboBox_sell_aptAmt.Size = new System.Drawing.Size(205, 30);
            this.comboBox_sell_aptAmt.TabIndex = 0;
            this.comboBox_sell_aptAmt.SelectionChangeCommitted += new System.EventHandler(this.comboBox_sell_aptAmt_SelectionChangeCommitted);
            // 
            // dataGridView_sell_view
            // 
            this.dataGridView_sell_view.AllowUserToAddRows = false;
            this.dataGridView_sell_view.AllowUserToDeleteRows = false;
            this.dataGridView_sell_view.AllowUserToResizeRows = false;
            this.dataGridView_sell_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_sell_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_sell_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_sell_view.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView_sell_view.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_sell_view.MultiSelect = false;
            this.dataGridView_sell_view.Name = "dataGridView_sell_view";
            this.dataGridView_sell_view.ReadOnly = true;
            this.dataGridView_sell_view.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_sell_view.RowTemplate.Height = 23;
            this.dataGridView_sell_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_sell_view.Size = new System.Drawing.Size(768, 335);
            this.dataGridView_sell_view.TabIndex = 0;
            this.dataGridView_sell_view.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CellContentClick);
            // 
            // tabPage_rent_view
            // 
            this.tabPage_rent_view.BackColor = System.Drawing.Color.Transparent;
            this.tabPage_rent_view.Controls.Add(this.splitContainer_rent);
            this.tabPage_rent_view.Location = new System.Drawing.Point(4, 34);
            this.tabPage_rent_view.Name = "tabPage_rent_view";
            this.tabPage_rent_view.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_rent_view.Size = new System.Drawing.Size(1160, 409);
            this.tabPage_rent_view.TabIndex = 3;
            this.tabPage_rent_view.Text = "전/월세";
            this.tabPage_rent_view.Enter += new System.EventHandler(this.tabPage_rent_view_Enter);
            // 
            // splitContainer_rent
            // 
            this.splitContainer_rent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_rent.Location = new System.Drawing.Point(3, 3);
            this.splitContainer_rent.Name = "splitContainer_rent";
            // 
            // splitContainer_rent.Panel1
            // 
            this.splitContainer_rent.Panel1.Controls.Add(this.splitContainer_rent_view_main);
            this.splitContainer_rent.Size = new System.Drawing.Size(1154, 403);
            this.splitContainer_rent.SplitterDistance = 778;
            this.splitContainer_rent.TabIndex = 0;
            // 
            // splitContainer_rent_view_main
            // 
            this.splitContainer_rent_view_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_rent_view_main.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_rent_view_main.Name = "splitContainer_rent_view_main";
            this.splitContainer_rent_view_main.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_rent_view_main.Panel1
            // 
            this.splitContainer_rent_view_main.Panel1.Controls.Add(this.splitContainer_rent_left_top);
            // 
            // splitContainer_rent_view_main.Panel2
            // 
            this.splitContainer_rent_view_main.Panel2.Controls.Add(this.dataGridView_rent_view);
            this.splitContainer_rent_view_main.Size = new System.Drawing.Size(778, 403);
            this.splitContainer_rent_view_main.SplitterDistance = 66;
            this.splitContainer_rent_view_main.TabIndex = 1;
            // 
            // splitContainer_rent_left_top
            // 
            this.splitContainer_rent_left_top.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_rent_left_top.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_rent_left_top.Name = "splitContainer_rent_left_top";
            // 
            // splitContainer_rent_left_top.Panel1
            // 
            this.splitContainer_rent_left_top.Panel1.Controls.Add(this.groupBox_rent_address);
            // 
            // splitContainer_rent_left_top.Panel2
            // 
            this.splitContainer_rent_left_top.Panel2.Controls.Add(this.groupBox_rent_money);
            this.splitContainer_rent_left_top.Size = new System.Drawing.Size(778, 66);
            this.splitContainer_rent_left_top.SplitterDistance = 444;
            this.splitContainer_rent_left_top.TabIndex = 0;
            // 
            // groupBox_rent_address
            // 
            this.groupBox_rent_address.AutoSize = true;
            this.groupBox_rent_address.Controls.Add(this.comboBox_rent_aptNm);
            this.groupBox_rent_address.Controls.Add(this.comboBox_rent_aptDong);
            this.groupBox_rent_address.Controls.Add(this.comboBox_rent_aptCity);
            this.groupBox_rent_address.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_rent_address.Location = new System.Drawing.Point(0, 0);
            this.groupBox_rent_address.Name = "groupBox_rent_address";
            this.groupBox_rent_address.Size = new System.Drawing.Size(444, 66);
            this.groupBox_rent_address.TabIndex = 3;
            this.groupBox_rent_address.TabStop = false;
            this.groupBox_rent_address.Text = "주소";
            // 
            // comboBox_rent_aptNm
            // 
            this.comboBox_rent_aptNm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_rent_aptNm.DropDownWidth = 150;
            this.comboBox_rent_aptNm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_rent_aptNm.FormattingEnabled = true;
            this.comboBox_rent_aptNm.Location = new System.Drawing.Point(280, 24);
            this.comboBox_rent_aptNm.Margin = new System.Windows.Forms.Padding(5);
            this.comboBox_rent_aptNm.Name = "comboBox_rent_aptNm";
            this.comboBox_rent_aptNm.Size = new System.Drawing.Size(159, 30);
            this.comboBox_rent_aptNm.TabIndex = 2;
            this.comboBox_rent_aptNm.SelectionChangeCommitted += new System.EventHandler(this.comboBox_rent_aptNm_SelectionChangeCommitted);
            // 
            // comboBox_rent_aptDong
            // 
            this.comboBox_rent_aptDong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_rent_aptDong.DropDownWidth = 150;
            this.comboBox_rent_aptDong.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_rent_aptDong.FormattingEnabled = true;
            this.comboBox_rent_aptDong.Location = new System.Drawing.Point(179, 24);
            this.comboBox_rent_aptDong.Margin = new System.Windows.Forms.Padding(5);
            this.comboBox_rent_aptDong.Name = "comboBox_rent_aptDong";
            this.comboBox_rent_aptDong.Size = new System.Drawing.Size(91, 30);
            this.comboBox_rent_aptDong.TabIndex = 0;
            this.comboBox_rent_aptDong.SelectionChangeCommitted += new System.EventHandler(this.comboBox_rent_aptDong_SelectionChangeCommitted);
            // 
            // comboBox_rent_aptCity
            // 
            this.comboBox_rent_aptCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_rent_aptCity.DropDownWidth = 150;
            this.comboBox_rent_aptCity.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_rent_aptCity.FormattingEnabled = true;
            this.comboBox_rent_aptCity.Location = new System.Drawing.Point(5, 24);
            this.comboBox_rent_aptCity.Margin = new System.Windows.Forms.Padding(5);
            this.comboBox_rent_aptCity.Name = "comboBox_rent_aptCity";
            this.comboBox_rent_aptCity.Size = new System.Drawing.Size(164, 30);
            this.comboBox_rent_aptCity.TabIndex = 1;
            this.comboBox_rent_aptCity.SelectionChangeCommitted += new System.EventHandler(this.comboBox_rent_aptCity_SelectionChangeCommitted);
            // 
            // groupBox_rent_money
            // 
            this.groupBox_rent_money.AutoSize = true;
            this.groupBox_rent_money.Controls.Add(this.comboBox_rent_aptDeposit);
            this.groupBox_rent_money.Controls.Add(this.comboBox_rent_aptLease);
            this.groupBox_rent_money.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_rent_money.Location = new System.Drawing.Point(0, 0);
            this.groupBox_rent_money.Name = "groupBox_rent_money";
            this.groupBox_rent_money.Size = new System.Drawing.Size(330, 66);
            this.groupBox_rent_money.TabIndex = 4;
            this.groupBox_rent_money.TabStop = false;
            this.groupBox_rent_money.Text = "월세/보증금(만원)";
            // 
            // comboBox_rent_aptDeposit
            // 
            this.comboBox_rent_aptDeposit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_rent_aptDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_rent_aptDeposit.FormattingEnabled = true;
            this.comboBox_rent_aptDeposit.Location = new System.Drawing.Point(112, 24);
            this.comboBox_rent_aptDeposit.Name = "comboBox_rent_aptDeposit";
            this.comboBox_rent_aptDeposit.Size = new System.Drawing.Size(215, 30);
            this.comboBox_rent_aptDeposit.TabIndex = 1;
            this.comboBox_rent_aptDeposit.SelectionChangeCommitted += new System.EventHandler(this.comboBox_rent_aptDeposit_SelectionChangeCommitted);
            // 
            // comboBox_rent_aptLease
            // 
            this.comboBox_rent_aptLease.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_rent_aptLease.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_rent_aptLease.FormattingEnabled = true;
            this.comboBox_rent_aptLease.Location = new System.Drawing.Point(6, 24);
            this.comboBox_rent_aptLease.Name = "comboBox_rent_aptLease";
            this.comboBox_rent_aptLease.Size = new System.Drawing.Size(100, 30);
            this.comboBox_rent_aptLease.TabIndex = 0;
            this.comboBox_rent_aptLease.SelectionChangeCommitted += new System.EventHandler(this.comboBox_rent_aptLease_SelectionChangeCommitted);
            // 
            // dataGridView_rent_view
            // 
            this.dataGridView_rent_view.AllowUserToAddRows = false;
            this.dataGridView_rent_view.AllowUserToDeleteRows = false;
            this.dataGridView_rent_view.AllowUserToResizeRows = false;
            this.dataGridView_rent_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_rent_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_rent_view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_rent_view.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView_rent_view.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_rent_view.MultiSelect = false;
            this.dataGridView_rent_view.Name = "dataGridView_rent_view";
            this.dataGridView_rent_view.ReadOnly = true;
            this.dataGridView_rent_view.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_rent_view.RowTemplate.Height = 23;
            this.dataGridView_rent_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_rent_view.Size = new System.Drawing.Size(778, 333);
            this.dataGridView_rent_view.TabIndex = 0;
            this.dataGridView_rent_view.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::TeamProject1.Properties.Resources.그림11;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1168, 124);
            this.panel1.TabIndex = 0;
            // 
            // bottom_panel_banner
            // 
            this.bottom_panel_banner.BackgroundImage = global::TeamProject1.Properties.Resources.banner1;
            this.bottom_panel_banner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bottom_panel_banner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottom_panel_banner.Location = new System.Drawing.Point(6, 595);
            this.bottom_panel_banner.Name = "bottom_panel_banner";
            this.bottom_panel_banner.Size = new System.Drawing.Size(1168, 60);
            this.bottom_panel_banner.TabIndex = 1;
            this.bottom_panel_banner.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bottom_panel_banner_MouseClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1180, 661);
            this.Controls.Add(this.tableLayoutPanel_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "석방";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel_Main.ResumeLayout(false);
            this.top_panel_mainTitle.ResumeLayout(false);
            this.tabControl_main.ResumeLayout(false);
            this.tabPage__data_sell.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_sell_data)).EndInit();
            this.tabPage_data_rent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_rent_data)).EndInit();
            this.tabPage_sell_view.ResumeLayout(false);
            this.splitContainer_sell.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_sell)).EndInit();
            this.splitContainer_sell.ResumeLayout(false);
            this.splitContainer_sell_left.Panel1.ResumeLayout(false);
            this.splitContainer_sell_left.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_sell_left)).EndInit();
            this.splitContainer_sell_left.ResumeLayout(false);
            this.splitContainer_sell_left_top.Panel1.ResumeLayout(false);
            this.splitContainer_sell_left_top.Panel1.PerformLayout();
            this.splitContainer_sell_left_top.Panel2.ResumeLayout(false);
            this.splitContainer_sell_left_top.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_sell_left_top)).EndInit();
            this.splitContainer_sell_left_top.ResumeLayout(false);
            this.groupBox_sell_address.ResumeLayout(false);
            this.groupBox_sell_money.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_sell_view)).EndInit();
            this.tabPage_rent_view.ResumeLayout(false);
            this.splitContainer_rent.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_rent)).EndInit();
            this.splitContainer_rent.ResumeLayout(false);
            this.splitContainer_rent_view_main.Panel1.ResumeLayout(false);
            this.splitContainer_rent_view_main.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_rent_view_main)).EndInit();
            this.splitContainer_rent_view_main.ResumeLayout(false);
            this.splitContainer_rent_left_top.Panel1.ResumeLayout(false);
            this.splitContainer_rent_left_top.Panel1.PerformLayout();
            this.splitContainer_rent_left_top.Panel2.ResumeLayout(false);
            this.splitContainer_rent_left_top.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_rent_left_top)).EndInit();
            this.splitContainer_rent_left_top.ResumeLayout(false);
            this.groupBox_rent_address.ResumeLayout(false);
            this.groupBox_rent_money.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_rent_view)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Main;
        private System.Windows.Forms.Panel top_panel_mainTitle;
        private System.Windows.Forms.Panel bottom_panel_banner;
        private System.Windows.Forms.TabControl tabControl_main;
        private System.Windows.Forms.TabPage tabPage__data_sell;
        private System.Windows.Forms.DataGridView dataGridView_sell_data;
        private System.Windows.Forms.TabPage tabPage_data_rent;
        private System.Windows.Forms.DataGridView dataGridView_rent_data;
        private System.Windows.Forms.TabPage tabPage_sell_view;
        private System.Windows.Forms.SplitContainer splitContainer_sell;
        private System.Windows.Forms.SplitContainer splitContainer_sell_left;
        private System.Windows.Forms.SplitContainer splitContainer_sell_left_top;
        private System.Windows.Forms.GroupBox groupBox_sell_address;
        private System.Windows.Forms.ComboBox comboBox_sell_aptNm;
        private System.Windows.Forms.ComboBox comboBox_sell_aptDong;
        private System.Windows.Forms.ComboBox comboBox_sell_aptCity;
        private System.Windows.Forms.GroupBox groupBox_sell_money;
        private System.Windows.Forms.ComboBox comboBox_sell_aptAmt;
        private System.Windows.Forms.DataGridView dataGridView_sell_view;
        private System.Windows.Forms.TabPage tabPage_rent_view;
        private System.Windows.Forms.SplitContainer splitContainer_rent;
        private System.Windows.Forms.SplitContainer splitContainer_rent_view_main;
        private System.Windows.Forms.SplitContainer splitContainer_rent_left_top;
        private System.Windows.Forms.GroupBox groupBox_rent_address;
        private System.Windows.Forms.ComboBox comboBox_rent_aptNm;
        private System.Windows.Forms.ComboBox comboBox_rent_aptDong;
        private System.Windows.Forms.ComboBox comboBox_rent_aptCity;
        private System.Windows.Forms.GroupBox groupBox_rent_money;
        private System.Windows.Forms.ComboBox comboBox_rent_aptDeposit;
        private System.Windows.Forms.ComboBox comboBox_rent_aptLease;
        private System.Windows.Forms.DataGridView dataGridView_rent_view;
        private System.Windows.Forms.Panel panel1;
    }
}

