using BulihanRMS.App.Helpers.CustomAttributes;
using BulihanRMS.Logic;
using BulihanRMS.Queries.Persistence;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BulihanRMS.App
{
    public partial class frmLogin : Form
    {
        public event EventHandler OnLoginSuccess;
        private bool isLogin;
        public frmLogin()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        void LoginSuccess()
        {
            var handler = this.OnLoginSuccess;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }
        }

        async void Login()
        {
            try
            {
              if (txtUserName.Text == string.Empty && txtPassword.Text == string.Empty)
                {
                    LocalUtils.ShowErrorMessage(this,"User Name or Password is empty");
                }
                else
                {

                    await Task.Run(() => Factories.CreateUser().LoginUser(txtUserName.Text, txtPassword.Text));
                    //if login success set isLogin to true
                    isLogin = true;
                    LoginSuccess();
                    this.Close();
                }
            }
            catch (Exception ex)
            {

                LocalUtils.ShowErrorMessage(this, ex.Message);
            }
                   
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           
                Login();
            
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isLogin)
            {
                Application.Exit();
            }
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
