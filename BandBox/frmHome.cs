using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Reflection;

namespace BandBox
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            try
            {
                LblVersion.Text = "V : " + Assembly.GetExecutingAssembly().GetName().Version.ToString();
                M_MASTER.Visible = false;
                                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void SM_USER_Click(object sender, EventArgs e)
        {
            try
            {
               
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void M_INVOICE_Click(object sender, EventArgs e)
        {
            try
            {
                Form[] activeChild = this.MdiChildren;

                if (activeChild.Length == 0)
                {
                    frmInvoice frmID = new frmInvoice();
                    frmID.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void M_BILL_Click(object sender, EventArgs e)
        {
            try
            {
                Form[] activeChild = this.MdiChildren;

                if (activeChild.Length == 0)
                {
                    frmBill frmID = new frmBill();
                    frmID.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void M_DAILYREPORT_Click(object sender, EventArgs e)
        {
            try
            {
                Form[] activeChild = this.MdiChildren;

                if (activeChild.Length == 0)
                {
                    frmDailyReport frmID = new frmDailyReport();
                    frmID.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
