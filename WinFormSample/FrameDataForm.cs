﻿using Leap;
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

namespace WinFormSample
{

    public partial class FrameDataForm : Form 
    {
        //Déclaration de mon dictionnaire qui sert de Buffer de longueur pour les doigts
        //Premier champ le numéro du doigt
        //Deuxième champ la longueur du doigt
        public class MultiDimDictList : Dictionary<int, List<float>> { }

        //Dictionnaire de la main droite / gauche
        MultiDimDictList BufferLenghtRight = new MultiDimDictList();
        MultiDimDictList BufferLenghtLeft = new MultiDimDictList();

        private byte[] imagedata = new byte[1];
        //Instanciation de l'objet controller (Leap Motion)
        private Controller controller = new Controller();
        //Instanciation du timer /1s 
        private static System.Timers.Timer aTimer;
        private Random rnd = new Random();
        //Liste des mains vue dans la Frame 
        List<Hand> Hands= new List<Hand>() ;

        // Liste des doigts de la main droite / gauche 
        List<Finger> fingersRight = new List<Finger>();
        List<Finger> fingersLeft = new List<Finger>();

        Vector boneMetacarpal1, boneMetacarpal2, boneMetacarpal3, boneMetacarpal4, boneMetacarpal5;
        //Tableau des labels de longeurs des doigts lissés
        Label[] Lenght;
        //Tableau des Leds de position des doigts (16 positions)
        Label[] Position;
        //Tableau des Labels de seuil minimales d'appui 
        Label[] Treshold;
        //Tableau des Lables de distances entre le bout des doigts et le centre de la paume
        Label[] DistanceToPalm;
        //Tableau des Lables de distances entre le bout des doigts et le centre de la paume
        Label[] FakeLed;

        //Tableau des longueurs des doigts lissé 
        int[] LenghtLissé = new int[10];
        //Tableau des seuils minimales d'appui pour chaque doigt
        double[] ThresholdInt = new double[10];
        //Tableau des distances entre le bout des doigts et le centre de la paume
        int[] distanceToFinger = new int[10];

        //Intanciation de l'objet frame (Une image traité par le sdk)
        Frame frame = new Frame();
        int SliderValue = 0;
        //Intanciation de l'objet device 
        Device device;

        //Leds d'appui des doigts par rapport au seuil 
        Label[] Leds;
        //Tableau contenant les objets player des notes du piano 
        SoundPlayer[] Note;
        //Objet Hand qui permet de stocker la main droigt / gauche pendant les traitements 
        Hand handRight = new Hand();
        Hand handLeft = new Hand();
        //Même fonction 
        Hand handTempo = new Hand();

        //Tableau stockant les l'ensemble des doigts de type Vector
        Vector[] VectorFingerRight;
        Vector[] VectorFingerLeft;
        Vector[] PianoDoigtRight;
        Vector[] PianoDoigtLeft;
        //Instanciation des Vector de l'ensemble des doigts 
        Vector Finger1,Finger2, Finger3, Finger4, Finger5, Finger6, Finger7, Finger8, Finger9, Finger10;
        Bone boneMetaCarpal, boneProximal, boneIntermediate, boneDistal;
        InteractionBox Test;
        int CptLissage=1;
        int[] MinPressure;
        //Indique si l'appli est instancié en mode debug ou non
        bool ModeDebug;
        bool Sound;
        ServiceController LeapMotionService = new ServiceController("Leap Service");
        //Déclaration des vecteurs pour le positionnement (16 positions)
        Vector PianoDoigt1,PianoDoigt2, PianoDoigt3, PianoDoigt4, PianoDoigt5,
            PianoDoigt6, PianoDoigt7, PianoDoigt8, PianoDoigt9, PianoDoigt10;

