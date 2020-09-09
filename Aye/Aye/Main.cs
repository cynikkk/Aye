using System;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Speech.Synthesis;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;
using System.Drawing;

/* To do :
 * 
 * Ajouter la liste de commandes
 * Ajouter une fonction pour changer la voix
 * Mettre en place une fonction de sauvegarde
 * Ajouter le Speech to Text ( Aye écris ... )
 * Ajouter la météo
 * Réagir aux insultes
 * Ajouter logiciels connus
 * Mettre les crédits
 * Améliorer l'UI
 * Setup d'installation ( à faire en tout dernier )
 * 
 */


namespace Aye
{
    public partial class Main : Form
    {
        public static Speak speak = new Speak();
        public static string choice;
        public static int volume = 50;
        public static SpeechRecognitionEngine voix = new SpeechRecognitionEngine();
        System.Windows.Forms.Timer stopListeningTimer = new System.Windows.Forms.Timer();

        public Main()
        {
            InitializeComponent();

            voix.SetInputToDefaultAudioDevice();
            speak.Bonjour();

            string[] phrases = GetPhrases();
            voix.LoadGrammar(new Grammar(new GrammarBuilder(new Choices(phrases))));

            voix.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(Voix_SpeechRecognized);
            voix.RecognizeAsync(RecognizeMode.Multiple);

            stopListeningTimer.Tick += new EventHandler(Time_Tick);
            stopListeningTimer.Interval = 1000;

        }

        public static string[] GetPhrases()        {
            string[] phrases = File.ReadAllLines(@"C:\\Users\\" + Environment.UserName + "\\Documents\\Grammaire.txt");
            int index = 0;
            foreach (string phrase in phrases)
            {
                if (phrase == string.Empty)
                {
                    phrases[index] = "Vide";
                }
                index++;
            }
            return phrases;
        }

        public void Say(string msg)
        {
            speak.say(msg);
        }

