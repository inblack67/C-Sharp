using System;
namespace Delegates
{
    public class PhotoProcessor
    {
        public delegate void PhotoFilterHandler(Photo photo);
        public void Process(string path, PhotoFilterHandler filehandler)
        {
            Console.WriteLine("Processing");
            filehandler(new Photo());
        }

    }

}






/*
  public void Process(string path)
        {
            var filters = new PhotoFilters();
            filters.ApplyBrightness(new Photo());
        }

    */