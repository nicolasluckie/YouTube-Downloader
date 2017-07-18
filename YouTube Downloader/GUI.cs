using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExtractor;
using System.Threading;
using System.Diagnostics;

namespace YouTube_Downloader {
    public partial class GUI : Form {
        public GUI() {
            InitializeComponent();
        }

        private void GUI_Load(object sender, EventArgs e) {
            resolution.SelectedIndex = 1;
        }

        private void startBtn_Click(object sender, EventArgs e) {

            progressBar.Minimum = 0;
            progressBar.Maximum = 100;

            IEnumerable<VideoInfo> videos = DownloadUrlResolver.GetDownloadUrls(vidUrl.Text);

            VideoInfo video = videos.First(p => p.VideoType == VideoType.Mp4 && p.Resolution == Convert.ToInt32(resolution.Text));

            if (video.RequiresDecryption) {
                Console.WriteLine("Decryption required!");
                DownloadUrlResolver.DecryptDownloadUrl(video);
            }

            VideoDownloader downloader = new VideoDownloader(video, "video.mp4");

            downloader.DownloadProgressChanged += Downloader_DownloadProgressChanged;
            downloader.DownloadFinished += Downloader_DownloadFinished;

            Thread thread = new Thread(() => { downloader.Execute(); }) { IsBackground = true };
            thread.Start();
        }

        private void Downloader_DownloadFinished(object sender, EventArgs e) {
            Invoke(new MethodInvoker(delegate () {
                vidUrl.Text = "Download complete.";
                Process process = new Process();
                process.Exited += Process_Exited;
                process.StartInfo.FileName = "CMD.exe";
                process.StartInfo.Arguments = "/C ffmpeg -i video.mp4 " + songName.Text + ".mp3";
                process.EnableRaisingEvents = true;
                process.Start();
                //Process.Start("CMD.exe", "/C ffmpeg -i video.mp4 " + songName.Text + ".mp3");
                //Process.Start("CMD.exe", "/C del video.mp4");
            }));            
        }

        private void Process_Exited(object sender, EventArgs e) {
            Process.Start("CMD.exe", "/C del video.mp4");
            Application.Exit();
        }

        private void Downloader_DownloadProgressChanged(object sender, ProgressEventArgs e) {
            Invoke(new MethodInvoker(delegate () {
                progressBar.Value = (int)e.ProgressPercentage;
                progText.Text = $"{string.Format("{0:0.##}", e.ProgressPercentage)}";
                progressBar.Update();
            }));
        }
    }
}
