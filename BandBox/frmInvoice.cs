using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using NUnit.Framework;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BandBox
{
    public partial class frmInvoice : Form
    {
        String connectionString = ConfigurationManager.ConnectionStrings["ConnBandBox"].ConnectionString;
        DateTime dtdFrom =DateTime.Parse(ConfigurationManager.AppSettings["KeyFrom"].ToString());
        DateTime dtdTo = DateTime.Parse(ConfigurationManager.AppSettings["KeyTo"].ToString());
        Int32 intDPer = Int32.Parse(ConfigurationManager.AppSettings["KeyPer"].ToString());
        public Int32 intOther = 1000;
        string strBill;
        DateTime strInvDate;

        public frmInvoice()
        {
            InitializeComponent();
            txtItemDesctiption.Visible = false;
            txtPriceO.Visible = false;
            txtQTYO.Visible = false;
            txtTotalO.Visible = false;

            dtpDueDate.Value = DateTime.Now.AddDays(7);
            rbNormal.Checked = true;

            fillItem();
            fetchGSTIN();
            fetchHSN();
            GenerateBill();

        }
        
        private void fillItem()
        {
            try
            {
                using (OleDbConnection sqlcon = new OleDbConnection(connectionString))
                {
                    DataTable dtItem = new DataTable();
                    OleDbCommand cmd = new OleDbCommand("Query_ItemMaster_Combo", sqlcon);
                    cmd.CommandType = CommandType.StoredProcedure;
                    OleDbDataAdapter daItem = new OleDbDataAdapter();
                    sqlcon.Open();
                    cmd.CommandTimeout = 0;
                    daItem.SelectCommand = cmd;
                    //cmd.Parameters.AddWithValue("@FROMDATE", FromDate);
                    //cmd.Parameters.AddWithValue("@TODATE", ToDate);
                    daItem.Fill(dtItem);
                    this.cBItemDescription.DataSource = dtItem;
                    this.cBItemDescription.DisplayMember = "Item";
                    this.cBItemDescription.ValueMember = "ItemID";

                    cBItemDescription_SelectedIndexChanged(cBItemDescription, new EventArgs());
                }
            }
            catch (Exception Ex)
            {

            }
        }
        
        private void fetchGSTIN()
        {
            try
            {
                using (OleDbConnection sqlcon = new OleDbConnection(connectionString))
                {
                    DataTable dtItem = new DataTable();
                    OleDbCommand cmd = new OleDbCommand("Query_GSTINMaster", sqlcon);
                    cmd.CommandType = CommandType.StoredProcedure;
                    sqlcon.Open();
                    cmd.CommandTimeout = 0;
                    OleDbDataReader oledbReader = cmd.ExecuteReader();
                    if (oledbReader.Read())
                    {
                        lblGSTIN.Text = lblGSTIN.Text + oledbReader.GetValue(0);
                    }

                }
            }
            catch (Exception Ex)
            {

            }

        }
        
        private void fetchHSN()
        {
            try
            {
                using (OleDbConnection sqlcon = new OleDbConnection(connectionString))
                {
                    DataTable dtItem = new DataTable();
                    OleDbCommand cmd = new OleDbCommand("Query_HSN", sqlcon);
                    cmd.CommandType = CommandType.StoredProcedure;
                    sqlcon.Open();
                    cmd.CommandTimeout = 0;
                    OleDbDataReader oledbReader = cmd.ExecuteReader();
                    if (oledbReader.Read())
                    {
                        lblHSNCode.Text = lblHSNCode.Text + oledbReader.GetValue(0);
                    }

                }
            }
            catch (Exception Ex)
            {

            }

        }
        
        private void GenerateBill()
        {
            try
            {
                using (OleDbConnection sqlcon = new OleDbConnection(connectionString))
                {
                    DataTable dtItem = new DataTable();
                    OleDbCommand cmd = new OleDbCommand("QueryBillGenerate", sqlcon);
                    cmd.CommandType = CommandType.StoredProcedure;
                    sqlcon.Open();
                    cmd.CommandTimeout = 0;
                    OleDbDataReader oledbReader = cmd.ExecuteReader();
                    if (oledbReader.Read())
                    {
                        if (oledbReader.GetValue(0).ToString() == "")
                        {
                            txtBillNo.Text = "101";
                        }
                        else
                        {
                            txtBillNo.Text = Convert.ToString(Int32.Parse(oledbReader.GetValue(0).ToString()) + 1);
                        }
                    }

                }
            }
            catch (Exception Ex)
            {

            }

        }
        
        private void frmInvoice_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception Ex)
            {

            }
        }
        
        private void cBItemDescription_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cBItemDescription.Text != "Others")
                {
                    txtItemDesctiption.Visible = false;
                    txtPriceO.Visible = false;
                    txtQTYO.Visible = false;
                    txtTotalO.Visible = false;
                    btnADDO.Visible = false;
                    btnDeleteO.Visible = false;

                    txtTQTY.Enabled = true;
                    btnADD.Enabled = true;
                    btnDelete.Enabled = true;

                    using (OleDbConnection sqlcon = new OleDbConnection(connectionString))
                    {
                        DataTable dtPrice = new DataTable();
                        OleDbCommand cmd = new OleDbCommand("Query_Price_Version", sqlcon);
                        cmd.CommandType = CommandType.StoredProcedure;
                        OleDbDataAdapter daPrice = new OleDbDataAdapter();
                        sqlcon.Open();
                        cmd.CommandTimeout = 0;
                        daPrice.SelectCommand = cmd;
                        cmd.Parameters.AddWithValue("@ItemID", cBItemDescription.SelectedValue);
                        daPrice.Fill(dtPrice);
                        sqlcon.Close();

                        string strBillStatus = "";
                        if (rbExpress.Checked == true)
                        {
                            strBillStatus = "EXPRESS";
                        }
                        else if (rbUrgent.Checked == true)
                        {
                            strBillStatus = "URGENT";
                        }
                        else
                        {
                            strBillStatus = "NORMAL";
                        }

                        DataTable dtEPrice = new DataTable();
                        OleDbCommand cmdEP;
                        if (rbExpress.Checked == true)
                        {
                            cmdEP = new OleDbCommand("SELECT BILLVALUE FROM MASTER_BILL_STATUS WHERE BILLSTATUS='" + strBillStatus + "'", sqlcon);
                        }
                        else if (rbUrgent.Checked == true)
                        {
                            cmdEP = new OleDbCommand("SELECT BILLVALUE FROM MASTER_BILL_STATUS WHERE BILLSTATUS='" + strBillStatus + "'", sqlcon);
                        }
                        else
                        {
                            cmdEP = new OleDbCommand("SELECT BILLVALUE FROM MASTER_BILL_STATUS WHERE BILLSTATUS='" + strBillStatus + "'", sqlcon);
                        }

                        cmdEP.CommandType = CommandType.Text;
                        OleDbDataAdapter daEPrice = new OleDbDataAdapter();
                        sqlcon.Open();
                        cmdEP.CommandTimeout = 0;
                        daEPrice.SelectCommand = cmdEP;
                        daEPrice.Fill(dtEPrice);

                        txtPrice.Text = Convert.ToString(Int32.Parse(dtPrice.Rows[0][0].ToString()) + (Int32.Parse(dtPrice.Rows[0][0].ToString())* Int32.Parse(dtEPrice.Rows[0][0].ToString())) / 100 );
                    }
                }
                else
                {
                    txtItemDesctiption.Visible = true;
                    txtPriceO.Visible = true;
                    txtQTYO.Visible = true;
                    txtTotalO.Visible = true;
                    btnADDO.Visible = true;
                    btnDeleteO.Visible = true;

                    txtTQTY.Enabled = false;
                    txtTotal.Enabled = false;
                    btnADD.Enabled = false;
                    btnDelete.Enabled = false;

                    txtTotalO.Text = "0";
                    txtItemDesctiption.Focus();

                }

            }
            catch (Exception Ex)
            {

            }
        }
        
        private void txtQTY_TextChanged(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    if (System.Text.RegularExpressions.Regex.IsMatch(txtQTY.Text, "[^0-9]"))
                    {
                        MessageBox.Show("Please enter only numbers.");
                        txtQTY.Text = txtQTY.Text.Remove(txtQTY.Text.Length - 1);
                        if (txtQTY.Text == "")
                        {
                            txtQTY.Text = "0";
                        }
                    }
                    else
                    {
                        txtTotal.Text = (Int32.Parse(txtPrice.Text) * Int32.Parse(txtQTY.Text)).ToString();
                    }
                }
                catch
                {

                }

            }
            catch (Exception Ex)
            {

            }
        }
        
        private void btnADD_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == "")
                {
                    MessageBox.Show("Please enter customer name");
                    txtName.Focus();
                }
                else if (txtMobile.Text == "")
                {
                    MessageBox.Show("Please enter mobile number");
                    txtMobile.Focus();
                }
                else if (txtQTY.Text == "0")
                {
                    MessageBox.Show("Please enter quantity");
                    txtQTY.Focus();
                }
                else
                {
                    Int32 strVal = 0;
                    for (int i = 1; i <= dgvDETAILS.Rows.Count - 1; i++)
                    {
                        if (cBItemDescription.SelectedValue.ToString() == dgvDETAILS.Rows[i].Cells[0].Value.ToString())
                        {
                            strVal = strVal + i;
                            break;
                        }
                    }
                    if (strVal == 0)
                    {
                        dgvDETAILS.Rows.Add(cBItemDescription.SelectedValue, cBItemDescription.Text, txtPrice.Text, txtQTY.Text, txtTotal.Text);
                        txtQTY.Text = "0";
                        txtTotal.Text = "0";
                        Calculation();
                    }
                    else
                    {
                        MessageBox.Show("Item already exists. Please modify the existing item.");
                    }
                }
            }
            catch (Exception Ex)
            {

            }
        }
        
        public void Calculation()
        {
            try
            {
                Double intTotal = 0;
                Int32 intTQTY = 0;
                for (Int32 i = 0; i < dgvDETAILS.Rows.Count; i++)
                {
                    intTotal = intTotal + Double.Parse(dgvDETAILS.Rows[i].Cells[4].Value.ToString());
                    intTQTY = intTQTY + Int32.Parse(dgvDETAILS.Rows[i].Cells[3].Value.ToString());
                }
                if (dtpInvoiceDate.Value >= dtdFrom && dtpInvoiceDate.Value <= dtdTo)
                {
                    intTotal = intTotal - ((intTotal * intDPer) / 100);
                }

                txtTQTY.Text = String.Format("{0:0}", intTQTY);
                txtSubTotal.Text = String.Format("{0:0.00}", intTotal);
                txtCGST.Text = String.Format("{0:0.00}", (intTotal / 100.00) * 9);  //String.Format("{0:0.00}", Convert.ToString((intTotal / 100.00) * 9));
                txtSGST.Text = String.Format("{0:0.00}", (intTotal / 100.00) * 9);
                txtGTotal.Text = Convert.ToString(System.Math.Round((intTotal + 2 * ((intTotal / 100.00) * 9)), 0));
            }
            catch (Exception Ex)
            {

            }
        }
        
        private void txtMobile_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                System.Text.RegularExpressions.Regex rphone = new System.Text.RegularExpressions.Regex(@"^\d{10,}$", System.Text.RegularExpressions.RegexOptions.Compiled);
                if (txtMobile.Text.Length > 0)
                {
                    if (!rphone.IsMatch(txtMobile.Text))
                    {
                        MessageBox.Show("Please provide valid mobile number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMobile.Text = "";
                        txtMobile.Focus();
                    }
                }
            }
            catch
            {

            }
        }
       
        private void txtMobile_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(txtMobile.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter only numbers.");
                    txtMobile.Text = txtMobile.Text.Remove(txtMobile.Text.Length - 1);
                }
            }
            catch
            {

            }
        }
       
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                //int row = dgvDETAILS.CurrentCell.RowIndex;
                //dgvDETAILS.Rows.RemoveAt(row);
                if (this.dgvDETAILS.SelectedRows.Count > 0)
                {
                    dgvDETAILS.Rows.RemoveAt(this.dgvDETAILS.SelectedRows[0].Index);
                    Calculation();
                }
                else
                {
                    MessageBox.Show("Please select a row to delete");
                }
            }
            catch
            {

            }
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == "")
                {
                    MessageBox.Show("Please fill customer Name");
                    txtName.Focus();
                }
                else if (txtMobile.Text == "")
                {
                    MessageBox.Show("Please fill mobile number");
                    txtMobile.Focus();
                }
                else if (txtGTotal.Text == "0")
                {
                    MessageBox.Show("No Items Entered");
                    txtQTY.Focus();
                }
                else {
                    String strGSTIN = lblGSTIN.Text.Substring(8, lblGSTIN.Text.Length - 8);
                    String strHSN = lblHSNCode.Text.Substring(14, lblHSNCode.Text.Length - 14);
                    strBill = txtBillNo.Text;
                    strInvDate = dtpInvoiceDate.Value;
                    string strBillType = "";
                    if (rbUrgent.Checked == true)
                    {
                        strBillType = "Urgent";
                    }
                    else if (rbExpress.Checked == true)
                    {
                        strBillType = "Express";
                    }
                    using (OleDbConnection sqlcon = new OleDbConnection(connectionString))
                    {
                        String strSQLM = "Insert into T_Bill_Master (BillID,CustomerName,MobileNo,PhoneNo,BillDate,CGST,SGST,GrandTotal,GSTIN,HSN,EntryDate,SubTotal,TQTY,DUEDATE,BILLTYPE) Values ('" + txtBillNo.Text + "','" + txtName.Text + "','" + txtMobile.Text + "','" + txtPhone.Text + "','" + dtpInvoiceDate.Value.ToShortDateString() + "','" + txtCGST.Text + "','" + txtSGST.Text + "','" + txtGTotal.Text + "','" + lblGSTIN.Text + "','" + lblHSNCode.Text + "','" + DateTime.Now + "','" + txtSubTotal.Text + "','" + txtTQTY.Text + "','" + dtpDueDate.Value.ToShortDateString() + "','" + strBillType + "');";

                        OleDbCommand cmdM = new OleDbCommand(strSQLM, sqlcon);
                        cmdM.CommandType = CommandType.Text;
                        sqlcon.Open();
                        cmdM.CommandTimeout = 0;
                        cmdM.ExecuteNonQuery();
                        sqlcon.Close();

                        for (Int32 i = 0; i < dgvDETAILS.Rows.Count; i++)
                        {
                            String strSQLD = "Insert into T_Bill_Details (BillID,ItemID,Item,Price,Qty,ItemTotal) Values ('" + txtBillNo.Text + "','" + Double.Parse(dgvDETAILS.Rows[i].Cells[0].Value.ToString()) + "','" + dgvDETAILS.Rows[i].Cells[1].Value.ToString() + "','" + dgvDETAILS.Rows[i].Cells[2].Value.ToString() + "','" + dgvDETAILS.Rows[i].Cells[3].Value.ToString() + "','" + dgvDETAILS.Rows[i].Cells[4].Value.ToString() + "');";
                            OleDbCommand cmdD = new OleDbCommand(strSQLD, sqlcon);
                            cmdD.CommandType = CommandType.Text;
                            sqlcon.Open();
                            cmdD.CommandTimeout = 0;
                            cmdD.ExecuteNonQuery();
                            sqlcon.Close();
                        }
                    }
                    MessageBox.Show("Data Saved Successfully");

                    txtName.Text = "";
                    txtPhone.Text = "";
                    txtQTY.Text = "";
                    txtMobile.Text = "";
                    txtTotal.Text = "";
                    txtCGST.Text = "";
                    txtSGST.Text = "";
                    txtGTotal.Text = "";
                    txtSubTotal.Text = "";
                    txtTQTY.Text = "0";
                    dgvDETAILS.DataSource = null;
                    dgvDETAILS.Rows.Clear();
                    dgvDETAILS.Refresh();
                    GenerateBill();

                    //frmInvoiceBill frmID = new frmInvoiceBill(strBill);
                    //frmID.ShowDialog();
                    //this.Hide();
                }
            }

            catch (Exception Ex)
            {

            }
        }
       
        private void dgvDETAILS_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex.ToString() != "-1")
                {
                    if (Int32.Parse(dgvDETAILS.Rows[e.RowIndex].Cells[0].Value.ToString()) >= 1000)
                    {
                        txtItemDesctiption.Text = dgvDETAILS.Rows[e.RowIndex].Cells[1].Value.ToString();
                        txtPriceO.Text = dgvDETAILS.Rows[e.RowIndex].Cells[2].Value.ToString();
                        txtQTYO.Text = dgvDETAILS.Rows[e.RowIndex].Cells[3].Value.ToString();

                        dgvDETAILS.Rows.RemoveAt(this.dgvDETAILS.Rows[e.RowIndex].Index);
                    }
                    else
                    {
                        cBItemDescription.SelectedValue = dgvDETAILS.Rows[e.RowIndex].Cells[0].Value.ToString();
                        txtQTY.Text = dgvDETAILS.Rows[e.RowIndex].Cells[3].Value.ToString();

                        cBItemDescription_SelectedIndexChanged(sender, e);
                        txtQTY_TextChanged(sender, e);
                        dgvDETAILS.Rows.RemoveAt(this.dgvDETAILS.Rows[e.RowIndex].Index);
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
        
        private void rbExpress_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                for (Int32 i = 0; i < dgvDETAILS.Rows.Count; i++)
                {
                    dgvDETAILS.Rows.RemoveAt(this.dgvDETAILS.SelectedRows[i].Index);
                }
                Calculation();
                cBItemDescription_SelectedIndexChanged(sender, e);
                txtQTY_TextChanged(sender, e);
            }
            catch
            {

            }
        }
        
        private void rbUrgent_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                for (Int32 i = 0; i < dgvDETAILS.Rows.Count; i++)
                {
                    dgvDETAILS.Rows.RemoveAt(this.dgvDETAILS.SelectedRows[i].Index);
                }
                Calculation();
                cBItemDescription_SelectedIndexChanged(sender, e);
                txtQTY_TextChanged(sender, e);
            }
            catch
            {

            }
        }
        
        private void rbNormal_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                for (Int32 i = 0; i < dgvDETAILS.Rows.Count; i++)
                {
                    dgvDETAILS.Rows.RemoveAt(this.dgvDETAILS.SelectedRows[i].Index);
                }
                Calculation();
                cBItemDescription_SelectedIndexChanged(sender, e);
                txtQTY_TextChanged(sender, e);
            }
            catch
            {

            }
        }
        
        private void txtQTYO_TextChanged(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    if (System.Text.RegularExpressions.Regex.IsMatch(txtQTYO.Text, "[^0-9]"))
                    {
                        MessageBox.Show("Please enter only numbers.");
                        txtQTYO.Text = txtQTYO.Text.Remove(txtQTYO.Text.Length - 1);
                        if (txtQTYO.Text == "")
                        {
                            txtQTYO.Text = "0";
                        }
                    }
                    else
                    {
                        txtTotalO.Text = (Int32.Parse(txtPriceO.Text) * Int32.Parse(txtQTYO.Text)).ToString();
                    }
                }
                catch
                {

                }

            }
            catch (Exception Ex)
            {

            }
        }
        
        private void txtPriceO_TextChanged(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    if (System.Text.RegularExpressions.Regex.IsMatch(txtPriceO.Text, "[^0-9]"))
                    {
                        MessageBox.Show("Please enter only numbers.");
                        txtPriceO.Text = txtPriceO.Text.Remove(txtPriceO.Text.Length - 1);
                        if (txtPriceO.Text == "")
                        {
                            txtPriceO.Text = "0";
                        }
                    }
                    else
                    {
                        txtTotalO.Text = (Int32.Parse(txtPriceO.Text) * Int32.Parse(txtQTYO.Text)).ToString();
                    }
                }
                catch
                {

                }

            }
            catch (Exception Ex)
            {

            }
        }
        
        private void btnADDO_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == "")
                {
                    MessageBox.Show("Please enter customer name");
                    txtName.Focus();
                }
                else if (txtMobile.Text == "")
                {
                    MessageBox.Show("Please enter mobile number");
                    txtMobile.Focus();
                }
                else if (txtItemDesctiption.Text == "")
                {
                    MessageBox.Show("Please enter items");
                    txtItemDesctiption.Focus();
                }
                else if (txtPriceO.Text == "0")
                {
                    MessageBox.Show("Please enter price");
                    txtPriceO.Focus();
                }
                else if (txtQTYO.Text == "0")
                {
                    MessageBox.Show("Please enter quantity");
                    txtQTYO.Focus();
                }
                else
                {
                    Int32 strVal = 0;
                    for (int i = 1; i <= dgvDETAILS.Rows.Count - 1; i++)
                    {
                        if (txtItemDesctiption.Text == dgvDETAILS.Rows[i].Cells[1].Value.ToString())
                        {
                            strVal = strVal + i;
                            break;
                        }
                    }
                    if (strVal == 0)
                    {

                        dgvDETAILS.Rows.Add(intOther + 1, txtItemDesctiption.Text, txtPriceO.Text, txtQTYO.Text, txtTotalO.Text);
                        txtQTYO.Text = "0";
                        txtTotalO.Text = "0";
                        Calculation();
                    }
                    else
                    {
                        MessageBox.Show("Item already exists. Please modify the existing item.");
                    }
                }
            }
            catch (Exception Ex)
            {

            }
        }
        
        private void btnDeleteO_Click(object sender, EventArgs e)
        {
            try
            {
                //int row = dgvDETAILS.CurrentCell.RowIndex;
                //dgvDETAILS.Rows.RemoveAt(row);
                if (this.dgvDETAILS.SelectedRows.Count > 0)
                {
                    dgvDETAILS.Rows.RemoveAt(this.dgvDETAILS.SelectedRows[0].Index);
                    Calculation();
                }
                else
                {
                    MessageBox.Show("Please select a row to delete");
                }
            }
            catch
            {

            }
        }
        
        private void txtPrint_Click(object sender, EventArgs e)
        {
            frmBill frmID = new frmBill();
            frmID.ShowDialog();
            this.Hide();
        }
    }
}

