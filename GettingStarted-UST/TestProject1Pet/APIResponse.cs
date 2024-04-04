using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStoreProject
{
  
        /// <summary>
        /// Contains API Response details code,messageand type
        /// </summary/   
    
    internal class APIResponse
    {
        private int code;
        private string message;
        private string type;
        public int Code { get; set; }
        public string Message { get; set; }
        public string Type { get; set; }
        public APIResponse()
        {
        }
    }

}