        public FrameDataForm()
        {
            InitializeComponent();
            if (LeapMotionService.Status.Equals(ServiceControllerStatus.Stopped))
            {
                LeapMotionService.Start();
            }

            if (LeapMotionService.Status.Equals(ServiceControllerStatus.Running))
            {
                LeapMotionService.Stop();
                LeapMotionService.Start();
            }
            
            Vector size = new Vector(200f,1f,1f);
            //Vector center = new Vector();
            Test = new InteractionBox(Test.Center,size);
            Lenght = new Label[] { lenght1, lenght2, lenght3, lenght4, lenght5, lenght6, lenght7, lenght8, lenght9, lenght10 };
            Position = new Label[] { Position1, Position2, Position3, Position4, Position5, Position6, Position7, Position8,
                Position9, Position10, Position11, Position12, Position13, Position14, Position16, Position16 };
            DistanceToPalm = new Label[] { Doigt1, Doigt2, Doigt3, Doigt4, Doigt5, Doigt6, Doigt7, Doigt8, Doigt9, Doigt10 };
            Leds = new Label[] { Led1, Led2, Led3, Led4, Led5, Led6, Led7, Led8, Led9, Led10 };
            VectorFingerRight = new Vector[] { Finger1, Finger2, Finger3, Finger4, Finger5};
            VectorFingerLeft = new Vector[] { Finger6, Finger7, Finger8, Finger9, Finger10};
            Treshold = new Label[] { Min1, Min2, Min3, Min4, Min5,Min6,Min7,Min8,Min9,Min10 };
            FakeLed = new Label[] { FakeLed1, FakeLed2, FakeLed3, FakeLed4, FakeLed5, FakeLed6, FakeLed7, FakeLed8, FakeLed9, FakeLed10 };
            PianoDoigtRight = new Vector[] {PianoDoigt1,PianoDoigt2, PianoDoigt3, PianoDoigt4, PianoDoigt5};
            PianoDoigtLeft = new Vector[] { PianoDoigt6, PianoDoigt7, PianoDoigt8, PianoDoigt9, PianoDoigt10 };
            MinPressure= new int[10];
            //Creation buffer droit
            for (int i = 0; i < 5; i++)
            {
                BufferLenghtRight.Add(i, new List<float>());
            }

            //Creation buffer gauche
            for (int i = 0; i < 5; i++)
            {
                BufferLenghtLeft.Add(i, new List<float>());
            }
            controller.Config.SetFloat("InteractionBox.Width", 1300.0f);
            controller.Config.SetFloat("InteractionBox.Height", 600.0f);
            //Configuration du Timer
            aTimer = new System.Timers.Timer();
            aTimer.Interval=1000;
            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += Lissage;
            // Have the timer fire repeated events (true is the default)
            aTimer.AutoReset = true;
            // Start the timer
            aTimer.Enabled = true;

            controller.EventContext = WindowsFormsSynchronizationContext.Current;
            controller.FrameReady += newFrameHandler;
            controller.ImageReady += onImageReady;
            controller.ImageRequestFailed += onImageRequestFailed;
            controller.InternalFrameReady += isConnected;
            controller.DeviceLost+= isDisconnected;
            controller.DeviceFailure += OnDeviceFailure;
            Slider.ValueChanged += SliderChanged;

            string[] args = Environment.GetCommandLineArgs();

            if (args.Length == 1)
            {
                Console.WriteLine("Too few arguments");
                System.Environment.Exit(1);
            }
            if (args.Length>4)
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
            if(args.Length==3)
            {
                if (Int32.TryParse(args[2] , out int args2Int))
                {
                    if(args2Int>=0 && args2Int<=30)
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
            if(args.Length==4)
            {
                if (args[3].Equals("Sound"))
                {
                    Sound=true;
                }

                else if (args[3].Equals("Mute"))
                {
                    Sound=false;
                }
                else
                {
                    Console.WriteLine("Argument 3 incorrect");
                    System.Environment.Exit(1);
                }
            }
            Slider.Value = Int32.Parse(ConfigurationManager.AppSettings["LastSliderValue"]);

            SoundPlayer Note1 = new SoundPlayer();
            Note1.SoundLocation = ".\\Sons\\Note1.wav";
            Note1.LoadAsync();

            SoundPlayer Note2 = new SoundPlayer();
            Note2.SoundLocation = ".\\Sons\\Note2.wav";
            Note2.LoadAsync();

            SoundPlayer Note3 = new SoundPlayer();
            Note3.SoundLocation = ".\\Sons\\Note3.wav";
            Note3.LoadAsync();

            SoundPlayer Note4 = new SoundPlayer();
            Note4.SoundLocation = ".\\Sons\\Note4.wav";
            Note4.LoadAsync();

            SoundPlayer Note5 = new SoundPlayer();
            Note5.SoundLocation = ".\\Sons\\Note5.wav";
            Note5.LoadAsync();

            SoundPlayer Note6 = new SoundPlayer();
            Note6.SoundLocation = ".\\Sons\\Note6.wav";
            Note1.LoadAsync();

            SoundPlayer Note7 = new SoundPlayer();
            Note7.SoundLocation = ".\\Sons\\Note7.wav";
            Note7.LoadAsync();

            SoundPlayer Note8 = new SoundPlayer();
            Note8.SoundLocation = ".\\Sons\\Note8.wav";
            Note8.LoadAsync();

            SoundPlayer Note9 = new SoundPlayer();
            Note9.SoundLocation = ".\\Sons\\Note9.wav";
            Note9.LoadAsync();

            SoundPlayer Note10 = new SoundPlayer();

            Note = new SoundPlayer[] { Note5, Note4, Note3, Note2, Note1, Note6, Note7, Note8, Note9, Note10 };
            Note10.SoundLocation = ".\\Sons\\Note10.wav";
            Note[9].LoadCompleted += new AsyncCompletedEventHandler(SoundPlayed);
            Note10.LoadAsync();
        }
        void isConnected( object sender, InternalFrameEventArgs eventArgs)
        {
            if (controller.IsConnected)
            {
                ConnectionUSB.BackColor = Color.Green;
            }
            

        }
        void isDisconnected(object sender, DeviceEventArgs eventArgs)
        {
            ConnectionUSB.BackColor = Color.Red;
        }
        void SliderChanged(object sender, EventArgs e)
        {
            SliderValue = Slider.Value;
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["LastSliderValue"].Value = Slider.Value.ToString();
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");

        }
        void newFrameHandler(object sender, FrameEventArgs eventArgs)
        {
            frame = eventArgs.frame;
            handRight = null;
            handLeft = null;

            if(ModeDebug==false)
            {
                this.Hide();
            }

            // Conditionnement de 0 à 1
            int tempo=0;

            if(distanceToFinger[4]>tempo && distanceToFinger[4]<100)
            {
                CptLissage = CptLissage + 1;
                if(CptLissage>10)
                {
                    CptLissage=0;
                    tempo = distanceToFinger[4];
                }

            }
            //label7.Text = Math.Round(Math.Abs(((distanceToFinger[4] - ThresholdInt[4]) / ( 93 - ThresholdInt[4]) - 1)),3).ToString();
          
            //The following are Label controls added in design view for the form
            displayFPS.Text = frame.CurrentFramesPerSecond.ToString();
            displayHandCount.Text = frame.Hands.Count.ToString();
            controller.RequestImages(frame.Id, Leap.Image.ImageType.DEFAULT, imagedata);
            device = controller.Devices[0];
            if (frame.Hands.Count>0)
                {

                Hands = frame.Hands;
                foreach(Hand e in Hands)
                    {
                    if(e.IsLeft)
                    {
                        handLeft = e;
                        fingersLeft= e.Fingers;

                    }
                    if (e.IsRight)
                    {
                        handRight = e;
                        fingersRight = e.Fingers;

                    }

                }

                if (handRight != null)
                {
                    //Confidence.Text = hand.Confidence.ToString();

                   for(int i=0;i<5;i++)
                    {
                        VectorFingerRight[i] = fingersRight[i].StabilizedTipPosition;
                        distanceToFinger[i] = (int)VectorFingerRight[i].DistanceTo(handRight.PalmPosition);
                        PianoDoigtRight[i]= Test.NormalizePoint(VectorFingerRight[i], true);
                    }
         
                    boneMetacarpal1 = fingersRight[0].Bone(Bone.BoneType.TYPE_PROXIMAL).NextJoint;
                    label60.Text = (boneMetacarpal1.DistanceTo(handRight.PalmPosition) + GetLenghtLisséRight(0)).ToString();
                    boneMetacarpal2 = fingersRight[1].Bone(Bone.BoneType.TYPE_METACARPAL).NextJoint;
                    label61.Text = (boneMetacarpal2.DistanceTo(handRight.PalmPosition) + GetLenghtLisséRight(1)).ToString();
                    MinPressure[1] = (int)boneMetacarpal2.DistanceTo(handRight.PalmPosition) + GetLenghtLisséRight(1);
                    boneMetacarpal3 = fingersRight[2].Bone(Bone.BoneType.TYPE_METACARPAL).NextJoint;
                    label62.Text = (boneMetacarpal3.DistanceTo(handRight.PalmPosition) + GetLenghtLisséRight(2)).ToString();
                    boneMetacarpal4 = fingersRight[3].Bone(Bone.BoneType.TYPE_METACARPAL).NextJoint;
                    label63.Text = (boneMetacarpal4.DistanceTo(handRight.PalmPosition) + GetLenghtLisséRight(3)).ToString();

                    boneMetacarpal5 = fingersRight[4].Bone(Bone.BoneType.TYPE_METACARPAL).NextJoint;
                    label64.Text = (boneMetacarpal5.DistanceTo(handRight.PalmPosition) + GetLenghtLisséRight(4)).ToString();
                   
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

                    for (int i = 0; i < fingersRight.Count; i++)
                    {
                        DistanceToPalm[i].Text = distanceToFinger[i].ToString();
                        Lenght[i].Text = LenghtLissé[i].ToString();
                        Treshold[i].Text = ((int)ThresholdInt[i]).ToString();
                    }
                }
                else
                {
                    for(int i=0;i<5;i++)
                    {
                        Leds[i].BackColor = Color.Red;
                    }
                    
                }
                if(handLeft!=null)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        VectorFingerLeft[i] = fingersLeft[i].StabilizedTipPosition;
                        distanceToFinger[i+5] = (int)VectorFingerLeft[i].DistanceTo(handLeft.PalmPosition);
                        PianoDoigtLeft[i] = Test.NormalizePoint(VectorFingerLeft[i], true);
                    }

                    for (int i = 5; i < fingersLeft.Count+5; i++)
                    {

                        DistanceToPalm[i].Text = distanceToFinger[i].ToString();
                        Lenght[i].Text = LenghtLissé[i].ToString();
                        Treshold[i].Text = ((int)ThresholdInt[i]).ToString();

                    }

                }
                
            }
        }
       
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
        void SoundPlayed(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                Thread.Sleep(1000);
                while (true)
                {
                    if (handRight != null)
                    {

                        for (int i = 0; i < fingersRight.Count; i++)
                        {
                            if (distanceToFinger[i] < ThresholdInt[i])
                            {
                                Leds[i].Invoke((MethodInvoker)(() => Leds[i].BackColor = Color.White));
                            }
                            else
                            {
                                Leds[i].Invoke((MethodInvoker)(() => Leds[i].BackColor = Color.FromArgb(28, 28, 28)));
                            }
                        }
                        if((MinPressure[1] - ThresholdInt[1]) > 0)
                        {
                            double calc = Math.Abs((distanceToFinger[1] - ThresholdInt[1]) / (MinPressure[1] - ThresholdInt[1])-1);
                            Calc.Invoke((MethodInvoker)(() => Calc.Text = calc.ToString()));
                            if(calc > 1)
                            {
                                FakeLed7.BackColor = Color.FromArgb(0, 0, 255);
                            }
                            else
                            {
                                FakeLed7.BackColor = Color.FromArgb(0, 0, ((int)(calc*255D)));
                            }
                        }




                    }
                }

            });

