using System;
using System.Collections.Generic;

namespace L13_Exception_Handling
{
    public class YouTubeApi
    {
        public List<Video> GetVideos(string user)
        {
            try
            {
                //access YouTube web service, read data, create list of video objects
                throw new Exception("Oops some low-level YouTube error.");
            }
            catch (Exception ex)
            {
                throw new YouTubeException("Could not fetch the videos from YouTube.", ex);
            }

            return new List<Video>();
        }
    }
}