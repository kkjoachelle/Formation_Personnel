using System;
using System.Threading;

namespace EVENTandDELEGATE
{
    public class VideoEventArg : EventArgs
    {
        public Video Video  { get; set; }

    }
    public class VideoEncoder
    {
        //1 Define Delegate ,VideoEventArg vient de la class VideoEventArg qui herite
        // de la classe EventArgs dont la proprieté est de type video venant de la classe video

        //2 Define an Event based on the Delegate
        //3 Raise the Event

        // Define a Delegate 
        /* public delegate void VideoEncoderHandler(Object source, VideoEventArg args);

         // Define an Event based on the Delegate
         public event VideoEncoderHandler viderEncoder;*/
        // ou //

        public event EventHandler<VideoEventArg> viderEncoder; //declaration de l'evenement

        //Raise the Event


        public void Encode(Video video)
        {
            Console.WriteLine("Encoding vidéo .....");
            Thread.Sleep(3000);

            OnVideoEncoder(video);
        }

        protected virtual void OnVideoEncoder(Video video)
        {
            if (viderEncoder !=null)
                viderEncoder(this, new VideoEventArg() { Video = video});
        }

    }
}
