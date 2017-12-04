﻿using System;

namespace L8_Events
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("MessageService: Sending a text message... " + args.Video.Title);
        }
    }
}