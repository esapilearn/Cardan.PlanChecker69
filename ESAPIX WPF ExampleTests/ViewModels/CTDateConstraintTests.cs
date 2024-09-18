using Microsoft.VisualStudio.TestTools.UnitTesting;
using ESAPX_StarterUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESAPIX.Constraints;

namespace ESAPX_StarterUI.ViewModels.Tests
{
    [TestClass()]
    public class CTDateConstraintTests
    {
        [TestMethod()]
        public void CT_Date_Passes_When_Less_Than_60days()
        {
            //Arrange
            var date = DateTime.Now.AddDays(-59);

            //Act
            var actual = new CTDateConstraint().ConstrainCTDate(date).ResultType;

            //Assert
            var expected = ResultType.PASSED;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CT_Date_Fails_When_Greater_Than_60days()
        {
            //Arrange
            var date = DateTime.Now.AddDays(-61);

            //Act
            var actual = new CTDateConstraint().ConstrainCTDate(date).ResultType;

            //Assert
            var expected = ResultType.ACTION_LEVEL_3;
            Assert.AreEqual(expected, actual);
        }
    }
}