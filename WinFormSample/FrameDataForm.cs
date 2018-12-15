using Leap;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Media;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Threading;

namespace WinFormSample
{
   
    public partial class FrameDataForm : Form 
    {
        public class MultiDimDictList : Dictionary<int, List<float>> { }
        MultiDimDictList myDicList = new MultiDimDictList();
        private byte[] imagedata = new byte[1];
        private Controller controller = new Controller();
        Bitmap bitmap = new Bitmap(640, 480, PixelFormat.Format8bppIndexed);
        private static System.Timers.Timer aTimer;
        private Random rnd = new Random();
        List<Hand> Hands= new List<Hand>() ;
        List<Finger> fingers = new List<Finger>();
   
        Label[] Lenght;
        Label[] Position;
        Label[] CalcPressure;
        Label[] MinPressure;
        int[] LenghtLissé = new int[10];
        double[] MinPressureInt = new double[10];
        Frame frame = new Frame();
        int[] distanceToFinger = new int[10];
        Device device;
        Label[] Labels;
        Label[] Leds;
        SoundPlayer[] Note;
        Hand hand= new Hand();
        Vector[] VectorFinger;
        Vector Finger1,Finger2, Finger3, Finger4, Finger5, Finger6, Finger7, Finger8, Finger9, Finger10;
        Bone boneMetaCarpal, boneProximal, boneIntermediate, boneDistal;
        InteractionBox Test;
        //Vector[] Piano;
        Vector PianoDoigt1,PianoDoigt2, PianoDoigt3, PianoDoigt4, PianoDoigt5,
            PianoDoigt6, PianoDoigt7, PianoDoigt8, PianoDoigt9, PianoDoigt10;
        public FrameDataForm()
        {
            InitializeComponent();
            Vector size = new Vector(200f,1f,1f);
            //Vector center = new Vector();
            Test = new InteractionBox(Test.Center,size);

            Lenght = new Label[] { lenght1, lenght2, lenght3, lenght4, lenght5, lenght6, lenght7, lenght8, lenght9, lenght10 };
            Position = new Label[] { Position1, Position2, Position3, Position4, Position5, Position6, Position7, Position8,
                Position9, Position10, Position11, Position12, Position13, Position14, Position15, Position16 };
            Labels = new Label[] { Doigt1, Doigt2, Doigt3, Doigt4, Doigt5, Doigt6, Doigt7, Doigt8, Doigt9, Doigt10 };
            Leds = new Label[] { Led1, Led2, Led3, Led4, Led5, Led6, Led7, Led8, Led9, Led10 };
            VectorFinger = new Vector[] { Finger1, Finger2, Finger3, Finger4, Finger5,Finger6, Finger7, Finger8, Finger9, Finger1 };
            MinPressure = new Label[] { Min1, Min2, Min3, Min4, Min5 };
            //Piano = new Vector[] { PianoDoigt1, PianoDoigt2 };




            SoundPlayer DO = new SoundPlayer();
            DO.SoundLocation = "C:\\Users\\LeapMotion\\Desktop\\DO.wav";
            DO.LoadAsync();

            SoundPlayer RE = new SoundPlayer();
            

            SoundPlayer MI = new SoundPlayer();
            MI.SoundLocation = "C:\\Users\\LeapMotion\\Desktop\\MI.wav";
            MI.LoadAsync();

            SoundPlayer FA = new SoundPlayer();
            FA.SoundLocation = "C:\\Users\\LeapMotion\\Desktop\\FA.wav";
            FA.LoadAsync();

            SoundPlayer SOL = new SoundPlayer();
            SOL.SoundLocation = "C:\\Users\\LeapMotion\\Desktop\\SOL.wav";
            SOL.LoadAsync();

            Note = new SoundPlayer[] { DO, RE, MI, FA, SOL };
            RE.SoundLocation = "C:\\Users\\LeapMotion\\Desktop\\RE.wav";
            Note[1].LoadCompleted += new AsyncCompletedEventHandler(SoundPlayed);
            RE.LoadAsync();


            //Dictionnaire de longueurs lissées
            myDicList.Add(0, new List<float>());
            myDicList.Add(1, new List<float>());
            myDicList.Add(2, new List<float>());
            myDicList.Add(3, new List<float>());
            myDicList.Add(4, new List<float>());
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
            
            //set greyscale palette for image Bitmap object
            ColorPalette grayscale = bitmap.Palette;
            for (int i = 0; i < 256; i++)
            {
                grayscale.Entries[i] = Color.FromArgb((int)255, i, i, i);
            }
            bitmap.Palette = grayscale;
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


        void newFrameHandler(object sender, FrameEventArgs eventArgs)
        {
             frame = eventArgs.frame;
            

            //The following are Label controls added in design view for the form
            displayFPS.Text = frame.CurrentFramesPerSecond.ToString();
            displayHandCount.Text = frame.Hands.Count.ToString();
            controller.RequestImages(frame.Id, Leap.Image.ImageType.DEFAULT, imagedata);
            device = controller.Devices[0];

            if (frame.Hands.Count>0)
                {
            
                
                Hands = frame.Hands;
                hand = Hands[0];
                Confidence.Text = hand.Confidence.ToString();
                
                // Get the hand's normal vector and direction
                Vector normal = hand.PalmNormal;
                Vector direction = hand.Direction;
                float yaw= direction.Yaw * 180.0f / (int)Math.PI;
                float pitch = (direction.Pitch * 180.0f / (int)Math.PI);
                float roll = normal.Roll * 180.0f / (int)Math.PI;
                // Calculate the hand's pitch, roll, and yaw angles
                //Yaw.Text = yaw.ToString();
                //Pitch.Text = pitch.ToString();
                //Roll.Text = roll.ToString();
                //Get Fingers Vector
                fingers = hand.Fingers;

                VectorFinger[0] = fingers[0].StabilizedTipPosition;
                VectorFinger[1] = fingers[1].StabilizedTipPosition;
                VectorFinger[2] = fingers[2].StabilizedTipPosition;
                VectorFinger[3] = fingers[3].StabilizedTipPosition;
                VectorFinger[4] = fingers[4].StabilizedTipPosition;

                //Finger 2 appui 1er Solution
                int Finger2x = (int)VectorFinger[1].x;
                int Finger2y = (int)VectorFinger[1].y;
                Finger2xLabel.Text = Finger2x.ToString();
                Finger2yLabel.Text = Finger2y.ToString();
                float Angle = Finger2.AngleTo(Finger3);
                int AngleEntier = (int)(Angle * 180.0f / (int)Math.PI);
                label5.Text = AngleEntier.ToString();

                //Finger 2 appui 2eme solution
                distanceToFinger[0] = (int)VectorFinger[0].DistanceTo(hand.PalmPosition);
                distanceToFinger[1] = (int)VectorFinger[1].DistanceTo(hand.PalmPosition);
                distanceToFinger[2] = (int)VectorFinger[2].DistanceTo(hand.PalmPosition);
                distanceToFinger[3] = (int)VectorFinger[3].DistanceTo(hand.PalmPosition);
                distanceToFinger[4] = (int)VectorFinger[4].DistanceTo(hand.PalmPosition);

                 boneMetaCarpal = fingers[0].Bone(Bone.BoneType.TYPE_METACARPAL);
                 boneProximal = fingers[0].Bone(Bone.BoneType.TYPE_PROXIMAL);
                 boneIntermediate = fingers[0].Bone(Bone.BoneType.TYPE_INTERMEDIATE);
                 boneDistal = fingers[0].Bone(Bone.BoneType.TYPE_DISTAL);
                bool isInto = true;
                PianoDoigt1 = Test.NormalizePoint(VectorFinger[0], isInto);
                PianoDoigt2 = Test.NormalizePoint(VectorFinger[1], isInto);
                PianoDoigt3 = Test.NormalizePoint(VectorFinger[2], isInto);
                PianoDoigt4 = Test.NormalizePoint(VectorFinger[3], isInto);
                PianoDoigt5 = Test.NormalizePoint(VectorFinger[4], isInto);

                for (int x = 0; x < 16; x++)
                {
                    Position[x].BackColor = Color.LightGray;
                }
                for (int x=0 ; x<16; x++)
                {
                if(PianoDoigt1.x>(x/16f) && PianoDoigt1.x<((x+1)/16f))
                {
                     Position[x].BackColor = Color.Green;
                }
                    
                if (PianoDoigt2.x > (x / 16f) && PianoDoigt2.x < ((x + 1) / 16f))
                {
                     Position[x].BackColor = Color.Red;
                }

                if (PianoDoigt3.x > (x / 16f) && PianoDoigt3.x < ((x + 1) / 16f))
                {
                    Position[x].BackColor = Color.Blue;
                }
                if (PianoDoigt4.x > (x / 16f) && PianoDoigt4.x < ((x + 1) / 16f))
                {
                    Position[x].BackColor = Color.Orange;
                }
                if (PianoDoigt5.x > (x / 16f) && PianoDoigt5.x < ((x + 1) / 16f))
                {
                    Position[x].BackColor = Color.Purple;
                }

                }
               
                for (int i = 0; i < fingers.Count; i++)
                {

                    Labels[i].Text = distanceToFinger[i].ToString();

                    Lenght[i].Text = LenghtLissé[i].ToString();
                    MinPressure[i].Text = ((int)MinPressureInt[i]).ToString();

                }
            }
        }
       
        void onImageRequestFailed(object sender, ImageRequestFailedEventArgs e)
        {
            if (e.reason == Leap.Image.RequestFailureReason.Insufficient_Buffer)
            {
                imagedata = new byte[e.requiredBufferSize];
            }
            Console.WriteLine("Image request failed: " + e.message);
        }

        void onImageReady(object sender, ImageEventArgs e)
        {
            Rectangle lockArea = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
            BitmapData bitmapData = bitmap.LockBits(lockArea, ImageLockMode.WriteOnly, PixelFormat.Format8bppIndexed);
            byte[] rawImageData = imagedata;
            System.Runtime.InteropServices.Marshal.Copy(rawImageData, 0, bitmapData.Scan0, e.image.Width * e.image.Height * 2 * e.image.BytesPerPixel);
            bitmap.UnlockBits(bitmapData);
            displayImages.Image = bitmap;
            
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

            Task.Factory.StartNew(() => {
                while(true)
                {
                    if (frame.Hands.Count> 0)
                    {
                        for (int i=0;i<fingers.Count;i++)
            {
                            if (distanceToFinger[i] < MinPressureInt[i])
                            {
                                Leds[i].BackColor = Color.Blue;
                            }
                            else
                                Leds[i].BackColor = Color.Red;

                            if (distanceToFinger[i] < MinPressureInt[i])
                            {
                                Note[i].PlaySync();
                            }
                            
                        }
                }
                }

            });
}
        int GetLenghtLissé(int i)
        {
            if(myDicList[i].Count>0)
            {
                return myDicList[i].ConvertAll(Convert.ToInt32).Sum() / myDicList[i].Count;
            }
            else
                return myDicList[i].ConvertAll(Convert.ToInt32).Sum() / 1;
        }
        void Lissage(Object source, System.Timers.ElapsedEventArgs e)
        {  
            label16.BackColor= Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            if (frame.Hands.Count > 0)
            {

                for (int z = 0; z < fingers.Count; z++)
                {
        
                    if (myDicList[z].Count > 20)
                    {
                        myDicList[z].RemoveAt(0);
                    }
                    if (z == 0)
                    {
                        myDicList[z].Add( boneProximal.Center.DistanceTo(boneIntermediate.Center) + boneIntermediate.Center.DistanceTo(boneDistal.Center));
                        MinPressureInt[z] = GetLenghtLissé(z);
                    }
                    else
                    {
                        myDicList[z].Add(fingers[z].Length);
                        MinPressureInt[z] = Math.Sqrt(Math.Pow(GetLenghtLissé(z), 2) + Math.Pow(hand.PalmPosition.DistanceTo(fingers[z].Bone(Bone.BoneType.TYPE_METACARPAL).Center), 2));
                    }
                    LenghtLissé[z] = myDicList[z].ConvertAll(Convert.ToInt32).Sum() / myDicList[z].Count;
                    
                }
            }
            else
                for(int z=0;z<5;z++)
                {
                    myDicList[z].Clear();
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
            label18.Text = rayonCourbure.ToString();
            //return;
        }
    }
}
