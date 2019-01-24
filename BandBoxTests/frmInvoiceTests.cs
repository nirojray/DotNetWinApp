using Microsoft.VisualStudio.TestTools.UnitTesting;
using BandBox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BandBox.Tests
{
    [TestClass()]
    public class frmInvoiceTests
    {
        [TestMethod()]
        public void CalculationTest()
        {
            frmInvoice objinvoice = new frmInvoice();
            try
            {
                objinvoice.Calculation();
            }
            catch (NullReferenceException e)
            {
                // Assert
                StringAssert.Contains(e.Message,"Unit test fail for method Calaulation of form frmInvoice");
            }
        }
    }
}