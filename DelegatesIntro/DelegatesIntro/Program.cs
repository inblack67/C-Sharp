using System;

namespace DelegatesIntro
{
    public class Photo
    {

    }

    public class PhotoFilters
    {
        public void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("Applying Brightness...");
        }

        public void ApplyContrast(Photo photo)
        {
            Console.WriteLine("Applying Contrast...");
        }

        public void Resize(Photo photo)
        {
            Console.WriteLine("Resizing...");
        }
    }

    public class PhotoProcessor
    {
        public delegate void PhotoFilterHandler(Photo photo);

        public void Process(string path,PhotoFilterHandler photoFilterHandler)
        {
            var photo = new Photo();
            photoFilterHandler(photo);
        }

        // built in delegate Action<>

        public void Process2(string path, Action<Photo> action)
        {
            var photo = new Photo();
            action(photo);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var photo = new Photo();
            var photofilters = new PhotoFilters();
            var photoprocessor = new PhotoProcessor();

            PhotoProcessor.PhotoFilterHandler filterHandler = photofilters.ApplyBrightness;

            filterHandler += photofilters.ApplyContrast;

            filterHandler += RemoveRedEye;  // even our custome method is added without redeploying anythang

            photoprocessor.Process("path",filterHandler);

            Console.WriteLine();

            // inbuilt delegate -> Action
            Console.WriteLine("Action The Custom one -> ");

            Action<Photo> customDelegate = photofilters.ApplyBrightness;
            customDelegate += photofilters.ApplyContrast;
            customDelegate += RemoveRedEye;

            photoprocessor.Process2("path",customDelegate);

        }

        static void RemoveRedEye(Photo photo)
        {
            Console.WriteLine("Removing the red eye");
        }
    }
}
