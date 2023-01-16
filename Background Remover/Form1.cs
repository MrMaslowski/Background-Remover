using System.Data.Common;
using System.Windows.Forms;

namespace Background_Remover
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            fLP1.Controls.Add(pictureBox);
        }
        Color bgColor;
        int xPb;
        int yPb;


        private void pictureBox_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            if (data != null)
            {
                var fileNames = data as string[];
                if(fileNames.Length > 0)
                {
                    pictureBox.BackgroundImage = null;
                    pictureBox.BackgroundImage = Properties.Resources.transparant_background_pattern;
                    pictureBox.Image = Image.FromFile(fileNames[0]);
                    pictureBox.Tag = fileNames[0];
                }
                else
                {
                    pictureBox.Image = null;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox.AllowDrop = true;
        }

        private void pictureBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point topleft = PointToScreen(new Point(pictureBox.Left, pictureBox.Top));

            xPb = me.X; //- topleft.X;
            yPb = me.Y; // - topleft.Y;

            if(pictureBox.Image != null)
            {
                var imageBitmap = (Bitmap)pictureBox.Image;
                bgColor = imageBitmap.GetPixel(xPb, yPb);

                //label1.Text = bgColor.ToString();
                label1.Text = "  ";
                label1.BackColor= bgColor;
                pictureBox.Image = imageBitmap;
            }
        }

        private void rmBg_Click(object sender, EventArgs e)
        {
            if(pictureBox.Image != null)
            {
                int diff = tbRange.Value;
                var imageBitmap = (Bitmap)pictureBox.Image;

                for (int column = 0; column < imageBitmap.Width; column++)
                {
                    for (int row = 0; row < imageBitmap.Height; row++)
                    {
                        if (areColorsClose(imageBitmap.GetPixel(column, row), bgColor, diff)) //imageBitmap.GetPixel(column, row).Equals(bgColor))
                        {
                            imageBitmap.SetPixel(column, row, Color.Transparent);
                        }
                    }
                }
                pictureBox.Image = imageBitmap;
            }
        }
        private bool areColorsClose(Color currC, Color compC, int diff)
        {
            int r = (int)currC.R - compC.R,
            g = (int)currC.G - compC.G,
            b = (int)currC.B - compC.B;

            return (r * r + g * g + b * b) <= diff * diff * diff;
        }

        private void downlaod_Click(object sender, EventArgs e)
        {
            if (pictureBox.Tag == null)
                return;

            string downloadPath = pictureBox.Tag.ToString();
            int fileExtPos = downloadPath.LastIndexOf(".");

            if (fileExtPos > 0) 
            { 
                downloadPath = downloadPath.Substring(0, fileExtPos);
                downloadPath += "-removedBg.png";

                pictureBox.Image.Save(downloadPath, System.Drawing.Imaging.ImageFormat.Png);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Error while saving the image.");
            }
        }
    }
}