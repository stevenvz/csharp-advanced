using System;

namespace L13_Exception_Handling
{
    public class YouTubeException : Exception
    {
        public YouTubeException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}