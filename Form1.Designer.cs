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
            this.Cancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Output = new System.Windows.Forms.Button();
            this.Audio = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Res = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.xout = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.yout = new System.Windows.Forms.TextBox();
            this.xcut = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ycut = new System.Windows.Forms.TextBox();
            this.created = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.Start.Text = "00:00:00.000";
            // 
            // End
            // 
            this.End.Location = new System.Drawing.Point(173, 49);
            this.End.Name = "End";
            this.End.Size = new System.Drawing.Size(74, 20);
            this.End.TabIndex = 3;
            this.End.Text = "00:00:00.000";
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
            this.Preview.Location = new System.Drawing.Point(479, 52);
            this.Preview.Name = "Preview";
            this.Preview.Size = new System.Drawing.Size(64, 17);
            this.Preview.TabIndex = 8;
            this.Preview.Text = "Preview";
            this.Preview.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(273, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Bitrate";
            // 
            // Qual
            // 
            this.Qual.Location = new System.Drawing.Point(334, 82);
            this.Qual.Name = "Qual";
            this.Qual.Size = new System.Drawing.Size(121, 20);
            this.Qual.TabIndex = 8;
            this.Qual.Text = "8000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Threads";
            // 
            // Thr
            // 
            this.Thr.Location = new System.Drawing.Point(60, 82);
            this.Thr.Name = "Thr";
            this.Thr.Size = new System.Drawing.Size(74, 20);
            this.Thr.TabIndex = 6;
            this.Thr.Text = "1";
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
            this.groupBox1.Controls.Add(this.created);
            this.groupBox1.Controls.Add(this.Thr);
            this.groupBox1.Controls.Add(this.Output);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Audio);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Res);
            this.groupBox1.Controls.Add(this.FileName);
            this.groupBox1.Controls.Add(this.Cancel);
            this.groupBox1.Controls.Add(this.make);
            this.groupBox1.Controls.Add(this.Start);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.End);
            this.groupBox1.Controls.Add(this.Qual);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Preview);
            this.groupBox1.Location = new System.Drawing.Point(7, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(677, 156);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clip";
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(479, 118);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(192, 23);
            this.Output.TabIndex = 15;
            this.Output.Text = "Open output folder";
            this.Output.UseVisualStyleBackColor = true;
            this.Output.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OpenFolder);
            // 
            // Audio
            // 
            this.Audio.AutoSize = true;
            this.Audio.Location = new System.Drawing.Point(479, 85);
            this.Audio.Name = "Audio";
            this.Audio.Size = new System.Drawing.Size(53, 17);
            this.Audio.TabIndex = 14;
            this.Audio.Text = "Audio";
            this.Audio.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Resolution";
            // 
            // Res
            // 
            this.Res.FormattingEnabled = true;
            this.Res.Items.AddRange(new object[] {
            "1080",
            "720"});
            this.Res.Location = new System.Drawing.Point(334, 49);
            this.Res.Name = "Res";
            this.Res.Size = new System.Drawing.Size(121, 21);
            this.Res.TabIndex = 12;
            this.Res.Text = "1080";
            this.Res.SelectionChangeCommitted += new System.EventHandler(this.change_Res);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.xcut);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.ycut);
            this.groupBox2.Controls.Add(this.xout);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.yout);
            this.groupBox2.Location = new System.Drawing.Point(7, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(677, 84);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Crop";
            // 
            // xout
            // 
            this.xout.Location = new System.Drawing.Point(58, 19);
            this.xout.Name = "xout";
            this.xout.Size = new System.Drawing.Size(74, 20);
            this.xout.TabIndex = 6;
            this.xout.Text = "1920";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "X-Width";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(596, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cancel_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(596, 16);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Crop";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.crop_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Y-Length";
            // 
            // yout
            // 
            this.yout.Location = new System.Drawing.Point(58, 50);
            this.yout.Name = "yout";
            this.yout.Size = new System.Drawing.Size(74, 20);
            this.yout.TabIndex = 8;
            this.yout.Text = "1080";
            // 
            // xcut
            // 
            this.xcut.Location = new System.Drawing.Point(202, 19);
            this.xcut.Name = "xcut";
            this.xcut.Size = new System.Drawing.Size(74, 20);
            this.xcut.TabIndex = 12;
            this.xcut.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(150, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "X-Start";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(150, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Y-Start";
            // 
            // ycut
            // 
            this.ycut.Location = new System.Drawing.Point(202, 50);
            this.ycut.Name = "ycut";
            this.ycut.Size = new System.Drawing.Size(74, 20);
            this.ycut.TabIndex = 14;
            this.ycut.Text = "0";
            // 
            // created
            // 
            this.created.AutoSize = true;
            this.created.Location = new System.Drawing.Point(8, 123);
            this.created.Name = "created";
            this.created.Size = new System.Drawing.Size(60, 13);
            this.created.TabIndex = 16;
            this.created.Text = "Current file:";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 251);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = ".WEBM Maker - Status: Idle";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Qual;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Thr;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox Audio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Res;
        private System.Windows.Forms.Button Output;
        private System.Windows.Forms.Label created;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox xcut;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ycut;
        private System.Windows.Forms.TextBox xout;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox yout;
    }
}

