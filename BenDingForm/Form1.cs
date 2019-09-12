﻿
using BenDingActive.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BenDingActive.Model;
using BenDingActive.Model.Params;
using Newtonsoft.Json;

namespace BenDingForm
{
    public partial class Form1 : Form
    {
        ResidentMedicalInsurance _residentd = new ResidentMedicalInsurance();
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
        {
            //居民保险
            string baseParam = JsonConvert.SerializeObject(new HisBaseParam()
            {
                YbOrgCode = "99999",
                EmpID = "E075AC49FCE443778F897CF839F3B924",
                OrgID = "51072600000000000000000513435964",
                BID= "6721F4DA50B349AF9F5F387707C1647A",
                BsCode = "23",
                TransKey = "6721F4DA50B349AF9F5F387707C1647A"
            });
            var paramEntity = new UserInfoParam();
            paramEntity.PI_CRBZ = "1";
            paramEntity.PI_SFBZ = "513701199002124815";
          
            var data = _residentd.GetUserInfo(JsonConvert.SerializeObject(paramEntity), JsonConvert.DeserializeObject<HisBaseParam>(baseParam));
            textBox1.Text = data;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }


}