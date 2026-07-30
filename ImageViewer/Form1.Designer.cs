namespace ImageViewer
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            lblTitle = new Label();
            btnPrevious = new Button();
            btnNext = new Button();
            lblPageCount = new Label();
            pnlTitle = new Panel();
            pnlInfo = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblTiffPage = new Label();
            lblPagenum = new Label();
            locationlbl = new Label();
            namelbl = new Label();
            lblLoc = new Label();
            lblname = new Label();
            pictureBoxImage = new PictureBox();
            pnlViewer = new Panel();
            panel1 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnPrevPag = new Button();
            btnNextPag = new Button();
            webViewPdf = new Microsoft.Web.WebView2.WinForms.WebView2();
            pnlNav = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            pnlTitle.SuspendLayout();
            pnlInfo.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).BeginInit();
            pnlViewer.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webViewPdf).BeginInit();
            pnlNav.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(214, 226, 234);
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(279, 37);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "DOFS IMAGE VIEWER";
            lblTitle.Click += label2_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnPrevious.BackColor = Color.LightSalmon;
            btnPrevious.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrevious.ForeColor = Color.LightYellow;
            btnPrevious.Location = new Point(3, 3);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(295, 95);
            btnPrevious.TabIndex = 3;
            btnPrevious.Text = "◀ Previous ";
            btnPrevious.UseVisualStyleBackColor = false;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnNext.BackColor = Color.Teal;
            btnNext.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNext.ForeColor = Color.LightYellow;
            btnNext.Location = new Point(605, 3);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(298, 95);
            btnNext.TabIndex = 4;
            btnNext.Text = " Next ▶";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // lblPageCount
            // 
            lblPageCount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblPageCount.AutoSize = true;
            lblPageCount.BackColor = Color.Transparent;
            lblPageCount.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPageCount.ForeColor = Color.Cyan;
            lblPageCount.Location = new Point(304, 0);
            lblPageCount.Name = "lblPageCount";
            lblPageCount.Size = new Size(295, 101);
            lblPageCount.TabIndex = 5;
            lblPageCount.Text = "N OF M";
            lblPageCount.TextAlign = ContentAlignment.MiddleCenter;
            lblPageCount.Click += lblPageCount_Click;
            // 
            // pnlTitle
            // 
            pnlTitle.BackColor = Color.DarkBlue;
            pnlTitle.Controls.Add(lblTitle);
            pnlTitle.Dock = DockStyle.Top;
            pnlTitle.Location = new Point(0, 0);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Size = new Size(906, 70);
            pnlTitle.TabIndex = 7;
            // 
            // pnlInfo
            // 
            pnlInfo.BackColor = Color.FromArgb(90, 118, 144);
            pnlInfo.Controls.Add(tableLayoutPanel1);
            pnlInfo.Dock = DockStyle.Bottom;
            pnlInfo.Location = new Point(0, 515);
            pnlInfo.Name = "pnlInfo";
            pnlInfo.Size = new Size(906, 100);
            pnlInfo.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tableLayoutPanel1.Controls.Add(lblTiffPage, 1, 2);
            tableLayoutPanel1.Controls.Add(lblPagenum, 0, 2);
            tableLayoutPanel1.Controls.Add(locationlbl, 1, 1);
            tableLayoutPanel1.Controls.Add(namelbl, 1, 0);
            tableLayoutPanel1.Controls.Add(lblLoc, 0, 1);
            tableLayoutPanel1.Controls.Add(lblname, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(906, 100);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblTiffPage
            // 
            lblTiffPage.AutoSize = true;
            lblTiffPage.Font = new Font("Segoe UI", 13F);
            lblTiffPage.Location = new Point(320, 66);
            lblTiffPage.Name = "lblTiffPage";
            lblTiffPage.Size = new Size(68, 25);
            lblTiffPage.TabIndex = 5;
            lblTiffPage.Text = "M of N";
            lblTiffPage.Click += numlbl_Click;
            // 
            // lblPagenum
            // 
            lblPagenum.AutoSize = true;
            lblPagenum.Font = new Font("Segoe UI", 13F);
            lblPagenum.ForeColor = SystemColors.ControlLightLight;
            lblPagenum.Location = new Point(3, 66);
            lblPagenum.Name = "lblPagenum";
            lblPagenum.Size = new Size(161, 25);
            lblPagenum.TabIndex = 4;
            lblPagenum.Text = "Number of pages: ";
            // 
            // locationlbl
            // 
            locationlbl.AutoSize = true;
            locationlbl.Font = new Font("Segoe UI", 13F);
            locationlbl.Location = new Point(320, 33);
            locationlbl.Name = "locationlbl";
            locationlbl.Size = new Size(88, 25);
            locationlbl.TabIndex = 3;
            locationlbl.Text = "oxoxoxox";
            locationlbl.Click += locationlbl_Click;
            // 
            // namelbl
            // 
            namelbl.AutoSize = true;
            namelbl.Font = new Font("Segoe UI", 13F);
            namelbl.Location = new Point(320, 0);
            namelbl.Name = "namelbl";
            namelbl.Size = new Size(58, 25);
            namelbl.TabIndex = 1;
            namelbl.Text = "xoxox";
            namelbl.Click += label2_Click_1;
            // 
            // lblLoc
            // 
            lblLoc.AutoSize = true;
            lblLoc.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLoc.ForeColor = SystemColors.ControlLightLight;
            lblLoc.Location = new Point(3, 33);
            lblLoc.Name = "lblLoc";
            lblLoc.Size = new Size(95, 23);
            lblLoc.TabIndex = 2;
            lblLoc.Text = "LOCATION:\r\n";
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.Font = new Font("Segoe UI", 13F);
            lblname.ForeColor = SystemColors.ControlLightLight;
            lblname.Location = new Point(3, 0);
            lblname.Name = "lblname";
            lblname.Size = new Size(71, 25);
            lblname.TabIndex = 0;
            lblname.Text = "NAME: ";
            // 
            // pictureBoxImage
            // 
            pictureBoxImage.Anchor = AnchorStyles.None;
            pictureBoxImage.BackColor = Color.Black;
            pictureBoxImage.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxImage.Image = (Image)resources.GetObject("pictureBoxImage.Image");
            pictureBoxImage.Location = new Point(176, 176);
            pictureBoxImage.Name = "pictureBoxImage";
            pictureBoxImage.Size = new Size(556, 224);
            pictureBoxImage.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxImage.TabIndex = 0;
            pictureBoxImage.TabStop = false;
            // 
            // pnlViewer
            // 
            pnlViewer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlViewer.BackColor = Color.FromArgb(30, 59, 83);
            pnlViewer.BorderStyle = BorderStyle.FixedSingle;
            pnlViewer.Controls.Add(panel1);
            pnlViewer.Controls.Add(webViewPdf);
            pnlViewer.Controls.Add(pictureBoxImage);
            pnlViewer.Dock = DockStyle.Fill;
            pnlViewer.Location = new Point(0, 0);
            pnlViewer.Margin = new Padding(10);
            pnlViewer.Name = "pnlViewer";
            pnlViewer.Size = new Size(906, 515);
            pnlViewer.TabIndex = 9;
            pnlViewer.Paint += panel1_Paint;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.Controls.Add(tableLayoutPanel3);
            panel1.Location = new Point(-1, 414);
            panel1.Name = "panel1";
            panel1.Size = new Size(943, 100);
            panel1.TabIndex = 6;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(btnPrevPag, 0, 0);
            tableLayoutPanel3.Controls.Add(btnNextPag, 1, 0);
            tableLayoutPanel3.Location = new Point(30, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(878, 100);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // btnPrevPag
            // 
            btnPrevPag.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnPrevPag.BackColor = Color.OrangeRed;
            btnPrevPag.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrevPag.ForeColor = Color.LightYellow;
            btnPrevPag.Location = new Point(3, 3);
            btnPrevPag.Name = "btnPrevPag";
            btnPrevPag.Size = new Size(433, 94);
            btnPrevPag.TabIndex = 4;
            btnPrevPag.Text = "◀ Previous ";
            btnPrevPag.UseVisualStyleBackColor = false;
            btnPrevPag.Click += button1_Click;
            // 
            // btnNextPag
            // 
            btnNextPag.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnNextPag.BackColor = Color.MediumSeaGreen;
            btnNextPag.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNextPag.ForeColor = Color.LightYellow;
            btnNextPag.Location = new Point(442, 3);
            btnNextPag.Name = "btnNextPag";
            btnNextPag.Size = new Size(433, 94);
            btnNextPag.TabIndex = 5;
            btnNextPag.Text = " Next ▶";
            btnNextPag.UseVisualStyleBackColor = false;
            btnNextPag.Click += button2_Click;
            // 
            // webViewPdf
            // 
            webViewPdf.AllowExternalDrop = true;
            webViewPdf.Anchor = AnchorStyles.None;
            webViewPdf.CreationProperties = null;
            webViewPdf.DefaultBackgroundColor = Color.White;
            webViewPdf.Location = new Point(176, 176);
            webViewPdf.Name = "webViewPdf";
            webViewPdf.Size = new Size(556, 224);
            webViewPdf.TabIndex = 1;
            webViewPdf.Visible = false;
            webViewPdf.ZoomFactor = 1D;
            // 
            // pnlNav
            // 
            pnlNav.BackColor = Color.Transparent;
            pnlNav.BackgroundImageLayout = ImageLayout.None;
            pnlNav.Controls.Add(tableLayoutPanel2);
            pnlNav.Dock = DockStyle.Top;
            pnlNav.Location = new Point(0, 70);
            pnlNav.Name = "pnlNav";
            pnlNav.Size = new Size(906, 101);
            pnlNav.TabIndex = 10;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(lblPageCount, 1, 0);
            tableLayoutPanel2.Controls.Add(btnPrevious, 0, 0);
            tableLayoutPanel2.Controls.Add(btnNext, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(906, 101);
            tableLayoutPanel2.TabIndex = 6;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 59, 83);
            ClientSize = new Size(906, 615);
            Controls.Add(pnlNav);
            Controls.Add(pnlTitle);
            Controls.Add(pnlViewer);
            Controls.Add(pnlInfo);
            MaximumSize = new Size(1200, 800);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DOFS Image Viewer";
            WindowState = FormWindowState.Maximized;
            Load += MainForm_Load;
            pnlTitle.ResumeLayout(false);
            pnlTitle.PerformLayout();
            pnlInfo.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).EndInit();
            pnlViewer.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)webViewPdf).EndInit();
            pnlNav.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lblTitle;
        private Button btnPrevious;
        private Button btnNext;
        private Label lblPageCount;
        private Panel pnlTitle;
        private Panel pnlInfo;
        private Panel pnlViewer;
        private Panel pnlNav;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblTiffPage;
        private Label lblPagenum;
        private Label locationlbl;
        private Label lblname;
        private Label namelbl;
        private Label lblLoc;
        private PictureBox pictureBoxImage;
        private TableLayoutPanel tableLayoutPanel2;
        private Microsoft.Web.WebView2.WinForms.WebView2 webViewPdf;
        private Button btnNextPag;
        private Button btnPrevPag;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel3;
    }
}
