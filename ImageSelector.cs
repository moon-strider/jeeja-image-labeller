using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Jeeja_ImageLabeller
{
    internal class ImageSelector
    {
        private int imageIndex;

        string imagePath;
        List<string> images;

        private List<int[]> rectangles;

        private Image currentImage;

        int imageWidth;
        int imageHeight;

        public Image curImage { get { return currentImage; } }

        public int imgIndex
        {
            get { return imageIndex; }
            set
            {
                if (value < images.Count() && value >= 0)
                {
                    imageIndex = value;
                }
                else
                {
                    imageIndex = 0;
                }
            }
        }

        public List<int[]> Rectangles
        {
            get { return rectangles; }
        }

        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        public void AddRectangle(int x1, int y1, int x2, int y2)
        {
            rectangles.Add(new int[] { x1, y1, x2, y2 });
        }

        public int ImagesCount() => images.Count();

        public Image GetNextImage()
        {
            imgIndex++;
            SetResizeImage(Image.FromFile(images[imgIndex]));
            return currentImage;
        }

        public Image GetPrevImage()
        {
            imgIndex--;
            SetResizeImage(Image.FromFile(images[imgIndex]));
            return currentImage;
        }

        private void SetResizeImage(Image img)
        {
            imageWidth = img.Width;
            imageHeight = img.Height;

            currentImage = ResizeImage(img, 1054, 526);
        }

        public ImageSelector(string imagesPath)
        {
            rectangles = new List<int[]>();
            images = new List<string>(Directory.GetFiles(imagesPath));
            Regex regex = new Regex(@".*\.(?i)(gif|jpe?g|tiff?|png|webp|bmp)$(?-i)");

            for (int i = images.Count() - 1; i >= 0; --i)
            {
                if (!regex.IsMatch(images[i]))
                {
                    images.Remove(images[i]);
                }
            }

            Image img = Image.FromFile(images.First());

            SetResizeImage(img);
        }
    }
}
