using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BenDing.Service;
using BenDingActive.Model;
using BenDingActive.Model.Dto.Workers;
using BenDingActive.Model.Params.Web;
using BenDingActive.Model.Params.Workers;
using BenDingActive.Xml;
using Newtonsoft.Json;

namespace BenDingForm
{
    public partial class WorkersForm : Form
    {
       
        public WorkersForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login();
            var data = WorkersMedicalInsurance.ReadCardInfo_cxjb("100", "222222");
            textBox1.Text = "";
            textBox1.Text = data.ToString();
            // string pi_name;
            // string pi_pwd;
            // StringBuilder po_grshbzh = new StringBuilder(1024);
            // StringBuilder po_xm = new StringBuilder(1024);
            // StringBuilder po_xb = new StringBuilder(1024);
            // StringBuilder po_csny = new StringBuilder(1024);
            // StringBuilder po_zglb = new StringBuilder(1024);
            // StringBuilder po_lxdz = new StringBuilder(1024);
            // StringBuilder po_lxdh = new StringBuilder(1024);
            // StringBuilder po_sfzh = new StringBuilder(1024);
            // StringBuilder po_sznl = new StringBuilder(1024);
            // StringBuilder po_dwmc = new StringBuilder(1024);
            // StringBuilder po_cbzt = new StringBuilder(1024);
            // StringBuilder po_grzhye = new StringBuilder(1024);
            // StringBuilder po_ybtszt = new StringBuilder(1024);
            // StringBuilder po_ybbxztsm = new StringBuilder(1024);
            // StringBuilder po_fhz = new StringBuilder(1024);
            // StringBuilder po_msg = new StringBuilder(1024);
            // string pi_sfbz = "6217212314001720070";
            // string pi_crbz = "1";
            // string pi_xzqh = "";
            //var data= WorkersMedicalInsurance.hqgrjbzl(pi_sfbz, pi_crbz, pi_xzqh, po_grshbzh, po_xm, po_xb, po_csny, po_zglb, po_lxdz, po_lxdh, po_sfzh, po_sznl, po_dwmc, po_cbzt, po_grzhye, po_ybtszt, po_ybbxztsm, po_fhz, po_msg);

        }
        public void Login()
        {
            var data = WorkersMedicalInsurance.ConnectAppServer_cxjb("cpq2677", "888888");
        }

        private void button2_Click(object sender, EventArgs e)
        { //G52.101 舌咽神经痛 icd-10
            string baseParam = GetBaseParam();
            Login();
             var param = new HospitalizationRegisterWorkersParam()
             {
                 Pi_sfbz= "511526198702015513",
                 Pi_crbz="2",
                 Pi_xzqh="511502",
                 Pi_yllb = "21",
                 Pi_ryrq = "20190919",
                 Pi_icd10 = "G52.101",
                 Pi_ryzd = "舌咽神经痛",
                 Pi_zybq = "内科",
                 Pi_cwh="22",
                 Pi_yyzyh = Convert.ToDateTime(DateTime.Now).ToString("yyyyMMddHHmmss") + "510726",//20位 入院日期+组织机构后四位
                 Pi_jbr = "李茜"
             };//44115784
            var poZyh=new StringBuilder(1024);
            var poSpbh = new StringBuilder(1024);
            var poBnyzycs = new StringBuilder(1024);
            var poBntcyzfje = new StringBuilder(1024);
            var po_bntckzfje = new StringBuilder(1024);
            var poFhz = new StringBuilder(1024);
            var poMsg = new StringBuilder(1024);
            var resultData= WorkersMedicalInsurance.zydj(
               param.Pi_sfbz,
               param.Pi_crbz,
               param.Pi_xzqh,
               param.Pi_yyzyh,
               param.Pi_yllb,
               param.Pi_ryrq,
               param.Pi_icd10,
               param.Pi_icd10_2,
               param.Pi_icd10_3,
               param.Pi_ryzd,
               param.Pi_zybq,
               param.Pi_cwh,
               param.Pi_yyzyh,
               param.Pi_jbr,
               poZyh,
               poSpbh,
               poBnyzycs,
               poBntcyzfje,
               po_bntckzfje,
               poFhz,
               poMsg
               );
            if (resultData == 1)
            {
                if (poFhz.ToString() == "1")
                {
                    var Id = Guid.NewGuid().ToString("N");
                    var sendParam = new MedicalInsuranceDataAllWebParam()
                    {
                        DataAllId= Id,
                        BusinessId = Id,
                        CreateUserId = "E075AC49FCE443778F897CF839F3B924",
                        DataId = Id,
                        DataType = "入院登记",
                        HisMedicalInsuranceId = Id,
                        IdCard = "6217212314001720070",
                        OrgCode = "51072600000000000000000513435964",
                        ParticipationJson = "",
                        Remark = "",
                        ResultDataJson = ""

                    };
                    var data = HttpHelp.HttpPost(JsonConvert.SerializeObject(sendParam), "SaveMedicalInsuranceDataAll", new ApiJsonResultData());

                }
            }

          

        }

