using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Media;

namespace Zegar
{
    public partial class Form1 : Form
    {
        private TimeSpan czasStoper = TimeSpan.Zero;
        private bool isRunning = false;

        private TimeSpan czasMinutnik = TimeSpan.Zero;
        private bool isMinRunning = false;
        private bool isMusicPlaying = false;
        private int musicPlayed = 0;
        private SoundPlayer player;

        private string czasBudzika;
        private bool isBudzikPlaying = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            panelZegar.Visible = true;
            panelStoper.Visible = false;
            panelMinutnik.Visible = false;
            panelBudzikow.Visible = false;
            panelADDBudzik.Visible = false;

            panelBudzikow.AutoScroll = true;
            panelBudzikow.VerticalScroll.Enabled = true;
            panelBudzikow.VerticalScroll.Visible = true;
            panelBudzikow.VerticalScroll.Maximum = 0;
            panelBudzikow.AutoScrollMinSize = new Size(0, 0);

            budzikTimer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:mm:ss");
            label2.Text = DateTime.Now.ToString("dd.MM.yyyy");
            label3.Text = DateTime.Now.ToString("dddd");
        }

        private void buttonZegar_Click(object sender, EventArgs e)
        {
            panelZegar.Visible = true;
            panelStoper.Visible = false;
            panelMinutnik.Visible = false;
            panelBudzikow.Visible = false;
            panelADDBudzik.Visible = false;
        }

        private void buttonStoper_Click(object sender, EventArgs e)
        {
            panelZegar.Visible = false;
            panelStoper.Visible = true;
            panelMinutnik.Visible = false;
            panelBudzikow.Visible = false;
            panelADDBudzik.Visible = false;
        }

        private void buttonMinutnik_Click(object sender, EventArgs e)
        {
            panelZegar.Visible = false;
            panelStoper.Visible = false;
            panelMinutnik.Visible = true;
            panelBudzikow.Visible = false;
            panelADDBudzik.Visible = false;
        }

