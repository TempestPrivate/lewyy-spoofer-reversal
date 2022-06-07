namespace KeyAuth
{
    public partial class Main : global::System.Windows.Forms.Form
    {
        protected override void Dispose(bool disposing)
        {
            bool flag = disposing && this.components != null;
            if (flag)
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Siticone.UI.AnimatorNS.Animation animation5 = new Siticone.UI.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.siticoneDragControl1 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.siticoneTransition1 = new Siticone.UI.WinForms.SiticoneTransition();
            this.label1 = new System.Windows.Forms.Label();
            this.siticoneCustomGradientPanel3 = new Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel();
            this.siticoneGradientButton3 = new Siticone.UI.WinForms.SiticoneGradientButton();
            this.siticoneGradientButton2 = new Siticone.UI.WinForms.SiticoneGradientButton();
            this.siticoneGradientButton1 = new Siticone.UI.WinForms.SiticoneGradientButton();
            this.siticoneCustomGradientPanel4 = new Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticoneControlBox2 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.label2 = new System.Windows.Forms.Label();
            this.siticonePictureBox1 = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.siticoneControlBox1 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.siticoneCustomGradientPanel5 = new Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel();
            this.siticonePictureBox5 = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.siticonePictureBox6 = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.siticonePictureBox4 = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.siticoneCustomGradientPanel6 = new Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.siticoneShadowForm = new Siticone.UI.WinForms.SiticoneShadowForm(this.components);
            this.siticoneDragControl2 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.siticonePictureBox2 = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.siticonePictureBox3 = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.siticonePictureBox7 = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.siticoneCustomGradientPanel3.SuspendLayout();
            this.siticoneCustomGradientPanel4.SuspendLayout();
            this.siticonePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).BeginInit();
            this.siticoneCustomGradientPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox4)).BeginInit();
            this.siticoneCustomGradientPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.TargetControl = this;
            // 
            // siticoneTransition1
            // 
            this.siticoneTransition1.AnimationType = Siticone.UI.AnimatorNS.AnimationType.Rotate;
            this.siticoneTransition1.Cursor = null;
            animation5.AnimateOnlyDifferences = true;
            animation5.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.BlindCoeff")));
            animation5.LeafCoeff = 0F;
            animation5.MaxTime = 1F;
            animation5.MinTime = 0F;
            animation5.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicCoeff")));
            animation5.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicShift")));
            animation5.MosaicSize = 0;
            animation5.Padding = new System.Windows.Forms.Padding(50);
            animation5.RotateCoeff = 1F;
            animation5.RotateLimit = 0F;
            animation5.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.ScaleCoeff")));
            animation5.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.SlideCoeff")));
            animation5.TimeCoeff = 0F;
            animation5.TransparencyCoeff = 1F;
            this.siticoneTransition1.DefaultAnimation = animation5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.label1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-1, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 22;
            // 
            // siticoneCustomGradientPanel3
            // 
            this.siticoneCustomGradientPanel3.BackColor = System.Drawing.Color.Transparent;
            this.siticoneCustomGradientPanel3.BorderColor = System.Drawing.Color.Black;
            this.siticoneCustomGradientPanel3.BorderRadius = 10;
            this.siticoneCustomGradientPanel3.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.siticoneCustomGradientPanel3.Controls.Add(this.siticoneGradientButton3);
            this.siticoneCustomGradientPanel3.Controls.Add(this.siticoneGradientButton2);
            this.siticoneCustomGradientPanel3.Controls.Add(this.siticoneGradientButton1);
            this.siticoneCustomGradientPanel3.Controls.Add(this.siticoneCustomGradientPanel4);
            this.siticoneTransition1.SetDecoration(this.siticoneCustomGradientPanel3, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneCustomGradientPanel3.FillColor = System.Drawing.Color.DarkGreen;
            this.siticoneCustomGradientPanel3.FillColor2 = System.Drawing.Color.DarkGreen;
            this.siticoneCustomGradientPanel3.FillColor3 = System.Drawing.Color.DarkGreen;
            this.siticoneCustomGradientPanel3.FillColor4 = System.Drawing.Color.DarkGreen;
            this.siticoneCustomGradientPanel3.Location = new System.Drawing.Point(14, 170);
            this.siticoneCustomGradientPanel3.Name = "siticoneCustomGradientPanel3";
            this.siticoneCustomGradientPanel3.ShadowDecoration.Parent = this.siticoneCustomGradientPanel3;
            this.siticoneCustomGradientPanel3.Size = new System.Drawing.Size(534, 118);
            this.siticoneCustomGradientPanel3.TabIndex = 66;
            this.siticoneCustomGradientPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.siticoneCustomGradientPanel3_Paint);
            // 
            // siticoneGradientButton3
            // 
            this.siticoneGradientButton3.BorderRadius = 5;
            this.siticoneGradientButton3.CheckedState.Parent = this.siticoneGradientButton3;
            this.siticoneGradientButton3.CustomImages.Parent = this.siticoneGradientButton3;
            this.siticoneTransition1.SetDecoration(this.siticoneGradientButton3, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneGradientButton3.FillColor = System.Drawing.Color.Lime;
            this.siticoneGradientButton3.FillColor2 = System.Drawing.Color.Lime;
            this.siticoneGradientButton3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneGradientButton3.ForeColor = System.Drawing.Color.Black;
            this.siticoneGradientButton3.HoveredState.Parent = this.siticoneGradientButton3;
            this.siticoneGradientButton3.Location = new System.Drawing.Point(365, 52);
            this.siticoneGradientButton3.Name = "siticoneGradientButton3";
            this.siticoneGradientButton3.ShadowDecoration.Parent = this.siticoneGradientButton3;
            this.siticoneGradientButton3.Size = new System.Drawing.Size(156, 42);
            this.siticoneGradientButton3.TabIndex = 52;
            this.siticoneGradientButton3.Text = "Registery Tracers";
            this.siticoneGradientButton3.Click += new System.EventHandler(this.siticoneGradientButton3_Click);
            // 
            // siticoneGradientButton2
            // 
            this.siticoneGradientButton2.BorderRadius = 5;
            this.siticoneGradientButton2.CheckedState.Parent = this.siticoneGradientButton2;
            this.siticoneGradientButton2.CustomImages.Parent = this.siticoneGradientButton2;
            this.siticoneTransition1.SetDecoration(this.siticoneGradientButton2, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneGradientButton2.FillColor = System.Drawing.Color.Lime;
            this.siticoneGradientButton2.FillColor2 = System.Drawing.Color.Lime;
            this.siticoneGradientButton2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneGradientButton2.ForeColor = System.Drawing.Color.Black;
            this.siticoneGradientButton2.HoveredState.Parent = this.siticoneGradientButton2;
            this.siticoneGradientButton2.Location = new System.Drawing.Point(193, 52);
            this.siticoneGradientButton2.Name = "siticoneGradientButton2";
            this.siticoneGradientButton2.ShadowDecoration.Parent = this.siticoneGradientButton2;
            this.siticoneGradientButton2.Size = new System.Drawing.Size(156, 42);
            this.siticoneGradientButton2.TabIndex = 51;
            this.siticoneGradientButton2.Text = "Change MAC";
            this.siticoneGradientButton2.Click += new System.EventHandler(this.siticoneGradientButton2_Click_1);
            // 
            // siticoneGradientButton1
            // 
            this.siticoneGradientButton1.BorderRadius = 5;
            this.siticoneGradientButton1.CheckedState.Parent = this.siticoneGradientButton1;
            this.siticoneGradientButton1.CustomImages.Parent = this.siticoneGradientButton1;
            this.siticoneTransition1.SetDecoration(this.siticoneGradientButton1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneGradientButton1.FillColor = System.Drawing.Color.Lime;
            this.siticoneGradientButton1.FillColor2 = System.Drawing.Color.Lime;
            this.siticoneGradientButton1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneGradientButton1.ForeColor = System.Drawing.Color.Black;
            this.siticoneGradientButton1.HoveredState.Parent = this.siticoneGradientButton1;
            this.siticoneGradientButton1.Location = new System.Drawing.Point(15, 52);
            this.siticoneGradientButton1.Name = "siticoneGradientButton1";
            this.siticoneGradientButton1.ShadowDecoration.Parent = this.siticoneGradientButton1;
            this.siticoneGradientButton1.Size = new System.Drawing.Size(156, 42);
            this.siticoneGradientButton1.TabIndex = 50;
            this.siticoneGradientButton1.Text = "Change Serials";
            this.siticoneGradientButton1.Click += new System.EventHandler(this.siticoneGradientButton1_Click);
            // 
            // siticoneCustomGradientPanel4
            // 
            this.siticoneCustomGradientPanel4.BackColor = System.Drawing.Color.Transparent;
            this.siticoneCustomGradientPanel4.BorderColor = System.Drawing.Color.Black;
            this.siticoneCustomGradientPanel4.BorderRadius = 7;
            this.siticoneCustomGradientPanel4.Controls.Add(this.label13);
            this.siticoneTransition1.SetDecoration(this.siticoneCustomGradientPanel4, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneCustomGradientPanel4.FillColor = System.Drawing.Color.DarkGreen;
            this.siticoneCustomGradientPanel4.FillColor2 = System.Drawing.Color.Lime;
            this.siticoneCustomGradientPanel4.FillColor3 = System.Drawing.Color.Lime;
            this.siticoneCustomGradientPanel4.FillColor4 = System.Drawing.Color.DarkGreen;
            this.siticoneCustomGradientPanel4.Location = new System.Drawing.Point(0, 0);
            this.siticoneCustomGradientPanel4.Name = "siticoneCustomGradientPanel4";
            this.siticoneCustomGradientPanel4.ShadowDecoration.Parent = this.siticoneCustomGradientPanel4;
            this.siticoneCustomGradientPanel4.Size = new System.Drawing.Size(534, 35);
            this.siticoneCustomGradientPanel4.TabIndex = 49;
            // 
            // label13
            // 
            this.siticoneTransition1.SetDecoration(this.label13, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(241, 5);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 25);
            this.label13.TabIndex = 49;
            this.label13.Text = "Spoofing";
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.BackColor = System.Drawing.Color.Transparent;
            this.siticonePanel1.Controls.Add(this.siticoneControlBox2);
            this.siticonePanel1.Controls.Add(this.label2);
            this.siticonePanel1.Controls.Add(this.siticonePictureBox1);
            this.siticonePanel1.Controls.Add(this.siticoneControlBox1);
            this.siticoneTransition1.SetDecoration(this.siticonePanel1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticonePanel1.Location = new System.Drawing.Point(0, 4);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.ShadowDecoration.Parent = this.siticonePanel1;
            this.siticonePanel1.Size = new System.Drawing.Size(557, 25);
            this.siticonePanel1.TabIndex = 67;
            this.siticonePanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.siticonePanel1_Paint);
            // 
            // siticoneControlBox2
            // 
            this.siticoneControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox2.BorderRadius = 7;
            this.siticoneControlBox2.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneTransition1.SetDecoration(this.siticoneControlBox2, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneControlBox2.FillColor = System.Drawing.Color.Gray;
            this.siticoneControlBox2.HoverState.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox2.Location = new System.Drawing.Point(479, 1);
            this.siticoneControlBox2.Name = "siticoneControlBox2";
            this.siticoneControlBox2.ShadowDecoration.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.Size = new System.Drawing.Size(35, 23);
            this.siticoneControlBox2.TabIndex = 3;
            this.siticoneControlBox2.Click += new System.EventHandler(this.siticoneControlBox2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.label2, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(239, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lewyy\'s Spoofer";
            // 
            // siticonePictureBox1
            // 
            this.siticonePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.siticonePictureBox1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticonePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("siticonePictureBox1.Image")));
            this.siticonePictureBox1.ImageRotate = 0F;
            this.siticonePictureBox1.Location = new System.Drawing.Point(0, 1);
            this.siticonePictureBox1.Name = "siticonePictureBox1";
            this.siticonePictureBox1.ShadowDecoration.Parent = this.siticonePictureBox1;
            this.siticonePictureBox1.Size = new System.Drawing.Size(39, 24);
            this.siticonePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.siticonePictureBox1.TabIndex = 1;
            this.siticonePictureBox1.TabStop = false;
            this.siticonePictureBox1.UseTransparentBackground = true;
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.BorderRadius = 7;
            this.siticoneTransition1.SetDecoration(this.siticoneControlBox1, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneControlBox1.FillColor = System.Drawing.Color.Gray;
            this.siticoneControlBox1.HoverState.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.Location = new System.Drawing.Point(518, 1);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.Size = new System.Drawing.Size(35, 23);
            this.siticoneControlBox1.TabIndex = 0;
            this.siticoneControlBox1.Click += new System.EventHandler(this.siticoneControlBox1_Click_1);
            // 
            // siticoneCustomGradientPanel5
            // 
            this.siticoneCustomGradientPanel5.BackColor = System.Drawing.Color.Transparent;
            this.siticoneCustomGradientPanel5.BorderColor = System.Drawing.Color.Black;
            this.siticoneCustomGradientPanel5.BorderRadius = 10;
            this.siticoneCustomGradientPanel5.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.siticoneCustomGradientPanel5.Controls.Add(this.siticonePictureBox7);
            this.siticoneCustomGradientPanel5.Controls.Add(this.siticonePictureBox3);
            this.siticoneCustomGradientPanel5.Controls.Add(this.siticonePictureBox2);
            this.siticoneCustomGradientPanel5.Controls.Add(this.siticonePictureBox5);
            this.siticoneCustomGradientPanel5.Controls.Add(this.siticonePictureBox6);
            this.siticoneCustomGradientPanel5.Controls.Add(this.siticonePictureBox4);
            this.siticoneCustomGradientPanel5.Controls.Add(this.siticoneCustomGradientPanel6);
            this.siticoneTransition1.SetDecoration(this.siticoneCustomGradientPanel5, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneCustomGradientPanel5.FillColor = System.Drawing.Color.DarkGreen;
            this.siticoneCustomGradientPanel5.FillColor2 = System.Drawing.Color.Lime;
            this.siticoneCustomGradientPanel5.FillColor3 = System.Drawing.Color.DarkGreen;
            this.siticoneCustomGradientPanel5.FillColor4 = System.Drawing.Color.Lime;
            this.siticoneCustomGradientPanel5.Location = new System.Drawing.Point(14, 40);
            this.siticoneCustomGradientPanel5.Name = "siticoneCustomGradientPanel5";
            this.siticoneCustomGradientPanel5.ShadowDecoration.Parent = this.siticoneCustomGradientPanel5;
            this.siticoneCustomGradientPanel5.Size = new System.Drawing.Size(534, 124);
            this.siticoneCustomGradientPanel5.TabIndex = 50;
            this.siticoneCustomGradientPanel5.Paint += new System.Windows.Forms.PaintEventHandler(this.siticoneCustomGradientPanel5_Paint);
            // 
            // siticonePictureBox5
            // 
            this.siticonePictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siticoneTransition1.SetDecoration(this.siticonePictureBox5, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticonePictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("siticonePictureBox5.Image")));
            this.siticonePictureBox5.ImageRotate = 0F;
            this.siticonePictureBox5.Location = new System.Drawing.Point(115, 52);
            this.siticonePictureBox5.Name = "siticonePictureBox5";
            this.siticonePictureBox5.ShadowDecoration.Parent = this.siticonePictureBox5;
            this.siticonePictureBox5.Size = new System.Drawing.Size(72, 37);
            this.siticonePictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.siticonePictureBox5.TabIndex = 63;
            this.siticonePictureBox5.TabStop = false;
            this.siticonePictureBox5.UseTransparentBackground = true;
            this.siticonePictureBox5.Click += new System.EventHandler(this.siticonePictureBox5_Click_1);
            // 
            // siticonePictureBox6
            // 
            this.siticonePictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siticoneTransition1.SetDecoration(this.siticonePictureBox6, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticonePictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("siticonePictureBox6.Image")));
            this.siticonePictureBox6.ImageRotate = 0F;
            this.siticonePictureBox6.Location = new System.Drawing.Point(193, 52);
            this.siticonePictureBox6.Name = "siticonePictureBox6";
            this.siticonePictureBox6.ShadowDecoration.Parent = this.siticonePictureBox6;
            this.siticonePictureBox6.Size = new System.Drawing.Size(72, 37);
            this.siticonePictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.siticonePictureBox6.TabIndex = 62;
            this.siticonePictureBox6.TabStop = false;
            this.siticonePictureBox6.UseTransparentBackground = true;
            this.siticonePictureBox6.Click += new System.EventHandler(this.siticonePictureBox6_Click);
            // 
            // siticonePictureBox4
            // 
            this.siticonePictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siticoneTransition1.SetDecoration(this.siticonePictureBox4, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticonePictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("siticonePictureBox4.Image")));
            this.siticonePictureBox4.ImageRotate = 0F;
            this.siticonePictureBox4.Location = new System.Drawing.Point(27, 52);
            this.siticonePictureBox4.Name = "siticonePictureBox4";
            this.siticonePictureBox4.ShadowDecoration.Parent = this.siticonePictureBox4;
            this.siticonePictureBox4.Size = new System.Drawing.Size(72, 37);
            this.siticonePictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.siticonePictureBox4.TabIndex = 60;
            this.siticonePictureBox4.TabStop = false;
            this.siticonePictureBox4.UseTransparentBackground = true;
            this.siticonePictureBox4.Click += new System.EventHandler(this.siticonePictureBox4_Click);
            // 
            // siticoneCustomGradientPanel6
            // 
            this.siticoneCustomGradientPanel6.BackColor = System.Drawing.Color.Transparent;
            this.siticoneCustomGradientPanel6.BorderColor = System.Drawing.Color.Black;
            this.siticoneCustomGradientPanel6.BorderRadius = 7;
            this.siticoneCustomGradientPanel6.Controls.Add(this.label5);
            this.siticoneTransition1.SetDecoration(this.siticoneCustomGradientPanel6, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticoneCustomGradientPanel6.FillColor = System.Drawing.Color.DarkGreen;
            this.siticoneCustomGradientPanel6.FillColor2 = System.Drawing.Color.DarkGreen;
            this.siticoneCustomGradientPanel6.FillColor3 = System.Drawing.Color.Lime;
            this.siticoneCustomGradientPanel6.FillColor4 = System.Drawing.Color.DarkGreen;
            this.siticoneCustomGradientPanel6.Location = new System.Drawing.Point(0, 0);
            this.siticoneCustomGradientPanel6.Name = "siticoneCustomGradientPanel6";
            this.siticoneCustomGradientPanel6.ShadowDecoration.Parent = this.siticoneCustomGradientPanel6;
            this.siticoneCustomGradientPanel6.Size = new System.Drawing.Size(534, 35);
            this.siticoneCustomGradientPanel6.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.label5, Siticone.UI.AnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(241, 5);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 19);
            this.label5.TabIndex = 49;
            this.label5.Text = "Cleaning";
            // 
            // siticoneDragControl2
            // 
            this.siticoneDragControl2.TargetControl = this.siticonePanel1;
            // 
            // siticonePictureBox2
            // 
            this.siticonePictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siticoneTransition1.SetDecoration(this.siticonePictureBox2, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticonePictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("siticonePictureBox2.Image")));
            this.siticonePictureBox2.ImageRotate = 0F;
            this.siticonePictureBox2.Location = new System.Drawing.Point(277, 52);
            this.siticonePictureBox2.Name = "siticonePictureBox2";
            this.siticonePictureBox2.ShadowDecoration.Parent = this.siticonePictureBox2;
            this.siticonePictureBox2.Size = new System.Drawing.Size(72, 37);
            this.siticonePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.siticonePictureBox2.TabIndex = 65;
            this.siticonePictureBox2.TabStop = false;
            this.siticonePictureBox2.UseTransparentBackground = true;
            this.siticonePictureBox2.Click += new System.EventHandler(this.siticonePictureBox2_Click_1);
            // 
            // siticonePictureBox3
            // 
            this.siticonePictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siticoneTransition1.SetDecoration(this.siticonePictureBox3, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticonePictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("siticonePictureBox3.Image")));
            this.siticonePictureBox3.ImageRotate = 0F;
            this.siticonePictureBox3.Location = new System.Drawing.Point(351, 52);
            this.siticonePictureBox3.Name = "siticonePictureBox3";
            this.siticonePictureBox3.ShadowDecoration.Parent = this.siticonePictureBox3;
            this.siticonePictureBox3.Size = new System.Drawing.Size(72, 37);
            this.siticonePictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.siticonePictureBox3.TabIndex = 66;
            this.siticonePictureBox3.TabStop = false;
            this.siticonePictureBox3.UseTransparentBackground = true;
            this.siticonePictureBox3.Click += new System.EventHandler(this.siticonePictureBox3_Click_1);
            // 
            // siticonePictureBox7
            // 
            this.siticonePictureBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siticoneTransition1.SetDecoration(this.siticonePictureBox7, Siticone.UI.AnimatorNS.DecorationType.None);
            this.siticonePictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("siticonePictureBox7.Image")));
            this.siticonePictureBox7.ImageRotate = 0F;
            this.siticonePictureBox7.Location = new System.Drawing.Point(439, 52);
            this.siticonePictureBox7.Name = "siticonePictureBox7";
            this.siticonePictureBox7.ShadowDecoration.Parent = this.siticonePictureBox7;
            this.siticonePictureBox7.Size = new System.Drawing.Size(72, 37);
            this.siticonePictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.siticonePictureBox7.TabIndex = 67;
            this.siticonePictureBox7.TabStop = false;
            this.siticonePictureBox7.UseTransparentBackground = true;
            this.siticonePictureBox7.Click += new System.EventHandler(this.siticonePictureBox7_Click_1);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(558, 301);
            this.Controls.Add(this.siticonePanel1);
            this.Controls.Add(this.siticoneCustomGradientPanel3);
            this.Controls.Add(this.siticoneCustomGradientPanel5);
            this.Controls.Add(this.label1);
            this.siticoneTransition1.SetDecoration(this, Siticone.UI.AnimatorNS.DecorationType.None);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cleaner";
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.Load += new System.EventHandler(this.Main_Load);
            this.siticoneCustomGradientPanel3.ResumeLayout(false);
            this.siticoneCustomGradientPanel4.ResumeLayout(false);
            this.siticonePanel1.ResumeLayout(false);
            this.siticonePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).EndInit();
            this.siticoneCustomGradientPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox4)).EndInit();
            this.siticoneCustomGradientPanel6.ResumeLayout(false);
            this.siticoneCustomGradientPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // Token: 0x04000001 RID: 1
        private global::System.ComponentModel.IContainer components = null;

        // Token: 0x04000002 RID: 2
        private global::Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;

        // Token: 0x04000009 RID: 9
        private global::Siticone.UI.WinForms.SiticoneTransition siticoneTransition1;

        // Token: 0x0400000A RID: 10
        private global::System.Windows.Forms.Label label1;
        private Siticone.UI.WinForms.SiticoneShadowForm siticoneShadowForm;
        private Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel siticoneCustomGradientPanel3;
        private Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel siticoneCustomGradientPanel4;
        private System.Windows.Forms.Label label13;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private System.Windows.Forms.Label label2;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox siticonePictureBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox2;
        private Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl2;
        private Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel siticoneCustomGradientPanel5;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox siticonePictureBox6;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox siticonePictureBox4;
        private Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel siticoneCustomGradientPanel6;
        private System.Windows.Forms.Label label5;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox siticonePictureBox5;
        private Siticone.UI.WinForms.SiticoneGradientButton siticoneGradientButton1;
        private Siticone.UI.WinForms.SiticoneGradientButton siticoneGradientButton2;
        private Siticone.UI.WinForms.SiticoneGradientButton siticoneGradientButton3;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox siticonePictureBox7;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox siticonePictureBox3;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox siticonePictureBox2;
    }
}