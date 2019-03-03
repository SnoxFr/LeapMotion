using Leap;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Threading;
using System.Configuration;
using System.Diagnostics;
using System.ServiceProcess;

using System.IO.Ports;

namespace WinFormSample
{
    // ! Attention solution à lancer en administrateur !

    public partial class FrameDataForm : Form
    {
        //Buffer pour communication serie
        Byte[] Buffer;
        //serial com
        private SerialPort port = new SerialPort("COM1", 9600, Parity.None, 8, StopBits.One);

        //Déclaration de mon dictionnaire qui sert de Buffer de longueur pour les doigts
        //Premier champ le numéro du doigt
        //Deuxième champ la longueur du doigt
        public class MultiDimDictList : Dictionary<int, List<float>> { }

        //Dictionnaire de la main droite / gauche
        MultiDimDictList BufferLenghtRight = new MultiDimDictList();
        MultiDimDictList BufferLenghtLeft = new MultiDimDictList();


        //Instanciation du timer /1s 
        private static System.Timers.Timer aTimer;
        private Random rnd = new Random();
        //Liste des mains vue dans la Frame 
        List<Hand> Hands = new List<Hand>();

        // Liste des doigts de la main droite / gauche 
        List<Finger> fingersRight = new List<Finger>();
        List<Finger> fingersLeft = new List<Finger>();



        //Tableau des Leds de position des doigts (16 positions) // POC zone d'interaction
        Label[] Position;
        //Déclaration des vecteurs pour le positionnement (16 positions) //POC zone de detection
        Vector PianoDoigt1, PianoDoigt2, PianoDoigt3, PianoDoigt4, PianoDoigt5,
            PianoDoigt6, PianoDoigt7, PianoDoigt8, PianoDoigt9, PianoDoigt10;

        //Tableau des labels de longeurs des doigts lissés // Ligne 3 de l'IHM
        Label[] LenghtLabel;
        //Tableau des Lables de distances entre le bout des doigts et le centre de la paume // Ligne 2 de l'IHM
        Label[] InstantPressureLabel;
        //Tableau des Lables de distances entre le bout des doigts et le centre de la paume // Ligne 4 de l'IHM
        Label[] FakeLed;
        //Leds indiquant si l'appui maximal a été atteint // Ligne 1 de l'IHM
        Label[] Leds;

        //Tableau des longueurs des doigts lissés 
        int[] LenghtLissé = new int[10];
        //Tableau des valeurs d'appui maximal pour chaque doigt
        double[] MaxPressure = new double[10];
        //Tableau des distances entre le bout des doigts et le centre de la paume
        int[] InstantPosition = new int[10];
        //Tableau des commandes appliqués par chaque doigt
        double[] InstantPressure = new double[10];
        //Tableau des valeurs d'appui minimal pour chaque doigt
        int[] MinPressure = new int[10];


        //Intanciation de l'objet frame (Une image traité par le sdk)
        Frame frame = new Frame();
        //Intanciation de l'objet device 
        Device device;
        //Instanciation de l'objet controller (Leap Motion)
        private Controller controller = new Controller();
        //Recherche du service correspondant au LeapMotion
        ServiceController LeapMotionService = new ServiceController("Leap Service");
        //Boite d'interaction
        InteractionBox Box;

        private byte[] imagedata = new byte[1];

        //Tableau contenant les objets player des notes du piano 
        SoundPlayer[] Note;
        //Objet Hand qui permet de stocker la main droigt / gauche pendant les traitements 
        Hand handRight = new Hand();
        Hand handLeft = new Hand();
        //Même fonction 
        Hand handTempo = new Hand();
        Hand handTempo2 = new Hand();

        //Tableau stockant les l'ensemble des doigts de type Vector
        Vector[] VectorFingerRight;
        Vector[] VectorFingerLeft;
        Vector[] PianoDoigtRight;
        Vector[] PianoDoigtLeft;
        Vector[] BoneMetaCarpalList;
        //Instanciation des Vector de l'ensemble des doigts 
        Vector Finger1, Finger2, Finger3, Finger4, Finger5, Finger6, Finger7, Finger8, Finger9, Finger10;
        //Déclaration des objets Bone pour utilisation dans l'ensemble de la solution
        Bone boneMetaCarpal, boneProximal, boneIntermediate, boneDistal;

        //Indique si l'appli est instancié en mode debug ou non
        bool ModeDebug;
        //Indique si l'on souhaite jouer des sons ou non 
        bool Sound;
        int SliderValue = 0;



