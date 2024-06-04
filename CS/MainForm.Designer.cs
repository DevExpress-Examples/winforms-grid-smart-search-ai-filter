namespace SmartAIFilter {
    partial class MainForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel1 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel2 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel3 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel4 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel5 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel6 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel7 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel8 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel9 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel10 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel11 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            itemBindingSource = new BindingSource(components);
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            colID = new DevExpress.XtraGrid.Columns.GridColumn();
            colName = new DevExpress.XtraGrid.Columns.GridColumn();
            colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            cbIncludeDescription = new DevExpress.XtraEditors.CheckEdit();
            simpleButtonSmartSearch = new DevExpress.XtraEditors.SimpleButton();
            teFilter = new DevExpress.XtraEditors.TextEdit();
            tbThreshold = new DevExpress.XtraEditors.TrackBarControl();
            layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            lciGridControl1 = new DevExpress.XtraLayout.LayoutControlItem();
            lciTextEditSmartSearch = new DevExpress.XtraLayout.LayoutControlItem();
            lciSimpleButtonSmartSearch = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlGroupSmartSettings = new DevExpress.XtraLayout.LayoutControlGroup();
            lciTrackBarControlSimularityFactor = new DevExpress.XtraLayout.LayoutControlItem();
            lciCheckEditDescription = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            lciLabelControl1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itemBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cbIncludeDescription.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)teFilter.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbThreshold).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbThreshold.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lciGridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lciTextEditSmartSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lciSimpleButtonSmartSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroupSmartSettings).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lciTrackBarControlSimularityFactor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lciCheckEditDescription).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lciLabelControl1).BeginInit();
            SuspendLayout();
            // 
            // gridControl1
            // 
            gridControl1.DataSource = itemBindingSource;
            gridControl1.EmbeddedNavigator.Margin = new Padding(1);
            gridControl1.Location = new Point(16, 82);
            gridControl1.MainView = gridView1;
            gridControl1.Margin = new Padding(2);
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(966, 297);
            gridControl1.TabIndex = 3;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colID, colName, colDescription });
            gridView1.DetailHeight = 239;
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.OptionsEditForm.PopupEditFormWidth = 533;
            gridView1.CustomRowFilter += OnCustomRowFilter;
            // 
            // colID
            // 
            colID.FieldName = "ID";
            colID.Name = "colID";
            colID.Visible = true;
            colID.VisibleIndex = 0;
            // 
            // colName
            // 
            colName.FieldName = "Name";
            colName.Name = "colName";
            colName.Visible = true;
            colName.VisibleIndex = 1;
            // 
            // colDescription
            // 
            colDescription.FieldName = "Description";
            colDescription.Name = "colDescription";
            colDescription.Visible = true;
            colDescription.VisibleIndex = 2;
            // 
            // layoutControl1
            // 
            layoutControl1.AllowCustomization = false;
            layoutControl1.Controls.Add(labelControl1);
            layoutControl1.Controls.Add(cbIncludeDescription);
            layoutControl1.Controls.Add(simpleButtonSmartSearch);
            layoutControl1.Controls.Add(teFilter);
            layoutControl1.Controls.Add(tbThreshold);
            layoutControl1.Controls.Add(gridControl1);
            layoutControl1.Dock = DockStyle.Fill;
            layoutControl1.Location = new Point(0, 0);
            layoutControl1.Margin = new Padding(2);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.Root = layoutControlGroup1;
            layoutControl1.Size = new Size(998, 560);
            layoutControl1.TabIndex = 1;
            // 
            // labelControl1
            // 
            labelControl1.AllowHtmlString = true;
            labelControl1.Appearance.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.DisabledText;
            labelControl1.Appearance.Options.UseForeColor = true;
            labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            labelControl1.Location = new Point(16, 16);
            labelControl1.Margin = new Padding(2);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(966, 26);
            labelControl1.StyleController = layoutControl1;
            labelControl1.TabIndex = 7;
            labelControl1.Text = resources.GetString("labelControl1.Text");
            // 
            // cbIncludeDescription
            // 
            cbIncludeDescription.Location = new Point(32, 428);
            cbIncludeDescription.Margin = new Padding(2);
            cbIncludeDescription.Name = "cbIncludeDescription";
            cbIncludeDescription.Properties.Caption = "Filter against both Description and Name Columns";
            cbIncludeDescription.Size = new Size(934, 22);
            cbIncludeDescription.StyleController = layoutControl1;
            cbIncludeDescription.TabIndex = 5;
            cbIncludeDescription.CheckedChanged += OnIncludeDescriptionChanged;
            // 
            // simpleButtonSmartSearch
            // 
            simpleButtonSmartSearch.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            simpleButtonSmartSearch.Appearance.Options.UseBackColor = true;
            simpleButtonSmartSearch.AutoWidthInLayoutControl = true;
            simpleButtonSmartSearch.ImageOptions.SvgImageSize = new Size(16, 16);
            simpleButtonSmartSearch.Location = new Point(310, 48);
            simpleButtonSmartSearch.Margin = new Padding(2);
            simpleButtonSmartSearch.Name = "simpleButtonSmartSearch";
            simpleButtonSmartSearch.Padding = new Padding(10, 0, 10, 0);
            simpleButtonSmartSearch.Size = new Size(56, 28);
            simpleButtonSmartSearch.StyleController = layoutControl1;
            simpleButtonSmartSearch.TabIndex = 2;
            simpleButtonSmartSearch.Text = "Apply";
            simpleButtonSmartSearch.Click += OnFilter;
            // 
            // teFilter
            // 
            teFilter.Location = new Point(137, 48);
            teFilter.Margin = new Padding(2);
            teFilter.MaximumSize = new Size(167, 0);
            teFilter.MinimumSize = new Size(167, 0);
            teFilter.Name = "teFilter";
            teFilter.Size = new Size(167, 28);
            teFilter.StyleController = layoutControl1;
            teFilter.TabIndex = 0;
            teFilter.KeyDown += teFilter_KeyDown;
            // 
            // tbThreshold
            // 
            tbThreshold.EditValue = 60;
            tbThreshold.Location = new Point(153, 456);
            tbThreshold.Margin = new Padding(2);
            tbThreshold.Name = "tbThreshold";
            tbThreshold.Properties.LabelAppearance.Options.UseTextOptions = true;
            tbThreshold.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            trackBarLabel1.Label = "0";
            trackBarLabel2.Label = "0.1";
            trackBarLabel2.Value = 10;
            trackBarLabel3.Label = "0.2";
            trackBarLabel3.Value = 20;
            trackBarLabel4.Label = "0.3";
            trackBarLabel4.Value = 30;
            trackBarLabel5.Label = "0.4";
            trackBarLabel5.Value = 40;
            trackBarLabel6.Label = "0.5";
            trackBarLabel6.Value = 50;
            trackBarLabel7.Label = "0.6";
            trackBarLabel7.Value = 60;
            trackBarLabel8.Label = "0.7";
            trackBarLabel8.Value = 70;
            trackBarLabel9.Label = "0.8";
            trackBarLabel9.Value = 80;
            trackBarLabel10.Label = "0.9";
            trackBarLabel10.Value = 90;
            trackBarLabel11.Label = "1";
            trackBarLabel11.Value = 100;
            tbThreshold.Properties.Labels.AddRange(new DevExpress.XtraEditors.Repository.TrackBarLabel[] { trackBarLabel1, trackBarLabel2, trackBarLabel3, trackBarLabel4, trackBarLabel5, trackBarLabel6, trackBarLabel7, trackBarLabel8, trackBarLabel9, trackBarLabel10, trackBarLabel11 });
            tbThreshold.Properties.Maximum = 100;
            tbThreshold.Properties.ShowLabels = true;
            tbThreshold.Size = new Size(813, 72);
            tbThreshold.StyleController = layoutControl1;
            tbThreshold.TabIndex = 6;
            tbThreshold.Value = 60;
            tbThreshold.ValueChanged += OnThresholdChanged;
            // 
            // layoutControlGroup1
            // 
            layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            layoutControlGroup1.GroupBordersVisible = false;
            layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { lciGridControl1, lciTextEditSmartSearch, lciSimpleButtonSmartSearch, layoutControlGroupSmartSettings, emptySpaceItem1, lciLabelControl1 });
            layoutControlGroup1.Name = "layoutControlGroup1";
            layoutControlGroup1.Size = new Size(998, 560);
            layoutControlGroup1.TextVisible = false;
            // 
            // lciGridControl1
            // 
            lciGridControl1.Control = gridControl1;
            lciGridControl1.Location = new Point(0, 66);
            lciGridControl1.Name = "lciGridControl1";
            lciGridControl1.Size = new Size(972, 303);
            lciGridControl1.TextSize = new Size(0, 0);
            lciGridControl1.TextVisible = false;
            // 
            // lciTextEditSmartSearch
            // 
            lciTextEditSmartSearch.Control = teFilter;
            lciTextEditSmartSearch.Location = new Point(0, 32);
            lciTextEditSmartSearch.Name = "lciTextEditSmartSearch";
            lciTextEditSmartSearch.Size = new Size(294, 34);
            lciTextEditSmartSearch.Text = "Smart Search AI Filter";
            lciTextEditSmartSearch.TextSize = new Size(105, 13);
            // 
            // lciSimpleButtonSmartSearch
            // 
            lciSimpleButtonSmartSearch.Control = simpleButtonSmartSearch;
            lciSimpleButtonSmartSearch.Location = new Point(294, 32);
            lciSimpleButtonSmartSearch.Name = "lciSimpleButtonSmartSearch";
            lciSimpleButtonSmartSearch.Size = new Size(62, 34);
            lciSimpleButtonSmartSearch.TextSize = new Size(0, 0);
            lciSimpleButtonSmartSearch.TextVisible = false;
            // 
            // layoutControlGroupSmartSettings
            // 
            layoutControlGroupSmartSettings.ExpandButtonVisible = true;
            layoutControlGroupSmartSettings.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            layoutControlGroupSmartSettings.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { lciTrackBarControlSimularityFactor, lciCheckEditDescription });
            layoutControlGroupSmartSettings.Location = new Point(0, 369);
            layoutControlGroupSmartSettings.Name = "layoutControlGroupSmartSettings";
            layoutControlGroupSmartSettings.Size = new Size(972, 165);
            layoutControlGroupSmartSettings.Text = "Smart Search AI Filter Settings";
            // 
            // lciTrackBarControlSimularityFactor
            // 
            lciTrackBarControlSimularityFactor.Control = tbThreshold;
            lciTrackBarControlSimularityFactor.Location = new Point(0, 28);
            lciTrackBarControlSimularityFactor.Name = "lciTrackBarControlSimularityFactor";
            lciTrackBarControlSimularityFactor.Size = new Size(940, 78);
            lciTrackBarControlSimularityFactor.Text = "Simularity Factor";
            lciTrackBarControlSimularityFactor.TextSize = new Size(105, 13);
            // 
            // lciCheckEditDescription
            // 
            lciCheckEditDescription.Control = cbIncludeDescription;
            lciCheckEditDescription.Location = new Point(0, 0);
            lciCheckEditDescription.Name = "lciCheckEditDescription";
            lciCheckEditDescription.Size = new Size(940, 28);
            lciCheckEditDescription.TextSize = new Size(0, 0);
            lciCheckEditDescription.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            emptySpaceItem1.AllowHotTrack = false;
            emptySpaceItem1.Location = new Point(356, 32);
            emptySpaceItem1.Name = "emptySpaceItem1";
            emptySpaceItem1.Size = new Size(616, 34);
            emptySpaceItem1.TextSize = new Size(0, 0);
            // 
            // lciLabelControl1
            // 
            lciLabelControl1.Control = labelControl1;
            lciLabelControl1.Location = new Point(0, 0);
            lciLabelControl1.Name = "lciLabelControl1";
            lciLabelControl1.Size = new Size(972, 32);
            lciLabelControl1.TextSize = new Size(0, 0);
            lciLabelControl1.TextVisible = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 560);
            Controls.Add(layoutControl1);
            Margin = new Padding(2);
            Name = "MainForm";
            Text = "AI – Smart Search Demo";
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)itemBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)cbIncludeDescription.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)teFilter.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbThreshold.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbThreshold).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroup1).EndInit();
            ((System.ComponentModel.ISupportInitialize)lciGridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)lciTextEditSmartSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)lciSimpleButtonSmartSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlGroupSmartSettings).EndInit();
            ((System.ComponentModel.ISupportInitialize)lciTrackBarControlSimularityFactor).EndInit();
            ((System.ComponentModel.ISupportInitialize)lciCheckEditDescription).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)lciLabelControl1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem lciGridControl1;
        private DevExpress.XtraEditors.TrackBarControl tbThreshold;
        private DevExpress.XtraLayout.LayoutControlItem lciTrackBarControlSimularityFactor;
        private DevExpress.XtraEditors.SimpleButton simpleButtonSmartSearch;
        private DevExpress.XtraEditors.TextEdit teFilter;
        private DevExpress.XtraLayout.LayoutControlItem lciTextEditSmartSearch;
        private DevExpress.XtraLayout.LayoutControlItem lciSimpleButtonSmartSearch;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroupSmartSettings;
        private BindingSource itemBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.CheckEdit cbIncludeDescription;
        private DevExpress.XtraLayout.LayoutControlItem lciCheckEditDescription;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraLayout.LayoutControlItem lciLabelControl1;
    }
}
