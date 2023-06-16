
namespace Knowledge_Crawler
{
    partial class gameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gameForm));
            this.txtHighScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.wordsList = new System.Windows.Forms.FlowLayoutPanel();
            this.border = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Shapes2 = new Guna.UI2.WinForms.Guna2Shapes();
            this.guna2Shapes1 = new Guna.UI2.WinForms.Guna2Shapes();
            this.startButton = new Guna.UI2.WinForms.Guna2Button();
            this.questionLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Shapes3 = new Guna.UI2.WinForms.Guna2Shapes();
            this.guna2Shapes4 = new Guna.UI2.WinForms.Guna2Shapes();
            this.heartAnim = new System.Windows.Forms.Timer(this.components);
            this.gameOverLabel = new Guna.UI2.WinForms.Guna2Button();
            this.diffCB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.backBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.heart3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.heart2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.heart1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.answerLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtScore = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtHighScore
            // 
            this.txtHighScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHighScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(171)))), ((int)(((byte)(121)))));
            this.txtHighScore.Location = new System.Drawing.Point(730, 314);
            this.txtHighScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtHighScore.Name = "txtHighScore";
            this.txtHighScore.Size = new System.Drawing.Size(348, 25);
            this.txtHighScore.TabIndex = 2;
            this.txtHighScore.Text = "HIGH SCORE: 0";
            this.txtHighScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 40;
            this.gameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(171)))), ((int)(((byte)(121)))));
            this.label1.Location = new System.Drawing.Point(731, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "WORDS ANSWERED";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wordsList
            // 
            this.wordsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.wordsList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.wordsList.Location = new System.Drawing.Point(731, 422);
            this.wordsList.Name = "wordsList";
            this.wordsList.Size = new System.Drawing.Size(348, 465);
            this.wordsList.TabIndex = 4;
            // 
            // border
            // 
            this.border.BorderRadius = 25;
            this.border.ContainerControl = this;
            this.border.DockForm = false;
            this.border.DockIndicatorTransparencyValue = 0.6D;
            this.border.ResizeForm = false;
            this.border.TransparentWhileDrag = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(171)))), ((int)(((byte)(121)))));
            this.guna2Panel1.Controls.Add(this.guna2Shapes2);
            this.guna2Panel1.Controls.Add(this.guna2Shapes1);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1091, 31);
            this.guna2Panel1.TabIndex = 7;
            // 
            // guna2Shapes2
            // 
            this.guna2Shapes2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.guna2Shapes2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Shapes2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.guna2Shapes2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Shapes2.Location = new System.Drawing.Point(1022, 3);
            this.guna2Shapes2.Name = "guna2Shapes2";
            this.guna2Shapes2.PolygonSkip = 1;
            this.guna2Shapes2.Rotate = 0F;
            this.guna2Shapes2.Shape = Guna.UI2.WinForms.Enums.ShapeType.Ellipse;
            this.guna2Shapes2.Size = new System.Drawing.Size(25, 25);
            this.guna2Shapes2.TabIndex = 10;
            this.guna2Shapes2.Text = "guna2Shapes2";
            this.guna2Shapes2.UseTransparentBackground = true;
            this.guna2Shapes2.Zoom = 100;
            this.guna2Shapes2.Click += new System.EventHandler(this.guna2Shapes2_Click);
            // 
            // guna2Shapes1
            // 
            this.guna2Shapes1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.guna2Shapes1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Shapes1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.guna2Shapes1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Shapes1.Location = new System.Drawing.Point(1053, 3);
            this.guna2Shapes1.Name = "guna2Shapes1";
            this.guna2Shapes1.PolygonSkip = 1;
            this.guna2Shapes1.Rotate = 0F;
            this.guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Ellipse;
            this.guna2Shapes1.Size = new System.Drawing.Size(25, 25);
            this.guna2Shapes1.TabIndex = 9;
            this.guna2Shapes1.Text = "guna2Shapes1";
            this.guna2Shapes1.UseTransparentBackground = true;
            this.guna2Shapes1.Zoom = 100;
            this.guna2Shapes1.Click += new System.EventHandler(this.guna2Shapes1_Click);
            // 
            // startButton
            // 
            this.startButton.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(12)))), ((int)(((byte)(53)))));
            this.startButton.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(12)))), ((int)(((byte)(53)))));
            this.startButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(12)))), ((int)(((byte)(53)))));
            this.startButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(171)))), ((int)(((byte)(121)))));
            this.startButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(80)))), ((int)(((byte)(104)))));
            this.startButton.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(171)))), ((int)(((byte)(121)))));
            this.startButton.Location = new System.Drawing.Point(810, 187);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(180, 45);
            this.startButton.TabIndex = 8;
            this.startButton.Text = "START";
            this.startButton.Click += new System.EventHandler(this.StartGame);
            // 
            // questionLabel
            // 
            this.questionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.questionLabel.AutoSize = false;
            this.questionLabel.BackColor = System.Drawing.Color.Transparent;
            this.questionLabel.Enabled = false;
            this.questionLabel.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.questionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(171)))), ((int)(((byte)(121)))));
            this.questionLabel.IsSelectionEnabled = false;
            this.questionLabel.Location = new System.Drawing.Point(13, 46);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(700, 134);
            this.questionLabel.TabIndex = 9;
            this.questionLabel.Text = "QUESTIONS";
            this.questionLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Shapes3
            // 
            this.guna2Shapes3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Shapes3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(80)))), ((int)(((byte)(104)))));
            this.guna2Shapes3.Location = new System.Drawing.Point(731, 338);
            this.guna2Shapes3.Name = "guna2Shapes3";
            this.guna2Shapes3.PolygonSkip = 1;
            this.guna2Shapes3.Rotate = 0F;
            this.guna2Shapes3.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line;
            this.guna2Shapes3.Size = new System.Drawing.Size(348, 35);
            this.guna2Shapes3.TabIndex = 10;
            this.guna2Shapes3.Text = "guna2Shapes3";
            this.guna2Shapes3.UseTransparentBackground = true;
            this.guna2Shapes3.Zoom = 70;
            // 
            // guna2Shapes4
            // 
            this.guna2Shapes4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Shapes4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(80)))), ((int)(((byte)(104)))));
            this.guna2Shapes4.Location = new System.Drawing.Point(730, 354);
            this.guna2Shapes4.Name = "guna2Shapes4";
            this.guna2Shapes4.PolygonSkip = 1;
            this.guna2Shapes4.Rotate = 0F;
            this.guna2Shapes4.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line;
            this.guna2Shapes4.Size = new System.Drawing.Size(348, 35);
            this.guna2Shapes4.TabIndex = 11;
            this.guna2Shapes4.Text = "guna2Shapes4";
            this.guna2Shapes4.UseTransparentBackground = true;
            this.guna2Shapes4.Zoom = 50;
            // 
            // heartAnim
            // 
            this.heartAnim.Tick += new System.EventHandler(this.heartAnim_Tick);
            // 
            // gameOverLabel
            // 
            this.gameOverLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gameOverLabel.BackColor = System.Drawing.Color.Transparent;
            this.gameOverLabel.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.gameOverLabel.CheckedState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.gameOverLabel.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.gameOverLabel.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(54)))), ((int)(((byte)(70)))));
            this.gameOverLabel.DisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.gameOverLabel.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.gameOverLabel.DisabledState.FillColor = System.Drawing.Color.Transparent;
            this.gameOverLabel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(54)))), ((int)(((byte)(70)))));
            this.gameOverLabel.Enabled = false;
            this.gameOverLabel.FillColor = System.Drawing.Color.Transparent;
            this.gameOverLabel.Font = new System.Drawing.Font("Segoe UI Variable Text", 90F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(54)))), ((int)(((byte)(70)))));
            this.gameOverLabel.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.gameOverLabel.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.gameOverLabel.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.gameOverLabel.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(54)))), ((int)(((byte)(70)))));
            this.gameOverLabel.Location = new System.Drawing.Point(13, 719);
            this.gameOverLabel.Margin = new System.Windows.Forms.Padding(0);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.PressedColor = System.Drawing.Color.Transparent;
            this.gameOverLabel.PressedDepth = 0;
            this.gameOverLabel.Size = new System.Drawing.Size(1055, 180);
            this.gameOverLabel.TabIndex = 16;
            this.gameOverLabel.Text = "GAME OVER";
            this.gameOverLabel.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.gameOverLabel.UseTransparentBackground = true;
            this.gameOverLabel.Visible = false;
            this.gameOverLabel.Click += new System.EventHandler(this.gameOverLabel_Click);
            // 
            // diffCB
            // 
            this.diffCB.BackColor = System.Drawing.Color.Transparent;
            this.diffCB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(80)))), ((int)(((byte)(104)))));
            this.diffCB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(12)))), ((int)(((byte)(53)))));
            this.diffCB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(12)))), ((int)(((byte)(53)))));
            this.diffCB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(171)))), ((int)(((byte)(121)))));
            this.diffCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.diffCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.diffCB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(80)))), ((int)(((byte)(104)))));
            this.diffCB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(80)))), ((int)(((byte)(104)))));
            this.diffCB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(80)))), ((int)(((byte)(104)))));
            this.diffCB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.diffCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(171)))), ((int)(((byte)(121)))));
            this.diffCB.ItemHeight = 30;
            this.diffCB.Location = new System.Drawing.Point(834, 238);
            this.diffCB.Name = "diffCB";
            this.diffCB.Size = new System.Drawing.Size(140, 36);
            this.diffCB.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.diffCB.TabIndex = 24;
            this.diffCB.TabStop = false;
            this.diffCB.SelectedIndexChanged += new System.EventHandler(this.diffCB_SelectedIndexChanged);
            this.diffCB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.diffCB_KeyDown);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Transparent;
            this.backBtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.backBtn.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.backBtn.Image = global::Knowledge_Crawler.Properties.Resources.Sprite_0002;
            this.backBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.backBtn.ImageRotate = 0F;
            this.backBtn.ImageSize = new System.Drawing.Size(32, 32);
            this.backBtn.Location = new System.Drawing.Point(0, 37);
            this.backBtn.Name = "backBtn";
            this.backBtn.PressedState.ImageSize = new System.Drawing.Size(40, 40);
            this.backBtn.Size = new System.Drawing.Size(55, 55);
            this.backBtn.TabIndex = 23;
            this.backBtn.UseTransparentBackground = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // heart3
            // 
            this.heart3.BackColor = System.Drawing.Color.Transparent;
            this.heart3.FillColor = System.Drawing.Color.Transparent;
            this.heart3.Image = global::Knowledge_Crawler.Properties.Resources.heart1;
            this.heart3.ImageRotate = 0F;
            this.heart3.Location = new System.Drawing.Point(547, 197);
            this.heart3.Name = "heart3";
            this.heart3.ShadowDecoration.BorderRadius = 0;
            this.heart3.Size = new System.Drawing.Size(48, 48);
            this.heart3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.heart3.TabIndex = 14;
            this.heart3.TabStop = false;
            this.heart3.UseTransparentBackground = true;
            this.heart3.Click += new System.EventHandler(this.heart3_Click);
            // 
            // heart2
            // 
            this.heart2.BackColor = System.Drawing.Color.Transparent;
            this.heart2.FillColor = System.Drawing.Color.Transparent;
            this.heart2.Image = ((System.Drawing.Image)(resources.GetObject("heart2.Image")));
            this.heart2.ImageRotate = 0F;
            this.heart2.Location = new System.Drawing.Point(601, 197);
            this.heart2.Name = "heart2";
            this.heart2.ShadowDecoration.BorderRadius = 0;
            this.heart2.Size = new System.Drawing.Size(48, 48);
            this.heart2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.heart2.TabIndex = 13;
            this.heart2.TabStop = false;
            this.heart2.UseTransparentBackground = true;
            // 
            // heart1
            // 
            this.heart1.BackColor = System.Drawing.Color.Transparent;
            this.heart1.FillColor = System.Drawing.Color.Transparent;
            this.heart1.Image = global::Knowledge_Crawler.Properties.Resources.heart1;
            this.heart1.ImageRotate = 0F;
            this.heart1.Location = new System.Drawing.Point(655, 197);
            this.heart1.Name = "heart1";
            this.heart1.ShadowDecoration.BorderRadius = 0;
            this.heart1.Size = new System.Drawing.Size(48, 48);
            this.heart1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.heart1.TabIndex = 12;
            this.heart1.TabStop = false;
            this.heart1.UseTransparentBackground = true;
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(67)))), ((int)(((byte)(96)))));
            this.picCanvas.Location = new System.Drawing.Point(13, 187);
            this.picCanvas.Margin = new System.Windows.Forms.Padding(4);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(700, 700);
            this.picCanvas.TabIndex = 1;
            this.picCanvas.TabStop = false;
            this.picCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.UpdatePictureBoxGraphics);
            // 
            // answerLabel
            // 
            this.answerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.answerLabel.AutoSize = false;
            this.answerLabel.BackColor = System.Drawing.Color.Transparent;
            this.answerLabel.Enabled = false;
            this.answerLabel.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(171)))), ((int)(((byte)(121)))));
            this.answerLabel.IsSelectionEnabled = false;
            this.answerLabel.Location = new System.Drawing.Point(730, 46);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(348, 134);
            this.answerLabel.TabIndex = 25;
            this.answerLabel.Text = "ANSWER";
            this.answerLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtScore
            // 
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(171)))), ((int)(((byte)(121)))));
            this.txtScore.Location = new System.Drawing.Point(730, 289);
            this.txtScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(348, 25);
            this.txtScore.TabIndex = 2;
            this.txtScore.Text = "SCORE: 0";
            this.txtScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(58)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(1091, 905);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.diffCB);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.gameOverLabel);
            this.Controls.Add(this.heart3);
            this.Controls.Add(this.heart2);
            this.Controls.Add(this.heart1);
            this.Controls.Add(this.guna2Shapes4);
            this.Controls.Add(this.guna2Shapes3);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.wordsList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHighScore);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.picCanvas);
            this.Controls.Add(this.questionLabel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(54)))), ((int)(((byte)(70)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "gameForm";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Knowledge Crawler";
            this.Load += new System.EventHandler(this.gameForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.heart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Label txtHighScore;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel wordsList;
        private Guna.UI2.WinForms.Guna2BorderlessForm border;
        private Guna.UI2.WinForms.Guna2Button startButton;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes2;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes1;
        private Guna.UI2.WinForms.Guna2HtmlLabel questionLabel;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes4;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes3;
        private Guna.UI2.WinForms.Guna2PictureBox heart1;
        private Guna.UI2.WinForms.Guna2PictureBox heart3;
        private Guna.UI2.WinForms.Guna2PictureBox heart2;
        private System.Windows.Forms.Timer heartAnim;
        private Guna.UI2.WinForms.Guna2Button gameOverLabel;
        private Guna.UI2.WinForms.Guna2ImageButton backBtn;
        private Guna.UI2.WinForms.Guna2ComboBox diffCB;
        private Guna.UI2.WinForms.Guna2HtmlLabel answerLabel;
        private System.Windows.Forms.Label txtScore;
    }
}

