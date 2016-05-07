using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace BananaSplit
{
    public partial class frmMain : Form
    {
        private string filePath = "";
        private string fileName = "";
        private string fullPath = "";
        private TimeSpan splitInterval;
        private int expectedCompletion = 0;
        private int completedJobs = 0;

        public frmMain()
        {
            InitializeComponent();

            /*filePath = @"C:\Users\Tom Dobbelaere\Videos";
            fileName = "GTAV_2243.mp4";
            fullPath = filePath + "\\" + fileName;

            btnSplit_Click(null, null);
            btnViewLog_Click(null, null);*/
        }

        private void btnViewLog_Click(object sender, EventArgs e)
        {
            this.Width = (this.Width < 730) ? 730 : 430;
        }

        private void Log(string text, bool newline = true)
        {

            if (rtbLog.InvokeRequired)
            {
                rtbLog.Invoke((Action)delegate ()
                {
                    rtbLog.AppendText(text + ((newline) ? Environment.NewLine : ""));
                });
            }
            else
            {
                rtbLog.AppendText(text + ((newline) ? Environment.NewLine : ""));
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (ofdVideoFile.ShowDialog() == DialogResult.OK)
            {
                filePath = Path.GetDirectoryName(ofdVideoFile.FileName);
                fileName = Path.GetFileName(ofdVideoFile.FileName);
                fullPath = filePath + "\\" + fileName;

                lblCurrFile.Text = fullPath;
                ttFile.SetToolTip(lblCurrFile, fullPath);

                lblStartsplitInfo.Text = lblStartsplitInfo.Tag.ToString().Replace("%filename%", fileName);
            }
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            rtbLog.Clear();

            string trimmedHours = txtHours.Text.Split(' ')[0];
            string trimmedMinutes = txtMinutes.Text.Split(' ')[0];
            string trimmedSeconds = txtSeconds.Text.Split(' ')[0];

            int hours, minutes, seconds;

            hours = int.Parse(trimmedHours);
            minutes = int.Parse(trimmedMinutes);
            seconds = int.Parse(trimmedSeconds);

            splitInterval = new TimeSpan(hours, minutes, seconds);

            Log("=== New job for " + fileName + " ===");
            Log(string.Format("Split every {0} hours, {1} minutes and {2} seconds", 
                                  splitInterval.Hours.ToString(), 
                                  splitInterval.Minutes.ToString(), 
                                  splitInterval.Seconds.ToString()));

            Log("Probing video length.. ", false);

            string output = ffmpeg("-i \"" + fullPath + "\"");
            string[] duration = Regex.Match(output, "Duration: [0-9][0-9]:[0-9][0-9]:[0-9][0-9]").Value.Split(' ')[1].Split(':');

            TimeSpan maxTime = new TimeSpan(int.Parse(duration[0]), int.Parse(duration[1]), int.Parse(duration[2]));

            Log(string.Format("{0}:{1}:{2}",
                                  maxTime.Hours.ToString("D2"),
                                  maxTime.Minutes.ToString("D2"),
                                  maxTime.Seconds.ToString("D2")));

            TimeSpan currentTime = new TimeSpan(0, 0, 0);

            Directory.CreateDirectory(fullPath + @"_split");

            TimeSpan measureTimes = new TimeSpan(0, 0, 0);

            expectedCompletion = 0;
            while (measureTimes < maxTime)
            {
                measureTimes += splitInterval;
                expectedCompletion++;
            }

            btnSplit.Enabled = false;
            btnSplit.Text = "Please wait...";

            completedJobs = 0;
            int number = 1;
            while (currentTime < maxTime)
            {
                TimeSpan startTime = currentTime;

                /*Log(string.Format("ffmpeg split {0}:{1}:{2} to ",
                                  currentTime.Hours.ToString("D2"),
                                  currentTime.Minutes.ToString("D2"),
                                  currentTime.Seconds.ToString("D2")), false);*/

                currentTime += splitInterval;

                /*Log(string.Format("{0}:{1}:{2}...",
                                  currentTime.Hours.ToString("D2"),
                                  currentTime.Minutes.ToString("D2"),
                                  currentTime.Seconds.ToString("D2")), false);*/

                string[] args = { "\"" + fullPath + "\"",
                                  startTime.Hours.ToString("D2"), startTime.Minutes.ToString("D2"), startTime.Seconds.ToString("D2"),
                                  splitInterval.Hours.ToString("D2"), splitInterval.Minutes.ToString("D2"), splitInterval.Seconds.ToString("D2"),
                                  "\"" + fullPath + @"_split\" + fileName.Split('.')[0] + "_" + number.ToString() + "." + fileName.Split('.')[1] + "\""};

                Task newTask = new Task(() => {
                    TimeSpan myTime = startTime;
                    ffmpeg(string.Format("-y -i {0} -codec copy -ss {1}:{2}:{3} -t {4}:{5}:{6} {7}", args));
                    Log(string.Format("Split job for {0}:{1}:{2} complete!",
                                        myTime.Hours.ToString("D2"),
                                        myTime.Minutes.ToString("D2"),
                                        myTime.Seconds.ToString("D2")));
                    completedJobs++;

                    if (btnSplit.InvokeRequired)
                    {
                        btnSplit.Invoke((Action)delegate ()
                        {
                            btnSplit.Text = completedJobs.ToString() + "/" + expectedCompletion.ToString();
                        });
                    }
                    else
                    {
                        btnSplit.Text = completedJobs.ToString() + "/" + expectedCompletion.ToString();
                    }

                    if (pbrProgress.InvokeRequired)
                    {
                        pbrProgress.Invoke((Action)delegate ()
                        {
                            pbrProgress.Value = (int) (completedJobs / (float) expectedCompletion * 100.0);
                        });
                    }
                    else
                    {
                        pbrProgress.Value = (int)(completedJobs / (float)expectedCompletion * 100.0);
                    }

                    if (completedJobs == expectedCompletion)
                    {
                        MessageBox.Show("Done!");
                        Log("All done!");

                        if (btnSplit.InvokeRequired)
                        {
                            btnSplit.Invoke((Action)delegate ()
                            {
                                btnSplit.Enabled = true;
                                btnSplit.Text = "Banana split!";
                            });
                        }
                        else
                        {
                            btnSplit.Enabled = true;
                            btnSplit.Text = "Banana split!";
                        }
                    }
                });
                newTask.Start();

                number += 1;
            }
        }

        private string ffmpeg(string arguments)
        {
            string outstr = "";

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.FileName = "incbin/ffmpeg.exe";
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;
            startInfo.Arguments = arguments;

            Process p = Process.Start(startInfo);

            outstr += p.StandardError.ReadToEnd();
            outstr += p.StandardOutput.ReadToEnd();

            return outstr;
        }
    }
}
