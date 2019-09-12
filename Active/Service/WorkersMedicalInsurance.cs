using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BenDing.Service
{/// <summary>
 /// 
 /// </summary>
    public static class WorkersMedicalInsurance
    {
        #region 职工医保 

        /// <summary>
        /// 获取个人基本资料
        /// </summary>
        /// <param name="pi_sfbz">个人IC卡号或身份证号或个人编号</param>
        /// <param name="pi_crbz">1为公民身份号码 2为医保卡号 3为个人编号</param>
        /// <param name="pi_xzqh">所属行政区</param>
        /// <param name="po_grshbzh">个人社会保障号</param>
        /// <param name="po_xm">姓名</param>
        /// <param name="po_xb">性别</param>
        /// <param name="po_csny">出生年月(yyyymmdd)</param>
        /// <param name="po_zglb">职工类别分三位,前两位标示职工类别(见附表)第三位标示公务员类别(0非公务员,1公务员,2交费公务员,3公务员B)</param>
        /// <param name="po_lxdz">联系地址</param>
        /// <param name="po_lxdh">联系电话</param>
        /// <param name="po_sfzh">身份证号</param>
        /// <param name="po_sznl">实足年龄</param>
        /// <param name="po_dwmc">单位名称</param>
        /// <param name="Po_cbzt">参保状态</param>
        /// <param name="po_grzhye">个人帐户余额</param>
        /// <param name="po_ybtszt">医保住院报销特殊状态  1正常报销，2限制报销，3不能报销</param>
        /// <param name="po_ybbxztsm">医保报销状态说明</param>
        /// <param name="Po_fhz">过程返回值(为1时正常，否则不正常)</param>
        /// <param name="Po_msg">系统错误信息</param>
        [DllImport("yyjk.dll", EntryPoint = "hqgrjbzl")]
        public static extern int ChangeNumber(string pi_sfbz, string pi_crbz, string pi_xzqh,
         out string po_grshbzh, out string po_xm, out string po_xb, out string po_csny,
         out string po_zglb, out string po_lxdz, out string po_lxdh, out string po_sfzh,
         out string po_sznl, out string po_dwmc, out string Po_cbzt, out string po_grzhye,
         out string po_ybtszt, out string po_ybbxztsm, out string Po_fhz, out string Po_msg
        );
        /// <summary>
        ///2.获取个人基本资料（工伤医疗）
        /// </summary>
        /// <param name="pi_sfbz">个人IC卡号或身份证号或个人编号</param>
        /// <param name="pi_crbz">1为公民身份号码 2为医保卡号 3为个人编号</param>
        /// <param name="pi_xzqh">所属行政区</param>
        /// <param name="po_grshbzh">个人社会保障号</param>
        /// <param name="po_xm">姓名</param>
        /// <param name="po_xb">性别</param>
        /// <param name="po_csny">出生年月(yyyymmdd)</param>
        /// <param name="po_zglb">职工类别分三位,前两位标示职工类别(见附表)第三位标示公务员类别(0非公务员,1公务员,2交费公务员,3公务员B)</param>
        /// <param name="po_lxdz">联系地址</param>
        /// <param name="po_lxdh">联系电话</param>
        /// <param name="po_sfzh">身份证号</param>
        /// <param name="po_sznl">实足年龄</param>
        /// <param name="po_dwmc">单位名称</param>
        /// <param name="po_cbzt">参保状态</param>
        /// <param name="po_ybtszt">医保住院报销特殊状态  1正常报销，2限制报销，3不能报销</param>
        /// <param name="po_ybbxztsm">医保报销状态说明</param>
        /// <param name="po_fhz">过程返回值(为1时正常，否则不正常)</param>
        /// <param name="po_msg">系统错误信息</param>
        [DllImport("yyjk.dll", EntryPoint = "hqgrjbzl_gs")]
        public static extern int hqgrjbzl_gs(string pi_sfbz, string pi_crbz, string pi_xzqh, out string po_grshbzh, out string po_xm,
            out string po_xb, out string po_csny, out string po_zglb,
            out string po_lxdz, out string po_lxdh, out string po_sfzh, out string po_sznl, out string po_dwmc,
            out string po_cbzt, out string po_ybtszt, out string po_ybbxztsm, out string po_fhz, out string po_msg
         );
        /// <summary>
        /// 住院登记
        /// </summary>
        /// <param name="pi_sfbz">个人IC卡号或身份证号</param>
        /// <param name="pi_crbz">为’1’表示卡号,’2’身份证号,3为个人编号</param>
        /// <param name="pi_xzqh">行政区划</param>
        /// <param name="pi_yybh">医院编号</param>
        /// <param name="pi_yllb">医疗类别(普通住院 21 ；工伤住院41 )</param>
        /// <param name="pi_ryrq">入院日期</param>
        /// <param name="pi_icd10">入院主要诊断疾病ICD-10编码</param>
        /// <param name="pi_icd10_2">入院诊断疾病ICD-10编码</param>
        /// <param name="pi_icd10_3">入院诊断疾病ICD-10编码</param>
        /// <param name="pi_ryzd">入院诊断</param>
        /// <param name="pi_jbr">经办人</param>
        /// <param name="po_zyh">社保住院号</param>
        /// <param name="po_spbh">审批编号</param>
        /// <param name="po_bnyzycs">本年已住院次数</param>
        /// <param name="po_bntcyzfje">本年统筹已支付金额</param>
        /// <param name="po_bntckzfje">本年统筹可支付金额</param>
        /// <param name="po_fhz">过程返回值(为1时正常，否则不正常)</param>
        /// <param name="po_msg">系统错误信息</param>
        /// <param name="pi_zybq">住院病区</param>
        /// <param name="pi_cwh">床位号</param>
        /// <param name="pi_yyzyh">住院号</param>
        /// <returns></returns>
        [DllImport("yyjk.dll", EntryPoint = "zydj")]
        public static extern int zydj(string pi_sfbz, string pi_crbz, string pi_xzqh, string pi_yybh, 
            string pi_yllb, string pi_ryrq, string pi_icd10, string pi_icd10_2, string pi_icd10_3, string pi_ryzd,
            string pi_zybq, string pi_cwh, string pi_yyzyh ,string pi_jbr,
            out string po_zyh, out string po_spbh, out string po_bnyzycs, out string po_bntcyzfje, out string po_bntckzfje,
            out string po_fhz, out string po_msg);
        /// <summary>
        /// 4.住院资料全部修改
        /// </summary>
        /// <param name="pi_fwjgh">医疗机构号</param>
        /// <param name="pi_zyh">住院号</param>
        /// <param name="pi_xzqh">行政区划</param>
        /// <param name="pi_ryrq">入院日期</param>
        /// <param name="pi_icd10">入院主要诊断疾病ICD-10编码</param>
        /// <param name="pi_icd10_2">入院诊断疾病ICD-10编码</param>
        /// <param name="pi_icd10_3">入院诊断疾病ICD-10编码</param>
        /// <param name="pi_ryzd">入院诊断</param>
        /// <param name="pi_zybq">住院病区</param>
        /// <param name="pi_cwh">床位号</param>
        /// <param name="pi_yyzyh">医院住院号</param>
        /// <param name="po_fhz">过程返回值(为1时正常，否则不正常)</param>
        /// <param name="po_msg">系统错误信息</param>
        /// <returns></returns>
        [DllImport("yyjk.dll", EntryPoint = "zyzlxgall")]
        public static extern int zyzlxgall(string pi_fwjgh, string  pi_zyh, string pi_xzqh, string pi_ryrq,
            string pi_icd10, string pi_icd10_2, string pi_icd10_3, string pi_ryzd, string pi_zybq, string pi_cwh,string pi_yyzyh ,
            out string po_fhz,out string po_msg);
        /// <summary>
        /// 住院费用计算
        /// </summary>
        /// <param name="pi_fwjgh">医疗机构号</param>
        /// <param name="pi_zyh">住院号</param>
        /// <param name="pi_xzqh">行政区划</param>
        /// <param name="pi_cszl">是否计住院次数</param>
        /// <param name="pi_czy">操作员</param>
        /// <param name="pi_cyrq">出院日期</param>
        /// <param name="pi_cyqk">出院情况（1康复，2转院，3死亡，4其他）</param>
        /// <param name="pi_icd10">出院主要诊断疾病ICD-10编码</param>
        /// <param name="pi_icd10_2">出院诊断疾病ICD-10编码</param>
        /// <param name="pi_icd10_3">出院诊断疾病ICD-10编码</param>
        /// <param name="pi_cyzd">出院诊断（确诊疾病）</param>
        /// <param name="PO_FYZE">发生费用金额</param>
        /// <param name="PO_TCZF">基本统筹支付</param>
        /// <param name="PO_BCZF">补充医疗保险支付金额</param>
        /// <param name="PO_ZXJJ">专项基金支付金额</param>
        /// <param name="PO_GWYBT">公务员补贴</param>
        /// <param name="PO_GWYBZ">公务员补助</param>
        /// <param name="PO_QTZF">其它支付金额</param>
        /// <param name="PO_ZHZF">帐户支付</param>
        /// <param name="PO_XJZF">现金支付</param>
        /// <param name="PO_qfje">起付金额</param>
        /// <param name="PO_DJH">单据号</param>
        /// <param name="po_bz">备注</param>
        /// <param name="po_fhz">过程返回值(为1时正常，否则不正常)</param>
        /// <param name="po_msg">系统错误信息</param>
        /// <returns></returns>
        [DllImport("yyjk.dll", EntryPoint = "fyjs_new")]
        public static extern int fyjs_new(string pi_fwjgh, string pi_zyh, string pi_xzqh, string pi_cszl, string pi_czy, string pi_cyrq,
            string pi_cyqk, string pi_icd10, string pi_icd10_2, string pi_icd10_3, string pi_cyzd,
            out string PO_FYZE,out string PO_TCZF, out string PO_BCZF, out string PO_ZXJJ,
            out string PO_GWYBT,out string PO_GWYBZ,out string PO_QTZF,out string PO_ZHZF,
            out string PO_XJZF,out string PO_qfje, out string PO_DJH ,out string po_bz,
            out string po_fhz,out string po_msg);
        /// <summary>
        /// 住院费用预计算
        /// </summary>
        /// <param name="pi_fwjgh">医疗机构号</param>
        /// <param name="pi_zyh">住院号</param>
        /// <param name="pi_xzqh">行政区划</param>
        /// <param name="pi_cszl">是否计住院次数</param>
        /// <param name="pi_czy">操作员</param>
        /// <param name="pi_cyrq">出院日期</param>
        /// <param name="PO_FYZE">发生费用金额</param>
        /// <param name="PO_TCZF">基本统筹支付</param>
        /// <param name="po_bczf">补充医疗保险支付金额</param>
        /// <param name="po_zxjj">专项基金支付金额</param>
        /// <param name="PO_GWYBT">公务员补贴</param>
        /// <param name="PO_GWYBZ">公务员补助</param>
        /// <param name="Po_qtzf">其它支付金额</param>
        /// <param name="PO_ZHZF">帐户支付</param>
        /// <param name="PO_XJZF">现金支付</param>
        /// <param name="PO_qfje">起付金额</param>
        /// <param name="PO_DJH">单据号</param>
        /// <param name="Po_bz">备注</param>
        /// <param name="po_fhz"></param>
        /// <param name="po_msg"></param>
        [DllImport("yyjk.dll", EntryPoint = "fyyjs_new")]
        public static extern int fyyjs_new(string pi_fwjgh, string pi_zyh, string pi_xzqh, string pi_cszl, string pi_czy,string pi_cyrq,
            out string PO_FYZE, out string PO_TCZF,
            out string po_bczf, out string po_zxjj,
            out string PO_GWYBT, out string PO_GWYBZ,
            out string Po_qtzf, out string PO_ZHZF,
            out string PO_XJZF, out string PO_qfje,
            out string PO_DJH, out string Po_bz,
            out string po_fhz, out string po_msg);
        /// <summary>
        /// 结算取消
        /// </summary>
        /// <param name="pi_xzqh">行政区划</param>
        /// <param name="pi_fwjgh">医疗机构号</param>
        /// <param name="pi_zyh">住院号</param>
        /// <param name="pi_djh">登记号</param>
        /// <param name="pi_qxcd">取消程度(1取消结算2删除资料)</param>
        /// <param name="pi_jbr">经办人</param>
        /// <param name="po_knbz">跨年标志</param>
        /// <param name="po_fhz">过程返回值(为1时正常，否则不正常)</param>
        /// <param name="po_msg">系统错误信息</param>
        /// <returns></returns>
        [DllImport("yyjk.dll", EntryPoint = "qxjs")]
        public static extern int qxjs(string pi_xzqh, string pi_fwjgh, string pi_zyh, string pi_djh, string pi_qxcd, string pi_jbr,
            out string po_knbz,out string po_fhz,out string po_msg);
        /// <summary>
        /// 查询费用结算结果
        /// </summary>
        /// <param name="pi_fwjgh">医疗机构号</param>
        /// <param name="PI_ZYH">住院号</param>
        /// <param name="pi_xzqh">行政区划</param>
        /// <param name="PO_TCZF">基本医疗统筹支付</param>
        /// <param name="po_bczf">补充医疗保险支付金额</param>
        /// <param name="po_zxjj">专项基金支付金额</param>
        /// <param name="pO_GWYBT">公务员补贴</param>
        /// <param name="PO_GWYBZ">公务员补贴</param>
        /// <param name="po_qtzf">其它支付金额</param>
        /// <param name="PO_ZHZF">帐户支付</param>
        /// <param name="PO_XJZF">现金支付</param>
        /// <param name="PO_QFJE">起付金额</param>
        /// <param name="PO_JSRQ">结算日期</param>
        /// <param name="po_bz">备注</param>
        /// <param name="PO_FHZ">过程返回值(为1时正常，否则不正常)</param>
        /// <param name="PO_MSG">系统错误信息</param>
        /// <returns></returns>
        [DllImport("yyjk.dll", EntryPoint = "hqfyjsjg_new")]
        public static extern int hqfyjsjg_new(string pi_fwjgh, string PI_ZYH, string pi_xzqh,
            out string PO_TCZF,    out string po_bczf, out string po_zxjj,    out string pO_GWYBT,
            out string PO_GWYBZ,   out string po_qtzf, out string PO_ZHZF,    out string PO_XJZF,
            out string PO_QFJE,    out string PO_JSRQ,out string po_bz,   out string PO_FHZ,
            out string PO_MSG);
        /// <summary>
        /// 处方项目传输
        /// </summary>
        /// <param name="pi_jzjlh">在医保上的住院号</param>
        /// <param name="pi_xzqh">行政区划</param>
        /// <param name="po_pch">批次号(本次上传)</param>
        /// <param name="po_fhz">过程返回值(为1时正常，否则不正常)</param>
        /// <param name="po_msg">系统错误信息</param>
        /// <returns></returns>
        [DllImport("yyjk.dll", EntryPoint = "xmlcfmxcs")]
        public static extern int xmlcfmxcs(string pi_jzjlh, string  pi_xzqh,
             out string po_pch,out string po_fhz,out string po_msg);
        /// <summary>
        /// 费用批次未注册确认信息查询
        /// </summary>
        /// <param name="pi_jzjlh">在医保上的住院号</param>
        /// <param name="pi_xzqh">行政区划</param>
        /// <param name="po_pch">批次号(查询结果) 以逗号为分隔符分隔的未确认批次号字符串</param>
        /// <param name="po_fhz">过程返回值(为1时正常，否则不正常)</param>
        /// <param name="po_msg">系统错误信息</param>
        /// <returns></returns>
        [DllImport("yyjk.dll", EntryPoint = "fypcxxcx")]
        public static extern int fypcxxcx(string pi_jzjlh, string pi_xzqh,
            out string po_pch, out string po_fhz, out string po_msg);
        /// <summary>
        /// 费用批次未注册确认信息查询
        /// </summary>
        /// <param name="Pi_jzjlh">在医保上的住院号</param>
        /// <param name="Pi_xzqh">行政区划</param>
        /// <param name="Pi_pch">批次号(查询结果) </param>
        /// <param name="Pi_qrlx">确认类型 1确认，2取消</param>
        /// <param name="Pi_jbr">经办人</param>
        /// <param name="po_fhz">过程返回值(为1时正常，否则不正常)</param>
        /// <param name="po_msg">系统错误信息</param>
        /// <returns></returns>
        [DllImport("yyjk.dll", EntryPoint = "fypcxxqr")]
        public static extern int fypcxxqr(string Pi_jzjlh, string Pi_xzqh, string Pi_pch, string Pi_qrlx, string Pi_jbr,
            out string po_fhz, out string po_msg);
        /// <summary>
        /// 已经上传处方明细删除
        /// </summary>
        /// <param name="pi_jzjlh">在医保上的就诊记录号</param>
        /// <param name="pi_pch">批次号</param>
        /// <param name="pi_xzqh">行政区划</param>
        /// <param name="po_fhz">过程返回值(为1时正常，否则不正常)</param>
        /// <param name="po_msg">系统错误信息</param>
        /// <returns></returns>
        [DllImport("yyjk.dll", EntryPoint = "cfmxplsc")]
        public static extern int cfmxplsc(string pi_jzjlh, string  pi_pch, string  pi_xzqh,
            out string po_fhz,out string po_msg) ;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pi_jzjlh">在医保上的就诊记录号</param>
        /// <param name="pi_xzqh">行政区划</param>
        /// <param name="po_fhz"></param>
        /// <param name="po_msg"></param>
        /// <returns></returns>
        [DllImport("yyjk.dll", EntryPoint = "xmlycscfmxcx")]
        public static extern int xmlycscfmxcx(string pi_jzjlh, string pi_xzqh,
        out string po_fhz,out string po_msg);
        /// <summary>
        /// 14.项目字典下载
        /// </summary>
        /// <param name="pi_xmlb">项目类别： 药品：yp检查治疗项目：jc下载全部：all</param>
        /// <param name="po_fhz"></param>
        /// <param name="po_msg"></param>
        /// <returns></returns>
        [DllImport("yyjk.dll", EntryPoint = "xmzdxz")]
        public static extern int xmzdxz(string pi_xmlb,
            out string po_fhz,out string po_msg) ;
        /// <summary>
        /// 18.读持卡人基本信息
        /// </summary>
        /// <param name="pi_ReaderPort">读卡器所连接的端口</param>
        /// <param name="pi_CardPasswd">卡密码</param>
        /// <param name="po_dwmc">单位名称</param>
        /// <param name="po_Cardid">IC卡卡号</param>
        /// <param name="po_Sfzhm">公民身份证号码</param>
        /// <param name="po_Name">姓名</param>
        /// <param name="po_Sex">性别</param>
        /// <param name="po_Folk">民族</param>
        /// <param name="po_BirthPlace">出生地</param>
        /// <param name="po_BirthDate">出生日期</param>
        /// <param name="po_Acntbalance">个人帐户余额</param>
        /// <param name="po_fhz"></param>
        /// <param name="po_msg"></param>
        /// <returns></returns>
        [DllImport("yyjk.dll", EntryPoint = "ReadCardInfo")]
        public static extern int ReadCardInfo(
            int pi_ReaderPort, string pi_CardPasswd,
            out string po_dwmc,out string po_Cardid,out string po_Sfzhm,
            out string po_Name,out string po_Sex,out string po_Folk,
            out string po_BirthPlace,out string po_BirthDate,out string po_Acntbalance,
            out string po_fhz,out string po_msg
            );
        /// <summary>
        /// 19.IC卡：IC卡划卡操作
        /// </summary>
        /// <param name="pi_ReaderPort">读卡器所连接的端口</param>
        /// <param name="pi_CardPasswd">卡密码</param>
        /// <param name="pi_fyze">消费费用总额</param>
        /// <param name="pi_hklb">划卡类别@1门诊划卡2住院划卡</param>
        /// <param name="Pi_yybh">医院编号</param>
        /// <param name="pi_jbr">经办人</param>
        /// <param name="Po_hklsh">帐户支付金额</param>
        /// <param name="po_zhzfje">自费支付金额</param>
        /// <param name="po_fhz"></param>
        /// <param name="po_msg"></param>
        /// <returns></returns>
        [DllImport("yyjk.dll", EntryPoint = "hkgl")]
        public static extern int hkgl(
            int pi_ReaderPort, string pi_CardPasswd,string pi_fyze,
            string pi_hklb,string Pi_yybh,string pi_jbr,
            out string Po_hklsh,out string po_zhzfje,out string po_zfzfje,
            out string po_fhz,out string po_msg
            );
        /// <summary>
        /// 已医疗机构结算信息查询
        /// </summary>
        /// <param name="pi_jsksrq">结算开始日期（YYYYMMDD）</param>
        /// <param name="pi_jszzrq">结算终止日期（YYYYMMDD）</param>
        /// <param name="pi_xzqh">行政区划</param>
        /// <param name="po_fhz"></param>
        /// <param name="po_msg"></param>
        /// <returns></returns>
        [DllImport("yyjk.dll", EntryPoint = "xmljsxxcx")]
        public static extern int xmljsxxcx(string pi_jsksrq, string  pi_jszzrq, string  pi_xzqh,
            out string po_fhz, out string po_msg) ;
        #endregion
        #region 居民医保 
        /// <summary>
        /// 链接服务器
        /// </summary>
        /// <param name="aLoginID"></param>
        /// <param name="aUserPwd"></param>
        /// <returns></returns>

        [DllImport("yyjk.dll", EntryPoint = "ConnectAppServer_cxjb")]
        public static extern int ConnectAppServer_cxjb(string aLoginID, string aUserPwd);

        /// <summary>
        /// 断开服务器
        /// </summary>
        /// <returns></returns>
        [DllImport("yyjk.dll", EntryPoint = "DisConnectAppServer_cxjb")]
        public static extern int DisConnectAppServer_cxjb();
        /// <summary>
        /// 业务功能调用
        /// </summary>
        /// <param name="aFuncCode"></param>
        /// <returns></returns>
        [DllImport("yyjk.dll", EntryPoint = "CallService_cxjb")]
        public static extern int CallService_cxjb(string aFuncCode);
        /// <summary>
        /// 读取社保卡
        /// </summary>
        /// <param name="aReaderPort"></param>
        /// <param name="aCardPasswd"></param>
        /// <returns></returns>
        [DllImport("yyjk.dll", EntryPoint = "ReadCardInfo_cxjb")]
        public static extern int ReadCardInfo_cxjb(string aReaderPort, string aCardPasswd);
        #endregion

    }
}
