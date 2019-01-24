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
    public partial class frmDailyReport : Form
    {
        String connectionString = ConfigurationManager.ConnectionStrings["ConnBandBox"].ConnectionString;
        String ConnectionCR = ConfigurationManager.AppSettings["ConnRep"].ToString();
        public frmDailyReport()
        {
            InitializeComponent();
        }

        private void btnBill_Click(object sender, EventArgs e)
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

                    OleDbCommand cmdA = new OleDbCommand("Select Address,Mobile from Master_Address", sqlcon);
                    cmdA.CommandType = CommandType.Text;
                    OleDbDataAdapter daItemA = new OleDbDataAdapter();
                    sqlcon.Open();
                    cmdA.CommandTimeout = 0;
                    daItemA.SelectCommand = cmdA;
                    daItemA.Fill(dtA);
                    sqlcon.Close();

                    OleDbCommand cmdM = new OleDbCommand("Select BillID,CustomerName,Address,MobileNo,PhoneNo,BillDate,CGST,SGST,GrandTotal,GSTIN,HSN,EntryDate,SubTotal,TQTY,DUEDATE,BILLTYPE,IIf(Cancellation =Yes,'Cancelled') as Cancel from T_Bill_Master where CDate(BillDate)='" + DateTime.Parse(dtpInvoiceDate.Value.ToString()).ToShortDateString() + "'", sqlcon);
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

                    //string filename = Application.StartupPath.Substring(0, Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf("\\")).LastIndexOf("\\")) + @"\CR\repBILL.rpt";
                    //string filename = "D:/DB/CR/repBILL.rpt";
                    string filename = ConnectionCR + "repDailyReport.rpt";
                    rptDoc.Load(filename);
                    rptDoc.SetDataSource(DS);
                    crvDailyReport.ReportSource = rptDoc;

                }
            }
            catch(Exception ex)
            {

            }

        }
    }
}
