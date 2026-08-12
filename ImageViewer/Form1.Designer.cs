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
            lblTiffPage2 = new Label();
            label1 = new Label();
            lblPageCount2 = new Label();
            lblPagenum = new Label();
            locationlbl = new Label();
            namelbl = new Label();
            lblLoc = new Label();
            lblname = new Label();
            pictureBoxImage = new PictureBox();
            pnlViewer = new Panel();
            btnFullScreen = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnPrevPag = new Button();
            btnNextPag = new Button();
            lblTiffPage = new Label();
            webViewPdf = new Microsoft.Web.WebView2.WinForms.WebView2();
            pnlNav = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            pnlTitle.SuspendLayout();
            pnlInfo.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).BeginInit();
            pnlViewer.SuspendLayout();
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
            btnPrevious.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnPrevious.BackColor = Color.FromArgb(51, 86, 128);
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
            btnNext.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnNext.BackColor = Color.FromArgb(51, 86, 128);
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
            lblPageCount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblPageCount.AutoSize = true;
            lblPageCount.BackColor = Color.Transparent;
            lblPageCount.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPageCount.ForeColor = Color.Cyan;
            lblPageCount.Location = new Point(401, 0);
            lblPageCount.Name = "lblPageCount";
            lblPageCount.Size = new Size(100, 101);
            lblPageCount.TabIndex = 5;
            lblPageCount.Text = "N OF M";
            lblPageCount.TextAlign = ContentAlignment.MiddleCenter;
            lblPageCount.Click += lblPageCount_Click;
            // 
            // pnlTitle
            // 
            pnlTitle.BackColor = Color.FromArgb(13, 27, 140);
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
            tableLayoutPanel1.BackColor = Color.FromArgb(95, 120, 147);
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tableLayoutPanel1.Controls.Add(lblTiffPage2, 1, 3);
            tableLayoutPanel1.Controls.Add(label1, 0, 3);
            tableLayoutPanel1.Controls.Add(lblPageCount2, 1, 2);
            tableLayoutPanel1.Controls.Add(lblPagenum, 0, 2);
            tableLayoutPanel1.Controls.Add(locationlbl, 1, 1);
            tableLayoutPanel1.Controls.Add(namelbl, 1, 0);
            tableLayoutPanel1.Controls.Add(lblLoc, 0, 1);
            tableLayoutPanel1.Controls.Add(lblname, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(906, 100);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblTiffPage2
            // 
            lblTiffPage2.AutoSize = true;
            lblTiffPage2.Font = new Font("Segoe UI", 13F);
            lblTiffPage2.Location = new Point(320, 78);
            lblTiffPage2.Name = "lblTiffPage2";
            lblTiffPage2.Size = new Size(68, 22);
            lblTiffPage2.TabIndex = 7;
            lblTiffPage2.Text = "M of N";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(3, 78);
            label1.Name = "label1";
            label1.Size = new Size(91, 22);
            label1.TabIndex = 6;
            label1.Text = "TIFF Page:";
            // 
            // lblPageCount2
            // 
            lblPageCount2.AutoSize = true;
            lblPageCount2.Font = new Font("Segoe UI", 13F);
            lblPageCount2.Location = new Point(320, 52);
            lblPageCount2.Name = "lblPageCount2";
            lblPageCount2.Size = new Size(68, 25);
            lblPageCount2.TabIndex = 5;
            lblPageCount2.Text = "M of N";
            lblPageCount2.Click += numlbl_Click;
            // 
            // lblPagenum
            // 
            lblPagenum.AutoSize = true;
            lblPagenum.Font = new Font("Segoe UI", 13F);
            lblPagenum.ForeColor = SystemColors.ControlLightLight;
            lblPagenum.Location = new Point(3, 52);
            lblPagenum.Name = "lblPagenum";
            lblPagenum.Size = new Size(71, 25);
            lblPagenum.TabIndex = 4;
            lblPagenum.Text = "Record:";
            lblPagenum.Click += lblPagenum_Click;
            // 
            // locationlbl
            // 
            locationlbl.AutoSize = true;
            locationlbl.Font = new Font("Segoe UI", 13F);
            locationlbl.Location = new Point(320, 26);
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
            lblLoc.Location = new Point(3, 26);
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
            pnlViewer.Anchor = AnchorStyles.None;
            pnlViewer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlViewer.BackColor = Color.FromArgb(30, 59, 83);
            pnlViewer.BorderStyle = BorderStyle.FixedSingle;
            pnlViewer.Controls.Add(btnFullScreen);
            pnlViewer.Controls.Add(tableLayoutPanel3);
            pnlViewer.Controls.Add(webViewPdf);
            pnlViewer.Controls.Add(pictureBoxImage);
            pnlViewer.Location = new Point(0, 0);
            pnlViewer.Margin = new Padding(10);
            pnlViewer.Name = "pnlViewer";
            pnlViewer.Size = new Size(906, 515);
            pnlViewer.TabIndex = 9;
            pnlViewer.Paint += panel1_Paint;
            // 
            // btnFullScreen
            // 
            btnFullScreen.BackColor = Color.FromArgb(51, 86, 128);
            btnFullScreen.ForeColor = Color.LightYellow;
            btnFullScreen.Location = new Point(761, 176);
            btnFullScreen.Name = "btnFullScreen";
            btnFullScreen.Size = new Size(109, 31);
            btnFullScreen.TabIndex = 7;
            btnFullScreen.Text = "⛶ Full Screen";
            btnFullScreen.UseVisualStyleBackColor = false;
            btnFullScreen.Click += btnFullScreen_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.44371F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.44371F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.1125832F));
            tableLayoutPanel3.Controls.Add(btnPrevPag, 0, 0);
            tableLayoutPanel3.Controls.Add(btnNextPag, 2, 0);
            tableLayoutPanel3.Controls.Add(lblTiffPage, 1, 0);
            tableLayoutPanel3.Location = new Point(271, 454);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(375, 54);
            tableLayoutPanel3.TabIndex = 6;
            // 
            // btnPrevPag
            // 
            btnPrevPag.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnPrevPag.BackColor = Color.FromArgb(51, 86, 128);
            btnPrevPag.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrevPag.ForeColor = Color.LightYellow;
            btnPrevPag.Location = new Point(3, 3);
            btnPrevPag.Name = "btnPrevPag";
            btnPrevPag.Size = new Size(119, 48);
            btnPrevPag.TabIndex = 4;
            btnPrevPag.Text = "⇚ Page";
            btnPrevPag.UseVisualStyleBackColor = false;
            btnPrevPag.Click += button1_Click;
            // 
            // btnNextPag
            // 
            btnNextPag.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnNextPag.BackColor = Color.FromArgb(51, 86, 128);
            btnNextPag.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNextPag.ForeColor = Color.LightYellow;
            btnNextPag.Location = new Point(253, 3);
            btnNextPag.Name = "btnNextPag";
            btnNextPag.Size = new Size(119, 48);
            btnNextPag.TabIndex = 5;
            btnNextPag.Text = "Page ⇛";
            btnNextPag.UseVisualStyleBackColor = false;
            btnNextPag.Click += button2_Click;
            // 
            // lblTiffPage
            // 
            lblTiffPage.Anchor = AnchorStyles.None;
            lblTiffPage.AutoSize = true;
            lblTiffPage.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTiffPage.Location = new Point(144, 17);
            lblTiffPage.Name = "lblTiffPage";
            lblTiffPage.Size = new Size(86, 20);
            lblTiffPage.TabIndex = 6;
            lblTiffPage.Text = "Page x of y";
            // 
            // webViewPdf
            // 
            webViewPdf.AllowExternalDrop = true;
            webViewPdf.Anchor = AnchorStyles.None;
            webViewPdf.CreationProperties = null;
            webViewPdf.DefaultBackgroundColor = Color.White;
            webViewPdf.Location = new Point(37, 176);
            webViewPdf.Name = "webViewPdf";
            webViewPdf.Size = new Size(833, 272);
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
            BackColor = Color.FromArgb(36, 59, 83);
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
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
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
        private Label lblPageCount2;
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
        private TableLayoutPanel tableLayoutPanel3;
        private Label lblTiffPage;
        private Label lblTiffPage2;
        private Label label1;
        private Button btnFullScreen;
    }
}
