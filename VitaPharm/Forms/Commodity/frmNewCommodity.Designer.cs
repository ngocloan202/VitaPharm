﻿namespace VitaPharm.Forms
{
    partial class frmNewCommodity
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
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            txtBaseUnit = new DevExpress.XtraEditors.TextEdit();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            txtManufacturer = new DevExpress.XtraEditors.TextEdit();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            textEdit2 = new DevExpress.XtraEditors.TextEdit();
            txtName = new DevExpress.XtraEditors.TextEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            groupControl2 = new DevExpress.XtraEditors.GroupControl();
            cboType = new DevExpress.XtraEditors.ComboBoxEdit();
            groupControl3 = new DevExpress.XtraEditors.GroupControl();
            txtSellingPrice = new DevExpress.XtraEditors.TextEdit();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            btnAdd = new DevExpress.XtraEditors.SimpleButton();
            btnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtBaseUnit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtManufacturer.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl2).BeginInit();
            groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cboType.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl3).BeginInit();
            groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtSellingPrice.Properties).BeginInit();
            SuspendLayout();
            // 
            // groupControl1
            // 
            groupControl1.AppearanceCaption.BorderColor = Color.FromArgb(222, 228, 255);
            groupControl1.AppearanceCaption.Options.UseBorderColor = true;
            groupControl1.Controls.Add(txtBaseUnit);
            groupControl1.Controls.Add(labelControl3);
            groupControl1.Controls.Add(txtManufacturer);
            groupControl1.Controls.Add(labelControl2);
            groupControl1.Controls.Add(textEdit2);
            groupControl1.Controls.Add(txtName);
            groupControl1.Controls.Add(labelControl1);
            groupControl1.Location = new Point(12, 12);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new Size(418, 187);
            groupControl1.TabIndex = 0;
            groupControl1.Text = "Basic Information";
            // 
            // txtBaseUnit
            // 
            txtBaseUnit.Location = new Point(118, 143);
            txtBaseUnit.Name = "txtBaseUnit";
            txtBaseUnit.Size = new Size(271, 22);
            txtBaseUnit.TabIndex = 3;
            // 
            // labelControl3
            // 
            labelControl3.Location = new Point(16, 146);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(53, 16);
            labelControl3.TabIndex = 0;
            labelControl3.Text = "Base Unit";
            // 
            // txtManufacturer
            // 
            txtManufacturer.Location = new Point(118, 90);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new Size(271, 22);
            txtManufacturer.TabIndex = 2;
            // 
            // labelControl2
            // 
            labelControl2.Location = new Point(16, 93);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(76, 16);
            labelControl2.TabIndex = 0;
            labelControl2.Text = "Manufacturer";
            // 
            // textEdit2
            // 
            textEdit2.Location = new Point(446, 56);
            textEdit2.Name = "textEdit2";
            textEdit2.Size = new Size(156, 22);
            textEdit2.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.Location = new Point(118, 36);
            txtName.Name = "txtName";
            txtName.Size = new Size(271, 22);
            txtName.TabIndex = 1;
            // 
            // labelControl1
            // 
            labelControl1.Location = new Point(16, 42);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(33, 16);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "Name";
            // 
            // groupControl2
            // 
            groupControl2.AppearanceCaption.BorderColor = Color.FromArgb(226, 251, 219);
            groupControl2.AppearanceCaption.Options.UseBorderColor = true;
            groupControl2.Controls.Add(cboType);
            groupControl2.Location = new Point(436, 12);
            groupControl2.Name = "groupControl2";
            groupControl2.Size = new Size(193, 78);
            groupControl2.TabIndex = 1;
            groupControl2.Text = "Type of commodity";
            // 
            // cboType
            // 
            cboType.EditValue = "Type";
            cboType.Location = new Point(7, 36);
            cboType.Name = "cboType";
            cboType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cboType.Size = new Size(169, 22);
            cboType.TabIndex = 0;
            // 
            // groupControl3
            // 
            groupControl3.AppearanceCaption.BorderColor = Color.FromArgb(250, 230, 230);
            groupControl3.AppearanceCaption.Options.UseBorderColor = true;
            groupControl3.Controls.Add(txtSellingPrice);
            groupControl3.Controls.Add(labelControl5);
            groupControl3.Controls.Add(labelControl4);
            groupControl3.Location = new Point(436, 96);
            groupControl3.Name = "groupControl3";
            groupControl3.Size = new Size(193, 103);
            groupControl3.TabIndex = 2;
            groupControl3.Text = "Sale";
            // 
            // txtSellingPrice
            // 
            txtSellingPrice.Location = new Point(20, 62);
            txtSellingPrice.Name = "txtSellingPrice";
            txtSellingPrice.Size = new Size(156, 22);
            txtSellingPrice.TabIndex = 1;
            // 
            // labelControl5
            // 
            labelControl5.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelControl5.Appearance.Options.UseFont = true;
            labelControl5.Location = new Point(7, 65);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new Size(8, 16);
            labelControl5.TabIndex = 1;
            labelControl5.Text = "$";
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Location = new Point(55, 31);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(77, 16);
            labelControl4.TabIndex = 0;
            labelControl4.Text = "Selling Price";
            // 
            // btnAdd
            // 
            btnAdd.Appearance.BackColor = Color.FromArgb(50, 112, 188);
            btnAdd.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Appearance.Options.UseBackColor = true;
            btnAdd.Appearance.Options.UseFont = true;
            btnAdd.Location = new Point(239, 213);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(81, 28);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            // 
            // btnCancel
            // 
            btnCancel.Appearance.BackColor = SystemColors.Window;
            btnCancel.Appearance.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Appearance.Options.UseBackColor = true;
            btnCancel.Appearance.Options.UseFont = true;
            btnCancel.Location = new Point(335, 213);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(84, 28);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            // 
            // frmNewCommodity
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(641, 248);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(groupControl3);
            Controls.Add(groupControl2);
            Controls.Add(groupControl1);
            Name = "frmNewCommodity";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New Commodity";
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtBaseUnit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtManufacturer.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl2).EndInit();
            groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)cboType.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl3).EndInit();
            groupControl3.ResumeLayout(false);
            groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtSellingPrice.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtBaseUnit;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtManufacturer;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.ComboBoxEdit cboType;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.TextEdit txtSellingPrice;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
    }
}