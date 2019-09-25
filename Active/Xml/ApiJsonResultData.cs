using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenDingActive.Xml
{
  
    public class ApiJsonResultData
    {
      

        public bool Success { get; set; }

        /// <summary>
        /// Gets or sets the messages.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the model.
        /// </summary>

        public object Data { get; set; }

        public string Code { get; set; }

      
    }

}
