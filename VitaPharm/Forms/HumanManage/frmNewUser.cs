﻿using DevExpress.XtraEditors;
using VitaPharm.Data;


namespace VitaPharm.Forms.HumanManage
{
    public partial class frmNewUser : DevExpress.XtraEditors.XtraForm
    {
        private PharmacyDbContext context = new PharmacyDbContext();
        private List<string> roles = new List<string> { "Admin", "User" };

        public frmNewUser()
        {
            InitializeComponent();
        }

        private void frmNewUser_Load(object sender, EventArgs e)
        {
            cboRole.Properties.Items.Clear();
            cboRole.Properties.Items.AddRange(roles);
            cboRole.SelectedIndex = 1;
            chkIsActive.Checked = true;
            chkFemale.Checked = false;
            dtpBirthday.EditValue = DateTime.Now;

            txtUsername.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            txtName.Text = "";
            txtContact.Text = "";
            txtAddress.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                XtraMessageBox.Show("Please enter a username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                XtraMessageBox.Show("Please enter a password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return;
            }
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                XtraMessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfirmPassword.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                XtraMessageBox.Show("Please enter the full name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return;
            }
            if (context.Accounts.Any(a => a.Username == txtUsername.Text))
            {
                XtraMessageBox.Show("Username already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
                return;
            }
            Employee emp = new Employee
            {
                EmployeeName = txtName.Text,
                Sex = chkFemale.Checked ? "F" : "M",
                Birthday = dtpBirthday.DateTime,
                Contact = txtContact.Text,
                EmployeeAddress = txtAddress.Text
            };
            context.Employees.Add(emp);
            context.SaveChanges();
            // Create Account
            Account acc = new Account
            {
                Username = txtUsername.Text,
                UserPassword = txtPassword.Text,
                UserRole = cboRole.Text,
                IsActive = chkIsActive.Checked ? "Active" : "InActive",
                Employee = emp
            };
            context.Accounts.Add(acc);
            context.SaveChanges();
            XtraMessageBox.Show("New user added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmNewUser_Load(sender, e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show(
                "Do you want to discard changes and reload original data?",
                "Confirm Cancel",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frmNewUser_Load(sender, e);
            }
        }
    }
}