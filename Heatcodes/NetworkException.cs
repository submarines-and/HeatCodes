using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeatCodes
{
    class NetworkException : Exception
    {
        private string errorMessage;

        public string ErrorMessage
        {
            get { return errorMessage; }
            set { errorMessage = value; }
        }

        public NetworkException(string message)
        {
            errorMessage = message;

        }
    }
}
