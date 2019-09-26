using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BenDingActive.Model;
using BenDingActive.Model.Params.DifferentPlaces;
using BenDingActive.Service;
using BenDingActive.Xml;
using Newtonsoft.Json;

namespace BenDingForm
{
    public partial class DifferentPlacesForm : Form
    {
        MedicalInsuranceDifferentPlacesService _differentPlaces=new MedicalInsuranceDifferentPlacesService();

        public DifferentPlacesForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BaseConnect.DifferentPlacesConnect();
            var param =JsonConvert.SerializeObject(new UserInfoDifferentParam()
            {
                PI_CRBZ = "1",
                PI_SFBZ = ""

            }) ;
            textBox1.Text=  _differentPlaces.DifferentPlacesGetUserInfo(param, new HisBaseParam());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BaseConnect.DifferentPlacesConnect();
            var data = BaseConnect.GetDifferentPlaces();
            var param = JsonConvert.SerializeObject(new HospitalizationRegisterDifferentParam()
            {////G52.101 舌咽神经痛 icd-10
                aac001 = data.aac001,
                aac002 = data.aac002,
                aaz500 = "*",
                aka042="1",
                baa008= data.baa008,
                bkc018="内科",
                akc193= "G52.101",
                bkc020= "舌咽神经痛",
                bkc015="7777",
                akc190= Convert.ToDateTime(DateTime.Now).ToString("yyyyMMddHHmmss") + "510726",//20位 入院日期+组织机构后四位
                aae030 = Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd HH:mm:ss"),
                bkc019="5号床",
                ake022_bm= "7777",
                ake022= "李茜",
                bkc017= "李茜",
                aae004="成中荣",
                aae005= "15928643162"

            });
            textBox1.Text = _differentPlaces.DifferentPlacesHospitalizationRegister(param, new HisBaseParam());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BaseConnect.DifferentPlacesConnect();
            var data = BaseConnect.GetDifferentPlaces();
            var param = JsonConvert.SerializeObject(new DifferentPlacesHospitalizationCancelParam()
            {////G52.101 舌咽神经痛 icd-10
                baa008= data.baa008,
                aac001= data.aac002,
                aaz217= data.aaz217,
                aac002= data.aac002,
                aac003= data.aac003,
                bkc131= "李茜"

            });
            textBox1.Text = _differentPlaces.DifferentPlacesHospitalizationCancel(param, new HisBaseParam());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BaseConnect.DifferentPlacesConnect();
            var data = BaseConnect.GetDifferentPlaces();
            var param = JsonConvert.SerializeObject(new DifferentLeaveHospitalParam()
            {////G52.101 舌咽神经痛 icd-10
                baa008 = data.baa008,
                aac001 = data.aac001,
                aaz217 = data.aaz217,
                bkc015= "7777",
                akc190="*",
                bkc031="2",
                aae031 = Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd HH:mm:ss"),
                akc196= "G52.101",
                bkc027= "舌咽神经痛",
                bkc024= "李茜"




            });
            textBox1.Text = _differentPlaces.DifferentLeaveHospital(param, new HisBaseParam());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BaseConnect.DifferentPlacesConnect();
            var data = BaseConnect.GetDifferentPlaces();
            var param = JsonConvert.SerializeObject(new DifferentLeaveHospitalReturnParam()
            {////G52.101 舌咽神经痛 icd-10
                baa008 = data.baa008,
                aac001 = data.aac001,
                aaz217 = data.aaz217,
                aac002 = data.aac002,
                aac003 = data.aac003,
              bkc131 = data.bkc131
     

            });
            textBox1.Text = _differentPlaces.DifferentLeaveHospitalReturn(param, new HisBaseParam());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            BaseConnect.DifferentPlacesConnect();
            var rowList = new List<Uploadrow>() ;
            rowList.Add(new Uploadrow()
            {   aae072="20190926001",
                bkc127="1",
                bke019="1",
                aaz231="*",
                bke026="*",
                bke027="*",
                ake003="*",
                akc226=1,
                akc225=2,
                akc264=2,
                aka067="瓶",
                aka074_yn="盒",
                aka070_yn="口服",
                bkc040= "20190926",
                xzyyspbz= "1"
            });
            rowList.Add(new Uploadrow()
            {
                aae072 = "20190926001",
                bkc127 = "1",
                bke019 = "2",
                aaz231 = "*",
                bke026 = "*",
                bke027 = "*",
                ake003 = "*",
                akc226 = 1,
                akc225 = 2,
                akc264 = 2,
                aka067 = "瓶",
                aka074_yn = "盒",
                aka070_yn = "口服",
                bkc040 = "20190926",
                xzyyspbz = "1"
            });
            var uploadData = new Uploadcfmx()
            {
                DATAROW =new Uploaddatarow()
                {
                    ROW= rowList
                }
            };
            var data = BaseConnect.GetDifferentPlaces();
            var param = JsonConvert.SerializeObject(new DifferentPlacesPrescriptionUploadParam()
            {////G52.101 舌咽神经痛 icd-10
                baa008 = data.baa008,
                aac001 = data.aac001,
                aaz217 = data.aaz217,
              bkc131 = data.bkc131,
                nums=2,


            });
            textBox1.Text = _differentPlaces.DifferentPlacesPrescriptionUpload(param, new HisBaseParam());
        }