        public FrameDataForm()
        {
            InitializeComponent();
            //Fenêtre non resizable
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            //Ouverture du port COM
            try
            {
                port.Open();
                Buffer = new byte[12];
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine("Error: Port {0} is in use Com1");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Uart exception: " + ex);
            }

            //Redemarrage du service LeapMotion
            if (LeapMotionService.Status.Equals(ServiceControllerStatus.Stopped))
            {
                LeapMotionService.Start();
            }
            if (LeapMotionService.Status.Equals(ServiceControllerStatus.Running))
            {
                LeapMotionService.Stop();
                LeapMotionService.Start();
            }
            /* Configuration et remplissage pour le POC Zone d'interaction
            Vector size = new Vector(200f, 1f, 1f);
            Box = new InteractionBox(Box.Center, size);
            PianoDoigtRight = new Vector[] { PianoDoigt1, PianoDoigt2, PianoDoigt3, PianoDoigt4, PianoDoigt5 };
            PianoDoigtLeft = new Vector[] { PianoDoigt6, PianoDoigt7, PianoDoigt8, PianoDoigt9, PianoDoigt10 };
            */

            //Remplissage des objets dans les tableaux pour utilisation facilitée
            LenghtLabel = new Label[] { lenght1, lenght2, lenght3, lenght4, lenght5, lenght6, lenght7, lenght8, lenght9, lenght10 };
            InstantPressureLabel = new Label[] { Doigt1, Doigt2, Doigt3, Doigt4, Doigt5, Doigt6, Doigt7, Doigt8, Doigt9, Doigt10 };
            Leds = new Label[] { Led1, Led2, Led3, Led4, Led5, Led6, Led7, Led8, Led9, Led10 };
            VectorFingerRight = new Vector[] { Finger1, Finger2, Finger3, Finger4, Finger5 };
            VectorFingerLeft = new Vector[] { Finger6, Finger7, Finger8, Finger9, Finger10 };
            FakeLed = new Label[] { FakeLed5, FakeLed4, FakeLed3, FakeLed2, FakeLed1, FakeLed6, FakeLed7, FakeLed8, FakeLed9, FakeLed10 };

            //Remplissage objet buffer droit
            for (int i = 0; i < 5; i++)
            {
                BufferLenghtRight.Add(i, new List<float>());
            }

            //Remplissage objet buffer gauche
            for (int i = 0; i < 5; i++)
            {
                BufferLenghtLeft.Add(i, new List<float>());
            }

            //Configuration de la zone d'interaction du LeapMotion
            controller.Config.SetFloat("InteractionBox.Width", 1300.0f);
            controller.Config.SetFloat("InteractionBox.Height", 600.0f);

            //Configuration du Timer pour thread Lissage
            aTimer = new System.Timers.Timer();
            aTimer.Interval = 1000;
            aTimer.Elapsed += Lissage;
            aTimer.AutoReset = true;
            // Démarrage du timer
            aTimer.Enabled = true;

            //Association événement fonction 
            controller.EventContext = WindowsFormsSynchronizationContext.Current;
            controller.FrameReady += newFrameHandler;
            controller.ImageReady += onImageReady;
            controller.ImageRequestFailed += onImageRequestFailed;
            controller.InternalFrameReady += isConnected;
            controller.DeviceLost += isDisconnected;
            controller.DeviceFailure += OnDeviceFailure;
            Slider.ValueChanged += SliderChanged;

            //Récupération des arguments d'appel
            string[] args = Environment.GetCommandLineArgs();


            //Process arguments
            if (args.Length == 1)
            {
                Console.WriteLine("Too few arguments");
                System.Environment.Exit(1);
            }
            if (args.Length > 4)
            {
                Console.WriteLine("Too much arguments");
                System.Environment.Exit(1);
            }
            if (args[1].Equals("Debug"))
            {
                ModeDebug = true;
            }

            else if (args[1].Equals("Release"))
            {
                ModeDebug = false;
            }
            else
            {
                Console.WriteLine("Argument 1 incorrect");
                System.Environment.Exit(1);
            }
            if (args.Length == 3)
            {
                if (Int32.TryParse(args[2], out int args2Int))
                {
                    if (args2Int >= 0 && args2Int <= 30)
                    {
                        Slider.Value = args2Int;
                        Console.WriteLine(args2Int);
                    }
                    else
                    {
                        Console.WriteLine("Argument 2 incorrect Value");
                        System.Environment.Exit(1);
                    }
                }
                else
                {
                    Console.WriteLine("Argument 2 incorrect type");
                    System.Environment.Exit(1);
                }

            }
            if (args.Length == 4)
            {
                if (args[3].Equals("Sound"))
                {
                    Sound = true;
                }

                else if (args[3].Equals("Mute"))
                {
                    Sound = false;
                }
                else
                {
                    Console.WriteLine("Argument 3 incorrect");
                    System.Environment.Exit(1);
                }

            }

            //Chargement de la dernière valeur de sensibilité stockee dans le fichier de config
            Slider.Value = Int32.Parse(ConfigurationManager.AppSettings["LastSliderValue"]);

            //Chargement et intanciation player son
            SoundPlayer Note5 = new SoundPlayer();
            Note5.SoundLocation = ".\\Sons\\Note5.wav";
            Note5.LoadAsync();

            SoundPlayer Note2 = new SoundPlayer();
            Note2.SoundLocation = ".\\Sons\\Note2.wav";
            Note2.LoadAsync();

            SoundPlayer Note3 = new SoundPlayer();
            Note3.SoundLocation = ".\\Sons\\Note3.wav";
            Note3.LoadAsync();

            SoundPlayer Note4 = new SoundPlayer();
            Note4.SoundLocation = ".\\Sons\\Note4.wav";
            Note4.LoadAsync();

            SoundPlayer Note10 = new SoundPlayer();
            Note10.SoundLocation = ".\\Sons\\Note10.wav";
            Note10.LoadAsync();

            SoundPlayer Note6 = new SoundPlayer();
            Note6.SoundLocation = ".\\Sons\\Note6.wav";
            Note6.LoadAsync();

            SoundPlayer Note7 = new SoundPlayer();
            Note7.SoundLocation = ".\\Sons\\Note7.wav";
            Note7.LoadAsync();

            SoundPlayer Note8 = new SoundPlayer();
            Note8.SoundLocation = ".\\Sons\\Note8.wav";
            Note8.LoadAsync();

            SoundPlayer Note9 = new SoundPlayer();
            Note9.SoundLocation = ".\\Sons\\Note9.wav";
            Note9.LoadAsync();

            SoundPlayer Note1 = new SoundPlayer();

            //Stockage dans un tableau d'objet 
            Note = new SoundPlayer[] { Note6, Note7, Note8, Note9, Note10, Note5, Note4, Note3, Note2, Note1 };

            Note1.SoundLocation = ".\\Sons\\Note1.wav";
            //Une fois que tout les sons sont chargés on démarre le thread Lissage
            Note[9].LoadCompleted += new AsyncCompletedEventHandler(ThreadHandler);
            Note1.LoadAsync();
        }

