using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore_New
{
    internal class ApiResponse
    {
        private int code;
        private string message;
        private string type;


        public int Code { get; set; }
        public string Message { get; set; }
        public string Type { get; set; }
    }
}
