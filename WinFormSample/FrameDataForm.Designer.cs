using System.Drawing;
using System.Windows.Forms;

namespace WinFormSample
{
    partial class FrameDataForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
            #region Windows Form Designer generated code

            /// <summary>
            /// Required method for Designer support - do not modify
            /// the contents of this method with the code editor.
            /// </summary>
            private void InitializeComponent()
        {
            this.ConnectionUSB = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Doigt1 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.Doigt2 = new System.Windows.Forms.Label();
            this.Doigt3 = new System.Windows.Forms.Label();
            this.Doigt4 = new System.Windows.Forms.Label();
            this.Doigt5 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.Led1 = new System.Windows.Forms.Label();
            this.Led2 = new System.Windows.Forms.Label();
            this.Led3 = new System.Windows.Forms.Label();
            this.Led4 = new System.Windows.Forms.Label();
            this.Led5 = new System.Windows.Forms.Label();
            this.Diagnostic = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Min6 = new System.Windows.Forms.Label();
            this.Min7 = new System.Windows.Forms.Label();
            this.Min8 = new System.Windows.Forms.Label();
            this.Min9 = new System.Windows.Forms.Label();
            this.Min10 = new System.Windows.Forms.Label();
            this.lenght6 = new System.Windows.Forms.Label();
            this.lenght7 = new System.Windows.Forms.Label();
            this.lenght8 = new System.Windows.Forms.Label();
            this.lenght9 = new System.Windows.Forms.Label();
            this.lenght10 = new System.Windows.Forms.Label();
            this.Led6 = new System.Windows.Forms.Label();
            this.Led7 = new System.Windows.Forms.Label();
            this.Led8 = new System.Windows.Forms.Label();
            this.Led9 = new System.Windows.Forms.Label();
            this.Led10 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.Doigt6 = new System.Windows.Forms.Label();
            this.Doigt7 = new System.Windows.Forms.Label();
            this.Doigt8 = new System.Windows.Forms.Label();
            this.Doigt9 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.Doigt10 = new System.Windows.Forms.Label();
            this.Position14 = new System.Windows.Forms.Label();
            this.Position15 = new System.Windows.Forms.Label();
            this.Position16 = new System.Windows.Forms.Label();
            this.Position11 = new System.Windows.Forms.Label();
            this.Position10 = new System.Windows.Forms.Label();
            this.Position12 = new System.Windows.Forms.Label();
            this.Position13 = new System.Windows.Forms.Label();
            this.Position9 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.Min5 = new System.Windows.Forms.Label();
            this.Min4 = new System.Windows.Forms.Label();
            this.Min3 = new System.Windows.Forms.Label();
            this.Min2 = new System.Windows.Forms.Label();
            this.Min1 = new System.Windows.Forms.Label();
            this.Position8 = new System.Windows.Forms.Label();
            this.Position7 = new System.Windows.Forms.Label();
            this.Position6 = new System.Windows.Forms.Label();
            this.Position5 = new System.Windows.Forms.Label();
            this.Position4 = new System.Windows.Forms.Label();
            this.Position3 = new System.Windows.Forms.Label();
            this.Position2 = new System.Windows.Forms.Label();
            this.Position1 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lenght5 = new System.Windows.Forms.Label();
            this.lenght4 = new System.Windows.Forms.Label();
            this.lenght3 = new System.Windows.Forms.Label();
            this.lenght2 = new System.Windows.Forms.Label();
            this.lenght1 = new System.Windows.Forms.Label();
            this.Confidence = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.FailureReason = new System.Windows.Forms.Label();
            this.Lightning = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Failure = new System.Windows.Forms.Label();
            this.Clean = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.Roll = new System.Windows.Forms.Label();
            this.Yaw = new System.Windows.Forms.Label();
            this.Pitch = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Finger2yLabel = new System.Windows.Forms.Label();
            this.Finger2xLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.displayFPS = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.displayHandCount = new System.Windows.Forms.Label();
            this.displayImages = new System.Windows.Forms.PictureBox();
            this.Diagnostic.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayImages)).BeginInit();
            this.SuspendLayout();
            // 
            // ConnectionUSB
            // 
            this.ConnectionUSB.AutoSize = true;
            this.ConnectionUSB.BackColor = System.Drawing.Color.Red;
            this.ConnectionUSB.Location = new System.Drawing.Point(208, 76);
            this.ConnectionUSB.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ConnectionUSB.MinimumSize = new System.Drawing.Size(100, 10);
            this.ConnectionUSB.Name = "ConnectionUSB";
            this.ConnectionUSB.Size = new System.Drawing.Size(100, 25);
            this.ConnectionUSB.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Connected:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 664);
            this.label15.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(180, 25);
            this.label15.TabIndex = 36;
            this.label15.Text = "Distance to Palm:";
            // 
            // Doigt1
            // 
            this.Doigt1.AutoSize = true;
            this.Doigt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Doigt1.Location = new System.Drawing.Point(1109, 787);
            this.Doigt1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Doigt1.Name = "Doigt1";
            this.Doigt1.Size = new System.Drawing.Size(146, 42);
            this.Doigt1.TabIndex = 35;
            this.Doigt1.Text = "Doigt 1:";
            this.Doigt1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(1492, 575);
            this.label18.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(0, 42);
            this.label18.TabIndex = 39;
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Doigt2
            // 
            this.Doigt2.AutoSize = true;
            this.Doigt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Doigt2.Location = new System.Drawing.Point(1267, 787);
            this.Doigt2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Doigt2.Name = "Doigt2";
            this.Doigt2.Size = new System.Drawing.Size(126, 42);
            this.Doigt2.TabIndex = 41;
            this.Doigt2.Text = "Doigt2";
            this.Doigt2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Doigt3
            // 
            this.Doigt3.AutoSize = true;
            this.Doigt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Doigt3.Location = new System.Drawing.Point(1418, 785);
            this.Doigt3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Doigt3.Name = "Doigt3";
            this.Doigt3.Size = new System.Drawing.Size(126, 42);
            this.Doigt3.TabIndex = 42;
            this.Doigt3.Text = "Doigt3";
            this.Doigt3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Doigt4
            // 
            this.Doigt4.AutoSize = true;
            this.Doigt4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Doigt4.Location = new System.Drawing.Point(1576, 787);
            this.Doigt4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Doigt4.Name = "Doigt4";
            this.Doigt4.Size = new System.Drawing.Size(126, 42);
            this.Doigt4.TabIndex = 43;
            this.Doigt4.Text = "Doigt4";
            this.Doigt4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Doigt5
            // 
            this.Doigt5.AutoSize = true;
            this.Doigt5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Doigt5.Location = new System.Drawing.Point(1727, 789);
            this.Doigt5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Doigt5.Name = "Doigt5";
            this.Doigt5.Size = new System.Drawing.Size(126, 42);
            this.Doigt5.TabIndex = 44;
            this.Doigt5.Text = "Doigt5";
            this.Doigt5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(1118, 679);
            this.label24.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(88, 25);
            this.label24.TabIndex = 45;
            this.label24.Text = "PouceD";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(1281, 679);
            this.label25.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(79, 25);
            this.label25.TabIndex = 46;
            this.label25.Text = "IndexD";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(1430, 679);
            this.label26.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(93, 25);
            this.label26.TabIndex = 47;
            this.label26.Text = "MajeurD";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(1578, 679);
            this.label27.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(113, 25);
            this.label27.TabIndex = 48;
            this.label27.Text = "AnnuaireD";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(1744, 681);
            this.label28.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(129, 25);
            this.label28.TabIndex = 49;
            this.label28.Text = "AuriculaireD";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Led1
            // 
            this.Led1.AutoSize = true;
            this.Led1.BackColor = System.Drawing.Color.Red;
            this.Led1.Location = new System.Drawing.Point(1116, 734);
            this.Led1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Led1.MinimumSize = new System.Drawing.Size(100, 10);
            this.Led1.Name = "Led1";
            this.Led1.Size = new System.Drawing.Size(100, 25);
            this.Led1.TabIndex = 50;
            this.Led1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Led2
            // 
            this.Led2.AutoSize = true;
            this.Led2.BackColor = System.Drawing.Color.Red;
            this.Led2.Location = new System.Drawing.Point(1281, 734);
            this.Led2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Led2.MinimumSize = new System.Drawing.Size(100, 10);
            this.Led2.Name = "Led2";
            this.Led2.Size = new System.Drawing.Size(100, 25);
            this.Led2.TabIndex = 51;
            this.Led2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Led3
            // 
            this.Led3.AutoSize = true;
            this.Led3.BackColor = System.Drawing.Color.Red;
            this.Led3.Location = new System.Drawing.Point(1434, 734);
            this.Led3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Led3.MinimumSize = new System.Drawing.Size(100, 10);
            this.Led3.Name = "Led3";
            this.Led3.Size = new System.Drawing.Size(100, 25);
            this.Led3.TabIndex = 52;
            this.Led3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Led4
            // 
            this.Led4.AutoSize = true;
            this.Led4.BackColor = System.Drawing.Color.Red;
            this.Led4.Location = new System.Drawing.Point(1581, 736);
            this.Led4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Led4.MinimumSize = new System.Drawing.Size(100, 10);
            this.Led4.Name = "Led4";
            this.Led4.Size = new System.Drawing.Size(100, 25);
            this.Led4.TabIndex = 53;
            this.Led4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Led5
            // 
            this.Led5.AutoSize = true;
            this.Led5.BackColor = System.Drawing.Color.Red;
            this.Led5.Location = new System.Drawing.Point(1744, 736);
            this.Led5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Led5.MinimumSize = new System.Drawing.Size(100, 10);
            this.Led5.Name = "Led5";
            this.Led5.Size = new System.Drawing.Size(100, 25);
            this.Led5.TabIndex = 54;
            this.Led5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Diagnostic
            // 
            this.Diagnostic.Controls.Add(this.tabPage1);
            this.Diagnostic.Controls.Add(this.tabPage2);
            this.Diagnostic.Location = new System.Drawing.Point(12, 1);
            this.Diagnostic.Name = "Diagnostic";
            this.Diagnostic.SelectedIndex = 0;
            this.Diagnostic.Size = new System.Drawing.Size(1883, 1304);
            this.Diagnostic.TabIndex = 55;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Min6);
            this.tabPage1.Controls.Add(this.Min7);
            this.tabPage1.Controls.Add(this.Min8);
            this.tabPage1.Controls.Add(this.Min9);
            this.tabPage1.Controls.Add(this.Min10);
            this.tabPage1.Controls.Add(this.lenght6);
            this.tabPage1.Controls.Add(this.lenght7);
            this.tabPage1.Controls.Add(this.lenght8);
            this.tabPage1.Controls.Add(this.lenght9);
            this.tabPage1.Controls.Add(this.lenght10);
            this.tabPage1.Controls.Add(this.Led6);
            this.tabPage1.Controls.Add(this.Led7);
            this.tabPage1.Controls.Add(this.Led8);
            this.tabPage1.Controls.Add(this.Led9);
            this.tabPage1.Controls.Add(this.Led10);
            this.tabPage1.Controls.Add(this.label49);
            this.tabPage1.Controls.Add(this.label50);
            this.tabPage1.Controls.Add(this.label51);
            this.tabPage1.Controls.Add(this.label52);
            this.tabPage1.Controls.Add(this.label53);
            this.tabPage1.Controls.Add(this.Doigt6);
            this.tabPage1.Controls.Add(this.Doigt7);
            this.tabPage1.Controls.Add(this.Doigt8);
            this.tabPage1.Controls.Add(this.Doigt9);
            this.tabPage1.Controls.Add(this.label58);
            this.tabPage1.Controls.Add(this.Doigt10);
            this.tabPage1.Controls.Add(this.Position14);
            this.tabPage1.Controls.Add(this.Position15);
            this.tabPage1.Controls.Add(this.Position16);
            this.tabPage1.Controls.Add(this.Position11);
            this.tabPage1.Controls.Add(this.Position10);
            this.tabPage1.Controls.Add(this.Position12);
            this.tabPage1.Controls.Add(this.Position13);
            this.tabPage1.Controls.Add(this.Position9);
            this.tabPage1.Controls.Add(this.label29);
            this.tabPage1.Controls.Add(this.label23);
            this.tabPage1.Controls.Add(this.Min5);
            this.tabPage1.Controls.Add(this.Min4);
            this.tabPage1.Controls.Add(this.Min3);
            this.tabPage1.Controls.Add(this.Min2);
            this.tabPage1.Controls.Add(this.Min1);
            this.tabPage1.Controls.Add(this.Position8);
            this.tabPage1.Controls.Add(this.Position7);
            this.tabPage1.Controls.Add(this.Position6);
            this.tabPage1.Controls.Add(this.Position5);
            this.tabPage1.Controls.Add(this.Position4);
            this.tabPage1.Controls.Add(this.Position3);
            this.tabPage1.Controls.Add(this.Position2);
            this.tabPage1.Controls.Add(this.Position1);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.lenght5);
            this.tabPage1.Controls.Add(this.lenght4);
            this.tabPage1.Controls.Add(this.lenght3);
            this.tabPage1.Controls.Add(this.lenght2);
            this.tabPage1.Controls.Add(this.lenght1);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.Led5);
            this.tabPage1.Controls.Add(this.Led4);
            this.tabPage1.Controls.Add(this.Led3);
            this.tabPage1.Controls.Add(this.Led2);
            this.tabPage1.Controls.Add(this.Led1);
            this.tabPage1.Controls.Add(this.label28);
            this.tabPage1.Controls.Add(this.Confidence);
            this.tabPage1.Controls.Add(this.label27);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.label26);
            this.tabPage1.Controls.Add(this.label25);
            this.tabPage1.Controls.Add(this.label24);
            this.tabPage1.Controls.Add(this.Doigt5);
            this.tabPage1.Controls.Add(this.Doigt4);
            this.tabPage1.Controls.Add(this.Doigt3);
            this.tabPage1.Controls.Add(this.FailureReason);
            this.tabPage1.Controls.Add(this.Doigt2);
            this.tabPage1.Controls.Add(this.Lightning);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.Failure);
            this.tabPage1.Controls.Add(this.Doigt1);
            this.tabPage1.Controls.Add(this.Clean);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.ConnectionUSB);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1867, 1257);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Diagnostic";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Min6
            // 
            this.Min6.AutoSize = true;
            this.Min6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Min6.Location = new System.Drawing.Point(942, 906);
            this.Min6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Min6.Name = "Min6";
            this.Min6.Size = new System.Drawing.Size(72, 31);
            this.Min6.TabIndex = 132;
            this.Min6.Text = "Min6";
            this.Min6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Min7
            // 
            this.Min7.AutoSize = true;
            this.Min7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Min7.Location = new System.Drawing.Point(801, 906);
            this.Min7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Min7.Name = "Min7";
            this.Min7.Size = new System.Drawing.Size(72, 31);
            this.Min7.TabIndex = 131;
            this.Min7.Text = "Min7";
            this.Min7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Min8
            // 
            this.Min8.AutoSize = true;
            this.Min8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Min8.Location = new System.Drawing.Point(633, 904);
            this.Min8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Min8.Name = "Min8";
            this.Min8.Size = new System.Drawing.Size(72, 31);
            this.Min8.TabIndex = 130;
            this.Min8.Text = "Min8";
            this.Min8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Min9
            // 
            this.Min9.AutoSize = true;
            this.Min9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Min9.Location = new System.Drawing.Point(482, 904);
            this.Min9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Min9.Name = "Min9";
            this.Min9.Size = new System.Drawing.Size(72, 31);
            this.Min9.TabIndex = 129;
            this.Min9.Text = "Min9";
            this.Min9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Min10
            // 
            this.Min10.AutoSize = true;
            this.Min10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Min10.Location = new System.Drawing.Point(331, 904);
            this.Min10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Min10.Name = "Min10";
            this.Min10.Size = new System.Drawing.Size(87, 31);
            this.Min10.TabIndex = 128;
            this.Min10.Text = "Min10";
            this.Min10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lenght6
            // 
            this.lenght6.AutoSize = true;
            this.lenght6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lenght6.Location = new System.Drawing.Point(948, 847);
            this.lenght6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lenght6.Name = "lenght6";
            this.lenght6.Size = new System.Drawing.Size(141, 42);
            this.lenght6.TabIndex = 122;
            this.lenght6.Text = "lenght6";
            this.lenght6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lenght7
            // 
            this.lenght7.AutoSize = true;
            this.lenght7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lenght7.Location = new System.Drawing.Point(797, 847);
            this.lenght7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lenght7.Name = "lenght7";
            this.lenght7.Size = new System.Drawing.Size(141, 42);
            this.lenght7.TabIndex = 121;
            this.lenght7.Text = "lenght7";
            this.lenght7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lenght8
            // 
            this.lenght8.AutoSize = true;
            this.lenght8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lenght8.Location = new System.Drawing.Point(639, 845);
            this.lenght8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lenght8.Name = "lenght8";
            this.lenght8.Size = new System.Drawing.Size(141, 42);
            this.lenght8.TabIndex = 120;
            this.lenght8.Text = "lenght8";
            this.lenght8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lenght9
            // 
            this.lenght9.AutoSize = true;
            this.lenght9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lenght9.Location = new System.Drawing.Point(488, 845);
            this.lenght9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lenght9.Name = "lenght9";
            this.lenght9.Size = new System.Drawing.Size(141, 42);
            this.lenght9.TabIndex = 119;
            this.lenght9.Text = "lenght9";
            this.lenght9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lenght10
            // 
            this.lenght10.AutoSize = true;
            this.lenght10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lenght10.Location = new System.Drawing.Point(330, 845);
            this.lenght10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lenght10.Name = "lenght10";
            this.lenght10.Size = new System.Drawing.Size(162, 42);
            this.lenght10.TabIndex = 118;
            this.lenght10.Text = "lenght10";
            this.lenght10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Led6
            // 
            this.Led6.AutoSize = true;
            this.Led6.BackColor = System.Drawing.Color.Red;
            this.Led6.Location = new System.Drawing.Point(965, 736);
            this.Led6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Led6.MinimumSize = new System.Drawing.Size(100, 10);
            this.Led6.Name = "Led6";
            this.Led6.Size = new System.Drawing.Size(100, 25);
            this.Led6.TabIndex = 117;
            this.Led6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Led7
            // 
            this.Led7.AutoSize = true;
            this.Led7.BackColor = System.Drawing.Color.Red;
            this.Led7.Location = new System.Drawing.Point(802, 736);
            this.Led7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Led7.MinimumSize = new System.Drawing.Size(100, 10);
            this.Led7.Name = "Led7";
            this.Led7.Size = new System.Drawing.Size(100, 25);
            this.Led7.TabIndex = 116;
            this.Led7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Led8
            // 
            this.Led8.AutoSize = true;
            this.Led8.BackColor = System.Drawing.Color.Red;
            this.Led8.Location = new System.Drawing.Point(655, 734);
            this.Led8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Led8.MinimumSize = new System.Drawing.Size(100, 10);
            this.Led8.Name = "Led8";
            this.Led8.Size = new System.Drawing.Size(100, 25);
            this.Led8.TabIndex = 115;
            this.Led8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Led9
            // 
            this.Led9.AutoSize = true;
            this.Led9.BackColor = System.Drawing.Color.Red;
            this.Led9.Location = new System.Drawing.Point(502, 734);
            this.Led9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Led9.MinimumSize = new System.Drawing.Size(100, 10);
            this.Led9.Name = "Led9";
            this.Led9.Size = new System.Drawing.Size(100, 25);
            this.Led9.TabIndex = 114;
            this.Led9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Led10
            // 
            this.Led10.AutoSize = true;
            this.Led10.BackColor = System.Drawing.Color.Red;
            this.Led10.Location = new System.Drawing.Point(337, 734);
            this.Led10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Led10.MinimumSize = new System.Drawing.Size(100, 10);
            this.Led10.Name = "Led10";
            this.Led10.Size = new System.Drawing.Size(100, 25);
            this.Led10.TabIndex = 113;
            this.Led10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(965, 681);
            this.label49.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(89, 25);
            this.label49.TabIndex = 112;
            this.label49.Text = "PouceG";
            this.label49.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(816, 681);
            this.label50.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(80, 25);
            this.label50.TabIndex = 111;
            this.label50.Text = "IndexG";
            this.label50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(651, 679);
            this.label51.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(94, 25);
            this.label51.TabIndex = 110;
            this.label51.Text = "MajeurG";
            this.label51.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(502, 679);
            this.label52.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(114, 25);
            this.label52.TabIndex = 109;
            this.label52.Text = "AnnuaireG";
            this.label52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(332, 679);
            this.label53.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(130, 25);
            this.label53.TabIndex = 108;
            this.label53.Text = "AuriculaireG";
            this.label53.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Doigt6
            // 
            this.Doigt6.AutoSize = true;
            this.Doigt6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Doigt6.Location = new System.Drawing.Point(948, 789);
            this.Doigt6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Doigt6.Name = "Doigt6";
            this.Doigt6.Size = new System.Drawing.Size(126, 42);
            this.Doigt6.TabIndex = 107;
            this.Doigt6.Text = "Doigt6";
            this.Doigt6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Doigt7
            // 
            this.Doigt7.AutoSize = true;
            this.Doigt7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Doigt7.Location = new System.Drawing.Point(797, 787);
            this.Doigt7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Doigt7.Name = "Doigt7";
            this.Doigt7.Size = new System.Drawing.Size(126, 42);
            this.Doigt7.TabIndex = 106;
            this.Doigt7.Text = "Doigt7";
            this.Doigt7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Doigt8
            // 
            this.Doigt8.AutoSize = true;
            this.Doigt8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Doigt8.Location = new System.Drawing.Point(639, 785);
            this.Doigt8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Doigt8.Name = "Doigt8";
            this.Doigt8.Size = new System.Drawing.Size(126, 42);
            this.Doigt8.TabIndex = 105;
            this.Doigt8.Text = "Doigt8";
            this.Doigt8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Doigt9
            // 
            this.Doigt9.AutoSize = true;
            this.Doigt9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Doigt9.Location = new System.Drawing.Point(488, 787);
            this.Doigt9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Doigt9.Name = "Doigt9";
            this.Doigt9.Size = new System.Drawing.Size(126, 42);
            this.Doigt9.TabIndex = 104;
            this.Doigt9.Text = "Doigt9";
            this.Doigt9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label58.Location = new System.Drawing.Point(713, 575);
            this.label58.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(0, 42);
            this.label58.TabIndex = 103;
            this.label58.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Doigt10
            // 
            this.Doigt10.AutoSize = true;
            this.Doigt10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Doigt10.Location = new System.Drawing.Point(330, 787);
            this.Doigt10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Doigt10.Name = "Doigt10";
            this.Doigt10.Size = new System.Drawing.Size(147, 42);
            this.Doigt10.TabIndex = 102;
            this.Doigt10.Text = "Doigt10";
            this.Doigt10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Position14
            // 
            this.Position14.AutoSize = true;
            this.Position14.BackColor = System.Drawing.Color.Red;
            this.Position14.Location = new System.Drawing.Point(1494, 1153);
            this.Position14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Position14.MinimumSize = new System.Drawing.Size(100, 10);
            this.Position14.Name = "Position14";
            this.Position14.Size = new System.Drawing.Size(100, 28);
            this.Position14.TabIndex = 101;
            this.Position14.UseCompatibleTextRendering = true;
            // 
            // Position15
            // 
            this.Position15.AutoSize = true;
            this.Position15.BackColor = System.Drawing.Color.Red;
            this.Position15.Location = new System.Drawing.Point(1606, 1153);
            this.Position15.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Position15.MinimumSize = new System.Drawing.Size(100, 10);
            this.Position15.Name = "Position15";
            this.Position15.Size = new System.Drawing.Size(100, 28);
            this.Position15.TabIndex = 100;
            this.Position15.UseCompatibleTextRendering = true;
            // 
            // Position16
            // 
            this.Position16.AutoSize = true;
            this.Position16.BackColor = System.Drawing.Color.Red;
            this.Position16.Location = new System.Drawing.Point(1718, 1153);
            this.Position16.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Position16.MinimumSize = new System.Drawing.Size(100, 10);
            this.Position16.Name = "Position16";
            this.Position16.Size = new System.Drawing.Size(100, 28);
            this.Position16.TabIndex = 99;
            this.Position16.UseCompatibleTextRendering = true;
            // 
            // Position11
            // 
            this.Position11.AutoSize = true;
            this.Position11.BackColor = System.Drawing.Color.Red;
            this.Position11.Location = new System.Drawing.Point(1158, 1153);
            this.Position11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Position11.MinimumSize = new System.Drawing.Size(100, 10);
            this.Position11.Name = "Position11";
            this.Position11.Size = new System.Drawing.Size(100, 28);
            this.Position11.TabIndex = 98;
            this.Position11.UseCompatibleTextRendering = true;
            // 
            // Position10
            // 
            this.Position10.AutoSize = true;
            this.Position10.BackColor = System.Drawing.Color.Red;
            this.Position10.Location = new System.Drawing.Point(1046, 1153);
            this.Position10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Position10.MinimumSize = new System.Drawing.Size(100, 10);
            this.Position10.Name = "Position10";
            this.Position10.Size = new System.Drawing.Size(100, 28);
            this.Position10.TabIndex = 97;
            this.Position10.UseCompatibleTextRendering = true;
            // 
            // Position12
            // 
            this.Position12.AutoSize = true;
            this.Position12.BackColor = System.Drawing.Color.Red;
            this.Position12.Location = new System.Drawing.Point(1270, 1153);
            this.Position12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Position12.MinimumSize = new System.Drawing.Size(100, 10);
            this.Position12.Name = "Position12";
            this.Position12.Size = new System.Drawing.Size(100, 28);
            this.Position12.TabIndex = 96;
            this.Position12.UseCompatibleTextRendering = true;
            // 
            // Position13
            // 
            this.Position13.AutoSize = true;
            this.Position13.BackColor = System.Drawing.Color.Red;
            this.Position13.Location = new System.Drawing.Point(1382, 1153);
            this.Position13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Position13.MinimumSize = new System.Drawing.Size(100, 10);
            this.Position13.Name = "Position13";
            this.Position13.Size = new System.Drawing.Size(100, 28);
            this.Position13.TabIndex = 95;
            this.Position13.UseCompatibleTextRendering = true;
            // 
            // Position9
            // 
            this.Position9.AutoSize = true;
            this.Position9.BackColor = System.Drawing.Color.Red;
            this.Position9.Location = new System.Drawing.Point(934, 1153);
            this.Position9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Position9.MinimumSize = new System.Drawing.Size(100, 10);
            this.Position9.Name = "Position9";
            this.Position9.Size = new System.Drawing.Size(100, 28);
            this.Position9.TabIndex = 94;
            this.Position9.UseCompatibleTextRendering = true;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(9, 31);
            this.label29.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(180, 25);
            this.label29.TabIndex = 93;
            this.label29.Text = "Timer Heart Beat:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(8, 889);
            this.label23.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(66, 25);
            this.label23.TabIndex = 92;
            this.label23.Text = "Seuil:";
            // 
            // Min5
            // 
            this.Min5.AutoSize = true;
            this.Min5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Min5.Location = new System.Drawing.Point(1721, 906);
            this.Min5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Min5.Name = "Min5";
            this.Min5.Size = new System.Drawing.Size(72, 31);
            this.Min5.TabIndex = 91;
            this.Min5.Text = "Min5";
            this.Min5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Min4
            // 
            this.Min4.AutoSize = true;
            this.Min4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Min4.Location = new System.Drawing.Point(1580, 906);
            this.Min4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Min4.Name = "Min4";
            this.Min4.Size = new System.Drawing.Size(72, 31);
            this.Min4.TabIndex = 90;
            this.Min4.Text = "Min4";
            this.Min4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Min3
            // 
            this.Min3.AutoSize = true;
            this.Min3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Min3.Location = new System.Drawing.Point(1412, 904);
            this.Min3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Min3.Name = "Min3";
            this.Min3.Size = new System.Drawing.Size(72, 31);
            this.Min3.TabIndex = 89;
            this.Min3.Text = "Min3";
            this.Min3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Min2
            // 
            this.Min2.AutoSize = true;
            this.Min2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Min2.Location = new System.Drawing.Point(1261, 904);
            this.Min2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Min2.Name = "Min2";
            this.Min2.Size = new System.Drawing.Size(72, 31);
            this.Min2.TabIndex = 88;
            this.Min2.Text = "Min2";
            this.Min2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Min1
            // 
            this.Min1.AutoSize = true;
            this.Min1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Min1.Location = new System.Drawing.Point(1110, 904);
            this.Min1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Min1.Name = "Min1";
            this.Min1.Size = new System.Drawing.Size(72, 31);
            this.Min1.TabIndex = 87;
            this.Min1.Text = "Min1";
            this.Min1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Position8
            // 
            this.Position8.AutoSize = true;
            this.Position8.BackColor = System.Drawing.Color.Red;
            this.Position8.Location = new System.Drawing.Point(822, 1153);
            this.Position8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Position8.MinimumSize = new System.Drawing.Size(100, 10);
            this.Position8.Name = "Position8";
            this.Position8.Size = new System.Drawing.Size(100, 28);
            this.Position8.TabIndex = 85;
            this.Position8.UseCompatibleTextRendering = true;
            // 
            // Position7
            // 
            this.Position7.AutoSize = true;
            this.Position7.BackColor = System.Drawing.Color.Red;
            this.Position7.Location = new System.Drawing.Point(710, 1153);
            this.Position7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Position7.MinimumSize = new System.Drawing.Size(100, 10);
            this.Position7.Name = "Position7";
            this.Position7.Size = new System.Drawing.Size(100, 28);
            this.Position7.TabIndex = 84;
            this.Position7.UseCompatibleTextRendering = true;
            // 
            // Position6
            // 
            this.Position6.AutoSize = true;
            this.Position6.BackColor = System.Drawing.Color.Red;
            this.Position6.Location = new System.Drawing.Point(598, 1153);
            this.Position6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Position6.MinimumSize = new System.Drawing.Size(100, 10);
            this.Position6.Name = "Position6";
            this.Position6.Size = new System.Drawing.Size(100, 28);
            this.Position6.TabIndex = 83;
            this.Position6.UseCompatibleTextRendering = true;
            // 
            // Position5
            // 
            this.Position5.AutoSize = true;
            this.Position5.BackColor = System.Drawing.Color.Red;
            this.Position5.Location = new System.Drawing.Point(486, 1153);
            this.Position5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Position5.MinimumSize = new System.Drawing.Size(100, 10);
            this.Position5.Name = "Position5";
            this.Position5.Size = new System.Drawing.Size(100, 28);
            this.Position5.TabIndex = 82;
            this.Position5.UseCompatibleTextRendering = true;
            // 
            // Position4
            // 
            this.Position4.AutoSize = true;
            this.Position4.BackColor = System.Drawing.Color.Red;
            this.Position4.Location = new System.Drawing.Point(374, 1153);
            this.Position4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Position4.MinimumSize = new System.Drawing.Size(100, 10);
            this.Position4.Name = "Position4";
            this.Position4.Size = new System.Drawing.Size(100, 28);
            this.Position4.TabIndex = 81;
            this.Position4.UseCompatibleTextRendering = true;
            // 
            // Position3
            // 
            this.Position3.AutoSize = true;
            this.Position3.BackColor = System.Drawing.Color.Red;
            this.Position3.Location = new System.Drawing.Point(258, 1153);
            this.Position3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Position3.MinimumSize = new System.Drawing.Size(100, 10);
            this.Position3.Name = "Position3";
            this.Position3.Size = new System.Drawing.Size(100, 28);
            this.Position3.TabIndex = 80;
            this.Position3.UseCompatibleTextRendering = true;
            // 
            // Position2
            // 
            this.Position2.AutoSize = true;
            this.Position2.BackColor = System.Drawing.Color.Red;
            this.Position2.Location = new System.Drawing.Point(146, 1153);
            this.Position2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Position2.MinimumSize = new System.Drawing.Size(100, 10);
            this.Position2.Name = "Position2";
            this.Position2.Size = new System.Drawing.Size(100, 28);
            this.Position2.TabIndex = 79;
            this.Position2.UseCompatibleTextRendering = true;
            // 
            // Position1
            // 
            this.Position1.AutoSize = true;
            this.Position1.BackColor = System.Drawing.Color.Red;
            this.Position1.Location = new System.Drawing.Point(34, 1153);
            this.Position1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Position1.MinimumSize = new System.Drawing.Size(100, 10);
            this.Position1.Name = "Position1";
            this.Position1.Size = new System.Drawing.Size(100, 28);
            this.Position1.TabIndex = 78;
            this.Position1.UseCompatibleTextRendering = true;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(15, 847);
            this.label22.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(147, 25);
            this.label22.TabIndex = 77;
            this.label22.Text = "Length Lissée";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(15, 906);
            this.label21.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(0, 25);
            this.label21.TabIndex = 76;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(15, 785);
            this.label20.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(180, 25);
            this.label20.TabIndex = 75;
            this.label20.Text = "Distance to Palm:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(208, 31);
            this.label16.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label16.MinimumSize = new System.Drawing.Size(100, 10);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 25);
            this.label16.TabIndex = 68;
            // 
            // lenght5
            // 
            this.lenght5.AutoSize = true;
            this.lenght5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lenght5.Location = new System.Drawing.Point(1727, 847);
            this.lenght5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lenght5.Name = "lenght5";
            this.lenght5.Size = new System.Drawing.Size(141, 42);
            this.lenght5.TabIndex = 67;
            this.lenght5.Text = "lenght5";
            this.lenght5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lenght4
            // 
            this.lenght4.AutoSize = true;
            this.lenght4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lenght4.Location = new System.Drawing.Point(1576, 847);
            this.lenght4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lenght4.Name = "lenght4";
            this.lenght4.Size = new System.Drawing.Size(141, 42);
            this.lenght4.TabIndex = 66;
            this.lenght4.Text = "lenght4";
            this.lenght4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lenght3
            // 
            this.lenght3.AutoSize = true;
            this.lenght3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lenght3.Location = new System.Drawing.Point(1418, 845);
            this.lenght3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lenght3.Name = "lenght3";
            this.lenght3.Size = new System.Drawing.Size(141, 42);
            this.lenght3.TabIndex = 65;
            this.lenght3.Text = "lenght3";
            this.lenght3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lenght2
            // 
            this.lenght2.AutoSize = true;
            this.lenght2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lenght2.Location = new System.Drawing.Point(1267, 845);
            this.lenght2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lenght2.Name = "lenght2";
            this.lenght2.Size = new System.Drawing.Size(141, 42);
            this.lenght2.TabIndex = 64;
            this.lenght2.Text = "lenght2";
            this.lenght2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lenght1
            // 
            this.lenght1.AutoSize = true;
            this.lenght1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lenght1.Location = new System.Drawing.Point(1109, 845);
            this.lenght1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lenght1.Name = "lenght1";
            this.lenght1.Size = new System.Drawing.Size(141, 42);
            this.lenght1.TabIndex = 63;
            this.lenght1.Text = "lenght1";
            this.lenght1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Confidence
            // 
            this.Confidence.AutoSize = true;
            this.Confidence.Location = new System.Drawing.Point(197, 326);
            this.Confidence.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Confidence.Name = "Confidence";
            this.Confidence.Size = new System.Drawing.Size(121, 25);
            this.Confidence.TabIndex = 56;
            this.Confidence.Text = "Confidence";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(13, 301);
            this.label17.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(160, 50);
            this.label17.TabIndex = 55;
            this.label17.Text = "Confidence \r\nin the measure:";
            // 
            // FailureReason
            // 
            this.FailureReason.AutoSize = true;
            this.FailureReason.Location = new System.Drawing.Point(197, 251);
            this.FailureReason.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.FailureReason.Name = "FailureReason";
            this.FailureReason.Size = new System.Drawing.Size(111, 25);
            this.FailureReason.TabIndex = 49;
            this.FailureReason.Text = "No Failure";
            // 
            // Lightning
            // 
            this.Lightning.AutoSize = true;
            this.Lightning.Location = new System.Drawing.Point(197, 187);
            this.Lightning.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Lightning.MinimumSize = new System.Drawing.Size(100, 25);
            this.Lightning.Name = "Lightning";
            this.Lightning.Size = new System.Drawing.Size(118, 25);
            this.Lightning.TabIndex = 48;
            this.Lightning.Text = "Lightning ?";
            this.Lightning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 187);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 25);
            this.label6.TabIndex = 47;
            this.label6.Text = "Lightning";
            // 
            // Failure
            // 
            this.Failure.AutoSize = true;
            this.Failure.Location = new System.Drawing.Point(13, 251);
            this.Failure.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Failure.Name = "Failure";
            this.Failure.Size = new System.Drawing.Size(164, 25);
            this.Failure.TabIndex = 46;
            this.Failure.Text = "Failure Reason:";
            // 
            // Clean
            // 
            this.Clean.AutoSize = true;
            this.Clean.Location = new System.Drawing.Point(197, 119);
            this.Clean.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Clean.MinimumSize = new System.Drawing.Size(100, 25);
            this.Clean.Name = "Clean";
            this.Clean.Size = new System.Drawing.Size(122, 25);
            this.Clean.TabIndex = 45;
            this.Clean.Text = "Clean ????";
            this.Clean.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 25);
            this.label4.TabIndex = 44;
            this.label4.Text = "State";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.Roll);
            this.tabPage2.Controls.Add(this.Yaw);
            this.tabPage2.Controls.Add(this.Pitch);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.Finger2yLabel);
            this.tabPage2.Controls.Add(this.Finger2xLabel);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.displayFPS);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.displayHandCount);
            this.tabPage2.Controls.Add(this.displayImages);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1867, 1257);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Rendu ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1239, 458);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 25);
            this.label8.TabIndex = 71;
            this.label8.Text = "Finger2yAxis";
            // 
            // Roll
            // 
            this.Roll.AutoSize = true;
            this.Roll.Location = new System.Drawing.Point(1519, 593);
            this.Roll.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Roll.Name = "Roll";
            this.Roll.Size = new System.Drawing.Size(70, 25);
            this.Roll.TabIndex = 65;
            this.Roll.Text = "label3";
            // 
            // Yaw
            // 
            this.Yaw.AutoSize = true;
            this.Yaw.Location = new System.Drawing.Point(1382, 593);
            this.Yaw.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Yaw.Name = "Yaw";
            this.Yaw.Size = new System.Drawing.Size(70, 25);
            this.Yaw.TabIndex = 64;
            this.Yaw.Text = "label2";
            // 
            // Pitch
            // 
            this.Pitch.AutoSize = true;
            this.Pitch.Location = new System.Drawing.Point(1235, 593);
            this.Pitch.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Pitch.Name = "Pitch";
            this.Pitch.Size = new System.Drawing.Size(70, 25);
            this.Pitch.TabIndex = 63;
            this.Pitch.Text = "label1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1239, 407);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 25);
            this.label9.TabIndex = 70;
            this.label9.Text = "Finger2xAxis";
            // 
            // Finger2yLabel
            // 
            this.Finger2yLabel.AutoSize = true;
            this.Finger2yLabel.Location = new System.Drawing.Point(1397, 458);
            this.Finger2yLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Finger2yLabel.Name = "Finger2yLabel";
            this.Finger2yLabel.Size = new System.Drawing.Size(149, 25);
            this.Finger2yLabel.TabIndex = 69;
            this.Finger2yLabel.Text = "Finger2yLabel";
            // 
            // Finger2xLabel
            // 
            this.Finger2xLabel.AutoSize = true;
            this.Finger2xLabel.Location = new System.Drawing.Point(1397, 407);
            this.Finger2xLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Finger2xLabel.Name = "Finger2xLabel";
            this.Finger2xLabel.Size = new System.Drawing.Size(149, 25);
            this.Finger2xLabel.TabIndex = 68;
            this.Finger2xLabel.Text = "Finger2xLabel";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1239, 348);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(267, 25);
            this.label7.TabIndex = 67;
            this.label7.Text = "Angle Finger 1 to Finger 2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1540, 333);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 42);
            this.label5.TabIndex = 66;
            this.label5.Text = "label5";
            // 
            // displayFPS
            // 
            this.displayFPS.AutoSize = true;
            this.displayFPS.Location = new System.Drawing.Point(77, 86);
            this.displayFPS.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.displayFPS.Name = "displayFPS";
            this.displayFPS.Size = new System.Drawing.Size(70, 25);
            this.displayFPS.TabIndex = 16;
            this.displayFPS.Text = "label3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "FPS:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(717, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Hand Count:";
            // 
            // displayHandCount
            // 
            this.displayHandCount.AutoSize = true;
            this.displayHandCount.Location = new System.Drawing.Point(861, 86);
            this.displayHandCount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.displayHandCount.Name = "displayHandCount";
            this.displayHandCount.Size = new System.Drawing.Size(132, 25);
            this.displayHandCount.TabIndex = 19;
            this.displayHandCount.Text = "Hand Count:";
            // 
            // displayImages
            // 
            this.displayImages.Location = new System.Drawing.Point(9, 126);
            this.displayImages.Margin = new System.Windows.Forms.Padding(6);
            this.displayImages.Name = "displayImages";
            this.displayImages.Size = new System.Drawing.Size(984, 682);
            this.displayImages.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.displayImages.TabIndex = 6;
            this.displayImages.TabStop = false;
            // 
            // FrameDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(2021, 1291);
            this.Controls.Add(this.Diagnostic);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(1024, 1300);
            this.Name = "FrameDataForm";
            this.Text = " ";
            this.Diagnostic.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayImages)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Label ConnectionUSB;
        private Label label3;
        private Label label15;
        private Label Doigt1;
        private Label label18;
        private Label Doigt2;
        private Label Doigt3;
        private Label Doigt4;
        private Label Doigt5;
        private Label label24;
        private Label label25;
        private Label label26;
        private Label label27;
        private Label label28;
        private Label Led1;
        private Label Led2;
        private Label Led3;
        private Label Led4;
        private Label Led5;
        private TabControl Diagnostic;
        private TabPage tabPage1;
        private Label Confidence;
        private Label label17;
        private Label FailureReason;
        private Label Lightning;
        private Label label6;
        private Label Failure;
        private Label Clean;
        private Label label4;
        private TabPage tabPage2;
        private Label displayFPS;
        private Label label1;
        private Label label2;
        private Label displayHandCount;
        private PictureBox displayImages;
        private Label lenght5;
        private Label lenght4;
        private Label lenght3;
        private Label lenght2;
        private Label lenght1;
        private Label label16;
        private Label label22;
        private Label label21;
        private Label label20;
        private Label Position8;
        private Label Position7;
        private Label Position6;
        private Label Position5;
        private Label Position4;
        private Label Position3;
        private Label Position2;
        private Label Position1;
        private Label label23;
        private Label Min5;
        private Label Min4;
        private Label Min3;
        private Label Min2;
        private Label Min1;
        private Label label29;
        private Label Position14;
        private Label Position15;
        private Label Position16;
        private Label Position11;
        private Label Position10;
        private Label Position12;
        private Label Position13;
        private Label Position9;
        private Label label8;
        private Label Roll;
        private Label Yaw;
        private Label Pitch;
        private Label label9;
        private Label Finger2yLabel;
        private Label Finger2xLabel;
        private Label label7;
        private Label label5;
        private Label Min6;
        private Label Min7;
        private Label Min8;
        private Label Min9;
        private Label Min10;
        private Label lenght6;
        private Label lenght7;
        private Label lenght8;
        private Label lenght9;
        private Label lenght10;
        private Label Led6;
        private Label Led7;
        private Label Led8;
        private Label Led9;
        private Label Led10;
        private Label label49;
        private Label label50;
        private Label label51;
        private Label label52;
        private Label label53;
        private Label Doigt6;
        private Label Doigt7;
        private Label Doigt8;
        private Label Doigt9;
        private Label label58;
        private Label Doigt10;
    }
}