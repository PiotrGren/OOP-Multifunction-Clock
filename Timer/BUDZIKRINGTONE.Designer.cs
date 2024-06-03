namespace Zegar
{
    partial class BUDZIKRINGTONE
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
            pictureBox1 = new PictureBox();
            CANCLEButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.RINGTONE2;
            pictureBox1.Location = new Point(14, 6);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(286, 243);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // CANCLEButton
            // 
            CANCLEButton.BackColor = Color.FromArgb(255, 235, 167);
            CANCLEButton.Cursor = Cursors.Hand;
            CANCLEButton.FlatStyle = FlatStyle.Popup;
            CANCLEButton.Font = new Font("Lucida Console", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CANCLEButton.ForeColor = Color.FromArgb(33, 37, 41);
            CANCLEButton.Location = new Point(14, 256);
            CANCLEButton.Name = "CANCLEButton";
            CANCLEButton.Size = new Size(286, 67);
            CANCLEButton.TabIndex = 24;
            CANCLEButton.Text = "WYŁĄCZ";
            CANCLEButton.UseVisualStyleBackColor = false;
            CANCLEButton.Click += CANCLEButton_Click;
            // 
            // BUDZIKRINGTONE
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 32, 41);
            ClientSize = new Size(312, 333);
            Controls.Add(CANCLEButton);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "BUDZIKRINGTONE";
            Text = "BUDZIKRINGTONE";
            Load += BUDZIKRINGTONE_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button CANCLEButton;
    }
}