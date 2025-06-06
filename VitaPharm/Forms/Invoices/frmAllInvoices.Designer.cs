﻿namespace VitaPharm.Forms.Invoices
{
    partial class frmAllInvoices
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAllInvoices));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            imageCollection = new DevExpress.Utils.ImageCollection(components);
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            btnClose = new DevExpress.XtraEditors.SimpleButton();
            btnReload = new DevExpress.XtraEditors.SimpleButton();
            btnDeactive = new DevExpress.XtraEditors.SimpleButton();
            btnNewInvoice = new DevExpress.XtraEditors.SimpleButton();
            repobtnViewDetail = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            colID = new DevExpress.XtraGrid.Columns.GridColumn();
            colInvoiceCode = new DevExpress.XtraGrid.Columns.GridColumn();
            colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            colEmployeeName = new DevExpress.XtraGrid.Columns.GridColumn();
            colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            colNote = new DevExpress.XtraGrid.Columns.GridColumn();
            colViewDetail = new DevExpress.XtraGrid.Columns.GridColumn();
            gridControl = new DevExpress.XtraGrid.GridControl();
            toolTip1 = new ToolTip(components);
            panel1 = new Panel();
            toolStrip1 = new ToolStrip();
            btnExport = new ToolStripButton();
            btnImport = new ToolStripButton();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)imageCollection).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)repobtnViewDetail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControl).BeginInit();
            panel1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // imageCollection
            // 
            imageCollection.ImageStream = (DevExpress.Utils.ImageCollectionStreamer)resources.GetObject("imageCollection.ImageStream");
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(btnClose);
            panelControl1.Controls.Add(btnReload);
            panelControl1.Controls.Add(btnDeactive);
            panelControl1.Controls.Add(btnNewInvoice);
            panelControl1.Dock = DockStyle.Bottom;
            panelControl1.Location = new Point(0, 351);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new Size(853, 64);
            panelControl1.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            btnClose.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            btnClose.Appearance.Options.UseBackColor = true;
            btnClose.Appearance.Options.UseFont = true;
            btnClose.Location = new Point(723, 16);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(118, 36);
            btnClose.TabIndex = 14;
            btnClose.Text = "Close";
            btnClose.Click += btnClose_Click;
            // 
            // btnReload
            // 
            btnReload.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnReload.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Warning;
            btnReload.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            btnReload.Appearance.Options.UseBackColor = true;
            btnReload.Appearance.Options.UseFont = true;
            btnReload.Location = new Point(599, 16);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(118, 36);
            btnReload.TabIndex = 13;
            btnReload.Text = "Reload";
            btnReload.Click += btnReload_Click;
            // 
            // btnDeactive
            // 
            btnDeactive.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDeactive.Appearance.BackColor = Color.FromArgb(78, 109, 156);
            btnDeactive.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            btnDeactive.Appearance.Options.UseBackColor = true;
            btnDeactive.Appearance.Options.UseFont = true;
            btnDeactive.Location = new Point(475, 16);
            btnDeactive.Name = "btnDeactive";
            btnDeactive.Size = new Size(118, 36);
            btnDeactive.TabIndex = 12;
            btnDeactive.Text = "Deactive";
            // 
            // btnNewInvoice
            // 
            btnNewInvoice.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNewInvoice.Appearance.BackColor = Color.FromArgb(100, 165, 80);
            btnNewInvoice.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold);
            btnNewInvoice.Appearance.Options.UseBackColor = true;
            btnNewInvoice.Appearance.Options.UseFont = true;
            btnNewInvoice.Location = new Point(351, 16);
            btnNewInvoice.Name = "btnNewInvoice";
            btnNewInvoice.Size = new Size(118, 36);
            btnNewInvoice.TabIndex = 11;
            btnNewInvoice.Text = "New Invoice";
            btnNewInvoice.Click += btnNewInvoice_Click;
            // 
            // repobtnViewDetail
            // 
            repobtnViewDetail.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            repobtnViewDetail.Appearance.Options.UseBackColor = true;
            repobtnViewDetail.AutoHeight = false;
            repobtnViewDetail.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "View Detail", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default) });
            repobtnViewDetail.Name = "repobtnViewDetail";
            repobtnViewDetail.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // gridView
            // 
            gridView.Appearance.FilterPanel.BorderColor = Color.FromArgb(255, 224, 192);
            gridView.Appearance.FilterPanel.Options.UseBorderColor = true;
            gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colID, colInvoiceCode, colDate, colCustomerName, colEmployeeName, colStatus, colNote, colViewDetail });
            gridView.GridControl = gridControl;
            gridView.Name = "gridView";
            gridView.OptionsBehavior.AutoPopulateColumns = false;
            gridView.OptionsEditForm.EditFormColumnCount = 5;
            gridView.OptionsPrint.PrintFilterInfo = true;
            gridView.OptionsView.ShowAutoFilterRow = true;
            gridView.OptionsView.ShowGroupedColumns = true;
            // 
            // colID
            // 
            colID.Caption = "ID";
            colID.FieldName = "ID";
            colID.MinWidth = 25;
            colID.Name = "colID";
            colID.OptionsColumn.AllowEdit = false;
            colID.OptionsColumn.AllowFocus = false;
            colID.Visible = true;
            colID.VisibleIndex = 0;
            colID.Width = 48;
            // 
            // colInvoiceCode
            // 
            colInvoiceCode.Caption = "Invoice Code";
            colInvoiceCode.FieldName = "InvoiceCode";
            colInvoiceCode.MinWidth = 25;
            colInvoiceCode.Name = "colInvoiceCode";
            colInvoiceCode.OptionsColumn.AllowEdit = false;
            colInvoiceCode.OptionsColumn.AllowFocus = false;
            colInvoiceCode.Visible = true;
            colInvoiceCode.VisibleIndex = 1;
            colInvoiceCode.Width = 98;
            // 
            // colDate
            // 
            colDate.Caption = "Created Date";
            colDate.DisplayFormat.FormatString = "dd/MM/yyyy";
            colDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            colDate.FieldName = "CreatedDate";
            colDate.MinWidth = 25;
            colDate.Name = "colDate";
            colDate.OptionsColumn.AllowEdit = false;
            colDate.OptionsColumn.AllowFocus = false;
            colDate.Visible = true;
            colDate.VisibleIndex = 2;
            colDate.Width = 120;
            // 
            // colCustomerName
            // 
            colCustomerName.Caption = "Customer";
            colCustomerName.FieldName = "CustomerName";
            colCustomerName.MinWidth = 25;
            colCustomerName.Name = "colCustomerName";
            colCustomerName.OptionsColumn.AllowEdit = false;
            colCustomerName.OptionsColumn.AllowFocus = false;
            colCustomerName.Visible = true;
            colCustomerName.VisibleIndex = 3;
            colCustomerName.Width = 145;
            // 
            // colEmployeeName
            // 
            colEmployeeName.Caption = "Employee";
            colEmployeeName.FieldName = "EmployeeName";
            colEmployeeName.MinWidth = 25;
            colEmployeeName.Name = "colEmployeeName";
            colEmployeeName.OptionsColumn.AllowEdit = false;
            colEmployeeName.OptionsColumn.AllowFocus = false;
            colEmployeeName.Visible = true;
            colEmployeeName.VisibleIndex = 4;
            colEmployeeName.Width = 160;
            // 
            // colStatus
            // 
            colStatus.Caption = "Status";
            colStatus.FieldName = "InvoiceStatus";
            colStatus.MinWidth = 25;
            colStatus.Name = "colStatus";
            colStatus.OptionsColumn.AllowEdit = false;
            colStatus.OptionsColumn.AllowFocus = false;
            colStatus.Visible = true;
            colStatus.VisibleIndex = 5;
            colStatus.Width = 94;
            // 
            // colNote
            // 
            colNote.Caption = "Note";
            colNote.FieldName = "Note";
            colNote.MinWidth = 25;
            colNote.Name = "colNote";
            colNote.OptionsColumn.AllowEdit = false;
            colNote.OptionsColumn.AllowFocus = false;
            colNote.Visible = true;
            colNote.VisibleIndex = 6;
            colNote.Width = 136;
            // 
            // colViewDetail
            // 
            colViewDetail.ColumnEdit = repobtnViewDetail;
            colViewDetail.FieldName = "Action";
            colViewDetail.MinWidth = 25;
            colViewDetail.Name = "colViewDetail";
            colViewDetail.OptionsColumn.ShowCaption = false;
            colViewDetail.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            colViewDetail.UnboundDataType = typeof(object);
            colViewDetail.Visible = true;
            colViewDetail.VisibleIndex = 7;
            colViewDetail.Width = 94;
            // 
            // gridControl
            // 
            gridControl.Dock = DockStyle.Fill;
            gridControl.Location = new Point(0, 41);
            gridControl.MainView = gridView;
            gridControl.Name = "gridControl";
            gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repobtnViewDetail });
            gridControl.Size = new Size(853, 310);
            gridControl.TabIndex = 0;
            gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView });
            // 
            // panel1
            // 
            panel1.Controls.Add(toolStrip1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(853, 41);
            panel1.TabIndex = 2;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Fill;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnExport, btnImport });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.Professional;
            toolStrip1.Size = new Size(853, 41);
            toolStrip1.TabIndex = 18;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnExport
            // 
            btnExport.Alignment = ToolStripItemAlignment.Right;
            btnExport.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExport.ForeColor = Color.Brown;
            btnExport.Image = Properties.Resources.export2;
            btnExport.ImageTransparentColor = Color.Magenta;
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(78, 38);
            btnExport.Text = "Export";
            btnExport.Click += btnExport_Click;
            // 
            // btnImport
            // 
            btnImport.Alignment = ToolStripItemAlignment.Right;
            btnImport.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnImport.ForeColor = Color.DarkSlateGray;
            btnImport.Image = Properties.Resources.import1;
            btnImport.ImageTransparentColor = Color.Magenta;
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(79, 38);
            btnImport.Text = "Import";
            btnImport.Click += btnImport_Click;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 41);
            panel2.Name = "panel2";
            panel2.Size = new Size(853, 310);
            panel2.TabIndex = 3;
            // 
            // frmAllInvoices
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(853, 415);
            Controls.Add(gridControl);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panelControl1);
            IconOptions.Image = Properties.Resources.vitapharm_transparent;
            Name = "frmAllInvoices";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "All Invoices";
            Load += frmAllInvoices_Load;
            ((System.ComponentModel.ISupportInitialize)imageCollection).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)repobtnViewDetail).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControl).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnReload;
        private DevExpress.XtraEditors.SimpleButton btnDeactive;
        private DevExpress.XtraEditors.SimpleButton btnNewInvoice;
        private DevExpress.Utils.ImageCollection imageCollection;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repobtnViewDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceCode;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeName;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colNote;
        private DevExpress.XtraGrid.GridControl gridControl;
        private ToolTip toolTip1;
        private DevExpress.XtraGrid.Columns.GridColumn colViewDetail;
        private Panel panel1;
        private Panel panel2;
        private ToolStrip toolStrip1;
        private ToolStripButton btnExport;
        private ToolStripButton btnImport;
    }
}