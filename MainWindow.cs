using System.Drawing;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Jeeja_ImageLabeller
{

    // TODO: ������� ������� ��������� ��� �� ��������� ������ ����, ���� �� ���� ��������
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
            KeyPreview = true;

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

        public float RectangleGetWidth(int x1, int x2)
        {
            return Math.Abs(x2 - x1);
        }

        public float RectangleGetHeight(int y1, int y2)
        {
            return Math.Abs(y2 - y1);
        }

        public float[] RectangleGetCenter(int x1, int y1, int x2, int y2)
        {
            if (x1 < x2 && y1 < y2) { return new float[] { x1 + RectangleGetWidth(x1, x2) / 2, y1 + RectangleGetHeight(y1, y2) / 2 }; }
            if (x1 < x2 && y1 > y2) { return new float[] { x1 + RectangleGetWidth(x1, x2) / 2, y1 - RectangleGetHeight(y1, y2) / 2 }; }
            if (x1 > x2 && y1 < y2) { return new float[] { x1 - RectangleGetWidth(x1, x2) / 2, y1 + RectangleGetHeight(y1, y2) / 2 }; }
            if (x1 > x2 && y1 > y2) { return new float[] { x1 - RectangleGetWidth(x1, x2) / 2, y1 - RectangleGetHeight(y1, y2) / 2 }; }
            return null;
        }

        public string RectangleNormalize(float w, float h, float[] c, float ww, float hh)
        {
            float nW, nH;
            float[] nC;

            nW = w / ww;
            nH = h / hh;
            nC = new float[] { c[0] / ww, c[1] / hh };

#pragma warning disable CS8601
            return $"{nC[0]} {nC[1]} {nW} {nH}";
#pragma warning restore CS8601
        }

        public void SaveLabels()
        {
            string newFileName = Path.ChangeExtension(imageSelector.images[imageSelector.imgIndex], ".txt");
            IEnumerable<string> endFile = newFileName.Split("\\").Reverse();
            string loc = endFile.First();
            string pathToLoc = $"{labelsLocation}\\{loc}";
            if (!File.Exists(pathToLoc))
            {
                using (StreamWriter sw = File.CreateText(pathToLoc))
                {
                    for (int i = 0; i < imageSelector.Rectangles[imageSelector.imgIndex].Count(); i++)
                    {
                        int x1 = imageSelector.Rectangles[imageSelector.imgIndex][i][0];
                        int y1 = imageSelector.Rectangles[imageSelector.imgIndex][i][1];
                        int x2 = imageSelector.Rectangles[imageSelector.imgIndex][i][2];
                        int y2 = imageSelector.Rectangles[imageSelector.imgIndex][i][3];
                        string str = RectangleNormalize(RectangleGetWidth(x1, x2), RectangleGetHeight(y1, y2), RectangleGetCenter(x1, y1, x2, y2), imagePanel.Width, imagePanel.Height);
                        sw.WriteLine($"{imageSelector.ClassI[imageSelector.imgIndex][i]} {str}");
                    }
                }
            }
        }

        private void loadListBox()
        {
            if (File.Exists(classesLocation))
            {
                string[] classes = File.ReadAllLines(classesLocation);
                listBoxClass.Items.Clear();
                foreach (string item in classes) {
                    string noSpaces = item.Replace(" ", "_");
                    listBoxClass.Items.Add(noSpaces);
                }
                listBoxClass.SelectedIndex = 0;
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
            labelImageCount.Text = $"Image {imageSelector.imgIndex + 1} of {imageSelector.ImagesCount()}";
            g.DrawImage(image, 0, 0);
            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
            DrawZones();
        }

        public void DrawZones()
        {
            foreach (int[] pos in imageSelector.Rectangles[imageSelector.imgIndex])
            {
                int x1 = pos[0];
                int y1 = pos[1];
                int x2 = pos[2];
                int y2 = pos[3];

                Pen pen = new Pen(Color.Black, 3);

                DrawRectangle(pen, g, x1, y1, x2, y2);
            }
        }

        public void CtrlZ()
        {
            if (imageSelector != null & imageSelector.Rectangles[imageSelector.imgIndex].Count() > 0)
            {
                imageSelector.Rectangles[imageSelector.imgIndex].
                    RemoveAt(imageSelector.Rectangles[imageSelector.imgIndex].Count() - 1);
                imageSelector.ClassI[imageSelector.imgIndex].
                    RemoveAt(imageSelector.ClassI[imageSelector.imgIndex].Count() - 1);
                imagePanel.Refresh();
            }
        }

        private void saveLabelsToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowDialog();
            labelsLocation = folderBrowserDialog.SelectedPath;
        }

        private void loadClassesFromToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "(*.txt)|*.txt";
            openFileDialog.ShowDialog();
            classesLocation = openFileDialog.FileName;
            loadListBox();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            SaveLabels();
            DrawImage(imageSelector.GetNextImage());
            imagePanel.Refresh();
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            SaveLabels();
            DrawImage(imageSelector.GetPrevImage());
            imagePanel.Refresh();
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
            imagePanel.Refresh();
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

                Pen pen = new Pen(Color.Black, 3);

                g.DrawLine(pen, 0, e.Y, imagePanel.Width, e.Y);
                g.DrawLine(pen, e.X, 0, e.X, imagePanel.Height);
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
            }
            imagePanel.Refresh();
        }

        private void imagePanel_Click(object sender, EventArgs e)
        {
            if (imageSelector != null)
            {
                MouseEventArgs me = (MouseEventArgs)e;
                if (me.Button == MouseButtons.Left)
                {
                    Point coordinates = me.Location;
                    if (!p1Captured)
                    {
                        p1 = new int[] { me.X, me.Y };
                        p1Captured = true;
                    }
                    else
                    {
                        imageSelector.AddRectangle(p1[0], p1[1], me.X, me.Y);
                        imageSelector.AddClass(listBoxClass.SelectedItem.ToString());
                        p1Captured = false;
                    }
                }
                else if (me.Button == MouseButtons.Right)
                {
                    CtrlZ();
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

        private void MainWindow_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            MessageBox.Show("jeja");
            if (e.KeyCode == Keys.D) {
                buttonNext_Click(sender, e);
            }
            if (e.KeyCode == Keys.A) {
                buttonPrev_Click(sender, e);
            }

            if (e.Control && e.KeyCode == Keys.Z)
            {
                CtrlZ();
            }
        }
    }
}