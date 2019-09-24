using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenDingActive.Model.Params.DifferentPlaces
{
   public class DifferentLeaveHospitalReturnParam
    {
        //    <baa008>参保人统筹地区编码</baa008>
        //<aaz217>就诊记录号</aaz217>
        //<aac001>个人编号</aac001>
        //<aac002>身份证号</aac002>
        //<aac003>姓名</aac003>
        //<bkc131>出院经办人</bkc131>
        /// <summary>
        /// 参保人统筹地区编码
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
        /// 身份证号
        /// </summary>
        public string aac002 { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string aac003 { get; set; }
        /// <summary>
        /// 出院经办人
        /// </summary>
        public string bkc131 { get; set; }
     

    }
}
