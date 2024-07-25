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

namespace GUI
{
    public partial class Form1 : Form
    {
        private WebClient Wb;
        public Form1()
        {
            InitializeComponent();
        }

        private void Activate_Click(object sender, EventArgs e)
        {
            this.Wb = new WebClient();
            int status = 1;
            string URI = "http://localhost:60320/Alarm/UpdateStateGui";

            string Params = "Status=" + status;
            Wb.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";

            string res = Wb.UploadString(URI, Params);
            LblO.BackColor = Color.Green;
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
            LblO.BackColor = Color.Red;
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
    }
}

//this.Wb = new WebClient();
//string Status = this.Wb.DownloadString("http://localhost:60320/Alarm/GetAllSystInfos");

//Console.WriteLine(Status);