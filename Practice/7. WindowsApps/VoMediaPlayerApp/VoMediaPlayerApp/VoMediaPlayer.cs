using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoMediaPlayerApp
{
    public partial class VoMediaPlayer : MetroFramework.Forms.MetroForm
    {
        string baseDebugDirectory = Environment.CurrentDirectory;
        string playerCommandsPath;

        OpenFileDialog ofdBrowse = new OpenFileDialog();

        SpeechRecognitionEngine reconnizer = new SpeechRecognitionEngine();
        SpeechSynthesizer sarah = new SpeechSynthesizer();
        SpeechRecognitionEngine startListening = new SpeechRecognitionEngine();
        Random random = new Random();
        int reconnizeTimeOut = 0;
        DateTime timeNow = DateTime.Now;


        public VoMediaPlayer()
        {
            InitializeComponent();
        }

        private void VoMediaPlayer_Load(object sender, EventArgs e)
        {
            axWMP.currentPlaylist.clear();
#if DEBUG
            playerCommandsPath = Path.GetFullPath(Path.Combine(baseDebugDirectory, @"..\..\PlayerCommands.txt"));
#else
            playerCommandsPath = Path.GetFullPath(Path.Combine(baseDebugDirectory, @"PlayerCommands.txt"));
#endif
            reconnizer.SetInputToDefaultAudioDevice();
            reconnizer.LoadGrammarAsync(new Grammar(new GrammarBuilder(new Choices(File.ReadAllLines(playerCommandsPath)))));
            reconnizer.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(Default_SpeechRecognized);
            reconnizer.SpeechDetected += new EventHandler<SpeechDetectedEventArgs>(Recognizer_SpeechRecognized);
            reconnizer.RecognizeAsync(RecognizeMode.Multiple);

            startListening.SetInputToDefaultAudioDevice();
            startListening.LoadGrammarAsync(new Grammar(new GrammarBuilder(new Choices(File.ReadAllLines(playerCommandsPath)))));
            startListening.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(StartListening_SpeechRecognized);

        }
        void Default_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            string speech = e.Result.Text;

            if (speech == "Default video")
            {
                sarah.SpeakAsync("Ok");
#if DEBUG
                axWMP.URL = Path.GetFullPath(Path.Combine(baseDebugDirectory, @"..\..\Videos\Allah Ya Rehman.mp4"));
#else
                axWMP.URL = Path.GetFullPath(Path.Combine(baseDebugDirectory, @"Videos\Allah Ya Rehman.mp4"));
#endif
            }

            if (speech == "Open")
            {
                ofdBrowse.Filter = "(mp3,wav,mp4,mov,wmv,mpg)|*.mp3;*.wav;*.mp4;*.mov;*.wmv;*.mpg|all files|*.*";
                if (ofdBrowse.ShowDialog() == DialogResult.OK)
                    axWMP.URL = ofdBrowse.FileName;
            }

            if (speech == "Play")
            {
                if (!string.IsNullOrWhiteSpace(axWMP.URL))
                {
                    axWMP.Ctlcontrols.play();
                }
                else
                {
                    sarah.SpeakAsync("Please open a video.");
                }
            }

            if (speech == "Pause")
            {
                if (!string.IsNullOrWhiteSpace(axWMP.URL))
                {
                    axWMP.Ctlcontrols.pause();
                }
                else
                {
                    sarah.SpeakAsync("Please open a video.");
                }
            }

            if (speech == "Stop")
            {
                axWMP.Ctlcontrols.stop();
                sarah.SpeakAsync("If you need me just ask");
                reconnizer.RecognizeAsyncCancel();
                startListening.RecognizeAsync(RecognizeMode.Multiple);
            }

            if (speech == "Clear")
            {
                sarah.SpeakAsync("Done!");
                axWMP.currentPlaylist.clear();
            }

            if (speech == "Exit")
            {
                Application.Exit();
            }

        }

        private void Recognizer_SpeechRecognized(object sender, SpeechDetectedEventArgs e)
        {
            reconnizeTimeOut = 0;
        }

        private void StartListening_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            string speech = e.Result.Text;
            if (speech == "Wake up")
            {
                startListening.RecognizeAsyncCancel();
                sarah.SpeakAsync("Yes, I am here");
                reconnizer.RecognizeAsync(RecognizeMode.Multiple);
            }
        }

        private void TmrSpeaking_Tick(object sender, EventArgs e)
        {
            if (reconnizeTimeOut == 10)
            {
                reconnizer.RecognizeAsyncCancel();
            }
            else if (reconnizeTimeOut == 11)
            {
                TmrSpeaking.Stop();
                startListening.RecognizeAsync(RecognizeMode.Multiple);
            }
        }


    }
}

