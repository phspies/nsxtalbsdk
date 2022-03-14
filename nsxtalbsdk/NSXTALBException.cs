using RestSharp;
using System;
using System.Collections.Generic;

namespace nsxtalbsdk
{
    public partial class NSXTALBException : Exception
    {
        public int StatusCode { get; private set; }

        public string Response { get; private set; }

        public IList<Parameter> Headers { get; private set; }

        public NSXTALBException(string message, int statusCode, string response, IList<Parameter> headers, Exception innerException = null)
            : base(message + "\n\nStatus: " + statusCode + "\nResponse: \n" + response.Substring(0, response.Length >= 512 ? 512 : response.Length), innerException)
        {
            StatusCode = statusCode;
            Response = response;
            Headers = headers;
        }

        public override string ToString()
        {
            return string.Format("HTTP Response: \n\n{0}\n\n{1}", Response, base.ToString());
        }
    }
}
