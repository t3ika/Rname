namespace Rname
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle5 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle6 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle7 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle8 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo2 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle1 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle2 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle3 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle4 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo1 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTab_tranform = new MetroFramework.Controls.MetroTabPage();
            this.metroTab_delete = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroButton_supprimer = new MetroFramework.Controls.MetroButton();
            this.metroTextBox_supp_valeur = new MetroFramework.Controls.MetroTextBox();
            this.metroTab_replace = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroButton_v_remplacer = new MetroFramework.Controls.MetroButton();
            this.metroTextBox_rempl_new = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox_rempl_base = new MetroFramework.Controls.MetroTextBox();
            this.metroTab_special = new MetroFramework.Controls.MetroTabPage();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.gridControl2 = new Syncfusion.Windows.Forms.Grid.GridControl();
            this.gridControl3 = new Syncfusion.Windows.Forms.Grid.GridControl();
            this.listView_parametres = new System.Windows.Forms.ListView();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.metroTile5 = new MetroFramework.Controls.MetroTile();
            this.metroTile6 = new MetroFramework.Controls.MetroTile();
            this.metroTab_transform = new MetroFramework.Controls.MetroTabPage();
            this.listBox_origine = new System.Windows.Forms.ListBox();
            this.listBox_tampon = new System.Windows.Forms.ListBox();
            this.listBox_apercu = new System.Windows.Forms.ListBox();
            this.listBox_parametre = new System.Windows.Forms.ListBox();
            this.metroLabel_erreur = new MetroFramework.Controls.MetroLabel();
            this.listBox_extension = new System.Windows.Forms.ListBox();
            this.metroTabControl1.SuspendLayout();
            this.metroTab_delete.SuspendLayout();
            this.metroTab_replace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTab_tranform);
            this.metroTabControl1.Controls.Add(this.metroTab_delete);
            this.metroTabControl1.Controls.Add(this.metroTab_replace);
            this.metroTabControl1.Controls.Add(this.metroTab_special);
            this.metroTabControl1.Location = new System.Drawing.Point(180, 73);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(1001, 100);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.SelectedIndexChanged += new System.EventHandler(this.metroTabControl1_SelectedIndexChanged);
            // 
            // metroTab_tranform
            // 
            this.metroTab_tranform.HorizontalScrollbarBarColor = true;
            this.metroTab_tranform.Location = new System.Drawing.Point(4, 35);
            this.metroTab_tranform.Name = "metroTab_tranform";
            this.metroTab_tranform.Size = new System.Drawing.Size(993, 61);
            this.metroTab_tranform.TabIndex = 3;
            this.metroTab_tranform.Text = "Transformer";
            this.metroTab_tranform.VerticalScrollbarBarColor = true;
            // 
            // metroTab_delete
            // 
            this.metroTab_delete.Controls.Add(this.metroLabel7);
            this.metroTab_delete.Controls.Add(this.metroButton_supprimer);
            this.metroTab_delete.Controls.Add(this.metroTextBox_supp_valeur);
            this.metroTab_delete.HorizontalScrollbarBarColor = true;
            this.metroTab_delete.Location = new System.Drawing.Point(4, 35);
            this.metroTab_delete.Name = "metroTab_delete";
            this.metroTab_delete.Size = new System.Drawing.Size(993, 61);
            this.metroTab_delete.TabIndex = 1;
            this.metroTab_delete.Text = "Supprimer";
            this.metroTab_delete.VerticalScrollbarBarColor = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(265, 25);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(71, 19);
            this.metroLabel7.TabIndex = 12;
            this.metroLabel7.Text = "Supprimer";
            // 
            // metroButton_supprimer
            // 
            this.metroButton_supprimer.Location = new System.Drawing.Point(577, 25);
            this.metroButton_supprimer.Name = "metroButton_supprimer";
            this.metroButton_supprimer.Size = new System.Drawing.Size(115, 23);
            this.metroButton_supprimer.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroButton_supprimer.TabIndex = 11;
            this.metroButton_supprimer.Text = "Valider";
            this.metroButton_supprimer.Click += new System.EventHandler(this.metroButton_supprimer_Click);
            // 
            // metroTextBox_supp_valeur
            // 
            this.metroTextBox_supp_valeur.BackColor = System.Drawing.Color.White;
            this.metroTextBox_supp_valeur.CustomBackground = true;
            this.metroTextBox_supp_valeur.Location = new System.Drawing.Point(343, 25);
            this.metroTextBox_supp_valeur.Name = "metroTextBox_supp_valeur";
            this.metroTextBox_supp_valeur.Size = new System.Drawing.Size(199, 23);
            this.metroTextBox_supp_valeur.TabIndex = 9;
            this.metroTextBox_supp_valeur.UseStyleColors = true;
            // 
            // metroTab_replace
            // 
            this.metroTab_replace.BackgroundImage = global::Rname.Properties.Resources.Search_28;
            this.metroTab_replace.Controls.Add(this.metroLabel5);
            this.metroTab_replace.Controls.Add(this.metroLabel4);
            this.metroTab_replace.Controls.Add(this.metroButton_v_remplacer);
            this.metroTab_replace.Controls.Add(this.metroTextBox_rempl_new);
            this.metroTab_replace.Controls.Add(this.metroTextBox_rempl_base);
            this.metroTab_replace.HorizontalScrollbarBarColor = true;
            this.metroTab_replace.Location = new System.Drawing.Point(4, 35);
            this.metroTab_replace.Name = "metroTab_replace";
            this.metroTab_replace.Size = new System.Drawing.Size(993, 61);
            this.metroTab_replace.TabIndex = 0;
            this.metroTab_replace.Text = "Remplacer";
            this.metroTab_replace.VerticalScrollbarBarColor = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(431, 25);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(28, 19);
            this.metroLabel5.TabIndex = 8;
            this.metroLabel5.Text = "Par";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(172, 25);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(72, 19);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "Remplacer";
            // 
            // metroButton_v_remplacer
            // 
            this.metroButton_v_remplacer.Location = new System.Drawing.Point(669, 25);
            this.metroButton_v_remplacer.Name = "metroButton_v_remplacer";
            this.metroButton_v_remplacer.Size = new System.Drawing.Size(115, 23);
            this.metroButton_v_remplacer.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroButton_v_remplacer.TabIndex = 4;
            this.metroButton_v_remplacer.Text = "Valider";
            this.metroButton_v_remplacer.Click += new System.EventHandler(this.metroButton_v_remplacer_Click);
            // 
            // metroTextBox_rempl_new
            // 
            this.metroTextBox_rempl_new.BackColor = System.Drawing.Color.White;
            this.metroTextBox_rempl_new.CustomBackground = true;
            this.metroTextBox_rempl_new.Location = new System.Drawing.Point(465, 25);
            this.metroTextBox_rempl_new.Name = "metroTextBox_rempl_new";
            this.metroTextBox_rempl_new.Size = new System.Drawing.Size(147, 23);
            this.metroTextBox_rempl_new.TabIndex = 3;
            this.metroTextBox_rempl_new.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox_rempl_new.UseStyleColors = true;
            // 
            // metroTextBox_rempl_base
            // 
            this.metroTextBox_rempl_base.BackColor = System.Drawing.Color.White;
            this.metroTextBox_rempl_base.CustomBackground = true;
            this.metroTextBox_rempl_base.Location = new System.Drawing.Point(250, 25);
            this.metroTextBox_rempl_base.Name = "metroTextBox_rempl_base";
            this.metroTextBox_rempl_base.Size = new System.Drawing.Size(147, 23);
            this.metroTextBox_rempl_base.TabIndex = 2;
            this.metroTextBox_rempl_base.UseStyleColors = true;
            // 
            // metroTab_special
            // 
            this.metroTab_special.HorizontalScrollbarBarColor = true;
            this.metroTab_special.Location = new System.Drawing.Point(4, 35);
            this.metroTab_special.Name = "metroTab_special";
            this.metroTab_special.Size = new System.Drawing.Size(993, 61);
            this.metroTab_special.TabIndex = 2;
            this.metroTab_special.Text = "Caractères spéciaux";
            this.metroTab_special.VerticalScrollbarBarColor = true;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // gridControl2
            // 
            this.gridControl2.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(94)))), ((int)(((byte)(171)))), ((int)(((byte)(222)))));
            this.metroStyleExtender1.SetApplyMetroTheme(this.gridControl2, true);
            this.gridControl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            gridBaseStyle5.Name = "Header";
            gridBaseStyle5.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle5.StyleInfo.Borders.Left = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle5.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle5.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle5.StyleInfo.CellType = "Header";
            gridBaseStyle5.StyleInfo.Font.Bold = true;
            gridBaseStyle5.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(199)))), ((int)(((byte)(184))))), System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(216))))));
            gridBaseStyle5.StyleInfo.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle;
            gridBaseStyle6.Name = "Standard";
            gridBaseStyle6.StyleInfo.Font.Facename = "Tahoma";
            gridBaseStyle6.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window);
            gridBaseStyle7.Name = "Column Header";
            gridBaseStyle7.StyleInfo.BaseStyle = "Header";
            gridBaseStyle7.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            gridBaseStyle8.Name = "Row Header";
            gridBaseStyle8.StyleInfo.BaseStyle = "Header";
            gridBaseStyle8.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Left;
            gridBaseStyle8.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(199)))), ((int)(((byte)(184))))), System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(216))))));
            this.gridControl2.BaseStylesMap.AddRange(new Syncfusion.Windows.Forms.Grid.GridBaseStyle[] {
            gridBaseStyle5,
            gridBaseStyle6,
            gridBaseStyle7,
            gridBaseStyle8});
            this.gridControl2.ColCount = 1;
            this.gridControl2.ColWidthEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridColWidth[] {
            new Syncfusion.Windows.Forms.Grid.GridColWidth(0, 35),
            new Syncfusion.Windows.Forms.Grid.GridColWidth(1, 216),
            new Syncfusion.Windows.Forms.Grid.GridColWidth(2, 37)});
            this.gridControl2.DefaultColWidth = 10;
            this.gridControl2.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid;
            this.gridControl2.DefaultRowHeight = 20;
            this.gridControl2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gridControl2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            gridCellInfo2.Col = -1;
            gridCellInfo2.Row = -1;
            gridCellInfo2.StyleInfo.Font.Bold = false;
            gridCellInfo2.StyleInfo.Font.Facename = "Segoe UI";
            gridCellInfo2.StyleInfo.Font.Italic = false;
            gridCellInfo2.StyleInfo.Font.Size = 9F;
            gridCellInfo2.StyleInfo.Font.Strikeout = false;
            gridCellInfo2.StyleInfo.Font.Underline = false;
            gridCellInfo2.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            this.gridControl2.GridCells.AddRange(new Syncfusion.Windows.Forms.Grid.GridCellInfo[] {
            gridCellInfo2});
            this.gridControl2.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.gridControl2.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridControl2.Location = new System.Drawing.Point(1083, 250);
            this.gridControl2.MetroScrollBars = true;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Properties.ColHeaders = false;
            this.gridControl2.Properties.GridLineColor = System.Drawing.Color.White;
            this.gridControl2.Properties.RowHeaders = false;
            this.gridControl2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridControl2.RowCount = 1;
            this.gridControl2.RowHeightEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridRowHeight[] {
            new Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 25)});
            this.gridControl2.SelectCellsMouseButtonsMask = System.Windows.Forms.MouseButtons.None;
            this.gridControl2.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeIntoCode;
            this.gridControl2.ShowColumnHeaders = false;
            this.gridControl2.ShowRowHeaders = false;
            this.gridControl2.Size = new System.Drawing.Size(255, 548);
            this.gridControl2.SmartSizeBox = false;
            this.gridControl2.TabIndex = 11;
            this.gridControl2.ThemesEnabled = true;
            this.gridControl2.UnHideColsOnDblClick = false;
            this.gridControl2.UseRightToLeftCompatibleTextBox = true;
            // 
            // gridControl3
            // 
            this.gridControl3.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(94)))), ((int)(((byte)(171)))), ((int)(((byte)(222)))));
            this.metroStyleExtender1.SetApplyMetroTheme(this.gridControl3, true);
            this.gridControl3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            gridBaseStyle1.Name = "Header";
            gridBaseStyle1.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle1.StyleInfo.Borders.Left = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle1.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle1.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle1.StyleInfo.CellType = "Header";
            gridBaseStyle1.StyleInfo.Font.Bold = true;
            gridBaseStyle1.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(199)))), ((int)(((byte)(184))))), System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(216))))));
            gridBaseStyle1.StyleInfo.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle;
            gridBaseStyle2.Name = "Standard";
            gridBaseStyle2.StyleInfo.Font.Facename = "Tahoma";
            gridBaseStyle2.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window);
            gridBaseStyle3.Name = "Column Header";
            gridBaseStyle3.StyleInfo.BaseStyle = "Header";
            gridBaseStyle3.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            gridBaseStyle4.Name = "Row Header";
            gridBaseStyle4.StyleInfo.BaseStyle = "Header";
            gridBaseStyle4.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Left;
            gridBaseStyle4.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(199)))), ((int)(((byte)(184))))), System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(216))))));
            this.gridControl3.BaseStylesMap.AddRange(new Syncfusion.Windows.Forms.Grid.GridBaseStyle[] {
            gridBaseStyle1,
            gridBaseStyle2,
            gridBaseStyle3,
            gridBaseStyle4});
            this.gridControl3.ColCount = 1;
            this.gridControl3.ColWidthEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridColWidth[] {
            new Syncfusion.Windows.Forms.Grid.GridColWidth(0, 35),
            new Syncfusion.Windows.Forms.Grid.GridColWidth(1, 216),
            new Syncfusion.Windows.Forms.Grid.GridColWidth(2, 37)});
            this.gridControl3.DefaultColWidth = 20;
            this.gridControl3.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid;
            this.gridControl3.DefaultRowHeight = 20;
            this.gridControl3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gridControl3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            gridCellInfo1.Col = -1;
            gridCellInfo1.Row = -1;
            gridCellInfo1.StyleInfo.Font.Bold = false;
            gridCellInfo1.StyleInfo.Font.Facename = "Segoe UI";
            gridCellInfo1.StyleInfo.Font.Italic = false;
            gridCellInfo1.StyleInfo.Font.Size = 9F;
            gridCellInfo1.StyleInfo.Font.Strikeout = false;
            gridCellInfo1.StyleInfo.Font.Underline = false;
            gridCellInfo1.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            this.gridControl3.GridCells.AddRange(new Syncfusion.Windows.Forms.Grid.GridCellInfo[] {
            gridCellInfo1});
            this.gridControl3.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.gridControl3.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridControl3.Location = new System.Drawing.Point(23, 250);
            this.gridControl3.MetroScrollBars = true;
            this.gridControl3.Name = "gridControl3";
            this.gridControl3.Properties.ColHeaders = false;
            this.gridControl3.Properties.GridLineColor = System.Drawing.Color.White;
            this.gridControl3.Properties.RowHeaders = false;
            this.gridControl3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridControl3.RowCount = 1;
            this.gridControl3.RowHeightEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridRowHeight[] {
            new Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 25)});
            this.gridControl3.SelectCellsMouseButtonsMask = System.Windows.Forms.MouseButtons.None;
            this.gridControl3.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeIntoCode;
            this.gridControl3.ShowColumnHeaders = false;
            this.gridControl3.ShowRowHeaders = false;
            this.gridControl3.Size = new System.Drawing.Size(1025, 548);
            this.gridControl3.SmartSizeBox = false;
            this.gridControl3.TabIndex = 19;
            this.gridControl3.ThemesEnabled = true;
            this.gridControl3.UnHideColsOnDblClick = false;
            this.gridControl3.UseRightToLeftCompatibleTextBox = true;
            // 
            // listView_parametres
            // 
            this.listView_parametres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.listView_parametres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_parametres.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_parametres.HideSelection = false;
            this.listView_parametres.Location = new System.Drawing.Point(438, 794);
            this.listView_parametres.Name = "listView_parametres";
            this.listView_parametres.Size = new System.Drawing.Size(315, 48);
            this.listView_parametres.TabIndex = 2;
            this.listView_parametres.UseCompatibleStateImageBehavior = false;
            this.listView_parametres.View = System.Windows.Forms.View.List;
            // 
            // metroTile2
            // 
            this.metroTile2.Location = new System.Drawing.Point(1205, 73);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(133, 100);
            this.metroTile2.TabIndex = 9;
            this.metroTile2.Text = "Renommer";
            this.metroTile2.TileImage = global::Rname.Properties.Resources.Form_Ok_01;
            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.UseTileImage = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.Location = new System.Drawing.Point(23, 73);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(133, 100);
            this.metroTile1.TabIndex = 7;
            this.metroTile1.Text = "Choisir un dossier";
            this.metroTile1.TileImage = global::Rname.Properties.Resources.Folder_Open_01;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroTile3
            // 
            this.metroTile3.Location = new System.Drawing.Point(23, 224);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(414, 23);
            this.metroTile3.TabIndex = 15;
            this.metroTile3.Text = "Original";
            // 
            // metroTile4
            // 
            this.metroTile4.Location = new System.Drawing.Point(465, 224);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(414, 23);
            this.metroTile4.TabIndex = 16;
            this.metroTile4.Text = "Aperçu";
            // 
            // metroTile5
            // 
            this.metroTile5.Location = new System.Drawing.Point(905, 224);
            this.metroTile5.Name = "metroTile5";
            this.metroTile5.Size = new System.Drawing.Size(143, 23);
            this.metroTile5.TabIndex = 17;
            this.metroTile5.Text = "Erreur";
            // 
            // metroTile6
            // 
            this.metroTile6.Location = new System.Drawing.Point(1083, 224);
            this.metroTile6.Name = "metroTile6";
            this.metroTile6.Size = new System.Drawing.Size(255, 23);
            this.metroTile6.TabIndex = 18;
            this.metroTile6.Text = "Paramètres";
            // 
            // metroTab_transform
            // 
            this.metroTab_transform.HorizontalScrollbarBarColor = true;
            this.metroTab_transform.Location = new System.Drawing.Point(4, 35);
            this.metroTab_transform.Name = "metroTab_transform";
            this.metroTab_transform.Size = new System.Drawing.Size(993, 61);
            this.metroTab_transform.TabIndex = 3;
            this.metroTab_transform.Text = "Transformer";
            this.metroTab_transform.VerticalScrollbarBarColor = true;
            // 
            // listBox_origine
            // 
            this.listBox_origine.FormattingEnabled = true;
            this.listBox_origine.Location = new System.Drawing.Point(416, 643);
            this.listBox_origine.Name = "listBox_origine";
            this.listBox_origine.Size = new System.Drawing.Size(120, 199);
            this.listBox_origine.TabIndex = 20;
            // 
            // listBox_tampon
            // 
            this.listBox_tampon.FormattingEnabled = true;
            this.listBox_tampon.Location = new System.Drawing.Point(542, 643);
            this.listBox_tampon.Name = "listBox_tampon";
            this.listBox_tampon.Size = new System.Drawing.Size(120, 199);
            this.listBox_tampon.TabIndex = 21;
            // 
            // listBox_apercu
            // 
            this.listBox_apercu.FormattingEnabled = true;
            this.listBox_apercu.Location = new System.Drawing.Point(668, 643);
            this.listBox_apercu.Name = "listBox_apercu";
            this.listBox_apercu.Size = new System.Drawing.Size(120, 199);
            this.listBox_apercu.TabIndex = 22;
            // 
            // listBox_parametre
            // 
            this.listBox_parametre.FormattingEnabled = true;
            this.listBox_parametre.Location = new System.Drawing.Point(794, 643);
            this.listBox_parametre.Name = "listBox_parametre";
            this.listBox_parametre.Size = new System.Drawing.Size(120, 199);
            this.listBox_parametre.TabIndex = 23;
            // 
            // metroLabel_erreur
            // 
            this.metroLabel_erreur.AutoSize = true;
            this.metroLabel_erreur.ForeColor = System.Drawing.Color.DarkRed;
            this.metroLabel_erreur.Location = new System.Drawing.Point(550, 176);
            this.metroLabel_erreur.Name = "metroLabel_erreur";
            this.metroLabel_erreur.Size = new System.Drawing.Size(25, 19);
            this.metroLabel_erreur.TabIndex = 24;
            this.metroLabel_erreur.Text = "    ";
            this.metroLabel_erreur.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listBox_extension
            // 
            this.listBox_extension.FormattingEnabled = true;
            this.listBox_extension.Location = new System.Drawing.Point(920, 643);
            this.listBox_extension.Name = "listBox_extension";
            this.listBox_extension.Size = new System.Drawing.Size(120, 199);
            this.listBox_extension.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 821);
            this.Controls.Add(this.listBox_extension);
            this.Controls.Add(this.metroLabel_erreur);
            this.Controls.Add(this.listBox_parametre);
            this.Controls.Add(this.listBox_apercu);
            this.Controls.Add(this.listBox_tampon);
            this.Controls.Add(this.listBox_origine);
            this.Controls.Add(this.gridControl3);
            this.Controls.Add(this.metroTile6);
            this.Controls.Add(this.metroTile5);
            this.Controls.Add(this.metroTile4);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.listView_parametres);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "Form1";
            this.Text = "Rname";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTab_delete.ResumeLayout(false);
            this.metroTab_delete.PerformLayout();
            this.metroTab_replace.ResumeLayout(false);
            this.metroTab_replace.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTab_replace;
        private MetroFramework.Controls.MetroTabPage metroTab_delete;
        private MetroFramework.Controls.MetroTabPage metroTab_special;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
        private System.Windows.Forms.ListView listView_parametres;
        private MetroFramework.Controls.MetroButton metroButton_v_remplacer;
        private MetroFramework.Controls.MetroTextBox metroTextBox_rempl_new;
        private MetroFramework.Controls.MetroTextBox metroTextBox_rempl_base;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTile metroTile1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroButton metroButton_supprimer;
        private MetroFramework.Controls.MetroTextBox metroTextBox_supp_valeur;
        private MetroFramework.Controls.MetroTile metroTile2;
        private Syncfusion.Windows.Forms.Grid.GridControl gridControl2;
        private MetroFramework.Controls.MetroTile metroTile6;
        private MetroFramework.Controls.MetroTile metroTile5;
        private MetroFramework.Controls.MetroTile metroTile4;
        private MetroFramework.Controls.MetroTile metroTile3;
        private Syncfusion.Windows.Forms.Grid.GridControl gridControl3;
        private MetroFramework.Controls.MetroTabPage metroTab_transform;
        private System.Windows.Forms.ListBox listBox_parametre;
        private System.Windows.Forms.ListBox listBox_apercu;
        private System.Windows.Forms.ListBox listBox_tampon;
        private System.Windows.Forms.ListBox listBox_origine;
        private MetroFramework.Controls.MetroTabPage metroTab_tranform;
        private MetroFramework.Controls.MetroLabel metroLabel_erreur;
        private System.Windows.Forms.ListBox listBox_extension;
    }
}

