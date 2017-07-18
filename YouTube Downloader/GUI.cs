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
                DownloadUrlResolver.DecryptDownloadUrl(video);
            }

            VideoDownloader downloader = new VideoDownloader(video, @"C:\Users\Nicolas Luckie\Downloads\video.mp4");

            downloader.DownloadProgressChanged += Downloader_DownloadProgressChanged;

            Thread thread = new Thread(() => { downloader.Execute(); }) { IsBackground = true };
            thread.Start();
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
