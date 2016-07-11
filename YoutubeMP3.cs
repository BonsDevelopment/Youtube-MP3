using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Youtube_MP3.Elements;
using Youtube_MP3.Attributes;
using Youtube_MP3.Downloader;
using System.IO;

namespace Youtube_MP3
{
    public class YoutubeMP3
    {
        private string downloadLocation;
        private string apiLink;
        Downloader.Downloader d1 = new Downloader.Downloader();
        public YoutubeMP3(string outPutFileLocation, string ApiLink)
        {
            
            downloadLocation = outPutFileLocation;
            apiLink = ApiLink;
        }

        public void StartDownload()
        {

            if (Downloader.Downloader.value != DownloadState.InProgess)
            {

                d1.StartDownload(downloadLocation, apiLink);
            }
            
        }

        public string GetPercentage()
        {
            return Percentage.GetPercent;
        }

        public string GetLength()
        {
            return d1.ReturnLength();
        }
        public DownloadState GetState()
        {
            return Downloader.Downloader.value;
        }

        public static string YouTubeSearch(string VideoName)
        {
            return SearchData.YTPostData(VideoName);
        }
    }
}
