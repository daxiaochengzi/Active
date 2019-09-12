using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenDingActive.Xml
{
    /// <summary>
    /// http请求返回结果
    /// </summary>
    public class ApiJsonResultData
    {
        /// </value>

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

        public string RedirectUrl { get; set; }


        public bool ReloadPage { get; set; }
    }

}
