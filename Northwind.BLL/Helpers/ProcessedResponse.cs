using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.BLL.Helpers
{
    public class ProcessedResponse
    {
        public string Message { get; set; }
        public bool IsSuccessful { get; set; }
        public object Object { get; set; }  
    }
}