        private void Voix_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {

            string input = e.Result.Text;

            int switchtabcount = 1;

            switch (input.ToUpper())
            {
                // Recherches internet
                case ("GOOGLE"):
                    Process.Start("http://www.google.fr");
                    Say("Google lancé");
                    break;

                case ("GMAIL"):
                    Process.Start("https://mail.google.com/mail/u/0/#inbox");
                    Say("Gmail lancé");
                    break;

                case ("OUTLOOK"):
                    Process.Start("https://outlook.live.com/owa/");
                    Say("Outlook lancé");
                    break;

                case ("NINEGAG"):
                    Process.Start("https://9gag.com/");
                    Say("Ninegag lancé");
                    break;

                case ("FACEBOOK"):
                    Process.Start("https://www.facebook.com/");
                    Say("Facebook lancé");
                    break;

                case ("YOUTUBE"):
                    Process.Start("https://www.youtube.com/?gl=FR&hl=fr");
                    Say("Youtube lancé");
                    break;

                case ("IBOGIV"):
                    Process.Start("http://ibogiv.com/sq45hgj4mlu4i1v54bfd5487sd/index.php");
                    Say("Ok !");
                    break;

                // Heure
                case ("HEURE"):
                case ("QUELLE HEURE EST IL"):
                case ("HEURE ACTUELLE"):
                case ("IL EST QUELLE HEURE"):
                case ("DIS L'HEURE"):
                    speak.Heure();
                    break;

                // Date
                case ("DATE"):
                case ("QUELLE DATE"):
                case ("ON EST LE COMBIEN"):
                    speak.Date();
                    break;

                // Jour
                case ("JOUR"):
                case ("QUEL JOUR"):
                case ("ON EST QUEL JOUR"):
                    speak.Jour();
                    break;

                // Bonjour !
                case ("HELLO"):
                case ("HELLO AYE"):
                case ("HEY"):
                case ("HEY AYE"):
                case ("SALUT"):
                case ("SALUT AYE"):
                case ("BONJOUR"):
                case ("BONJOUR AYE"):
                    speak.Bonjour();
                    break;

                // QUIT
                case ("QUITTE"):
                case ("AUREVOIR"):
                case ("STOP"):
                    speak.Aurevoir();
                    this.Close();
                    break;

                // Baisse le volume
                case ("BAISSE UN PEU"):
                case ("AYE BAISSE"):
                case ("BAISSE TON VOLUME"):
                    AyeVolume(true);
                    break;

                // Augmente le volume
                case ("AUGMENTE"):
                case ("JE T'ENTEND PAS"):
                case ("JE NE COMPREND PAS"):
                case ("AYE AUGMENTE"):
                    AyeVolume(false);
                    break;

                // Mute
                case ("AYE MUET"):
                case ("MUET"):
                case ("TAIT TOI"):
                case ("AYE TAIT TOI"):
                    AyeMute(true);
                    break;

                // Unmute
                case ("AYE PARLE"):
                case ("PARLE"):
                    AyeMute(false);
                    break;

                // Arette d'écouter
                case ("ARETTE D'ECOUTER"):
                    StopListening();
                    break;

                // Processus
                case ("OUVRE OPERA"):
                    Process.Start("opera.exe");
                    Say("Opera lancé");
                    break;

                case ("FERME OPERA"):
                    EndProcess("opera");
                    Say("Opera fermé");
                    break;

                case ("OUVRE DISCORD"):
                    Process.Start(@"C:\\Users\\" + Environment.UserName + "AppData\\Local\\Discord\\app-0.0.301\\discord.exe");
                    Say("Discord lancé");
                    break;

                case ("FERME DISCORD"):
                    EndProcess("discord");
                    Say("Opera fermé");
                    break;

                case ("OUVRE VISUAL STUDIO"):
                    Process.Start(@"C:\Program Files (x86)\Microsoft Visual Studio\2017\Community\Common7\IDE\devenv.exe");
                    Say("Visual studio lancé");
                    break;

                case ("FERME VISUAL STUDIO"):
                    EndProcess("devenv");
                    Say("Visual studio fermé");
                    break;

                case ("OUVRE STIME"):
                    Process.Start(@"C:\Program Files (x86)\Steam\steam.exe");
                    Say("Stime lancé");
                    break;

                case ("FERME STIME"):
                    EndProcess("steam");
                    Say("Stime fermé");
                    break;

                // Redemarage
                case ("REDEMARRE L'ORDINATEUR"):
                case ("AYE REDEMARRE L'ORDINATEUR"):
                    speak.Aurevoir();
                    Process.Start("shutdown", "/r /t 0"); // argument /r est pour restart
                    break;

                // Extinction
                case ("ETEINT L'ORDINATEUR"):
                case ("AYE ETEINT L'ORDINATEUR"):
                    speak.Aurevoir();
                    Process.Start("shutdown", "/s /t 0");
                    break;

                // Veille
                case ("MET EN VEILLE L'ORDINATEUR"):
                case ("AYE MET EN VEILLE L'ORDINATEUR"):
                    speak.Aurevoir();
                    LockWorkStation();
                    break;

                // Log off
                case ("DECONNECTE MOI"):
                case ("AYE DECONNECTE MOI"):
                    speak.Aurevoir();
                    ExitWindowsEx(0, 0);
                    break;

                // tab switch
                case "SWITCH":
                case "CHANGE DE FENETRE":
                    SendKeys.Send("%{TAB " + switchtabcount + "}");
                    switchtabcount += 1;
                    Say("Ok !");
                    break;

                // Pas de commande assignée
                default:
                    NoCommand();
                    break;
            }
        }

        int time = 60;
        public void StopListening()
        {
            time = 60;
            voix.RecognizeAsyncStop();
            stopListeningTimer.Start();
        }

        private void Time_Tick(object sender, EventArgs e)
        {
            time = time - 2;
            Console.WriteLine(time.ToString());
            if (time == 0)
            {
                voix.RecognizeAsync(RecognizeMode.Multiple);
                stopListeningTimer.Stop();
            }
        }

        public static void AyeVolume(bool volumeDown)
        {

            speak.ayeVol(volumeDown);
        }

        public static void AyeMute(bool mute)
        {
            speak.ayeVol(mute);
        }

        [DllImport("user32")]
        public static extern bool ExitWindowsEx(uint uFlags, uint dwReason);

        [DllImport("user32")]
        public static extern void LockWorkStation();

        private void EndProcess(string process)
        {
            Process[] processes = Process.GetProcesses();
            foreach (Process currentProcess in processes)
            {
                if (currentProcess.ProcessName.ToString().ToUpper().Contains(process.ToUpper()))
                {
                    currentProcess.Kill();
                }
            }
        }

        private void NoCommand()
        {
            Thread noOptAvail = new Thread(new ThreadStart(() => speak.noOptions()))
            {
                IsBackground = true
            };
            noOptAvail.Start();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            speak.Aurevoir();
            this.Close();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = HomeButton.Height;
            SidePanel.Top = HomeButton.Top;
            homeControl1.BringToFront();

        }

        private void CmdButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = CmdButton.Height;
            SidePanel.Top = CmdButton.Top;
            cmdControl1.BringToFront();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = SettingsButton.Height;
            SidePanel.Top = SettingsButton.Top;
            settingsControl1.BringToFront();
        }
    }
}
