using BlockLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject2
{
    [TestFixture]
    public class EmpInfoTesting
    {
        [Test]
        public void EmpInfo_ValidData_ShouldPassValidation()
        {
            // Arrange
            EmpInfo empInfo = new EmpInfo
            {
                EmailId = "madhuri@gmail.com",
                Name = "Madhuri",
                PassCode = 12345
            };

        }





    }
}

