using System;
using System.Threading;

namespace Events
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }

    public class Video
    {
        public string Title { get; set; }

    }

    public class VideoEncoder
    {
        // 1) Defining a delegate
        //public delegate void VideoEncodedEventHandler(object source, EventArgs args);
        public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);

        // built in even handler
        // EventHandler or EventHandler<EventArgs>

        // 2) Defining an event based on the delegate
        public event VideoEncodedEventHandler VideoEncoded;
        //public event EvenHandler<VideoEventArgs> VideoEncoded;

        public void Encode(Video video) // this must send the video data to the event that follows
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000); // delaying for 3 seconds
            OnVideoEncoded(video);
        }

        // Raising the damn event
        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)     
            {
                VideoEncoded(this, new VideoEventArgs() { Video = video}); // Where is the video ?
                                                        // here is the video.
            }
        }
    }

    public class MailService // event handler this is
    {
        // confirming the delegate signature

        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("MailService: Sending mails..." + e.Video.Title);
        }
    }

    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("MessageService: Sending messages..." + e.Video.Title);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Video 1" };
            var videoEncoder = new VideoEncoder(); // publisher
            var mailService = new MailService();// subscriber
            var messageService = new MessageService();

            // making the subscription first
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;    // not calling, just a reference

            // making another subscription
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;


            videoEncoder.Encode(video);

            // subscribers added without making single change in VE class

            // must send the data...

        }
    }
}
