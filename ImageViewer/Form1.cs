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

        private readonly ImageService imageService = new();

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
            if (images.Count == 0)
                return;

            ImageRecord image = images[currentIndex];

            pictureBoxImage.Image = Image.FromFile(image.ImagePath);

            namelbl.Text = image.Name;

            locationlbl.Text = image.Location;

            lblPageCount.Text =
                $"{currentIndex + 1} of {images.Count}";

            btnPrevious.Enabled = currentIndex > 0;

            btnNext.Enabled =
                currentIndex < images.Count - 1;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            images = imageService.LoadImages(@"C:\my-images");

            ShowImage();
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