            Task.Factory.StartNew(() =>
            {
                Thread.Sleep(1000);
                while (true)
                {
                    if (handLeft != null)
                    {

                        for (int i = 0; i < fingersLeft.Count; i++)
                        {
                            if (distanceToFinger[i + 5] < ThresholdInt[i + 5])
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

            if (Sound==true)
            {
                Console.WriteLine("pass");
                Task.Factory.StartNew(() =>
                {
                //Tempo attente initil
                Thread.Sleep(1000);
                    while (true)
                    {
                        if (handRight != null)
                        {

                            for (int i = 0; i < fingersRight.Count; i++)
                            {
                                if (distanceToFinger[i] < ThresholdInt[i])
                                {
                                    Note[i].PlaySync();
                                }

                            }

                        }
                    }
                });

                Task.Factory.StartNew(() =>
                {
                //Tempo attente initil
                Thread.Sleep(1000);
                    while (true)
                    {
                        if (handLeft != null)
                        {
                            for (int i = 0; i < fingersLeft.Count; i++)
                            {
                                if (distanceToFinger[i + 5] < ThresholdInt[i + 5])
                                {
                                    Note[i + 5].PlaySync();
                                }

                            }

                        }
                    }

                });
            }
        }
        int GetLenghtLisséRight(int i)
        {
            if(BufferLenghtRight[i].Count>0)
            {
                return BufferLenghtRight[i].ConvertAll(Convert.ToInt32).Sum() / BufferLenghtRight[i].Count;
            }
            else
                return BufferLenghtRight[i].ConvertAll(Convert.ToInt32).Sum() / 1;
        }

        int GetLenghtLisséLeft(int i)
        {
            if (BufferLenghtLeft[i].Count > 0)
            {
                return BufferLenghtLeft[i].ConvertAll(Convert.ToInt32).Sum() / BufferLenghtLeft[i].Count;
            }
            else
                return BufferLenghtLeft[i].ConvertAll(Convert.ToInt32).Sum() / 1;
        }
        void Lissage(Object source, System.Timers.ElapsedEventArgs e)
        {  
            label16.BackColor= Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));

            if (handRight!=null)
            {
                handTempo = handRight;

                for (int z = 0; z < fingersRight.Count ; z++)
                {
        
                    if (BufferLenghtRight[z].Count > 20)
                    {
                        BufferLenghtRight[z].RemoveAt(0);
                    }
                    //Calcul spécial pour le pouce
                    if (z == 0)
                    {
                        boneProximal = fingersRight[0].Bone(Bone.BoneType.TYPE_PROXIMAL);
                        boneIntermediate = fingersRight[0].Bone(Bone.BoneType.TYPE_INTERMEDIATE);
                        boneDistal = fingersRight[0].Bone(Bone.BoneType.TYPE_DISTAL);
                        BufferLenghtRight[z].Add( boneProximal.Center.DistanceTo(boneIntermediate.Center) + boneIntermediate.Center.DistanceTo(boneDistal.Center));
                        ThresholdInt[z] = (int)(GetLenghtLisséRight(z)*((100f+ SliderValue) /100f));
                    }
                    else
                    {
                        BufferLenghtRight[z].Add(fingersRight[z].Length);
                        ThresholdInt[z] = (int)(((100f + SliderValue) /100f)* (Math.Sqrt(Math.Pow(GetLenghtLisséRight(z), 2) + Math.Pow(handTempo.PalmPosition.DistanceTo(fingersRight[z].Bone(Bone.BoneType.TYPE_METACARPAL).Center), 2))));
                    }
                    LenghtLissé[z] = BufferLenghtRight[z].ConvertAll(Convert.ToInt32).Sum() / BufferLenghtRight[z].Count;
                    
                }
            }
            else
                for(int z=0;z<5;z++)
                {
                    BufferLenghtRight[z].Clear();
                    Leds[z].BackColor = Color.Red;
                    DistanceToPalm[z].Invoke((MethodInvoker)(() => DistanceToPalm[z].Text = "×"));
                    Treshold[z].Invoke((MethodInvoker)(() => Treshold[z].Text = "×"));
                    Lenght[z].Invoke((MethodInvoker)(() => Lenght[z].Text = "×"));
                }
            if (handLeft != null)
            {

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
                        ThresholdInt[z + 5] =(int)( GetLenghtLisséLeft(z) * ((100f + SliderValue) / 100f));
                    }
                    else
                    {
                        BufferLenghtLeft[z].Add(fingersLeft[z].Length);
                        ThresholdInt[z+5] = (int)(((100f + SliderValue) / 100f)*Math.Sqrt(Math.Pow(GetLenghtLisséLeft(z), 2) + Math.Pow(handLeft.PalmPosition.DistanceTo(fingersLeft[z].Bone(Bone.BoneType.TYPE_METACARPAL).Center), 2)));
                    }
                    LenghtLissé[z+5] = BufferLenghtLeft[z].ConvertAll(Convert.ToInt32).Sum() / BufferLenghtLeft[z].Count;

                }
            }
            else
                for (int z = 0; z < 5; z++)
                {
                    BufferLenghtLeft[z].Clear();
                    Leds[z+5].BackColor = Color.Red;
                    DistanceToPalm[z+5].Invoke((MethodInvoker)(() => DistanceToPalm[z + 5].Text = "×"));
                    Treshold[z+5].Invoke((MethodInvoker)(() => Treshold[z + 5].Text = "×"));
                    Lenght[z+5].Invoke((MethodInvoker)(() => Lenght[z + 5].Text = "×"));
                }
        }

