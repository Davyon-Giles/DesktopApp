namespace ImageViewer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }
        private List<ImageRecord> images = new();

        private int currentIndex = 0;

        //private readonly ImageService imageService = new();
        private readonly DatabaseService databaseService = new();

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentIndex < images.Count - 1)
            {
                currentIndex++;

                ShowImage();
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
        private void ShowImage()
        {
            ImageRecord image = images[currentIndex];

            namelbl.Text = image.ImageName;
            locationlbl.Text = image.SubFolderPath;
            lblPageCount.Text = $"{currentIndex + 1} of {images.Count}";

            if (File.Exists(image.ImagePath))
            {
                /*  if (pictureBoxImage.Image != null)
                  {
                      pictureBoxImage.Image.Dispose();
                      pictureBoxImage.Image = null;
                  }

                  pictureBoxImage.Image = Image.FromFile(image.ImagePath);
              }
              else
              {
                  pictureBoxImage.Image = null;
              }*/

                try
                {
                    if (pictureBoxImage.Image != null)
                    {
                        pictureBoxImage.Image.Dispose();
                        pictureBoxImage.Image = null;
                    }

                    pictureBoxImage.Image = Image.FromFile(image.ImagePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        $"Unable to load image:\n\n{image.ImagePath}\n\n{ex.Message}",
                        "Image Load Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    pictureBoxImage.Image = null;
                }
            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // images = imageService.LoadImages(@"C:\my-images");

            //ShowImage();

            images = databaseService.GetImages();

            if (images.Count > 0)
            {
                ShowImage();
            }
        }


        private void lblPageCount_Click(object sender, EventArgs e)
        {

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;

                ShowImage();
            }
        }
    }
}
