namespace Zegar
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            label3 = new Label();
            buttonZegar = new Button();
            buttonStoper = new Button();
            buttonMinutnik = new Button();
            buttonBudzik = new Button();
            panelZegar = new Panel();
            panelStoper = new Panel();
            buttonStop = new Button();
            labelStoper = new Label();
            buttonPost = new Button();
            buttonStart = new Button();
            timerStoper = new System.Windows.Forms.Timer(components);
            panelMinutnik = new Panel();
            btnSecDown = new Button();
            btnMinDown = new Button();
            btnHrsDown = new Button();
            btnSecUp = new Button();
            btnMinUp = new Button();
            btnHrsUp = new Button();
            btnMINStop = new Button();
            labelMinutnik = new Label();
            btnMINPOST = new Button();
            btnMINSTART = new Button();
            panelBudzikow = new Panel();
            ADDAlarm = new Button();
            timerMinutnik = new System.Windows.Forms.Timer(components);
            panelADDBudzik = new Panel();
            budzikTimer = new System.Windows.Forms.Timer(components);
            panelZegar.SuspendLayout();
            panelStoper.SuspendLayout();
            panelMinutnik.SuspendLayout();
            panelADDBudzik.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(31, 32, 41);
            label1.Font = new Font("Lucida Console", 72F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(196, 195, 202);
            label1.Location = new Point(32, 48);
            label1.Name = "label1";
            label1.Size = new Size(634, 120);
            label1.TabIndex = 0;
            label1.Text = "00:00:00";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Console", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(255, 235, 167);
            label2.Location = new Point(32, 244);
            label2.Name = "label2";
            label2.Size = new Size(161, 40);
            label2.TabIndex = 1;
            label2.Text = "label2";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Console", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(255, 235, 167);
            label3.ImageAlign = ContentAlignment.MiddleRight;
            label3.Location = new Point(345, 244);
            label3.Name = "label3";
            label3.Size = new Size(161, 40);
            label3.TabIndex = 2;
            label3.Text = "label3";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // buttonZegar
            // 
            buttonZegar.BackColor = Color.FromArgb(255, 235, 167);
            buttonZegar.Cursor = Cursors.Hand;
            buttonZegar.FlatStyle = FlatStyle.Popup;
            buttonZegar.Font = new Font("Lucida Console", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonZegar.ForeColor = Color.FromArgb(33, 37, 41);
            buttonZegar.Location = new Point(14, 332);
            buttonZegar.Name = "buttonZegar";
            buttonZegar.Size = new Size(139, 45);
            buttonZegar.TabIndex = 3;
            buttonZegar.Text = "ZEGAR";
            buttonZegar.UseVisualStyleBackColor = false;
            buttonZegar.Click += buttonZegar_Click;
            // 
            // buttonStoper
            // 
            buttonStoper.BackColor = Color.FromArgb(255, 235, 167);
            buttonStoper.Cursor = Cursors.Hand;
            buttonStoper.FlatStyle = FlatStyle.Popup;
            buttonStoper.Font = new Font("Lucida Console", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonStoper.ForeColor = Color.FromArgb(33, 37, 41);
            buttonStoper.Location = new Point(183, 331);
            buttonStoper.Name = "buttonStoper";
            buttonStoper.Size = new Size(139, 45);
            buttonStoper.TabIndex = 4;
            buttonStoper.Text = "STOPER";
            buttonStoper.UseVisualStyleBackColor = false;
            buttonStoper.Click += buttonStoper_Click;
            // 
            // buttonMinutnik
            // 
            buttonMinutnik.BackColor = Color.FromArgb(255, 235, 167);
            buttonMinutnik.Cursor = Cursors.Hand;
            buttonMinutnik.FlatStyle = FlatStyle.Popup;
            buttonMinutnik.Font = new Font("Lucida Console", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonMinutnik.ForeColor = Color.FromArgb(33, 37, 41);
            buttonMinutnik.Location = new Point(359, 331);
            buttonMinutnik.Name = "buttonMinutnik";
            buttonMinutnik.Size = new Size(139, 45);
            buttonMinutnik.TabIndex = 5;
            buttonMinutnik.Text = "MINUTNIK";
            buttonMinutnik.UseVisualStyleBackColor = false;
            buttonMinutnik.Click += buttonMinutnik_Click;
            // 
            // buttonBudzik
            // 
            buttonBudzik.BackColor = Color.FromArgb(255, 235, 167);
            buttonBudzik.Cursor = Cursors.Hand;
            buttonBudzik.FlatStyle = FlatStyle.Popup;
            buttonBudzik.Font = new Font("Lucida Console", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonBudzik.ForeColor = Color.FromArgb(33, 37, 41);
            buttonBudzik.Location = new Point(533, 331);
            buttonBudzik.Name = "buttonBudzik";
            buttonBudzik.Size = new Size(139, 45);
            buttonBudzik.TabIndex = 6;
            buttonBudzik.Text = "BUDZIK";
            buttonBudzik.UseVisualStyleBackColor = false;
            buttonBudzik.Click += buttonBudzik_Click;
            // 
            // panelZegar
            // 
            panelZegar.Controls.Add(label2);
            panelZegar.Controls.Add(label3);
            panelZegar.Controls.Add(label1);
            panelZegar.Location = new Point(14, 15);
            panelZegar.Name = "panelZegar";
            panelZegar.Size = new Size(658, 311);
            panelZegar.TabIndex = 7;
            // 
            // panelStoper
            // 
            panelStoper.Controls.Add(buttonStop);
            panelStoper.Controls.Add(labelStoper);
            panelStoper.Controls.Add(buttonPost);
            panelStoper.Controls.Add(buttonStart);
            panelStoper.Location = new Point(13, 14);
            panelStoper.Name = "panelStoper";
            panelStoper.Size = new Size(658, 311);
            panelStoper.TabIndex = 8;
            panelStoper.Paint += panelStoper_Paint;
            // 
            // buttonStop
            // 
            buttonStop.BackColor = Color.FromArgb(255, 235, 167);
            buttonStop.Cursor = Cursors.Hand;
            buttonStop.FlatStyle = FlatStyle.Popup;
            buttonStop.Font = new Font("Lucida Console", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonStop.ForeColor = Color.FromArgb(33, 37, 41);
            buttonStop.Location = new Point(41, 221);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new Size(139, 53);
            buttonStop.TabIndex = 11;
            buttonStop.Text = "■";
            buttonStop.UseVisualStyleBackColor = false;
            buttonStop.Click += buttonStop_Click;
            // 
            // labelStoper
            // 
            labelStoper.AutoSize = true;
            labelStoper.BackColor = Color.FromArgb(31, 32, 41);
            labelStoper.Font = new Font("Lucida Console", 72F, FontStyle.Bold, GraphicsUnit.Point);
            labelStoper.ForeColor = Color.FromArgb(196, 195, 202);
            labelStoper.Location = new Point(18, 48);
            labelStoper.Name = "labelStoper";
            labelStoper.Size = new Size(634, 120);
            labelStoper.TabIndex = 3;
            labelStoper.Text = "00:00:00";
            // 
            // buttonPost
            // 
            buttonPost.BackColor = Color.FromArgb(255, 235, 167);
            buttonPost.Cursor = Cursors.Hand;
            buttonPost.FlatStyle = FlatStyle.Popup;
            buttonPost.Font = new Font("Lucida Console", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPost.ForeColor = Color.FromArgb(33, 37, 41);
            buttonPost.Location = new Point(184, 221);
            buttonPost.Name = "buttonPost";
            buttonPost.Size = new Size(293, 53);
            buttonPost.TabIndex = 10;
            buttonPost.Text = "▮▮";
            buttonPost.UseVisualStyleBackColor = false;
            buttonPost.Click += buttonPost_Click;
            // 
            // buttonStart
            // 
            buttonStart.BackColor = Color.FromArgb(255, 235, 167);
            buttonStart.Cursor = Cursors.Hand;
            buttonStart.FlatStyle = FlatStyle.Popup;
            buttonStart.Font = new Font("Lucida Console", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonStart.ForeColor = Color.FromArgb(33, 37, 41);
            buttonStart.Location = new Point(480, 221);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(139, 53);
            buttonStart.TabIndex = 9;
            buttonStart.Text = "▶";
            buttonStart.UseVisualStyleBackColor = false;
            buttonStart.Click += buttonStart_Click;
            // 
            // timerStoper
            // 
            timerStoper.Interval = 10;
            timerStoper.Tick += timerStoper_Tick;
            // 
            // panelMinutnik
            // 
            panelMinutnik.Controls.Add(btnSecDown);
            panelMinutnik.Controls.Add(btnMinDown);
            panelMinutnik.Controls.Add(btnHrsDown);
            panelMinutnik.Controls.Add(btnSecUp);
            panelMinutnik.Controls.Add(btnMinUp);
            panelMinutnik.Controls.Add(btnHrsUp);
            panelMinutnik.Controls.Add(btnMINStop);
            panelMinutnik.Controls.Add(labelMinutnik);
            panelMinutnik.Controls.Add(btnMINPOST);
            panelMinutnik.Controls.Add(btnMINSTART);
            panelMinutnik.Location = new Point(13, 16);
            panelMinutnik.Margin = new Padding(3, 4, 3, 4);
            panelMinutnik.Name = "panelMinutnik";
            panelMinutnik.Size = new Size(658, 311);
            panelMinutnik.TabIndex = 9;
            panelMinutnik.Paint += panelMinutnik_Paint;
            // 
            // btnSecDown
            // 
            btnSecDown.FlatStyle = FlatStyle.Popup;
            btnSecDown.Font = new Font("Lucida Console", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnSecDown.ForeColor = Color.FromArgb(196, 195, 202);
            btnSecDown.Location = new Point(474, 165);
            btnSecDown.Margin = new Padding(3, 4, 3, 4);
            btnSecDown.Name = "btnSecDown";
            btnSecDown.Size = new Size(143, 40);
            btnSecDown.TabIndex = 20;
            btnSecDown.Text = "v";
            btnSecDown.TextAlign = ContentAlignment.TopCenter;
            btnSecDown.UseVisualStyleBackColor = true;
            btnSecDown.Click += btnSecDown_Click;
            // 
            // btnMinDown
            // 
            btnMinDown.FlatStyle = FlatStyle.Popup;
            btnMinDown.Font = new Font("Lucida Console", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnMinDown.ForeColor = Color.FromArgb(196, 195, 202);
            btnMinDown.Location = new Point(251, 165);
            btnMinDown.Margin = new Padding(3, 4, 3, 4);
            btnMinDown.Name = "btnMinDown";
            btnMinDown.Size = new Size(143, 40);
            btnMinDown.TabIndex = 19;
            btnMinDown.Text = "v";
            btnMinDown.TextAlign = ContentAlignment.TopCenter;
            btnMinDown.UseVisualStyleBackColor = true;
            btnMinDown.Click += btnMinDown_Click;
            // 
            // btnHrsDown
            // 
            btnHrsDown.FlatStyle = FlatStyle.Popup;
            btnHrsDown.Font = new Font("Lucida Console", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnHrsDown.ForeColor = Color.FromArgb(196, 195, 202);
            btnHrsDown.Location = new Point(35, 165);
            btnHrsDown.Margin = new Padding(3, 4, 3, 4);
            btnHrsDown.Name = "btnHrsDown";
            btnHrsDown.Size = new Size(143, 40);
            btnHrsDown.TabIndex = 18;
            btnHrsDown.Text = "v";
            btnHrsDown.TextAlign = ContentAlignment.TopCenter;
            btnHrsDown.UseVisualStyleBackColor = true;
            btnHrsDown.Click += btnHrsDown_Click;
            // 
            // btnSecUp
            // 
            btnSecUp.FlatStyle = FlatStyle.Popup;
            btnSecUp.Font = new Font("Lucida Console", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnSecUp.ForeColor = Color.FromArgb(196, 195, 202);
            btnSecUp.Location = new Point(474, 9);
            btnSecUp.Margin = new Padding(3, 4, 3, 4);
            btnSecUp.Name = "btnSecUp";
            btnSecUp.Size = new Size(143, 40);
            btnSecUp.TabIndex = 17;
            btnSecUp.Text = "^";
            btnSecUp.TextAlign = ContentAlignment.TopCenter;
            btnSecUp.UseVisualStyleBackColor = true;
            btnSecUp.Click += btnSecUp_Click;
            // 
            // btnMinUp
            // 
            btnMinUp.FlatStyle = FlatStyle.Popup;
            btnMinUp.Font = new Font("Lucida Console", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnMinUp.ForeColor = Color.FromArgb(196, 195, 202);
            btnMinUp.Location = new Point(251, 9);
            btnMinUp.Margin = new Padding(3, 4, 3, 4);
            btnMinUp.Name = "btnMinUp";
            btnMinUp.Size = new Size(143, 40);
            btnMinUp.TabIndex = 16;
            btnMinUp.Text = "^";
            btnMinUp.TextAlign = ContentAlignment.TopCenter;
            btnMinUp.UseVisualStyleBackColor = true;
            btnMinUp.Click += btnMinUp_Click;
            // 
            // btnHrsUp
            // 
            btnHrsUp.FlatStyle = FlatStyle.Popup;
            btnHrsUp.Font = new Font("Lucida Console", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnHrsUp.ForeColor = Color.FromArgb(196, 195, 202);
            btnHrsUp.Location = new Point(35, 9);
            btnHrsUp.Margin = new Padding(3, 4, 3, 4);
            btnHrsUp.Name = "btnHrsUp";
            btnHrsUp.Size = new Size(143, 40);
            btnHrsUp.TabIndex = 15;
            btnHrsUp.Text = "^";
            btnHrsUp.TextAlign = ContentAlignment.TopCenter;
            btnHrsUp.UseVisualStyleBackColor = true;
            btnHrsUp.Click += btnHrsUp_Click;
            // 
            // btnMINStop
            // 
            btnMINStop.BackColor = Color.FromArgb(255, 235, 167);
            btnMINStop.Cursor = Cursors.Hand;
            btnMINStop.FlatStyle = FlatStyle.Popup;
            btnMINStop.Font = new Font("Lucida Console", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnMINStop.ForeColor = Color.FromArgb(33, 37, 41);
            btnMINStop.Location = new Point(34, 221);
            btnMINStop.Name = "btnMINStop";
            btnMINStop.Size = new Size(139, 53);
            btnMINStop.TabIndex = 14;
            btnMINStop.Text = "■";
            btnMINStop.UseVisualStyleBackColor = false;
            btnMINStop.Click += btnMINStop_Click;
            // 
            // labelMinutnik
            // 
            labelMinutnik.AutoSize = true;
            labelMinutnik.BackColor = Color.FromArgb(31, 32, 41);
            labelMinutnik.Font = new Font("Lucida Console", 72F, FontStyle.Bold, GraphicsUnit.Point);
            labelMinutnik.ForeColor = Color.FromArgb(196, 195, 202);
            labelMinutnik.Location = new Point(13, 48);
            labelMinutnik.Name = "labelMinutnik";
            labelMinutnik.Size = new Size(634, 120);
            labelMinutnik.TabIndex = 10;
            labelMinutnik.Text = "00:00:00";
            labelMinutnik.TextChanged += labelMinutnik_TextChanged;
            // 
            // btnMINPOST
            // 
            btnMINPOST.BackColor = Color.FromArgb(255, 235, 167);
            btnMINPOST.Cursor = Cursors.Hand;
            btnMINPOST.FlatStyle = FlatStyle.Popup;
            btnMINPOST.Font = new Font("Lucida Console", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnMINPOST.ForeColor = Color.FromArgb(33, 37, 41);
            btnMINPOST.Location = new Point(178, 221);
            btnMINPOST.Name = "btnMINPOST";
            btnMINPOST.Size = new Size(297, 53);
            btnMINPOST.TabIndex = 13;
            btnMINPOST.Text = "▮▮";
            btnMINPOST.UseVisualStyleBackColor = false;
            btnMINPOST.Click += btnMINPOST_Click;
            // 
            // btnMINSTART
            // 
            btnMINSTART.BackColor = Color.FromArgb(255, 235, 167);
            btnMINSTART.Cursor = Cursors.Hand;
            btnMINSTART.FlatStyle = FlatStyle.Popup;
            btnMINSTART.Font = new Font("Lucida Console", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnMINSTART.ForeColor = Color.FromArgb(33, 37, 41);
            btnMINSTART.Location = new Point(480, 221);
            btnMINSTART.Name = "btnMINSTART";
            btnMINSTART.Size = new Size(139, 53);
            btnMINSTART.TabIndex = 12;
            btnMINSTART.Text = "▶";
            btnMINSTART.UseVisualStyleBackColor = false;
            btnMINSTART.Click += btnMINSTART_Click;
            // 
            // panelBudzikow
            // 
            panelBudzikow.Location = new Point(11, 19);
            panelBudzikow.Margin = new Padding(3, 4, 3, 4);
            panelBudzikow.Name = "panelBudzikow";
            panelBudzikow.Size = new Size(660, 240);
            panelBudzikow.TabIndex = 10;
            // 
            // ADDAlarm
            // 
            ADDAlarm.BackColor = Color.FromArgb(255, 235, 167);
            ADDAlarm.Cursor = Cursors.Hand;
            ADDAlarm.FlatStyle = FlatStyle.Popup;
            ADDAlarm.Font = new Font("Lucida Console", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            ADDAlarm.ForeColor = Color.FromArgb(33, 37, 41);
            ADDAlarm.Location = new Point(299, 5);
            ADDAlarm.Name = "ADDAlarm";
            ADDAlarm.Size = new Size(60, 60);
            ADDAlarm.TabIndex = 7;
            ADDAlarm.Text = "+";
            ADDAlarm.UseVisualStyleBackColor = false;
            ADDAlarm.Click += ADDAlarm_Click;
            // 
            // timerMinutnik
            // 
            timerMinutnik.Interval = 1000;
            timerMinutnik.Tick += timerMinutnik_Tick;
            // 
            // panelADDBudzik
            // 
            panelADDBudzik.Controls.Add(ADDAlarm);
            panelADDBudzik.Location = new Point(12, 259);
            panelADDBudzik.Margin = new Padding(3, 4, 3, 4);
            panelADDBudzik.Name = "panelADDBudzik";
            panelADDBudzik.Size = new Size(658, 71);
            panelADDBudzik.TabIndex = 11;
            // 
            // budzikTimer
            // 
            budzikTimer.Tick += budzikTimer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 32, 41);
            ClientSize = new Size(679, 383);
            Controls.Add(panelADDBudzik);
            Controls.Add(panelBudzikow);
            Controls.Add(panelMinutnik);
            Controls.Add(panelStoper);
            Controls.Add(panelZegar);
            Controls.Add(buttonBudzik);
            Controls.Add(buttonMinutnik);
            Controls.Add(buttonStoper);
            Controls.Add(buttonZegar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Clock";
            Load += Form1_Load;
            panelZegar.ResumeLayout(false);
            panelZegar.PerformLayout();
            panelStoper.ResumeLayout(false);
            panelStoper.PerformLayout();
            panelMinutnik.ResumeLayout(false);
            panelMinutnik.PerformLayout();
            panelADDBudzik.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Label label2;
        private Label label3;
        private Button buttonZegar;
        private Button buttonStoper;
        private Button buttonMinutnik;
        private Button buttonBudzik;
        private Panel panelZegar;
        private Panel panelStoper;
        private Label labelStoper;
        private Button buttonStop;
        private Button buttonPost;
        private Button buttonStart;
        private System.Windows.Forms.Timer timerStoper;
        private Panel panelMinutnik;
        private Label labelMinutnik;
        private Button btnHrsUp;
        private Button btnMINStop;
        private Button btnMINPOST;
        private Button btnMINSTART;
        private Button btnHrsDown;
        private Button btnSecUp;
        private Button btnMinUp;
        private Button btnSecDown;
        private Button btnMinDown;
        private System.Windows.Forms.Timer timerMinutnik;
        private Panel panelBudzikow;
        private Button ADDAlarm;
        private Panel panelADDBudzik;
        private System.Windows.Forms.Timer budzikTimer;
    }
}