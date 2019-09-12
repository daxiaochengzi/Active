using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenDingActive.Model.Params
{/// <summary>
 /// 入院登记
 /// </summary>
    public class HospitalizationRegisterParam
    {
      
            // <summary>
            /// 身份标识
            /// </summary>
            public string PI_SFBZ { get; set; }
            /// <summary>
            /// 传入标志
            /// </summary>
            public string PI_CRBZ { get; set; }
            /// <summary>
            /// 医疗类别
            /// </summary>
            public string PI_YLLB { get; set; }
            /// <summary>
            /// 胎儿数
            /// </summary>
            public string PI_PI_TES { get; set; }
           
            /// <summary>
            /// 户口性质
            /// </summary>
            public string PI_PI_HKXZ { get; set; }
            /// <summary>
            /// 入院日期
            /// </summary>
            public string PPI_RYRQ { get; set; }
            /// <summary>
            /// 入院主要诊断疾病ICD-10编码
            /// </summary>
            public string PI_ICD10 { get; set; }
            /// <summary>
            /// 入院诊断疾病ICD-10编码
            /// </summary>
            public string PI_ICD10_2 { get; set; }
            /// <summary>
            /// 入院诊断疾病ICD-10编码
            /// </summary>
            public string PI_ICD10_3 { get; set; }
            /// <summary>
            /// 入院诊断疾病名称
            /// </summary>
            public string PI_RYZD { get; set; }
            /// <summary>
            /// 住院科室
            /// </summary>
            public string PI_ZYBQ { get; set; }
            /// <summary>
            /// 床位号
            /// </summary>
            public string PI_CWH { get; set; }
            /// <summary>
            /// 医院住院号
            /// </summary>
            public string PI_YYZYH { get; set; }
            /// <summary>
            /// 经办人
            /// </summary>
            public string PI_JBR { get; set; }
            /// <summary>
            /// 胎儿数
            /// </summary>
            public string PI_TES { get; set; }
            /// <summary>
            /// 户口性质如果为生育入院（即就诊类别为71，72，41）的，需录入产妇的户口性质。10:城镇户口20:农业户口
            /// </summary>
            public string PI_HKXZ { get; set; }
            /// <summary>
            /// 入院日期  (格式为YYYYMMDD)
            /// </summary>
            public string PI_RYRQ { get; set; }
    }
}
