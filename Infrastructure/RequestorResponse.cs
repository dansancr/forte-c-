using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Net;

namespace ForteSdk
{
    public class RequestorResponse
    {
        public HttpStatusCode StatusCode { get; set; }
        
        public string Message { get; set; }
        
        public string Content { get; set; }
        
    }
}