        private void button16_Click(object sender, EventArgs e)
        {
            BaseConnect.DifferentPlacesConnect();
            var data = BaseConnect.GetDifferentPlaces();
            var param = JsonConvert.SerializeObject(new DifferentPlacesCostPreSettlementParam()
            {////G52.101 舌咽神经痛 icd-10
                baa008 = data.baa008,
                aac001 = data.aac001,
                aaz217 = data.aaz217,
              bkc131 = data.bkc131,
                bkc142=0,
                nums=2,
                akc264="*",
            });
            textBox1.Text = _differentPlaces.DifferentPlacesCostPreSettlement(param, new HisBaseParam());
        }

        private void button14_Click(object sender, EventArgs e)
        {
            BaseConnect.DifferentPlacesConnect();
            var data = BaseConnect.GetDifferentPlaces();
            var param = JsonConvert.SerializeObject(new DifferentPlacesCostPreSettlementParam()
            {////G52.101 舌咽神经痛 icd-10
                baa008 = data.baa008,
                aac001 = data.aac001,
                aaz217 = data.aaz217,
              bkc131 = data.bkc131,
                bkc142 = 0,
                nums = 2,
                akc264 = "*",
            });
            textBox1.Text = _differentPlaces.DifferentPlacesCostSettlement(param, new HisBaseParam());
        }

        private void button15_Click(object sender, EventArgs e)
        {
            BaseConnect.DifferentPlacesConnect();
            var data = BaseConnect.GetDifferentPlaces();
            var param = JsonConvert.SerializeObject(new DifferentPlacesHospitalizedSettlementCancelParam()
            {////G52.101 舌咽神经痛 icd-10
                baa008 = data.baa008,
                aac001 = data.aac001,
                aaz217 = data.aaz217,
                aaz216 = "*",
                aac002= data.aac002,
                aac003= data.aac003,

              bkc131 = data.bkc131,

            });
            textBox1.Text = _differentPlaces.DifferentPlacesHospitalizedSettlementCancel(param, new HisBaseParam());
        }

        private void button20_Click(object sender, EventArgs e)
        {
            BaseConnect.DifferentPlacesConnect();
            var data = BaseConnect.GetDifferentPlaces();
            var param = JsonConvert.SerializeObject(new DifferentPlacesDoctorsAdviceUploadParam()
            {////G52.101 舌咽神经痛 icd-10
                baa008 = data.baa008,
                aac001 = data.aac001,
                aaz217 = data.aaz217,
                bkc131 = data.bkc131,
                zyyzmx=new DifferentPlacesDoctorsAdviceZyyzmx()
                {
                    DataRow = new DifferentPlacesDoctorsAdvicedatarow()
                    {
                        Row = new List<DifferentPlacesDoctorsAdviceRow>()
                        {
                            new DifferentPlacesDoctorsAdviceRow()
                            {  bkc127="1",
                               ake099 = "不要乱吃药，不要放弃治疗",
                                bkc048 = "",
                                bkc049 = "*",
                                bkc128 = Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd HH:mm:ss")

                            }
                        }
                    }
                }


            });
            textBox1.Text = _differentPlaces.DifferentPlacesDoctorsAdviceUpload(param, new HisBaseParam());
        }

