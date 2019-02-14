using System;

namespace EVENTandDELEGATE
{
    public class MessageService
    {
        public void OnVideoEncoder(object source, VideoEventArg args)
        {
            Console.WriteLine("MessgeSerice: Sending a text message .."+args.Video.Title);
        }
    }
}


