using System.Drawing;
using System.Windows.Forms;
using VisualStudioTabControl;

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
            this.visualStudioTabControl1 = new VisualStudioTabControl.VisualStudioTabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Position1 = new System.Windows.Forms.Label();
            this.Position2 = new System.Windows.Forms.Label();
            this.Position3 = new System.Windows.Forms.Label();
            this.Position4 = new System.Windows.Forms.Label();
            this.Position5 = new System.Windows.Forms.Label();
            this.Position6 = new System.Windows.Forms.Label();
            this.Position7 = new System.Windows.Forms.Label();
            this.Position8 = new System.Windows.Forms.Label();
            this.Position13 = new System.Windows.Forms.Label();
            this.Position16 = new System.Windows.Forms.Label();
            this.Position9 = new System.Windows.Forms.Label();
            this.Position14 = new System.Windows.Forms.Label();
            this.Position12 = new System.Windows.Forms.Label();
            this.Position10 = new System.Windows.Forms.Label();
            this.Position11 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.FakeLed10 = new System.Windows.Forms.Label();
            this.FakeLed9 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.FakeLed8 = new System.Windows.Forms.Label();
            this.lenght5 = new System.Windows.Forms.Label();
            this.FakeLed7 = new System.Windows.Forms.Label();
            this.FakeLed6 = new System.Windows.Forms.Label();
            this.FakeLed5 = new System.Windows.Forms.Label();
            this.FakeLed4 = new System.Windows.Forms.Label();
            this.FakeLed3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.FakeLed2 = new System.Windows.Forms.Label();
            this.FakeLed1 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.lenght10 = new System.Windows.Forms.Label();
            this.lenght9 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.lenght6 = new System.Windows.Forms.Label();
            this.lenght8 = new System.Windows.Forms.Label();
            this.lenght7 = new System.Windows.Forms.Label();
            this.lenght4 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lenght3 = new System.Windows.Forms.Label();
            this.lenght2 = new System.Windows.Forms.Label();
            this.lenght1 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Slider = new System.Windows.Forms.TrackBar();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label29 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.FailureReason = new System.Windows.Forms.Label();
            this.Lightning = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Failure = new System.Windows.Forms.Label();
            this.Clean = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ConnectionUSB = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.displayHandCount = new System.Windows.Forms.Label();
            this.displayFPS = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Doigt8 = new System.Windows.Forms.Label();
            this.Doigt6 = new System.Windows.Forms.Label();
            this.Doigt1 = new System.Windows.Forms.Label();
            this.Doigt2 = new System.Windows.Forms.Label();
            this.Doigt7 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.Doigt3 = new System.Windows.Forms.Label();
            this.Doigt4 = new System.Windows.Forms.Label();
            this.Doigt9 = new System.Windows.Forms.Label();
            this.Doigt10 = new System.Windows.Forms.Label();
            this.Doigt5 = new System.Windows.Forms.Label();
            this.Led4 = new System.Windows.Forms.Label();
            this.Led3 = new System.Windows.Forms.Label();
            this.Led2 = new System.Windows.Forms.Label();
            this.Led1 = new System.Windows.Forms.Label();
            this.Led6 = new System.Windows.Forms.Label();
            this.Led7 = new System.Windows.Forms.Label();
            this.Led8 = new System.Windows.Forms.Label();
            this.Led9 = new System.Windows.Forms.Label();
            this.Led10 = new System.Windows.Forms.Label();
            this.Led5 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.visualStudioTabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Slider)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // visualStudioTabControl1
            // 
            this.visualStudioTabControl1.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.visualStudioTabControl1.AllowDrop = true;
            this.visualStudioTabControl1.BackTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.visualStudioTabControl1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.visualStudioTabControl1.ClosingButtonColor = System.Drawing.Color.WhiteSmoke;
            this.visualStudioTabControl1.ClosingMessage = null;
            this.visualStudioTabControl1.Controls.Add(this.tabPage4);
            this.visualStudioTabControl1.Controls.Add(this.tabPage3);
            this.visualStudioTabControl1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.visualStudioTabControl1.HorizontalLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.visualStudioTabControl1.ItemSize = new System.Drawing.Size(240, 16);
            this.visualStudioTabControl1.Location = new System.Drawing.Point(1, 0);
            this.visualStudioTabControl1.Name = "visualStudioTabControl1";
            this.visualStudioTabControl1.SelectedIndex = 0;
            this.visualStudioTabControl1.SelectedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.visualStudioTabControl1.ShowClosingButton = false;
            this.visualStudioTabControl1.ShowClosingMessage = false;
            this.visualStudioTabControl1.Size = new System.Drawing.Size(2337, 822);
            this.visualStudioTabControl1.TabIndex = 72;
            this.visualStudioTabControl1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.tabPage4.Controls.Add(this.tableLayoutPanel2);
            this.tabPage4.Controls.Add(this.tableLayoutPanel1);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.Slider);
            this.tabPage4.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage4.Location = new System.Drawing.Point(4, 20);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(2329, 798);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Main";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 17;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.label13, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label12, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Position1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Position2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.Position3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.Position4, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.Position5, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.Position6, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.Position7, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.Position8, 7, 0);
            this.tableLayoutPanel2.Controls.Add(this.Position13, 12, 0);
            this.tableLayoutPanel2.Controls.Add(this.Position16, 14, 0);
            this.tableLayoutPanel2.Controls.Add(this.Position9, 8, 0);
            this.tableLayoutPanel2.Controls.Add(this.Position14, 13, 0);
            this.tableLayoutPanel2.Controls.Add(this.Position12, 11, 0);
            this.tableLayoutPanel2.Controls.Add(this.Position10, 9, 0);
            this.tableLayoutPanel2.Controls.Add(this.Position11, 10, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(170, 637);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1865, 89);
            this.tableLayoutPanel2.TabIndex = 139;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Silver;
            this.label13.Location = new System.Drawing.Point(214, 0);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.MinimumSize = new System.Drawing.Size(92, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 35);
            this.label13.TabIndex = 103;
            this.label13.UseCompatibleTextRendering = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Silver;
            this.label12.Location = new System.Drawing.Point(110, 0);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.MinimumSize = new System.Drawing.Size(92, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 35);
            this.label12.TabIndex = 102;
            this.label12.UseCompatibleTextRendering = true;
            // 
            // Position1
            // 
            this.Position1.AutoSize = true;
            this.Position1.BackColor = System.Drawing.Color.Silver;
            this.Position1.Location = new System.Drawing.Point(6, 0);
            this.Position1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Position1.MinimumSize = new System.Drawing.Size(92, 10);
            this.Position1.Name = "Position1";
            this.Position1.Size = new System.Drawing.Size(92, 35);
            this.Position1.TabIndex = 78;
            this.Position1.UseCompatibleTextRendering = true;
            // 
            // Position2
            // 
            this.Position2.AutoSize = true;
            this.Position2.BackColor = System.Drawing.Color.Silver;
            this.Position2.Location = new System.Drawing.Point(318, 0);
            this.Position2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Position2.MinimumSize = new System.Drawing.Size(92, 10);
            this.Position2.Name = "Position2";
            this.Position2.Size = new System.Drawing.Size(92, 35);
            this.Position2.TabIndex = 79;
            this.Position2.UseCompatibleTextRendering = true;
            // 
            // Position3
            // 
            this.Position3.AutoSize = true;
            this.Position3.BackColor = System.Drawing.Color.Silver;
            this.Position3.Location = new System.Drawing.Point(422, 0);
            this.Position3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Position3.MinimumSize = new System.Drawing.Size(92, 10);
            this.Position3.Name = "Position3";
            this.Position3.Size = new System.Drawing.Size(92, 35);
            this.Position3.TabIndex = 80;
            this.Position3.UseCompatibleTextRendering = true;
            // 
            // Position4
            // 
            this.Position4.AutoSize = true;
            this.Position4.BackColor = System.Drawing.Color.Silver;
            this.Position4.Location = new System.Drawing.Point(526, 0);
            this.Position4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Position4.MinimumSize = new System.Drawing.Size(92, 10);
            this.Position4.Name = "Position4";
            this.Position4.Size = new System.Drawing.Size(92, 35);
            this.Position4.TabIndex = 81;
            this.Position4.UseCompatibleTextRendering = true;
            // 
            // Position5
            // 
            this.Position5.AutoSize = true;
            this.Position5.BackColor = System.Drawing.Color.Silver;
            this.Position5.Location = new System.Drawing.Point(630, 0);
            this.Position5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Position5.MinimumSize = new System.Drawing.Size(92, 10);
            this.Position5.Name = "Position5";
            this.Position5.Size = new System.Drawing.Size(92, 35);
            this.Position5.TabIndex = 82;
            this.Position5.UseCompatibleTextRendering = true;
            // 
            // Position6
            // 
            this.Position6.AutoSize = true;
            this.Position6.BackColor = System.Drawing.Color.Silver;
            this.Position6.Location = new System.Drawing.Point(734, 0);
            this.Position6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Position6.MinimumSize = new System.Drawing.Size(92, 10);
            this.Position6.Name = "Position6";
            this.Position6.Size = new System.Drawing.Size(92, 35);
            this.Position6.TabIndex = 83;
            this.Position6.UseCompatibleTextRendering = true;
            // 
            // Position7
            // 
            this.Position7.AutoSize = true;
            this.Position7.BackColor = System.Drawing.Color.Silver;
            this.Position7.Location = new System.Drawing.Point(838, 0);
            this.Position7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Position7.MinimumSize = new System.Drawing.Size(92, 10);
            this.Position7.Name = "Position7";
            this.Position7.Size = new System.Drawing.Size(92, 35);
            this.Position7.TabIndex = 84;
            this.Position7.UseCompatibleTextRendering = true;
            // 
            // Position8
            // 
            this.Position8.AutoSize = true;
            this.Position8.BackColor = System.Drawing.Color.Silver;
            this.Position8.Location = new System.Drawing.Point(942, 0);
            this.Position8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Position8.MinimumSize = new System.Drawing.Size(92, 10);
            this.Position8.Name = "Position8";
            this.Position8.Size = new System.Drawing.Size(92, 35);
            this.Position8.TabIndex = 85;
            this.Position8.UseCompatibleTextRendering = true;
            // 
            // Position13
            // 
            this.Position13.AutoSize = true;
            this.Position13.BackColor = System.Drawing.Color.Silver;
            this.Position13.Location = new System.Drawing.Point(1462, 0);
            this.Position13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Position13.MinimumSize = new System.Drawing.Size(92, 10);
            this.Position13.Name = "Position13";
            this.Position13.Size = new System.Drawing.Size(92, 35);
            this.Position13.TabIndex = 95;
            this.Position13.UseCompatibleTextRendering = true;
            // 
            // Position16
            // 
            this.Position16.AutoSize = true;
            this.Position16.BackColor = System.Drawing.Color.Silver;
            this.Position16.Location = new System.Drawing.Point(1670, 0);
            this.Position16.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Position16.MinimumSize = new System.Drawing.Size(92, 10);
            this.Position16.Name = "Position16";
            this.Position16.Size = new System.Drawing.Size(92, 35);
            this.Position16.TabIndex = 100;
            this.Position16.UseCompatibleTextRendering = true;
            // 
            // Position9
            // 
            this.Position9.AutoSize = true;
            this.Position9.BackColor = System.Drawing.Color.Silver;
            this.Position9.Location = new System.Drawing.Point(1046, 0);
            this.Position9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Position9.MinimumSize = new System.Drawing.Size(92, 10);
            this.Position9.Name = "Position9";
            this.Position9.Size = new System.Drawing.Size(92, 35);
            this.Position9.TabIndex = 94;
            this.Position9.UseCompatibleTextRendering = true;
            // 
            // Position14
            // 
            this.Position14.AutoSize = true;
            this.Position14.BackColor = System.Drawing.Color.Silver;
            this.Position14.Location = new System.Drawing.Point(1566, 0);
            this.Position14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Position14.MinimumSize = new System.Drawing.Size(92, 10);
            this.Position14.Name = "Position14";
            this.Position14.Size = new System.Drawing.Size(92, 35);
            this.Position14.TabIndex = 101;
            this.Position14.UseCompatibleTextRendering = true;
            // 
            // Position12
            // 
            this.Position12.AutoSize = true;
            this.Position12.BackColor = System.Drawing.Color.Silver;
            this.Position12.Location = new System.Drawing.Point(1358, 0);
            this.Position12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Position12.MinimumSize = new System.Drawing.Size(92, 10);
            this.Position12.Name = "Position12";
            this.Position12.Size = new System.Drawing.Size(92, 35);
            this.Position12.TabIndex = 96;
            this.Position12.UseCompatibleTextRendering = true;
            // 
            // Position10
            // 
            this.Position10.AutoSize = true;
            this.Position10.BackColor = System.Drawing.Color.Silver;
            this.Position10.Location = new System.Drawing.Point(1150, 0);
            this.Position10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Position10.MinimumSize = new System.Drawing.Size(92, 10);
            this.Position10.Name = "Position10";
            this.Position10.Size = new System.Drawing.Size(92, 35);
            this.Position10.TabIndex = 97;
            this.Position10.UseCompatibleTextRendering = true;
            // 
            // Position11
            // 
            this.Position11.AutoSize = true;
            this.Position11.BackColor = System.Drawing.Color.Silver;
            this.Position11.Location = new System.Drawing.Point(1254, 0);
            this.Position11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Position11.MinimumSize = new System.Drawing.Size(92, 10);
            this.Position11.Name = "Position11";
            this.Position11.Size = new System.Drawing.Size(92, 35);
            this.Position11.TabIndex = 98;
            this.Position11.UseCompatibleTextRendering = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 11;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 323F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.999102F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0001F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0001F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0001F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0001F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0001F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0001F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0001F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0001F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0001F));
            this.tableLayoutPanel1.Controls.Add(this.FakeLed10, 10, 5);
            this.tableLayoutPanel1.Controls.Add(this.FakeLed9, 9, 5);
            this.tableLayoutPanel1.Controls.Add(this.label15, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label14, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.FakeLed8, 8, 5);
            this.tableLayoutPanel1.Controls.Add(this.lenght5, 10, 4);
            this.tableLayoutPanel1.Controls.Add(this.FakeLed7, 7, 5);
            this.tableLayoutPanel1.Controls.Add(this.FakeLed6, 6, 5);
            this.tableLayoutPanel1.Controls.Add(this.FakeLed5, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.Doigt5, 10, 3);
            this.tableLayoutPanel1.Controls.Add(this.Led5, 10, 2);
            this.tableLayoutPanel1.Controls.Add(this.FakeLed4, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.FakeLed3, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.label11, 9, 1);
            this.tableLayoutPanel1.Controls.Add(this.FakeLed2, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.Doigt10, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.Led10, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.FakeLed1, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label53, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label52, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.Led9, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.Doigt9, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.lenght10, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lenght9, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label51, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label50, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label49, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.label24, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.label25, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.label26, 8, 1);
            this.tableLayoutPanel1.Controls.Add(this.Led8, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.Led7, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.Led6, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.lenght6, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.lenght8, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.lenght7, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.Led1, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.Led2, 7, 2);
            this.tableLayoutPanel1.Controls.Add(this.Led3, 8, 2);
            this.tableLayoutPanel1.Controls.Add(this.Led4, 9, 2);
            this.tableLayoutPanel1.Controls.Add(this.Doigt4, 9, 3);
            this.tableLayoutPanel1.Controls.Add(this.lenght4, 9, 4);
            this.tableLayoutPanel1.Controls.Add(this.label22, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Doigt3, 8, 3);
            this.tableLayoutPanel1.Controls.Add(this.label20, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lenght3, 8, 4);
            this.tableLayoutPanel1.Controls.Add(this.Doigt7, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.Doigt2, 7, 3);
            this.tableLayoutPanel1.Controls.Add(this.lenght2, 7, 4);
            this.tableLayoutPanel1.Controls.Add(this.Doigt1, 6, 3);
            this.tableLayoutPanel1.Controls.Add(this.Doigt6, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.lenght1, 6, 4);
            this.tableLayoutPanel1.Controls.Add(this.Doigt8, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label27, 10, 1);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(2161, 229);
            this.tableLayoutPanel1.TabIndex = 138;
            // 
            // FakeLed10
            // 
            this.FakeLed10.AutoSize = true;
            this.FakeLed10.BackColor = System.Drawing.Color.Red;
            this.FakeLed10.Location = new System.Drawing.Point(1976, 137);
            this.FakeLed10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.FakeLed10.MinimumSize = new System.Drawing.Size(92, 10);
            this.FakeLed10.Name = "FakeLed10";
            this.FakeLed10.Size = new System.Drawing.Size(92, 32);
            this.FakeLed10.TabIndex = 149;
            this.FakeLed10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FakeLed9
            // 
            this.FakeLed9.AutoSize = true;
            this.FakeLed9.BackColor = System.Drawing.Color.Red;
            this.FakeLed9.Location = new System.Drawing.Point(1793, 137);
            this.FakeLed9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.FakeLed9.MinimumSize = new System.Drawing.Size(92, 10);
            this.FakeLed9.Name = "FakeLed9";
            this.FakeLed9.Size = new System.Drawing.Size(92, 32);
            this.FakeLed9.TabIndex = 150;
            this.FakeLed9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label15.Location = new System.Drawing.Point(6, 137);
            this.label15.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(117, 32);
            this.label15.TabIndex = 140;
            this.label15.Text = "Fake LED";
            // 
            // FakeLed8
            // 
            this.FakeLed8.AutoSize = true;
            this.FakeLed8.BackColor = System.Drawing.Color.Red;
            this.FakeLed8.Location = new System.Drawing.Point(1610, 137);
            this.FakeLed8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.FakeLed8.MinimumSize = new System.Drawing.Size(92, 10);
            this.FakeLed8.Name = "FakeLed8";
            this.FakeLed8.Size = new System.Drawing.Size(92, 32);
            this.FakeLed8.TabIndex = 148;
            this.FakeLed8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lenght5
            // 
            this.lenght5.AutoSize = true;
            this.lenght5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lenght5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lenght5.Location = new System.Drawing.Point(1976, 98);
            this.lenght5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lenght5.Name = "lenght5";
            this.lenght5.Size = new System.Drawing.Size(129, 39);
            this.lenght5.TabIndex = 139;
            this.lenght5.Text = "lenght5";
            this.lenght5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FakeLed7
            // 
            this.FakeLed7.AutoSize = true;
            this.FakeLed7.BackColor = System.Drawing.Color.Red;
            this.FakeLed7.Location = new System.Drawing.Point(1427, 137);
            this.FakeLed7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.FakeLed7.MinimumSize = new System.Drawing.Size(92, 10);
            this.FakeLed7.Name = "FakeLed7";
            this.FakeLed7.Size = new System.Drawing.Size(92, 32);
            this.FakeLed7.TabIndex = 147;
            this.FakeLed7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FakeLed6
            // 
            this.FakeLed6.AutoSize = true;
            this.FakeLed6.BackColor = System.Drawing.Color.Red;
            this.FakeLed6.Location = new System.Drawing.Point(1244, 137);
            this.FakeLed6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.FakeLed6.MinimumSize = new System.Drawing.Size(92, 10);
            this.FakeLed6.Name = "FakeLed6";
            this.FakeLed6.Size = new System.Drawing.Size(92, 32);
            this.FakeLed6.TabIndex = 145;
            this.FakeLed6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FakeLed5
            // 
            this.FakeLed5.AutoSize = true;
            this.FakeLed5.BackColor = System.Drawing.Color.Red;
            this.FakeLed5.Location = new System.Drawing.Point(1061, 137);
            this.FakeLed5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.FakeLed5.MinimumSize = new System.Drawing.Size(92, 10);
            this.FakeLed5.Name = "FakeLed5";
            this.FakeLed5.Size = new System.Drawing.Size(92, 32);
            this.FakeLed5.TabIndex = 146;
            this.FakeLed5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FakeLed4
            // 
            this.FakeLed4.AutoSize = true;
            this.FakeLed4.BackColor = System.Drawing.Color.Red;
            this.FakeLed4.Location = new System.Drawing.Point(878, 137);
            this.FakeLed4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.FakeLed4.MinimumSize = new System.Drawing.Size(92, 10);
            this.FakeLed4.Name = "FakeLed4";
            this.FakeLed4.Size = new System.Drawing.Size(92, 32);
            this.FakeLed4.TabIndex = 142;
            this.FakeLed4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FakeLed3
            // 
            this.FakeLed3.AutoSize = true;
            this.FakeLed3.BackColor = System.Drawing.Color.Red;
            this.FakeLed3.Location = new System.Drawing.Point(695, 137);
            this.FakeLed3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.FakeLed3.MinimumSize = new System.Drawing.Size(92, 10);
            this.FakeLed3.Name = "FakeLed3";
            this.FakeLed3.Size = new System.Drawing.Size(92, 32);
            this.FakeLed3.TabIndex = 144;
            this.FakeLed3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Turquoise;
            this.label11.Location = new System.Drawing.Point(1793, 0);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 28);
            this.label11.TabIndex = 139;
            this.label11.Text = "AnnuaireD";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FakeLed2
            // 
            this.FakeLed2.AutoSize = true;
            this.FakeLed2.BackColor = System.Drawing.Color.Red;
            this.FakeLed2.Location = new System.Drawing.Point(512, 137);
            this.FakeLed2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.FakeLed2.MinimumSize = new System.Drawing.Size(92, 10);
            this.FakeLed2.Name = "FakeLed2";
            this.FakeLed2.Size = new System.Drawing.Size(92, 32);
            this.FakeLed2.TabIndex = 143;
            this.FakeLed2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FakeLed1
            // 
            this.FakeLed1.AutoSize = true;
            this.FakeLed1.BackColor = System.Drawing.Color.Red;
            this.FakeLed1.Location = new System.Drawing.Point(329, 137);
            this.FakeLed1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.FakeLed1.MinimumSize = new System.Drawing.Size(92, 10);
            this.FakeLed1.Name = "FakeLed1";
            this.FakeLed1.Size = new System.Drawing.Size(92, 32);
            this.FakeLed1.TabIndex = 141;
            this.FakeLed1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Font = new System.Drawing.Font("Segoe UI", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label53.ForeColor = System.Drawing.Color.Turquoise;
            this.label53.Location = new System.Drawing.Point(329, 0);
            this.label53.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(119, 28);
            this.label53.TabIndex = 108;
            this.label53.Text = "AuriculaireG";
            this.label53.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("Segoe UI", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.ForeColor = System.Drawing.Color.Turquoise;
            this.label52.Location = new System.Drawing.Point(512, 0);
            this.label52.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(104, 28);
            this.label52.TabIndex = 109;
            this.label52.Text = "AnnuaireG";
            this.label52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lenght10
            // 
            this.lenght10.AutoSize = true;
            this.lenght10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lenght10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lenght10.Location = new System.Drawing.Point(329, 98);
            this.lenght10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lenght10.Name = "lenght10";
            this.lenght10.Size = new System.Drawing.Size(148, 39);
            this.lenght10.TabIndex = 118;
            this.lenght10.Text = "lenght10";
            this.lenght10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lenght9
            // 
            this.lenght9.AutoSize = true;
            this.lenght9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lenght9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lenght9.Location = new System.Drawing.Point(512, 98);
            this.lenght9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lenght9.Name = "lenght9";
            this.lenght9.Size = new System.Drawing.Size(129, 39);
            this.lenght9.TabIndex = 119;
            this.lenght9.Text = "lenght9";
            this.lenght9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("Segoe UI", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label51.ForeColor = System.Drawing.Color.Turquoise;
            this.label51.Location = new System.Drawing.Point(695, 0);
            this.label51.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(87, 28);
            this.label51.TabIndex = 110;
            this.label51.Text = "MajeurG";
            this.label51.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Segoe UI", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.ForeColor = System.Drawing.Color.Turquoise;
            this.label50.Location = new System.Drawing.Point(878, 0);
            this.label50.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(73, 28);
            this.label50.TabIndex = 111;
            this.label50.Text = "IndexG";
            this.label50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Segoe UI", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.ForeColor = System.Drawing.Color.Turquoise;
            this.label49.Location = new System.Drawing.Point(1061, 0);
            this.label49.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(78, 28);
            this.label49.TabIndex = 112;
            this.label49.Text = "PouceG";
            this.label49.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Turquoise;
            this.label24.Location = new System.Drawing.Point(1244, 0);
            this.label24.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(78, 28);
            this.label24.TabIndex = 45;
            this.label24.Text = "PouceD";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.Turquoise;
            this.label25.Location = new System.Drawing.Point(1427, 0);
            this.label25.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(73, 28);
            this.label25.TabIndex = 46;
            this.label25.Text = "IndexD";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Turquoise;
            this.label26.Location = new System.Drawing.Point(1610, 0);
            this.label26.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(87, 28);
            this.label26.TabIndex = 47;
            this.label26.Text = "MajeurD";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lenght6
            // 
            this.lenght6.AutoSize = true;
            this.lenght6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lenght6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lenght6.Location = new System.Drawing.Point(1061, 98);
            this.lenght6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lenght6.Name = "lenght6";
            this.lenght6.Size = new System.Drawing.Size(129, 39);
            this.lenght6.TabIndex = 122;
            this.lenght6.Text = "lenght6";
            this.lenght6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lenght8
            // 
            this.lenght8.AutoSize = true;
            this.lenght8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lenght8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lenght8.Location = new System.Drawing.Point(695, 98);
            this.lenght8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lenght8.Name = "lenght8";
            this.lenght8.Size = new System.Drawing.Size(129, 39);
            this.lenght8.TabIndex = 120;
            this.lenght8.Text = "lenght8";
            this.lenght8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lenght7
            // 
            this.lenght7.AutoSize = true;
            this.lenght7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lenght7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lenght7.Location = new System.Drawing.Point(878, 98);
            this.lenght7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lenght7.Name = "lenght7";
            this.lenght7.Size = new System.Drawing.Size(129, 39);
            this.lenght7.TabIndex = 121;
            this.lenght7.Text = "lenght7";
            this.lenght7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lenght4
            // 
            this.lenght4.AutoSize = true;
            this.lenght4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lenght4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lenght4.Location = new System.Drawing.Point(1793, 98);
            this.lenght4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lenght4.Name = "lenght4";
            this.lenght4.Size = new System.Drawing.Size(129, 39);
            this.lenght4.TabIndex = 66;
            this.lenght4.Text = "lenght4";
            this.lenght4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label22.Location = new System.Drawing.Point(6, 98);
            this.label22.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(170, 32);
            this.label22.TabIndex = 77;
            this.label22.Text = "Length Lissée:";
            // 
            // lenght3
            // 
            this.lenght3.AutoSize = true;
            this.lenght3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lenght3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lenght3.Location = new System.Drawing.Point(1610, 98);
            this.lenght3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lenght3.Name = "lenght3";
            this.lenght3.Size = new System.Drawing.Size(129, 39);
            this.lenght3.TabIndex = 65;
            this.lenght3.Text = "lenght3";
            this.lenght3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lenght2
            // 
            this.lenght2.AutoSize = true;
            this.lenght2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lenght2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lenght2.Location = new System.Drawing.Point(1427, 98);
            this.lenght2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lenght2.Name = "lenght2";
            this.lenght2.Size = new System.Drawing.Size(129, 39);
            this.lenght2.TabIndex = 64;
            this.lenght2.Text = "lenght2";
            this.lenght2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lenght1
            // 
            this.lenght1.AutoSize = true;
            this.lenght1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lenght1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lenght1.Location = new System.Drawing.Point(1244, 98);
            this.lenght1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lenght1.Name = "lenght1";
            this.lenght1.Size = new System.Drawing.Size(129, 39);
            this.lenght1.TabIndex = 63;
            this.lenght1.Text = "lenght1";
            this.lenght1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Segoe UI", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.Turquoise;
            this.label27.Location = new System.Drawing.Point(1976, 0);
            this.label27.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(119, 28);
            this.label27.TabIndex = 48;
            this.label27.Text = "AuriculaireD";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(519, 450);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 32);
            this.label9.TabIndex = 136;
            this.label9.Text = "+30%";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(237, 450);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 32);
            this.label8.TabIndex = 135;
            this.label8.Text = "+0%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label5.Location = new System.Drawing.Point(21, 422);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 32);
            this.label5.TabIndex = 133;
            this.label5.Text = "Sensibility:";
            // 
            // Slider
            // 
            this.Slider.Cursor = System.Windows.Forms.Cursors.Default;
            this.Slider.LargeChange = 50;
            this.Slider.Location = new System.Drawing.Point(231, 402);
            this.Slider.Maximum = 30;
            this.Slider.Name = "Slider";
            this.Slider.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Slider.Size = new System.Drawing.Size(366, 80);
            this.Slider.SmallChange = 3;
            this.Slider.TabIndex = 10;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.label29);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.FailureReason);
            this.tabPage3.Controls.Add(this.Lightning);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.Failure);
            this.tabPage3.Controls.Add(this.Clean);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.ConnectionUSB);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.displayHandCount);
            this.tabPage3.Controls.Add(this.displayFPS);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabPage3.Location = new System.Drawing.Point(4, 20);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(2329, 798);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Rendu";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.button1.Location = new System.Drawing.Point(33, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(333, 41);
            this.button1.TabIndex = 104;
            this.button1.Text = "Restart LeapMotion Service";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label29.Location = new System.Drawing.Point(28, 30);
            this.label29.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(165, 25);
            this.label29.TabIndex = 103;
            this.label29.Text = "Timer Heart Beat:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(248, 29);
            this.label16.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label16.MinimumSize = new System.Drawing.Size(92, 10);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 25);
            this.label16.TabIndex = 102;
            // 
            // FailureReason
            // 
            this.FailureReason.AutoSize = true;
            this.FailureReason.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FailureReason.Location = new System.Drawing.Point(248, 251);
            this.FailureReason.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.FailureReason.Name = "FailureReason";
            this.FailureReason.Size = new System.Drawing.Size(101, 25);
            this.FailureReason.TabIndex = 101;
            this.FailureReason.Text = "No Failure";
            // 
            // Lightning
            // 
            this.Lightning.AutoSize = true;
            this.Lightning.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lightning.Location = new System.Drawing.Point(248, 180);
            this.Lightning.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Lightning.MinimumSize = new System.Drawing.Size(92, 24);
            this.Lightning.Name = "Lightning";
            this.Lightning.Size = new System.Drawing.Size(107, 25);
            this.Lightning.TabIndex = 100;
            this.Lightning.Text = "Lightning ?";
            this.Lightning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(28, 180);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 25);
            this.label6.TabIndex = 99;
            this.label6.Text = "Lightning";
            // 
            // Failure
            // 
            this.Failure.AutoSize = true;
            this.Failure.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Failure.Location = new System.Drawing.Point(32, 241);
            this.Failure.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Failure.Name = "Failure";
            this.Failure.Size = new System.Drawing.Size(149, 25);
            this.Failure.TabIndex = 98;
            this.Failure.Text = "Failure Reason:";
            // 
            // Clean
            // 
            this.Clean.AutoSize = true;
            this.Clean.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Clean.Location = new System.Drawing.Point(248, 115);
            this.Clean.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Clean.MinimumSize = new System.Drawing.Size(92, 24);
            this.Clean.Name = "Clean";
            this.Clean.Size = new System.Drawing.Size(113, 25);
            this.Clean.TabIndex = 97;
            this.Clean.Text = "Clean ????";
            this.Clean.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(32, 115);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 25);
            this.label4.TabIndex = 96;
            this.label4.Text = "State";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(32, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 95;
            this.label3.Text = "Connected:";
            // 
            // ConnectionUSB
            // 
            this.ConnectionUSB.AutoSize = true;
            this.ConnectionUSB.BackColor = System.Drawing.Color.Red;
            this.ConnectionUSB.Location = new System.Drawing.Point(248, 73);
            this.ConnectionUSB.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ConnectionUSB.MinimumSize = new System.Drawing.Size(92, 10);
            this.ConnectionUSB.Name = "ConnectionUSB";
            this.ConnectionUSB.Size = new System.Drawing.Size(92, 25);
            this.ConnectionUSB.TabIndex = 94;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(1326, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Hand Count:";
            // 
            // displayHandCount
            // 
            this.displayHandCount.AutoSize = true;
            this.displayHandCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.displayHandCount.Location = new System.Drawing.Point(1448, 3);
            this.displayHandCount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.displayHandCount.Name = "displayHandCount";
            this.displayHandCount.Size = new System.Drawing.Size(123, 25);
            this.displayHandCount.TabIndex = 19;
            this.displayHandCount.Text = "Hand Count:";
            // 
            // displayFPS
            // 
            this.displayFPS.AutoSize = true;
            this.displayFPS.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.displayFPS.Location = new System.Drawing.Point(845, 3);
            this.displayFPS.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.displayFPS.Name = "displayFPS";
            this.displayFPS.Size = new System.Drawing.Size(64, 25);
            this.displayFPS.TabIndex = 16;
            this.displayFPS.Text = "label3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(788, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "FPS:";
            // 
            // Doigt8
            // 
            this.Doigt8.AutoSize = true;
            this.Doigt8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Doigt8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Doigt8.Location = new System.Drawing.Point(695, 60);
            this.Doigt8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Doigt8.Name = "Doigt8";
            this.Doigt8.Size = new System.Drawing.Size(111, 38);
            this.Doigt8.TabIndex = 105;
            this.Doigt8.Text = "Doigt8";
            this.Doigt8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Doigt6
            // 
            this.Doigt6.AutoSize = true;
            this.Doigt6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Doigt6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Doigt6.Location = new System.Drawing.Point(1061, 60);
            this.Doigt6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Doigt6.Name = "Doigt6";
            this.Doigt6.Size = new System.Drawing.Size(111, 38);
            this.Doigt6.TabIndex = 107;
            this.Doigt6.Text = "Doigt6";
            this.Doigt6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Doigt1
            // 
            this.Doigt1.AutoSize = true;
            this.Doigt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Doigt1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Doigt1.Location = new System.Drawing.Point(1244, 60);
            this.Doigt1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Doigt1.Name = "Doigt1";
            this.Doigt1.Size = new System.Drawing.Size(120, 38);
            this.Doigt1.TabIndex = 35;
            this.Doigt1.Text = "Doigt 1";
            this.Doigt1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Doigt2
            // 
            this.Doigt2.AutoSize = true;
            this.Doigt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Doigt2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Doigt2.Location = new System.Drawing.Point(1427, 60);
            this.Doigt2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Doigt2.Name = "Doigt2";
            this.Doigt2.Size = new System.Drawing.Size(111, 38);
            this.Doigt2.TabIndex = 41;
            this.Doigt2.Text = "Doigt2";
            this.Doigt2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Doigt7
            // 
            this.Doigt7.AutoSize = true;
            this.Doigt7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Doigt7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Doigt7.Location = new System.Drawing.Point(878, 60);
            this.Doigt7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Doigt7.Name = "Doigt7";
            this.Doigt7.Size = new System.Drawing.Size(111, 38);
            this.Doigt7.TabIndex = 106;
            this.Doigt7.Text = "Doigt7";
            this.Doigt7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI Black", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label20.Location = new System.Drawing.Point(6, 60);
            this.label20.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(227, 32);
            this.label20.TabIndex = 75;
            this.label20.Text = "Instant  Pressure :";
            // 
            // Doigt3
            // 
            this.Doigt3.AutoSize = true;
            this.Doigt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Doigt3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Doigt3.Location = new System.Drawing.Point(1610, 60);
            this.Doigt3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Doigt3.Name = "Doigt3";
            this.Doigt3.Size = new System.Drawing.Size(111, 38);
            this.Doigt3.TabIndex = 42;
            this.Doigt3.Text = "Doigt3";
            this.Doigt3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Doigt4
            // 
            this.Doigt4.AutoSize = true;
            this.Doigt4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Doigt4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Doigt4.Location = new System.Drawing.Point(1793, 60);
            this.Doigt4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Doigt4.Name = "Doigt4";
            this.Doigt4.Size = new System.Drawing.Size(111, 38);
            this.Doigt4.TabIndex = 43;
            this.Doigt4.Text = "Doigt4";
            this.Doigt4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Doigt9
            // 
            this.Doigt9.AutoSize = true;
            this.Doigt9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Doigt9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Doigt9.Location = new System.Drawing.Point(512, 60);
            this.Doigt9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Doigt9.Name = "Doigt9";
            this.Doigt9.Size = new System.Drawing.Size(111, 38);
            this.Doigt9.TabIndex = 104;
            this.Doigt9.Text = "Doigt9";
            this.Doigt9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Doigt10
            // 
            this.Doigt10.AutoSize = true;
            this.Doigt10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Doigt10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Doigt10.Location = new System.Drawing.Point(329, 60);
            this.Doigt10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Doigt10.Name = "Doigt10";
            this.Doigt10.Size = new System.Drawing.Size(129, 38);
            this.Doigt10.TabIndex = 102;
            this.Doigt10.Text = "Doigt10";
            this.Doigt10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Doigt5
            // 
            this.Doigt5.AutoSize = true;
            this.Doigt5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Doigt5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Doigt5.Location = new System.Drawing.Point(1976, 60);
            this.Doigt5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Doigt5.Name = "Doigt5";
            this.Doigt5.Size = new System.Drawing.Size(111, 38);
            this.Doigt5.TabIndex = 139;
            this.Doigt5.Text = "Doigt5";
            this.Doigt5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Led4
            // 
            this.Led4.AutoSize = true;
            this.Led4.BackColor = System.Drawing.Color.Red;
            this.Led4.Location = new System.Drawing.Point(1793, 28);
            this.Led4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Led4.MinimumSize = new System.Drawing.Size(92, 10);
            this.Led4.Name = "Led4";
            this.Led4.Size = new System.Drawing.Size(92, 32);
            this.Led4.TabIndex = 53;
            this.Led4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Led3
            // 
            this.Led3.AutoSize = true;
            this.Led3.BackColor = System.Drawing.Color.Red;
            this.Led3.Location = new System.Drawing.Point(1610, 28);
            this.Led3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Led3.MinimumSize = new System.Drawing.Size(92, 10);
            this.Led3.Name = "Led3";
            this.Led3.Size = new System.Drawing.Size(92, 32);
            this.Led3.TabIndex = 52;
            this.Led3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Led2
            // 
            this.Led2.AutoSize = true;
            this.Led2.BackColor = System.Drawing.Color.Red;
            this.Led2.Location = new System.Drawing.Point(1427, 28);
            this.Led2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Led2.MinimumSize = new System.Drawing.Size(92, 10);
            this.Led2.Name = "Led2";
            this.Led2.Size = new System.Drawing.Size(92, 32);
            this.Led2.TabIndex = 51;
            this.Led2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Led1
            // 
            this.Led1.AutoSize = true;
            this.Led1.BackColor = System.Drawing.Color.Red;
            this.Led1.Location = new System.Drawing.Point(1244, 28);
            this.Led1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Led1.MinimumSize = new System.Drawing.Size(92, 10);
            this.Led1.Name = "Led1";
            this.Led1.Size = new System.Drawing.Size(92, 32);
            this.Led1.TabIndex = 50;
            this.Led1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Led6
            // 
            this.Led6.AutoSize = true;
            this.Led6.BackColor = System.Drawing.Color.Red;
            this.Led6.Location = new System.Drawing.Point(1061, 28);
            this.Led6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Led6.MinimumSize = new System.Drawing.Size(92, 10);
            this.Led6.Name = "Led6";
            this.Led6.Size = new System.Drawing.Size(92, 32);
            this.Led6.TabIndex = 117;
            this.Led6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Led7
            // 
            this.Led7.AutoSize = true;
            this.Led7.BackColor = System.Drawing.Color.Red;
            this.Led7.Location = new System.Drawing.Point(878, 28);
            this.Led7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Led7.MinimumSize = new System.Drawing.Size(92, 10);
            this.Led7.Name = "Led7";
            this.Led7.Size = new System.Drawing.Size(92, 32);
            this.Led7.TabIndex = 116;
            this.Led7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Led8
            // 
            this.Led8.AutoSize = true;
            this.Led8.BackColor = System.Drawing.Color.Red;
            this.Led8.Location = new System.Drawing.Point(695, 28);
            this.Led8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Led8.MinimumSize = new System.Drawing.Size(92, 10);
            this.Led8.Name = "Led8";
            this.Led8.Size = new System.Drawing.Size(92, 32);
            this.Led8.TabIndex = 115;
            this.Led8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Led9
            // 
            this.Led9.AutoSize = true;
            this.Led9.BackColor = System.Drawing.Color.Red;
            this.Led9.Location = new System.Drawing.Point(512, 28);
            this.Led9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Led9.MinimumSize = new System.Drawing.Size(92, 10);
            this.Led9.Name = "Led9";
            this.Led9.Size = new System.Drawing.Size(92, 32);
            this.Led9.TabIndex = 114;
            this.Led9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Led10
            // 
            this.Led10.AutoSize = true;
            this.Led10.BackColor = System.Drawing.Color.Red;
            this.Led10.Location = new System.Drawing.Point(329, 28);
            this.Led10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Led10.MinimumSize = new System.Drawing.Size(92, 10);
            this.Led10.Name = "Led10";
            this.Led10.Size = new System.Drawing.Size(92, 32);
            this.Led10.TabIndex = 113;
            this.Led10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Led5
            // 
            this.Led5.AutoSize = true;
            this.Led5.BackColor = System.Drawing.Color.Red;
            this.Led5.Location = new System.Drawing.Point(1976, 28);
            this.Led5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Led5.MinimumSize = new System.Drawing.Size(92, 10);
            this.Led5.Name = "Led5";
            this.Led5.Size = new System.Drawing.Size(92, 32);
            this.Led5.TabIndex = 139;
            this.Led5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label14.Location = new System.Drawing.Point(6, 28);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(152, 32);
            this.label14.TabIndex = 140;
            this.label14.Text = "Seuil atteint";
            // 
            // FrameDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(2211, 824);
            this.Controls.Add(this.visualStudioTabControl1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(941, 740);
            this.Name = "FrameDataForm";
            this.Text = " ";
            this.visualStudioTabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Slider)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private VisualStudioTabControl.VisualStudioTabControl visualStudioTabControl1;
        private TabPage tabPage3;
        private Label label2;
        private Label displayHandCount;
        private Label displayFPS;
        private Label label1;
        private TabPage tabPage4;
        private Label Position1;
        private Label Position2;
        private Label Position3;
        private Label Position4;
        private Label Position5;
        private Label Position6;
        private Label lenght6;
        private Label Position7;
        private Label lenght7;
        private Label Position8;
        private Label lenght8;
        private Label Position9;
        private Label lenght9;
        private Label Position13;
        private Label lenght10;
        private Label Position12;
        private Label Position10;
        private Label Position11;
        private Label Position16;
        private Label Position14;
        private Label label49;
        private Label label50;
        private Label label51;
        private Label label52;
        private Label label53;
        private Label label24;
        private Label label25;
        private Label label26;
        private Label label27;
        private Label lenght1;
        private Label lenght2;
        private Label label22;
        private Label lenght3;
        private Label lenght4;
        private TrackBar Slider;
        private Label label5;
        private Label label7;
        private Label label9;
        private Label label8;
        private Label label10;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label11;
        private Label lenght5;
        private Label label29;
        private Label label16;
        private Label FailureReason;
        private Label Lightning;
        private Label label6;
        private Label Failure;
        private Label Clean;
        private Label label4;
        private Label label3;
        private Label ConnectionUSB;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label12;
        private Label label13;
        private Button button1;
        private Label FakeLed10;
        private Label FakeLed9;
        private Label label15;
        private Label FakeLed8;
        private Label FakeLed7;
        private Label FakeLed6;
        private Label FakeLed5;
        private Label FakeLed4;
        private Label FakeLed3;
        private Label FakeLed2;
        private Label FakeLed1;
        private Label label14;
        private Label Doigt5;
        private Label Led5;
        private Label Doigt10;
        private Label Led10;
        private Label Led9;
        private Label Doigt9;
        private Label Led8;
        private Label Led7;
        private Label Led6;
        private Label Led1;
        private Label Led2;
        private Label Led3;
        private Label Led4;
        private Label Doigt4;
        private Label Doigt3;
        private Label label20;
        private Label Doigt7;
        private Label Doigt2;
        private Label Doigt1;
        private Label Doigt6;
        private Label Doigt8;
    }
}