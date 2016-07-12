using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Youtube_MP3.Elements;
using Youtube_MP3.Attributes;
using System.IO;

namespace Youtube_MP3.Downloader
{
    public class Downloader
    {

        private string dlLocation;
        private string f;
        static public DownloadState value = DownloadState.Neutral;

        public void StartDownload(string outputFileLocation, string ytAPILink)
        {
            
                value = DownloadState.Neutral;
                dlLocation = outputFileLocation;
                using (WebClient wc = new WebClient())
                {
                    f = wc.DownloadString("https://www.youtubeinmp3.com/fetch/?format=text&video=" + ytAPILink);
                 
                    wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(webClient_DownloadChanged);
                    wc.DownloadDataCompleted += DownloadDataCompleted;
                    value = DownloadState.InProgess;
                    wc.DownloadDataAsync(new Uri(StaticLink.GetLink(f)));


                }
           
        }

        public string ReturnLength()
        {
            return StaticLength.GetLength(f);
        }

        private void DownloadDataCompleted(object sender, DownloadDataCompletedEventArgs e)
        {
            using (MemoryStream ms = new MemoryStream(e.Result))
            {

                if (ms.Length > 0)
                {
                    
                    File.WriteAllBytes(dlLocation + StaticTitle.GetTitle(f).Replace("<br/>", "") + ".mp3", ms.ToArray());
                    value = DownloadState.Finished;
                }

            }
        }

        private void webClient_DownloadChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            int bytesIn, totalBytes;

            if (!Int32.TryParse(e.BytesReceived.ToString(), out bytesIn) ||
                !Int32.TryParse(e.TotalBytesToReceive.ToString(), out totalBytes)) { return; }


            int mb_in = (bytesIn / 1024) / 1024;
            int mb_total = (totalBytes / 1024) / 1024;

            int kb_in = bytesIn / 1024;
            int kb_total = totalBytes / 1024;

            KB.GetKB = kb_in;
            KB.GetKBTotal = kb_total;
            //Console.WriteLine(mb_in + "mb / " + mb_total + "mb");

            Percentage.GetPercent = e.ProgressPercentage;
        }
    }

    
}
