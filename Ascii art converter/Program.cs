
using System.Drawing;
using System.Text;

namespace Ascii_art_converter
{
    internal class Program
    {
        const string ASCII_CHARS = "@%#*+=-:. ";
        static void Main(string[] args)
        {


        }

        static Bitmap ResizeImage(Bitmap originalImage, int newWidth)
        {
            int originalWidth = originalImage.Width;
            int originalHeight = originalImage.Height;
            double aspectRatio = (double)originalHeight / originalWidth;
            int newHeight = (int)(newWidth * aspectRatio * 0.55);

            return new Bitmap(originalImage, new Size(newWidth, newHeight));
        }

        static Bitmap ToGrayScale(Bitmap originalImage)
        {
            Bitmap grayImage = new Bitmap(originalImage.Width, originalImage.Height);
            for (int y = 0; y < originalImage.Height; y++)
            {
                for (int x = 0; x < originalImage.Width; x++)
                {
                    Color pixelColor = grayImage.GetPixel(x, y);
                    int grayScaleValue = (int)(pixelColor.R * 0.3 + pixelColor.G * 0.59 + pixelColor.B * 0.11);
                    Color grayColor = Color.FromArgb(grayScaleValue, grayScaleValue, grayScaleValue);
                    grayImage.SetPixel(x, y, grayColor);
                }
            }
            return grayImage;
        }

        static string ConvertToAscii(Bitmap image)
        {
            StringBuilder asciiArt = new StringBuilder();
            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color pixelColor = image.GetPixel(x, y);
                    int brightness = pixelColor.R;

                }

            }
        }
