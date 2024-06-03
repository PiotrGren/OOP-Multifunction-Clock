namespace Zegar
{
    partial class UstawianieBudzika
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
            labelBudzik = new Label();
            btnHRSUp = new Button();
            btnMINUp = new Button();
            btnHRSDown = new Button();
            btnMINDown = new Button();
            CANCLEButton = new Button();
            ADDButton = new Button();
            SuspendLayout();
            // 
            // labelBudzik
            // 
            labelBudzik.AutoSize = true;
            labelBudzik.BackColor = Color.FromArgb(31, 32, 41);
            labelBudzik.Font = new Font("Lucida Console", 72F, FontStyle.Bold, GraphicsUnit.Point);
            labelBudzik.ForeColor = Color.FromArgb(196, 195, 202);
            labelBudzik.Location = new Point(2, 67);
            labelBudzik.Name = "labelBudzik";
            labelBudzik.Size = new Size(415, 120);
            labelBudzik.TabIndex = 11;
            labelBudzik.Text = "00:00";
            labelBudzik.TextChanged += labelBudzik_TextChanged;
            // 
            // btnHRSUp
            // 
            btnHRSUp.FlatStyle = FlatStyle.Popup;
            btnHRSUp.Font = new Font("Lucida Console", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnHRSUp.ForeColor = Color.FromArgb(196, 195, 202);
            btnHRSUp.Location = new Point(25, 23);
            btnHRSUp.Margin = new Padding(3, 4, 3, 4);
            btnHRSUp.Name = "btnHRSUp";
            btnHRSUp.Size = new Size(143, 40);
            btnHRSUp.TabIndex = 18;
            btnHRSUp.Text = "^";
            btnHRSUp.TextAlign = ContentAlignment.TopCenter;
            btnHRSUp.UseVisualStyleBackColor = true;
            btnHRSUp.Click += btnHRSUp_Click;
            // 
            // btnMINUp
            // 
            btnMINUp.FlatStyle = FlatStyle.Popup;
            btnMINUp.Font = new Font("Lucida Console", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnMINUp.ForeColor = Color.FromArgb(196, 195, 202);
            btnMINUp.Location = new Point(238, 23);
            btnMINUp.Margin = new Padding(3, 4, 3, 4);
            btnMINUp.Name = "btnMINUp";
            btnMINUp.Size = new Size(143, 40);
            btnMINUp.TabIndex = 19;
            btnMINUp.Text = "^";
            btnMINUp.TextAlign = ContentAlignment.TopCenter;
            btnMINUp.UseVisualStyleBackColor = true;
            btnMINUp.Click += btnMINUp_Click;
            // 
            // btnHRSDown
            // 
            btnHRSDown.FlatStyle = FlatStyle.Popup;
            btnHRSDown.Font = new Font("Lucida Console", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnHRSDown.ForeColor = Color.FromArgb(196, 195, 202);
            btnHRSDown.Location = new Point(25, 183);
            btnHRSDown.Margin = new Padding(3, 4, 3, 4);
            btnHRSDown.Name = "btnHRSDown";
            btnHRSDown.Size = new Size(143, 40);
            btnHRSDown.TabIndex = 21;
            btnHRSDown.Text = "v";
            btnHRSDown.TextAlign = ContentAlignment.TopCenter;
            btnHRSDown.UseVisualStyleBackColor = true;
            btnHRSDown.Click += btnHRSDown_Click;
            // 
            // btnMINDown
            // 
            btnMINDown.FlatStyle = FlatStyle.Popup;
            btnMINDown.Font = new Font("Lucida Console", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnMINDown.ForeColor = Color.FromArgb(196, 195, 202);
            btnMINDown.Location = new Point(236, 183);
            btnMINDown.Margin = new Padding(3, 4, 3, 4);
            btnMINDown.Name = "btnMINDown";
            btnMINDown.Size = new Size(143, 40);
            btnMINDown.TabIndex = 22;
            btnMINDown.Text = "v";
            btnMINDown.TextAlign = ContentAlignment.TopCenter;
            btnMINDown.UseVisualStyleBackColor = true;
            btnMINDown.Click += btnMINDown_Click;
            // 
            // CANCLEButton
            // 
            CANCLEButton.BackColor = Color.FromArgb(255, 235, 167);
            CANCLEButton.Cursor = Cursors.Hand;
            CANCLEButton.FlatStyle = FlatStyle.Popup;
            CANCLEButton.Font = new Font("Lucida Console", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CANCLEButton.ForeColor = Color.FromArgb(33, 37, 41);
            CANCLEButton.Location = new Point(12, 243);
            CANCLEButton.Name = "CANCLEButton";
            CANCLEButton.Size = new Size(190, 55);
            CANCLEButton.TabIndex = 23;
            CANCLEButton.Text = "ANULUJ";
            CANCLEButton.UseVisualStyleBackColor = false;
            CANCLEButton.Click += CANCLEButton_Click;
            // 
            // ADDButton
            // 
            ADDButton.BackColor = Color.FromArgb(255, 235, 167);
            ADDButton.Cursor = Cursors.Hand;
            ADDButton.FlatStyle = FlatStyle.Popup;
            ADDButton.Font = new Font("Lucida Console", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ADDButton.ForeColor = Color.FromArgb(33, 37, 41);
            ADDButton.Location = new Point(208, 243);
            ADDButton.Name = "ADDButton";
            ADDButton.Size = new Size(190, 55);
            ADDButton.TabIndex = 24;
            ADDButton.Text = "DODAJ";
            ADDButton.UseVisualStyleBackColor = false;
            ADDButton.Click += ADDButton_Click;
            // 
            // UstawianieBudzika
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 32, 41);
            ClientSize = new Size(407, 306);
            Controls.Add(ADDButton);
            Controls.Add(CANCLEButton);
            Controls.Add(btnMINDown);
            Controls.Add(btnHRSDown);
            Controls.Add(btnMINUp);
            Controls.Add(btnHRSUp);
            Controls.Add(labelBudzik);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UstawianieBudzika";
            Text = "UstawianieBudzika";
            Load += UstawianieBudzika_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelBudzik;
        private Button btnHRSUp;
        private Button btnMINUp;
        private Button btnHRSDown;
        private Button btnMINDown;
        private Button CANCLEButton;
        private Button ADDButton;
    }
}