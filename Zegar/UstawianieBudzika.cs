using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zegar
{
    public partial class UstawianieBudzika : Form
    {

        public TimeSpan WybranyCzas { get; private set; }
        private TimeSpan CZAS = TimeSpan.Zero;

        public UstawianieBudzika()
        {
            InitializeComponent();
        }

        private void UstawianieBudzika_Load(object sender, EventArgs e)
        {
            ADDButton.Enabled = false;
        }

        private void btnHRSUp_Click(object sender, EventArgs e)
        {
            CZAS = CZAS.Add(TimeSpan.FromHours(1));
            if (CZAS.Hours > 23)
            {
                CZAS = CZAS.Add(TimeSpan.FromHours(-24));
            }

            UpdateLabel();
        }

        private void btnHRSDown_Click(object sender, EventArgs e)
        {
            CZAS = CZAS.Add(TimeSpan.FromHours(-1));
            if (CZAS.Hours < 0)
            {
                CZAS = CZAS.Add(TimeSpan.FromHours(24));
            }

            UpdateLabel();
        }

        private void btnMINUp_Click(object sender, EventArgs e)
        {
            CZAS = CZAS.Add(TimeSpan.FromMinutes(1));
            if (CZAS.Minutes > 59)
            {
                CZAS = CZAS.Add(TimeSpan.FromMinutes(-60));
            }

            UpdateLabel();
        }

        private void btnMINDown_Click(object sender, EventArgs e)
        {
            CZAS = CZAS.Add(TimeSpan.FromMinutes(-1));
            if (CZAS.Minutes < 0)
            {
                CZAS = CZAS.Add(TimeSpan.FromMinutes(60));
            }

            UpdateLabel();
        }

        private void UpdateLabel()
        {
            labelBudzik.Text = CZAS.ToString(@"hh\:mm");
        }

        private void ADDButton_Click(object sender, EventArgs e)
        {
            WybranyCzas = CZAS;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CANCLEButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void labelBudzik_TextChanged(object sender, EventArgs e)
        {
            if (CZAS > TimeSpan.Zero)
            {
                ADDButton.Enabled = true;
            }
            else
            {
                ADDButton.Enabled = true;
            }
        }
    }
}
