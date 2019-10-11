using BenDingActive.Service;
using BenDingActive.Xml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BenDingActive.Model;
using BenDingActive.Model.Params;
using BenDingActive.Model.Params.Single;
using Newtonsoft.Json;

namespace BenDingForm
{
    public partial class SingleResiden : Form
    {


        KeyboardValue _keyboard = new KeyboardValue();
      
        /// <summary> 
        /// 单病种
        /// </summary>
        SingleResidentMedicalInsuranceService _single=new SingleResidentMedicalInsuranceService();
        ResidentMedicalInsuranceService _resident = new ResidentMedicalInsuranceService();
        public SingleResiden()
        {
            InitializeComponent();
          
        }
       

    private void button1_Click(object sender, EventArgs e)
        {
            
            BaseConnect.Connect();
            var param = JsonConvert.SerializeObject(new SingleHospitalizationRegisterParam()
            {
                // E11.900 Ⅱ糖尿病社区诊治管理
                PI_SFBZ = textBox2.Text,//1为身份证
                PI_CRBZ="1",
                PI_AKA130="18",
                PI_CKC537="20190923",
                PI_AKC193= "E11.900",
                PI_CKC540= "Ⅱ糖尿病社区诊治管理",
                PI_AKF001 ="内科",
                PI_AKE020="20",
                PI_AKC190 = Convert.ToDateTime(DateTime.Now).ToString("yyyyMMddHHmmss") + "510726",//20位 入院日期+组织机构后四位
                PI_AAE011= "李茜"

            });
      
            textBox1.Text = _single.SingleHospitalizationRegister(param, new HisBaseParam());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BaseConnect.Connect();
            var param = JsonConvert.SerializeObject(new SingleHospitalizationModifyParam()
            {
             
                PI_AAZ217="",//必填
                PI_CKC544="1",
                PI_CKC537 = "20190923",
                PI_AKC193 = "J15.700",
                PI_CKC540 = "支原体肺炎",
                PI_AKF001 = "内科",
                PI_AKE020 = "20",
                PI_AKC190 = Convert.ToDateTime(DateTime.Now).ToString("yyyyMMddHHmmss") + "510726",//20位 入院日期+组织机构后四位
      

            });
            textBox1.Text = _single.SingleHospitalizationModify(param, new HisBaseParam());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BaseConnect.Connect();
            var param = JsonConvert.SerializeObject(new SingleHospitalizationCancelParam()
            {

                PI_AAZ217 = "",//必填
              


            });
            textBox1.Text = _single.SingleHospitalizationCancel(param, new HisBaseParam());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BaseConnect.Connect();
            var paramList=new List<PI_CFMXRow>();
            paramList.Add(new PI_CFMXRow()
            {
                CO = "0",
                AKC220 = "29115",
                AKC584 = "1",
                AKC222 = "B68000833",
                AKC515 = "29115",
                AKC221 = "2019-09-23 13:01:01",
                AAE040 = "2019-09-23 13:01:02",
                AKA063 = "11", //西药费
                AKC223 = "劳拉西泮",
                AKA065 = "2",//1:甲类  2：乙类  3：丙类
                AKC225 = "0.10",
                AKC226 = "1",
                AKC227 = "0.10",
                AKC228 = "0.01",
                AKA070 = "口服",
                AKA071 = "0",
                AKA072 = "1",
                AKA073 = "直接口服",
                AKA074 = "",
                AKA067 = "",
                AKC229 = "0",
                CKE619="10",
                AAE013 =""
            });
            paramList.Add(new PI_CFMXRow()
            {
                CO = "0",
                AKC220 = "29115",
                AKC584 = "2",
                AKC222 = "B68000834",
                AKC515 = "29116",
                AKC221 = "2019-09-23 13:01:01",
                AAE040 = "2019-09-23 13:01:02",
                AKA063 = "11", //西药费
                AKC223 = "氯美扎酮",
                AKA065 = "2",//1:甲类  2：乙类  3：丙类
                AKC225 = "0.10",
                AKC226 = "1",
                AKC227 = "0.10",
                AKC228 = "0.01",
                AKA070 = "口服",
                AKA071 = "0",
                AKA072 = "1",
                AKA073 = "直接口服",
                AKA074 = "",
                AKA067 = "",
                AKC229 = "0",
                CKE619 = "10",
                AAE013 = ""
            });


            var param = JsonConvert.SerializeObject(new SinglePrescriptionUploadParam()
            {

                PI_AAZ217 = "",//必填
                PI_JBR= "李茜",
                PI_CFMX = paramList
            });
            textBox1.Text = _single.SinglePrescriptionUpload(param, new HisBaseParam());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            BaseConnect.Connect();
            var param = JsonConvert.SerializeObject(new SinglePrescriptionDetailQueryParam()
            {

                PI_AAZ217 = "",//必填
            });
            textBox1.Text = _single.SinglePrescriptionDetailQuery(param, new HisBaseParam());
        }



