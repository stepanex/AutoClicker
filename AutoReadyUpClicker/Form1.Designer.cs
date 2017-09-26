namespace AutoReadyUpClicker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timerXY = new System.Windows.Forms.Timer(this.components);
            this.buttonRemoveAll = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.comboBoxPresets = new System.Windows.Forms.ComboBox();
            this.textBoxPresetName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.buttonClickReset = new System.Windows.Forms.Button();
            this.buttonClickSet = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.labelChosenPreset = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBoxClickY = new System.Windows.Forms.TextBox();
            this.textBoxClickX = new System.Windows.Forms.TextBox();
            this.buttonColorReset = new System.Windows.Forms.Button();
            this.pictureBoxColorDetected = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonColorSet = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxColorY = new System.Windows.Forms.TextBox();
            this.textBoxColorX = new System.Windows.Forms.TextBox();
            this.labelXY = new System.Windows.Forms.Label();
            this.buttonCreatePreset = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.tabPage4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColorDetected)).BeginInit();
            this.SuspendLayout();
            // 
            // timerXY
            // 
            this.timerXY.Enabled = true;
            this.timerXY.Interval = 40;
            this.timerXY.Tick += new System.EventHandler(this.timerXY_Tick);
            // 
            // buttonRemoveAll
            // 
            this.buttonRemoveAll.Location = new System.Drawing.Point(357, 276);
            this.buttonRemoveAll.Name = "buttonRemoveAll";
            this.buttonRemoveAll.Size = new System.Drawing.Size(124, 44);
            this.buttonRemoveAll.TabIndex = 2;
            this.buttonRemoveAll.Text = "Remove all presets";
            this.buttonRemoveAll.UseVisualStyleBackColor = true;
            this.buttonRemoveAll.Click += new System.EventHandler(this.buttonRemoveAll_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemove.Location = new System.Drawing.Point(173, 187);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(140, 47);
            this.buttonRemove.TabIndex = 1;
            this.buttonRemove.Text = "Remove chosen preset";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.buttonRemoveAll);
            this.tabPage4.Controls.Add(this.buttonRemove);
            this.tabPage4.Controls.Add(this.comboBoxPresets);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(484, 328);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Remove a preset";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // comboBoxPresets
            // 
            this.comboBoxPresets.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxPresets.FormattingEnabled = true;
            this.comboBoxPresets.Location = new System.Drawing.Point(173, 82);
            this.comboBoxPresets.Name = "comboBoxPresets";
            this.comboBoxPresets.Size = new System.Drawing.Size(140, 21);
            this.comboBoxPresets.TabIndex = 0;
            // 
            // textBoxPresetName
            // 
            this.textBoxPresetName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPresetName.Location = new System.Drawing.Point(113, 212);
            this.textBoxPresetName.Name = "textBoxPresetName";
            this.textBoxPresetName.Size = new System.Drawing.Size(127, 20);
            this.textBoxPresetName.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 215);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Set name of preset:";
            // 
            // buttonClickReset
            // 
            this.buttonClickReset.Enabled = false;
            this.buttonClickReset.Location = new System.Drawing.Point(338, 153);
            this.buttonClickReset.Name = "buttonClickReset";
            this.buttonClickReset.Size = new System.Drawing.Size(75, 23);
            this.buttonClickReset.TabIndex = 20;
            this.buttonClickReset.Text = "Reset";
            this.buttonClickReset.UseVisualStyleBackColor = true;
            this.buttonClickReset.Click += new System.EventHandler(this.buttonClickReset_Click);
            // 
            // buttonClickSet
            // 
            this.buttonClickSet.Location = new System.Drawing.Point(338, 124);
            this.buttonClickSet.Name = "buttonClickSet";
            this.buttonClickSet.Size = new System.Drawing.Size(75, 23);
            this.buttonClickSet.TabIndex = 5;
            this.buttonClickSet.Text = "Set";
            this.buttonClickSet.UseVisualStyleBackColor = true;
            this.buttonClickSet.Click += new System.EventHandler(this.buttonClickSet_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(246, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Y:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(171, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "X:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 129);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(158, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Set position of place to click on:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(492, 354);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.labelChosenPreset);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBoxTime);
            this.tabPage1.Controls.Add(this.buttonStart);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(484, 328);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Start";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "The application needs to stay in focus in order to work";
            // 
            // labelChosenPreset
            // 
            this.labelChosenPreset.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelChosenPreset.AutoSize = true;
            this.labelChosenPreset.Location = new System.Drawing.Point(187, 53);
            this.labelChosenPreset.Name = "labelChosenPreset";
            this.labelChosenPreset.Size = new System.Drawing.Size(107, 13);
            this.labelChosenPreset.TabIndex = 9;
            this.labelChosenPreset.Text = "Chosen preset: None";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Number of seconds you want to wait:";
            // 
            // textBoxTime
            // 
            this.textBoxTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTime.Location = new System.Drawing.Point(269, 101);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxTime.Size = new System.Drawing.Size(100, 20);
            this.textBoxTime.TabIndex = 7;
            this.textBoxTime.Text = "30000";
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStart.Location = new System.Drawing.Point(175, 173);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(140, 47);
            this.buttonStart.TabIndex = 6;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.flowLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(484, 328);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Presets";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(478, 322);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBoxPresetName);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.buttonClickReset);
            this.tabPage3.Controls.Add(this.buttonClickSet);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.textBoxClickY);
            this.tabPage3.Controls.Add(this.textBoxClickX);
            this.tabPage3.Controls.Add(this.buttonColorReset);
            this.tabPage3.Controls.Add(this.pictureBoxColorDetected);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.buttonColorSet);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.textBoxColorY);
            this.tabPage3.Controls.Add(this.textBoxColorX);
            this.tabPage3.Controls.Add(this.labelXY);
            this.tabPage3.Controls.Add(this.buttonCreatePreset);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(484, 328);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Create new preset";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBoxClickY
            // 
            this.textBoxClickY.Location = new System.Drawing.Point(269, 126);
            this.textBoxClickY.Name = "textBoxClickY";
            this.textBoxClickY.Size = new System.Drawing.Size(54, 20);
            this.textBoxClickY.TabIndex = 4;
            // 
            // textBoxClickX
            // 
            this.textBoxClickX.Location = new System.Drawing.Point(194, 126);
            this.textBoxClickX.Name = "textBoxClickX";
            this.textBoxClickX.Size = new System.Drawing.Size(46, 20);
            this.textBoxClickX.TabIndex = 3;
            // 
            // buttonColorReset
            // 
            this.buttonColorReset.Enabled = false;
            this.buttonColorReset.Location = new System.Drawing.Point(391, 68);
            this.buttonColorReset.Name = "buttonColorReset";
            this.buttonColorReset.Size = new System.Drawing.Size(75, 23);
            this.buttonColorReset.TabIndex = 13;
            this.buttonColorReset.Text = "Reset color";
            this.buttonColorReset.UseVisualStyleBackColor = true;
            this.buttonColorReset.Click += new System.EventHandler(this.buttonColorReset_Click);
            // 
            // pictureBoxColorDetected
            // 
            this.pictureBoxColorDetected.Location = new System.Drawing.Point(269, 68);
            this.pictureBoxColorDetected.Name = "pictureBoxColorDetected";
            this.pictureBoxColorDetected.Size = new System.Drawing.Size(66, 26);
            this.pictureBoxColorDetected.TabIndex = 12;
            this.pictureBoxColorDetected.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(117, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Detected color looks like this:";
            // 
            // buttonColorSet
            // 
            this.buttonColorSet.Location = new System.Drawing.Point(391, 39);
            this.buttonColorSet.Name = "buttonColorSet";
            this.buttonColorSet.Size = new System.Drawing.Size(75, 23);
            this.buttonColorSet.TabIndex = 2;
            this.buttonColorSet.Text = "Set color";
            this.buttonColorSet.UseVisualStyleBackColor = true;
            this.buttonColorSet.Click += new System.EventHandler(this.buttonColorSet_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(298, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Y:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "X:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Set position of place that will change color:";
            // 
            // textBoxColorY
            // 
            this.textBoxColorY.Location = new System.Drawing.Point(321, 41);
            this.textBoxColorY.Name = "textBoxColorY";
            this.textBoxColorY.Size = new System.Drawing.Size(54, 20);
            this.textBoxColorY.TabIndex = 1;
            // 
            // textBoxColorX
            // 
            this.textBoxColorX.Location = new System.Drawing.Point(246, 41);
            this.textBoxColorX.Name = "textBoxColorX";
            this.textBoxColorX.Size = new System.Drawing.Size(46, 20);
            this.textBoxColorX.TabIndex = 0;
            // 
            // labelXY
            // 
            this.labelXY.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelXY.AutoSize = true;
            this.labelXY.Location = new System.Drawing.Point(3, 0);
            this.labelXY.Name = "labelXY";
            this.labelXY.Size = new System.Drawing.Size(35, 13);
            this.labelXY.TabIndex = 3;
            this.labelXY.Text = "label2";
            // 
            // buttonCreatePreset
            // 
            this.buttonCreatePreset.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCreatePreset.Location = new System.Drawing.Point(174, 246);
            this.buttonCreatePreset.Name = "buttonCreatePreset";
            this.buttonCreatePreset.Size = new System.Drawing.Size(140, 47);
            this.buttonCreatePreset.TabIndex = 7;
            this.buttonCreatePreset.Text = "Create preset";
            this.buttonCreatePreset.UseVisualStyleBackColor = true;
            this.buttonCreatePreset.Click += new System.EventHandler(this.buttonCreatePreset_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 354);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(493, 343);
            this.Name = "Form1";
            this.Text = "Auto ready up clicker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage4.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColorDetected)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerXY;
        private System.Windows.Forms.Button buttonRemoveAll;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ComboBox comboBoxPresets;
        private System.Windows.Forms.TextBox textBoxPresetName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button buttonClickReset;
        private System.Windows.Forms.Button buttonClickSet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelChosenPreset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBoxClickY;
        private System.Windows.Forms.TextBox textBoxClickX;
        private System.Windows.Forms.Button buttonColorReset;
        private System.Windows.Forms.PictureBox pictureBoxColorDetected;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonColorSet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxColorY;
        private System.Windows.Forms.TextBox textBoxColorX;
        private System.Windows.Forms.Label labelXY;
        private System.Windows.Forms.Button buttonCreatePreset;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

