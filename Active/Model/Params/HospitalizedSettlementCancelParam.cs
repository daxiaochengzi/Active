using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenDingActive.Model.Params
{/// <summary>
/// 入院结算取消
/// </summary>
  public  class HospitalizedSettlementCancelParam
    {///<summary>
        /// 住院号
        /// </summary>
        public string PI_ZHY { get; set; }
        ///<summary>
        /// 结算单据号
        /// </summary>
        public string PI_DJH { get; set; }
        /// <summary>
        /// 取消程度
        /// </summary>
        public string PI_QXCD { get; set; }
        ///<summary>
        /// 经办人
        /// </summary>
        public string PI_JBR { get; set; }
    }
}
