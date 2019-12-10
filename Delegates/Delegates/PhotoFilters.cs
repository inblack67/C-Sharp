using System;
namespace Delegates
{
    public class PhotoFilters
    {
        public void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("Apply Brightness");
        }

        public void ApplyContrast(Photo photo)
        {
            Console.WriteLine("Apply Contrast");
        }

        public void ApplyResize(Photo photo)
        {
            Console.WriteLine("Resizing");
        }
    }
}