        //Evenement connexion LeapMotion
        void isConnected(object sender, InternalFrameEventArgs eventArgs)
        {
            if (controller.IsConnected)
            {
                ConnectionUSB.BackColor = Color.Green;
            }

        }

        //Evenement deconnexion LeapMotion
        void isDisconnected(object sender, DeviceEventArgs eventArgs)
        {
            ConnectionUSB.BackColor = Color.Red;
        }

        //Ecriture de la valeur de sensibilite à chaque modification
        void SliderChanged(object sender, EventArgs e)
        {
            SliderValue = Slider.Value;
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["LastSliderValue"].Value = Slider.Value.ToString();
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        // Recuperation d'une nouvelle image traitée par le SDK
        void newFrameHandler(object sender, FrameEventArgs eventArgs)
        {
            if (ModeDebug == false)
            {
                this.Hide();
            }

            frame = eventArgs.frame;
            handRight = null;
            handLeft = null;

            //Mise à jour IHM monitoring
            displayFPS.Text = frame.CurrentFramesPerSecond.ToString();
            displayHandCount.Text = frame.Hands.Count.ToString();
            controller.RequestImages(frame.Id, Leap.Image.ImageType.DEFAULT, imagedata);


            //Selection du premier device 
            device = controller.Devices[0];

            //Remplissage objet
            if (frame.Hands.Count > 0)
            {
                Hands = frame.Hands;
                foreach (Hand e in Hands)
                {
                    if (e.IsLeft)
                    {
                        handLeft = e;
                        fingersLeft = e.Fingers;

                    }
                    if (e.IsRight)
                    {
                        handRight = e;
                        fingersRight = e.Fingers;

                    }
                }

                if (handRight != null)
                {
                    Confidence.Text = handRight.Confidence.ToString();


                    for (int i = 0; i < 5; i++)
                    {
                        //Remplissage avec les valeurs stabilisés
                        VectorFingerRight[i] = fingersRight[i].StabilizedTipPosition;
                        //Calcul de distance entre la paume et le bout de chaque doigt
                        InstantPosition[i] = (int)VectorFingerRight[i].DistanceTo(handRight.PalmPosition);

                        //Calcul spécial pouce
                        if (i == 0)
                        {
                            if (handRight.PalmPosition.y - VectorFingerRight[i].y > 0)
                            {
                                InstantPosition[i] = (int)(handRight.PalmPosition.y - VectorFingerRight[i].y);
                            }
                            else
                            {
                                InstantPosition[i] = 0;
                            }
                        }

                        // Recupération de la position de chque doigt normalisé par rapport à la zone d'interaction//Process pour POC Zone d'interaction
                        PianoDoigtRight[i] = Box.NormalizePoint(VectorFingerRight[i], true);

                        //Récupération de la position de la dernière articulation avant la paume 
                        BoneMetaCarpalList[i] = fingersRight[i].Bone(Bone.BoneType.TYPE_METACARPAL).NextJoint;

                        //Calcul de pression miniaml à partir des valeurs de longueur des doigts lissés
                        MinPressure[i] = (int)BoneMetaCarpalList[i].DistanceTo(handRight.PalmPosition) + GetLenghtLisséRight(i);
                    }

                    for (int i = 0; i < fingersRight.Count; i++)
                    {
                        //Affichage IHM instant pressure avec deux digits
                        InstantPressureLabel[i].Text = InstantPressure[i].ToString("0.00");
                        //Affichage IHM longeurs doigt lissés
                        LenghtLabel[i].Text = LenghtLissé[i].ToString();

                    }

                    /* PROCESS POC Zone d'interactions
                    // En l'état il ne fonctionne pas il faut rajouter les labels positions dans l'IHM
                    //Il fonctionne uniquement avec la main droite
                     
                       for (int x = 0; x < 16; x++)
                       {
                           Position[x].BackColor = Color.LightGray;
                       }
                       for (int x = 0; x < 16; x++)
                       {
                           if (PianoDoigtRight[0].x > (x / 16f) && PianoDoigtRight[0].x < ((x + 1) / 16f))
                           {
                               Position[x].BackColor = Color.Green;
                           }
                           if (PianoDoigtRight[1].x > (x / 16f) && PianoDoigtRight[1].x < ((x + 1) / 16f))
                           {
                               Position[x].BackColor = Color.Red;
                           }
                           if (PianoDoigtRight[2].x > (x / 16f) && PianoDoigtRight[2].x < ((x + 1) / 16f))
                           {
                               Position[x].BackColor = Color.Blue;
                           }
                           if (PianoDoigtRight[3].x > (x / 16f) && PianoDoigtRight[3].x < ((x + 1) / 16f))
                           {
                               Position[x].BackColor = Color.Orange;
                           }
                           if (PianoDoigtRight[4].x > (x / 16f) && PianoDoigtRight[4].x < ((x + 1) / 16f))
                           {
                               Position[x].BackColor = Color.Purple;
                           }
                       }
                       */

                }
                else
                {
                    for (int i = 0; i < 5; i++)
                    {
                        Leds[i].BackColor = Color.Red;
                    }

                }
                //Même process pour la main gauche mais avec des index différents
                if (handLeft != null)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        VectorFingerLeft[i] = fingersLeft[i].StabilizedTipPosition;
                        PianoDoigtLeft[i] = Box.NormalizePoint(VectorFingerLeft[i], true);
                    }

                    for (int i = 5; i < fingersLeft.Count + 5; i++)
                    {
                        //Affichage IHM instant pressure avec deux digits
                        InstantPressureLabel[i].Text = InstantPressure[i].ToString("0.00");
                        //Affichage IHM longeurs doigt lissés
                        LenghtLabel[i].Text = LenghtLissé[i].ToString();
                        //Affichage IHM position instantannée
                        InstantPosition[i] = (int)VectorFingerLeft[i - 5].DistanceTo(handLeft.PalmPosition);

                        //Calcul spécial pouce
                        if (i == 5)
                        {
                            if (handLeft.PalmPosition.y - VectorFingerLeft[0].y > 0)
                            {
                                InstantPosition[i] = (int)(handLeft.PalmPosition.y - VectorFingerLeft[0].y);
                            }
                            else
                            {
                                InstantPosition[i] = 0;
                            }
                        }
                        BoneMetaCarpalList[i] = fingersLeft[i - 5].Bone(Bone.BoneType.TYPE_METACARPAL).NextJoint;
                        MinPressure[i] = (int)BoneMetaCarpalList[i].DistanceTo(handLeft.PalmPosition) + GetLenghtLisséLeft(i - 5);
                    }
                }
            }
        }

