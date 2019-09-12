using BenDingActive.Model.Dto;
using BenDingActive.Model.Params;
using BenDingActive.Xml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenDingActive.Service
{
   public class SingleResidentMedicalInsurance
    {
        public UserInfoDto SingleGetUserInfo(UserInfoParam param)
        {
            UserInfoDto resultData = new UserInfoDto();
            var Data = XmlHelp.DeSerializerModel(new IdentificationSpecialDownloadListDto());

            //var xmlStr = XmlHelp.SaveXml(param);
            //if (xmlStr)
            //{
            //    int result = WorkersMedicalInsurance.CallService_cxjb("CXJB001");
            //    if (result == 1)
            //    {
            //        resultData = XmlHelp.DeSerializerModel(new UserInfoDto());
            //     
            //    }


            //}
            return resultData;

        }
        /// <summary>
        /// 入院登记
        /// </summary>
        /// <returns></returns>
        public string SingleHospitalizationRegister()
        {
            return "";
        }
        /// <summary>
        /// 住院资料修改
        /// </summary>
        /// <returns></returns>
        public string SingleHospitalizationModify()
        {
            return "";
        }
        /// <summary>
        /// 取消入院
        /// </summary>
        /// <returns></returns>
        public string SingleHospitalizationCancel()
        {
            return "";
        }
        
        /// <summary>
        /// 处方上传
        /// </summary>
        /// <returns></returns>
        public string SinglePrescriptionUpload()
        {
            return "";
        }
        /// <summary>
        /// 处方删除
        /// </summary>
        public void SinglePrescriptionDelete()
        {
        }
        /// <summary>
        /// 处方明细查询
        /// </summary>
        public void SinglePrescriptionDetailQuery()
        {
        }
        /// <summary>
        /// 单病种出院结算
        /// </summary>
        public void SingleLeaveHospitalSettlement()
        {
        }
        /// <summary>
        /// 单病种出院结算取消
        /// </summary>
        public void SingleLeaveHospitalSettlementCancel()
        {
        }
        /// <summary>
        /// 单病种预结算
        /// </summary>
        public void SinglePreSettlement()
        {
        }

        /// <summary>
        /// 单病种预结算查询
        /// </summary>
        public void SinglePreSettlementQuery()
        {
        }
        /// <summary>
        ///单病种 精神病住院月结汇总查询
        /// </summary>
        public void SinglePreMonthSettlement()
        {
        }
        /// <summary>
        ///单病种 精神病月结汇总取消
        /// </summary>
        public void SinglePreMonthSettlementCancel()
        {
        }
        /// <summary>
        ///2.2.24.门诊诊查费录入及结算
        /// </summary>
        public void OutpatientConsultationFeeSettlement()
        {
        }
        /// <summary>
        ///2.2.25.门诊诊查费取消(挂号取消)
        /// </summary>
        public void OutpatientConsultationFeeCancel()
        {
        }
        /// <summary>
        ///2.2.26.门诊诊查费查询
        /// </summary>
        public void OutpatientConsultationFeeQuery()
        {
        }
        
    }
}
