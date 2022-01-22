using System.Drawing;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Jeeja_ImageLabeller
{
    public partial class MainWindow : Form
    {

        string imagesLocation;
        string classesLocation;
        string labelsLocation;
        Graphics g;
        Bitmap bmp;

        bool p1Captured = false;

        int[] p1;

        ImageSelector imageSelector;

        List<string> images;

        public MainWindow()
        {

            InitializeComponent();

            listBoxClass.SelectedIndex = 0;
            imagesLocation = ".";
            classesLocation = ".";
            labelsLocation = ".";
            images = new List<string>(Directory.GetFiles("."));

        }

        public void DrawRectangle(Pen pen, Graphics g, int x1, int y1, int x2, int y2)
        {
            g.DrawLine(pen, x1, y1, x1, y2);
            g.DrawLine(pen, x1, y1, x2, y1);
            g.DrawLine(pen, x2, y2, x1, y2);
            g.DrawLine(pen, x2, y2, x2, y1);
        }

        private void loadListBox()
        {
            if (File.Exists(classesLocation))
            {
                string[] classes = File.ReadAllLines(classesLocation);
                listBoxClass.Items.Clear();
                foreach (string item in classes) {
                    listBoxClass.Items.Add(item);
                }
            }
        }

        private void autosaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            autosaveToolStripMenuItem.Checked = 
                autosaveToolStripMenuItem.Checked ? false : true;
        }

        private void drawCrosshairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawCrosshairToolStripMenuItem.Checked =
                drawCrosshairToolStripMenuItem.Checked ? false : true;
        }

        private void loadImagesFromToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowDialog();
            imagesLocation = folderBrowserDialog.SelectedPath;
            
            imageSelector = new ImageSelector(imagesLocation);

            if (images.Count() > 0)
            {
                DrawImage(imageSelector.curImage);
            }
            else
            {
                labelImageCount.Text = "Select a folder to load images";
            }
            
        }

        public void DrawImage(Image image) {
            labelImageCount.Text = $"Image {imageSelector.imgIndex+1} of {imageSelector.ImagesCount()}";
            g.DrawImage(image, 0, 0);
            DrawZones();
        }

        public void DrawZones()
        {
            foreach (int[] pos in imageSelector.Rectangles)
            {
                int x1 = pos[0];
                int y1 = pos[1];
                int x2 = pos[2];
                int y2 = pos[3];

                Pen pen = new Pen(Color.Black, 3);

                DrawRectangle(pen, g, x1, y1, x2, y2);
            }
        }

        private void saveLabelsToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowDialog();
            labelsLocation = folderBrowserDialog.SelectedPath;
            MessageBox.Show(labelsLocation);
        }

        private void loadClassesFromToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "(*.txt)|*.txt";
            openFileDialog.ShowDialog();
            classesLocation = openFileDialog.FileName;
            loadListBox();
        }

        private void imagePanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            DrawImage(imageSelector.GetNextImage());
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            DrawImage(imageSelector.GetPrevImage());
        }

        private void buttonGoto_Click(object sender, EventArgs e)
        {
            try
            {
                imageSelector.imgIndex = Convert.ToInt32(textBoxGoto.Text) - 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error! {ex.Message}");
                return;
            }

            DrawImage(imageSelector.curImage);
        }

        int lastX = 0;
        int lastY = 0;
        private void imagePanel_MouseLeave(object sender, EventArgs e)
        {
            if (drawCrosshairToolStripMenuItem.Checked)
            {
                imagePanel.Update();
                //imagePanel.Invalidate();
            }
            if (imageSelector != null)
            {
                //imagePanel.Update();
                DrawImage(imageSelector.curImage);
                
            }
        }

        private void imagePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (imageSelector != null)
            {
                DrawImage(imageSelector.curImage);
            }

            if (drawCrosshairToolStripMenuItem.Checked)
            {
                Region r = new Region();
                r.Union(new Rectangle(0, lastY, imagePanel.Width, 1));
                r.Union(new Rectangle(lastX, 0, 1, imagePanel.Height));
                //imagePanel.Invalidate(r);
                imagePanel.Update();
                //Graphics g = Graphics.FromHwnd(imagePanel.Handle);

                g.DrawLine(Pens.Black, 0, e.Y, imagePanel.Width, e.Y);
                g.DrawLine(Pens.Black, e.X, 0, e.X, imagePanel.Height);
                lastX = e.X;
                lastY = e.Y;
            }

            if (p1Captured)
            {
                Pen pen = new Pen(Color.Black, 3);
                g.DrawLine(pen, p1[0], p1[1], p1[0], e.Y);
                g.DrawLine(pen, p1[0], p1[1], e.X, p1[1]);
                g.DrawLine(pen, e.X, e.Y, p1[0], e.Y);
                g.DrawLine(pen, e.X, e.Y, e.X, p1[1]);

                // rect width = Math.Abs(e.X-p[0]);
                // rect height = Math.Abs(e.Y-p[1]);
            }
            imagePanel.Refresh();
        }

        private void imagePanel_Click(object sender, EventArgs e)
        {
            if (imageSelector != null)
            {
                MouseEventArgs me = (MouseEventArgs)e;
                Point coordinates = me.Location;
                if (!p1Captured)
                {
                    p1 = new int[] { me.X, me.Y };
                    p1Captured = true;
                }
                else
                {
                    imageSelector.AddRectangle(p1[0], p1[1], me.X, me.Y);
                    p1Captured = false;
                }
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(imagePanel.Width, imagePanel.Height);
            g = Graphics.FromImage(bmp);
            imagePanel.Image = bmp;
            imagePanel.Refresh();
        }
    }
}