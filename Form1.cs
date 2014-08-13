using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using Microsoft.Win32;
using System.Threading;

namespace WebmShitter
{
    public partial class Form1 : Form
    {
        bool isProcessing = false;
        string cmd = "-i ";
        string outFile = "";
        public Thread thread = null;
        string genName = "";


        delegate void SetTitleCallback(string text);
        delegate void SetProcessingCallback(bool value);

        Process proc;

        private void SetTitle(string text)
        {
            if (this.InvokeRequired)
            {
                SetTitleCallback d = new SetTitleCallback(SetTitle);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.Text = text;
            }
        }

        private void SetThread(bool value)
        {
            if (this.InvokeRequired)
            {
                SetProcessingCallback d = new SetProcessingCallback(SetThread);
                this.Invoke(d, new object[] { value });
            }
            else
            {
                this.isProcessing = value;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] FileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            this.FileName.Text = FileList[0];
            genName = gen_Name();
            outFile = Directory.GetCurrentDirectory() + "\\output\\" + genName + ".webm";
            created.Text = "Current file: " + genName;
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private string gen_Name()
        {
            string[] lines = File.ReadAllLines(Directory.GetCurrentDirectory() + "\\bin\\" + "list");
            Random rand = new Random();
            string line = lines[rand.Next(lines.Length)];
            string nline = "";
            for (int i = 0; i <= 1; i++)
            {
                while (line.Contains(nline))
                {
                    rand = new Random();
                    nline = lines[rand.Next(lines.Length)];
                }
                line += nline;
            }
            return line;
        }
        private bool retard_Check()
        {
            if (FileName.Text == "" || FileName.Text == "Drag and drop a file" || Start.Text == "" || End.Text == "" || Start.Text == "00:00:00.000" || End.Text == "00:00:00.000")
            {
                return false;
            }
            return true;
        }

        private void ProcessFile(string start, string end, string filename, string thr, string qual)
        {
                string scaler = "";
                this.Invoke((MethodInvoker)delegate()
                {
                    scaler = Res.Text;
                });

                qual += "k";

                    string args = "-i " + '"' + FileName.Text + '"' + " -y -ss " + Start.Text + " -to " + End.Text + " -codec:v libvpx -quality good -cpu-used 0 -qmin 0 -qmax 50 ";
                    args += "-b:v " + qual + " -maxrate " + qual + " -bufsize " + qual + " -vf scale=-1:" + scaler;

                    bool audio = false;
                    this.Invoke((MethodInvoker)delegate()
                    {
                        audio = Audio.Checked;
                    });

                    if (!audio)
                    {
                        args += " -an";
                    }

                    args += " -threads " + thr + " " + '"' + outFile + '"';

                    SetTitle(".WEBM Maker - Status: Processing (This might take a while) ...");

                    proc = new Process
                    {
                        StartInfo = new ProcessStartInfo
                        {
                            FileName = Directory.GetCurrentDirectory() + "\\bin" + "\\ffmpeg.exe",
                            Arguments = args,
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                            CreateNoWindow = true
                        }
                    };

                    proc.Start();
                    proc.WaitForExit();
          

                SetTitle(".WEBM Maker - Status: Done ...");

                Thread.Sleep(1500);

                this.Invoke((MethodInvoker)delegate()
                {
                    if (Preview.Checked)
                    {
                        System.Diagnostics.Process.Start(@outFile);
                    }
                });

          
                SetTitle(".WEBM Maker - Status: Idle");
                SetThread(false);
       }

        private void CropFile(string xout, string yout, string xcut, string ycut, string thr, string qual)
        {
            qual += "k";
            string filename = Directory.GetCurrentDirectory() + "\\output\\" + "Cropped" + genName + ".webm";

            string args = "-i " + '"' + outFile + '"' + " -y -vf crop=" + xout + ":" + yout + ":" + xcut + ":" + ycut + " -vcodec libvpx -b:v " + qual + " " + '"' + filename + '"';
            //MessageBox.Show(args);

            //-i something.webm -vf crop=1280:450:0:110 -vcodec libvpx -b:v 8000k test.webm

            SetTitle(".WEBM Maker - Status: Processing (This might take a while) ...");

            proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = Directory.GetCurrentDirectory() + "\\bin" + "\\ffmpeg.exe",
                    Arguments = args,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };

            proc.Start();
            proc.WaitForExit();

            SetTitle(".WEBM Maker - Status: Done ...");

            Thread.Sleep(1500);

            this.Invoke((MethodInvoker)delegate()
            {
                if (Preview.Checked)
                {
                    System.Diagnostics.Process.Start(@filename);
                }
            });


            SetTitle(".WEBM Maker - Status: Idle");
            SetThread(false);
        }

        private void make_Click(object sender, EventArgs e)
        {
            if (!File.Exists(FileName.Text))
            {
                MessageBox.Show("Select a file!");
                return;
            }

            if (!isProcessing)
            {
                isProcessing = true;
                thread = new Thread(() => ProcessFile(Start.Text, End.Text, FileName.Text, Thr.Text, Qual.Text));
                thread.Start();
            }
            else
            {
                MessageBox.Show("Already processing - cancel current or wait!");
            }
        }


        private void Cancel_Click(object sender, EventArgs e)
        {
            if (isProcessing)
            {
                proc.Kill();
                thread.Abort();
                SetTitle(".WEBM Maker - Status: Canceled ...");
                
                isProcessing = false;
            }
        }

        private void OpenFolder(object sender, MouseEventArgs e)
        {
            Process.Start(Directory.GetCurrentDirectory() + "\\output\\");
        }

        private void crop_Click(object sender, MouseEventArgs e)
        {
            if (!File.Exists(outFile))
            {
                MessageBox.Show("Create a clip first!");
                return;    
            }

            if (!isProcessing)
            {
                isProcessing = true;
                thread = new Thread(() => CropFile(xout.Text, yout.Text, xcut.Text, ycut.Text, Thr.Text, Qual.Text));
                thread.Start();
            }
            else
            {
                MessageBox.Show("Already processing - cancel current or wait!");
            }
        }

        private void cancel_Click(object sender, MouseEventArgs e)
        {
            if (isProcessing)
            {
                proc.Kill();
                thread.Abort();
                SetTitle(".WEBM Maker - Status: Canceled ...");

                isProcessing = false;
            }
        }

        private void change_Res(object sender, EventArgs e)
        {
            if (Res.SelectedItem == "1080")
            {
                yout.Text = "1080";
                xout.Text = "1920";
                Qual.Text = "8000";
            }

            if (Res.SelectedItem == "720")
            {
                yout.Text = "720";
                xout.Text = "1280";
                Qual.Text = "3500";
            }
        }

    }
}
