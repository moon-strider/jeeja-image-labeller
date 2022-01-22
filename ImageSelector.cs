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

        public List<string> images;

        private List<List<int[]>> rectangles;
        private List<List<string>> classI;

        private Image currentImage;

        int imageWidth;
        int imageHeight;

        public Image curImage { 
            get 
            {
                SetResizeImage(Image.FromFile(images[imgIndex]));
                return currentImage;
            } 
        }

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

        public List<List<int[]>> Rectangles
        {
            get { return rectangles; }
        }

        public List<List<string>> ClassI
        {
            get { return classI; }
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

        public void AddClass(string str)
        {
            classI[imgIndex].Add(str);
        }

        public void AddRectangle(int x1, int y1, int x2, int y2)
        {
            rectangles[imgIndex].Add(new int[] { x1, y1, x2, y2 });
        }

        public void InitRectangles() 
        {
            rectangles.Add(new List<int[]>());
        }

        public void InitClasses() {
            classI.Add(new List<string>());
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
            classI = new List<List<string>>();
            rectangles = new List<List<int[]>>();
            images = new List<string>(Directory.GetFiles(imagesPath));
            imgIndex = 0;
            Regex regex = new Regex(@".*\.(?i)(gif|jpe?g|tiff?|png|webp|bmp)$(?-i)");

            for (int i = images.Count() - 1; i >= 0; --i)
            {
                if (!regex.IsMatch(images[i]))
                {
                    images.Remove(images[i]);
                }
            }

            for (int i = 0; i < images.Count(); i++)
            {
                InitRectangles();
                InitClasses();
            }

            Image img = Image.FromFile(images.First());

            SetResizeImage(img);
        }
    }
}
