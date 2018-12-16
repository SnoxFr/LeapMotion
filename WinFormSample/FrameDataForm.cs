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
        MultiDimDictList BufferLenghtRight = new MultiDimDictList();
        MultiDimDictList BufferLenghtLeft = new MultiDimDictList();
        private byte[] imagedata = new byte[1];
        private Controller controller = new Controller();
        Bitmap bitmap = new Bitmap(640, 480, PixelFormat.Format8bppIndexed);
        private static System.Timers.Timer aTimer;
        private Random rnd = new Random();
        List<Hand> Hands= new List<Hand>() ;
        List<Finger> fingersRight = new List<Finger>();
        List<Finger> fingersLeft = new List<Finger>();

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
        Hand handRight = new Hand();
        Hand handLeft = new Hand();
        Hand handTempo = new Hand();
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
            MinPressure = new Label[] { Min1, Min2, Min3, Min4, Min5,Min6,Min7,Min8,Min9,Min10 };
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
            handRight = null;
            handLeft = null;

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

                    // Get the hand's normal vector and direction
                    //Vector normal = handRight.PalmNormal;
                    //Vector direction = handRight.Direction;
                    //float yaw= direction.Yaw * 180.0f / (int)Math.PI;
                    //float pitch = (direction.Pitch * 180.0f / (int)Math.PI);
                    //float roll = normal.Roll * 180.0f / (int)Math.PI;
                    // Calculate the hand's pitch, roll, and yaw angles
                    //Yaw.Text = yaw.ToString();
                    //Pitch.Text = pitch.ToString();
                    //Roll.Text = roll.ToString();
                    //Get Fingers Vector
                    //for (int i=0; i<)

                    VectorFinger[0] = fingersRight[0].StabilizedTipPosition;
                    VectorFinger[1] = fingersRight[1].StabilizedTipPosition;
                    VectorFinger[2] = fingersRight[2].StabilizedTipPosition;
                    VectorFinger[3] = fingersRight[3].StabilizedTipPosition;
                    VectorFinger[4] = fingersRight[4].StabilizedTipPosition;
                    

                    //Finger 2 appui 1er Solution
                    //int Finger2x = (int)VectorFinger[1].x;
                    //int Finger2y = (int)VectorFinger[1].y;
                    //Finger2xLabel.Text = Finger2x.ToString();
                    //Finger2yLabel.Text = Finger2y.ToString();
                    //float Angle = Finger2.AngleTo(Finger3);
                    //int AngleEntier = (int)(Angle * 180.0f / (int)Math.PI);
                    //label5.Text = AngleEntier.ToString();

                    //Finger 2 appui 2eme solution
                    distanceToFinger[0] = (int)VectorFinger[0].DistanceTo(handRight.PalmPosition);
                    distanceToFinger[1] = (int)VectorFinger[1].DistanceTo(handRight.PalmPosition);
                    distanceToFinger[2] = (int)VectorFinger[2].DistanceTo(handRight.PalmPosition);
                    distanceToFinger[3] = (int)VectorFinger[3].DistanceTo(handRight.PalmPosition);
                    distanceToFinger[4] = (int)VectorFinger[4].DistanceTo(handRight.PalmPosition);

                   

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
                    for (int x = 0; x < 16; x++)
                    {
                        if (PianoDoigt1.x > (x / 16f) && PianoDoigt1.x < ((x + 1) / 16f))
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

                    for (int i = 0; i < fingersRight.Count; i++)
                    {

                        Labels[i].Text = distanceToFinger[i].ToString();

                        Lenght[i].Text = LenghtLissé[i].ToString();
                        MinPressure[i].Text = ((int)MinPressureInt[i]).ToString();

                    }
                }
                if(handLeft!=null)
                {

                    VectorFinger[5] = fingersLeft[0].StabilizedTipPosition;
                    VectorFinger[6] = fingersLeft[1].StabilizedTipPosition;
                    VectorFinger[7] = fingersLeft[2].StabilizedTipPosition;
                    VectorFinger[8] = fingersLeft[3].StabilizedTipPosition;
                    VectorFinger[9] = fingersLeft[4].StabilizedTipPosition;

                    distanceToFinger[5] = (int)VectorFinger[5].DistanceTo(handLeft.PalmPosition);
                    distanceToFinger[6] = (int)VectorFinger[6].DistanceTo(handLeft.PalmPosition);
                    distanceToFinger[7] = (int)VectorFinger[7].DistanceTo(handLeft.PalmPosition);
                    distanceToFinger[8] = (int)VectorFinger[8].DistanceTo(handLeft.PalmPosition);
                    distanceToFinger[9] = (int)VectorFinger[9].DistanceTo(handLeft.PalmPosition);

                    for (int i = 5; i < fingersLeft.Count+5; i++)
                    {

                        Labels[i].Text = distanceToFinger[i].ToString();

                        Lenght[i].Text = LenghtLissé[i].ToString();
                        MinPressure[i].Text = ((int)MinPressureInt[i]).ToString();

                    }

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
                Thread.Sleep(1000);
                while(true)
                {
                    if (handRight!=null)
                    {
                        for(int i = 0; i < 10; i++)
                        {
                            Leds[i].Invoke((MethodInvoker)(() => Leds[i].BackColor = Color.Red));
                        }
                        
                        for (int i=0;i<fingersRight.Count;i++)
                        {
                            if (distanceToFinger[i] < MinPressureInt[i])
                            {
                                
                                Leds[i].Invoke((MethodInvoker)(() => Leds[i].BackColor = Color.Blue));
                            }
 
                            if (distanceToFinger[i] < MinPressureInt[i])
                            {
                                Note[i].PlaySync();
                            }
                            
                        }
                       
                    }
                }

            });
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
                        MinPressureInt[z] = GetLenghtLisséRight(z);
                    }
                    else
                    {
                        BufferLenghtRight[z].Add(fingersRight[z].Length);
                        MinPressureInt[z] = Math.Sqrt(Math.Pow(GetLenghtLisséRight(z), 2) + Math.Pow(handTempo.PalmPosition.DistanceTo(fingersRight[z].Bone(Bone.BoneType.TYPE_METACARPAL).Center), 2));
                    }
                    LenghtLissé[z] = BufferLenghtRight[z].ConvertAll(Convert.ToInt32).Sum() / BufferLenghtRight[z].Count;
                    
                }
            }
            else
                for(int z=0;z<5;z++)
                {
                    BufferLenghtRight[z].Clear();
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
                        MinPressureInt[z + 5] = GetLenghtLisséLeft(z);
                    }
                    else
                    {
                        BufferLenghtLeft[z].Add(fingersLeft[z].Length);
                        MinPressureInt[z+5] = Math.Sqrt(Math.Pow(GetLenghtLisséLeft(z), 2) + Math.Pow(handLeft.PalmPosition.DistanceTo(fingersLeft[z].Bone(Bone.BoneType.TYPE_METACARPAL).Center), 2));
                    }
                    LenghtLissé[z+5] = BufferLenghtLeft[z].ConvertAll(Convert.ToInt32).Sum() / BufferLenghtLeft[z].Count;

                }
            }
            else
                for (int z = 0; z < 5; z++)
                {
                    BufferLenghtLeft[z].Clear();
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
