using System;
using System.Threading;

namespace L8_Events
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }
    public class VideoEncoder
    {
        // 1- define a delegate
        // 2- define an event based on that delegate
        // 3- raise the event

        //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);
        //public event VideoEncodedEventHandler VideoEncoded;
        //simpler version of above using .NET delegate is below:

        public event EventHandler<VideoEventArgs> VideoEncoded; 

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
                VideoEncoded(this, new VideoEventArgs(){Video = video});
        }
    }
}