        private void button5_Click(object sender, EventArgs e)
        {
            BaseConnect.Connect();
            var param = JsonConvert.SerializeObject(new SinglePrescriptionDeleteParam()
            {

                PI_AAZ217 = "",//必填
                PI_PCH="",//必填
            });
            textBox1.Text = _single.SinglePrescriptionDelete(param, new HisBaseParam());
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            BaseConnect.Connect();
            var param = JsonConvert.SerializeObject(new SinglePreSettlementParam()
            {

                PI_AAZ217 = "",//必填
                PI_CYRQ = "2019-09-23 13:01:01",//必填
            });
            textBox1.Text = _single.SinglePreSettlement(param, new HisBaseParam());
        }

        private void button14_Click(object sender, EventArgs e)
        {
            BaseConnect.Connect();
            var param = JsonConvert.SerializeObject(new SingleLeaveHospitalSettlementParam()
            {

                PI_AAZ217 = "",//必填
                PI_CYRQ = "2019-09-23 13:01:01",//必填
                PI_JBR= "李茜",
                PI_CYQK= "1",//必填
                PI_ICD10= "J15.700",//必填
                PI_CYZD= "支原体肺炎"//必填


            });
            textBox1.Text = _single.SingleLeaveHospitalSettlement(param, new HisBaseParam());
        }

        private void button16_Click(object sender, EventArgs e)
        {
            BaseConnect.Connect();
            var param = JsonConvert.SerializeObject(new SingleLeaveHospitalSettlementCancelParam()
            {

                PI_AAZ217="",//必填
                PI_AAZ216="",//必填
                PI_JBR = "李茜",


            });
            textBox1.Text = _single.SingleLeaveHospitalSettlementCancel(param, new HisBaseParam());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BaseConnect.Connect();
            var param = JsonConvert.SerializeObject(new SingleMonthSettlementParam()
            {

                PI_CKA549 = "",//必填
                PI_CKE544 = "",//必填
                PI_KSRQ="",//必填
                PI_JSRQ = "",//必填

            });
            textBox1.Text = _single.SingleMonthSettlement(param, new HisBaseParam());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            BaseConnect.Connect();
            var param = JsonConvert.SerializeObject(new SingleMonthSettlementCancelParam()
            {
                PI_BAE007="",//必填
                PI_CKA549 = "",//必填
                PI_CKE544 = "",//必填


            });
            textBox1.Text = _single.SingleMonthSettlementCancel(param, new HisBaseParam());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            BaseConnect.Connect();
            var param = JsonConvert.SerializeObject(new OutpatientConsultationFeeSettlementParam()
            {   PI_SFBZ= textBox2.Text,//必填
                PI_CRBZ = "1",//必填
                PI_JBR = "李茜",//必填
                PI_ZCFY = 20.00 //必填
            });
            textBox1.Text = _single.OutpatientConsultationFeeSettlement(param, new HisBaseParam());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            BaseConnect.Connect();
            var param = JsonConvert.SerializeObject(new OutpatientConsultationFeeCancelParam()
            {
                PI_BAE007 = "",//必填
            });
            textBox1.Text = _single.OutpatientConsultationFeeCancel(param, new HisBaseParam());
        }

        private void button17_Click(object sender, EventArgs e)
        {
            BaseConnect.Connect();
            var param = JsonConvert.SerializeObject(new OutpatientConsultationFeeQueryParam()
            {
                PI_AAC001 = "",//必填
                PI_BAE007 = "",//必填
            });
            textBox1.Text = _single.OutpatientConsultationFeeQuery(param, new HisBaseParam());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            BaseConnect.Connect();
            var paramEntity = new UserInfoParam();
            paramEntity.PI_CRBZ = "1";
            paramEntity.PI_SFBZ = textBox2.Text;

            var dataResult = _resident.GetUserInfo(JsonConvert.SerializeObject(paramEntity), new HisBaseParam());
            textBox1.Text = JsonConvert.SerializeObject(dataResult);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form1 f2 = new Form1();
            f2.Show();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            Form1 f2 = new Form1();
            f2.Show();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
         
            try
            {
                _keyboard.Start();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
            

        }
       

        private void button12_Click_1(object sender, EventArgs e)
        {

        }
    }
}
