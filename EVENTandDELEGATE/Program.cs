using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVENTandDELEGATE
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video()
            {
                Title = "video 1"
            };

            var videoencoder = new VideoEncoder();  //publisher
            var mailservice = new MailService();   //subscriber
            var messageservice = new MessageService(); // subscriber

            videoencoder.viderEncoder += mailservice.OnVideoEncoder;

            videoencoder.viderEncoder += messageservice.OnVideoEncoder;

            videoencoder.Encode(video);

   
            Console.ReadKey();
        }
    }
}


