using BulihanRMS.App.Properties;
using BulihanRMS.App.Helpers.Themes;
using BulihanRMS.App.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BulihanRMS.Logic;
using System.Drawing.Imaging;
using BulihanRMS.Queries.Persistence;

namespace BulihanRMS.App
{
    public partial class frmDashboard : Form
    {
        private DateTime expDate;

        public frmDashboard()
        {
            InitializeComponent();
            expDate = DateTime.Parse("2020-04-20");
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            //ResizeSideBar();
        }
        private void ResizeSideBar()
        {
            const int maxSize = (int)SideBar.maxSize;
            const int minSize = (int)SideBar.minSize;
            switch (pnlSideBar.Width)
            {
                case maxSize:
                    //reduce the size of side bar
                    pnlSideBar.Width = minSize; 
                    //hide the avatar
                    //pictureBox1.Visible = false;
                    break;
                default:
                    //show the avatar
                    //pictureBox1.Visible = true;
                    //increase the size of side bar
                    pnlSideBar.Width = maxSize;
                    break;
            }
        }
        void SetDashboardSummaries()
        {
            var summary = Factories.CreateDashboardSummary().Get();
            // Biz Clearance Summary
            lblBizClearanceMonthlyCount.Text = "Monthly: " + summary.BizClearanceMonthlyCount.ToString();
            lblBizClearanceWeeklyCount.Text = "Weekly: " + summary.BizClearanceWeeklyCount.ToString();
            lblBizClearanceTodayCount.Text = "Today: " + summary.BizClearanceTodayCount.ToString();
            // Brgy Clearance Summary
            lblBrgyClearanceMonthlyCount.Text = "Monthly: " + summary.BrgyClearanceMonthlyCount.ToString();
            lblBrgyClearanceWeeklyCount.Text = "Weekly: " + summary.BrgyClearanceWeeklyCount.ToString();
            lblBrgyClearanceTodayCount.Text = "Today: " + summary.BrgyClearanceTodayCount.ToString();
            // Personal Info Summary
            lblPersonalInfoMonthlyCount.Text = "Monthly: " + summary.PersonalInfoMonthlyCount.ToString();
            lblPersonalInfoWeeklyCount.Text = "Weekly: " + summary.PersonalInfoWeeklyCount.ToString();
            lblPersonalInfoTodayCount.Text = "Today: " + summary.PersonalInfoTodayCount.ToString();
            lblPersonalInfoTotal.Text = "Total Residence: " + summary.PersonalInfoTotalCount.ToString();
           
        }
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized:
                    // restore the default windows state
                    this.WindowState = FormWindowState.Normal;
                    // change image to maximized
                    btnMaximize.Image = Resources.maximize_window_48;
                    break;
                default:
                    // restore the maximized windows state
                    this.WindowState = FormWindowState.Maximized;
                    // change image to restore
                    btnMaximize.Image = Resources.restore_window_48;
                    break;
            }  
             
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnShowMoreMenus_Click(object sender, EventArgs e)
        {
            ResizeSideBar();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
          
            
        }

       
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            page.SetPage(pageDashboard);
            LocalUtils.CenterControlXY(pageDashboard, pnlDashboard);
            LocalUtils.CenterControlXY(pageBarangayInfo, pnlBrgyInfo);
            LocalUtils.CenterControlXY(pageClearance, pnlClearance);
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            try
            {
                
                SetDashboardSummaries();
                SetOpacityToImage(pnlDashboard);
                SetOpacityToImage(pnlBrgyInfo);
                SetOpacityToImage(pnlClearance);
                //LocalUtils.CenterControlXY(pageDashboard, pnlDashboard);
                //LocalUtils.CenterControlXY(pageBarangayInfo, pnlBrgyInfo);
                //LocalUtils.CenterControlXY(pageClearance, pnlClearance);
                
            }
            catch (Exception)
            {
                
                throw;
            }
           
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnBarangayInformations_Click(object sender, EventArgs e)
        {
            page.SetPage(pageBarangayInfo);
            LocalUtils.CenterControlXY(pageDashboard, pnlDashboard);
            LocalUtils.CenterControlXY(pageBarangayInfo, pnlBrgyInfo);
            LocalUtils.CenterControlXY(pageClearance, pnlClearance);
        }

        private void btnClearance_Click(object sender, EventArgs e)
        {
            page.SetPage(pageClearance);
            LocalUtils.CenterControlXY(pageDashboard, pnlDashboard);
            LocalUtils.CenterControlXY(pageBarangayInfo, pnlBrgyInfo);
            LocalUtils.CenterControlXY(pageClearance, pnlClearance);
        }

        private void btnBarangayClearance_Click(object sender, EventArgs e)
        {
            var form = new frmBarangayClearance();
            form.OnRecordSave += form_OnRecordSave;
            form.ShowDialog();
        }

