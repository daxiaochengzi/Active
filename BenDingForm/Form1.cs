
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
using BenDingActive.Model.Params;
using Newtonsoft.Json;

namespace BenDingForm
{
    public partial class Form1 : Form
    {
       
        ResidentMedicalInsuranceService _residentd = new ResidentMedicalInsuranceService();
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
        {    //登录账户:cpg2677
            //居民保险
            //YbOrgCode = 99999
            //OrgID = 51072600000000000000000513435964
            //EmpID = E075AC49FCE443778F897CF839F3B924
            //BID = FFE6ADE4D0B746C58B972C7824B8C9DF &
            //      BsCode = 21
            //TransKey = FFE6ADE4D0B746C58B972C7824B8C9DF
            //伊珍敏
            //512501195802085180
            string baseParam = JsonConvert.SerializeObject(new HisBaseParam()
            {
                YbOrgCode = "99999",
                EmpID = "E075AC49FCE443778F897CF839F3B924",
                OrgID = "51072600000000000000000513435964",
                BID= "FFE6ADE4D0B746C58B972C7824B8C9DF",
                BsCode = "21",
                TransKey = "FFE6ADE4D0B746C58B972C7824B8C9DF"
            });
            var paramEntity = new UserInfoParam();
            paramEntity.PI_CRBZ = "1";
            paramEntity.PI_SFBZ = "512501195802085180";
          
            var data = _residentd.GetUserInfo(JsonConvert.SerializeObject(paramEntity), JsonConvert.DeserializeObject<HisBaseParam>(baseParam));
            textBox1.Text = data;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
           var ddd =new StringBuilder().Append("cpg2677"); //"cpg2677";
           var ddds = new StringBuilder().Append("cbwsy16");
            string pwd = textBox3.Text.ToString() =="" ? "cbwsy16" : textBox3.Text.ToString();
           var data= WorkersMedicalInsurance.ConnectAppServer_cxjb("cpg2677", pwd);
            textBox1.Text = data.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var dd = TestEg.Test(22, 66);
            var ddd = new StringBuilder(32);
            StringBuilder str = new StringBuilder(32);
            //var retval = TestEg.GetRates( str,"妈妈的");
            string strData;
            var retvaldd = TestEg.GetRatesString(str, ddd.Append("wc"));
            textBox2.Text = str.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var data = WorkersMedicalInsurance.DisConnectAppServer_cxjb();
            textBox1.Text = data.ToString();
        }
    }


}
