using System.Text.RegularExpressions;

namespace Jeeja_ImageLabeller
{
    public partial class MainWindow : Form
    {

        string imagesLocation;
        string classesLocation;
        string labelsLocation;
        Graphics g;

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

            g = imagePanel.CreateGraphics();
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

        private void textBoxGoto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                imageSelector.imgIndex = Convert.ToInt32(textBoxGoto.Text);
            }
        }
    }
}