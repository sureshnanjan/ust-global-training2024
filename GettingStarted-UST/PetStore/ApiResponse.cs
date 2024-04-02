using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore
{
    /// <summary>
    /// Represents an ApiResponse.
    /// </summary>
    internal class ApiResponse
    {
        private int code;
        private string? type;
        private string? message;

        /// <summary>
        /// Gets or sets the response code.
        /// </summary>
        public int Code
        {
            get { return code; }
            set { code = value; }
        }

        /// <summary>
        /// Gets or sets the response type.
        /// </summary>
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        /// <summary>
        /// Gets or sets the response message.
        /// </summary>
        public string Message
        {
            get { return message; }
            set { message = value; }
        }
    }
}