        public string GetBaseParam()
        {     string baseParam = JsonConvert.SerializeObject(new HisBaseParam()
            {
                  YbOrgCode = "99999",
                    EmpID = "E075AC49FCE443778F897CF839F3B924",
                    OrgID = "51072600000000000000000513435964",
                    BID = "FFE6ADE4D0B746C58B972C7824B8C9DF",
                    BsCode = "21",
                    TransKey = "FFE6ADE4D0B746C58B972C7824B8C9DF"
                });
            return baseParam;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            SaveDataInfo("入院登记","","");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var po_pch = new StringBuilder(1024);
            var po_fhz = new StringBuilder(1024);
            var po_msg = new StringBuilder(1024);
            var param = new PrescriptionUploadWorkersDetailListParam();
            var paramList=new List<PrescriptionUploadWorkersDetailParam>();
            paramList.Add(new PrescriptionUploadWorkersDetailParam()
            {   AKB020= "2677",
                AKC190 = "4411578410000234",//院内住院号
                AKC220= "511912",
                AKC584=1,
                AKC222= "YLYY0127",
                AKC515= "10000234",
                AKC221= "2019-09-20",
                AAE040 = "2019-09-20",
                AKA063="22",
                AKC223= "盆疗",
                AKA065="3",
                AKC225= 100.00,
                AKC226=1.00,
                AKC227=100.00,
                AKC228= 100.00,
                AKA071= 0.00,
                AKA072="0",
                AKA073="0",
                AKA074= "项",
                AKA067 = "项",
                AKC229=0
            });
            paramList.Add(new PrescriptionUploadWorkersDetailParam()
            {
                AKB020 = "2677",
                AKC190 = "4411578410000234",//院内住院号
                AKC220 = "511912",
                AKC584 = 2,
                AKC222 = "110200005",
                AKC515 = "10015333",
                AKC221 = "2019-09-20",
                AAE040 = "2019-09-20",
                AKA063 = "27",
                AKC223 = "住院诊查费",
                AKA065 = "1",
                AKC225 = 3.40,
                AKC226 = 1.00,
                AKC227 = 3.40,
                AKC228 = 100.00,
                AKA071 = 0.00,
                AKA072 = "0",
                AKA073 = "0",
                AKA074 = "项",
                AKA067 = "项",
                AKC229 = 0
            });
            param.ROW = paramList;
            if (XmlHelp.SavePrescriptionUploadWorkersParam(param, "44115784"))
            {
                Login();
                var data = WorkersMedicalInsurance.xmlcfmxcs("44115784", "511502", po_pch, po_fhz, po_msg);
                if (data == 1)
                {
                    SaveDataInfo("入院登记",
                        "",
                        JsonConvert.SerializeObject(new PrescriptionUploadWorkersDto()
                        {
                            PO_FHZ = po_fhz.ToString(),
                            PO_MSG = po_msg.ToString(),
                            Po_pch = po_pch.ToString(),
                        }));
                }
            }
        }

        public void SaveDataInfo(string dataType,string participationJson,string resultDataJson)
        {
            var Id = Guid.NewGuid().ToString("N");
            var sendParam = new MedicalInsuranceDataAllWebParam()
            {
                DataAllId = Id,
                BusinessId = Id,
                CreateUserId = "E075AC49FCE443778F897CF839F3B924",
                DataId = Id,
                DataType = dataType,
                HisMedicalInsuranceId = Id,
                IdCard = "6217212314001720070",
                OrgCode = "51072600000000000000000513435964",
                ParticipationJson = participationJson,
                Remark = "",
                ResultDataJson = resultDataJson

            };
            var data = HttpHelp.HttpPost(JsonConvert.SerializeObject(sendParam),
                "SaveMedicalInsuranceDataAll", new ApiJsonResultData());

        }
    }
}
