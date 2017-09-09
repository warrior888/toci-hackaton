using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Speech.Recognition;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Cloud.Speech.V1;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;

namespace Krystek
{
    public partial class Form1 : Form
    {
        List<string> users = new List<string>();
        Dictionary<string, List<Label>> mapa = new Dictionary<string, List<Label>>();

        public Form1()
        {
            InitializeComponent();
            Test();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            users.Add(userTexbox.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 20;
            int save = 40;

            

            foreach (string user in users)
            {
                List<Label> labele = mapa.ContainsKey(user) ? mapa[user] : new List<Label>();
                Label Player = new Label();
                labele.Add(Player);
                
                Player.Text = user;
                save = save + i;
                Player.Location = new Point(20, save);
                Controls.Add(Player);
                if (mapa.ContainsKey(user))
                {

                    mapa[user] = labele;
                }
                else
                {

                    mapa.Add(user, labele);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            users.Remove(userTexbox.Text);
            foreach (Label lb in mapa[userTexbox.Text])
            {
                Controls.Remove(lb);
            }
            
            mapa.Remove(userTexbox.Text);
        }

        public class QuickStart
        {
            public static void Maing()
            {
                GoogleCredential credential = GoogleCredential.GetApplicationDefault();


                var speech = SpeechClient.Create();
                var response = speech.Recognize(new RecognitionConfig()
                {
                    Encoding = RecognitionConfig.Types.AudioEncoding.Linear16,
                    SampleRateHertz = 16000,
                    LanguageCode = "en",
                }, RecognitionAudio.FromFile("example.wav"));
                foreach (var result in response.Results)
                {
                    foreach (var alternative in result.Alternatives)
                    {
                        Console.WriteLine(alternative.Transcript);
                    }
                }
            }
        }

        public virtual void Test()
        {
            QuickStart.Maing();
                /*SR = new Microsoft.Bing.Speech.SpeechRecognizer("en-US", credentials);

                // Add speech recognition event handlers.
                SR.onaudiocapturestatechanged = SR_AudioCaptureStateChanged;
                SR.onaudiolevelchanged = SR_AudioLevelChanged;
                SR.onrecognizerresultreceived = SR_RecognizerResultReceived;

                Plugin.BingSpeech.BingSpeech.Current
                Plugin.BingSpeech.BingSpeech.Current.MicrophoneService.StartRecording("ex.lol");
                */
                //SpeechRecognitionEngine en = new SpeechRecognitionEngine();
                //en.

                //    speechrecognitions
                //    en.SetInputToAudioStream()
                ;
            //RequestMetadata mt = new RequestMetadata(new Guid(), new DeviceMetadata(DeviceType.Near, DeviceFamily.Laptop, NetworkType.CellLTE, OsName.Windows, "10", "", ""), new ApplicationMetadata("8", "8.8"), "999");
            //Microsoft.Bing.Speech.SpeechInput si = new SpeechInput(File.OpenRead(@"c:\example.wav"), mt);
            
        }
    }
}
