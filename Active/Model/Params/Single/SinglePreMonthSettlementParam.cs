using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenDingActive.Model.Params.Single
{
   public class SinglePreMonthSettlementParam
    {/// <summary>
     /// 人员类别
     /// </summary>
        public string PI_CKA549 { get; set; }
        /// <summary>
        /// 汇总类别
        /// </summary>
        public string PI_CKE54 { get; set; }
        /// <summary>
        /// 汇总开始日期
        /// </summary>

        public string PI_KSRQ { get; set; }
        /// <summary>
        /// 汇总截止日期
        /// </summary>
        public string PI_JSRQ { get; set; }
    }
}
