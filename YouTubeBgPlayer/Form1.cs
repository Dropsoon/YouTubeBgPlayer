using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System.IO;
using MetroFramework;

using MetroFramework.Components;
using MetroFramework.Forms;

namespace YouTubeBgPlayer
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;

        string[] qId = new string[1024];
        string[] qTitle = new string[1024];
        int addedSongs = 0;
        int currentSong = 0;
        bool bStopClicekd = false;
        bool bTextClicked = false;
        bool nextorprev = false;
        float volume = 0.1f;
        public Form1()
        {
            InitializeComponent();
            var flowPanel = this.flowControls;
            flowPanel.FlowDirection = FlowDirection.LeftToRight;
            flowPanel.Margin = new Padding(10);

            var buttonPlay = this.buttonPlay;
            buttonPlay.Text = "Play";
            buttonPlay.Click += buttonPlay_Click;
            flowPanel.Controls.Add(buttonPlay);

            var buttonStop = this.buttonStop;
            buttonStop.Text = "Stop";
            buttonStop.Click += buttonStop_Click;
            flowPanel.Controls.Add(buttonStop);

            this.Controls.Add(flowPanel);

            this.FormClosing += buttonStop_Click;

            LoadData();
        }

        public void LoadData()
        {
            FileStream fs;
            if (File.Exists("songs/ids.txt"))
            {
                fs = File.OpenRead("songs/ids.txt");
                var sr = new StreamReader(fs);
                string line;
                int i = 0;
                while((line = sr.ReadLine()) != null)
                {
                    qId[i++] = line;
                    addedSongs++;
                }
                fs.Close();
            } else
            {
                
                File.Create("songs/ids.txt");
            }
            for(int i=0; i<addedSongs; i++)
            {
                string filename = "songs/data/" + qId[i] + ".txt";
                fs = File.OpenRead(filename);
                var sr = new StreamReader(fs);
                string line = sr.ReadLine();
                if(line == qId[i])
                {
                    line = sr.ReadLine();
                    qTitle[i] = line;
                }
                fs.Close();
            }
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if (outputDevice == null)
            {
                outputDevice = new WaveOutEvent();
                outputDevice.PlaybackStopped += OnPlaybackStopped;
            }
            if (audioFile == null)
            {
                if(addedSongs > 0)
                {
                    string fileName = "songs/files/" + qId[currentSong] + ".mp3";
                    audioFile = null;
                    audioFile = new AudioFileReader(fileName);
                    outputDevice.Init(audioFile);
                    audioFile.Volume = volume;
                }
                
            }
            outputDevice.Play();
        }

        private void OnPlaybackStopped(object sender, StoppedEventArgs args)
        {
            if(currentSong != addedSongs-1 && !bStopClicekd && !nextorprev)
            {
                currentSong++;
                string fileName = "songs/files/" + qId[currentSong] + ".mp3";
                audioFile = null;
                audioFile = new AudioFileReader(fileName);
                outputDevice.Init(audioFile);
                audioFile.Volume = volume;
                outputDevice.Play();
                bStopClicekd = false;
            }
            else if(!nextorprev)
            {
                outputDevice.Dispose();
                outputDevice = null;
                audioFile.Dispose();
                audioFile = null;
                bStopClicekd = false;
            }
            else
            {
                nextorprev = false;
            }
            
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            outputDevice?.Stop();
            bStopClicekd = true;
        }

        private void bNext_Click(object sender, EventArgs e)
        {
            if(currentSong != addedSongs - 1)
            {
                nextorprev = true;
                outputDevice?.Stop();
                currentSong++;
                string fileName = "songs/files/" + qId[currentSong] + ".mp3";
                audioFile = null;
                audioFile = new AudioFileReader(fileName);
                outputDevice.Init(audioFile);
                audioFile.Volume = volume;
                outputDevice.Play();
                bStopClicekd = false;
            }
        }

        private void bPrevious_Click(object sender, EventArgs e)
        {
            if (currentSong != 0)
            {
                nextorprev = true;
                outputDevice?.Stop();
                currentSong--;
                string fileName = "songs/files/" + qId[currentSong] + ".mp3";
                audioFile = null;
                audioFile = new AudioFileReader(fileName);
                outputDevice.Init(audioFile);
                audioFile.Volume = volume;
                outputDevice.Play();
                bStopClicekd = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tLink_MouseClick(object sender, MouseEventArgs e)
        {
            if (!bTextClicked)
            {
                this.tLink.Text = "";
                bTextClicked = true;
            }
        }

        private void tLink_MouseDoubleClick(object sender, MouseEventArgs e) //show dialog with waild links
        {

        }
    }
}