        private void buttonBudzik_Click(object sender, EventArgs e)
        {
            panelZegar.Visible = false;
            panelStoper.Visible = false;
            panelMinutnik.Visible = false;
            panelBudzikow.Visible = true;
            panelADDBudzik.Visible = true;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            isRunning = true;
            buttonStart.Enabled = false;
            buttonPost.Enabled = true;
            buttonStop.Enabled = true;

            timerStoper.Start();
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            if (isRunning)
            {
                isRunning = false;
                buttonPost.Text = "▮▶";
                timerStoper.Stop();
            }
            else
            {
                isRunning = true;
                buttonPost.Text = "▮▮";
                timerStoper.Start();
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            isRunning = false;
            buttonStart.Enabled = true;
            buttonPost.Enabled = false;
            buttonStop.Enabled = false;
            buttonPost.Text = "▮▮";

            timerStoper.Stop();
            czasStoper = TimeSpan.Zero;

            UpdateLabelStoper();
        }

        private void timerStoper_Tick(object sender, EventArgs e)
        {
            czasStoper = czasStoper.Add(TimeSpan.FromSeconds(1));

            if (czasStoper >= TimeSpan.Parse("23:59:59"))
            {
                isRunning = false;
                buttonStart.Enabled = true;
                buttonPost.Enabled = false;
                buttonStop.Enabled = false;
                buttonPost.Text = "▮▮";
                timerStoper.Stop();
                czasStoper = TimeSpan.Zero;
            }

            UpdateLabelStoper();
        }

        private void UpdateLabelStoper()
        {
            labelStoper.Text = czasStoper.ToString(@"hh\:mm\:ss");
        }

        private void panelStoper_Paint(object sender, PaintEventArgs e)
        {
            buttonStart.Enabled = true;
            buttonPost.Enabled = false;
            buttonStop.Enabled = false;
        }

        private void panelMinutnik_Paint(object sender, PaintEventArgs e)
        {
            btnMINSTART.Enabled = false;
            btnMINPOST.Enabled = false;
            btnMINStop.Enabled = false;
        }

        private void btnMINSTART_Click(object sender, EventArgs e)
        {
            if (czasMinutnik > TimeSpan.Zero)
            {
                isMinRunning = true;
                btnMINSTART.Enabled = false;
                btnMINPOST.Enabled = true;
                btnMINStop.Enabled = true;
                btnHrsDown.Enabled = false;
                btnHrsUp.Enabled = false;
                btnMinDown.Enabled = false;
                btnMinUp.Enabled = false;
                btnSecDown.Enabled = false;
                btnSecUp.Enabled = false;

                timerMinutnik.Start();
            }
        }

        private void btnSecUp_Click(object sender, EventArgs e)
        {
            czasMinutnik = czasMinutnik.Add(TimeSpan.FromSeconds(1));
            if (czasMinutnik.Seconds > 59)
            {
                czasMinutnik = czasMinutnik.Add(TimeSpan.FromSeconds(-60));
            }

            UpdateLabelMinutnik();
        }

        private void btnSecDown_Click(object sender, EventArgs e)
        {
            czasMinutnik = czasMinutnik.Add(TimeSpan.FromSeconds(-1));
            if (czasMinutnik.Seconds < 0)
            {
                czasMinutnik = czasMinutnik.Add(TimeSpan.FromSeconds(60));
            }

            UpdateLabelMinutnik();
        }

        private void btnMinUp_Click(object sender, EventArgs e)
        {
            czasMinutnik = czasMinutnik.Add(TimeSpan.FromMinutes(1));
            if (czasMinutnik.Minutes > 59)
            {
                czasMinutnik = czasMinutnik.Add(TimeSpan.FromMinutes(-60));
            }

            UpdateLabelMinutnik();
        }

        private void btnMinDown_Click(object sender, EventArgs e)
        {
            czasMinutnik = czasMinutnik.Add(TimeSpan.FromMinutes(-1));
            if (czasMinutnik.Minutes < 0)
            {
                czasMinutnik = czasMinutnik.Add(TimeSpan.FromMinutes(60));
            }

            UpdateLabelMinutnik();
        }

        private void btnHrsUp_Click(object sender, EventArgs e)
        {
            czasMinutnik = czasMinutnik.Add(TimeSpan.FromHours(1));
            if (czasMinutnik.Hours > 23)
            {
                czasMinutnik = czasMinutnik.Add(TimeSpan.FromHours(-23));
            }

            UpdateLabelMinutnik();
        }

        private void btnHrsDown_Click(object sender, EventArgs e)
        {
            czasMinutnik = czasMinutnik.Add(TimeSpan.FromHours(-1));
            if (czasMinutnik.Hours < 0)
            {
                czasMinutnik = czasMinutnik.Add(TimeSpan.FromHours(23));
            }

            UpdateLabelMinutnik();
        }

        private void UpdateLabelMinutnik()
        {
            labelMinutnik.Text = czasMinutnik.ToString(@"hh\:mm\:ss");
        }

        private void labelMinutnik_TextChanged(object sender, EventArgs e)
        {
            if (czasMinutnik > TimeSpan.Zero && !isMinRunning)
            {
                btnMINSTART.Enabled = true;
            }
            else
            {
                btnMINSTART.Enabled = false;
            }
        }

        private void btnMINPOST_Click(object sender, EventArgs e)
        {
            if (isMinRunning)
            {
                isMinRunning = false;
                btnMINPOST.Text = "▮▶";
                timerMinutnik.Stop();
            }
            else
            {
                isMinRunning = true;
                btnMINPOST.Text = "▮▮";
                timerMinutnik.Start();
            }
        }

        private void btnMINStop_Click(object sender, EventArgs e)
        {
            isMinRunning = false;
            btnMINSTART.Enabled = false;
            btnMINPOST.Enabled = false;
            btnMINStop.Enabled = false;
            btnMINPOST.Text = "▮▮";
            btnHrsDown.Enabled = true;
            btnHrsUp.Enabled = true;
            btnMinDown.Enabled = true;
            btnMinUp.Enabled = true;
            btnSecDown.Enabled = true;
            btnSecUp.Enabled = true;

            timerMinutnik.Stop();
            czasMinutnik = TimeSpan.Zero;

            if (isMusicPlaying)
            {
                StopMusic();
                isMusicPlaying = false;
            }

            UpdateLabelMinutnik();
        }

        private void timerMinutnik_Tick(object sender, EventArgs e)
        {
            czasMinutnik = czasMinutnik.Subtract(TimeSpan.FromSeconds(1));

            if (czasMinutnik.TotalSeconds <= 0)
            {
                timerMinutnik.Stop();
                isMinRunning = false;
                btnMINPOST.Enabled = false;
                btnMINPOST.Text = "▮▮";

                isMusicPlaying = true;
                PlayMusic();

                czasMinutnik = TimeSpan.Zero;
                UpdateLabelMinutnik();
            }
            else
            {
                UpdateLabelMinutnik();
            }
        }

        private void PlayMusic()
        {
            try
            {
                string filePath = @"C:\Users\Piotrek\Desktop\Uczelnia\III rok\Semestr I\Programowanie Obiektowe\Laboratoria\Kolokwium 2\KOLOKWIUM2\Zegar\AlarmSound.wav";
                player = new SoundPlayer(filePath);

                player.PlayLooping();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas odtwarzania muzyki: " + ex.Message);
            }
        }

        private void StopMusic()
        {
            try
            {
                player?.Stop();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas zatrzymywania muzyki: " + ex.Message);
            }
        }

        private void ADDAlarm_Click(object sender, EventArgs e)
        {
            UstawianieBudzika ustawianieBudzikaForm = new UstawianieBudzika();
            DialogResult result = ustawianieBudzikaForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                Budzik nowyBudzik = new Budzik
                {
                    Czas = ustawianieBudzikaForm.WybranyCzas,
                    Wlaczony = false,
                };

                // Dodaj budzik do ListView
                DodajBudzikDoPanelu(nowyBudzik);
            }
        }

