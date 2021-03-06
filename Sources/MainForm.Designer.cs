﻿namespace KindleLibrarySynchronizer
{
	partial class MainForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.textLog = new System.Windows.Forms.TextBox();
			this.mainMenu = new System.Windows.Forms.MenuStrip();
			this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
			this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
			this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
			this.menuCompare = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.menuSelectNew = new System.Windows.Forms.ToolStripMenuItem();
			this.menuSelectChanged = new System.Windows.Forms.ToolStripMenuItem();
			this.menuSelectDeleted = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.menuConvertSelected = new System.Windows.Forms.ToolStripMenuItem();
			this.menuDeleteSelected = new System.Windows.Forms.ToolStripMenuItem();
			this.menuView = new System.Windows.Forms.ToolStripMenuItem();
			this.menuShowAll = new System.Windows.Forms.ToolStripMenuItem();
			this.menuShowActual = new System.Windows.Forms.ToolStripMenuItem();
			this.menuShowNew = new System.Windows.Forms.ToolStripMenuItem();
			this.menuShowChanged = new System.Windows.Forms.ToolStripMenuItem();
			this.menuShowDeleted = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
			this.menuShowIgnored = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
			this.menuToggleLogPane = new System.Windows.Forms.ToolStripMenuItem();
			this.menuTools = new System.Windows.Forms.ToolStripMenuItem();
			this.menuOptions = new System.Windows.Forms.ToolStripMenuItem();
			this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.toolbar = new System.Windows.Forms.ToolStrip();
			this.comboLibraries = new System.Windows.Forms.ToolStripComboBox();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.buttonCompare = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.buttonShowAll = new System.Windows.Forms.ToolStripButton();
			this.buttonShowActual = new System.Windows.Forms.ToolStripButton();
			this.buttonShowNew = new System.Windows.Forms.ToolStripButton();
			this.buttonShowChanged = new System.Windows.Forms.ToolStripButton();
			this.buttonShowDeleted = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
			this.buttonShowIgnored = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.buttonSelectNew = new System.Windows.Forms.ToolStripButton();
			this.buttonSelectChanged = new System.Windows.Forms.ToolStripButton();
			this.buttonSelectDeleted = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.buttonConvertSelected = new System.Windows.Forms.ToolStripButton();
			this.buttonDeleteSelected = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.buttonOptions = new System.Windows.Forms.ToolStripButton();
			this.statusBar = new System.Windows.Forms.StatusStrip();
			this.statusSelection = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusCounters = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusFiller = new System.Windows.Forms.ToolStripStatusLabel();
			this.buttonToggleLogPane = new System.Windows.Forms.ToolStripButton();
			this.booksMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.menuBooksCompare = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
			this.menuBooksOpen = new System.Windows.Forms.ToolStripMenuItem();
			this.menuBooksExplore = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
			this.menuBooksConvert = new System.Windows.Forms.ToolStripMenuItem();
			this.menuBooksDelete = new System.Windows.Forms.ToolStripMenuItem();
			this.splitContainer = new System.Windows.Forms.SplitContainer();
			this.synchroList = new KindleLibrarySynchronizer.SynchroList();
			this.mainMenu.SuspendLayout();
			this.toolbar.SuspendLayout();
			this.statusBar.SuspendLayout();
			this.booksMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
			this.splitContainer.Panel1.SuspendLayout();
			this.splitContainer.Panel2.SuspendLayout();
			this.splitContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// textLog
			// 
			this.textLog.AllowDrop = true;
			this.textLog.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textLog.Location = new System.Drawing.Point(0, 0);
			this.textLog.Multiline = true;
			this.textLog.Name = "textLog";
			this.textLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textLog.Size = new System.Drawing.Size(150, 46);
			this.textLog.TabIndex = 0;
			this.textLog.WordWrap = false;
			this.textLog.DoubleClick += new System.EventHandler(this.textLog_DoubleClick);
			// 
			// mainMenu
			// 
			this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuEdit,
            this.menuView,
            this.menuTools,
            this.menuHelp});
			this.mainMenu.Location = new System.Drawing.Point(0, 0);
			this.mainMenu.Name = "mainMenu";
			this.mainMenu.Size = new System.Drawing.Size(806, 24);
			this.mainMenu.TabIndex = 6;
			this.mainMenu.Text = "menuStrip1";
			// 
			// menuFile
			// 
			this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuExit});
			this.menuFile.Name = "menuFile";
			this.menuFile.Size = new System.Drawing.Size(35, 20);
			this.menuFile.Text = "&File";
			// 
			// menuExit
			// 
			this.menuExit.Name = "menuExit";
			this.menuExit.Size = new System.Drawing.Size(92, 22);
			this.menuExit.Text = "Exit";
			// 
			// menuEdit
			// 
			this.menuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCompare,
            this.toolStripMenuItem1,
            this.menuSelectNew,
            this.menuSelectChanged,
            this.menuSelectDeleted,
            this.toolStripMenuItem2,
            this.menuConvertSelected,
            this.menuDeleteSelected});
			this.menuEdit.Name = "menuEdit";
			this.menuEdit.Size = new System.Drawing.Size(37, 20);
			this.menuEdit.Text = "&Edit";
			// 
			// menuCompare
			// 
			this.menuCompare.Image = global::KindleLibrarySynchronizer.Properties.Resources.Compare;
			this.menuCompare.Name = "menuCompare";
			this.menuCompare.Size = new System.Drawing.Size(188, 22);
			this.menuCompare.Text = "Compare";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(185, 6);
			// 
			// menuSelectNew
			// 
			this.menuSelectNew.Image = global::KindleLibrarySynchronizer.Properties.Resources.Select_New;
			this.menuSelectNew.Name = "menuSelectNew";
			this.menuSelectNew.Size = new System.Drawing.Size(188, 22);
			this.menuSelectNew.Text = "Select All New";
			// 
			// menuSelectChanged
			// 
			this.menuSelectChanged.Image = global::KindleLibrarySynchronizer.Properties.Resources.Select_Changed;
			this.menuSelectChanged.Name = "menuSelectChanged";
			this.menuSelectChanged.Size = new System.Drawing.Size(188, 22);
			this.menuSelectChanged.Text = "Select All Changed";
			// 
			// menuSelectDeleted
			// 
			this.menuSelectDeleted.Image = ((System.Drawing.Image)(resources.GetObject("menuSelectDeleted.Image")));
			this.menuSelectDeleted.Name = "menuSelectDeleted";
			this.menuSelectDeleted.Size = new System.Drawing.Size(188, 22);
			this.menuSelectDeleted.Text = "Select All Deleted";
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(185, 6);
			// 
			// menuConvertSelected
			// 
			this.menuConvertSelected.Image = global::KindleLibrarySynchronizer.Properties.Resources.Convert;
			this.menuConvertSelected.Name = "menuConvertSelected";
			this.menuConvertSelected.Size = new System.Drawing.Size(188, 22);
			this.menuConvertSelected.Text = "Convert Selected Books";
			// 
			// menuDeleteSelected
			// 
			this.menuDeleteSelected.Image = global::KindleLibrarySynchronizer.Properties.Resources.Delete;
			this.menuDeleteSelected.Name = "menuDeleteSelected";
			this.menuDeleteSelected.Size = new System.Drawing.Size(188, 22);
			this.menuDeleteSelected.Text = "Delete Selected Books";
			// 
			// menuView
			// 
			this.menuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuShowAll,
            this.menuShowActual,
            this.menuShowNew,
            this.menuShowChanged,
            this.menuShowDeleted,
            this.toolStripMenuItem4,
            this.menuShowIgnored,
            this.toolStripMenuItem3,
            this.menuToggleLogPane});
			this.menuView.Name = "menuView";
			this.menuView.Size = new System.Drawing.Size(41, 20);
			this.menuView.Text = "&View";
			// 
			// menuShowAll
			// 
			this.menuShowAll.Image = global::KindleLibrarySynchronizer.Properties.Resources.Show_All;
			this.menuShowAll.Name = "menuShowAll";
			this.menuShowAll.Size = new System.Drawing.Size(146, 22);
			this.menuShowAll.Text = "Show All";
			// 
			// menuShowActual
			// 
			this.menuShowActual.Image = global::KindleLibrarySynchronizer.Properties.Resources.Show_Actual;
			this.menuShowActual.Name = "menuShowActual";
			this.menuShowActual.Size = new System.Drawing.Size(146, 22);
			this.menuShowActual.Text = "Show Actual";
			// 
			// menuShowNew
			// 
			this.menuShowNew.Image = global::KindleLibrarySynchronizer.Properties.Resources.Show_New;
			this.menuShowNew.Name = "menuShowNew";
			this.menuShowNew.Size = new System.Drawing.Size(146, 22);
			this.menuShowNew.Text = "Show New";
			// 
			// menuShowChanged
			// 
			this.menuShowChanged.Image = global::KindleLibrarySynchronizer.Properties.Resources.Show_Changed;
			this.menuShowChanged.Name = "menuShowChanged";
			this.menuShowChanged.Size = new System.Drawing.Size(146, 22);
			this.menuShowChanged.Text = "Show Changed";
			// 
			// menuShowDeleted
			// 
			this.menuShowDeleted.Image = global::KindleLibrarySynchronizer.Properties.Resources.Show_Deleted;
			this.menuShowDeleted.Name = "menuShowDeleted";
			this.menuShowDeleted.Size = new System.Drawing.Size(146, 22);
			this.menuShowDeleted.Text = "Show Deleted";
			// 
			// toolStripMenuItem4
			// 
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.Size = new System.Drawing.Size(143, 6);
			// 
			// menuShowIgnored
			// 
			this.menuShowIgnored.Image = global::KindleLibrarySynchronizer.Properties.Resources.Show_Ignored;
			this.menuShowIgnored.Name = "menuShowIgnored";
			this.menuShowIgnored.Size = new System.Drawing.Size(146, 22);
			this.menuShowIgnored.Text = "Show Ignored";
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(143, 6);
			// 
			// menuToggleLogPane
			// 
			this.menuToggleLogPane.Name = "menuToggleLogPane";
			this.menuToggleLogPane.Size = new System.Drawing.Size(146, 22);
			this.menuToggleLogPane.Text = "Log Pane";
			// 
			// menuTools
			// 
			this.menuTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOptions});
			this.menuTools.Name = "menuTools";
			this.menuTools.Size = new System.Drawing.Size(44, 20);
			this.menuTools.Text = "&Tools";
			// 
			// menuOptions
			// 
			this.menuOptions.Image = global::KindleLibrarySynchronizer.Properties.Resources.Options;
			this.menuOptions.Name = "menuOptions";
			this.menuOptions.Size = new System.Drawing.Size(123, 22);
			this.menuOptions.Text = "Options...";
			// 
			// menuHelp
			// 
			this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAbout});
			this.menuHelp.Name = "menuHelp";
			this.menuHelp.Size = new System.Drawing.Size(40, 20);
			this.menuHelp.Text = "&Help";
			// 
			// menuAbout
			// 
			this.menuAbout.Name = "menuAbout";
			this.menuAbout.Size = new System.Drawing.Size(115, 22);
			this.menuAbout.Text = "About...";
			// 
			// toolbar
			// 
			this.toolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comboLibraries,
            this.toolStripSeparator5,
            this.buttonCompare,
            this.toolStripSeparator1,
            this.buttonShowAll,
            this.buttonShowActual,
            this.buttonShowNew,
            this.buttonShowChanged,
            this.buttonShowDeleted,
            this.toolStripSeparator8,
            this.buttonShowIgnored,
            this.toolStripSeparator2,
            this.buttonSelectNew,
            this.buttonSelectChanged,
            this.buttonSelectDeleted,
            this.toolStripSeparator3,
            this.buttonConvertSelected,
            this.buttonDeleteSelected,
            this.toolStripSeparator4,
            this.buttonOptions});
			this.toolbar.Location = new System.Drawing.Point(0, 24);
			this.toolbar.Name = "toolbar";
			this.toolbar.Size = new System.Drawing.Size(806, 25);
			this.toolbar.TabIndex = 7;
			this.toolbar.Text = "toolStrip1";
			// 
			// comboLibraries
			// 
			this.comboLibraries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboLibraries.Name = "comboLibraries";
			this.comboLibraries.Size = new System.Drawing.Size(200, 25);
			this.comboLibraries.SelectedIndexChanged += new System.EventHandler(this.comboLibraries_SelectedIndexChanged);
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
			// 
			// buttonCompare
			// 
			this.buttonCompare.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonCompare.Image = global::KindleLibrarySynchronizer.Properties.Resources.Compare;
			this.buttonCompare.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.buttonCompare.Name = "buttonCompare";
			this.buttonCompare.Size = new System.Drawing.Size(23, 22);
			this.buttonCompare.Text = "toolStripButton1";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// buttonShowAll
			// 
			this.buttonShowAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonShowAll.Image = ((System.Drawing.Image)(resources.GetObject("buttonShowAll.Image")));
			this.buttonShowAll.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.buttonShowAll.Name = "buttonShowAll";
			this.buttonShowAll.Size = new System.Drawing.Size(23, 22);
			this.buttonShowAll.Text = "toolStripButton1";
			// 
			// buttonShowActual
			// 
			this.buttonShowActual.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonShowActual.Image = global::KindleLibrarySynchronizer.Properties.Resources.Show_Actual;
			this.buttonShowActual.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.buttonShowActual.Name = "buttonShowActual";
			this.buttonShowActual.Size = new System.Drawing.Size(23, 22);
			this.buttonShowActual.Text = "toolStripButton2";
			// 
			// buttonShowNew
			// 
			this.buttonShowNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonShowNew.Image = global::KindleLibrarySynchronizer.Properties.Resources.Show_New;
			this.buttonShowNew.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.buttonShowNew.Name = "buttonShowNew";
			this.buttonShowNew.Size = new System.Drawing.Size(23, 22);
			this.buttonShowNew.Text = "toolStripButton3";
			// 
			// buttonShowChanged
			// 
			this.buttonShowChanged.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonShowChanged.Image = global::KindleLibrarySynchronizer.Properties.Resources.Show_Changed;
			this.buttonShowChanged.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.buttonShowChanged.Name = "buttonShowChanged";
			this.buttonShowChanged.Size = new System.Drawing.Size(23, 22);
			this.buttonShowChanged.Text = "toolStripButton4";
			// 
			// buttonShowDeleted
			// 
			this.buttonShowDeleted.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonShowDeleted.Image = global::KindleLibrarySynchronizer.Properties.Resources.Show_Deleted;
			this.buttonShowDeleted.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.buttonShowDeleted.Name = "buttonShowDeleted";
			this.buttonShowDeleted.Size = new System.Drawing.Size(23, 22);
			this.buttonShowDeleted.Text = "toolStripButton8";
			// 
			// toolStripSeparator8
			// 
			this.toolStripSeparator8.Name = "toolStripSeparator8";
			this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
			// 
			// buttonShowIgnored
			// 
			this.buttonShowIgnored.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonShowIgnored.Image = global::KindleLibrarySynchronizer.Properties.Resources.Show_Ignored;
			this.buttonShowIgnored.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.buttonShowIgnored.Name = "buttonShowIgnored";
			this.buttonShowIgnored.Size = new System.Drawing.Size(23, 22);
			this.buttonShowIgnored.Text = "toolStripButton9";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// buttonSelectNew
			// 
			this.buttonSelectNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonSelectNew.Image = global::KindleLibrarySynchronizer.Properties.Resources.Select_New;
			this.buttonSelectNew.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.buttonSelectNew.Name = "buttonSelectNew";
			this.buttonSelectNew.Size = new System.Drawing.Size(23, 22);
			this.buttonSelectNew.Text = "toolStripButton5";
			// 
			// buttonSelectChanged
			// 
			this.buttonSelectChanged.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonSelectChanged.Image = global::KindleLibrarySynchronizer.Properties.Resources.Select_Changed;
			this.buttonSelectChanged.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.buttonSelectChanged.Name = "buttonSelectChanged";
			this.buttonSelectChanged.Size = new System.Drawing.Size(23, 22);
			this.buttonSelectChanged.Text = "toolStripButton6";
			// 
			// buttonSelectDeleted
			// 
			this.buttonSelectDeleted.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonSelectDeleted.Image = ((System.Drawing.Image)(resources.GetObject("buttonSelectDeleted.Image")));
			this.buttonSelectDeleted.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.buttonSelectDeleted.Name = "buttonSelectDeleted";
			this.buttonSelectDeleted.Size = new System.Drawing.Size(23, 22);
			this.buttonSelectDeleted.Text = "toolStripButton7";
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
			// 
			// buttonConvertSelected
			// 
			this.buttonConvertSelected.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonConvertSelected.Image = global::KindleLibrarySynchronizer.Properties.Resources.Convert;
			this.buttonConvertSelected.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.buttonConvertSelected.Name = "buttonConvertSelected";
			this.buttonConvertSelected.Size = new System.Drawing.Size(23, 22);
			this.buttonConvertSelected.Text = "toolStripButton10";
			// 
			// buttonDeleteSelected
			// 
			this.buttonDeleteSelected.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonDeleteSelected.Image = global::KindleLibrarySynchronizer.Properties.Resources.Delete;
			this.buttonDeleteSelected.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.buttonDeleteSelected.Name = "buttonDeleteSelected";
			this.buttonDeleteSelected.Size = new System.Drawing.Size(23, 22);
			this.buttonDeleteSelected.Text = "toolStripButton11";
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
			// 
			// buttonOptions
			// 
			this.buttonOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonOptions.Image = global::KindleLibrarySynchronizer.Properties.Resources.Options;
			this.buttonOptions.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.buttonOptions.Name = "buttonOptions";
			this.buttonOptions.Size = new System.Drawing.Size(23, 22);
			this.buttonOptions.Text = "toolStripButton1";
			// 
			// statusBar
			// 
			this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusSelection,
            this.statusCounters,
            this.statusFiller,
            this.buttonToggleLogPane});
			this.statusBar.Location = new System.Drawing.Point(0, 601);
			this.statusBar.Name = "statusBar";
			this.statusBar.Size = new System.Drawing.Size(806, 22);
			this.statusBar.TabIndex = 8;
			this.statusBar.Text = "statusStrip1";
			// 
			// statusSelection
			// 
			this.statusSelection.AutoSize = false;
			this.statusSelection.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
			this.statusSelection.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
			this.statusSelection.Name = "statusSelection";
			this.statusSelection.Size = new System.Drawing.Size(200, 19);
			this.statusSelection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// statusCounters
			// 
			this.statusCounters.AutoSize = false;
			this.statusCounters.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
			this.statusCounters.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
			this.statusCounters.Name = "statusCounters";
			this.statusCounters.Size = new System.Drawing.Size(300, 19);
			this.statusCounters.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// statusFiller
			// 
			this.statusFiller.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
			this.statusFiller.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
			this.statusFiller.Name = "statusFiller";
			this.statusFiller.Size = new System.Drawing.Size(236, 19);
			this.statusFiller.Spring = true;
			// 
			// buttonToggleLogPane
			// 
			this.buttonToggleLogPane.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.buttonToggleLogPane.Image = ((System.Drawing.Image)(resources.GetObject("buttonToggleLogPane.Image")));
			this.buttonToggleLogPane.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.buttonToggleLogPane.Name = "buttonToggleLogPane";
			this.buttonToggleLogPane.Size = new System.Drawing.Size(55, 20);
			this.buttonToggleLogPane.Text = "Log Pane";
			// 
			// booksMenu
			// 
			this.booksMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBooksCompare,
            this.toolStripMenuItem5,
            this.menuBooksOpen,
            this.menuBooksExplore,
            this.toolStripSeparator7,
            this.menuBooksConvert,
            this.menuBooksDelete});
			this.booksMenu.Name = "contextMenu";
			this.booksMenu.Size = new System.Drawing.Size(153, 148);
			this.booksMenu.Opening += new System.ComponentModel.CancelEventHandler(this.booksMenu_Opening);
			// 
			// menuBooksCompare
			// 
			this.menuBooksCompare.Name = "menuBooksCompare";
			this.menuBooksCompare.Size = new System.Drawing.Size(152, 22);
			this.menuBooksCompare.Text = "Compare";
			// 
			// toolStripMenuItem5
			// 
			this.toolStripMenuItem5.Name = "toolStripMenuItem5";
			this.toolStripMenuItem5.Size = new System.Drawing.Size(149, 6);
			// 
			// menuBooksOpen
			// 
			this.menuBooksOpen.Name = "menuBooksOpen";
			this.menuBooksOpen.Size = new System.Drawing.Size(152, 22);
			this.menuBooksOpen.Text = "Open";
			// 
			// menuBooksExplore
			// 
			this.menuBooksExplore.Name = "menuBooksExplore";
			this.menuBooksExplore.Size = new System.Drawing.Size(152, 22);
			this.menuBooksExplore.Text = "Explore";
			// 
			// toolStripSeparator7
			// 
			this.toolStripSeparator7.Name = "toolStripSeparator7";
			this.toolStripSeparator7.Size = new System.Drawing.Size(149, 6);
			// 
			// menuBooksConvert
			// 
			this.menuBooksConvert.Name = "menuBooksConvert";
			this.menuBooksConvert.Size = new System.Drawing.Size(152, 22);
			this.menuBooksConvert.Text = "Convert";
			// 
			// menuBooksDelete
			// 
			this.menuBooksDelete.Name = "menuBooksDelete";
			this.menuBooksDelete.Size = new System.Drawing.Size(152, 22);
			this.menuBooksDelete.Text = "Delete";
			// 
			// splitContainer
			// 
			this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainer.Location = new System.Drawing.Point(0, 49);
			this.splitContainer.Name = "splitContainer";
			this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer.Panel1
			// 
			this.splitContainer.Panel1.Controls.Add(this.synchroList);
			// 
			// splitContainer.Panel2
			// 
			this.splitContainer.Panel2.Controls.Add(this.textLog);
			this.splitContainer.Panel2Collapsed = true;
			this.splitContainer.Size = new System.Drawing.Size(806, 552);
			this.splitContainer.SplitterDistance = 410;
			this.splitContainer.TabIndex = 9;
			// 
			// synchroList
			// 
			this.synchroList.BookComparer = null;
			this.synchroList.ContextMenuStrip = this.booksMenu;
			this.synchroList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.synchroList.Location = new System.Drawing.Point(0, 0);
			this.synchroList.Name = "synchroList";
			this.synchroList.ShowActualBooks = true;
			this.synchroList.ShowChangedBooks = true;
			this.synchroList.ShowDeletedBooks = true;
			this.synchroList.ShowNewBooks = true;
			this.synchroList.Size = new System.Drawing.Size(806, 552);
			this.synchroList.TabIndex = 3;
			this.synchroList.SelectionChanged += new System.EventHandler(this.synchroList_SelectionChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(806, 623);
			this.Controls.Add(this.splitContainer);
			this.Controls.Add(this.statusBar);
			this.Controls.Add(this.toolbar);
			this.Controls.Add(this.mainMenu);
			this.MainMenuStrip = this.mainMenu;
			this.Name = "MainForm";
			this.Text = "Kindle Library Synchronizer";
			this.mainMenu.ResumeLayout(false);
			this.mainMenu.PerformLayout();
			this.toolbar.ResumeLayout(false);
			this.toolbar.PerformLayout();
			this.statusBar.ResumeLayout(false);
			this.statusBar.PerformLayout();
			this.booksMenu.ResumeLayout(false);
			this.splitContainer.Panel1.ResumeLayout(false);
			this.splitContainer.Panel2.ResumeLayout(false);
			this.splitContainer.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
			this.splitContainer.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textLog;
		private SynchroList synchroList;
		private System.Windows.Forms.MenuStrip mainMenu;
		private System.Windows.Forms.ToolStripMenuItem menuFile;
		private System.Windows.Forms.ToolStripMenuItem menuExit;
		private System.Windows.Forms.ToolStripMenuItem menuEdit;
		private System.Windows.Forms.ToolStripMenuItem menuCompare;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem menuSelectNew;
		private System.Windows.Forms.ToolStripMenuItem menuSelectChanged;
		private System.Windows.Forms.ToolStripMenuItem menuSelectDeleted;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem menuConvertSelected;
		private System.Windows.Forms.ToolStripMenuItem menuDeleteSelected;
		private System.Windows.Forms.ToolStripMenuItem menuView;
		private System.Windows.Forms.ToolStripMenuItem menuShowActual;
		private System.Windows.Forms.ToolStripMenuItem menuShowNew;
		private System.Windows.Forms.ToolStripMenuItem menuShowChanged;
		private System.Windows.Forms.ToolStripMenuItem menuShowDeleted;
		private System.Windows.Forms.ToolStripMenuItem menuShowIgnored;
		private System.Windows.Forms.ToolStripMenuItem menuTools;
		private System.Windows.Forms.ToolStripMenuItem menuOptions;
		private System.Windows.Forms.ToolStripMenuItem menuHelp;
		private System.Windows.Forms.ToolStripMenuItem menuAbout;
		private System.Windows.Forms.ToolStrip toolbar;
		private System.Windows.Forms.StatusStrip statusBar;
		private System.Windows.Forms.ToolStripStatusLabel statusSelection;
		private System.Windows.Forms.ToolStripStatusLabel statusCounters;
		private System.Windows.Forms.ToolStripComboBox comboLibraries;
		private System.Windows.Forms.ToolStripButton buttonCompare;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton buttonShowActual;
		private System.Windows.Forms.ToolStripButton buttonShowNew;
		private System.Windows.Forms.ToolStripButton buttonShowChanged;
		private System.Windows.Forms.ToolStripButton buttonShowDeleted;
		private System.Windows.Forms.ToolStripButton buttonShowIgnored;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton buttonSelectNew;
		private System.Windows.Forms.ToolStripButton buttonSelectChanged;
		private System.Windows.Forms.ToolStripButton buttonSelectDeleted;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripButton buttonConvertSelected;
		private System.Windows.Forms.ToolStripButton buttonDeleteSelected;
		private System.Windows.Forms.ToolStripButton buttonOptions;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ContextMenuStrip booksMenu;
		private System.Windows.Forms.ToolStripMenuItem menuBooksConvert;
		private System.Windows.Forms.ToolStripMenuItem menuBooksDelete;
		private System.Windows.Forms.ToolStripMenuItem menuBooksExplore;
		private System.Windows.Forms.ToolStripMenuItem menuBooksOpen;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
		private System.Windows.Forms.SplitContainer splitContainer;
		private System.Windows.Forms.ToolStripButton buttonToggleLogPane;
		private System.Windows.Forms.ToolStripStatusLabel statusFiller;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem menuToggleLogPane;
		private System.Windows.Forms.ToolStripMenuItem menuShowAll;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
		private System.Windows.Forms.ToolStripButton buttonShowAll;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
		private System.Windows.Forms.ToolStripMenuItem menuBooksCompare;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
	}
}

