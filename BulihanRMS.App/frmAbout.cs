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
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadAboutPDF();
        }

   

        private void btnLogin_Click(object sender, EventArgs e)
        {
           
             
            
        }
        private void LoadAboutPDF()
        {
            // get path to pdf file
            string path = string.Format(@"{0}\pdf\help.pdf", Application.StartupPath);
            axAcroPDF1.LoadFile(path);
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
           
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
