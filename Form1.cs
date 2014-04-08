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

        delegate void SetTitleCallback(string text);
        delegate void SetProcessingCallback(bool value);
  
        private void SetTitle(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
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
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
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
            if (FileName.Text == "" || FileName.Text == "Drag and drop a file" || Start.Text == "" || End.Text == "")
            {
                return false;
            }
            return true;
        }

        private void ProcessFile(string start, string end, string filesize, string filename, string thr, string qual, string x, string y)
        {
            outFile = Directory.GetCurrentDirectory() + "\\output\\" + gen_Name() + ".webm";
            double quality = System.Convert.ToInt64(qual);

            if (filesize != "0")
            {
                do
                {
                    if (File.Exists(outFile))
                    {
                        File.Delete(outFile);
                        SetTitle(".WEBM Maker - Status: Processing (Reducing quality to fit size limit) ...");
                    }

                    qual = quality.ToString().Replace(",", ".") + "M";

                    string args = "-i " + '"' + FileName.Text + '"' + " -ss " + Start.Text + " -to " + End.Text + " -c:v libvpx -crf 4 -b:v " + qual;
                    
                    if(x != "" && y != "")
                    {
                        args += " -vf scale=" + x + ":" + y;
                    }

                    bool audio = false;
                    this.Invoke((MethodInvoker)delegate()
                    {
                        audio = Audio.Checked;
                    });

                    if(!audio)
                    {
                      args += " -an";
                    }
                    
                    bool twopass = false;
                    this.Invoke((MethodInvoker)delegate()
                    {
                        twopass = Twopass.Checked;
                    });

                    if(twopass)
                    {
                        args += " -pass 2";
                    }

                    args += " -threads " + thr + " " + '"' + outFile + '"';

                    SetTitle(".WEBM Maker - Status: Processing (This might take a while) ...");

                    var proc = new Process
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

                    quality -= 0.2;
                    bool value = true;
                    this.Invoke((MethodInvoker)delegate()
                    {
                        value = isProcessing;
                    });

                    if (!value)
                    {
                        SetTitle(".WEBM Maker - Status: Canceling ...");
                        foreach (System.Diagnostics.Process myProc in System.Diagnostics.Process.GetProcesses())
                        {
                            if (myProc.ProcessName == "ffmpeg")
                            {
                                myProc.Kill();
                            }
                        }
                        Thread.Sleep(1500);
                        SetTitle(".WEBM Maker - Status: Idle");
                        return;
                    }
                } while (new FileInfo(outFile).Length > (System.Convert.ToInt64(filesize) * 1000000));
            }
            else {

                qual = quality.ToString().Replace(",", ".") + "M";

                string args = "-i " + '"' + FileName.Text + '"' + " -ss " + Start.Text + " -to " + End.Text + " -c:v libvpx -crf 4 -b:v " + qual;

                if (x != "" && y != "")
                {
                    args += " -vf scale=" + x + ":" + y;
                }

                bool audio = false;
                this.Invoke((MethodInvoker)delegate()
                {
                    audio = Audio.Checked;
                });

                if (!audio)
                {
                    args += " -an";
                }

                bool twopass = false;
                this.Invoke((MethodInvoker)delegate()
                {
                    twopass = Twopass.Checked;
                });

                if (twopass)
                {
                    args += " -pass 2";
                }

                args += " -threads " + thr + " " + '"' + outFile + '"';

                SetTitle(".WEBM Maker - Status: Processing (This might take a while) ...");

                var proc = new Process
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
            }

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
                thread = new Thread(() => ProcessFile(Start.Text, End.Text, filesize.Text, FileName.Text, Thr.Text, Qual.Text, x.Text, y.Text));
                thread.Start();
            }
            else
            {
                MessageBox.Show("Already processing - cancel current or wait!");
            }
        }

        private void Advanced_CheckedChanged(object sender, EventArgs e)
        {
            if (Advanced.Checked)
            {
                panel.Visible = true;
            }
            else {
                panel.Visible = false;
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            if (isProcessing)
            {
                isProcessing = false;
            }
        }

    }
}
