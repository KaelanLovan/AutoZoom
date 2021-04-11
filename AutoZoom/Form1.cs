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
using System.Drawing;


namespace AutoZoom
{
    public partial class Form1 : Form
    {
        #region Initialize Form
        public Form1()
        {
            InitializeComponent();
        }
        #endregion

        #region Move Form Function
        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }
        #endregion

        #region Executable Path
        public string jsonPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\Classes.json";
        #endregion

        #region Start AutoZoom Button
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ClassTime();
            this.label2.Text = "Status: On";
            this.label2.BackColor = System.Drawing.Color.Green;
            this.unsavedLabel.Visible = false;
        }
        #endregion

        #region New Input Button
        private void New_butt_Click(object sender, EventArgs e)
        {
            this.New_butt.Enabled = false;
            this.Save_butt.Enabled = true;

            //---------Enable Inputs--------
            this.class_textBox1.Enabled = true;
            this.ml_textBox2.Enabled = true;
            this.dateTimePicker1.Enabled = true;
            this.dateTimePicker2.Enabled = true;
            this.dateTimePicker3.Enabled = true;

            //---------Clear Boxes -------
            this.class_textBox1.ResetText();
            this.ml_textBox2.ResetText();
            this.dateTimePicker1.ResetText();
            this.dateTimePicker2.ResetText();
            this.dateTimePicker3.ResetText();

            //--------------------------------
        }
        #endregion

        #region Save Info Button
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

            string mDay1 = this.dateTimePicker2.Value.DayOfWeek.ToString();
            string mDay2 = "";

            if (this.dateTimePicker3.Checked == true)
            {
                mDay2 = this.dateTimePicker3.Value.DayOfWeek.ToString();
            } 
            
            string meetLink = this.ml_textBox2.Text;

            MessageBox.Show("Saved!");
            this.unsavedLabel.Visible = true;

            var jsonObject = new JObject();
            dynamic classInfo = jsonObject;

            classInfo[subject] = new JArray() as dynamic;
            dynamic info = new JObject();
            info.hour = hourSTR;
            info.minute = minuteSTR;
            info.Day1 = mDay1;
            info.Day2 = mDay2;
            info.link = meetLink;
            classInfo[subject].Add(info);

            
            if (File.Exists(jsonPath))
            {   
                var oldJSONString = File.ReadAllText(jsonPath, Encoding.UTF8);
                var parsedOldJSON = JValue.Parse(oldJSONString);
                dynamic updateJSON = parsedOldJSON;
                updateJSON[subject] = new JArray() as dynamic;
                updateJSON[subject].Add(info);

                string newClassIn = updateJSON.ToString();
                File.WriteAllText(jsonPath, newClassIn, Encoding.UTF8);
            }
            else
            {
                string classIn = classInfo.ToString();
                File.WriteAllText(jsonPath, classIn, Encoding.UTF8);
            }

            this.New_butt.Enabled = true;
            this.Save_butt.Enabled = false;

            this.class_textBox1.Enabled = false;
            this.ml_textBox2.Enabled = false;
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker2.Enabled = false;
            this.dateTimePicker3.Enabled = false;
        }
        #endregion

        #region Timer 
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

            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.AutoScroll = true;

            foreach (var i in parsedOldJSON)
            {
                string fmt = "00.##";

                string somethingElse = parsedOldJSON[i.Key].ToString();
                dynamic parsedLink = JValue.Parse(somethingElse);
                
                string linkParsed = parsedLink[0].ToString();
                dynamic finalParse = JValue.Parse(linkParsed);
                
                var newDay1 = finalParse["Day1"].ToString();
                var newDay2 = finalParse["Day2"].ToString();

                var newHour = finalParse["hour"].ToString(fmt);
                var newMinute = finalParse["minute"].ToString(fmt);
                int newMinuteInt = Convert.ToInt32(newMinute);

                var newLink = finalParse["link"].ToString();

                var currentDay = DateTime.Now.DayOfWeek.ToString();
                Console.WriteLine(newDay1);
                Console.WriteLine(newDay2);

                if (currentDay == newDay1 || currentDay == newDay2)
                {
                    MidnightTimer1(new TimeSpan(Int32.Parse(newHour), Int32.Parse(newMinute), 00), newLink);
                }
                int hourInt = Convert.ToInt32(newHour);
                
                if (hourInt > 12)
                {
                    hourInt -= 12;
                    string hourString = hourInt.ToString();
                    this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
                    this.tableLayoutPanel1.Controls.Add(new Label { Text = i.Key });
                    this.tableLayoutPanel1.Controls.Add(new Label { Text = hourString + ':' + newMinuteInt.ToString(fmt) + " P.M."});

                    foreach (Label tb in this.tableLayoutPanel1.Controls.OfType<Label>())
                    {
                        tb.AutoSize = true;
                    }
                }
                else
                {
                    string hourString = hourInt.ToString();
                    this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
                    this.tableLayoutPanel1.Controls.Add(new Label { Text = i.Key });
                    this.tableLayoutPanel1.Controls.Add(new Label { Text = hourString + ':' + newMinuteInt.ToString(fmt) + " A.M." });

                    foreach (Label tb in this.tableLayoutPanel1.Controls.OfType<Label>())
                    {
                        tb.AutoSize = true;
                    }
                }
            }

        }
        #endregion

        #region Link Activate
        private void generalJoin(string link)
        {
            System.Diagnostics.Process.Start(link);
        }
        #endregion

        #region Minimize and Close Funtctions
        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            Hide();
            notifyIcon1.Visible = true;
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region View Mode Control

        string viewMode = "light";

        private void Form1_Load(object sender, EventArgs e)
        {
            lightMode();
        }

        private void lightMode()
        {
            viewMode = "light";
            this.ForeColor = Color.Black;
            this.BackColor = Color.White;
            this.viewColorButton.Text = "Dark";
            this.viewColorButton.Image = AutoZoom.Properties.Resources.darkTheme;
        }

        private void darkMode()
        {
            viewMode = "dark";
            this.ForeColor = Color.White;
            this.label2.ForeColor = Color.Black;
            this.unsavedLabel.ForeColor = Color.Black;
            this.BackColor = Color.FromArgb(48, 48, 48);
            this.viewColorButton.Text = "Light";
            this.viewColorButton.Image = AutoZoom.Properties.Resources.lightTheme;
        }

        private void viewColor(object sender, EventArgs e)
        {
            if (this.viewColorButton.Text == "Light")
            {
                lightMode();
            } 
            else
            {
                darkMode();
            }
        }

        private void tsi_MouseEnter(object sender, EventArgs e)
        {
            if (viewMode == "light")
            {
                switch (((ToolStripItem)sender).ToString())
                {
                    case "Run":
                        Console.WriteLine((ToolStripItem)sender);
                        this.toolStripButton2.BackgroundImage = Properties.Resources.lightgray;
                        break;
                    case "Dark":
                        Console.WriteLine((ToolStripItem)sender);
                        this.viewColorButton.BackgroundImage = Properties.Resources.lightgray;
                        break;
                    case "Minimize":
                        Console.WriteLine((ToolStripItem)sender);
                        this.toolStripButton1.BackgroundImage = Properties.Resources.lightgray;
                        break;
                    case "Exit":
                        Console.WriteLine((ToolStripItem)sender);
                        this.toolStripButton5.BackgroundImage = Properties.Resources.lightgray;
                        break;
                    case "New Meeting":
                        Console.WriteLine((ToolStripItem)sender);
                        this.New_butt.BackgroundImage = Properties.Resources.lightgray;
                        break;
                    case "Save":
                        this.Save_butt.BackgroundImage = Properties.Resources.lightgray;
                        break;
                }
            } else
            {
                switch (((ToolStripItem)sender).ToString())
                {
                    case "Run":
                        Console.WriteLine((ToolStripItem)sender);
                        this.toolStripButton2.BackgroundImage = Properties.Resources.midgray;
                        break;
                    case "Light":
                        Console.WriteLine((ToolStripItem)sender);
                        this.viewColorButton.BackgroundImage = Properties.Resources.midgray;
                        break;
                    case "Minimize":
                        Console.WriteLine((ToolStripItem)sender);
                        this.toolStripButton1.BackgroundImage = Properties.Resources.midgray;
                        break;
                    case "Exit":
                        Console.WriteLine((ToolStripItem)sender);
                        this.toolStripButton5.BackgroundImage = Properties.Resources.midgray;
                        break;
                    case "New Meeting":
                        Console.WriteLine((ToolStripItem)sender);
                        this.New_butt.BackgroundImage = Properties.Resources.midgray;
                        break;
                    case "Save":
                        this.Save_butt.BackgroundImage = Properties.Resources.midgray;
                        break;
                }
            }
        }

        private void tsi_MouseLeave(object sender, EventArgs e)
        {
            (sender as ToolStripItem).BackgroundImage = null;
        }
        #endregion
    }
}
