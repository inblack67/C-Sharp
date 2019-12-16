using System;
using System.Collections.Generic;
namespace ExceptionHandling
{
    public class Video
    {

    }

    public class CustomExceptions
    {
        public void GetVideos(string user)
        {
            try
            {
                // Access yt web service
                // read the data
                // create a list of video objects
                throw new Exception("Some low level yt exception occurred");
            }
            catch (Exception ex)
            {
                // log
                throw new CustomException1("Could not fetch the videos",ex);

            }


        }


    }
}
