using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject
{
    class LogInResponse
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string responseMessage { get; set; }

        public int statusCode { get; set; }

        public int id { get; set; }

        //public MyJsonSubDocumentType MySubDocument { get; set; }

        //public List<int> MyListProperty { get; set; }
    }
}