        private int aktualnaWysokoscPanelu = 0;

        private void DodajBudzikDoPanelu(Budzik budzik)
        {
            // Tworzymy nowy panel dla budzika
            Panel panelBudzik = new Panel();
            panelBudzik.BackColor = ColorTranslator.FromHtml("#1f2029");
            panelBudzik.Size = new Size(640, 52);
            panelBudzik.Location = new Point(23, aktualnaWysokoscPanelu);

            // Label z ustawioną godziną budzika
            Label labelGodzina = new Label();
            labelGodzina.Text = budzik.Czas.ToString(@"hh\:mm");
            labelGodzina.Font = new Font("Lucida Console", 25);
            labelGodzina.ForeColor = Color.FromArgb(196, 195, 202);
            labelGodzina.Location = new Point(10, 10);
            labelGodzina.Size = new Size(200, 40);
            panelBudzik.Controls.Add(labelGodzina);

            // CheckBox do włączania/wyłączania budzika
            CheckBox checkBoxWlacz = new CheckBox();
            checkBoxWlacz.Text = "WŁ/WYŁ";
            checkBoxWlacz.ForeColor = Color.FromArgb(196, 195, 202);
            checkBoxWlacz.Font = new Font("Lucida Console", 8);
            checkBoxWlacz.Size = new Size(80, 50);
            checkBoxWlacz.Location = new Point(400, 3);
            checkBoxWlacz.CheckedChanged += (s, e) =>
            {
                if (checkBoxWlacz.Checked)
                {
                    panelBudzik.BackColor = ColorTranslator.FromHtml("#3a3c4c");
                }
                else
                {
                    panelBudzik.BackColor = ColorTranslator.FromHtml("#1f2029");
                }

                // Dodaj kod obsługujący włączanie/wyłączanie budzika
                budzik.Wlaczony = checkBoxWlacz.Checked;
            };
            panelBudzik.Controls.Add(checkBoxWlacz);

            // Przycisk do usuwania budzika
            Button buttonUsun = new Button();
            buttonUsun.Text = "X";
            buttonUsun.Font = new Font("Lucida Console", 12);
            buttonUsun.ForeColor = Color.FromArgb(31, 32, 41);
            buttonUsun.BackColor = Color.FromArgb(255, 235, 167);
            buttonUsun.FlatStyle = FlatStyle.Popup;
            buttonUsun.FlatAppearance.BorderSize = 0;
            buttonUsun.Size = new Size(30, 30);
            buttonUsun.Location = new Point(600, 10);
            buttonUsun.Click += (s, e) =>
            {
                // Kod obsługujący usuwanie budzika
                panelBudzik.Parent.Controls.Remove(panelBudzik);
                PrzesunPaneliWGore(panelBudzik);
            };
            panelBudzik.Controls.Add(buttonUsun);

            // Wyśrodkuj panel w poziomie
            panelBudzik.Location = new Point((panelBudzikow.Width - panelBudzik.Width) / 2, aktualnaWysokoscPanelu);

            // Dodaj nowy panel budzika do głównego panelu budzików
            panelBudzikow.Controls.Add(panelBudzik);
            AktualizujWysokoscPanelu();
        }

