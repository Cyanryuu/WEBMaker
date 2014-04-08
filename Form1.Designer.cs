namespace WebmShitter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.FileName = new System.Windows.Forms.TextBox();
            this.make = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.TextBox();
            this.End = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Preview = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Qual = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Thr = new System.Windows.Forms.TextBox();
            this.filesize = new System.Windows.Forms.TextBox();
            this.Advanced = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.x = new System.Windows.Forms.TextBox();
            this.y = new System.Windows.Forms.TextBox();
            this.Audio = new System.Windows.Forms.CheckBox();
            this.Twopass = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FileName
            // 
            this.FileName.Location = new System.Drawing.Point(6, 19);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(665, 20);
            this.FileName.TabIndex = 0;
            this.FileName.Text = "Drag and drop a file";
            // 
            // make
            // 
            this.make.Location = new System.Drawing.Point(596, 49);
            this.make.Name = "make";
            this.make.Size = new System.Drawing.Size(75, 23);
            this.make.TabIndex = 1;
            this.make.Text = "Make";
            this.make.UseVisualStyleBackColor = true;
            this.make.Click += new System.EventHandler(this.make_Click);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(42, 49);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(74, 20);
            this.Start.TabIndex = 2;
            this.Start.Text = "00:00:00";
            // 
            // End
            // 
            this.End.Location = new System.Drawing.Point(173, 49);
            this.End.Name = "End";
            this.End.Size = new System.Drawing.Size(74, 20);
            this.End.TabIndex = 3;
            this.End.Text = "00:00:00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Start";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Stop";
            // 
            // Preview
            // 
            this.Preview.AutoSize = true;
            this.Preview.Checked = true;
            this.Preview.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Preview.Location = new System.Drawing.Point(432, 51);
            this.Preview.Name = "Preview";
            this.Preview.Size = new System.Drawing.Size(64, 17);
            this.Preview.TabIndex = 8;
            this.Preview.Text = "Preview";
            this.Preview.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Quality (MB)";
            // 
            // Qual
            // 
            this.Qual.Location = new System.Drawing.Point(86, 47);
            this.Qual.Name = "Qual";
            this.Qual.Size = new System.Drawing.Size(74, 20);
            this.Qual.TabIndex = 8;
            this.Qual.Text = "5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Threads";
            // 
            // Thr
            // 
            this.Thr.Location = new System.Drawing.Point(86, 21);
            this.Thr.Name = "Thr";
            this.Thr.Size = new System.Drawing.Size(74, 20);
            this.Thr.TabIndex = 6;
            this.Thr.Text = "1";
            // 
            // filesize
            // 
            this.filesize.Location = new System.Drawing.Point(347, 49);
            this.filesize.Name = "filesize";
            this.filesize.Size = new System.Drawing.Size(51, 20);
            this.filesize.TabIndex = 3;
            this.filesize.Text = "0";
            // 
            // Advanced
            // 
            this.Advanced.AutoSize = true;
            this.Advanced.Location = new System.Drawing.Point(10, 84);
            this.Advanced.Name = "Advanced";
            this.Advanced.Size = new System.Drawing.Size(236, 17);
            this.Advanced.TabIndex = 10;
            this.Advanced.Text = "Show Advanced (Refer to FFMPEG Manual)";
            this.Advanced.UseVisualStyleBackColor = true;
            this.Advanced.CheckedChanged += new System.EventHandler(this.Advanced_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Max size (MB)";
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(596, 78);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 11;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FileName);
            this.groupBox1.Controls.Add(this.Cancel);
            this.groupBox1.Controls.Add(this.make);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Start);
            this.groupBox1.Controls.Add(this.Advanced);
            this.groupBox1.Controls.Add(this.End);
            this.groupBox1.Controls.Add(this.filesize);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Preview);
            this.groupBox1.Location = new System.Drawing.Point(7, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(677, 114);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.Twopass);
            this.panel.Controls.Add(this.Audio);
            this.panel.Controls.Add(this.y);
            this.panel.Controls.Add(this.x);
            this.panel.Controls.Add(this.label6);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.Qual);
            this.panel.Controls.Add(this.Thr);
            this.panel.Controls.Add(this.label4);
            this.panel.Location = new System.Drawing.Point(7, 114);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(677, 78);
            this.panel.TabIndex = 13;
            this.panel.TabStop = false;
            this.panel.Text = "Advanced";
            this.panel.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(170, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Resolution";
            // 
            // x
            // 
            this.x.Location = new System.Drawing.Point(236, 21);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(74, 20);
            this.x.TabIndex = 11;
            // 
            // y
            // 
            this.y.Location = new System.Drawing.Point(236, 47);
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(74, 20);
            this.y.TabIndex = 13;
            // 
            // Audio
            // 
            this.Audio.AutoSize = true;
            this.Audio.Location = new System.Drawing.Point(334, 49);
            this.Audio.Name = "Audio";
            this.Audio.Size = new System.Drawing.Size(53, 17);
            this.Audio.TabIndex = 14;
            this.Audio.Text = "Audio";
            this.Audio.UseVisualStyleBackColor = true;
            // 
            // Twopass
            // 
            this.Twopass.AutoSize = true;
            this.Twopass.Location = new System.Drawing.Point(334, 24);
            this.Twopass.Name = "Twopass";
            this.Twopass.Size = new System.Drawing.Size(58, 17);
            this.Twopass.TabIndex = 15;
            this.Twopass.Text = "2 Pass";
            this.Twopass.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 198);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = ".WEBM Maker - Status: Idle";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox FileName;
        private System.Windows.Forms.Button make;
        private System.Windows.Forms.TextBox Start;
        private System.Windows.Forms.TextBox End;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox Preview;
        private System.Windows.Forms.TextBox filesize;
        private System.Windows.Forms.CheckBox Advanced;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Qual;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Thr;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox panel;
        private System.Windows.Forms.TextBox y;
        private System.Windows.Forms.TextBox x;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox Audio;
        private System.Windows.Forms.CheckBox Twopass;
    }
}