        //Récupération évenement ImageRequestFailed cf Manuel Developpeur
        void onImageRequestFailed(object sender, ImageRequestFailedEventArgs e)
        {
            if (ModeDebug)
            {
                if (e.reason == Leap.Image.RequestFailureReason.Insufficient_Buffer)
                {
                    imagedata = new byte[e.requiredBufferSize];
                }
                Console.WriteLine("Image request failed: " + e.message);
            }
        }

        //Récupération évenement ImageReady cf Manuel Developpeur
        void onImageReady(object sender, ImageEventArgs e)
        {

            //State
            Device device = controller.Devices[0];
            //Smudged
            if (device.IsSmudged)
            {
                Clean.Text = "Dirty";
                Clean.BackColor = Color.Red;
            }
            else
            {
                Clean.Text = "Clean";
                Clean.BackColor = Color.Green;
            }
            //Lightning Conditions
            if (device.IsLightingBad)
            {
                Lightning.Text = "Bad";
                Lightning.BackColor = Color.Red;
            }
            else
            {
                Lightning.Text = "Good";
                Lightning.BackColor = Color.Green;
            }
        }

        //Récupération évenement DeviceFailure cf Manuel Developpeur
        public void OnDeviceFailure(Object sender, DeviceFailureEventArgs e)
        {
            Controller controller = sender as Controller;
            FailedDeviceList badDevices = controller.FailedDevices();
            foreach (FailedDevice badDevice in badDevices)
            {
                switch (badDevice.Failure)
                {
                    case FailedDevice.FailureType.FAIL_CALIBRATION:
                        FailureReason.Text = "has bad calibration record.";
                        break;
                    case FailedDevice.FailureType.FAIL_CONTROL:
                        FailureReason.Text = "failed to establish USB control interfaces.";
                        break;
                    case FailedDevice.FailureType.FAIL_FIRMWARE:
                        FailureReason.Text = "has corrupt firmware or failed to update";
                        break;
                    case FailedDevice.FailureType.FAIL_TRANSPORT:
                        FailureReason.Text = "not responding.";
                        break;
                    case FailedDevice.FailureType.FAIL_UNKNOWN:
                        FailureReason.Text = "failed for unknown reason.";
                        break;
                }

            }
        }

