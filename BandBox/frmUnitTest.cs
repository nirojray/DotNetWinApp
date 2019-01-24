using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BandBox
{
    public partial class frmUnitTest : Form
    {
        public frmUnitTest()
        {
            InitializeComponent();
        }
        public void Add(string intfno,string intsno)
        {
            int intres = int.Parse(intfno) + int.Parse(intsno);
            MessageBox.Show(intres.ToString());
        }
        public void Sub(string intfno, string intsno)
        {
            int intres = int.Parse(intfno) - int.Parse(intsno);
            MessageBox.Show(intres.ToString());
        }
        public void Mul(string intfno, string intsno)
        {
            int intres = int.Parse(intfno) * int.Parse(intsno);
            MessageBox.Show(intres.ToString());
        }
        public void Div(string intfno, string intsno)
        {
            int intres = int.Parse(intfno) / int.Parse(intsno);
            MessageBox.Show(intres.ToString());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Add(txtFNo.Text, txtSNo.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void btnSub_Click(object sender, EventArgs e)
        {
            try
            {
                Sub(txtFNo.Text, txtSNo.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void btnMul_Click(object sender, EventArgs e)
        {
            try
            {
                Mul(txtFNo.Text, txtSNo.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void btnDivide_Click(object sender, EventArgs e)
        {
            try
            {
                Div(txtFNo.Text, txtSNo.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
