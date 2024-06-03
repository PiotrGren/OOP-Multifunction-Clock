using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zegar
{
    public partial class BUDZIKRINGTONE : Form
    {
        private SoundPlayer player;
        public BUDZIKRINGTONE()
        {
            InitializeComponent();
        }

        private void CANCLEButton_Click(object sender, EventArgs e)
        {
            StopMusic();

            DialogResult = DialogResult.Cancel;
            Close();
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

        private void BUDZIKRINGTONE_Load(object sender, EventArgs e)
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
    }
}
