
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
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.txtScore = new System.Windows.Forms.Label();
            this.txtHighScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.wordsList = new System.Windows.Forms.FlowLayoutPanel();
            this.answerLabel = new System.Windows.Forms.Label();
            this.border = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Shapes2 = new Guna.UI2.WinForms.Guna2Shapes();
            this.guna2Shapes1 = new Guna.UI2.WinForms.Guna2Shapes();
            this.startButton = new Guna.UI2.WinForms.Guna2Button();
            this.questionLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Shapes3 = new Guna.UI2.WinForms.Guna2Shapes();
            this.guna2Shapes4 = new Guna.UI2.WinForms.Guna2Shapes();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
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
            // txtScore
            // 
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(171)))), ((int)(((byte)(121)))));
            this.txtScore.Location = new System.Drawing.Point(730, 235);
            this.txtScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(348, 25);
            this.txtScore.TabIndex = 2;
            this.txtScore.Text = "SCORE: 0";
            this.txtScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtHighScore
            // 
            this.txtHighScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHighScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(171)))), ((int)(((byte)(121)))));
            this.txtHighScore.Location = new System.Drawing.Point(730, 260);
            this.txtHighScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtHighScore.Name = "txtHighScore";
            this.txtHighScore.Size = new System.Drawing.Size(348, 25);
            this.txtHighScore.TabIndex = 2;
            this.txtHighScore.Text = "HIGH SCORE: 0";
            this.txtHighScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 60;
            this.gameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(171)))), ((int)(((byte)(121)))));
            this.label1.Location = new System.Drawing.Point(731, 342);
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
            this.wordsList.Location = new System.Drawing.Point(731, 383);
            this.wordsList.Name = "wordsList";
            this.wordsList.Size = new System.Drawing.Size(348, 504);
            this.wordsList.TabIndex = 4;
            // 
            // answerLabel
            // 
            this.answerLabel.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(171)))), ((int)(((byte)(121)))));
            this.answerLabel.Location = new System.Drawing.Point(731, 46);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(348, 134);
            this.answerLabel.TabIndex = 6;
            this.answerLabel.Text = "answer";
            this.answerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(171)))), ((int)(((byte)(121)))));
            this.guna2Panel1.Controls.Add(this.guna2Shapes2);
            this.guna2Panel1.Controls.Add(this.guna2Shapes1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1091, 31);
            this.guna2Panel1.TabIndex = 7;
            // 
            // guna2Shapes2
            // 
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
            this.startButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.startButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.startButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.startButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
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
            this.questionLabel.AutoSize = false;
            this.questionLabel.BackColor = System.Drawing.Color.Transparent;
            this.questionLabel.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.questionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(171)))), ((int)(((byte)(121)))));
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
            this.guna2Shapes3.Location = new System.Drawing.Point(731, 288);
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
            this.guna2Shapes4.Location = new System.Drawing.Point(730, 304);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(58)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(1091, 905);
            this.Controls.Add(this.guna2Shapes4);
            this.Controls.Add(this.guna2Shapes3);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.wordsList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHighScore);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.picCanvas);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(54)))), ((int)(((byte)(70)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Knowledge Crawler";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label txtHighScore;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel wordsList;
        private System.Windows.Forms.Label answerLabel;
        private Guna.UI2.WinForms.Guna2BorderlessForm border;
        private Guna.UI2.WinForms.Guna2Button startButton;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes2;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes1;
        private Guna.UI2.WinForms.Guna2HtmlLabel questionLabel;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes4;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes3;
    }
}

