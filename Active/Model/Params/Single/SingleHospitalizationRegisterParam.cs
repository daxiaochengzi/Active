using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenDingActive.Model.Params.Single
{/// <summary>
 /// 单病种 精神病住院登记
 /// </summary>
    public class SingleHospitalizationRegisterParam
    {/// <summary>
        /// 身份标志  
        /// </summary>
        public string PI_SFBZ { get; set; }
        /// <summary>
        /// 传入标志  
        /// </summary>
        public string PI_CRBZ { get; set; }
        /// <summary>
        /// 就诊类别  
        /// </summary>
        public string PI_AKA130 { get; set; }
        /// <summary>
        /// 诊断日期  
        /// </summary>
        public string PI_CKC537 { get; set; }
        /// <summary>
        /// 入院主要诊断疾病ICD-10编码  
        /// </summary>
        public string PI_AKC193 { get; set; }
        /// <summary>
        /// 入院诊断疾病ICD-10编码  
        /// </summary>
        public string PI_AKC194 { get; set; }
        /// <summary>
        /// 入院诊断疾病ICD-10编码  
        /// </summary>
        public string PI_AKC195 { get; set; }
        /// <summary>
        /// 入院诊断疾病名称  
        /// </summary>
        public string PI_CKC540 { get; set; }
        /// <summary>
        /// 住院科室  
        /// </summary>
        public string PI_AKF001 { get; set; }
        /// <summary>
        /// 床位号  
        /// </summary>
        public string PI_AKE020 { get; set; }
        /// <summary>
        /// 住院号  
        /// </summary>
        public string PI_AKC190 { get; set; }
        /// <summary>
        /// 经办人  
        /// </summary>
        public string PI_AAE011 { get; set; }
    }
}
