using System;
using System.Collections.Generic;
using System.Text;

namespace HarryPotterApp.Models
{
    public class ApiResponse
    {
        public bool Successful => ErrorMessage == null;
        public string ErrorMessage { get; set; }
        public string Response { get; set; }

    }
}