        void RayonCourbureFind(Bone boneMetaCarpal, Bone boneDistal, Bone boneProximal, Bone boneIntermediate)
        {
            //Linear Approximation

            double dxdy, dxxdyy;
            double rayonCourbure;
            double m1, m2, m3;

            //Metacarpal - Proximal 
            m1 = (boneProximal.Center.y - boneMetaCarpal.Center.y) / (boneProximal.Center.z - boneMetaCarpal.Center.z );
            //Proximal-intermediate
            m2 = (boneIntermediate.Center.y - boneProximal.Center.y) / (boneIntermediate.Center.z - boneProximal.Center.z);
            //intermediate-distal
            m3 = (boneDistal.Center.y - boneIntermediate.Center.y) / (boneDistal.Center.z - boneIntermediate.Center.z);

            //Proximal-Intermediate-Distal
            dxdy = ( m2 + m3) / 2;
            dxxdyy = (m3 - m2) / (((boneDistal.Center.z + boneIntermediate.Center.z) / 2 - (boneIntermediate.Center.z + boneProximal.Center.z) / 2));

            ////Metacarpal-Proximal-Interdiate
            //dxdy = (m1 + m2) / 2;
            //dxxdyy = (m2 - m1) / (((boneIntermediate.Center.z + boneProximal.Center.z) / 2 - (boneProximal.Center.z + boneMetaCarpal.Center.z) / 2));

            /* calcul de la courbure */
            rayonCourbure = (int) (Math.Pow((1+Math.Pow(dxdy,2)),3/2)/dxxdyy);
            //label18.Text = rayonCourbure.ToString();
            //return;
        }
    }
}
