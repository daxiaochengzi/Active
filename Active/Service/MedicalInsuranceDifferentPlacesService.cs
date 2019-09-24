using System;
using BenDing.Service;
using BenDingActive.Model;
using BenDingActive.Model.Dto;
using BenDingActive.Model.Dto.DifferentPlaces;
using BenDingActive.Model.Dto.Single;
using BenDingActive.Model.Params;
using BenDingActive.Model.Params.DifferentPlaces;
using BenDingActive.Model.Params.Single;
using BenDingActive.Xml;
using Newtonsoft.Json;


namespace BenDingActive.Service
{
    public class MedicalInsuranceDifferentPlacesService
    {
        /// <summary>
        /// 获取个人基础资料
        /// </summary>
        /// <param name="param"></param>
        /// <param name="baseParam"></param>
        public string DifferentPlacesGetUserInfo(string param, HisBaseParam baseParam)
        {
            var resultData = new ApiJsonResultData { Success = true };
            var data = new UserInfoDifferentDto();
            try
            {
                var paramIni = JsonConvert.DeserializeObject<UserInfoDifferentParam>(param);
                var xmlStr = XmlHelp.SaveXml(paramIni);
                if (xmlStr)
                {
                    int result = MedicalInsuranceDifferentPlaces.yyjk_call("YYJK001");
                    if (result == 1)
                    {
                        data = XmlHelp.DeSerializerModel(new UserInfoDifferentDto());
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

            return  JsonConvert.SerializeObject(resultData);

        }
        /// <summary>
        /// 入院登记
        /// </summary>
        /// <returns></returns>
        public string DifferentPlacesHospitalizationRegister(string param, HisBaseParam baseParam)
        {
            var resultData = new ApiJsonResultData { Success = true };
            var data = new HospitalizationRegisterDifferentDto();
            try
            {
                var paramIni = JsonConvert.DeserializeObject<HospitalizationRegisterParam>(param);

                var xmlStr = XmlHelp.SaveXml(paramIni);
                if (xmlStr)
                {
                    int result = MedicalInsuranceDifferentPlaces.yyjk_call("YYJK003");
                    if (result == 1)
                    {
                        data = XmlHelp.DeSerializerModel(new HospitalizationRegisterDifferentDto());
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
        /// 取消入院登记
        /// </summary>
        /// <returns></returns>
        public string DifferentPlacesHospitalizationCancel(string param, HisBaseParam baseParam)
        {
            var resultData = new ApiJsonResultData { Success = true };
            var data = new SingleHospitalizationCancelDto();
            try
            {
                var paramIni = JsonConvert.DeserializeObject<SingleHospitalizationCancelParam>(param);

                var xmlStr = XmlHelp.SaveXml(paramIni);
                if (xmlStr)
                {
                    int result = WorkersMedicalInsurance.CallService_cxjb("YYJK004");
                    if (result == 1)
                    {
                        data = XmlHelp.DeSerializerModel(new SingleHospitalizationCancelDto());
                        if (data.PO_FHZ == "1")
                        {
                            resultData.Data = JsonConvert.SerializeObject(data);
                        }
                        else
                        {
                            throw new Exception("病人身份证:" + baseParam.IdCard + ";" + data.PO_MSG);
                        }
                        Logs.LogWrite(new LogParam()
                        {
                            Msg = data.PO_MSG,
                            OperatorCode = baseParam.EmpID,
                            Params = Logs.ToJson(param),
                            ResultData = Logs.ToJson(data)

                        });

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
        public string DifferentPlacesHospitalizationModify(string param, HisBaseParam baseParam)
        {
            var resultData = new ApiJsonResultData { Success = true };
            var data = new HospitalizationModifyDto();
            try
            {
                var paramIni = JsonConvert.DeserializeObject<HospitalizationModifyParam>(param);

                var xmlStr = XmlHelp.SaveXml(paramIni);
                if (xmlStr)
                {
                    int result = MedicalInsuranceDifferentPlaces.yyjk_call("YYJK005");
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
        /// 出院办理
        /// </summary>
        /// <param name="param"></param>
        /// <param name="baseParam"></param>
        /// <returns></returns>
        public string DifferentLeaveHospital(string param, HisBaseParam baseParam)
        {
            var resultData = new ApiJsonResultData { Success = true };
            var data = new DifferentLeaveHospitalDto();
            try
            {
                var paramIni = JsonConvert.DeserializeObject<DifferentLeaveHospitalParam>(param);

                var xmlStr = XmlHelp.SaveXml(paramIni);
                if (xmlStr)
                {
                    int result = MedicalInsuranceDifferentPlaces.yyjk_call("YYJK005");
                    if (result == 1)
                    {
                        data = XmlHelp.DeSerializerModel(new DifferentLeaveHospitalDto());
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
        /// 出院办理回退
        /// </summary>
        /// <param name="param"></param>
        /// <param name="baseParam"></param>
        /// <returns></returns>
        public string DifferentLeaveHospitalReturn(string param, HisBaseParam baseParam)
        {
            var resultData = new ApiJsonResultData { Success = true };
            var data = new DifferentLeaveHospitalDto();
            try
            {
                var paramIni = JsonConvert.DeserializeObject<DifferentLeaveHospitalParam>(param);

                var xmlStr = XmlHelp.SaveXml(paramIni);
                if (xmlStr)
                {
                    int result = MedicalInsuranceDifferentPlaces.yyjk_call("YYJK005");
                    if (result == 1)
                    {
                        data = XmlHelp.DeSerializerModel(new DifferentLeaveHospitalDto());
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
        public string DifferentPlacesPrescriptionUpload(string param, HisBaseParam baseParam)
        {
            var resultData = new ApiJsonResultData { Success = true };
            var data = new PrescriptionUploadDto();
            try
            {
                var paramIni = JsonConvert.DeserializeObject<PrescriptionUploadParam>(param);

                var xmlStr = XmlHelp.SaveXml(paramIni);
                if (xmlStr)
                {
                    int result = MedicalInsuranceDifferentPlaces.yyjk_call("CXJB004");
                    if (result == 1)
                    {
                        data = XmlHelp.DeSerializerModel(new PrescriptionUploadDto());
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
        /// 处方删除
        /// </summary>
        public string DifferentPlacesPrescriptionDelete(string param, HisBaseParam baseParam)
        {
            var resultData = new ApiJsonResultData { Success = true };
            var data = new PrescriptionDeleteDto();
            try
            {
                var paramIni = JsonConvert.DeserializeObject<PrescriptionDeleteParam>(param);

                var xmlStr = XmlHelp.SaveXml(paramIni);
                if (xmlStr)
                {
                    int result = MedicalInsuranceDifferentPlaces.yyjk_call("CXJB005");
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
        ///// <summary>
        ///// 处方明细查询
        ///// </summary>
        //public string DifferentPlacesPrescriptionDetailQuery(string param, HisBaseParam baseParam)
        //{
        //    var resultData = new ApiJsonResultData { Success = true };

        //    try
        //    {
        //        var paramIni = JsonConvert.DeserializeObject<PrescriptionDetailQueryParam>(param);

        //        var xmlStr = XmlHelp.SaveXml(paramIni);
        //        if (xmlStr)
        //        {
        //            int result = MedicalInsuranceDifferentPlaces.yyjk_call("CXJB006");
        //            if (result == 1)
        //            {
        //                var validData = XmlHelp.ValidXml("CFMX");
        //                if (validData.PO_FHZ == "1")
        //                {
        //                    if (validData.IsRows)
        //                    {
        //                        var data = XmlHelp.DeSerializerModel(new PrescriptionDetailQueryRow());
        //                        resultData.Data = JsonConvert.SerializeObject(data);
        //                    }
        //                    else
        //                    {
        //                        var data = XmlHelp.DeSerializerModel(new PrescriptionDetailQueryDto());
        //                        resultData.Data = JsonConvert.SerializeObject(data);
        //                    }


        //                }
        //                else
        //                {
        //                    throw new Exception("病人身份证:" + baseParam.IdCard + ";" + validData.PO_MSG);
        //                }
        //            }

        //        }

        //    }
        //    catch (Exception e)
        //    {
        //        resultData.Success = false;
        //        resultData.Message = e.Message;
        //        Logs.LogWrite(new LogParam()
        //        {
        //            Msg = e.Message,
        //            OperatorCode = baseParam.EmpID,
        //            Params = Logs.ToJson(param),
        //        });

        //    }
        //    return JsonConvert.SerializeObject(resultData);
        //}
        
        /// <summary>
        /// 费用预结算
        /// </summary>
        public string DifferentPlacesCostPreSettlement(string param, HisBaseParam baseParam)
        {
            var resultData = new ApiJsonResultData { Success = true };
            var data = new CostPreSettlementDto();
            try
            {
                var paramIni = JsonConvert.DeserializeObject<CostPreSettlementParam>(param);

                var xmlStr = XmlHelp.SaveXml(paramIni);
                if (xmlStr)
                {
                    int result = MedicalInsuranceDifferentPlaces.yyjk_call("CXJB009");
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
        public string DifferentPlacesCostSettlement(string param, HisBaseParam baseParam)
        {
            var resultData = new ApiJsonResultData { Success = true };
            var data = new CostSettlementDto();
            try
            {
                var paramIni = JsonConvert.DeserializeObject<CostSettlementParam>(param);

                var xmlStr = XmlHelp.SaveXml(paramIni);
                if (xmlStr)
                {
                    int result = MedicalInsuranceDifferentPlaces.yyjk_call("CXJB010");
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
        public string DifferentPlacesHospitalizedSettlementCancel(string param, HisBaseParam baseParam)
        {
            var resultData = new ApiJsonResultData { Success = true };
            var data = new HospitalizedSettlementCancelDto();
            try
            {
                var paramIni = JsonConvert.DeserializeObject<HospitalizedSettlementCancelParam>(param);

                var xmlStr = XmlHelp.SaveXml(paramIni);
                if (xmlStr)
                {
                    int result = MedicalInsuranceDifferentPlaces.yyjk_call("CXJB011");
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
        public string DifferentPlacesCostSettlementQuery(string param, HisBaseParam baseParam)
        {
            var resultData = new ApiJsonResultData { Success = true };
            var data = new CostSettlementQueryDto();
            try
            {
                var paramIni = JsonConvert.DeserializeObject<CostSettlementQueryParam>(param);

                var xmlStr = XmlHelp.SaveXml(paramIni);
                if (xmlStr)
                {
                    int result = MedicalInsuranceDifferentPlaces.yyjk_call("CXJB012");
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
    }
}
