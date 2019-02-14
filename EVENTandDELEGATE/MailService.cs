using System;

namespace EVENTandDELEGATE
{
    public class MailService
        {
               public void OnVideoEncoder(object source, VideoEventArg e)
                {
                     Console.WriteLine("MailService: Sending an email .."+ e.Video.Title); 
                }
        }
}


