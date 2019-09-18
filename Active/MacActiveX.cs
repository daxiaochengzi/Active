using System.Runtime.InteropServices;
using BenDingActive.Model;
using BenDingActive.Service;
using Newtonsoft.Json;

namespace BenDingActive
{
    [Guid("65D8E97F-D3E2-462A-B389-241D7C38C518")]
    public class MacActiveX : ActiveXControl
    {  //居民保险
        private ResidentMedicalInsuranceService _resident=new ResidentMedicalInsuranceService();
        /// <summary>
        /// 获取基础信息
        /// </summary>
        /// <param name="param"></param>
        /// <param name="baseParam"></param>
        /// <returns></returns>
        public string GetUserInfo(string param,string baseParam)
        {
            var data = _resident.GetUserInfo(param, JsonConvert.DeserializeObject<HisBaseParam>(baseParam));
             return param;
         }
        /// <summary>
        /// 入院登记
        /// </summary>
        /// <param name="param"></param>
        /// <param name="baseParam"></param>
        /// <returns></returns>
        public string HospitalizationRegister(string param, string baseParam)
        {
            var data = _resident.HospitalizationRegister(param, JsonConvert.DeserializeObject<HisBaseParam>(baseParam));
            return data;
        }
        /// <summary>
        /// 修改入院登记
        /// </summary>
        /// <param name="param"></param>
        /// <param name="baseParam"></param>
        /// <returns></returns>
        public string HospitalizationModify(string param, string baseParam)
        {
            var data = _resident.HospitalizationModify(param, JsonConvert.DeserializeObject<HisBaseParam>(baseParam));
            return data;
        }

        public string GetMacAddress()
        {
            return "777";
        }
    }
}
