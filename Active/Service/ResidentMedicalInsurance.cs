using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenDing.Service;
using BenDingActive.Model;
using BenDingActive.Model.Dto;
using BenDingActive.Model.Params;
using BenDingActive.Xml;
using Newtonsoft.Json;

namespace BenDingActive.Service
{/// <summary>
 /// 居民医保接口
 /// </summary>
    public class ResidentMedicalInsurance
    {
        /// <summary>
        /// 获取个人基础资料
        /// </summary>
        /// <param name="param"></param>
        /// <param name="baseParam"></param>
        public string GetUserInfo(string param, HisBaseParam baseParam)
        {
            var resultData = new ApiJsonResultData {Success = true};
            var data=new UserInfoDto();
            try
            {
               var paramIni= JsonConvert.DeserializeObject<UserInfoParam>(param);  

                var xmlStr = XmlHelp.SaveXml(paramIni);
                if (xmlStr)
                {
                    int result = WorkersMedicalInsurance.CallService_cxjb("CXJB001");
                    if (result == 1)
                    {
                        data = XmlHelp.DeSerializerModel(new UserInfoDto());
                        if (data.PO_FHZ == "1")
                        {
                            resultData.Data = JsonConvert.SerializeObject(data);
                        }
                        else
                        {
                           throw  new Exception(data.PO_MSG);
                        }


                    }

                }

            }
            catch (Exception e)
            {
                resultData.Success = false;
                resultData.Message = e.Message;
                Logs.LogWrite(new LogParam()
                {
                    Msg = e.Message,
                    OperatorCode = baseParam.EmpID.ToString(),
                    Params = Logs.ToJson(param),
                    ResultData = Logs.ToJson(data)

                });

            }
            return JsonConvert.SerializeObject(resultData);

        }
        /// <summary>
        /// 入院登记
        /// </summary>
        /// <returns></returns>
        public string HospitalizationRegister(string param, HisBaseParam baseParam)
        {
            var resultData = new ApiJsonResultData { Success = true };
            var data = new HospitalizationRegisterDto();
            try
            {
                var paramIni = JsonConvert.DeserializeObject<HospitalizationRegisterParam>(param);

                var xmlStr = XmlHelp.SaveXml(paramIni);
                if (xmlStr)
                {
                    int result = WorkersMedicalInsurance.CallService_cxjb("CXJB002");
                    if (result == 1)
                    {
                        data = XmlHelp.DeSerializerModel(new HospitalizationRegisterDto());
                        if (data.PO_FHZ == "1")
                        {
                            resultData.Data = JsonConvert.SerializeObject(data);
                        }
                        else
                        {
                            throw new Exception(data.PO_MSG);
                        }


                    }

                }

            }
            catch (Exception e)
            {
                resultData.Success = false;
                resultData.Message = e.Message;
                Logs.LogWrite(new LogParam()
                {
                    Msg = e.Message,
                    OperatorCode = baseParam.EmpID.ToString(),
                    Params = Logs.ToJson(param),
                    ResultData = Logs.ToJson(data)

                });

            }
            return JsonConvert.SerializeObject(resultData);
        }
        /// <summary>
        /// 住院资料修改
        /// </summary>
        /// <returns></returns>
        public string HospitalizationModify(string param, HisBaseParam baseParam)
        {   
            var resultData = new ApiJsonResultData { Success = true };
            var data = new HospitalizationModifyDto();
            try
            {
                var paramIni = JsonConvert.DeserializeObject<HospitalizationModifyParam>(param);

                var xmlStr = XmlHelp.SaveXml(paramIni);
                if (xmlStr)
                {
                    int result = WorkersMedicalInsurance.CallService_cxjb("CXJB003");
                    if (result == 1)
                    {
                        data = XmlHelp.DeSerializerModel(new HospitalizationModifyDto());
                        if (data.PO_FHZ == "1")
                        {
                            resultData.Data = JsonConvert.SerializeObject(data);
                        }
                        else
                        {
                            throw new Exception(data.PO_MSG);
                        }


                    }

                }

            }
            catch (Exception e)
            {
                resultData.Success = false;
                resultData.Message = e.Message;
                Logs.LogWrite(new LogParam()
                {
                    Msg = e.Message,
                    OperatorCode = baseParam.EmpID.ToString(),
                    Params = Logs.ToJson(param),
                    ResultData = Logs.ToJson(data)

                });

            }
            return JsonConvert.SerializeObject(resultData);

        }
        /// <summary>
        /// 处方上传
        /// </summary>
        /// <returns></returns>
        public string PrescriptionUpload()
        {
            return "";
        }
        /// <summary>
        /// 处方删除
        /// </summary>
        public void PrescriptionDelete()
        {
        }
        /// <summary>
        /// 处方明细查询
        /// </summary>
        public void PrescriptionDetailQuery()
        {
        }
        /// <summary>
        /// 批次确认
        /// </summary>
        public void BatchConfirmation()
        {
        }
        /// <summary>
        /// 批次未确认
        /// </summary>
        public void BatchUnConfirmation()
        {
        }
        /// <summary>
        /// 费用预结算
        /// </summary>
        public void CostPreSettlement()
        {
        }
        /// <summary>
        /// 费用结算
        /// </summary>
        public void CostSettlement()
        {
        }
        /// <summary>
        /// 入院结算取消
        /// </summary>
        public void HospitalizedSettlementCancel()
        {
        }
        /// <summary>
        /// 费用结算查询
        /// </summary>
        public void CostSettlementQuery()
        {
        }
        /// <summary>
        /// 项目下载
        /// </summary>
        public void ProjectDownload()
        {
        }
        /// <summary>
        /// 特殊疾病认定
        /// </summary>
        public void IdentificationSpecialDiseases()
        {
        }
        /// <summary>
        /// 特殊疾病认定取消
        /// </summary>
        public void IdentificationSpecialDiseasesCancel()
        {
        }
        /// <summary>
        /// 特殊疾病查询
        /// </summary>
        public void IdentificationSpecialQuery()
        {
        }
        /// <summary>
        /// 特殊疾病申报变更
        /// </summary>
        public void IdentificationSpecialChange()
        {
        }
        /// <summary>
        /// 特殊疾病预结算
        /// </summary>
        public void IdentificationSpecialSettlement()
        {
        }
        /// <summary>
        /// 特殊疾病报销
        /// </summary>
        public void IdentificationSpecialReimbursement()
        {
        }
        /// <summary>
        /// 特殊疾病报销取消
        /// </summary>
        public void IdentificationSpecialCancel()
        {
        }
        /// <summary>
        /// 特殊疾病报销取消查询
        /// </summary>
        public void IdentificationSpecialReimbursementQuery()
        { 
        }
        /// <summary>
        /// 特殊疾病报销汇总
        /// </summary>
        public void IdentificationSpecialReimbursementAll()
        {
        }
        /// <summary>
        /// 特殊疾病报销汇总取消
        /// </summary>
        public void IdentificationSpecialReimbursementAlllCancel()
        {
        }
        /// <summary>
        /// 特殊疾病下载
        /// </summary>
        public void IdentificationSpecialDownload()
        {
        }

    }
}
