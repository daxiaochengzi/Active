
using BenDingActive.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BenDing.Service;
using BenDingActive.Model;
using BenDingActive.Model.Dto;
using BenDingActive.Model.Params;
using Newtonsoft.Json;

namespace BenDingForm
{
    public partial class Form1 : Form
    {
       
        ResidentMedicalInsuranceService _residentd = new ResidentMedicalInsuranceService();
        private ResidentMedicalInsuranceTest _residentdTest = new ResidentMedicalInsuranceTest();
        HisBaseParam _hisBase=new HisBaseParam()
        {

            YbOrgCode = "99999",
            EmpID = "E075AC49FCE443778F897CF839F3B924",
            OrgID = "51072600000000000000000513435964",
            BID = "6721F4DA50B349AF9F5F387707C1647A",
            BsCode = "23",
            TransKey = "6721F4DA50B349AF9F5F387707C1647A"
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {    //登录账户:cpq2677
             //    //居民保险
             //    //YbOrgCode = 99999
             //    //OrgID = 51072600000000000000000513435964
             //    //EmpID = E075AC49FCE443778F897CF839F3B924
             //    //BID = FFE6ADE4D0B746C58B972C7824B8C9DF &
             //    //      BsCode = 21
             //    //TransKey = FFE6ADE4D0B746C58B972C7824B8C9DF
             //    //伊珍敏
             //    //512501195802085180
             //    string baseParam = JsonConvert.SerializeObject(new HisBaseParam()
             //    {
             //        YbOrgCode = "99999",
             //        EmpID = "E075AC49FCE443778F897CF839F3B924",
             //        OrgID = "51072600000000000000000513435964",
             //        BID= "FFE6ADE4D0B746C58B972C7824B8C9DF",
             //        BsCode = "21",
             //        TransKey = "FFE6ADE4D0B746C58B972C7824B8C9DF"
             //    });
             //    var paramEntity = new UserInfoParam();
             //    paramEntity.PI_CRBZ = "1";
             //    paramEntity.PI_SFBZ = "512501195802085180";

            //    var data = _residentd.GetUserInfo(JsonConvert.SerializeObject(paramEntity), JsonConvert.DeserializeObject<HisBaseParam>(baseParam));
            Login();
            var data = _residentdTest.GetUserInfo();
            textBox1.Text = JsonConvert.SerializeObject(data) ;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {  //G52.101 舌咽神经痛 icd-10
            Login();
            var data = _residentdTest.GetUserInfo();
            string param = JsonConvert.SerializeObject(new HospitalizationRegisterParam()
            {
                PI_SFBZ= data.PO_SFZH,
                PI_CRBZ="1",//1为身份证
                PI_YLLB="11",//普通入院
                PI_RYRQ= "20190919",
                PI_ICD10= "G52.101",//J40.x01 5229
                PI_CWH = "内科5号床",
                PI_RYZD= "舌咽神经痛",
                PI_YYZYH=  Convert.ToDateTime(DateTime.Now).ToString("yyyyMMddHHmmss")+ "510726",//20位 入院日期+组织机构后四位
                PI_JBR = "李茜",//20位
            });
            _residentd.HospitalizationRegister(param, new HisBaseParam());
      
        }
        private void button6_Click(object sender, EventArgs e)
        {
            //var ddd =new StringBuilder().Append("cpq2677"); //"cpg2677";
            //var ddds = new StringBuilder().Append("cbwsy16");
           // string pwd = textBox3.Text.ToString() =="" ? "cbwsy16" : textBox3.Text.ToString();
            var data= WorkersMedicalInsurance.ConnectAppServer_cxjb("cpq2677", "888888");
            textBox1.Text = data.ToString();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            var dd = TestEg.Test(22, 66);
            var ddd = new StringBuilder(32);
            StringBuilder str = new StringBuilder(32);
            //var retval = TestEg.GetRates( str,"妈妈的");
          
            var retvaldd = TestEg.GetRatesString(str, ddd.Append("wc"));
          
        }
        private void button8_Click(object sender, EventArgs e)
        {
            var data = WorkersMedicalInsurance.DisConnectAppServer_cxjb();
            textBox1.Text = data.ToString();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            
        }
        public void Login()
        {
            var data = WorkersMedicalInsurance.ConnectAppServer_cxjb("cpq2677", "888888");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Login();
            var cFmxList = new List<PrescriptionUploadCFMX>();
            cFmxList.Add(new PrescriptionUploadCFMX()
            {
                CO ="0",
                AKC220= "29115",
                AKC584="1",
                AKC222= "B68000833",
                AKC515= "29115",
                AKC221= "2019-09-19 13:01:01",
                AAE040= "2019-09-19 13:01:02",
                AKA063= "11", //西药费
                AKC223= "劳拉西泮",
                AKA065= "2",//1:甲类  2：乙类  3：丙类
                AKC225="0.10",
                AKC226 = "1",
                AKC227="0.10",
                AKC228="0.01",
                AKA070="口服",
                AKA071="0",
                AKA072="1",
                AKA073="直接口服",
                AKA074="",
                AKA067="",
                AKC229="0",
                CKC691="007",
                CKE841="1",
                CKE843 = "22",
                CKE844= "20190919130101"
            });
            cFmxList.Add(new PrescriptionUploadCFMX()
            {
                CO = "0",
                AKC220 = "29115",
                AKC584 = "2",
                AKC222 = "B68000834",
                AKC515 = "29116",
                AKC221 = "2019-09-19 13:01:01",
                AAE040 = "2019-09-19 13:01:02",
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
                CKC691 = "007",
                CKE841 = "1",
                CKE843 = "22",
                CKE844 = "20190919130101"
            });
            string param = JsonConvert.SerializeObject( new PrescriptionUploadParam
            {
                PI_JBR = "李茜",
                PI_ZYH = "44115784",
                CFMX = cFmxList
            });

            var data = _residentd.PrescriptionUpload(param, new HisBaseParam());

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Login();
            string param = JsonConvert.SerializeObject(new PrescriptionDetailQueryParam()
            {
                PI_ZYH = "44115756"
            });
            var data = _residentd.PrescriptionDetailQuery(param, new HisBaseParam());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Login();
            string param = JsonConvert.SerializeObject(new BatchConfirmationParam()
            {
                PI_ZYH = "44115756",
                PI_PCH= "136412024",
                PI_QRLX="1",
                PI_JBR = "李茜",
            });
            
            var data = _residentd.BatchConfirmation(param, new HisBaseParam());
        }

        private void button12_Click(object sender, EventArgs e)
        {

            Login();
            string param = JsonConvert.SerializeObject(new BatchUnConfirmationParam()
            {
                PI_ZYH = "44115756",
            });

            var data = _residentd.BatchUnConfirmation(param, new HisBaseParam());
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Login();
            string param = JsonConvert.SerializeObject(new CostPreSettlementParam()
            {
                PI_ZYH = "44115756",
                PI_CYRQ= "20190920"
            });

            var data = _residentd.CostPreSettlement(param, new HisBaseParam());
            textBox1.Text = data;
        }

        private void button14_Click(object sender, EventArgs e)
        {

            Login();
            string param = JsonConvert.SerializeObject(new CostSettlementParam()
            {
                PI_ZYH = "44115756",
                PI_CYRQ = "20190919",
                PI_CZY= "李茜",
                PI_CYQK="1",
                PI_ICD10= "G52.101",
                PI_CYZD= "舌咽神经痛"

            });

            var data = _residentd.CostSettlement(param, new HisBaseParam());
            textBox1.Text = data;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Login();
            string param = JsonConvert.SerializeObject(new CostSettlementQueryParam()
            {
                PI_ZYH = "44115756",
              
            });

            var data = _residentd.CostSettlementQuery(param, new HisBaseParam());
            textBox1.Text = data;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Login();
            string param = JsonConvert.SerializeObject(new HospitalizedSettlementCancelParam()
            {
                PI_ZYH = "44115756",
                PI_DJH= "47712004",
                PI_QXCD="1",
                PI_JBR = "李茜",

            });

            var data = _residentd.HospitalizedSettlementCancel(param, new HisBaseParam());
            textBox1.Text = data;
        }

        private void button19_Click(object sender, EventArgs e)
        {

            Login();
            string param = JsonConvert.SerializeObject(new IdentificationSpecialDiseasesQueryParam()
            {
                PI_SFBZ = "512527196604306139",
                PI_CRBZ="1",

            });

            var data = _residentd.IdentificationSpecialQuery(param, new HisBaseParam());
            textBox1.Text = data;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Login();
            string param = JsonConvert.SerializeObject(new IdentificationSpecialDiseasesParam()
            {
                PI_SFBZ = "512527196604306139",
                PI_CRBZ = "1",
                PI_AAE005 = "159286413166",
                PI_AAE006 = "宜宾市翠屏区",
                PI_CKZ736="通过",
                PI_AAE810="20190919",
                PI_AKB021_1 = "",
                PI_CKZ735= "108"//108	类风湿关节炎


            });
            var data = _residentd.IdentificationSpecialQuery(param, new HisBaseParam());
            textBox1.Text = data;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Login();
            string param = JsonConvert.SerializeObject(new IdentificationSpecialDiseasesCancelParam()
            {
                PI_AKC603 = "1000000035",
                PI_AAE013="测试取消"


            });
            var data = _residentd.IdentificationSpecialDiseasesCancel(param, new HisBaseParam());
            textBox1.Text = data;
        }

        private void button20_Click(object sender, EventArgs e)
        {
           
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Login();
            var piFymx = new List<IdentificationSpecialSettlementPI_FYMXParam>();
            piFymx.Add(new IdentificationSpecialSettlementPI_FYMXParam()
            { BKE019="4",
              AKE001= "B68000822",
              AKE002= "氯普噻吨",
              CKE521="1.00",
              AKC226="1.00",
              CKC526="1.00",
              CKA588= "口服",
              BKC045="口服",
              BKC046="吉林",
              CKC691="555"

            });
            piFymx.Add(new IdentificationSpecialSettlementPI_FYMXParam()
            {
                BKE019 = "5",
                AKE001 = "B68000822",
                AKE002 = "氯普噻吨",
                CKE521 = "1.00",
                AKC226 = "1.00",
                CKC526 = "1.00",
                CKA588 = "口服",
                BKC045 = "口服",
                BKC046 = "吉林",
                CKC691 = "555"

            });
            string param = JsonConvert.SerializeObject(new IdentificationSpecialSettlementParam()
            {   PI_AKC190= "201909191301111",//必须传
                PI_SFBZ = "1021593295",//512527196604306139个人编码1021593295
                PI_CRBZ = "2",
                PI_CKZ735_1= "109",
                PI_AKE010= "20190919130101",
                PI_NUM="2.00",
                PI_CKC501="2.00",
                PI_FYMX= piFymx,
            });
            var data = _residentd.IdentificationSpecialSettlement(param, new HisBaseParam());
            textBox1.Text = data;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Login();
            string param = JsonConvert.SerializeObject(new IdentificationSpecialDownloadParam()
            {
                PI_CKZ735="",
                PI_AAE036="",
                PI_CXLB ="2",
                PI_PAGESIZE="100",
                PI_PAGE="2"

            });
            var data = _residentd.IdentificationSpecialDownload(param, new HisBaseParam());
            textBox1.Text = data;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Login();
            var piFymx = new List<IdentificationSpecialSettlementPI_FYMXParam>();
            piFymx.Add(new IdentificationSpecialSettlementPI_FYMXParam()
            {
                BKE019 = "4",
                AKE001 = "B68000822",
                AKE002 = "氯普噻吨",
                CKE521 = "1.00",
                AKC226 = "1.00",
                CKC526 = "1.00",
                CKA588 = "口服",
                BKC045 = "口服",
                BKC046 = "吉林",
                CKC691 = "555"

            });
            piFymx.Add(new IdentificationSpecialSettlementPI_FYMXParam()
            {
                BKE019 = "5",
                AKE001 = "B68000822",
                AKE002 = "氯普噻吨",
                CKE521 = "1.00",
                AKC226 = "1.00",
                CKC526 = "1.00",
                CKA588 = "口服",
                BKC045 = "口服",
                BKC046 = "吉林",
                CKC691 = "555"

            });
            string param = JsonConvert.SerializeObject(new IdentificationSpecialSettlementParam()
            {
                PI_AKC190 = "201909191301111",//必须传
                PI_SFBZ = "1021593295",//512527196604306139个人编码1021593295
                PI_CRBZ = "2",
                PI_CKZ735_1 = "109",
                PI_AKE010 = "20190919130101",
                PI_NUM = "2.00",
                PI_CKC501 = "2.00",
                PI_FYMX = piFymx,
            });
            var data = _residentd.IdentificationSpecialReimbursement(param, new HisBaseParam());
            textBox1.Text = data;
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            Login();
            string param = JsonConvert.SerializeObject(new ProjectDownloadParam()
            {
                PI_AAE036 = "",
                PI_AKE001 = "",
                PI_CKE897 = "0",
                PI_PAGESIZE = "100",
                PI_PAGE = "2",
                PI_CXLB = "2"//1获取总条数PO_CNT， 2实际数据

            });
            var baseParam = new HisBaseParam()
            {
                YbOrgCode = "99999",
                EmpID = "E075AC49FCE443778F897CF839F3B924",
                OrgID = "51072600000000000000000513435964",
                BID = "FFE6ADE4D0B746C58B972C7824B8C9DF",
                BsCode = "21",
                TransKey = "FFE6ADE4D0B746C58B972C7824B8C9DF"
            };
            _residentd.ProjectDownload(param, baseParam);
        }
    }


}
