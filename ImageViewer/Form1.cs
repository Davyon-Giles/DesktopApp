using System.Drawing.Imaging;

namespace ImageViewer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            webViewPdf.KeyDown += WebViewPdf_KeyDown;
        }
        private bool isFullScreen = false;

        private FormBorderStyle previousBorderStyle;
        private FormWindowState previousWindowState;
        private Rectangle previousBounds;

        private Image? currentTiff;

        private int currentTiffPage = 0;
        private int pageCount = 0;
        private List<ImageRecord> images = new();
        private bool isImageFullScreen = false;

        private Rectangle previousImageBounds;
        private int currentIndex = 0;

        //private readonly ImageService imageService = new();
        private readonly DatabaseService databaseService = new();
        private void ToggleFullScreen()
        {
            if (!isFullScreen)
            {
                previousBorderStyle = this.FormBorderStyle;
                previousWindowState = this.WindowState;
                previousBounds = this.Bounds;

                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;

                pnlTitle.Visible = false;
                pnlNav.Visible = false;
                pnlInfo.Visible = false;

                pictureBoxImage.Dock = DockStyle.Fill;
                webViewPdf.Dock = DockStyle.Fill;
                btnFullScreen.Visible = false;
                tableLayoutPanel3.Visible = false;
                isFullScreen = true;
            }
            else
            {
                FormBorderStyle = previousBorderStyle;
                WindowState = previousWindowState;
                Bounds = previousBounds;

                pnlTitle.Visible = true;
                pnlNav.Visible = true;
                pnlInfo.Visible = true;
                btnFullScreen.Visible = true;
                pictureBoxImage.Dock = DockStyle.None;
                webViewPdf.Dock = DockStyle.None;

                tableLayoutPanel3.Visible = true;
               // isFullScreen = true;

                isFullScreen = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void WebViewPdf_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && isFullScreen)
            {
                ToggleFullScreen();

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
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
        /*  private void ShowImage()
          {
              if (images.Count == 0)
                  return;

              ImageRecord image = images[currentIndex];

              namelbl.Text = image.ImageName;
              locationlbl.Text = image.SubFolderPath;
              lblPageCount.Text = $"Record {currentIndex + 1} of {images.Count}";

              // Check if the file exists
              if (!File.Exists(image.ImagePath))
              {
                  pictureBoxImage.Image = null;

                  MessageBox.Show(
                      $"File not found:\n\n{image.ImagePath}",
                      "Missing File",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Warning);

                  return;
              }

              // Determine the file type
              string extension = Path.GetExtension(image.ImagePath).ToLower();

              currentTiff = Image.FromFile(image.ImagePath);

              FrameDimension dimension =
                  new FrameDimension(currentTiff.FrameDimensionsList[0]);

              pageCount = currentTiff.GetFrameCount(dimension);
              switch (extension)
              {
                  // Supported image formats
                  case ".jpg":
                  case ".jpeg":
                  case ".png":
                  case ".bmp":
                  case ".gif":
                      break;
                  case ".tif":
                  case ".tiff":
                      pictureBoxImage.Visible = true;
                      webViewPdf.Visible = false;
                      bool multiPage = pageCount > 1;

                      lblPageCount2.Visible = true;
                      btnPrevPag.Visible = multiPage;
                      btnNextPag.Visible = multiPage;
                      try
                      {
                          // Dispose of the previous image
                          if (pictureBoxImage.Image != null)
                          {
                              pictureBoxImage.Image.Dispose();
                              pictureBoxImage.Image = null;
                          }

                          //pictureBoxImage.Image = Image.FromFile(image.ImagePath);

                          // MessageBox.Show($"This TIFF has {pageCount} page(s).");
                          currentTiffPage = 0;
                          ShowTiffPage();
                          // lblPageCount2.Text = $"Page {currentTiffPage + 1} of {pageCount}";
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

                      break;

                  // PDF files
                  case ".pdf":

                      pictureBoxImage.Visible = false;
                      webViewPdf.Visible = true;

                      webViewPdf.Source = new Uri(image.ImagePath);

                      break;

                  // Unsupported file types
                  default:

                      pictureBoxImage.Image = null;

                      MessageBox.Show(
                          $"Unsupported file type:\n{extension}",
                          "Unsupported File",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Information);

                      break;
              }

              // Enable/Disable navigation buttons
              btnPrevious.Enabled = currentIndex > 0;
              btnNext.Enabled = currentIndex < images.Count - 1;
          }*/
        private void ShowImage()
        {
            if (images.Count == 0)
                return;

            ImageRecord image = images[currentIndex];

            namelbl.Text = image.ImageName;
            locationlbl.Text = image.SubFolderPath;
            lblPageCount.Text = $"Record {currentIndex + 1} of {images.Count}";

            // Check if the file exists
            if (!File.Exists(image.ImagePath))
            {
                pictureBoxImage.Image = null;

                MessageBox.Show(
                    $"File not found:\n\n{image.ImagePath}",
                    "Missing File",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string extension = Path.GetExtension(image.ImagePath).ToLowerInvariant();

            switch (extension)
            {
                // --------------------------------
                // Standard image files
                // --------------------------------
                case ".jpg":
                case ".jpeg":
                case ".png":
                case ".bmp":
                case ".gif":

                    pictureBoxImage.Visible = true;
                    webViewPdf.Visible = false;

                    try
                    {
                        if (pictureBoxImage.Image != null)
                        {
                            pictureBoxImage.Image.Dispose();
                            pictureBoxImage.Image = null;
                        }

                        pictureBoxImage.Image = Image.FromFile(image.ImagePath);
                    }
                    catch (Exception)
                    {
                        pictureBoxImage.Image = null;
                    }

                    break;


                // --------------------------------
                // TIFF files
                // --------------------------------
                case ".tif":
                case ".tiff":

                    pictureBoxImage.Visible = true;
                    webViewPdf.Visible = false;

                    try
                    {
                        if (pictureBoxImage.Image != null)
                        {
                            pictureBoxImage.Image.Dispose();
                            pictureBoxImage.Image = null;
                        }

                        // Load the TIFF
                        currentTiff = Image.FromFile(image.ImagePath);

                        FrameDimension dimension =
                            new FrameDimension(
                                currentTiff.FrameDimensionsList[0]);

                        // Determine number of TIFF pages
                        pageCount =
                            currentTiff.GetFrameCount(dimension);

                        currentTiffPage = 0;

                        // Show/hide TIFF controls
                        bool multiPage = pageCount > 1;

                        lblPageCount2.Visible = true;
                        btnPrevPag.Visible = multiPage;
                        btnNextPag.Visible = multiPage;

                        ShowTiffPage();
                    }
                    catch (Exception)
                    {
                        pictureBoxImage.Image = null;

                        if (currentTiff != null)
                        {
                            currentTiff.Dispose();
                            currentTiff = null;
                        }

                        pageCount = 0;
                        currentTiffPage = 0;

                        lblPageCount2.Visible = false;
                        btnPrevPag.Visible = false;
                        btnNextPag.Visible = false;
                    }

                    break;


                // --------------------------------
                // PDF files
                // --------------------------------
                case ".pdf":

                    pictureBoxImage.Visible = false;
                    webViewPdf.Visible = true;

                    lblPageCount2.Visible = false;
                    btnPrevPag.Visible = false;
                    btnNextPag.Visible = false;

                    webViewPdf.Source = new Uri(image.ImagePath);

                    break;


                // --------------------------------
                // Unsupported files
                // --------------------------------
                default:

                    pictureBoxImage.Image = null;
                    webViewPdf.Visible = false;

                    lblPageCount2.Visible = false;
                    btnPrevPag.Visible = false;
                    btnNextPag.Visible = false;

                    MessageBox.Show(
                        $"Unsupported file type:\n{extension}",
                        "Unsupported File",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    break;
            }

            // Record navigation
            btnPrevious.Enabled = currentIndex > 0;
            btnNext.Enabled = currentIndex < images.Count - 1;
        }


        private async void MainForm_Load(object sender, EventArgs e)
        {
            images = databaseService.GetImages();

            await webViewPdf.EnsureCoreWebView2Async();

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

        private void numlbl_Click(object sender, EventArgs e)
        {
            // lblPageCount2.Text =
            //$"{currentTiffPage + 1} of {pageCount}";
        }
        private void ShowTiffPage()
        {
            if (currentTiff == null)
                return;

            FrameDimension dimension =
                new FrameDimension(currentTiff.FrameDimensionsList[0]);

            currentTiff.SelectActiveFrame(dimension, currentTiffPage);

            pictureBoxImage.Image?.Dispose();

            pictureBoxImage.Image = (Image)currentTiff.Clone();

            lblPageCount2.Text = $" {currentIndex + 1} of {images.Count}";

            lblTiffPage.Text = $"Page {currentTiffPage + 1} of {pageCount}";
            lblTiffPage2.Text = $"Page {currentTiffPage + 1} of {pageCount}";

            btnPrevPag.Enabled = currentTiffPage > 0;
            btnNextPag.Enabled = currentTiffPage < pageCount - 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currentTiff == null || currentTiffPage <= 0)
                return;

            currentTiffPage--;

            ShowTiffPage();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (currentTiff == null || currentTiffPage >= pageCount - 1)
                return;

            currentTiffPage++;

            ShowTiffPage();
        }

        private void locationlbl_Click(object sender, EventArgs e)
        {

        }

        private void lblPagenum_Click(object sender, EventArgs e)
        {

        }

        private void btnFullScreen_Click(object sender, EventArgs e)
        {
             ToggleFullScreen();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F11)
            {
                ToggleFullScreen();
                return true;
            }
            if (keyData == Keys.Escape && isFullScreen)
            {
                ToggleFullScreen();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);

        }
    }
}
