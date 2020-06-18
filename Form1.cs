using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace Metronome
{
    public partial class Form1 : Form
    {
        public double BPMrate;
        public bool isPlaying;


        //the metronome sound
        SoundPlayer player = new SoundPlayer(@"C:\Users\tmcar\source\repos\Metronome\Sounds\button-16.wav");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            isPlaying = false;
            
        }



        private void setBPM_Click(object sender, EventArgs e)
        {
            metronomeBackgroundWorker.CancelAsync();
            //setting the BPM variable to what was inputted in the textbox on the click of the setBPM button
            double testDouble = 0;
            double.TryParse(BPMinput.Text, out testDouble);
            if (testDouble == 0)
            {
                BPMinput.Text = "";
            }
            else
            {
                BPMrate = testDouble;
            }
        }

        private void BPMLabel_Click(object sender, EventArgs e)
        {

        }

        private void BPMtxt_Changed(object sender, EventArgs e)
        {

        }

        private void Metronome()
        {
            //creating an array of radio buttons to allow me to more easily iterate through them while toggling their value
            RadioButton[] radioButtons = { mTimer1, mTimer2, mTimer3, mTimer4 };
            while (isPlaying == true)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (isPlaying == false) { break; }
                    radioButtons[i].Checked = true;
                    player.Play();
                    //converting the BPMrate into miliseconds so the delay can correspond with the BPM
                    Thread.Sleep(Convert.ToInt32(Math.Round(60000/BPMrate)));
                    radioButtons[i].Checked = false;
                }

            }
            
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            //setting playing boolean with button while changing the text of the button and toggling background worker
            if(isPlaying == false)
            {
                
                isPlaying = true;
                if (metronomeBackgroundWorker.IsBusy == false)
                {
                    playButton.Text = "STOP";
                    metronomeBackgroundWorker.RunWorkerAsync();
                }                
            }
            else if(isPlaying == true)
            {
               
                    isPlaying = false;
                    playButton.Text = "PLAY";
                    metronomeBackgroundWorker.CancelAsync();
                
            }
        }

        private void MetronomeBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
           //running metronome in background worker to allow its click to run asynchronously
                Metronome();
            
        }

        private void MetronomeBackgroundWorker_Completed(object sender, RunWorkerCompletedEventArgs e)
        {
            
        }


    }
}
