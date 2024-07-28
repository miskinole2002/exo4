using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;

namespace GUI
{
    public partial class Form1 : Form
    {
        private WebClient Wb;

        private int Status;

        private String z1;
        private String z2;
        private String z3;
        private String z4;

        public Form1()
        {
            InitializeComponent();

            this.Wb = new WebClient();
            string status = this.Wb.DownloadString("http://localhost:60320/Alarm/GetAllSystInfos");

            StateSys();

            //Console.WriteLine(status);
        }
        private void StateSys()
        {
            List<Syst> list = new List<Syst>();
            
            this.Wb = new WebClient();
            string status = this.Wb.DownloadString("http://localhost:60320/Alarm/GetAllSystInfos");
            
            
             list = JsonConvert.DeserializeObject<List<Syst>>(status);
            foreach ( Syst item in list )
            {
                Status = item.Status;
                z1=item.Z1;
                z2=item.Z2;
                z3 = item.Z3;
                z4 = item.Z4;
            }

          //  Console.WriteLine(Status+'\n'+z1+ '\n'+z2+ '\n'+z3+ '\n'+z4);
          
            

            //  string Stat = State.Z1;

            if(Status == 1)
            {

                LblO.BackColor = Color.Red;
                if (z1 == "on")
                {
                    Z1.BackColor = Color.Red;
                }
                if (z2=="on")
                {
                    Z2.BackColor = Color.Red;

                }
                if (z3 == "on")
                {
                    Z3.BackColor = Color.Red;

                }
                if (z4 == "on")
                {
                    Z4.BackColor = Color.Red;

                }
            }
            else
            {
                LblO.BackColor = Color.Gainsboro;
                Z1.BackColor = Color.Green;
                Z2.BackColor = Color.Green;
                Z3.BackColor = Color.Green;
                Z4.BackColor = Color.Green;


            }

            //Z1.BackColor=Color.Orange;
            //Z2.BackColor = Color.Orange;
            //Z3.BackColor = Color.Orange;
            //Z4.BackColor = Color.Orange;






        }

        private void Activate_Click(object sender, EventArgs e)
        {
            this.Wb = new WebClient();
            int status = 1;
            string URI = "http://localhost:60320/Alarm/UpdateStateGui";

            string Params = "Status=" + status;
            Wb.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";

            string res = Wb.UploadString(URI, Params);
          //  LblO.BackColor = Color.Green;
            StateSys();
            // Console.WriteLine(res);
        }

        private void Deact_Click(object sender, EventArgs e)
        {

            this.Wb = new WebClient();
            int status = 0;
            string URI = "http://localhost:60320/Alarm/UpdateStateGui";

            string Params = "Status="+status;
            Wb.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";

            string res =Wb.UploadString(URI, Params);
            StateSys();

            //  LblO.BackColor = Color.Red;
            //  Console.WriteLine(res);
        }

        private void rest_Click(object sender, EventArgs e)
        {
            this.Wb = new WebClient();
            int status = 0;
            string URI = "http://localhost:60320/Alarm/UpdateStateGui";

            string Params = "Status=" + status;
            Wb.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";

            string res = Wb.UploadString(URI, Params);
            LblO.BackColor = Color.Red;

            //  Console.WriteLine(res);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LblO_Click(object sender, EventArgs e)
        {

        }
    }
}

