using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L8_Events
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() {Title = "Video 1"};
            var videoEncoder = new VideoEncoder(); //publisher
            var mailService = new MailService(); //subscriber
            var messageService = new MessageService(); //subscriber

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded; //hook up subscriptions before calling Encode method below
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

            videoEncoder.Encode(video);
        }
    }
}
