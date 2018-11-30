using System;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;

namespace ImageCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            var image = new Image<Rgba32>(100, 200);
            Console.WriteLine($"Image size: {image.Width}x{image.Height}");
        }
    }
}
