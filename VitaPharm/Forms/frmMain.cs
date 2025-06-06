﻿using DevExpress.XtraEditors;
using VitaPharm.Forms.HumanManage;
using VitaPharm.Forms.Commodities;
using VitaPharm.Data;
using VitaPharm.Forms.Receipt;
using VitaPharm.Forms.Invoices;
using VitaPharm.Reports;

namespace VitaPharm.Forms
{
    public partial class frmMain : XtraForm
    {
        #region Global variable
        private frmProfile? profileForm = null;
        private frmNewUser? newUserForm = null;
        private frmAllGoodsReceipt? allGoodsReceiptForm = null;
        private frmAllUsers? allUsersForm = null;
        private frmAllCustomers? allCustomersForm = null;
        private frmNewGoodsReceipt? newGoodsReceiptForm = null;
        private frmAllCommodities? allCommoditiesForm = null;
        private frmNewCommodity? newCommodityForm = null;
        private frmAllInvoices? allInvoicesForm = null;
        private frmNewInvoice? newInvoicesForm = null;
        private frmRevenueReportViewer? revenueReportForm = null;
        private bool shouldClose = false;
        #endregion

        public frmMain()
        {
            InitializeComponent();
            this.IsMdiContainer = true;

            using (var signIn = new frmSignIn())
            {
                if (signIn.ShowDialog() != DialogResult.OK)
                {
                    shouldClose = true;
                }
                else
                {
                    XtraMessageBox.Show(
                        "Login successful!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    ConfigureBasedOnRole();
                    OpenProfile();
                }
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (shouldClose)
            {
                this.Close();
            }
        }

        private void SignOut()
        {
            CurrentUser.Username = null;
            CurrentUser.Role = null;
            CurrentUser.EmployeeID = 0;
            foreach (var f in this.MdiChildren) f.Close();

            this.Hide();
            using (var signIn = new frmSignIn())
            {
                if (signIn.ShowDialog() == DialogResult.OK)
                {
                    this.Show();
                    ConfigureBasedOnRole();
                    OpenProfile();
                }
                else
                {
                    this.Close();
                }
            }
        }

        #region ConfigureBasedOnRole
        private void ConfigureBasedOnRole()
        {
            bool isAdmin = CurrentUser.Role.Equals("Admin", StringComparison.OrdinalIgnoreCase);
            bool isUser = CurrentUser.Role.Equals("User", StringComparison.OrdinalIgnoreCase);

            btnProfile.Enabled = true;
            btnNewUser.Enabled = isAdmin;
            btnAllUsers.Enabled = isAdmin;
            btnAllGoodsReceipt.Enabled = true;
            btnAllCustomers.Enabled = true;
            btnNewReceipt.Enabled = isUser;
            btnAllCommodities.Enabled = true;
            btnNewCommodity.Enabled = true;
            btnAllInvoices.Enabled = true;
            btnNewInvoice.Enabled = isUser;
            btnRevenueReport.Enabled = isAdmin;
        }

        private void OpenProfile()
        {
            foreach (var f in this.MdiChildren) f.Close();
            profileForm = new frmProfile(CurrentUser.EmployeeID)
            {
                MdiParent = this
            };
            profileForm.Show();
        }

        private void OpenNewUser()
        {
            if (!CurrentUser.Role.Equals("Admin", StringComparison.OrdinalIgnoreCase))
            {
                XtraMessageBox.Show("You do not have permission to access this feature!", "Notification",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (var f in this.MdiChildren) f.Close();

            if (newUserForm == null || newUserForm.IsDisposed)
            {
                newUserForm = new frmNewUser()
                {
                    MdiParent = this
                };
            }
            newUserForm.Show();
            newUserForm.BringToFront();
        }

        private void OpenAllGoodsReceipt()
        {
            foreach (var f in this.MdiChildren) f.Close();
            if (allGoodsReceiptForm == null || allGoodsReceiptForm.IsDisposed)
            {
                allGoodsReceiptForm = new frmAllGoodsReceipt(CurrentUser.Username)
                {
                    MdiParent = this
                };
            }
            allGoodsReceiptForm.Show();
            allGoodsReceiptForm.BringToFront();
        }

        private void OpenAllUsers()
        {
            if (!CurrentUser.Role.Equals("Admin", StringComparison.OrdinalIgnoreCase))
            {
                XtraMessageBox.Show("You do not have permission to access this feature!", "Notification",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (var f in this.MdiChildren) f.Close();

            if (allUsersForm == null || allUsersForm.IsDisposed)
            {
                allUsersForm = new frmAllUsers()
                {
                    MdiParent = this
                };
            }
            allUsersForm.Show();
            allUsersForm.BringToFront();
        }

        private void OpenAllCustomers()
        {
            foreach (var f in this.MdiChildren) f.Close();
            if (allCustomersForm == null || allCustomersForm.IsDisposed)
            {
                allCustomersForm = new frmAllCustomers()
                {
                    MdiParent = this
                };
            }
            allCustomersForm.Show();
            allCustomersForm.BringToFront();
        }

        private void OpenAllCommodities()
        {
            foreach (var f in this.MdiChildren) f.Close();
            if (allCommoditiesForm == null || allCommoditiesForm.IsDisposed)
            {
                allCommoditiesForm = new frmAllCommodities()
                {
                    MdiParent = this
                };
            }
            allCommoditiesForm.Show();
            allCommoditiesForm.BringToFront();
        }

        private void OpenNewCommodity()
        {
            foreach (var f in this.MdiChildren) f.Close();
            if (newCommodityForm == null || newCommodityForm.IsDisposed)
            {
                newCommodityForm = new frmNewCommodity()
                {
                    MdiParent = this
                };
            }
            newCommodityForm.Show();
            newCommodityForm.BringToFront();
        }

        private void OpenAllInvoices()
        {
            foreach (var f in this.MdiChildren) f.Close();
            if (allInvoicesForm == null || allInvoicesForm.IsDisposed)
            {
                allInvoicesForm = new frmAllInvoices()
                {
                    MdiParent = this
                };
            }
            allInvoicesForm.Show();
            allInvoicesForm.BringToFront();
        }

        private void OpenNewReceipt()
        {
            foreach (var f in this.MdiChildren) f.Close();

            if (newGoodsReceiptForm == null || newGoodsReceiptForm.IsDisposed)
            {
                newGoodsReceiptForm = new frmNewGoodsReceipt(CurrentUser.Username)
                {
                    MdiParent = this
                };
            }
            newGoodsReceiptForm.Show();
            newGoodsReceiptForm.BringToFront();
        }

        private void OpenNewInvoice()
        {
            foreach (var f in this.MdiChildren) f.Close();

            if (newInvoicesForm == null || newInvoicesForm.IsDisposed)
            {
                newInvoicesForm = new frmNewInvoice(CurrentUser.Username)
                {
                    MdiParent = this
                };
            }
            newInvoicesForm.Show();
            newInvoicesForm.BringToFront();
        }

        public void OpenRevenueReport()
        {
            foreach (var f in this.MdiChildren) f.Close();
            if (revenueReportForm == null || revenueReportForm.IsDisposed)
            {
                revenueReportForm = new frmRevenueReportViewer()
                {
                    MdiParent = this
                };
            }
            revenueReportForm.Show();
            revenueReportForm.BringToFront();
        }
        #endregion



        private void btnProfile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenProfile();
        }

        private void btnNewUser_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenNewUser();
        }

        private void btnAllGoodsReceipt_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenAllGoodsReceipt();
        }

        private void btnAllUsers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenAllUsers();
        }

        private void btnAllCustomers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenAllCustomers();
        }

        private void btnSignOut_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var result = XtraMessageBox.Show("Are you sure you want to sign out?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                SignOut();
            }
        }

        private void btnNewReceipt_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenNewReceipt();
        }

        private void btnAllCommodities_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenAllCommodities();
        }

        private void btnCommodity_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenNewCommodity();
        }

        private void btnAllInvoices_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenAllInvoices();
        }

        private void btnNewInvoice_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenNewInvoice();
        }

        private void btnRevenueReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenRevenueReport();
        }
    }
}