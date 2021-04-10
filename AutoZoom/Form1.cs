using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Nancy.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;


namespace AutoZoom
{
    public partial class Form1 : Form
    {
        
        public string jsonPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\Classes.json";
        public Form1()
        {
            InitializeComponent();
        }

        

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ClassTime();
            this.label2.Text = "Status: On";
            this.label2.BackColor = System.Drawing.Color.Green;
        }

        private void Info_gbox_Enter(object sender, EventArgs e)
        {

        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void New_butt_Click(object sender, EventArgs e)
        {
            this.New_butt.Enabled = false;
            this.Save_butt.Enabled = true;
            //--------------------------------
            this.Info_gbox.Enabled = true;
            //---------Clear TextBoxes -------
            this.class_textBox1.ResetText();
            this.ml_textBox2.ResetText();
            //this.mt_textBox3.ResetText();
            this.day1_textBox1.ResetText();
            this.day2_textBox2.ResetText();
            //--------------------------------
        }



        private void Save_butt_Click(object sender, EventArgs e)
        {
            if (this.class_textBox1.Text == "")
            {
                MessageBox.Show("You must enter a valid ID!");
                return;
            }

            string subject = this.class_textBox1.Text;

            string hourSTR = this.dateTimePicker1.Value.Hour.ToString();
            string minuteSTR = this.dateTimePicker1.Value.Minute.ToString();

            int hourVar = this.dateTimePicker1.Value.Hour;
            int minuteVar = this.dateTimePicker1.Value.Minute;

            string mDay1Var = this.day1_textBox1.Text;
            string mDay2Var = this.day2_textBox2.Text;

            string meetLink = this.ml_textBox2.Text;

            MessageBox.Show("Saved!");

            var jsonObject = new JObject();
            dynamic classInfo = jsonObject;


            classInfo[subject] = new JArray() as dynamic;
            dynamic info = new JObject();
            info.hour = hourSTR;
            info.minute = minuteSTR;
            info.Day1 = mDay1Var;
            info.Day2 = mDay2Var;
            info.link = meetLink;
            classInfo[subject].Add(info);

            
            Console.WriteLine(classInfo);

            
            if (File.Exists(jsonPath))
            {   
                var oldJSONString = File.ReadAllText(jsonPath, Encoding.UTF8);
                var parsedOldJSON = JValue.Parse(oldJSONString);
                dynamic updateJSON = parsedOldJSON;
                updateJSON[subject] = new JArray() as dynamic;
                updateJSON[subject].Add(info);

                string newClassIn = updateJSON.ToString();
                File.WriteAllText(jsonPath, newClassIn, Encoding.UTF8);
                Console.WriteLine(updateJSON);
            }
            else
            {
                string classIn = classInfo.ToString();
                File.WriteAllText(jsonPath, classIn, Encoding.UTF8);
            }
        }

        #region Geometry Timer
        private System.Threading.Timer timer;
        private void MidnightTimer1(TimeSpan alertTime, string link)
        {
            DateTime current = DateTime.Now;
            TimeSpan timeToGo = alertTime - current.TimeOfDay;
            if (timeToGo < TimeSpan.Zero)
            {
                return;//time already passed
            }
            this.timer = new System.Threading.Timer(x =>
            {
                generalJoin(link);
            }, null, timeToGo, Timeout.InfiniteTimeSpan);
        }

        private void ClassTime()
        {
            string oldJSONString = File.ReadAllText(jsonPath);
            JObject parsedOldJSON = JObject.Parse(oldJSONString);

            foreach (var i in parsedOldJSON)
            {
                Console.WriteLine(i.Key);


                string somethingElse = parsedOldJSON[i.Key].ToString();
                dynamic parsedLink = JValue.Parse(somethingElse);

                string linkParsed = parsedLink[0].ToString();
                dynamic finalParse = JValue.Parse(linkParsed);
                ;
                var newDay1 = finalParse["Day1"].ToString();
                var newDay2 = finalParse["Day2"].ToString();

                var newHour = finalParse["hour"].ToString();
                var newMinute = finalParse["minute"].ToString();

                var newLink = finalParse["link"].ToString();

                var currentDay = DateTime.Now.DayOfWeek.ToString();

                if (currentDay == newDay1 || currentDay == newDay2)
                {
                    MidnightTimer1(new TimeSpan(Int32.Parse(newHour), Int32.Parse(newMinute), 00), newLink);
                }
                Console.Write(newDay1);
                Console.WriteLine(newDay2);

                // System.Console.Write("{0} ", i);

            }

        }
        //-------
       
        #endregion
        private void generalJoin(string link)
        {
            System.Diagnostics.Process.Start(link);
        }      

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            //if the form is minimized  
            //hide it from the task bar  
            //and show the system tray icon (represented by the NotifyIcon control)  
            if (this.WindowState == FormWindowState.Minimized)
             {
                 notifyIcon1.Visible = true;
                 Hide();
             }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;   
            notifyIcon1.Visible = false;
            Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClassTime();
        }
    }
}
