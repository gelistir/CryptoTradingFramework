﻿using Crypto.Core.Strategies;
using DevExpress.XtraBars;

namespace CryptoMarketClient.Strategies {
    partial class StrategiesCollectionForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StrategiesCollectionForm));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.siAdd = new DevExpress.XtraBars.BarSubItem();
            this.biRemove = new DevExpress.XtraBars.BarButtonItem();
            this.biEdit = new DevExpress.XtraBars.BarButtonItem();
            this.biStart = new DevExpress.XtraBars.BarButtonItem();
            this.biStop = new DevExpress.XtraBars.BarButtonItem();
            this.btShowData = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.siStatus = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.strategyBaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEnabled = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colDemoMode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStateText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEarned = new DevExpress.XtraGrid.Columns.GridColumn();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.biSimulation = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.strategyBaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.siAdd,
            this.biRemove,
            this.biEdit,
            this.siStatus,
            this.biStart,
            this.biStop,
            this.btShowData,
            this.biSimulation});
            this.barManager1.MaxItemId = 9;
            this.barManager1.OptionsStubGlyphs.AllowStubGlyphs = DevExpress.Utils.DefaultBoolean.True;
            this.barManager1.OptionsStubGlyphs.CaseMode = DevExpress.Utils.Drawing.GlyphTextCaseMode.UpperCase;
            this.barManager1.OptionsStubGlyphs.CornerRadius = 3;
            this.barManager1.OptionsStubGlyphs.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.barManager1.OptionsStubGlyphs.LetterCount = DevExpress.Utils.Drawing.GlyphTextSymbolCount.Two;
            this.barManager1.OptionsStubGlyphs.UseFont = true;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.siAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.biRemove),
            new DevExpress.XtraBars.LinkPersistInfo(this.biEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.biStart, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.biStop),
            new DevExpress.XtraBars.LinkPersistInfo(this.biSimulation),
            new DevExpress.XtraBars.LinkPersistInfo(this.btShowData, true)});
            this.bar1.OptionsBar.DrawBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // siAdd
            // 
            this.siAdd.Caption = "New";
            this.siAdd.Id = 0;
            this.siAdd.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("siAdd.ImageOptions.SvgImage")));
            this.siAdd.Name = "siAdd";
            this.siAdd.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // biRemove
            // 
            this.biRemove.Caption = "Remove Selected";
            this.biRemove.Id = 1;
            this.biRemove.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("biRemove.ImageOptions.SvgImage")));
            this.biRemove.Name = "biRemove";
            this.biRemove.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.biRemove.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.biRemove_ItemClick);
            // 
            // biEdit
            // 
            this.biEdit.Caption = "Edit";
            this.biEdit.Id = 2;
            this.biEdit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("biEdit.ImageOptions.SvgImage")));
            this.biEdit.Name = "biEdit";
            this.biEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.biEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.biEdit_ItemClick);
            // 
            // biStart
            // 
            this.biStart.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
            this.biStart.Caption = "<b>Run!</b>";
            this.biStart.Id = 4;
            this.biStart.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("biStart.ImageOptions.SvgImage")));
            this.biStart.ItemAppearance.Hovered.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Information;
            this.biStart.ItemAppearance.Hovered.Options.UseForeColor = true;
            this.biStart.ItemAppearance.Normal.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Information;
            this.biStart.ItemAppearance.Normal.Options.UseForeColor = true;
            this.biStart.ItemAppearance.Pressed.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Information;
            this.biStart.ItemAppearance.Pressed.Options.UseForeColor = true;
            this.biStart.Name = "biStart";
            this.biStart.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.biStart.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.biStart_ItemClick);
            // 
            // biStop
            // 
            this.biStop.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
            this.biStop.Caption = "<b>Stop</b>";
            this.biStop.Id = 5;
            this.biStop.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("biStop.ImageOptions.SvgImage")));
            this.biStop.ItemAppearance.Hovered.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Critical;
            this.biStop.ItemAppearance.Hovered.Options.UseForeColor = true;
            this.biStop.ItemAppearance.Normal.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Critical;
            this.biStop.ItemAppearance.Normal.Options.UseForeColor = true;
            this.biStop.ItemAppearance.Pressed.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Critical;
            this.biStop.ItemAppearance.Pressed.Options.UseForeColor = true;
            this.biStop.Name = "biStop";
            this.biStop.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.biStop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.biStop_ItemClick);
            // 
            // btShowData
            // 
            this.btShowData.Caption = "Show Data";
            this.btShowData.Id = 6;
            this.btShowData.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btShowData.ImageOptions.SvgImage")));
            this.btShowData.Name = "btShowData";
            this.btShowData.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btShowData.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btShowData_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.siStatus)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // siStatus
            // 
            this.siStatus.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
            this.siStatus.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.siStatus.Caption = "    ";
            this.siStatus.Id = 3;
            this.siStatus.ItemAppearance.Normal.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Information;
            this.siStatus.ItemAppearance.Normal.Options.UseForeColor = true;
            this.siStatus.Name = "siStatus";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1667, 60);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 967);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1667, 59);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 60);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 907);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1667, 60);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 907);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.strategyBaseBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 60);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemCheckEdit1,
            this.repositoryItemCheckEdit2});
            this.gridControl1.Size = new System.Drawing.Size(1667, 907);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // strategyBaseBindingSource
            // 
            this.strategyBaseBindingSource.DataSource = typeof(Crypto.Core.Strategies.StrategyBase);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEnabled,
            this.colDemoMode,
            this.colDescription,
            this.colName,
            this.colStateText,
            this.colEarned});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full;
            this.gridView1.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridView1_RowStyle);
            // 
            // colEnabled
            // 
            this.colEnabled.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colEnabled.FieldName = "Enabled";
            this.colEnabled.MinWidth = 40;
            this.colEnabled.Name = "colEnabled";
            this.colEnabled.Visible = true;
            this.colEnabled.VisibleIndex = 0;
            this.colEnabled.Width = 175;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.SvgToggle1;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.EditValueChanged += new System.EventHandler(this.repositoryItemCheckEdit1_EditValueChanged);
            // 
            // colDemoMode
            // 
            this.colDemoMode.ColumnEdit = this.repositoryItemCheckEdit2;
            this.colDemoMode.FieldName = "DemoMode";
            this.colDemoMode.MinWidth = 40;
            this.colDemoMode.Name = "colDemoMode";
            this.colDemoMode.Visible = true;
            this.colDemoMode.VisibleIndex = 1;
            this.colDemoMode.Width = 213;
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.SvgToggle1;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            this.repositoryItemCheckEdit2.EditValueChanged += new System.EventHandler(this.repositoryItemCheckEdit2_EditValueChanged);
            // 
            // colDescription
            // 
            this.colDescription.ColumnEdit = this.repositoryItemTextEdit1;
            this.colDescription.FieldName = "Description";
            this.colDescription.MinWidth = 40;
            this.colDescription.Name = "colDescription";
            this.colDescription.OptionsColumn.AllowEdit = false;
            this.colDescription.Width = 554;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            this.repositoryItemTextEdit1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.MinWidth = 40;
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowEdit = false;
            this.colName.OptionsColumn.ReadOnly = true;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 2;
            this.colName.Width = 615;
            // 
            // colStateText
            // 
            this.colStateText.FieldName = "StateText";
            this.colStateText.MinWidth = 40;
            this.colStateText.Name = "colStateText";
            this.colStateText.OptionsColumn.AllowEdit = false;
            this.colStateText.Visible = true;
            this.colStateText.VisibleIndex = 3;
            this.colStateText.Width = 297;
            // 
            // colEarned
            // 
            this.colEarned.DisplayFormat.FormatString = "0.0000000";
            this.colEarned.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colEarned.FieldName = "Earned";
            this.colEarned.MinWidth = 40;
            this.colEarned.Name = "colEarned";
            this.colEarned.OptionsColumn.AllowEdit = false;
            this.colEarned.Visible = true;
            this.colEarned.VisibleIndex = 4;
            this.colEarned.Width = 331;
            // 
            // biSimulation
            // 
            this.biSimulation.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
            this.biSimulation.Caption = "<b>Simulation</b>";
            this.biSimulation.Id = 8;
            this.biSimulation.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.biSimulation.ItemAppearance.Hovered.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Question;
            this.biSimulation.ItemAppearance.Hovered.Options.UseForeColor = true;
            this.biSimulation.ItemAppearance.Normal.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Question;
            this.biSimulation.ItemAppearance.Normal.Options.UseForeColor = true;
            this.biSimulation.ItemAppearance.Pressed.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Question;
            this.biSimulation.ItemAppearance.Pressed.Options.UseForeColor = true;
            this.biSimulation.Name = "biSimulation";
            this.biSimulation.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.biSimulation.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.biSimulation_ItemClick);
            // 
            // StrategiesCollectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1667, 1026);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "StrategiesCollectionForm";
            this.Text = "Active Strategies";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.strategyBaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private Bar bar1;
        private Bar bar3;
        private BarDockControl barDockControlTop;
        private BarDockControl barDockControlBottom;
        private BarDockControl barDockControlLeft;
        private BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarSubItem siAdd;
        private DevExpress.XtraBars.BarButtonItem biRemove;
        private DevExpress.XtraBars.BarButtonItem biEdit;
        private DevExpress.XtraBars.BarStaticItem siStatus;
        private BarButtonItem biStart;
        private BarButtonItem biStop;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource strategyBaseBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colEnabled;
        private DevExpress.XtraGrid.Columns.GridColumn colDemoMode;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colStateText;
        private DevExpress.XtraGrid.Columns.GridColumn colEarned;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private BarButtonItem btShowData;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private BarButtonItem biSimulation;
    }
}