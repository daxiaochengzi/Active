using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenDingActive.Model.Params.DifferentPlaces
{
    public class DifferentPlacesCostPreSettlementParam
    {
        //    <baa008>参保人统筹区划代码</baa008>
        //<aaz217>就诊记录号</aaz217>
        //<aac001>个人编号</aac001>
        //<nums>费用明细条数</nums>
        //<akc264>明细总额</akc264>
        //<bkc131>结算经办人</bkc131>

        /// <summary>
        /// 参保人统筹区划代码
        /// </summary>
        public string baa008 { get; set; }
        /// <summary>
        /// 就诊记录号
        /// </summary>

        public string aaz217 { get; set; }
        /// <summary>
        /// 个人编号
        /// </summary>
        public string aac001 { get; set; }
        /// <summary>
        /// 费用明细条数
        /// </summary>
        public string nums { get; set; }
        /// <summary>
        /// 明细总额
        /// </summary>
        public string akc264 { get; set; }
        /// <summary>
        /// 结算经办人
        /// </summary>
        public string bkc131 { get; set; }
    }
}