        private void AktualizujWysokoscPanelu()
        {
            // Aktualizuj wysokość panelu
            aktualnaWysokoscPanelu += 55;
        }

        private void PrzesunPaneliWGore(Panel usunietyPanel)
        {
            foreach (Control control in panelBudzikow.Controls)
            {
                if (control is Panel panel && panel != usunietyPanel)
                {
                    if (panel.Location.Y > usunietyPanel.Location.Y)
                    {
                        panel.Location = new Point(panel.Location.X, panel.Location.Y - 55);
                    }
                }
            }

            aktualnaWysokoscPanelu -= 55;
        }

        private async void SprawdzBudziki()
        {
            // Pobierz aktualny czas
            DateTime aktualnyCzas = DateTime.Now;

            // Iteruj przez wszystkie panele budzików
            foreach (Control control in panelBudzikow.Controls)
            {
                if (control is Panel panelBudzik)
                {
                    foreach (Control controlka in panelBudzik.Controls)
                    {
                        if (controlka.GetType().ToString() == "System.Windows.Forms.Label")
                        {
                            czasBudzika = controlka.Text;
                        }
                        if (controlka.GetType().ToString() == "System.Windows.Forms.CheckBox")
                        {
                            if (controlka is CheckBox checkBox)
                            {
                                if (checkBox.Checked)
                                {
                                    if (TimeSpan.TryParseExact(czasBudzika, @"hh\:mm", CultureInfo.InvariantCulture, out TimeSpan CZAS))
                                    {
                                        if (CZAS.Hours == aktualnyCzas.Hour && CZAS.Minutes == aktualnyCzas.Minute && CZAS.Seconds == aktualnyCzas.Second)
                                        {
                                            budzikTimer.Stop();
                                            BUDZIKRINGTONE budzikRingtoneForm = new BUDZIKRINGTONE();
                                            DialogResult result = budzikRingtoneForm.ShowDialog();
                                            if (result == DialogResult.Cancel)
                                            {
                                                checkBox.Checked = false;
                                                budzikTimer.Start();
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void budzikTimer_Tick(object sender, EventArgs e)
        {
            SprawdzBudziki();
        }
    }

    public class Budzik
    {
        public TimeSpan Czas { get; set; }
        public bool Wlaczony { get; set; }
        public Control Kontener { get; set; }

        // Konstruktor
        public Budzik()
        {
            Kontener = new Panel();
        }
    }
}