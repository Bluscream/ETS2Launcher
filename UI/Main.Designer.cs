namespace ETS2Launcher
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel_full = new System.Windows.Forms.Panel();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabs_main = new MaterialSkin.Controls.MaterialTabControl();
            this.tab_news = new System.Windows.Forms.TabPage();
            this.tab_game = new System.Windows.Forms.TabPage();
            this.tab_mods = new System.Windows.Forms.TabPage();
            this.tabselect_mods = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabs_mods = new MaterialSkin.Controls.MaterialTabControl();
            this.tab_mods_installed = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_mods_reload = new System.Windows.Forms.Button();
            this.lst_mods_installed = new MaterialSkin.Controls.MaterialListView();
            this.menu_mod = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_mod_name = new MaterialSkin.Controls.MaterialLabel();
            this.txt_mod_name = new System.Windows.Forms.TextBox();
            this.tab_mods_available = new System.Windows.Forms.TabPage();
            this.tab_plugins = new System.Windows.Forms.TabPage();
            this.tabselect_plugins = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabs_plugins = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btn_plugins_reload = new System.Windows.Forms.Button();
            this.lst_plugins_installed = new MaterialSkin.Controls.MaterialListView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tab_settings = new System.Windows.Forms.TabPage();
            this.panel_status = new System.Windows.Forms.Panel();
            this.txt_status = new System.Windows.Forms.TextBox();
            this.btn_play = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel_full.SuspendLayout();
            this.tabs_main.SuspendLayout();
            this.tab_mods.SuspendLayout();
            this.tabs_mods.SuspendLayout();
            this.tab_mods_installed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tab_plugins.SuspendLayout();
            this.tabs_plugins.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel_status.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_full
            // 
            this.panel_full.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_full.Controls.Add(this.materialTabSelector1);
            this.panel_full.Controls.Add(this.tabs_main);
            this.panel_full.Controls.Add(this.panel_status);
            this.panel_full.Location = new System.Drawing.Point(12, 78);
            this.panel_full.Name = "panel_full";
            this.panel_full.Size = new System.Drawing.Size(1031, 568);
            this.panel_full.TabIndex = 1;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.tabs_main;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 0);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1031, 23);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // tabs_main
            // 
            this.tabs_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabs_main.Controls.Add(this.tab_news);
            this.tabs_main.Controls.Add(this.tab_game);
            this.tabs_main.Controls.Add(this.tab_mods);
            this.tabs_main.Controls.Add(this.tab_plugins);
            this.tabs_main.Controls.Add(this.tab_settings);
            this.tabs_main.Depth = 0;
            this.tabs_main.Location = new System.Drawing.Point(3, 32);
            this.tabs_main.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabs_main.Name = "tabs_main";
            this.tabs_main.SelectedIndex = 0;
            this.tabs_main.Size = new System.Drawing.Size(1025, 473);
            this.tabs_main.TabIndex = 1;
            this.tabs_main.SelectedIndexChanged += new System.EventHandler(this.Tabs_main_SelectedIndexChanged);
            // 
            // tab_news
            // 
            this.tab_news.Location = new System.Drawing.Point(4, 22);
            this.tab_news.Name = "tab_news";
            this.tab_news.Padding = new System.Windows.Forms.Padding(3);
            this.tab_news.Size = new System.Drawing.Size(1017, 447);
            this.tab_news.TabIndex = 0;
            this.tab_news.Text = "News";
            this.tab_news.UseVisualStyleBackColor = true;
            // 
            // tab_game
            // 
            this.tab_game.BackColor = System.Drawing.Color.DimGray;
            this.tab_game.Location = new System.Drawing.Point(4, 22);
            this.tab_game.Name = "tab_game";
            this.tab_game.Padding = new System.Windows.Forms.Padding(3);
            this.tab_game.Size = new System.Drawing.Size(1017, 447);
            this.tab_game.TabIndex = 1;
            this.tab_game.Text = "Game";
            // 
            // tab_mods
            // 
            this.tab_mods.Controls.Add(this.tabselect_mods);
            this.tab_mods.Controls.Add(this.tabs_mods);
            this.tab_mods.Location = new System.Drawing.Point(4, 22);
            this.tab_mods.Name = "tab_mods";
            this.tab_mods.Padding = new System.Windows.Forms.Padding(3);
            this.tab_mods.Size = new System.Drawing.Size(1017, 447);
            this.tab_mods.TabIndex = 2;
            this.tab_mods.Text = "Mods";
            this.tab_mods.UseVisualStyleBackColor = true;
            // 
            // tabselect_mods
            // 
            this.tabselect_mods.BaseTabControl = this.tabs_mods;
            this.tabselect_mods.Depth = 0;
            this.tabselect_mods.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabselect_mods.Location = new System.Drawing.Point(3, 3);
            this.tabselect_mods.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabselect_mods.Name = "tabselect_mods";
            this.tabselect_mods.Size = new System.Drawing.Size(1011, 23);
            this.tabselect_mods.TabIndex = 1;
            this.tabselect_mods.Text = "materialTabSelector2";
            // 
            // tabs_mods
            // 
            this.tabs_mods.Controls.Add(this.tab_mods_installed);
            this.tabs_mods.Controls.Add(this.tab_mods_available);
            this.tabs_mods.Depth = 0;
            this.tabs_mods.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabs_mods.Location = new System.Drawing.Point(3, 32);
            this.tabs_mods.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabs_mods.Name = "tabs_mods";
            this.tabs_mods.SelectedIndex = 0;
            this.tabs_mods.Size = new System.Drawing.Size(1011, 412);
            this.tabs_mods.TabIndex = 0;
            // 
            // tab_mods_installed
            // 
            this.tab_mods_installed.Controls.Add(this.splitContainer1);
            this.tab_mods_installed.Location = new System.Drawing.Point(4, 22);
            this.tab_mods_installed.Name = "tab_mods_installed";
            this.tab_mods_installed.Padding = new System.Windows.Forms.Padding(3);
            this.tab_mods_installed.Size = new System.Drawing.Size(1003, 386);
            this.tab_mods_installed.TabIndex = 0;
            this.tab_mods_installed.Text = "Installed";
            this.tab_mods_installed.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btn_mods_reload);
            this.splitContainer1.Panel1.Controls.Add(this.lst_mods_installed);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(997, 380);
            this.splitContainer1.SplitterDistance = 221;
            this.splitContainer1.TabIndex = 2;
            // 
            // btn_mods_reload
            // 
            this.btn_mods_reload.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_mods_reload.Location = new System.Drawing.Point(0, 357);
            this.btn_mods_reload.Name = "btn_mods_reload";
            this.btn_mods_reload.Size = new System.Drawing.Size(221, 23);
            this.btn_mods_reload.TabIndex = 3;
            this.btn_mods_reload.Text = "Reload";
            this.btn_mods_reload.UseVisualStyleBackColor = true;
            this.btn_mods_reload.Click += new System.EventHandler(this.Btn_mods_reload_Click);
            // 
            // lst_mods_installed
            // 
            this.lst_mods_installed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lst_mods_installed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lst_mods_installed.ContextMenuStrip = this.menu_mod;
            this.lst_mods_installed.Depth = 0;
            this.lst_mods_installed.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lst_mods_installed.FullRowSelect = true;
            this.lst_mods_installed.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lst_mods_installed.HideSelection = false;
            this.lst_mods_installed.Location = new System.Drawing.Point(3, -3);
            this.lst_mods_installed.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lst_mods_installed.MouseState = MaterialSkin.MouseState.OUT;
            this.lst_mods_installed.Name = "lst_mods_installed";
            this.lst_mods_installed.OwnerDraw = true;
            this.lst_mods_installed.Size = new System.Drawing.Size(215, 354);
            this.lst_mods_installed.TabIndex = 2;
            this.lst_mods_installed.UseCompatibleStateImageBehavior = false;
            this.lst_mods_installed.View = System.Windows.Forms.View.Details;
            // 
            // menu_mod
            // 
            this.menu_mod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.menu_mod.Depth = 0;
            this.menu_mod.MouseState = MaterialSkin.MouseState.HOVER;
            this.menu_mod.Name = "menu_mod";
            this.menu_mod.Size = new System.Drawing.Size(61, 4);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_mod_name, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_mod_name, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(772, 380);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lbl_mod_name
            // 
            this.lbl_mod_name.AutoSize = true;
            this.lbl_mod_name.Depth = 0;
            this.lbl_mod_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_mod_name.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_mod_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_mod_name.Location = new System.Drawing.Point(3, 0);
            this.lbl_mod_name.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_mod_name.Name = "lbl_mod_name";
            this.lbl_mod_name.Size = new System.Drawing.Size(187, 190);
            this.lbl_mod_name.TabIndex = 0;
            this.lbl_mod_name.Text = "Name:";
            // 
            // txt_mod_name
            // 
            this.txt_mod_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_mod_name.Location = new System.Drawing.Point(196, 3);
            this.txt_mod_name.Name = "txt_mod_name";
            this.txt_mod_name.Size = new System.Drawing.Size(573, 20);
            this.txt_mod_name.TabIndex = 1;
            // 
            // tab_mods_available
            // 
            this.tab_mods_available.Location = new System.Drawing.Point(4, 22);
            this.tab_mods_available.Name = "tab_mods_available";
            this.tab_mods_available.Padding = new System.Windows.Forms.Padding(3);
            this.tab_mods_available.Size = new System.Drawing.Size(1003, 386);
            this.tab_mods_available.TabIndex = 1;
            this.tab_mods_available.Text = "Available";
            this.tab_mods_available.UseVisualStyleBackColor = true;
            // 
            // tab_plugins
            // 
            this.tab_plugins.Controls.Add(this.tabselect_plugins);
            this.tab_plugins.Controls.Add(this.tabs_plugins);
            this.tab_plugins.Location = new System.Drawing.Point(4, 22);
            this.tab_plugins.Name = "tab_plugins";
            this.tab_plugins.Padding = new System.Windows.Forms.Padding(3);
            this.tab_plugins.Size = new System.Drawing.Size(1017, 447);
            this.tab_plugins.TabIndex = 4;
            this.tab_plugins.Text = "Plugins";
            this.tab_plugins.UseVisualStyleBackColor = true;
            // 
            // tabselect_plugins
            // 
            this.tabselect_plugins.BaseTabControl = this.tabs_plugins;
            this.tabselect_plugins.Depth = 0;
            this.tabselect_plugins.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabselect_plugins.Location = new System.Drawing.Point(3, 3);
            this.tabselect_plugins.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabselect_plugins.Name = "tabselect_plugins";
            this.tabselect_plugins.Size = new System.Drawing.Size(1011, 23);
            this.tabselect_plugins.TabIndex = 3;
            this.tabselect_plugins.Text = "materialTabSelector2";
            // 
            // tabs_plugins
            // 
            this.tabs_plugins.Controls.Add(this.tabPage1);
            this.tabs_plugins.Controls.Add(this.tabPage2);
            this.tabs_plugins.Depth = 0;
            this.tabs_plugins.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabs_plugins.Location = new System.Drawing.Point(3, 32);
            this.tabs_plugins.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabs_plugins.Name = "tabs_plugins";
            this.tabs_plugins.SelectedIndex = 0;
            this.tabs_plugins.Size = new System.Drawing.Size(1011, 412);
            this.tabs_plugins.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1003, 386);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Installed";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.btn_plugins_reload);
            this.splitContainer2.Panel1.Controls.Add(this.lst_plugins_installed);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer2.Size = new System.Drawing.Size(997, 380);
            this.splitContainer2.SplitterDistance = 221;
            this.splitContainer2.TabIndex = 2;
            // 
            // btn_plugins_reload
            // 
            this.btn_plugins_reload.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_plugins_reload.Location = new System.Drawing.Point(0, 357);
            this.btn_plugins_reload.Name = "btn_plugins_reload";
            this.btn_plugins_reload.Size = new System.Drawing.Size(221, 23);
            this.btn_plugins_reload.TabIndex = 3;
            this.btn_plugins_reload.Text = "Reload";
            this.btn_plugins_reload.UseVisualStyleBackColor = true;
            this.btn_plugins_reload.Click += new System.EventHandler(this.Btn_plugins_reload_Click);
            // 
            // lst_plugins_installed
            // 
            this.lst_plugins_installed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lst_plugins_installed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lst_plugins_installed.ContextMenuStrip = this.menu_mod;
            this.lst_plugins_installed.Depth = 0;
            this.lst_plugins_installed.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lst_plugins_installed.FullRowSelect = true;
            this.lst_plugins_installed.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lst_plugins_installed.HideSelection = false;
            this.lst_plugins_installed.Location = new System.Drawing.Point(3, -3);
            this.lst_plugins_installed.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lst_plugins_installed.MouseState = MaterialSkin.MouseState.OUT;
            this.lst_plugins_installed.Name = "lst_plugins_installed";
            this.lst_plugins_installed.OwnerDraw = true;
            this.lst_plugins_installed.Size = new System.Drawing.Size(215, 354);
            this.lst_plugins_installed.TabIndex = 2;
            this.lst_plugins_installed.UseCompatibleStateImageBehavior = false;
            this.lst_plugins_installed.View = System.Windows.Forms.View.Details;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel2.Controls.Add(this.materialLabel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(772, 380);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(3, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(187, 190);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Name:";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(196, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(573, 20);
            this.textBox1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1003, 386);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Available";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tab_settings
            // 
            this.tab_settings.Location = new System.Drawing.Point(4, 22);
            this.tab_settings.Name = "tab_settings";
            this.tab_settings.Padding = new System.Windows.Forms.Padding(3);
            this.tab_settings.Size = new System.Drawing.Size(1017, 447);
            this.tab_settings.TabIndex = 3;
            this.tab_settings.Text = "Settings";
            this.tab_settings.UseVisualStyleBackColor = true;
            // 
            // panel_status
            // 
            this.panel_status.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_status.Controls.Add(this.txt_status);
            this.panel_status.Controls.Add(this.btn_play);
            this.panel_status.Location = new System.Drawing.Point(0, 511);
            this.panel_status.Name = "panel_status";
            this.panel_status.Size = new System.Drawing.Size(1031, 57);
            this.panel_status.TabIndex = 0;
            // 
            // txt_status
            // 
            this.txt_status.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txt_status.Location = new System.Drawing.Point(0, 37);
            this.txt_status.Name = "txt_status";
            this.txt_status.ReadOnly = true;
            this.txt_status.Size = new System.Drawing.Size(1031, 20);
            this.txt_status.TabIndex = 2;
            // 
            // btn_play
            // 
            this.btn_play.AutoSize = true;
            this.btn_play.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_play.Depth = 0;
            this.btn_play.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_play.Icon = null;
            this.btn_play.Location = new System.Drawing.Point(0, 0);
            this.btn_play.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_play.Name = "btn_play";
            this.btn_play.Primary = true;
            this.btn_play.Size = new System.Drawing.Size(1031, 36);
            this.btn_play.TabIndex = 1;
            this.btn_play.Text = "Play";
            this.btn_play.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 658);
            this.Controls.Add(this.panel_full);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Euro Truck Simulator 2 Launcher";
            this.panel_full.ResumeLayout(false);
            this.tabs_main.ResumeLayout(false);
            this.tab_mods.ResumeLayout(false);
            this.tabs_mods.ResumeLayout(false);
            this.tab_mods_installed.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tab_plugins.ResumeLayout(false);
            this.tabs_plugins.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel_status.ResumeLayout(false);
            this.panel_status.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_full;
        private MaterialSkin.Controls.MaterialTabControl tabs_main;
        private System.Windows.Forms.TabPage tab_news;
        private System.Windows.Forms.TabPage tab_game;
        private System.Windows.Forms.Panel panel_status;
        private MaterialSkin.Controls.MaterialRaisedButton btn_play;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.TabPage tab_mods;
        private MaterialSkin.Controls.MaterialTabSelector tabselect_mods;
        private MaterialSkin.Controls.MaterialTabControl tabs_mods;
        private System.Windows.Forms.TabPage tab_mods_available;
        private MaterialSkin.Controls.MaterialContextMenuStrip menu_mod;
        private System.Windows.Forms.TabPage tab_settings;
        private System.Windows.Forms.TabPage tab_mods_installed;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_mods_reload;
        private MaterialSkin.Controls.MaterialListView lst_mods_installed;
        public System.Windows.Forms.TextBox txt_status;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialLabel lbl_mod_name;
        private System.Windows.Forms.TextBox txt_mod_name;
        private System.Windows.Forms.TabPage tab_plugins;
        private MaterialSkin.Controls.MaterialTabSelector tabselect_plugins;
        private MaterialSkin.Controls.MaterialTabControl tabs_plugins;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btn_plugins_reload;
        private MaterialSkin.Controls.MaterialListView lst_plugins_installed;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

