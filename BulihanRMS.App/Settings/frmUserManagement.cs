using BulihanRMS.App.Properties;
using BulihanRMS.App.Helpers.Themes;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BulihanRMS.Queries.Persistence;
using Bunifu.Framework.UI;
using BulihanRMS.Logic.Contracts;
using BulihanRMS.Logic.Implementors;
using BulihanRMS.Logic;
using BulihanRMS.Logic.Models;
using MetroFramework;
using Helpers;
using Bunifu.UI.WinForms.BunifuTextbox;
using Microsoft.Reporting.WinForms;
using BulihanRMS.App.Reports;


namespace BulihanRMS.App
{
    public partial class frmUserManagement : Form
    {
        private int userID = 1;
       
        public frmUserManagement()
        {
            InitializeComponent();

        }

        private void AddHandlers()
        {
            var flatButtons = LocalUtils.GetAll(this, typeof(BunifuFlatButton))
                     .OrderBy(c => c.TabIndex);
            foreach (BunifuFlatButton item in flatButtons)
            {

                item.Click += flatButton_OnSetFormTitle;

            }
            var textboxes = LocalUtils.GetAll(this, typeof(BunifuTextBox))
                     .Where(c => c.CausesValidation == true).OrderBy(c => c.TabIndex);
            foreach (BunifuTextBox item in textboxes)
            {
                if (item.Tag != null)
                {


                    if (item.Tag.ToString().Contains("integer"))
                    {
                        item.TextChange += item_IntCheckTextChange;
                    }
                    else if (item.Tag.ToString().Contains("double"))
                    {
                        item.TextChange += item_DoubleCheckTextChange;
                    }


                }
            }

        }

        private void item_IntCheckTextChange(object sender, EventArgs e)
        {
            var control = (PlaceholderTextBox)sender;

            int value = 0;
            if (!int.TryParse(control.Text, out value))
            {
                control.Text = "0";
            }

        }
        void item_DoubleCheckTextChange(object sender, EventArgs e)
        {
            var control = (PlaceholderTextBox)sender;

            double value = 0;
            if (!double.TryParse(control.Text, out value))
            {
                control.Text = "0.0";
            }

        }

        private void flatButton_OnSetFormTitle(object sender, EventArgs e)
        {
            //BunifuFlatButton flatButton = (BunifuFlatButton)sender;
            //lblTitle.Text = "INFORMATION SHEET";
            //lblTitle.Text = lblTitle.Text + " - " + flatButton.Tag.ToString();
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

        private void frm_Load(object sender, EventArgs e)
        {
            AddHandlers();
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Save();
            }
            catch (Exception ex)
            {
                LocalUtils.ShowErrorMessage(this, ex.Message);
            }
        }
        private async void Save()
        {

            if (!ValidatedFields())
            {
                return;
            }
            var dto = new UserDTO();
            dto.Password = txtPassword.Text;
            dto.RetypePassword = txtRetypePassword.Text;
            await Task.Run(() => Factories.CreateUser().Edit(userID, dto));
            LocalUtils.ShowSaveMessage(this);
            this.Close();


        }

        private bool ValidatedFields()
        {

            var ctrlTextBoxes2 = LocalUtils.GetAll(this, typeof(BunifuTextBox))
                       .Where(c => c.CausesValidation == true).OrderBy(c => c.TabIndex);
            foreach (BunifuTextBox item in ctrlTextBoxes2)
            {

                if (item.Text == string.Empty)
                {
                    LocalUtils.ShowValidationFailedMessage(this);
                    return false;
                }

            }
            var ctrlDropdown = LocalUtils.GetAll(this, typeof(Bunifu.UI.WinForms.BunifuDropdown))
                        .Where(c => c.CausesValidation == true).OrderBy(c => c.TabIndex);
            foreach (Bunifu.UI.WinForms.BunifuDropdown item in ctrlDropdown)
            {
                if (item.SelectedIndex < 0)
                {
                    item.Focus();
                    LocalUtils.ShowValidationFailedMessage(this);
                    return false;
                }
            }

            return true;
        }

 
       
    }

}