        private void button18_Click(object sender, EventArgs e)
        {
            BaseConnect.DifferentPlacesConnect();
            var data = BaseConnect.GetDifferentPlaces();
            var param = JsonConvert.SerializeObject(new DifferentPlacesDoctorsAdviceCancelParam()
            {////G52.101 舌咽神经痛 icd-10
                baa008 = data.baa008,
                aac001 = data.aac001,
                aaz217 = data.aaz217,
                Zyyzmx = new DifferentPlacesDoctorsAdviceCancelZyyzmx()
                {
                    DataRow = new DifferentPlacesDoctorsAdviceCancelDataRow()
                    {
                        Row = new List<DifferentPlacesDoctorsAdviceCancelRow>()
                        {
                            new DifferentPlacesDoctorsAdviceCancelRow()
                            {   bkc127="1",
                                bkc129 = Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd HH:mm:ss"),
                                bkc130="数据录入错误",
                                bkc132="李茜"

                            }
                        }
                    }
                }


            });
            textBox1.Text = _differentPlaces.DifferentPlacesDoctorsAdviceCancel(param, new HisBaseParam());
        }

        private void button19_Click(object sender, EventArgs e)
        {
            BaseConnect.DifferentPlacesConnect();
            var data = BaseConnect.GetDifferentPlaces();
            var param = JsonConvert.SerializeObject(new DifferentPlacesMedicalRecordUploadParam()
            {
                baa008 = data.baa008,
                aaz217 = data.aaz217,
                bkc131 = data.bkc131,
                aae036 = Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd HH:mm:ss"),
                filename=""

            });
            textBox1.Text = _differentPlaces.DifferentPlacesMedicalRecordUpload(param, new HisBaseParam());
        }

        private void button17_Click(object sender, EventArgs e)
        {
            BaseConnect.DifferentPlacesConnect();
            var data = BaseConnect.GetDifferentPlaces();
            var param = JsonConvert.SerializeObject(new DifferentPlacesMedicalRecordQueryParam()
            {
                baa008 = data.baa008,
                aaz217 = data.aaz217,
                aac001= data.aac001,
                aac002 = data.aac002,
                akz007 = "*",
                aac003= data.aac003
            });
            textBox1.Text = _differentPlaces.DifferentPlacesMedicalRecordQuery(param, new HisBaseParam());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            BaseConnect.DifferentPlacesConnect();
            var data = BaseConnect.GetDifferentPlaces();
            var param = JsonConvert.SerializeObject(new DifferentPlacesMedicalRecordDeleteParam()
            {
                baa008 = data.baa008,
                aaz217 = data.aaz217,
                aac001 = data.aac001,
                aac002 = data.aac002,
                akz007 = "*",
                aac003 = data.aac003
            });
            textBox1.Text = _differentPlaces.DifferentPlacesMedicalRecordDelete(param, new HisBaseParam());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BaseConnect.DifferentPlacesConnect();
            var data = BaseConnect.GetDifferentPlaces();
            var param = JsonConvert.SerializeObject(new DifferentPlacesIsBackQueryParam()
            {
                baa008 = data.baa008,
                aaz217 = data.aaz217,
                aac001 = data.aac001,
                aac002 = data.aac002,
                aac003 = data.aac003,
                cxlx="*",
                aaz216="*",
            });
            textBox1.Text = _differentPlaces.DifferentPlacesIsBackQuery(param, new HisBaseParam());
        }

        private void button12_Click(object sender, EventArgs e)
        {
            BaseConnect.DifferentPlacesConnect();
            var data = BaseConnect.GetDifferentPlaces();
            var param = JsonConvert.SerializeObject(new DifferentPlacesHospitalizationExamineQueryParam()
            {
                baa008 = data.baa008,
                aaz217 = data.aaz217,

            });
            textBox1.Text = _differentPlaces.DifferentPlacesHospitalizationExamineQuery(param, new HisBaseParam());
        }

