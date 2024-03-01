using BlockLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject2
{
    public class BlogTests
    {


        // Arrange
        [Test]
        public void BlogInfo_ValidProperties_PassesValidation()
        {
            var blogInfo = new BlogInfo
            {
                BlogId = 25,
                Title = "Docker",
                Subject = "MVC Connect to Docker",
                BlogUrl = "https://github.com/Madhuri70/Cap.git/Deploy-an-ASP.NET-WebForms-Application-on-Azure.git",
                EmpEmailId = "madhuri@gmail.com",

            };
        }




    }
}
    
