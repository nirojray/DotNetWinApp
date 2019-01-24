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
    public partial class frmInvoiceBill : Form
    {
        String connectionString = ConfigurationManager.ConnectionStrings["ConnBandBox"].ConnectionString;
        String ConnectionCR = ConfigurationManager.AppSettings["ConnRep"].ToString();
        DateTime dtdFrom = DateTime.Parse(ConfigurationManager.AppSettings["KeyFrom"].ToString());
        DateTime dtdTo = DateTime.Parse(ConfigurationManager.AppSettings["KeyTo"].ToString());
        string strBill1;
        DateTime strInvDate1;
        public frmInvoiceBill(string strBill,DateTime strInvDate)
        {
            InitializeComponent();
            strBill1 = strBill;
            strInvDate1 = strInvDate;
        }
        private void Bill()
        {
            try
            {
                ReportDocument rptDoc = new ReportDocument();
                using (OleDbConnection sqlcon = new OleDbConnection(connectionString))
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

                    OleDbCommand cmdD = new OleDbCommand("Select ItemId,Item,Price,Qty,ItemTotal from T_Bill_Details where BillID=" + strBill1 + "", sqlcon);
                    cmdD.CommandType = CommandType.Text;
                    OleDbDataAdapter daItemD = new OleDbDataAdapter();
                    sqlcon.Open();
                    cmdD.CommandTimeout = 0;
                    daItemD.SelectCommand = cmdD;
                    daItemD.Fill(dtD);
                    sqlcon.Close();

                    OleDbCommand cmdM = new OleDbCommand("Select BillID,CustomerName,Address,MobileNo,PhoneNo,BillDate,CGST,SGST,GrandTotal,GSTIN,HSN,EntryDate,SubTotal,TQTY,DUEDATE,BILLTYPE from T_Bill_Master where BillID=" + strBill1 + "", sqlcon);
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
                    string filename="";
                    if (strInvDate1 >= dtdFrom && strInvDate1 <= dtdTo)
                    {
                        filename = ConnectionCR + "repBILLCancelDiscount.rpt";
                    }
                    else
                    {
                        filename = ConnectionCR + "repBILLCancel.rpt";
                    }
                    rptDoc.Load(filename);
                    rptDoc.SetDataSource(DS);
                    crvInvBill.ReportSource = rptDoc;
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void frmInvoiceBill_Load(object sender, EventArgs e)
        {
            try
            {
                Bill();
            }
            catch(Exception ex)
            {

            }
        }
    }
}
