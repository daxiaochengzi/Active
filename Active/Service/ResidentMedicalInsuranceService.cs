﻿using System;
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
    public class ResidentMedicalInsuranceService
    {
      
        /// <summary>
        /// 获取个人基础资料
        /// </summary>
        /// <param name="param"></param>
        /// <param name="baseParam"></param>
        public UserInfoDto GetUserInfo(string param, HisBaseParam baseParam)
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
                    OperatorCode = baseParam.EmpID,
                    Params = Logs.ToJson(param),
                    ResultData = Logs.ToJson(data)

                });

            }

            return data; //JsonConvert.SerializeObject(resultData);

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
                            throw new Exception("病人身份证:" + baseParam.IdCard + ";" + data.PO_MSG);
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
                    OperatorCode = baseParam.EmpID,
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
                            throw new Exception("病人身份证:" + baseParam.IdCard + ";" + data.PO_MSG);
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
                    OperatorCode = baseParam.EmpID,
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
        public PrescriptionUploadDto PrescriptionUpload(string param, HisBaseParam baseParam)
        {
            var resultData = new ApiJsonResultData { Success = true };
            var data = new PrescriptionUploadDto();
            try
            {
                var paramIni = JsonConvert.DeserializeObject<PrescriptionUploadParam>(param);

                var xmlStr = XmlHelp.SaveXml(paramIni);
                if (xmlStr)
                {
                    int result = WorkersMedicalInsurance.CallService_cxjb("CXJB004");
                    if (result == 1)
                    {
                        data = XmlHelp.DeSerializerModel(new PrescriptionUploadDto());
                        if (data.PO_FHZ == "1")
                        {
                            resultData.Data = JsonConvert.SerializeObject(data);
                        }
                        else
                        {
                            throw new Exception("病人身份证:"+baseParam.IdCard +";"+ data.PO_MSG);
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
                    OperatorCode = baseParam.EmpID,
                    Params = Logs.ToJson(param),
                    ResultData = Logs.ToJson(data)

                });

            }

            return data; //JsonConvert.SerializeObject(resultData);


        }
        /// <summary>
        /// 处方删除
        /// </summary>
        public string PrescriptionDelete(string param, HisBaseParam baseParam)
        {
            var resultData = new ApiJsonResultData { Success = true };
            var data = new PrescriptionDeleteDto();
            try
            {
                var paramIni = JsonConvert.DeserializeObject<PrescriptionDeleteParam>(param);

                var xmlStr = XmlHelp.SaveXml(paramIni);
                if (xmlStr)
                {
                    int result = WorkersMedicalInsurance.CallService_cxjb("CXJB005");
                    if (result == 1)
                    {
                        data = XmlHelp.DeSerializerModel(new PrescriptionDeleteDto());
                        if (data.PO_FHZ == "1")
                        {
                            resultData.Data = JsonConvert.SerializeObject(data);
                        }
                        else
                        {
                            throw new Exception("病人身份证:" + baseParam.IdCard + ";" + data.PO_MSG);
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
                    OperatorCode = baseParam.EmpID,
                    Params = Logs.ToJson(param),
                    ResultData = Logs.ToJson(data)

                });

            }
            return JsonConvert.SerializeObject(resultData);
        }
        /// <summary>
        /// 处方明细查询
        /// </summary>
        public string PrescriptionDetailQuery(string param, HisBaseParam baseParam)
        {
            var resultData = new ApiJsonResultData { Success = true };
           
            try
            {
                var paramIni = JsonConvert.DeserializeObject<PrescriptionDetailQueryParam>(param);

                var xmlStr = XmlHelp.SaveXml(paramIni);
                if (xmlStr)
                {
                    int result = WorkersMedicalInsurance.CallService_cxjb("CXJB006");
                    if (result == 1)
                    {
                         var validData = XmlHelp.ValidXml("CFMX");
                        if (validData.PO_FHZ == "1")
                        {
                            if (validData.IsRows )
                            {
                                var data = XmlHelp.DeSerializerModel(new PrescriptionDetailQueryRow());
                                resultData.Data = JsonConvert.SerializeObject(data);
                            }
                            else
                            {
                                var data = XmlHelp.DeSerializerModel(new PrescriptionDetailQueryDto());
                                resultData.Data = JsonConvert.SerializeObject(data);
                            }

                            
                        }
                        else
                        {
                            throw new Exception("病人身份证:" + baseParam.IdCard + ";" + validData.PO_MSG);
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
                    OperatorCode = baseParam.EmpID,
                    Params = Logs.ToJson(param),
                });

            }
            return JsonConvert.SerializeObject(resultData);
        }
        /// <summary>
        /// 批次确认
        /// </summary>
        public string BatchConfirmation(string param, HisBaseParam baseParam)
        {
            var resultData = new ApiJsonResultData { Success = true };
            var data = new BatchConfirmationDto();
            try
            {
                var paramIni = JsonConvert.DeserializeObject<BatchConfirmationParam>(param);
                var xmlStr = XmlHelp.SaveXml(paramIni);
                if (xmlStr)
                {
                    int result = WorkersMedicalInsurance.CallService_cxjb("CXJB007");
                    if (result == 1)
                    {
                        data = XmlHelp.DeSerializerModel(new BatchConfirmationDto());
                        if (data.PO_FHZ == "1")
                        {
                            resultData.Data = JsonConvert.SerializeObject(data);
                        }
                        else
                        {
                            throw new Exception("病人身份证:" + baseParam.IdCard + ";" + data.PO_MSG);
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
                    OperatorCode = baseParam.EmpID,
                    Params = Logs.ToJson(param),
                    ResultData = Logs.ToJson(data)

                });

            }
            return JsonConvert.SerializeObject(resultData);

        }
        /// <summary>
        /// 批次未确认
        /// </summary>
        public string BatchUnConfirmation(string param, HisBaseParam baseParam)
        {
            var resultData = new ApiJsonResultData { Success = true };
            var data = new BatchUnConfirmationDto();
            try
            {
                var paramIni = JsonConvert.DeserializeObject<BatchUnConfirmationParam>(param);

                var xmlStr = XmlHelp.SaveXml(paramIni);
                if (xmlStr)
                {
                    int result = WorkersMedicalInsurance.CallService_cxjb("CXJB008");
                    if (result == 1)
                    {
                        data = XmlHelp.DeSerializerModel(new BatchUnConfirmationDto());
                        if (data.PO_FHZ == "1")
                        {
                            resultData.Data = JsonConvert.SerializeObject(data);
                        }
                        else
                        {
                            throw new Exception("病人身份证:" + baseParam.IdCard + ";" + data.PO_MSG);
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
                    OperatorCode = baseParam.EmpID,
                    Params = Logs.ToJson(param),
                    ResultData = Logs.ToJson(data)

                });

            }
            return JsonConvert.SerializeObject(resultData);
        }
        /// <summary>
        /// 费用预结算
        /// </summary>
        public string CostPreSettlement(string param, HisBaseParam baseParam)
        {
            var resultData = new ApiJsonResultData { Success = true };
            var data = new CostPreSettlementDto();
            try
            {
                var paramIni = JsonConvert.DeserializeObject<CostPreSettlementParam>(param);

                var xmlStr = XmlHelp.SaveXml(paramIni);
                if (xmlStr)
                {
                    int result = WorkersMedicalInsurance.CallService_cxjb("CXJB009");
                    if (result == 1)
                    {
                        data = XmlHelp.DeSerializerModel(new CostPreSettlementDto());
                        if (data.PO_FHZ == "1")
                        {
                            resultData.Data = JsonConvert.SerializeObject(data);
                        }
                        else
                        {
                            throw new Exception("病人身份证:" + baseParam.IdCard + ";" + data.PO_MSG);
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
                    OperatorCode = baseParam.EmpID,
                    Params = Logs.ToJson(param),
                    ResultData = Logs.ToJson(data)

                });

            }
            return JsonConvert.SerializeObject(resultData);
        }
        /// <summary>
        /// 费用结算
        /// </summary>
        public string CostSettlement(string param, HisBaseParam baseParam)
        {
            var resultData = new ApiJsonResultData { Success = true };
            var data = new CostSettlementDto();
            try
            {
                var paramIni = JsonConvert.DeserializeObject<CostSettlementParam>(param);

                var xmlStr = XmlHelp.SaveXml(paramIni);
                if (xmlStr)
                {
                    int result = WorkersMedicalInsurance.CallService_cxjb("CXJB010");
                    if (result == 1)
                    {
                        data = XmlHelp.DeSerializerModel(new CostSettlementDto());
                        if (data.PO_FHZ == "1")
                        {
                            resultData.Data = JsonConvert.SerializeObject(data);
                        }
                        else
                        {
                            throw new Exception("病人身份证:" + baseParam.IdCard + ";" + data.PO_MSG);
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
                    OperatorCode = baseParam.EmpID,
                    Params = Logs.ToJson(param),
                    ResultData = Logs.ToJson(data)

                });

            }
            return JsonConvert.SerializeObject(resultData);
        }
        /// <summary>
        /// 入院结算取消
        /// </summary>
        public string HospitalizedSettlementCancel(string param, HisBaseParam baseParam)
        {
            var resultData = new ApiJsonResultData { Success = true };
            var data = new HospitalizedSettlementCancelDto();
            try
            {
                var paramIni = JsonConvert.DeserializeObject<HospitalizedSettlementCancelParam>(param);

                var xmlStr = XmlHelp.SaveXml(paramIni);
                if (xmlStr)
                {
                    int result = WorkersMedicalInsurance.CallService_cxjb("CXJB011");
                    if (result == 1)
                    {
                        data = XmlHelp.DeSerializerModel(new HospitalizedSettlementCancelDto());
                        if (data.PO_FHZ == "1")
                        {
                            resultData.Data = JsonConvert.SerializeObject(data);
                        }
                        else
                        {
                            throw new Exception("病人身份证:" + baseParam.IdCard + ";" + data.PO_MSG);
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
                    OperatorCode = baseParam.EmpID,
                    Params = Logs.ToJson(param),
                    ResultData = Logs.ToJson(data)

                });

            }
            return JsonConvert.SerializeObject(resultData);
        }
        /// <summary>
        /// 费用结算查询
        /// </summary>
        public string CostSettlementQuery(string param, HisBaseParam baseParam)
        {
            var resultData = new ApiJsonResultData { Success = true };
            var data = new CostSettlementQueryDto();
            try
            {
                var paramIni = JsonConvert.DeserializeObject<CostSettlementQueryParam>(param);

                var xmlStr = XmlHelp.SaveXml(paramIni);
                if (xmlStr)
                {
                    int result = WorkersMedicalInsurance.CallService_cxjb("CXJB012");
                    if (result == 1)
                    {
                        data = XmlHelp.DeSerializerModel(new CostSettlementQueryDto());
                        if (data.PO_FHZ == "1")
                        {
                            resultData.Data = JsonConvert.SerializeObject(data);
                        }
                        else
                        {
                            throw new Exception("病人身份证:" + baseParam.IdCard + ";" + data.PO_MSG);
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
                    OperatorCode = baseParam.EmpID,
                    Params = Logs.ToJson(param),
                    ResultData = Logs.ToJson(data)

                });

            }
            return JsonConvert.SerializeObject(resultData);
        }
        /// <summary>
        /// 项目下载
        /// </summary>
        public ProjectDownloadDto ProjectDownload(string param, HisBaseParam baseParam)
        {
            var resultData = new ApiJsonResultData { Success = true };
            var data = new ProjectDownloadDto();
            try
            {
                var paramIni = JsonConvert.DeserializeObject<ProjectDownloadParam>(param);

                var xmlStr = XmlHelp.SaveXml(paramIni);
                if (xmlStr)
                {
                    int result = WorkersMedicalInsurance.CallService_cxjb("CXJB019");
                    if (result == 1)
                    {
                        data = XmlHelp.DeSerializerModel(new ProjectDownloadDto());
                        if (data.PO_FHZ == "1")
                        {
                            resultData.Data = JsonConvert.SerializeObject(data);
                        }
                        else
                        {
                            throw new Exception( data.PO_MSG);
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
                    OperatorCode = baseParam.EmpID,
                    Params = Logs.ToJson(param),
                    ResultData = Logs.ToJson(data)

                });

            }

            return data; //JsonConvert.SerializeObject(resultData);
        }
        /// <summary>
        /// 特殊疾病认定
        /// </summary>
        public string IdentificationSpecialDiseases(string param, HisBaseParam baseParam)
        {
            var resultData = new ApiJsonResultData { Success = true };
            var data = new IdentificationSpecialDiseasesDto();
            try
            {
                var paramIni = JsonConvert.DeserializeObject<IdentificationSpecialDiseasesParam>(param);

                var xmlStr = XmlHelp.SaveXml(paramIni);
                if (xmlStr)
                {
                    int result = WorkersMedicalInsurance.CallService_cxjb("CXJB013");
                    if (result == 1)
                    {
                        data = XmlHelp.DeSerializerModel(new IdentificationSpecialDiseasesDto());
                        if (data.PO_FHZ == "1")
                        {
                            resultData.Data = JsonConvert.SerializeObject(data);
                        }
                        else
                        {
                            throw new Exception("病人身份证:" + baseParam.IdCard + ";" + data.PO_MSG);
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
                    OperatorCode = baseParam.EmpID,
                    Params = Logs.ToJson(param),
                    ResultData = Logs.ToJson(data)

                });

            }
            return JsonConvert.SerializeObject(resultData);
        }
        /// <summary>
        /// 特殊疾病认定取消
        /// </summary>
        public string IdentificationSpecialDiseasesCancel(string param, HisBaseParam baseParam)
        {
            var resultData = new ApiJsonResultData { Success = true };
            var data = new IdentificationSpecialCancelDto();
            try
            {
                var paramIni = JsonConvert.DeserializeObject<IdentificationSpecialDiseasesCancelParam>(param);

                var xmlStr = XmlHelp.SaveXml(paramIni);
                if (xmlStr)
                {
                    int result = WorkersMedicalInsurance.CallService_cxjb("MTBX002");
                    if (result == 1)
                    {
                        data = XmlHelp.DeSerializerModel(new IdentificationSpecialCancelDto());
                        if (data.PO_FHZ == "1")
                        {
                            resultData.Data = JsonConvert.SerializeObject(data);
                        }
                        else
                        {
                            throw new Exception("病人身份证:" + baseParam.IdCard + ";" + data.PO_MSG);
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
                    OperatorCode = baseParam.EmpID,
                    Params = Logs.ToJson(param),
                    ResultData = Logs.ToJson(data)

                });

            }
            return JsonConvert.SerializeObject(resultData);
        }
        /// <summary>
        /// 特殊疾病查询
        /// </summary>
        public string IdentificationSpecialQuery(string param, HisBaseParam baseParam)
        {
            var resultData = new ApiJsonResultData { Success = true };
            try
            {
                var paramIni = JsonConvert.DeserializeObject<IdentificationSpecialDiseasesQueryParam>(param);

                var xmlStr = XmlHelp.SaveXml(paramIni);
                if (xmlStr)
                {
                    int result = WorkersMedicalInsurance.CallService_cxjb("MTBX003");
                    if (result == 1)
                    {
                        
                        var dataValid = XmlHelp.ValidXml("PO_RDXX");
                        if (dataValid.PO_FHZ == "1")
                        {
                            var data = XmlHelp.IdentificationSpecialQueryDeSerializerModel(
                                new IdentificationSpecialQueryDto());
                            resultData.Data = JsonConvert.SerializeObject(data);
                        }
                        else
                        {
                            throw new Exception("病人身份证:" + baseParam.IdCard + ";" + dataValid.PO_MSG);
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
                    OperatorCode = baseParam.EmpID,
                    Params = Logs.ToJson(param),
                   

                });

            }
            return JsonConvert.SerializeObject(resultData);
        }
        public string IdentificationSpecialHospitalQuery(string param, HisBaseParam baseParam)
        {
            var resultData = new ApiJsonResultData { Success = true };
            var data = new IdentificationSpecialHospitalQueryDto();
            try
            {
                var paramIni = JsonConvert.DeserializeObject<IdentificationSpecialHospitalQueryParam>(param);

                var xmlStr = XmlHelp.SaveXml(paramIni);
                if (xmlStr)
                {
                    int result = WorkersMedicalInsurance.CallService_cxjb("MTBX004");
                    if (result == 1) 
                    {
                        data = XmlHelp.DeSerializerModel(new IdentificationSpecialHospitalQueryDto());
                        if (data.PO_FHZ == "1")
                        {
                            resultData.Data = JsonConvert.SerializeObject(data);
                        }
                        else
                        {
                            throw new Exception("病人身份证:" + baseParam.IdCard + ";" + data.PO_MSG);
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
                    OperatorCode = baseParam.EmpID,
                    Params = Logs.ToJson(param),
                    ResultData = Logs.ToJson(data)

                });

            }
            return JsonConvert.SerializeObject(resultData);
        }
        /// <summary>
        /// 特殊疾病申报变更
        /// </summary>
        public string   IdentificationSpecialChange(string param, HisBaseParam baseParam)
        {
            var resultData = new ApiJsonResultData { Success = true };
            var data = new IdentificationSpecialChangeDto();
            try
            {
                var paramIni = JsonConvert.DeserializeObject<IdentificationSpecialChangParam>(param);

                var xmlStr = XmlHelp.SaveXml(paramIni);
                if (xmlStr)
                {
                    int result = WorkersMedicalInsurance.CallService_cxjb("MTBX005");
                    if (result == 1)
                    {
                        data = XmlHelp.DeSerializerModel(new IdentificationSpecialChangeDto());
                        if (data.PO_FHZ == "1")
                        {
                            resultData.Data = JsonConvert.SerializeObject(data);
                        }
                        else
                        {
                            throw new Exception("病人身份证:" + baseParam.IdCard + ";" + data.PO_MSG);
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
                    OperatorCode = baseParam.EmpID,
                    Params = Logs.ToJson(param),
                    ResultData = Logs.ToJson(data)

                });

            }
            return JsonConvert.SerializeObject(resultData);
        }
        /// <summary>
        /// 特殊疾病预结算
        /// </summary>
        public string IdentificationSpecialSettlement(string param, HisBaseParam baseParam)
        {
            var resultData = new ApiJsonResultData { Success = true };
            var data = new IdentificationSpecialSettlementDto();
            try
            {
                var paramIni = JsonConvert.DeserializeObject<IdentificationSpecialSettlementParam>(param);

                var xmlStr = XmlHelp.SaveXml(paramIni);
                if (xmlStr)
                {
                    int result = WorkersMedicalInsurance.CallService_cxjb("MTBX012");
                    if (result == 1)
                    {
                        data = XmlHelp.DeSerializerModel(new IdentificationSpecialSettlementDto());
                        if (data.PO_FHZ == "1")
                        {
                            resultData.Data = JsonConvert.SerializeObject(data);
                        }
                        else
                        {
                            throw new Exception("病人身份证:" + baseParam.IdCard + ";" + data.PO_MSG);
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
                    OperatorCode = baseParam.EmpID,
                    Params = Logs.ToJson(param),
                    ResultData = Logs.ToJson(data)

                });

            }
            return JsonConvert.SerializeObject(resultData);
        }
        /// <summary>
        /// 特殊疾病报销
        /// </summary>
        public string IdentificationSpecialReimbursement(string param, HisBaseParam baseParam)
        {
            var resultData = new ApiJsonResultData { Success = true };
            var data = new IdentificationSpecialReimbursementDto();
            try
            {
                var paramIni = JsonConvert.DeserializeObject<IdentificationSpecialSettlementParam>(param);

                var xmlStr = XmlHelp.SaveXml(paramIni);
                if (xmlStr)
                {
                    int result = WorkersMedicalInsurance.CallService_cxjb("MTBX006");
                    if (result == 1)
                    {
                        data = XmlHelp.DeSerializerModel(new IdentificationSpecialReimbursementDto());
                        if (data.PO_FHZ == "1")
                        {
                            resultData.Data = JsonConvert.SerializeObject(data);
                        }
                        else
                        {
                            throw new Exception("病人身份证:" + baseParam.IdCard + ";" + data.PO_MSG);
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
                    OperatorCode = baseParam.EmpID,
                    Params = Logs.ToJson(param),
                    ResultData = Logs.ToJson(data)

                });

            }
            return JsonConvert.SerializeObject(resultData);
        }
        /// <summary>
        /// 特殊疾病报销取消
        /// </summary>
        public string IdentificationSpecialCancel(string param, HisBaseParam baseParam)
        {
            var resultData = new ApiJsonResultData { Success = true };
            var data = new IdentificationSpecialCancelDto();
            try
            {
                var paramIni = JsonConvert.DeserializeObject<IdentificationSpecialCancelParam>(param);

                var xmlStr = XmlHelp.SaveXml(paramIni);
                if (xmlStr)
                {
                    int result = WorkersMedicalInsurance.CallService_cxjb("MTBX007");
                    if (result == 1)
                    {
                        data = XmlHelp.DeSerializerModel(new IdentificationSpecialCancelDto());
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
                    OperatorCode = baseParam.EmpID,
                    Params = Logs.ToJson(param),
                    ResultData = Logs.ToJson(data)

                });

            }
            return JsonConvert.SerializeObject(resultData);
        }
        /// <summary>
        /// 特殊疾病报销查询
        /// </summary>
        public string IdentificationSpecialReimbursementQuery(string param, HisBaseParam baseParam)
        {
            var resultData = new ApiJsonResultData { Success = true };
            try
            {
                var paramIni = JsonConvert.DeserializeObject<IdentificationSpecialReimbursementQueryParam>(param);

                var xmlStr = XmlHelp.SaveXml(paramIni);
                if (xmlStr)
                {
                    int result = WorkersMedicalInsurance.CallService_cxjb("MTBX008");
                    if (result == 1)
                    {

                        var dataValid = XmlHelp.ValidXml("PO_JSXX");
                        if (dataValid.PO_FHZ == "1")
                        {
                            if (dataValid.IsRows)
                            {
                                 var data = XmlHelp.DeSerializerModel(
                                    new IdentificationSpecialReimbursementQueryListDto());
                                  resultData.Data = JsonConvert.SerializeObject(data);
                            }
                            else
                            {
                                var data = XmlHelp.DeSerializerModel(
                                    new IdentificationSpecialReimbursementQueryDto());
                                resultData.Data = JsonConvert.SerializeObject(data);
                            } 
                        }  
                        else
                        {
                            throw new Exception("病人身份证:" + baseParam.IdCard + ";" + dataValid.PO_MSG);
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
                    OperatorCode = baseParam.EmpID,
                    Params = Logs.ToJson(param),


                });

            }
            return JsonConvert.SerializeObject(resultData);
        }
        /// <summary>
        /// 特殊疾病报销汇总
        /// </summary>
        public string IdentificationSpecialReimbursementAll(string param, HisBaseParam baseParam)
        {
            var resultData = new ApiJsonResultData { Success = true };
            var data = new IdentificationSpecialReimbursementAllDto();
            try
            {
                var paramIni = JsonConvert.DeserializeObject<IdentificationSpecialReimbursementAllParam>(param);

                var xmlStr = XmlHelp.SaveXml(paramIni);
                if (xmlStr)
                {
                    int result = WorkersMedicalInsurance.CallService_cxjb("MTBX009");
                    if (result == 1)
                    {
                        data = XmlHelp.DeSerializerModel(new IdentificationSpecialReimbursementAllDto());
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
                    OperatorCode = baseParam.EmpID,
                    Params = Logs.ToJson(param),
                    ResultData = Logs.ToJson(data)

                });

            }
            return JsonConvert.SerializeObject(resultData);
        }
        /// <summary>
        /// 特殊疾病报销汇总取消
        /// </summary>
        public string IdentificationSpecialReimbursementAllCancel(string param, HisBaseParam baseParam)
        {
            var resultData = new ApiJsonResultData { Success = true };
            var data = new IdentificationSpecialReimbursementAlllCancelDto();
            try
            {
                var paramIni = JsonConvert.DeserializeObject<IdentificationSpecialReimbursementAlllCancelParam>(param);

                var xmlStr = XmlHelp.SaveXml(paramIni);
                if (xmlStr)
                {
                    int result = WorkersMedicalInsurance.CallService_cxjb("MTBX010");
                    if (result == 1)
                    {
                        data = XmlHelp.DeSerializerModel(new IdentificationSpecialReimbursementAlllCancelDto());
                        if (data.PO_FHZ == "1")
                        {
                            resultData.Data = JsonConvert.SerializeObject(data);
                        }
                        else
                        {
                            throw new Exception( data.PO_MSG);
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
                    OperatorCode = baseParam.EmpID,
                    Params = Logs.ToJson(param),
                    ResultData = Logs.ToJson(data)

                });

            }
            return JsonConvert.SerializeObject(resultData);
        }
        /// <summary>
        /// 特殊疾病下载
        /// </summary>
        public string IdentificationSpecialDownload(string param, HisBaseParam baseParam)
        {
            var resultData = new ApiJsonResultData { Success = true };
            var data = new IdentificationSpecialDownloadDto();
            try
            {
                var paramIni = JsonConvert.DeserializeObject<IdentificationSpecialDownloadParam>(param);

                var xmlStr = XmlHelp.SaveXml(paramIni);
                if (xmlStr)
                {
                    int result = WorkersMedicalInsurance.CallService_cxjb("MTBX010");
                    if (result == 1)
                    {
                        data = XmlHelp.DeSerializerModel(new IdentificationSpecialDownloadDto());
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
                    OperatorCode = baseParam.EmpID,
                    Params = Logs.ToJson(param),
                    ResultData = Logs.ToJson(data)

                });

            }
            return JsonConvert.SerializeObject(resultData);
        }

    }
}
