namespace CoinKeeper
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_privatekey = new MaterialSkin.Controls.MaterialTextBox2();
            this.btn_login = new MaterialSkin.Controls.MaterialButton();
            this.btn_createaccount = new MaterialSkin.Controls.MaterialButton();
            this.btn_addaccount = new MaterialSkin.Controls.MaterialButton();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cb_network = new MaterialSkin.Controls.MaterialComboBox();
            this.btn_refresh = new MaterialSkin.Controls.MaterialButton();
            this.lb_balance = new MaterialSkin.Controls.MaterialLabel();
            this.lb_address = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel40 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_tokenaddress = new MaterialSkin.Controls.MaterialTextBox2();
            this.lv_token = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.btn_add = new MaterialSkin.Controls.MaterialButton();
            this.btn_remove = new MaterialSkin.Controls.MaterialButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lv_transaction = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.cb_token = new MaterialSkin.Controls.MaterialComboBox();
            this.tb_toaddress = new MaterialSkin.Controls.MaterialTextBox2();
            this.tb_amount = new MaterialSkin.Controls.MaterialTextBox2();
            this.tb_gas = new MaterialSkin.Controls.MaterialTextBox2();
            this.tb_gasprice = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.lb_msg = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btn_send = new MaterialSkin.Controls.MaterialButton();
            this.IconList = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage5);
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Controls.Add(this.tabPage4);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.IconList;
            this.materialTabControl1.Location = new System.Drawing.Point(2, 43);
            this.materialTabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(725, 535);
            this.materialTabControl1.TabIndex = 1;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.tableLayoutPanel5);
            this.tabPage5.ImageKey = "round_gps_fixed_white_24dp.png";
            this.tabPage5.Location = new System.Drawing.Point(4, 31);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(717, 500);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Account";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.tb_privatekey, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.btn_login, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.btn_createaccount, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.btn_addaccount, 1, 3);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 5;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(717, 500);
            this.tableLayoutPanel5.TabIndex = 6;
            // 
            // tb_privatekey
            // 
            this.tb_privatekey.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_privatekey.AnimateReadOnly = false;
            this.tb_privatekey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tb_privatekey.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tableLayoutPanel5.SetColumnSpan(this.tb_privatekey, 2);
            this.tb_privatekey.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_privatekey.Depth = 0;
            this.tb_privatekey.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_privatekey.HideSelection = true;
            this.tb_privatekey.Hint = "Password";
            this.tb_privatekey.LeadingIcon = global::CoinKeeper.Properties.Resources.baseline_fingerprint_black_24dp;
            this.tb_privatekey.Location = new System.Drawing.Point(155, 178);
            this.tb_privatekey.MaxLength = 100;
            this.tb_privatekey.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_privatekey.Name = "tb_privatekey";
            this.tb_privatekey.PasswordChar = '●';
            this.tb_privatekey.PrefixSuffixText = null;
            this.tb_privatekey.ReadOnly = false;
            this.tb_privatekey.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_privatekey.SelectedText = "";
            this.tb_privatekey.SelectionLength = 0;
            this.tb_privatekey.SelectionStart = 0;
            this.tb_privatekey.ShortcutsEnabled = true;
            this.tb_privatekey.Size = new System.Drawing.Size(406, 48);
            this.tb_privatekey.TabIndex = 4;
            this.tb_privatekey.TabStop = false;
            this.tb_privatekey.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_privatekey.TrailingIcon = null;
            this.tb_privatekey.UseSystemPasswordChar = true;
            // 
            // btn_login
            // 
            this.btn_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_login.AutoSize = false;
            this.btn_login.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel5.SetColumnSpan(this.btn_login, 2);
            this.btn_login.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_login.Depth = 0;
            this.btn_login.HighEmphasis = false;
            this.btn_login.Icon = global::CoinKeeper.Properties.Resources.baseline_favorite_border_black_24dp;
            this.btn_login.Location = new System.Drawing.Point(264, 233);
            this.btn_login.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_login.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_login.Name = "btn_login";
            this.btn_login.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_login.Size = new System.Drawing.Size(189, 33);
            this.btn_login.TabIndex = 14;
            this.btn_login.Text = "Login";
            this.btn_login.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btn_login.UseAccentColor = false;
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_createaccount
            // 
            this.btn_createaccount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_createaccount.AutoSize = false;
            this.btn_createaccount.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_createaccount.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_createaccount.Depth = 0;
            this.btn_createaccount.HighEmphasis = true;
            this.btn_createaccount.Icon = null;
            this.btn_createaccount.Location = new System.Drawing.Point(165, 283);
            this.btn_createaccount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_createaccount.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_createaccount.Name = "btn_createaccount";
            this.btn_createaccount.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_createaccount.Size = new System.Drawing.Size(189, 33);
            this.btn_createaccount.TabIndex = 15;
            this.btn_createaccount.Text = "Create A New Account";
            this.btn_createaccount.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btn_createaccount.UseAccentColor = false;
            this.btn_createaccount.UseVisualStyleBackColor = true;
            // 
            // btn_addaccount
            // 
            this.btn_addaccount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_addaccount.AutoSize = false;
            this.btn_addaccount.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_addaccount.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_addaccount.Depth = 0;
            this.btn_addaccount.HighEmphasis = true;
            this.btn_addaccount.Icon = null;
            this.btn_addaccount.Location = new System.Drawing.Point(362, 283);
            this.btn_addaccount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_addaccount.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_addaccount.Name = "btn_addaccount";
            this.btn_addaccount.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_addaccount.Size = new System.Drawing.Size(189, 33);
            this.btn_addaccount.TabIndex = 16;
            this.btn_addaccount.Text = "Add an Account";
            this.btn_addaccount.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btn_addaccount.UseAccentColor = true;
            this.btn_addaccount.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.ImageKey = "round_bookmark_white_24dp.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(717, 500);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.cb_network, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_refresh, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lb_balance, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lb_address, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel40, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel5, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(713, 496);
            this.tableLayoutPanel1.TabIndex = 91;
            // 
            // cb_network
            // 
            this.cb_network.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cb_network.AutoResize = false;
            this.cb_network.BackColor = System.Drawing.Color.White;
            this.cb_network.Depth = 0;
            this.cb_network.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cb_network.DropDownHeight = 174;
            this.cb_network.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_network.DropDownWidth = 121;
            this.cb_network.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_network.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cb_network.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cb_network.FormattingEnabled = true;
            this.cb_network.Hint = "Network:";
            this.cb_network.IntegralHeight = false;
            this.cb_network.ItemHeight = 43;
            this.cb_network.Items.AddRange(new object[] {
            "ETH-Sepolia"});
            this.cb_network.Location = new System.Drawing.Point(3, 85);
            this.cb_network.MaxDropDownItems = 4;
            this.cb_network.MouseState = MaterialSkin.MouseState.OUT;
            this.cb_network.Name = "cb_network";
            this.cb_network.Size = new System.Drawing.Size(223, 49);
            this.cb_network.StartIndex = 0;
            this.cb_network.TabIndex = 88;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_refresh.AutoSize = false;
            this.btn_refresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_refresh.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_refresh.Depth = 0;
            this.btn_refresh.HighEmphasis = true;
            this.btn_refresh.Icon = null;
            this.btn_refresh.Location = new System.Drawing.Point(360, 93);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_refresh.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_refresh.Size = new System.Drawing.Size(168, 33);
            this.btn_refresh.TabIndex = 90;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_refresh.UseAccentColor = false;
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // lb_balance
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.lb_balance, 2);
            this.lb_balance.Depth = 0;
            this.lb_balance.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lb_balance.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lb_balance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_balance.HighEmphasis = true;
            this.lb_balance.Location = new System.Drawing.Point(3, 407);
            this.lb_balance.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_balance.Name = "lb_balance";
            this.lb_balance.Size = new System.Drawing.Size(600, 27);
            this.lb_balance.TabIndex = 87;
            this.lb_balance.Text = "0";
            this.lb_balance.UseAccent = true;
            // 
            // lb_address
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.lb_address, 2);
            this.lb_address.Depth = 0;
            this.lb_address.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lb_address.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lb_address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_address.HighEmphasis = true;
            this.lb_address.Location = new System.Drawing.Point(3, 237);
            this.lb_address.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_address.Name = "lb_address";
            this.lb_address.Size = new System.Drawing.Size(600, 27);
            this.lb_address.TabIndex = 85;
            this.lb_address.Text = "0x0000000000000000000000000000000000000000";
            this.lb_address.UseAccent = true;
            // 
            // materialLabel4
            // 
            this.materialLabel4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel4.Location = new System.Drawing.Point(2, 13);
            this.materialLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(143, 40);
            this.materialLabel4.TabIndex = 91;
            this.materialLabel4.Text = "Home";
            // 
            // materialLabel40
            // 
            this.materialLabel40.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.materialLabel40.Depth = 0;
            this.materialLabel40.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel40.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel40.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel40.HighEmphasis = true;
            this.materialLabel40.Location = new System.Drawing.Point(3, 178);
            this.materialLabel40.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel40.Name = "materialLabel40";
            this.materialLabel40.Size = new System.Drawing.Size(143, 33);
            this.materialLabel40.TabIndex = 92;
            this.materialLabel40.Text = "Address:";
            // 
            // materialLabel5
            // 
            this.materialLabel5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.HighEmphasis = true;
            this.materialLabel5.Location = new System.Drawing.Point(3, 348);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(143, 33);
            this.materialLabel5.TabIndex = 93;
            this.materialLabel5.Text = "Balance:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.ImageKey = "round_assessment_white_24dp.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(717, 500);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Token";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tableLayoutPanel2.Controls.Add(this.tb_tokenaddress, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lv_token, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.materialLabel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_add, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.btn_remove, 2, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(713, 496);
            this.tableLayoutPanel2.TabIndex = 37;
            // 
            // tb_tokenaddress
            // 
            this.tb_tokenaddress.AnimateReadOnly = false;
            this.tb_tokenaddress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tb_tokenaddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tb_tokenaddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_tokenaddress.Depth = 0;
            this.tb_tokenaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_tokenaddress.HideSelection = true;
            this.tb_tokenaddress.Hint = "TokenAddress";
            this.tb_tokenaddress.LeadingIcon = null;
            this.tb_tokenaddress.Location = new System.Drawing.Point(3, 456);
            this.tb_tokenaddress.MaxLength = 50;
            this.tb_tokenaddress.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_tokenaddress.Name = "tb_tokenaddress";
            this.tb_tokenaddress.PasswordChar = '\0';
            this.tb_tokenaddress.PrefixSuffixText = null;
            this.tb_tokenaddress.ReadOnly = false;
            this.tb_tokenaddress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_tokenaddress.SelectedText = "";
            this.tb_tokenaddress.SelectionLength = 0;
            this.tb_tokenaddress.SelectionStart = 0;
            this.tb_tokenaddress.ShortcutsEnabled = true;
            this.tb_tokenaddress.Size = new System.Drawing.Size(406, 48);
            this.tb_tokenaddress.TabIndex = 93;
            this.tb_tokenaddress.TabStop = false;
            this.tb_tokenaddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_tokenaddress.TrailingIcon = null;
            this.tb_tokenaddress.UseSystemPasswordChar = false;
            // 
            // lv_token
            // 
            this.lv_token.AutoSizeTable = false;
            this.lv_token.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lv_token.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lv_token.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.tableLayoutPanel2.SetColumnSpan(this.lv_token, 3);
            this.lv_token.Depth = 0;
            this.lv_token.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_token.FullRowSelect = true;
            this.lv_token.HideSelection = false;
            this.lv_token.Location = new System.Drawing.Point(2, 69);
            this.lv_token.Margin = new System.Windows.Forms.Padding(2);
            this.lv_token.MinimumSize = new System.Drawing.Size(133, 67);
            this.lv_token.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lv_token.MouseState = MaterialSkin.MouseState.OUT;
            this.lv_token.Name = "lv_token";
            this.lv_token.OwnerDraw = true;
            this.lv_token.Size = new System.Drawing.Size(709, 382);
            this.lv_token.TabIndex = 36;
            this.lv_token.UseCompatibleStateImageBehavior = false;
            this.lv_token.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Symbol";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Balance";
            this.columnHeader2.Width = 400;
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel3.Location = new System.Drawing.Point(2, 13);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(143, 40);
            this.materialLabel3.TabIndex = 92;
            this.materialLabel3.Text = "Token";
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_add.AutoSize = false;
            this.btn_add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_add.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_add.Depth = 0;
            this.btn_add.HighEmphasis = true;
            this.btn_add.Icon = null;
            this.btn_add.Location = new System.Drawing.Point(451, 458);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_add.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_add.Name = "btn_add";
            this.btn_add.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_add.Size = new System.Drawing.Size(100, 33);
            this.btn_add.TabIndex = 91;
            this.btn_add.Text = "Add";
            this.btn_add.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_add.UseAccentColor = false;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_remove.AutoSize = false;
            this.btn_remove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_remove.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_remove.Depth = 0;
            this.btn_remove.HighEmphasis = true;
            this.btn_remove.Icon = null;
            this.btn_remove.Location = new System.Drawing.Point(584, 458);
            this.btn_remove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_remove.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_remove.Size = new System.Drawing.Size(100, 33);
            this.btn_remove.TabIndex = 38;
            this.btn_remove.Text = "Remove";
            this.btn_remove.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_remove.UseAccentColor = true;
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel3);
            this.tabPage3.ImageKey = "round_swap_vert_white_24dp.png";
            this.tabPage3.Location = new System.Drawing.Point(4, 31);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(717, 500);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Transaction";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.lv_transaction, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.materialLabel2, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(713, 496);
            this.tableLayoutPanel3.TabIndex = 36;
            // 
            // lv_transaction
            // 
            this.lv_transaction.AutoSizeTable = false;
            this.lv_transaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lv_transaction.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lv_transaction.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3});
            this.tableLayoutPanel3.SetColumnSpan(this.lv_transaction, 3);
            this.lv_transaction.Depth = 0;
            this.lv_transaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_transaction.FullRowSelect = true;
            this.lv_transaction.HideSelection = false;
            this.lv_transaction.Location = new System.Drawing.Point(2, 69);
            this.lv_transaction.Margin = new System.Windows.Forms.Padding(2);
            this.lv_transaction.MinimumSize = new System.Drawing.Size(133, 67);
            this.lv_transaction.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lv_transaction.MouseState = MaterialSkin.MouseState.OUT;
            this.lv_transaction.Name = "lv_transaction";
            this.lv_transaction.OwnerDraw = true;
            this.lv_transaction.Size = new System.Drawing.Size(709, 425);
            this.lv_transaction.TabIndex = 37;
            this.lv_transaction.UseCompatibleStateImageBehavior = false;
            this.lv_transaction.View = System.Windows.Forms.View.Details;
            this.lv_transaction.DoubleClick += new System.EventHandler(this.lv_transaction_DoubleClick);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "History Transaction Hash";
            this.columnHeader3.Width = 900;
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel2.Location = new System.Drawing.Point(2, 13);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(187, 40);
            this.materialLabel2.TabIndex = 38;
            this.materialLabel2.Text = "Transaction";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.tableLayoutPanel4);
            this.tabPage4.ImageKey = "round_backup_white_24dp.png";
            this.tabPage4.Location = new System.Drawing.Point(4, 31);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage4.Size = new System.Drawing.Size(717, 500);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Transfer";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tableLayoutPanel4.Controls.Add(this.materialLabel14, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.cb_token, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.tb_toaddress, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.tb_amount, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.tb_gas, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.tb_gasprice, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.materialCard1, 0, 6);
            this.tableLayoutPanel4.Controls.Add(this.btn_send, 1, 7);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 8;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(713, 496);
            this.tableLayoutPanel4.TabIndex = 36;
            // 
            // materialLabel14
            // 
            this.materialLabel14.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel14.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel14.Location = new System.Drawing.Point(3, 13);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(143, 40);
            this.materialLabel14.TabIndex = 94;
            this.materialLabel14.Text = "Transfer";
            // 
            // cb_token
            // 
            this.cb_token.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cb_token.AutoResize = false;
            this.cb_token.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel4.SetColumnSpan(this.cb_token, 2);
            this.cb_token.Depth = 0;
            this.cb_token.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cb_token.DropDownHeight = 174;
            this.cb_token.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_token.DropDownWidth = 121;
            this.cb_token.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_token.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cb_token.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cb_token.FormattingEnabled = true;
            this.cb_token.Hint = "Token";
            this.cb_token.IntegralHeight = false;
            this.cb_token.ItemHeight = 43;
            this.cb_token.Items.AddRange(new object[] {
            "ETH"});
            this.cb_token.Location = new System.Drawing.Point(3, 121);
            this.cb_token.MaxDropDownItems = 4;
            this.cb_token.MouseState = MaterialSkin.MouseState.OUT;
            this.cb_token.Name = "cb_token";
            this.cb_token.Size = new System.Drawing.Size(685, 49);
            this.cb_token.StartIndex = 0;
            this.cb_token.TabIndex = 93;
            // 
            // tb_toaddress
            // 
            this.tb_toaddress.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_toaddress.AnimateReadOnly = false;
            this.tb_toaddress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tb_toaddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tableLayoutPanel4.SetColumnSpan(this.tb_toaddress, 2);
            this.tb_toaddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_toaddress.Depth = 0;
            this.tb_toaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_toaddress.HideSelection = true;
            this.tb_toaddress.Hint = "ToAddress";
            this.tb_toaddress.LeadingIcon = null;
            this.tb_toaddress.Location = new System.Drawing.Point(3, 70);
            this.tb_toaddress.MaxLength = 50;
            this.tb_toaddress.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_toaddress.Name = "tb_toaddress";
            this.tb_toaddress.PasswordChar = '\0';
            this.tb_toaddress.PrefixSuffixText = null;
            this.tb_toaddress.ReadOnly = false;
            this.tb_toaddress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_toaddress.SelectedText = "";
            this.tb_toaddress.SelectionLength = 0;
            this.tb_toaddress.SelectionStart = 0;
            this.tb_toaddress.ShortcutsEnabled = true;
            this.tb_toaddress.Size = new System.Drawing.Size(684, 48);
            this.tb_toaddress.TabIndex = 36;
            this.tb_toaddress.TabStop = false;
            this.tb_toaddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_toaddress.TrailingIcon = null;
            this.tb_toaddress.UseSystemPasswordChar = false;
            // 
            // tb_amount
            // 
            this.tb_amount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_amount.AnimateReadOnly = false;
            this.tb_amount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tb_amount.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tableLayoutPanel4.SetColumnSpan(this.tb_amount, 2);
            this.tb_amount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_amount.Depth = 0;
            this.tb_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_amount.HideSelection = true;
            this.tb_amount.Hint = "Amount";
            this.tb_amount.LeadingIcon = null;
            this.tb_amount.Location = new System.Drawing.Point(3, 172);
            this.tb_amount.MaxLength = 50;
            this.tb_amount.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_amount.Name = "tb_amount";
            this.tb_amount.PasswordChar = '\0';
            this.tb_amount.PrefixSuffixText = null;
            this.tb_amount.ReadOnly = false;
            this.tb_amount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_amount.SelectedText = "";
            this.tb_amount.SelectionLength = 0;
            this.tb_amount.SelectionStart = 0;
            this.tb_amount.ShortcutsEnabled = true;
            this.tb_amount.Size = new System.Drawing.Size(684, 48);
            this.tb_amount.TabIndex = 38;
            this.tb_amount.TabStop = false;
            this.tb_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_amount.TrailingIcon = null;
            this.tb_amount.UseSystemPasswordChar = false;
            // 
            // tb_gas
            // 
            this.tb_gas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_gas.AnimateReadOnly = false;
            this.tb_gas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tb_gas.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tableLayoutPanel4.SetColumnSpan(this.tb_gas, 2);
            this.tb_gas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_gas.Depth = 0;
            this.tb_gas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_gas.HideSelection = true;
            this.tb_gas.Hint = "Gas";
            this.tb_gas.LeadingIcon = null;
            this.tb_gas.Location = new System.Drawing.Point(3, 223);
            this.tb_gas.MaxLength = 50;
            this.tb_gas.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_gas.Name = "tb_gas";
            this.tb_gas.PasswordChar = '\0';
            this.tb_gas.PrefixSuffixText = null;
            this.tb_gas.ReadOnly = false;
            this.tb_gas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_gas.SelectedText = "";
            this.tb_gas.SelectionLength = 0;
            this.tb_gas.SelectionStart = 0;
            this.tb_gas.ShortcutsEnabled = true;
            this.tb_gas.Size = new System.Drawing.Size(684, 48);
            this.tb_gas.TabIndex = 39;
            this.tb_gas.TabStop = false;
            this.tb_gas.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_gas.TrailingIcon = null;
            this.tb_gas.UseSystemPasswordChar = false;
            // 
            // tb_gasprice
            // 
            this.tb_gasprice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_gasprice.AnimateReadOnly = false;
            this.tb_gasprice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tb_gasprice.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tableLayoutPanel4.SetColumnSpan(this.tb_gasprice, 2);
            this.tb_gasprice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_gasprice.Depth = 0;
            this.tb_gasprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_gasprice.HideSelection = true;
            this.tb_gasprice.Hint = "Gas Price";
            this.tb_gasprice.LeadingIcon = null;
            this.tb_gasprice.Location = new System.Drawing.Point(3, 274);
            this.tb_gasprice.MaxLength = 50;
            this.tb_gasprice.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_gasprice.Name = "tb_gasprice";
            this.tb_gasprice.PasswordChar = '\0';
            this.tb_gasprice.PrefixSuffixText = null;
            this.tb_gasprice.ReadOnly = false;
            this.tb_gasprice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_gasprice.SelectedText = "";
            this.tb_gasprice.SelectionLength = 0;
            this.tb_gasprice.SelectionStart = 0;
            this.tb_gasprice.ShortcutsEnabled = true;
            this.tb_gasprice.Size = new System.Drawing.Size(684, 48);
            this.tb_gasprice.TabIndex = 40;
            this.tb_gasprice.TabStop = false;
            this.tb_gasprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_gasprice.TrailingIcon = null;
            this.tb_gasprice.UseSystemPasswordChar = false;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.lb_msg);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(9, 331);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(9);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(9);
            this.tableLayoutPanel4.SetRowSpan(this.materialCard1, 2);
            this.materialCard1.Size = new System.Drawing.Size(562, 156);
            this.materialCard1.TabIndex = 95;
            // 
            // lb_msg
            // 
            this.lb_msg.AutoSize = true;
            this.lb_msg.Depth = 0;
            this.lb_msg.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lb_msg.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lb_msg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_msg.Location = new System.Drawing.Point(12, 35);
            this.lb_msg.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_msg.Name = "lb_msg";
            this.lb_msg.Size = new System.Drawing.Size(26, 24);
            this.lb_msg.TabIndex = 73;
            this.lb_msg.Text = "Na";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.HighEmphasis = true;
            this.materialLabel1.Location = new System.Drawing.Point(12, 9);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(39, 24);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Log:";
            // 
            // btn_send
            // 
            this.btn_send.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_send.AutoSize = false;
            this.btn_send.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_send.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_send.Depth = 0;
            this.btn_send.HighEmphasis = true;
            this.btn_send.Icon = null;
            this.btn_send.Location = new System.Drawing.Point(584, 418);
            this.btn_send.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_send.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_send.Name = "btn_send";
            this.btn_send.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_send.Size = new System.Drawing.Size(100, 33);
            this.btn_send.TabIndex = 92;
            this.btn_send.Text = "Send";
            this.btn_send.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_send.UseAccentColor = false;
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // IconList
            // 
            this.IconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IconList.ImageStream")));
            this.IconList.TransparentColor = System.Drawing.Color.Transparent;
            this.IconList.Images.SetKeyName(0, "round_assessment_white_24dp.png");
            this.IconList.Images.SetKeyName(1, "round_backup_white_24dp.png");
            this.IconList.Images.SetKeyName(2, "round_bookmark_white_24dp.png");
            this.IconList.Images.SetKeyName(3, "round_swap_vert_white_24dp.png");
            this.IconList.Images.SetKeyName(4, "baseline_favorite_border_black_24dp.png");
            this.IconList.Images.SetKeyName(5, "baseline_fingerprint_black_24dp.png");
            this.IconList.Images.SetKeyName(6, "round_gps_fixed_white_24dp.png");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(729, 580);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(2, 43, 2, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CoinKeeper";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ImageList IconList;
        private MaterialSkin.Controls.MaterialComboBox cb_network;
        private MaterialSkin.Controls.MaterialLabel lb_balance;
        private MaterialSkin.Controls.MaterialLabel lb_address;
        private MaterialSkin.Controls.MaterialButton btn_refresh;
        private MaterialSkin.Controls.MaterialListView lv_token;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MaterialSkin.Controls.MaterialButton btn_remove;
        private MaterialSkin.Controls.MaterialButton btn_add;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private MaterialSkin.Controls.MaterialListView lv_transaction;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private MaterialSkin.Controls.MaterialTextBox2 tb_toaddress;
        private MaterialSkin.Controls.MaterialTextBox2 tb_amount;
        private MaterialSkin.Controls.MaterialTextBox2 tb_gas;
        private MaterialSkin.Controls.MaterialTextBox2 tb_gasprice;
        private MaterialSkin.Controls.MaterialButton btn_send;
        private MaterialSkin.Controls.MaterialComboBox cb_token;
        private System.Windows.Forms.TabPage tabPage5;
        private MaterialSkin.Controls.MaterialTextBox2 tb_privatekey;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel40;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialTextBox2 tb_tokenaddress;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel lb_msg;
        private MaterialSkin.Controls.MaterialButton btn_login;
        private MaterialSkin.Controls.MaterialButton btn_createaccount;
        private MaterialSkin.Controls.MaterialButton btn_addaccount;
    }
}

