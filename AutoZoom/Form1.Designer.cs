
namespace AutoZoom
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ml_textBox2 = new System.Windows.Forms.TextBox();
            this.class_textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.unsavedLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.New_butt = new System.Windows.Forms.ToolStripLabel();
            this.Save_butt = new System.Windows.Forms.ToolStripLabel();
            this.Exit = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripLabel();
            this.viewColorButton = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator5,
            this.Exit,
            this.toolStripButton5,
            this.toolStripSeparator2,
            this.toolStripButton1,
            this.toolStripSeparator3,
            this.toolStripSeparator1,
            this.viewColorButton,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(864, 41);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.toolStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.toolStrip1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 41);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 41);
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Classes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Status: Off";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker3.CustomFormat = "dddd";
            this.dateTimePicker3.Enabled = false;
            this.dateTimePicker3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker3.Location = new System.Drawing.Point(193, 400);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.ShowCheckBox = true;
            this.dateTimePicker3.Size = new System.Drawing.Size(203, 31);
            this.dateTimePicker3.TabIndex = 23;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.CustomFormat = "dddd";
            this.dateTimePicker2.Enabled = false;
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(193, 312);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(203, 31);
            this.dateTimePicker2.TabIndex = 22;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CustomFormat = "h:mm tt";
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(193, 224);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(203, 31);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // ml_textBox2
            // 
            this.ml_textBox2.Enabled = false;
            this.ml_textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ml_textBox2.Location = new System.Drawing.Point(193, 148);
            this.ml_textBox2.Name = "ml_textBox2";
            this.ml_textBox2.Size = new System.Drawing.Size(203, 31);
            this.ml_textBox2.TabIndex = 13;
            // 
            // class_textBox1
            // 
            this.class_textBox1.Enabled = false;
            this.class_textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class_textBox1.Location = new System.Drawing.Point(193, 72);
            this.class_textBox1.Name = "class_textBox1";
            this.class_textBox1.Size = new System.Drawing.Size(203, 31);
            this.class_textBox1.TabIndex = 1;
            // 
            // unsavedLabel
            // 
            this.unsavedLabel.AutoSize = true;
            this.unsavedLabel.BackColor = System.Drawing.Color.Gold;
            this.unsavedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unsavedLabel.Location = new System.Drawing.Point(127, 51);
            this.unsavedLabel.Name = "unsavedLabel";
            this.unsavedLabel.Size = new System.Drawing.Size(354, 24);
            this.unsavedLabel.TabIndex = 8;
            this.unsavedLabel.Text = "You have unsaved changes, Click \"Run\"!";
            this.unsavedLabel.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.AutoScrollMinSize = new System.Drawing.Size(10, 449);
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.2F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.8F));
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(14, 173);
            this.tableLayoutPanel1.MaximumSize = new System.Drawing.Size(375, 449);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(375, 449);
            this.tableLayoutPanel1.TabIndex = 7;
            this.tableLayoutPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.tableLayoutPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.tableLayoutPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "AutoZoom";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "AutoZoom";
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.dateTimePicker3);
            this.panel1.Controls.Add(this.toolStrip3);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.ml_textBox2);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.class_textBox1);
            this.panel1.Location = new System.Drawing.Point(438, 161);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 461);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 405);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 25);
            this.label8.TabIndex = 30;
            this.label8.Text = "Meeting Day 2:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 317);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 25);
            this.label9.TabIndex = 29;
            this.label9.Text = "Meeting Day 1:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 151);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 25);
            this.label10.TabIndex = 27;
            this.label10.Text = "Meeting Link:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(14, 229);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 25);
            this.label11.TabIndex = 26;
            this.label11.Text = "Meeting Time:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(14, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 25);
            this.label12.TabIndex = 24;
            this.label12.Text = "Class:";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 41);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 41);
            // 
            // toolStrip3
            // 
            this.toolStrip3.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator6,
            this.New_butt,
            this.toolStripSeparator4,
            this.Save_butt});
            this.toolStrip3.Location = new System.Drawing.Point(0, 0);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(414, 28);
            this.toolStrip3.TabIndex = 34;
            this.toolStrip3.Text = "toolStrip3";
            this.toolStrip3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.toolStrip3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.toolStrip3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 28);
            // 
            // New_butt
            // 
            this.New_butt.BackColor = System.Drawing.Color.Transparent;
            this.New_butt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New_butt.Image = global::AutoZoom.Properties.Resources.book;
            this.New_butt.Name = "New_butt";
            this.New_butt.Size = new System.Drawing.Size(141, 25);
            this.New_butt.Text = "New Meeting";
            this.New_butt.Click += new System.EventHandler(this.New_butt_Click);
            this.New_butt.MouseEnter += new System.EventHandler(this.tsi_MouseEnter);
            this.New_butt.MouseLeave += new System.EventHandler(this.tsi_MouseLeave);
            // 
            // Save_butt
            // 
            this.Save_butt.Enabled = false;
            this.Save_butt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_butt.Image = global::AutoZoom.Properties.Resources.saveIco;
            this.Save_butt.Name = "Save_butt";
            this.Save_butt.Size = new System.Drawing.Size(67, 25);
            this.Save_butt.Text = "Save";
            this.Save_butt.Click += new System.EventHandler(this.Save_butt_Click);
            this.Save_butt.MouseEnter += new System.EventHandler(this.tsi_MouseEnter);
            this.Save_butt.MouseLeave += new System.EventHandler(this.tsi_MouseLeave);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Image = global::AutoZoom.Properties.Resources.auto;
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(121, 38);
            this.Exit.Text = "AutoZoom";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton5.BackColor = System.Drawing.Color.Transparent;
            this.toolStripButton5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton5.Image = global::AutoZoom.Properties.Resources.powerButton;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(66, 38);
            this.toolStripButton5.Text = "Exit";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            this.toolStripButton5.MouseEnter += new System.EventHandler(this.tsi_MouseEnter);
            this.toolStripButton5.MouseLeave += new System.EventHandler(this.tsi_MouseLeave);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1.Image = global::AutoZoom.Properties.Resources.minimize_icon_65;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(106, 38);
            this.toolStripButton1.Text = "Minimize";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            this.toolStripButton1.MouseEnter += new System.EventHandler(this.tsi_MouseEnter);
            this.toolStripButton1.MouseLeave += new System.EventHandler(this.tsi_MouseLeave);
            // 
            // viewColorButton
            // 
            this.viewColorButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.viewColorButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewColorButton.Image = global::AutoZoom.Properties.Resources.darkTheme;
            this.viewColorButton.Name = "viewColorButton";
            this.viewColorButton.Size = new System.Drawing.Size(75, 38);
            this.viewColorButton.Text = "Dark";
            this.viewColorButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.viewColorButton.Click += new System.EventHandler(this.viewColor);
            this.viewColorButton.MouseEnter += new System.EventHandler(this.tsi_MouseEnter);
            this.viewColorButton.MouseLeave += new System.EventHandler(this.tsi_MouseLeave);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton2.Image = global::AutoZoom.Properties.Resources.power;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.toolStripButton2.Size = new System.Drawing.Size(71, 38);
            this.toolStripButton2.Text = "Run";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            this.toolStripButton2.MouseEnter += new System.EventHandler(this.tsi_MouseEnter);
            this.toolStripButton2.MouseLeave += new System.EventHandler(this.tsi_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(864, 634);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.unsavedLabel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoZoom";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ml_textBox2;
        private System.Windows.Forms.TextBox class_textBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label unsavedLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripLabel Exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ToolStripLabel New_butt;
        private System.Windows.Forms.ToolStripLabel Save_butt;
        private System.Windows.Forms.ToolStripLabel toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel viewColorButton;
        private System.Windows.Forms.ToolStripLabel toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripButton5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
    }
}