        void ThreadHandler(object sender, EventArgs e)
        {
            if (ModeDebug)
            {
                //Thread calc commande Led main gauche
                Task.Factory.StartNew(() =>
            {
                //Temporisation démarrage pour les traitement SDK
                Thread.Sleep(1000);

                while (true)
                {
                    if (handLeft != null)
                    {
                        //Conservation objet hand durant le traitement -> deadlock
                        handTempo = handLeft;

                        for (int i = 0; i < fingersLeft.Count; i++)
                        {
                            //Temporisation optisation perf
                            Thread.Sleep(10);

                            if ((MinPressure[i + 5] - MaxPressure[i + 5]) > 0)
                            {
                                //Calcul de pression sur la main gauche
                                InstantPressure[5] = Math.Abs((InstantPosition[5] - MaxPressure[5]) / (20 - MaxPressure[5]) - 1);
                                InstantPressure[6] = Math.Abs((InstantPosition[6] - MaxPressure[6]) / (MinPressure[6] * 0.95f - MaxPressure[6]) - 1);
                                InstantPressure[7] = Math.Abs((InstantPosition[7] - MaxPressure[7]) / (MinPressure[7] - MaxPressure[7]) - 1);
                                InstantPressure[8] = Math.Abs((InstantPosition[8] - MaxPressure[8]) / (MinPressure[8] - MaxPressure[8]) - 1);
                                InstantPressure[9] = Math.Abs((InstantPosition[9] - MaxPressure[9]) / (MinPressure[9] * 0.95f - MaxPressure[9]) - 1);

                                //Mise à jour IHM par appel delegue au thread IHM
                                if (InstantPressure[i + 5] > 1)
                                {
                                    FakeLed[i].Invoke((MethodInvoker)(() => FakeLed[i].BackColor = Color.FromArgb(255, 255, 255)));
                                }
                                else
                                {
                                    FakeLed[i].Invoke((MethodInvoker)(() => FakeLed[i].BackColor = Color.FromArgb((int)(InstantPressure[i + 5] * 255D), (int)(InstantPressure[i + 5] * 255D), (int)(InstantPressure[i + 5] * 255D))));
                                }
                                //Processur special pour le pouce
                                if (InstantPosition[5] == 0)
                                {
                                    FakeLed[0].Invoke((MethodInvoker)(() => FakeLed[0].BackColor = Color.FromArgb(0, 0, 0)));
                                }
                            }
                        }

                    }
                }
            });

                //Thread calc commande Led main droite
                //Aucune différence dans le process seul les index change
                Task.Factory.StartNew(() =>
                {
                    Thread.Sleep(1000);
                    while (true)
                    {
                        if (handRight != null)
                        {
                            handTempo = handRight;

                            for (int i = 0; i < fingersRight.Count; i++)
                            {
                                Thread.Sleep(10);
                                if ((MinPressure[i] - MaxPressure[i]) > 0)
                                {
                                    InstantPressure[0] = Math.Abs((InstantPosition[0] - MaxPressure[0]) / (20 - MaxPressure[0]) - 1);
                                    InstantPressure[1] = Math.Abs((InstantPosition[1] - MaxPressure[1]) / (MinPressure[1] * 0.95f - MaxPressure[1]) - 1);
                                    InstantPressure[2] = Math.Abs((InstantPosition[2] - MaxPressure[2]) / (MinPressure[2] - MaxPressure[2]) - 1);
                                    InstantPressure[3] = Math.Abs((InstantPosition[3] - MaxPressure[3]) / (MinPressure[3] - MaxPressure[3]) - 1);
                                    InstantPressure[4] = Math.Abs((InstantPosition[4] - MaxPressure[4]) / (MinPressure[4] * 0.95f - MaxPressure[4]) - 1);

                                    if (InstantPressure[i] > 1)
                                    {
                                        FakeLed[i + 5].Invoke((MethodInvoker)(() => FakeLed[i + 5].BackColor = Color.FromArgb(255, 255, 255)));
                                    }

                                    else
                                    {
                                        FakeLed[i + 5].Invoke((MethodInvoker)(() => FakeLed[i + 5].BackColor = Color.FromArgb((int)(InstantPressure[i] * 255D), (int)(InstantPressure[i] * 255D), (int)(InstantPressure[i] * 255D))));
                                    }
                                    //Calcul spécial pouce
                                    if (InstantPosition[0] == 0)
                                    {
                                        FakeLed[5].Invoke((MethodInvoker)(() => FakeLed[5].BackColor = Color.FromArgb(0, 0, 0)));
                                    }
                                }
                            }
                        }
                    }
                });

                //Uniquement en mode debug
                if (ModeDebug)
                {
                    //Thread Affichage Seuil atteint IHM droite
                    Task.Factory.StartNew(() =>
                    {
                        Thread.Sleep(1000);
                        while (true)
                        {
                            if (handRight != null)
                            {
                            //Calcul spécial pouce
                            if (InstantPosition[0] > MaxPressure[0])
                                {
                                //On modifie la couleur de la LED par appel delegue au thread IHM
                                Leds[0].Invoke((MethodInvoker)(() => Leds[0].BackColor = Color.White));
                                }
                                else
                                {
                                //On redonne la valeur nominal c'est à dire celle du fond de l'IHM
                                Leds[0].Invoke((MethodInvoker)(() => Leds[0].BackColor = Color.FromArgb(28, 28, 28)));
                                }

                                for (int i = 1; i < fingersRight.Count; i++)
                                {
                                // Quand la position instantannée dépasse le seuil maximal appui
                                if (InstantPosition[i] < MaxPressure[i])
                                    {
                                        Leds[i].Invoke((MethodInvoker)(() => Leds[i].BackColor = Color.White));
                                    }
                                    else
                                    {
                                        Leds[i].Invoke((MethodInvoker)(() => Leds[i].BackColor = Color.FromArgb(28, 28, 28)));
                                    }

                                }
                            }
                        }

                    });

                    //Thread Affichage Seuil atteint IHM gauche
                    //Même process 
                    Task.Factory.StartNew(() =>
                    {
                        Thread.Sleep(1000);
                        while (true)
                        {
                            if (handLeft != null)
                            {
                            //Calcul spécial pouce
                            if (InstantPosition[5] > MaxPressure[5])
                                {
                                    Leds[5].Invoke((MethodInvoker)(() => Leds[5].BackColor = Color.White));
                                }
                                else
                                {
                                    Leds[5].Invoke((MethodInvoker)(() => Leds[5].BackColor = Color.FromArgb(28, 28, 28)));
                                }


                                for (int i = 1; i < fingersLeft.Count; i++)
                                {
                                // Quand la position instantannée dépasse le seuil maximal appui
                                if (InstantPosition[i + 5] < MaxPressure[i + 5])
                                    {
                                        Leds[i + 5].Invoke((MethodInvoker)(() => Leds[i + 5].BackColor = Color.White));
                                    }
                                    else
                                    {
                                        Leds[i + 5].Invoke((MethodInvoker)(() => Leds[i + 5].BackColor = Color.FromArgb(28, 28, 28)));
                                    }
                                }

                            }
                        }

                    });
                }
            }
            
            //Uniquement si on a choisi de les jouer
            if (Sound)
            {
                //Thread SoundPlayer main droigt
                Task.Factory.StartNew(() =>
                {
                    Thread.Sleep(1000);
                    while (true)
                    {
                        if (handRight != null)
                        {
                            Thread.Sleep(5);
                            //Calcul spécial pouce
                            if (InstantPosition[0] > MaxPressure[0])
                            {
                                Note[0].PlaySync();
                            }

                            for (int i = 1; i < fingersRight.Count; i++)
                            {
                                // Quand la position instantannée dépasse le seuil maximal appui
                                if (InstantPosition[i] < MaxPressure[i])
                                {
                                    Note[i].PlaySync();
                                }
                            }
                        }
                    }
                });

                //Thread SoundPlayer main gauche
                //Même Process
                Task.Factory.StartNew(() =>
                {
                    Thread.Sleep(1000);
                    while (true)
                    {
                        if (handLeft != null)
                        {
                            Thread.Sleep(5);
                            for (int i = 1; i < fingersLeft.Count; i++)
                            {
                                if (InstantPosition[5] > MaxPressure[5])
                                {
                                    Note[5].PlaySync();
                                }
                                if (InstantPosition[i + 5] < MaxPressure[i + 5])
                                {
                                    Note[i + 5].PlaySync();
                                }
                            }
                        }
                    }
                });
            }
            /*           
            //Thread SEND USB command
            //Thread non testé avec la maquette orgue lumineux 
            Task.Factory.StartNew(() =>
            {
                Thread.Sleep(1000);
                while (true)
                {
                    for(int i=0;i<10;i++)
                    {

                        if (InstantPressure[i] > 1)
                        {
                            try
                            {
                                port.WriteLine(
                                    String.Format("{0}:{1}", i, 255));
                                //Tempo entre chaque trame
                                Thread.Sleep(20);
                            }
                            catch (UnauthorizedAccessException exe)
                            {
                                Console.WriteLine("Error: Port {0} is in use Com1" + exe);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Uart exception: " + ex);
                            }

                        }
                        else
                        {
                            try
                            {
                            port.WriteLine(
                                String.Format("{0}:{1}", i, InstantPressure[i]));
                             //Tempo entre chaque trame
                             Thread.Sleep(20);
                            }
                            catch (UnauthorizedAccessException exe)
                            {
                                Console.WriteLine("Error: Port {0} is in use Com1" + exe);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Uart exception: " + ex);
                            }
                        }
                    }
                }
            });
            */
        }
        //Geter pour le buffer droigt
        int GetLenghtLisséRight(int i)
        {
            if (BufferLenghtRight[i].Count > 0)
            {
                return BufferLenghtRight[i].ConvertAll(Convert.ToInt32).Sum() / BufferLenghtRight[i].Count;
            }
            else
                return BufferLenghtRight[i].ConvertAll(Convert.ToInt32).Sum() / 1;
        }

