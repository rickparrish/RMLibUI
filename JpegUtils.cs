using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Text;

namespace RandM.RMLibUI
{
    public class JpegUtils
    {
        static public void ResizeJpegToMaxHeight(string inFileName, string outFileName, int quality, int maxHeight)
        {
            using (Bitmap inBitmap = new Bitmap(inFileName))
            {
                // Bitmap dimensions
                int InWidth = inBitmap.Width;
                int InHeight = inBitmap.Height;

                // Default out bitmap dimensions
                int OutWidth = InWidth;
                int OutHeight = InHeight;

                // Check if we even need to resize (only need to if in bitmap is larger than maxSize)
                if (InHeight > maxHeight)
                {
                    // Calculate width based on max height
                    OutHeight = maxHeight;
                    double Ratio = (double)OutHeight / (double)InHeight;
                    OutWidth = Convert.ToInt32(InWidth * Ratio);
                }

                ResizeJpegToWidthAndHeight(inBitmap, outFileName, quality, OutWidth, OutHeight);
            }
        }

        static public void ResizeJpegToMaxWidth(string inFileName, string outFileName, int quality, int maxWidth)
        {
            using (Bitmap inBitmap = new Bitmap(inFileName))
            {
                // Bitmap dimensions
                int InWidth = inBitmap.Width;
                int InHeight = inBitmap.Height;

                // Default out bitmap dimensions
                int OutWidth = InWidth;
                int OutHeight = InHeight;

                // Check if we even need to resize (only need to if in bitmap is larger than maxSize)
                if (InWidth > maxWidth)
                {
                    // Calculate height based on max width
                    OutWidth = maxWidth;
                    double Ratio = (double)OutWidth / (double)InWidth;
                    OutHeight = Convert.ToInt32(InHeight * Ratio);
                }

                ResizeJpegToWidthAndHeight(inBitmap, outFileName, quality, OutWidth, OutHeight);
            }
        }

        static public void ResizeJpegToMaxWidthOrHeight(string inFileName, string outFileName, int quality, int maxSize)
        {
            using (Bitmap inBitmap = new Bitmap(inFileName))
            {
                // Bitmap dimensions
                int InWidth = inBitmap.Width;
                int InHeight = inBitmap.Height;

                // Default out bitmap dimensions
                int OutWidth = InWidth;
                int OutHeight = InHeight;

                // Check if we even need to resize (only need to if in bitmap is larger than maxSize)
                if ((InWidth > maxSize) || (InHeight > maxSize))
                {
                    // Is it wider than it is tall?
                    if (InWidth >= InHeight)
                    {
                        // Calculate height based on max width
                        OutWidth = maxSize;
                        double Ratio = (double)OutWidth / (double)InWidth;
                        OutHeight = Convert.ToInt32(InHeight * Ratio);
                    }
                    else
                    {
                        // Calculate width based on max height
                        OutHeight = maxSize;
                        double Ratio = (double)OutHeight / (double)InHeight;
                        OutWidth = Convert.ToInt32(InWidth * Ratio);
                    }
                }

                ResizeJpegToWidthAndHeight(inBitmap, outFileName, quality, OutWidth, OutHeight);
            }
        }

        static private void ResizeJpegToWidthAndHeight(Bitmap inBitmap, string outFileName, int quality, int width, int height)
        {
            using (Bitmap OutBitmap = new Bitmap(width, height))
            {
                using (Graphics OutGraphics = Graphics.FromImage(OutBitmap))
                {
                    OutGraphics.SmoothingMode = SmoothingMode.HighQuality;
                    OutGraphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    OutGraphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                    OutGraphics.DrawImage(inBitmap, 0, 0, width, height);
                }

                // Find the image/jpeg codec
                ImageCodecInfo JpegCodecInfo = null;
                foreach (ImageCodecInfo Codec in ImageCodecInfo.GetImageEncoders())
                {
                    if (Codec.MimeType == "image/jpeg")
                    {
                        JpegCodecInfo = Codec;
                        break;
                    }
                }

                // Encoder parameter for image quality
                EncoderParameters EncoderParams = new EncoderParameters(1);
                EncoderParams.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, quality);

                // Save output file
                OutBitmap.Save(outFileName, JpegCodecInfo, EncoderParams);
            }
        }

    }
}