        private void button23_Click(object sender, EventArgs e)
        {
            BaseConnect.DifferentPlacesConnect();
            var data = BaseConnect.GetDifferentPlaces();
            var param = JsonConvert.SerializeObject(new DifferentPlacesSettlementPrintParam()
            {
                baa008 = data.baa008,
                aaz217 = data.aaz217,
                aaz216="*",
                bkc131=data.bkc131
              
            });
            textBox1.Text = _differentPlaces.DifferentPlacesSettlementPrint(param, new HisBaseParam());
        }

        private void button24_Click(object sender, EventArgs e)
        {
            //G52.101 舌咽神经痛 icd-10
            BaseConnect.DifferentPlacesConnect();
            var data = BaseConnect.GetDifferentPlaces();
            var disease=new  OutpatientSimulatedSettlementDisease();
            var bkc033 = new OutpatientSimulatedSettlementBkc033();
            var rowList= GetSettlementRowList(); 

            var param = JsonConvert.SerializeObject(new OutpatientSimulatedSettlementParam()
            {
                baa008 = data.baa008,
                aac001 = data.aac001,
                aac002 = data.aac002,
                aac003 = data.aac003,
                akc190 ="*",//20
                aaz500= "*",
                aka130="*",
                bka013="*",
                bka015="*",
                akc193= "G52.101",
                bkc020= "舌咽神经痛",
                Disease = disease,
                Bkc033 = bkc033,
                bkc142=0,//*
                bkc131= data.bkc131,
                aae030= Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd HH:mm: ss"),
                nums=2,
                Mzfymx=new OutpatientSimulatedSettlementMzfymx()
                {
                    DataRow = new OutpatientSimulatedSettlementDataRow()
                    {
                        Row = rowList
                    }
                }




            });
            textBox1.Text = _differentPlaces.OutpatientSimulatedSettlement(param, new HisBaseParam());
        }
        /// <summary>
        /// 获取明细
        /// </summary>
        /// <returns></returns>
        public List<OutpatientSimulatedSettlementRow> GetSettlementRowList()
        {
            var dataResult = new List<OutpatientSimulatedSettlementRow>();
            dataResult.Add(new OutpatientSimulatedSettlementRow()
            {   bke019=1,
                aaz231="*",
                bke026="201909260070",
                bke027="*",
                aka074_yn="*",
                aka070_yn="*",
                aka067_yn="*",
                aka067="个",
                akc226=1.00,
                akc225=0,//*,
                akc264=0,//*
                bkc048="*",
                bkc049="*",
                aaz307="*",
                aae386="*",
                bkc045="口服",
                bkc044=1,
                aka074=100,
                ake003=""
            });
            dataResult.Add(new OutpatientSimulatedSettlementRow()
            {
                bke019 = 2,
                aaz231 = "*",
                bke026 = "2019092600701",
                bke027 = "*",
                aka074_yn = "*",
                aka070_yn = "*",
                aka067_yn = "*",
                aka067 = "个",
                akc226 = 1.00,
                akc225 = 0,//*,
                akc264 = 0,//*
                bkc048 = "*",
                bkc049 = "*",
                aaz307 = "*",
                aae386 = "*",
                bkc045 = "口服",
                bkc044 = 1,
                aka074 = 100,
                ake003 = ""
            });
            return dataResult;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            //G52.101 舌咽神经痛 icd-10
            BaseConnect.DifferentPlacesConnect();
            var data = BaseConnect.GetDifferentPlaces();
            var disease = new OutpatientSimulatedSettlementDisease();
            var bkc033 = new OutpatientSimulatedSettlementBkc033();
            var rowList = GetSettlementRowList();
            var param = JsonConvert.SerializeObject(new OutpatientSettlementParam()
            {
                baa008 = data.baa008,
                aac001 = data.aac001,
                aac002 = data.aac002,
                aac003 = data.aac003,
                akc190 = "*",//20
                aaz500 = "*",
                aka130 = "*",
                bka013 = "*",
                bka015 = "*",
                akc193 = "G52.101",
                bkc020 = "舌咽神经痛",
                Disease = disease,
                Bkc033 = bkc033,
                bkc142 = 0,//*
                bkc131 = data.bkc131,
                aae030 = Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd HH:mm: ss"),
                nums = 2,
                Mzfymx = new OutpatientSimulatedSettlementMzfymx()
                {
                    DataRow = new OutpatientSimulatedSettlementDataRow()
                    {
                        Row = rowList
                    }
                }




            });
            textBox1.Text = _differentPlaces.OutpatientSettlement(param, new HisBaseParam());
        }