        //Geter pour le buffer gauche
        int GetLenghtLisséLeft(int i)
        {
            if (BufferLenghtLeft[i].Count > 0)
            {
                return BufferLenghtLeft[i].ConvertAll(Convert.ToInt32).Sum() / BufferLenghtLeft[i].Count;
            }
            else
                return BufferLenghtLeft[i].ConvertAll(Convert.ToInt32).Sum() / 1;
        }

        //Thread Lissage
        void Lissage(Object source, System.Timers.ElapsedEventArgs e)
        {
            label16.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));

            //Lissage Main droite
            if (handRight != null)
            {
                handTempo = handRight;

                for (int z = 0; z < fingersRight.Count; z++)
                {
                    //Si le buffer droit est plein on enlève le premier élement
                    if (BufferLenghtRight[z].Count > 20)
                    {
                        BufferLenghtRight[z].RemoveAt(0);
                    }
                    //Calcul longueur spécial pour le pouce
                    if (z == 0)
                    {
                        boneProximal = fingersRight[0].Bone(Bone.BoneType.TYPE_PROXIMAL);
                        boneIntermediate = fingersRight[0].Bone(Bone.BoneType.TYPE_INTERMEDIATE);
                        boneDistal = fingersRight[0].Bone(Bone.BoneType.TYPE_DISTAL);
                        BufferLenghtRight[z].Add(boneProximal.Center.DistanceTo(boneIntermediate.Center) + boneIntermediate.Center.DistanceTo(boneDistal.Center));
                        MaxPressure[z] = (int)((GetLenghtLisséRight(z) * ((100f - SliderValue) / 100f)) * 0.9f);
                    }
                    
                    else
                    {
                        //ajout de la longueur dans le buffer
                        BufferLenghtRight[z].Add(fingersRight[z].Length);
                        //Calcul de la pression maximal atteingnable à partir des valeurs du buffer
                        MaxPressure[z] = (int)(((100f + SliderValue) / 100f) * (Math.Sqrt(Math.Pow(GetLenghtLisséRight(z), 2) + Math.Pow(handTempo.PalmPosition.DistanceTo(fingersRight[z].Bone(Bone.BoneType.TYPE_METACARPAL).Center), 2))));
                    }
                    //Rafraichissement IHM avec les valeurs percues par le système
                    LenghtLissé[z] = BufferLenghtRight[z].ConvertAll(Convert.ToInt32).Sum() / BufferLenghtRight[z].Count;
                }
            }

            else
                //Process Clean IHM si pas de main droite
                for (int z = 0; z < 5; z++)
                {
                    BufferLenghtRight[z].Clear();
                    Leds[z].BackColor = Color.Red;
                    InstantPressureLabel[z].Invoke((MethodInvoker)(() => InstantPressureLabel[z].Text = "×"));
                    LenghtLabel[z].Invoke((MethodInvoker)(() => LenghtLabel[z].Text = "×"));
                    FakeLed[z + 5].Invoke((MethodInvoker)(() => FakeLed[z + 5].BackColor = Color.Red));
                }
            //Lissage Main gauche
            if (handLeft != null)
            {
                handTempo = handLeft;

                for (int z = 0; z < fingersLeft.Count; z++)
                {

                    if (BufferLenghtLeft[z].Count > 20)
                    {
                        BufferLenghtLeft[z].RemoveAt(0);
                    }
                    //Calcul spécial pour le pouce
                    if (z == 0)
                    {
                        boneProximal = fingersLeft[0].Bone(Bone.BoneType.TYPE_PROXIMAL);
                        boneIntermediate = fingersLeft[0].Bone(Bone.BoneType.TYPE_INTERMEDIATE);
                        boneDistal = fingersLeft[0].Bone(Bone.BoneType.TYPE_DISTAL);
                        BufferLenghtLeft[z].Add(boneProximal.Center.DistanceTo(boneIntermediate.Center) + boneIntermediate.Center.DistanceTo(boneDistal.Center));
                        MaxPressure[z + 5] = (int)((GetLenghtLisséLeft(z) * ((100f - SliderValue) / 100f)) * 0.9f);
                    }
                    else
                    {
                        BufferLenghtLeft[z].Add(fingersLeft[z].Length);
                        MaxPressure[z + 5] = (int)(((100f + SliderValue) / 100f) * Math.Sqrt(Math.Pow(GetLenghtLisséLeft(z), 2) + Math.Pow(handTempo.PalmPosition.DistanceTo(fingersLeft[z].Bone(Bone.BoneType.TYPE_METACARPAL).Center), 2)));
                    }
                    LenghtLissé[z + 5] = BufferLenghtLeft[z].ConvertAll(Convert.ToInt32).Sum() / BufferLenghtLeft[z].Count;

                }
            }

            //Process Clean IHM si pas de main gauche
            else
                for (int z = 0; z < 5; z++)
                {
                    BufferLenghtLeft[z].Clear();
                    Leds[z + 5].BackColor = Color.Red;
                    InstantPressureLabel[z + 5].Invoke((MethodInvoker)(() => InstantPressureLabel[z + 5].Text = "×"));
                    LenghtLabel[z + 5].Invoke((MethodInvoker)(() => LenghtLabel[z + 5].Text = "×"));
                    FakeLed[z].Invoke((MethodInvoker)(() => FakeLed[z].BackColor = Color.Red));
                }
        }

        //Ancien POC Rayon de courbure 
        void RayonCourbureFind(Bone boneMetaCarpal, Bone boneDistal, Bone boneProximal, Bone boneIntermediate)
        {
            //Linear Approximation

            double dxdy, dxxdyy;
            double rayonCourbure;
            double m1, m2, m3;

            //Metacarpal - Proximal 
            m1 = (boneProximal.Center.y - boneMetaCarpal.Center.y) / (boneProximal.Center.z - boneMetaCarpal.Center.z);
            //Proximal-intermediate
            m2 = (boneIntermediate.Center.y - boneProximal.Center.y) / (boneIntermediate.Center.z - boneProximal.Center.z);
            //intermediate-distal
            m3 = (boneDistal.Center.y - boneIntermediate.Center.y) / (boneDistal.Center.z - boneIntermediate.Center.z);

            //Proximal-Intermediate-Distal
            dxdy = (m2 + m3) / 2;
            dxxdyy = (m3 - m2) / (((boneDistal.Center.z + boneIntermediate.Center.z) / 2 - (boneIntermediate.Center.z + boneProximal.Center.z) / 2));

            ////Metacarpal-Proximal-Interdiate
            //dxdy = (m1 + m2) / 2;
            //dxxdyy = (m2 - m1) / (((boneIntermediate.Center.z + boneProximal.Center.z) / 2 - (boneProximal.Center.z + boneMetaCarpal.Center.z) / 2));

            /* calcul de la courbure */
            rayonCourbure = (int)(Math.Pow((1 + Math.Pow(dxdy, 2)), 3 / 2) / dxxdyy);
            //label18.Text = rayonCourbure.ToString();
            //return;
        }
    }
}
