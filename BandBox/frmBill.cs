using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Data.OleDb;
using System.Configuration;

namespace BandBox
{
    public partial class frmBill : Form
    {
        String connectionString = ConfigurationManager.ConnectionStrings["ConnBandBox"].ConnectionString;
        String ConnectionCR = ConfigurationManager.AppSettings["ConnRep"].ToString();
        DateTime dtdFrom = DateTime.Parse(ConfigurationManager.AppSettings["KeyFrom"].ToString());
        DateTime dtdTo = DateTime.Parse(ConfigurationManager.AppSettings["KeyTo"].ToString());
        public frmBill()
        {
            InitializeComponent();

        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbBillNo.Text != "")
                {
                    ReportDocument rptDoc = new ReportDocument();
                    using (OleDbConnection sqlcon = new OleDbConnection(connectionString))
                    {
                        DataTable dtExist = new DataTable();
                        OleDbCommand cmdExist = new OleDbCommand("Select * from T_BILL_Master where BillID =" + Int32.Parse(cbBillNo.Text) + "", sqlcon);
                        cmdExist.CommandType = CommandType.Text;
                        OleDbDataAdapter daItemExist = new OleDbDataAdapter();
                        sqlcon.Open();
                        cmdExist.CommandTimeout = 0;
                        daItemExist.SelectCommand = cmdExist;
                        daItemExist.Fill(dtExist);
                        sqlcon.Close();

                        if (dtExist.Rows.Count > 0)
                        {
                            DataTable dtA = new DataTable();
                            dtA.TableName = "Address";
                            DataTable dtM = new DataTable();
                            dtM.TableName = "Master";
                            DataTable dtD = new DataTable();
                            dtD.TableName = "Details";

                            OleDbCommand cmdA = new OleDbCommand("Select Address,Mobile from Master_Address", sqlcon);
                            cmdA.CommandType = CommandType.Text;
                            OleDbDataAdapter daItemA = new OleDbDataAdapter();
                            sqlcon.Open();
                            cmdA.CommandTimeout = 0;
                            daItemA.SelectCommand = cmdA;
                            daItemA.Fill(dtA);
                            sqlcon.Close();

                            OleDbCommand cmdD = new OleDbCommand("Select ItemId,Item,Price,Qty,ItemTotal from T_Bill_Details where BillID=" + Int32.Parse(cbBillNo.Text) + "", sqlcon);
                            cmdD.CommandType = CommandType.Text;
                            OleDbDataAdapter daItemD = new OleDbDataAdapter();
                            sqlcon.Open();
                            cmdD.CommandTimeout = 0;
                            daItemD.SelectCommand = cmdD;
                            daItemD.Fill(dtD);
                            sqlcon.Close();

                            OleDbCommand cmdM = new OleDbCommand("Select BillID,CustomerName,Address,MobileNo,PhoneNo,BillDate,CGST,SGST,GrandTotal,GSTIN,HSN,EntryDate,SubTotal,TQTY,DUEDATE,BILLTYPE from T_Bill_Master where BillID=" + Int32.Parse(cbBillNo.Text) + "", sqlcon);
                            cmdM.CommandType = CommandType.Text;
                            OleDbDataAdapter daItemM = new OleDbDataAdapter();
                            sqlcon.Open();
                            cmdM.CommandTimeout = 0;
                            daItemM.SelectCommand = cmdM;
                            daItemM.Fill(dtM);
                            sqlcon.Close();

                            DataSet DS = new DataSet();
                            DS.Tables.Add(dtA);
                            DS.Tables.Add(dtM);
                            DS.Tables.Add(dtD);

                            //string filename = Application.StartupPath.Substring(0, Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf("\\")).LastIndexOf("\\")) + @"\CR\repBILL.rpt";
                            //string filename = "D:/DB/CR/repBILL.rpt";

                            string filename = "";
                            if (DateTime.Parse(dtM.Rows[0]["BillDate"].ToString()) >= dtdFrom && DateTime.Parse(dtM.Rows[0]["BillDate"].ToString()) <= dtdTo)
                            {
                                filename = ConnectionCR + "repBILLCancelDiscount.rpt";
                            }
                            else
                            {
                                filename = ConnectionCR + "repBILLCancel.rpt";
                            }

                            //string filename = ConnectionCR + "repBILLCancel.rpt";
                            rptDoc.Load(filename);
                            rptDoc.SetDataSource(DS);
                            crvBill.ReportSource = rptDoc;
                        }
                        else
                        {
                            MessageBox.Show("Bill No does not exists:");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please enter Bill No:");
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void txtBillNo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(txtBillNo.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter only numbers.");
                    txtBillNo.Text = txtBillNo.Text.Remove(txtBillNo.Text.Length - 1);
                }

            }
            catch
            {

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbBillNo.Text != "")
                {
                    DialogResult dialogResult = MessageBox.Show("Do you want to cancel the Bill", "Bill Cancellation", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        using (OleDbConnection sqlcon = new OleDbConnection(connectionString))
                        {
                            DataTable dtExist = new DataTable();
                            OleDbCommand cmdExist = new OleDbCommand("Update T_BILL_Master set Cancellation=1 where BillID =" + Int32.Parse(cbBillNo.Text) + "", sqlcon);
                            sqlcon.Open();
                            cmdExist.CommandTimeout = 0;
                            cmdExist.ExecuteNonQuery();
                            sqlcon.Close();
                            MessageBox.Show("Bill cancelled successfully.");
                        }
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        MessageBox.Show("No");
                    }
                }
                else
                {
                    MessageBox.Show("Bill No does not exists:");
                }
            }
            catch (Exception Ex)
            {

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                frmInvoice frmID = new frmInvoice();
                frmID.ShowDialog();
                this.Hide();
            }
            catch
            {

            }
        }

        private void fillBill()
        {
            try
            {
                using (OleDbConnection sqlcon = new OleDbConnection(connectionString))
                {
                    DataTable dtItem = new DataTable();
                    OleDbCommand cmd = new OleDbCommand("QueryBill", sqlcon);
                    cmd.CommandType = CommandType.StoredProcedure;
                    OleDbDataAdapter daItem = new OleDbDataAdapter();
                    sqlcon.Open();
                    cmd.CommandTimeout = 0;
                    daItem.SelectCommand = cmd;
                    //cmd.Parameters.AddWithValue("@FROMDATE", FromDate);
                    //cmd.Parameters.AddWithValue("@TODATE", ToDate);
                    daItem.Fill(dtItem);
                    this.cbBillNo.DataSource = dtItem;
                    this.cbBillNo.DisplayMember = "BillID";
                    this.cbBillNo.ValueMember = "BillID";
                    sqlcon.Close();

                    /////////////////////////////////////////////////////////////////////////////////////////////
                    btnBill_Click(btnBill, new EventArgs());
                }
            }
            catch (Exception Ex)
            {

            }

        }

        private void frmBill_Load(object sender, EventArgs e)
        {
            try
            {
                fillBill();
            }
            catch (Exception Ex)
            {

            }
        }
    }
}