        private void button26_Click(object sender, EventArgs e)
        {
            BaseConnect.DifferentPlacesConnect();
            var data = BaseConnect.GetDifferentPlaces();
            var param = JsonConvert.SerializeObject(new OutpatientSettlementCancelParam()
            {
                baa008 = data.baa008,
                aaz217 = data.aaz217,
                aac001 = data.aac001,
                aac002 = data.aac002,
                aac003 = data.aac003,
                bkc131=data.bkc131,
                akc264=0,//*
                aaz216 ="",
                akb068=0,//*,
                akb066 = 0//*


            });
            textBox1.Text = _differentPlaces.OutpatientSettlementCancel(param, new HisBaseParam());
        }

        private void button27_Click(object sender, EventArgs e)
        {
            BaseConnect.DifferentPlacesConnect();
            var data = BaseConnect.GetDifferentPlaces();
            var param = JsonConvert.SerializeObject(new DifferentPlacesRushTransactionParam()
            {
               
                bkc131 = data.bkc131,
                jydm="*",
                jylsh="*",


            });
            textBox1.Text = _differentPlaces.DifferentPlacesRushTransaction(param, new HisBaseParam());
        }

        private void button28_Click(object sender, EventArgs e)
        {
            BaseConnect.DifferentPlacesConnect();
            var data = BaseConnect.GetDifferentPlaces();
            var param = JsonConvert.SerializeObject(new DifferentPlacesCardAuthenticationTransactionParam()
            {
                baa008 = data.baa008,
                aac002 = data.aac002,
                aac003 = data.aac003,
                aaz500="*",
                bkb005="*",
                aaz501="*",
                aab034="*",
                aae120="*",
                aae140="*",
            });
            textBox1.Text = _differentPlaces.DifferentPlacesCardAuthenticationTransaction(param, new HisBaseParam());
        }

        private void button29_Click(object sender, EventArgs e)
        {
            BaseConnect.DifferentPlacesConnect();
            var data = BaseConnect.GetDifferentPlaces();
            var rowList=new List<DifferentPlacesDepartmentInfoUploadRow>();
            var param = JsonConvert.SerializeObject(new DifferentPlacesDepartmentInfoUploadParam()
            {
                nums = 1,
                DataRow=new DifferentPlacesDepartmentInfoUploadDataRow()
                {
                    Row = rowList
                }


            });
            textBox1.Text = _differentPlaces.DifferentPlacesDepartmentInfoUpload(param, new HisBaseParam());
        }

        private void button30_Click(object sender, EventArgs e)
        {
            BaseConnect.DifferentPlacesConnect();
            var data = BaseConnect.GetDifferentPlaces();
            var rowList = new List<DifferentPlacesDoctorInfoUploadRow>();
            rowList.Add(new DifferentPlacesDoctorInfoUploadRow()
            {
                aaz263 = "*",
                aac002 = "",
                aac003 = "*",
                aac006 = "*",
                aac011 = "*",
                aac004 = "*",
                aac005 = "*",
                aaz307 = "*",
                aac014 = "",
                yab029 = "*",
                aaf009 = "",
                ykf011 = "",
                ykf012 = "*",
                aae011 = data.bkc131,
                aae030 = "*",
                aae031 = "*",
                aae100 = "*"
            });
            var param = JsonConvert.SerializeObject(new DifferentPlacesDoctorInfoUploadParam()
            {
                nums = 1,
                DataRow = new DifferentPlacesDoctorInfoUploadDataRow()
                {
                    Row = rowList
                }


            });
            textBox1.Text = _differentPlaces.DifferentPlacesDoctorInfoUpload(param, new HisBaseParam()); ;
        }

        private void button31_Click(object sender, EventArgs e)
        {
           
        }
    }
}
