

namespace cpx400
{
    partial class Form1
    {

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_Connect = new System.Windows.Forms.Button();
            this.btn_COE = new System.Windows.Forms.Button();
            this.btn_CCL = new System.Windows.Forms.Button();
            this.btn_COVP = new System.Windows.Forms.Button();
            this.btn_CVL = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_CVLchName = new System.Windows.Forms.Label();
            this.lbl_CVLlvl = new System.Windows.Forms.Label();
            this.nud_CVL_level = new System.Windows.Forms.NumericUpDown();
            this.lbl_CCLlimit = new System.Windows.Forms.Label();
            this.nud_CCL_limit = new System.Windows.Forms.NumericUpDown();
            this.lbl_COVPlimit = new System.Windows.Forms.Label();
            this.nud_COVP_limit = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nud_COCP_limit = new System.Windows.Forms.NumericUpDown();
            this.btn_COCP = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtn_voltage = new System.Windows.Forms.RadioButton();
            this.rbtn_amper = new System.Windows.Forms.RadioButton();
            this.lbl_chanelName = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.rbtn_COVP_true = new System.Windows.Forms.RadioButton();
            this.rbtn_COVP_false = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.nud_CCL_behavior = new System.Windows.Forms.NumericUpDown();
            this.gb_chanelNames = new System.Windows.Forms.GroupBox();
            this.rbtn_chname1 = new System.Windows.Forms.RadioButton();
            this.rbtn_chname2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.nud_CVL_level)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_CCL_limit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_COVP_limit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_COCP_limit)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_CCL_behavior)).BeginInit();
            this.gb_chanelNames.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Connect
            // 
            this.btn_Connect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(179)))), ((int)(((byte)(24)))));
            this.btn_Connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Connect.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Connect.ForeColor = System.Drawing.Color.White;
            this.btn_Connect.Location = new System.Drawing.Point(97, 12);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(776, 42);
            this.btn_Connect.TabIndex = 0;
            this.btn_Connect.Text = "CONNECT . . . ";
            this.btn_Connect.UseVisualStyleBackColor = false;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // btn_COE
            // 
            this.btn_COE.BackColor = System.Drawing.Color.White;
            this.btn_COE.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_COE.Location = new System.Drawing.Point(9, 253);
            this.btn_COE.Name = "btn_COE";
            this.btn_COE.Size = new System.Drawing.Size(212, 97);
            this.btn_COE.TabIndex = 1;
            this.btn_COE.Text = " Output Enabled/Disabled Configuration";
            this.btn_COE.UseVisualStyleBackColor = false;
            this.btn_COE.Click += new System.EventHandler(this.btn_COE_Click);
            // 
            // btn_CCL
            // 
            this.btn_CCL.BackColor = System.Drawing.Color.White;
            this.btn_CCL.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_CCL.Location = new System.Drawing.Point(9, 205);
            this.btn_CCL.Name = "btn_CCL";
            this.btn_CCL.Size = new System.Drawing.Size(207, 31);
            this.btn_CCL.TabIndex = 3;
            this.btn_CCL.Text = "Configure Current Limit";
            this.btn_CCL.UseVisualStyleBackColor = false;
            this.btn_CCL.Click += new System.EventHandler(this.btn_CCL_Click);
            // 
            // btn_COVP
            // 
            this.btn_COVP.BackColor = System.Drawing.Color.White;
            this.btn_COVP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_COVP.Location = new System.Drawing.Point(270, 314);
            this.btn_COVP.Name = "btn_COVP";
            this.btn_COVP.Size = new System.Drawing.Size(217, 31);
            this.btn_COVP.TabIndex = 4;
            this.btn_COVP.Text = " Configure OVP";
            this.btn_COVP.UseVisualStyleBackColor = false;
            this.btn_COVP.Click += new System.EventHandler(this.btn_COVP_Click);
            // 
            // btn_CVL
            // 
            this.btn_CVL.BackColor = System.Drawing.Color.White;
            this.btn_CVL.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_CVL.Location = new System.Drawing.Point(269, 123);
            this.btn_CVL.Name = "btn_CVL";
            this.btn_CVL.Size = new System.Drawing.Size(218, 31);
            this.btn_CVL.TabIndex = 5;
            this.btn_CVL.Text = "Configure Voltage Level";
            this.btn_CVL.UseVisualStyleBackColor = false;
            this.btn_CVL.Click += new System.EventHandler(this.btn_CVL_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_close.Enabled = false;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_close.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_close.Image = global::cpx400.Properties.Resources.close1;
            this.btn_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_close.Location = new System.Drawing.Point(360, 75);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(242, 42);
            this.btn_close.TabIndex = 6;
            this.btn_close.Text = "CLOSE";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_reset.Enabled = false;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_reset.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_reset.Image = global::cpx400.Properties.Resources.refresh_button;
            this.btn_reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reset.Location = new System.Drawing.Point(359, 123);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(243, 42);
            this.btn_reset.TabIndex = 7;
            this.btn_reset.Text = "RESET";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(346, 57);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(79, 15);
            this.lbl_status.TabIndex = 10;
            this.lbl_status.Text = "Status Code :";
            // 
            // lbl_CVLchName
            // 
            this.lbl_CVLchName.AutoSize = true;
            this.lbl_CVLchName.Location = new System.Drawing.Point(25, 22);
            this.lbl_CVLchName.Name = "lbl_CVLchName";
            this.lbl_CVLchName.Size = new System.Drawing.Size(88, 15);
            this.lbl_CVLchName.TabIndex = 12;
            this.lbl_CVLchName.Text = "Chanel Name : ";
            // 
            // lbl_CVLlvl
            // 
            this.lbl_CVLlvl.AutoSize = true;
            this.lbl_CVLlvl.Location = new System.Drawing.Point(267, 95);
            this.lbl_CVLlvl.Name = "lbl_CVLlvl";
            this.lbl_CVLlvl.Size = new System.Drawing.Size(43, 15);
            this.lbl_CVLlvl.TabIndex = 13;
            this.lbl_CVLlvl.Text = "Level : ";
            // 
            // nud_CVL_level
            // 
            this.nud_CVL_level.Location = new System.Drawing.Point(367, 87);
            this.nud_CVL_level.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nud_CVL_level.Name = "nud_CVL_level";
            this.nud_CVL_level.Size = new System.Drawing.Size(120, 23);
            this.nud_CVL_level.TabIndex = 16;
            // 
            // lbl_CCLlimit
            // 
            this.lbl_CCLlimit.AutoSize = true;
            this.lbl_CCLlimit.Location = new System.Drawing.Point(9, 143);
            this.lbl_CCLlimit.Name = "lbl_CCLlimit";
            this.lbl_CCLlimit.Size = new System.Drawing.Size(40, 15);
            this.lbl_CCLlimit.TabIndex = 18;
            this.lbl_CCLlimit.Text = "Limit :";
            // 
            // nud_CCL_limit
            // 
            this.nud_CCL_limit.DecimalPlaces = 2;
            this.nud_CCL_limit.Location = new System.Drawing.Point(96, 143);
            this.nud_CCL_limit.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nud_CCL_limit.Name = "nud_CCL_limit";
            this.nud_CCL_limit.Size = new System.Drawing.Size(120, 23);
            this.nud_CCL_limit.TabIndex = 20;
            // 
            // lbl_COVPlimit
            // 
            this.lbl_COVPlimit.AutoSize = true;
            this.lbl_COVPlimit.Location = new System.Drawing.Point(269, 287);
            this.lbl_COVPlimit.Name = "lbl_COVPlimit";
            this.lbl_COVPlimit.Size = new System.Drawing.Size(43, 15);
            this.lbl_COVPlimit.TabIndex = 22;
            this.lbl_COVPlimit.Text = "Limit : ";
            // 
            // nud_COVP_limit
            // 
            this.nud_COVP_limit.DecimalPlaces = 2;
            this.nud_COVP_limit.Location = new System.Drawing.Point(363, 285);
            this.nud_COVP_limit.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nud_COVP_limit.Name = "nud_COVP_limit";
            this.nud_COVP_limit.Size = new System.Drawing.Size(124, 23);
            this.nud_COVP_limit.TabIndex = 29;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(289, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(91)))), ((int)(((byte)(100)))));
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nud_COCP_limit);
            this.groupBox1.Controls.Add(this.btn_COCP);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lbl_chanelName);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.groupBox8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nud_CCL_behavior);
            this.groupBox1.Controls.Add(this.nud_COVP_limit);
            this.groupBox1.Controls.Add(this.lbl_CCLlimit);
            this.groupBox1.Controls.Add(this.nud_CCL_limit);
            this.groupBox1.Controls.Add(this.lbl_CVLlvl);
            this.groupBox1.Controls.Add(this.nud_CVL_level);
            this.groupBox1.Controls.Add(this.btn_CCL);
            this.groupBox1.Controls.Add(this.lbl_COVPlimit);
            this.groupBox1.Controls.Add(this.btn_CVL);
            this.groupBox1.Controls.Add(this.btn_COVP);
            this.groupBox1.Controls.Add(this.btn_COE);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.Silver;
            this.groupBox1.Location = new System.Drawing.Point(75, 263);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 358);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CONTROLLER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(542, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 25);
            this.label3.TabIndex = 48;
            this.label3.Text = "measurement";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 51;
            this.label2.Text = "Limit :";
            // 
            // nud_COCP_limit
            // 
            this.nud_COCP_limit.DecimalPlaces = 2;
            this.nud_COCP_limit.Location = new System.Drawing.Point(96, 66);
            this.nud_COCP_limit.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nud_COCP_limit.Name = "nud_COCP_limit";
            this.nud_COCP_limit.Size = new System.Drawing.Size(120, 23);
            this.nud_COCP_limit.TabIndex = 52;
            // 
            // btn_COCP
            // 
            this.btn_COCP.BackColor = System.Drawing.Color.White;
            this.btn_COCP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_COCP.Location = new System.Drawing.Point(9, 95);
            this.btn_COCP.Name = "btn_COCP";
            this.btn_COCP.Size = new System.Drawing.Size(207, 31);
            this.btn_COCP.TabIndex = 50;
            this.btn_COCP.Text = " Configure OCP";
            this.btn_COCP.UseVisualStyleBackColor = false;
            this.btn_COCP.Click += new System.EventHandler(this.btn_COCP_click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtn_voltage);
            this.groupBox2.Controls.Add(this.rbtn_amper);
            this.groupBox2.ForeColor = System.Drawing.Color.Silver;
            this.groupBox2.Location = new System.Drawing.Point(542, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 61);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Measurement Type";
            // 
            // rbtn_voltage
            // 
            this.rbtn_voltage.AutoSize = true;
            this.rbtn_voltage.Location = new System.Drawing.Point(34, 22);
            this.rbtn_voltage.Name = "rbtn_voltage";
            this.rbtn_voltage.Size = new System.Drawing.Size(79, 19);
            this.rbtn_voltage.TabIndex = 50;
            this.rbtn_voltage.Text = "Voltage(V)";
            this.rbtn_voltage.UseVisualStyleBackColor = true;
            // 
            // rbtn_amper
            // 
            this.rbtn_amper.AutoSize = true;
            this.rbtn_amper.Checked = true;
            this.rbtn_amper.Location = new System.Drawing.Point(119, 22);
            this.rbtn_amper.Name = "rbtn_amper";
            this.rbtn_amper.Size = new System.Drawing.Size(72, 19);
            this.rbtn_amper.TabIndex = 51;
            this.rbtn_amper.TabStop = true;
            this.rbtn_amper.Text = "Amper(I)";
            this.rbtn_amper.UseVisualStyleBackColor = true;
            // 
            // lbl_chanelName
            // 
            this.lbl_chanelName.AutoSize = true;
            this.lbl_chanelName.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_chanelName.ForeColor = System.Drawing.Color.SeaShell;
            this.lbl_chanelName.Location = new System.Drawing.Point(178, 6);
            this.lbl_chanelName.Name = "lbl_chanelName";
            this.lbl_chanelName.Size = new System.Drawing.Size(398, 47);
            this.lbl_chanelName.TabIndex = 48;
            this.lbl_chanelName.Text = "SELECTED CHANEL = 1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.richTextBox1.Location = new System.Drawing.Point(550, 185);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.richTextBox1.Size = new System.Drawing.Size(220, 165);
            this.richTextBox1.TabIndex = 46;
            this.richTextBox1.Text = "History";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.rbtn_COVP_true);
            this.groupBox8.Controls.Add(this.rbtn_COVP_false);
            this.groupBox8.ForeColor = System.Drawing.Color.Silver;
            this.groupBox8.Location = new System.Drawing.Point(269, 218);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(220, 61);
            this.groupBox8.TabIndex = 45;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Enabled";
            // 
            // rbtn_COVP_true
            // 
            this.rbtn_COVP_true.AutoSize = true;
            this.rbtn_COVP_true.Location = new System.Drawing.Point(84, 21);
            this.rbtn_COVP_true.Name = "rbtn_COVP_true";
            this.rbtn_COVP_true.Size = new System.Drawing.Size(47, 19);
            this.rbtn_COVP_true.TabIndex = 33;
            this.rbtn_COVP_true.Text = "True";
            this.rbtn_COVP_true.UseVisualStyleBackColor = true;
            // 
            // rbtn_COVP_false
            // 
            this.rbtn_COVP_false.AutoSize = true;
            this.rbtn_COVP_false.Checked = true;
            this.rbtn_COVP_false.Location = new System.Drawing.Point(142, 21);
            this.rbtn_COVP_false.Name = "rbtn_COVP_false";
            this.rbtn_COVP_false.Size = new System.Drawing.Size(51, 19);
            this.rbtn_COVP_false.TabIndex = 34;
            this.rbtn_COVP_false.TabStop = true;
            this.rbtn_COVP_false.Text = "False";
            this.rbtn_COVP_false.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 43;
            this.label1.Text = "Behavior :";
            // 
            // nud_CCL_behavior
            // 
            this.nud_CCL_behavior.DecimalPlaces = 2;
            this.nud_CCL_behavior.Location = new System.Drawing.Point(96, 172);
            this.nud_CCL_behavior.Name = "nud_CCL_behavior";
            this.nud_CCL_behavior.Size = new System.Drawing.Size(120, 23);
            this.nud_CCL_behavior.TabIndex = 44;
            // 
            // gb_chanelNames
            // 
            this.gb_chanelNames.Controls.Add(this.rbtn_chname1);
            this.gb_chanelNames.Controls.Add(this.rbtn_chname2);
            this.gb_chanelNames.Enabled = false;
            this.gb_chanelNames.Location = new System.Drawing.Point(346, 171);
            this.gb_chanelNames.Name = "gb_chanelNames";
            this.gb_chanelNames.Size = new System.Drawing.Size(269, 86);
            this.gb_chanelNames.TabIndex = 47;
            this.gb_chanelNames.TabStop = false;
            this.gb_chanelNames.Text = "Chanel Name";
            // 
            // rbtn_chname1
            // 
            this.rbtn_chname1.AutoSize = true;
            this.rbtn_chname1.Checked = true;
            this.rbtn_chname1.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbtn_chname1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rbtn_chname1.Location = new System.Drawing.Point(42, 20);
            this.rbtn_chname1.Name = "rbtn_chname1";
            this.rbtn_chname1.Size = new System.Drawing.Size(48, 41);
            this.rbtn_chname1.TabIndex = 37;
            this.rbtn_chname1.TabStop = true;
            this.rbtn_chname1.Text = "1";
            this.rbtn_chname1.UseVisualStyleBackColor = true;
            this.rbtn_chname1.CheckedChanged += new System.EventHandler(this.rbtn_chname1_CheckedChanged);
            // 
            // rbtn_chname2
            // 
            this.rbtn_chname2.AutoSize = true;
            this.rbtn_chname2.Checked = true;
            this.rbtn_chname2.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbtn_chname2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rbtn_chname2.Location = new System.Drawing.Point(157, 20);
            this.rbtn_chname2.Name = "rbtn_chname2";
            this.rbtn_chname2.Size = new System.Drawing.Size(51, 41);
            this.rbtn_chname2.TabIndex = 36;
            this.rbtn_chname2.TabStop = true;
            this.rbtn_chname2.Text = "2";
            this.rbtn_chname2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(959, 633);
            this.Controls.Add(this.gb_chanelNames);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.btn_Connect);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nud_CVL_level)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_CCL_limit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_COVP_limit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_COCP_limit)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_CCL_behavior)).EndInit();
            this.gb_chanelNames.ResumeLayout(false);
            this.gb_chanelNames.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Connect;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button btn_close;
        private Button btn_reset;
        private Label lbl_status;
        private Label lbl_CVLchName;
        private Label lbl_CVLlvl;
        private NumericUpDown nud_CVL_level;
        private Label lbl_CCLlimit;
        private NumericUpDown nud_CCL_limit;
        private Label lbl_COVPlimit;
        private NumericUpDown nud_COVP_limit;
        private PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox1;
        private Button Enabled;
        private Button btn_COE;
        private Button btn_CCL;
        private Button btn_COVP;
        private Button btn_CVL;
        private Label label1;
        private NumericUpDown nud_CCL_behavior;
        private GroupBox groupBox8;
        private RadioButton rbtn_COVP_true;
        private RadioButton rbtn_COVP_false;
        private RichTextBox richTextBox1;
        private GroupBox gb_chanelNames;
        private RadioButton rbtn_chname1;
        private RadioButton rbtn_chname2;
        private Label lbl_chanelName;
        private GroupBox groupBox2;
        private RadioButton rbtn_voltage;
        private RadioButton rbtn_amper;
        private Button btn_COCP;
        private Label label2;
        private NumericUpDown nud_COCP_limit;
        private Label label3;
    }
}