        void form_OnRecordSave(object sender, EventArgs e)
        {
            
            SetDashboardSummaries();
        }

        private void CheckTrialVersion()
        {
            if (expDate.Date <= DateTime.Now.Date)
            {
                LocalUtils.ShowErrorMessage(this, "Your trial version has been ended! Please contact developer.");
                Application.Exit();
            }
            else
            {
                LocalUtils.ShowInfo(this, "This application is a trial version and will be expired on " + expDate.ToString("MMMM dd, yyyy"));
            }
        }

        private void btnBarangayBizClearance_Click(object sender, EventArgs e)
        {
            var form = new frmBrgyBizClearance();
            form.OnRecordSave +=form_OnRecordSave;
            form.ShowDialog();
        }

        private void btnBarangayProperties_Click(object sender, EventArgs e)
        {
            var form = new frmProperties();
            form.ShowDialog();
        }

        private void btnDailyDuty_Click(object sender, EventArgs e)
        {
            var form = new frmDailyDuty();
            form.ShowDialog();
        }

        private void btnPersonalInfo_Click(object sender, EventArgs e)
        {
            var form = new frmPersonalInfo();
            form.OnRecordSave += form_OnRecordSave;
            form.ShowDialog();
        }

        private void btnBarangayOfficials_Click(object sender, EventArgs e)
        {

            var form = new frmOfficials();
            form.ShowDialog();
        }

        private void btnProperties_Click(object sender, EventArgs e)
        {
            var form = new frmProperties();
            form.ShowDialog();
        }

        private void frmDailyDuty_Click(object sender, EventArgs e)
        {
            var form = new frmDailyDuty();
            form.ShowDialog();
        }

        private void btnBlotter_Click(object sender, EventArgs e)
        {
            var form = new frmBlotter();
            form.ShowDialog();
        }

        private void btnIndigency_Click(object sender, EventArgs e)
        {
            var form = new frmIndigency();
            form.ShowDialog();
        }

        private void btnResidency_Click(object sender, EventArgs e)
        {
            var form = new frmResidency();
            form.ShowDialog();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            var form = new frmUserManagement();
            form.ShowDialog();
        }

        private void frmDashboard_Shown(object sender, EventArgs e)
        {
           
            //CheckTrialVersion();
            ShowLogin();
           
        }
        private void ShowLogin()
        {
            var frmLogin = new frmLogin();
            frmLogin.OnLoginSuccess += frmLogin_OnLoginSuccess;
            frmLogin.ShowDialog();
        }

        private void frmLogin_OnLoginSuccess(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            ShowLogin();
        }

        private void btnBusinessRecord_Click(object sender, EventArgs e)
        {
            
            var frm = new frmBusinessRecords();
            frm.ShowDialog();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
        private void SetOpacityToImage(PictureBox pic)
        {
            Image original = null;
            if (original == null) original = (Bitmap)pic.Image.Clone();
            pic.BackColor = Color.Transparent;
            pic.Image = SetAlpha((Bitmap)original, 50);
        }
        private void SetOpacityToImage(Panel pnl)
        {
            Image original = null;
            if (original == null) original = (Bitmap)pnl.BackgroundImage.Clone();
            pnl.BackColor = Color.Transparent;
            pnl.BackgroundImage = SetAlpha((Bitmap)original, 50);
        }
        private Image SetAlpha(Bitmap bmpIn, int alpha)
        {
            Bitmap bmpOut = new Bitmap(bmpIn.Width, bmpIn.Height);
            float a = alpha / 255f;
            Rectangle r = new Rectangle(0, 0, bmpIn.Width, bmpIn.Height);

            float[][] matrixItems = { 
        new float[] {1, 0, 0, 0, 0},
        new float[] {0, 1, 0, 0, 0},
        new float[] {0, 0, 1, 0, 0},
        new float[] {0, 0, 0, a, 0}, 
        new float[] {0, 0, 0, 0, 1}};

            ColorMatrix colorMatrix = new ColorMatrix(matrixItems);

            ImageAttributes imageAtt = new ImageAttributes();
            imageAtt.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            using (Graphics g = Graphics.FromImage(bmpOut))
                g.DrawImage(bmpIn, r, r.X, r.Y, r.Width, r.Height, GraphicsUnit.Pixel, imageAtt);

            return bmpOut;
        }

        private void frmDashboard_Resize(object sender, EventArgs e)
        {
            LocalUtils.CenterControlXY(pageDashboard, pnlDashboard);
            LocalUtils.CenterControlXY(pageBarangayInfo, pnlBrgyInfo);
            LocalUtils.CenterControlXY(pageClearance, pnlClearance);
        }

        private void btnAbout_Click_1(object sender, EventArgs e)
        {
            var frmAbout = new frmAbout();
            frmAbout.ShowDialog();
        }
    }
}
