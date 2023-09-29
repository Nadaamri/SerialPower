namespace WindowsFormsApp1
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
            this.comboBoxSerialPorts = new System.Windows.Forms.ComboBox();
            this.bscqn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bdisconnect = new System.Windows.Forms.Button();
            this.bconnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bpoweron = new System.Windows.Forms.Button();
            this.bpoweroff = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bsetvoltage = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guidelineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxSerialPorts
            // 
            this.comboBoxSerialPorts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSerialPorts.FormattingEnabled = true;
            this.comboBoxSerialPorts.Location = new System.Drawing.Point(48, 19);
            this.comboBoxSerialPorts.Name = "comboBoxSerialPorts";
            this.comboBoxSerialPorts.Size = new System.Drawing.Size(112, 21);
            this.comboBoxSerialPorts.TabIndex = 0;
            // 
            // bscqn
            // 
            this.bscqn.Location = new System.Drawing.Point(327, 19);
            this.bscqn.Name = "bscqn";
            this.bscqn.Size = new System.Drawing.Size(75, 23);
            this.bscqn.TabIndex = 1;
            this.bscqn.Text = "Scan";
            this.bscqn.UseVisualStyleBackColor = true;
            this.bscqn.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bdisconnect);
            this.groupBox1.Controls.Add(this.bconnect);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bscqn);
            this.groupBox1.Controls.Add(this.comboBoxSerialPorts);
            this.groupBox1.Location = new System.Drawing.Point(8, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 61);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Communication";
            // 
            // bdisconnect
            // 
            this.bdisconnect.Location = new System.Drawing.Point(247, 19);
            this.bdisconnect.Name = "bdisconnect";
            this.bdisconnect.Size = new System.Drawing.Size(75, 23);
            this.bdisconnect.TabIndex = 7;
            this.bdisconnect.Text = "Disconnect";
            this.bdisconnect.UseVisualStyleBackColor = true;
            this.bdisconnect.Click += new System.EventHandler(this.bdisconnect_Click);
            // 
            // bconnect
            // 
            this.bconnect.Location = new System.Drawing.Point(166, 19);
            this.bconnect.Name = "bconnect";
            this.bconnect.Size = new System.Drawing.Size(75, 23);
            this.bconnect.TabIndex = 6;
            this.bconnect.Text = "Connect";
            this.bconnect.UseVisualStyleBackColor = true;
            this.bconnect.Click += new System.EventHandler(this.bconnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Port";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(144, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(54, 24);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "12";
            // 
            // bpoweron
            // 
            this.bpoweron.Location = new System.Drawing.Point(11, 19);
            this.bpoweron.Name = "bpoweron";
            this.bpoweron.Size = new System.Drawing.Size(121, 42);
            this.bpoweron.TabIndex = 4;
            this.bpoweron.Text = "Power On";
            this.bpoweron.UseVisualStyleBackColor = true;
            this.bpoweron.Click += new System.EventHandler(this.bpoweron_Click);
            // 
            // bpoweroff
            // 
            this.bpoweroff.Location = new System.Drawing.Point(144, 19);
            this.bpoweroff.Name = "bpoweroff";
            this.bpoweroff.Size = new System.Drawing.Size(118, 42);
            this.bpoweroff.TabIndex = 5;
            this.bpoweroff.Text = "Power Off";
            this.bpoweroff.UseVisualStyleBackColor = true;
            this.bpoweroff.Click += new System.EventHandler(this.bpoweroff_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(204, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "V";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bsetvoltage);
            this.groupBox2.Controls.Add(this.bpoweron);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.bpoweroff);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(10, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 113);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Command";
            // 
            // bsetvoltage
            // 
            this.bsetvoltage.Location = new System.Drawing.Point(11, 72);
            this.bsetvoltage.Name = "bsetvoltage";
            this.bsetvoltage.Size = new System.Drawing.Size(121, 24);
            this.bsetvoltage.TabIndex = 9;
            this.bsetvoltage.Text = "Set Voltage";
            this.bsetvoltage.UseVisualStyleBackColor = true;
            this.bsetvoltage.Click += new System.EventHandler(this.bsetvoltage_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Voltage";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "00 V";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(284, 99);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(140, 113);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(433, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guidelineToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // guidelineToolStripMenuItem
            // 
            this.guidelineToolStripMenuItem.Name = "guidelineToolStripMenuItem";
            this.guidelineToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.guidelineToolStripMenuItem.Text = "Guideline";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.CES_LOGO_RGB_1024x326;
            this.pictureBox1.Location = new System.Drawing.Point(318, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(15, 220);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(408, 65);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.voltagetick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 292);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Sharlock Power";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSerialPorts;
        private System.Windows.Forms.Button bscqn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bpoweroff;
        private System.Windows.Forms.Button bpoweron;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bconnect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bsetvoltage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guidelineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bdisconnect;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Timer timer1;
    }
}

