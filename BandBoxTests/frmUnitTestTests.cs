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
    public class frmUnitTestTests
    {
        [TestMethod()]
        public void AddTest()
        {
            //Arrange  
            frmUnitTest objtest = new frmUnitTest();
            String fno = "20";
            String sno = "10";
            String expected = "30";
            String actual;
            //Act  
            try
            {
                objtest.Add(fno, sno);
            }
            catch (ArgumentNullException e)
            {
                // Assert
                StringAssert.Contains(e.Message, "AMOUNT CANNOT BE NULL");
            }
        }

        [TestMethod()]
        public void SubTest()
        {
            //Arrange  
            frmUnitTest objtest = new frmUnitTest();
            String fno = "20";
            String sno = "10";
            String expected = "10";
            String actual;
            //Act  
            try
            {
                objtest.Sub(fno, sno);
            }
            catch (ArgumentNullException e)
            {
                // Assert
                StringAssert.Contains(e.Message, "AMOUNT CANNOT BE NULL");
            }
        }

        [TestMethod()]
        public void MulTest()
        {
            //Arrange  
            frmUnitTest objtest = new frmUnitTest();
            String fno = "20";
            String sno = "10";
            String expected = "200";
            String actual;
            //Act  
            try
            {
                objtest.Mul(fno, sno);
            }
            catch (ArgumentNullException e)
            {
                // Assert
                StringAssert.Contains(e.Message, "AMOUNT CANNOT BE NULL");
            }
        }

        [TestMethod()]
        public void DivTest()
        {
            //Arrange  
            frmUnitTest objtest = new frmUnitTest();
            String fno = "20";
            String sno = "10";
            String expected = "200";
            String actual;

            //Act 
            try
            {
                objtest.Div(fno, sno);
            }
            catch (ArgumentNullException e)
            {
                // Assert
                StringAssert.Contains(e.Message, "AMOUNT CANNOT BE NULL");
            }
            catch (DivideByZeroException e)
            {
                // Assert
                StringAssert.Contains(e.Message, "CANNOT BE DIVIDED BY ZERO");
            }
        }
    }
}