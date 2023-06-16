using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using NAudio.Wave;
using System.Drawing.Imaging; // add this for the JPG compressor
using System.Data.SqlClient;
using Guna.UI2.WinForms;
using System.Collections;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.IO;
using System.Media;

namespace Knowledge_Crawler
{
    public partial class gameForm : Form
    {

        private List<Circle> Snake = new List<Circle>();
        private Circle[] food ={new Circle(), new Circle(), new Circle()};

        int maxWidth;
        int maxHeight;

        private WaveOutEvent hitPlayer;
        private WaveOutEvent pickupPlayer;

        private WaveFileReader hitReader;
        private WaveFileReader pickupReader;

        SoundPlayer bgSound = new SoundPlayer(Properties.Resources.bgGame);

        private bool isBlinking = false;
        int score;
        int highScore;
        int live = 3;
        int blinkCount = 0;
        Random rand = new Random();

        private Timer timer;
        private int labelY;
        private const int AnimationDuration = 600; // Animation duration in milliseconds
        private const int TimerInterval = 10; // Timer interval in milliseconds
        private const int InitialDelay = 10; // Delay before starting the animation in milliseconds
        private DateTime startTime;

        string difficulty;
        bool goLeft, goRight, goDown, goUp;
        string correctAnswer = "A";
        string question = "";
        static int index = 0;
        static int maxIndex = 0;
        static string[] letter = new string[3];
        static string hiddenAnswer = "";
        List<string> finishedQuestion = new List<string>();
        static bool isHit = false;

        public gameForm()
        {
            InitializeComponent();
            new Settings();
            this.KeyDown += KeyIsDown;
            this.KeyUp += KeyIsUp;
            StartPosition = FormStartPosition.Manual;
            Rectangle screen = Screen.FromPoint(Cursor.Position).WorkingArea;
            int w = Width >= screen.Width ? screen.Width : (screen.Width + Width) / 2;
            int h = Height >= screen.Height ? screen.Height : (screen.Height + Height) / 2;
            Location = new Point(screen.Left + (screen.Width - w) / 2, screen.Top + (screen.Height - h) / 2);
            Size = new Size(w, h);
            AutoSize = true;

            try
            {
                pickupPlayer = new WaveOutEvent();
                Stream pickupMem = Properties.Resources.pickupLetter;
                pickupReader = new WaveFileReader(pickupMem);
                WaveChannel32 pickupChannel = new WaveChannel32(pickupReader);
                pickupPlayer.Init(pickupChannel);

                hitPlayer = new WaveOutEvent();
                Stream hitMem = Properties.Resources.hitHurt;
                hitReader = new WaveFileReader(hitMem);
                WaveChannel32 hitChannel = new WaveChannel32(hitReader);
                hitPlayer.Init(hitChannel);

                if(Settings.music)
                {
                    bgSound.Load();
                    bgSound.PlayLooping();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "AN ERROR HAS OCCURED", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left && Settings.directions != "right")
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right && Settings.directions != "left")
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Up && Settings.directions != "down")
            {
                goUp = true;
            }
            if (e.KeyCode == Keys.Down && Settings.directions != "up")
            {
                goDown = true;
            }



        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
        }

        private void StartGame(object sender, EventArgs e)
        {
            Size formSize = new Size(this.Width, this.Height);
            AutoSize = false;
            this.Size = formSize;

            Settings.playMenuSelect();
            difficulty = diffCB.Text;
            diffCB.Enabled = false;

            foreach (Control control in wordsList.Controls)
            {
                wordsList.Controls.Remove(control);
                control.Dispose(); 
            }

            isHit = false;
            if (difficulty == "EASY")
                gameTimer.Interval = 80;
            else if (difficulty == "MEDIUM")
                gameTimer.Interval = 60;
            else if (difficulty == "HARD")
                gameTimer.Interval = 40;
            RestartGame();
        }


        private void GameTimerEvent(object sender, EventArgs e)
        {
            // setting the directions

            if (goLeft)
            {
                Settings.directions = "left";
            }
            if (goRight)
            {
                Settings.directions = "right";
            }
            if (goDown)
            {
                Settings.directions = "down";
            }
            if (goUp)
            {
                Settings.directions = "up";
            }
            // end of directions

            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {

                    switch (Settings.directions)
                    {
                        case "left":
                            Snake[i].X--;
                            break;
                        case "right":
                            Snake[i].X++;
                            break;
                        case "down":
                            Snake[i].Y++;
                            break;
                        case "up":
                            Snake[i].Y--;
                            break;
                    }

                    if (Snake[i].X < 0)
                    {
                        Snake[i].X = maxWidth;
                    }
                    if (Snake[i].X > maxWidth)
                    {
                        Snake[i].X = 0;
                    }
                    if (Snake[i].Y < 0)
                    {
                        Snake[i].Y = maxHeight;
                    }
                    if (Snake[i].Y > maxHeight)
                    {
                        Snake[i].Y = 0;
                    }

                    // eating food
                    for (int j = 0; j < food.Length; j++)
                    {
                        if (Snake[i].X == food[j].X && Snake[j].Y == food[j].Y)
                        {
                            if (letter[j] == correctAnswer[index].ToString())
                            {
                                EatFood();
                            }
                            else
                            {
                                GameOver();
                            }
                        }
                    }
                    

                    for (int j = 1; j < Snake.Count; j++)
                    {

                        if (Snake[i].X == Snake[j].X && Snake[i].Y == Snake[j].Y)
                        {
                            GameOver();
                        }

                    }


                }
                else
                {
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }


            picCanvas.Invalidate();

        }
        Random random = new Random();
        private string randLetter()
        {
            char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            char randomLetter = alphabet[random.Next(0, alphabet.Length)];

            if (!string.IsNullOrWhiteSpace(letter[1]))
            {
                if (letter[1] == randomLetter.ToString())
                    randomLetter = alphabet[random.Next(0, alphabet.Length)];
            }
            
            return randomLetter.ToString();
        }
        Graphics canvas;
        Brush snakeColour;
        private void UpdatePictureBoxGraphics(object sender, PaintEventArgs e)
        {
            heart1.BackColor = Color.Transparent;
            heart2.BackColor = Color.Transparent;
            heart3.BackColor = Color.Transparent;
            canvas = e.Graphics;

            for (int i = 0; i < Snake.Count; i++)
            {
                if(isBlinking)
                {
                    snakeColour = new SolidBrush(Color.FromArgb(239, 201, 169));

                    canvas.FillEllipse(snakeColour, new Rectangle
                        (
                        Snake[i].X * Settings.Width,
                        Snake[i].Y * Settings.Height,
                        Settings.Width, Settings.Height
                        ));
                }
                else
                {
                    if (i == 0)
                    {
                        snakeColour = new SolidBrush(Color.FromArgb(173, 95, 31));
                    }
                    else
                    {
                        snakeColour = new SolidBrush(Color.FromArgb(231, 171, 121));
                    }

                    canvas.FillEllipse(snakeColour, new Rectangle
                        (
                        Snake[i].X * Settings.Width,
                        Snake[i].Y * Settings.Height,
                        Settings.Width, Settings.Height
                        ));
                }  
            }

            // Food location
            for (int i = 0; i < food.Length; i++)
            {
                // Draw the filled ellipse
                canvas.FillEllipse(Brushes.DarkRed, new Rectangle(
                    food[i].X * Settings.Width,
                    food[i].Y * Settings.Height,
                    Settings.Width, Settings.Height));

                // Draw the letter inside the ellipse
                Font font = new Font("Arial", 12); // Replace with the desired font and size
                Brush textBrush = Brushes.White; // Replace with the desired color

                // Calculate the center coordinates of the ellipse
                int centerX = food[i].X * Settings.Width + (Settings.Width / 2);
                int centerY = food[i].Y * Settings.Height + (Settings.Height / 2);

                // Calculate the size of the letter based on the font
                SizeF letterSize = canvas.MeasureString(letter[0], font);

                // Calculate the position to draw the letter so that it's centered in the ellipse
                float letterX = centerX - (letterSize.Width / 2);
                float letterY = centerY - (letterSize.Height / 2);

                // Draw the letter
                canvas.DrawString(letter[i], font, textBrush, letterX, letterY);
                
            }
            
        }
        private void RestartGame()
        {
            isHit = false;

            heart1.Image = Properties.Resources.heart1;
            heart2.Image = Properties.Resources.heart1;
            heart3.Image = Properties.Resources.heart1;

            live = 3;
            blinkCount = 0;
            newQuestion();
            letter[0] = correctAnswer[index].ToString();
            letter[1] = randLetter();
            letter[2] = randLetter();

            maxWidth = picCanvas.Width / Settings.Width - 1;
            maxHeight = picCanvas.Height / Settings.Height - 1;

            Snake.Clear();

            startButton.Enabled = false;
            score = 0;
            txtScore.Text = "SCORE: " + score;

            Circle head = new Circle { X = 10, Y = 5 };
            Snake.Add(head); // adding the head part of the snake to the list

            for (int i = 0; i < 10; i++)
            {
                Circle body = new Circle();
                Snake.Add(body);
            }
            for (int i = 0; i < food.Length; i++)
            {
                food[i] = new Circle { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };
            }

            gameTimer.Start();

        }

        private void guna2Shapes1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Environment.Exit(0);
        }

        private void guna2Shapes2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void EatFood()
        {
            if(Settings.gameSfx)
            {
                pickupPlayer.Stop();
                pickupReader.Position = 0;
                pickupPlayer.Play();
            }

            // easy = 5
            // medium = 10
            // hard = 15
            if (difficulty == "EASY")
                score += 5;
            else if (difficulty == "MEDIUM")
                score += 10;
            else if (difficulty == "HARD")
                score += 15;

            Circle body = new Circle
            {
                X = Snake[Snake.Count - 1].X,
                Y = Snake[Snake.Count - 1].Y
            };

            Snake.Add(body);

            for (int i = 0; i < food.Length; i++)
            {
                food[i] = new Circle { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };
            }

            if (maxIndex-1 <= index)
            {
                // easy = 1
                // medium = 2
                // hard = 3
                if (difficulty == "EASY")
                    score += correctAnswer.Length;
                else if (difficulty == "MEDIUM")
                    score += correctAnswer.Length * 2;
                else if (difficulty == "HARD")
                    score += correctAnswer.Length * 3;

                Label label = new Label();
                label.Text = correctAnswer.ToUpper();
                label.Font = new Font("Arial", 12);
                label.ForeColor = Color.FromArgb(231, 171, 121);
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.MinimumSize = new Size(wordsList.Width-5, 0);

                finishedQuestion.Add(correctAnswer);

                wordsList.Controls.Add(label);

                newQuestion();
                letter[0] = correctAnswer[index].ToString();
                letter[1] = randLetter();
                letter[2] = randLetter();
                return;
            }
            else
            {
                StringBuilder hiddenAnswerBuilder = new StringBuilder(hiddenAnswer);
                hiddenAnswerBuilder.Remove(index, 1);
                hiddenAnswerBuilder.Insert(index, correctAnswer[index]);
                hiddenAnswer = hiddenAnswerBuilder.ToString();
                answerLabel.Text = hiddenAnswer;

                index++;
                if (string.IsNullOrWhiteSpace(correctAnswer[index].ToString()) || string.IsNullOrEmpty(correctAnswer[index].ToString()))
                    index++;
                letter[0] = correctAnswer[index].ToString();
                letter[1] = randLetter();
                letter[2] = randLetter();

            }

            txtScore.Text = "Score: " + score;
        }

        private void GameOver()
        {
            if (isHit)
                return;
            
                blinkCount = 0;
            try
            {
                if(Settings.gameSfx)
                {
                    hitPlayer.Stop();
                    hitReader.Position = 0;
                    hitPlayer.Play();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "AN ERROR HAS OCCURED", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            isHit = true;
            if (live == 3)
            {
                heart1.Image = Properties.Resources.blank_heart;
                heartAnim.Start();
            }
            else if (live == 2)
            {
                heart2.Image = Properties.Resources.blank_heart;
                heartAnim.Start();
            }
            else if (live == 1)
            {
                heart3.Image = Properties.Resources.blank_heart;
                heartAnim.Start();
            }


            if(live <= 0)
            {
                gameTimer.Stop();

                gameOverLabel.Enabled = true;
                gameOverLabel.Visible = true;
                startButton.Text = "RESTART";
                timer.Start();
                startTime = DateTime.Now.AddMilliseconds(InitialDelay);
                if (score > highScore)
                {
                    highScore = score;
                    txtHighScore.Text = "HIGH SCORE: " + highScore;
                    txtHighScore.ForeColor = Color.FromArgb(220, 130, 56);
                    txtHighScore.TextAlign = ContentAlignment.MiddleCenter;
                }
            }
        }

        private void newQuestion()
        {
            string query;
            if (finishedQuestion != null && finishedQuestion.Any())
            {
                query = $"SELECT * FROM Questions WHERE answer != '{correctAnswer}' " +
                        $"AND answer NOT IN ({string.Join(",", finishedQuestion.Select(q => $"'{q}'"))}) " +
                        $"ORDER BY NEWID()";
            }
            else
            {
                query = $"SELECT * FROM Questions WHERE answer != '{correctAnswer}' ORDER BY NEWID()";
            }


            // 0 - Id
            // 1 - questions
            // 2 - answer
            using (SqlConnection con = new SqlConnection(Settings.server))
            {
                hiddenAnswer = "";
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        question = dr.GetString(1);
                        correctAnswer = dr.GetString(2).ToUpper();

                        index = 0;
                        maxIndex = correctAnswer.Length;
                    }
                    else
                    {
                        GameOver();
                        if (finishedQuestion != null && finishedQuestion.Any())
                        {
                            MessageBox.Show("Congratulations! You finished all the questions!", "YOU WON!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("There are no questions", "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    dr.Close();
                }
            }
            questionLabel.Text = question;
            for (int i = 0; i < correctAnswer.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(correctAnswer[i].ToString()))
                {
                    hiddenAnswer += " ";
                }
                else
                {
                    hiddenAnswer += "●";
                }
            }
            answerLabel.Text = hiddenAnswer;
        }


        private HashSet<Keys> keysPressed = new HashSet<Keys>();

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (!keysPressed.Contains(keyData))
            {
                keysPressed.Add(keyData);
                KeyIsDown(keyData);
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void heartAnim_Tick(object sender, EventArgs e)
        {
            bool isVisible = true;
            if (live == 3)
            {
                if (heart1.Visible)
                {
                    isVisible= false;
                    heart1.Visible = false;
                }
                else
                {
                    isVisible = true;
                    heart1.Visible = true;
                }
            }
            else if (live == 2)
            {
                if (heart2.Visible)
                {
                    isVisible = false;
                    heart2.Visible = false;
                }
                else
                {
                    isVisible = true;
                    heart2.Visible = true;
                }
            }
            else if (live == 1)
            {
                if (heart3.Visible)
                {
                    isVisible = false;
                    heart3.Visible = false;
                }
                else
                {
                    isVisible = true;
                    heart3.Visible = true;
                }
            }
            // Toggle the blinking state
            isBlinking = !isBlinking;

            // Refresh the PictureBox to update the snake's appearance
            picCanvas.Invalidate();

            blinkCount++;
            if (blinkCount >= 8) // Adjust the number based on the desired number of blinks
            {
                live--;
                isHit = false;
                heartAnim.Stop();
            }
        }

        private void gameForm_Load(object sender, EventArgs e)
        {
            startButton.Visible = true;
            startButton.Enabled = true;
            startButton.BringToFront();

            diffCB.Enabled = true;
            diffCB.Visible= true;
            diffCB.BringToFront();

            diffCB.Items.Add("EASY");
            diffCB.Items.Add("MEDIUM");
            diffCB.Items.Add("HARD");
            diffCB.SelectedIndex = 0;

            gameOverLabel.BackColor = Color.Transparent;
            heart1.BackColor = Color.Transparent;
            heart2.BackColor = Color.Transparent;
            heart3.BackColor = Color.Transparent;

            heart1.Parent = picCanvas; heart2.Parent = picCanvas; heart3.Parent = picCanvas;
            heart1.Location = new Point(picCanvas.Width - heart1.Width - 10, 5);
            heart2.Location = new Point(picCanvas.Width - heart1.Width * 2 - 5 * 2, 5);
            heart3.Location = new Point(picCanvas.Width - heart1.Width * 3 - 4 * 3, 5);

            gameOverLabel.Left = (ClientSize.Width - gameOverLabel.Width) / 2;
            labelY = ClientSize.Height;

            timer = new Timer();

            timer.Interval = 5;
            timer.Tick += Timer_Tick;
            timer.Stop();
            gameOverLabel.Visible = false;
            gameOverLabel.Enabled = false;

            this.Refresh();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsedTime = DateTime.Now - startTime;

            double interpolation = Math.Min(1, elapsedTime.TotalMilliseconds / AnimationDuration);

            int newY = (int)(labelY - (labelY - ClientSize.Height / 2) * interpolation);
            gameOverLabel.Top = newY;

            if (interpolation >= 1)
            {
                timer.Stop();
                timer.Dispose();

                Timer delayTimer = new Timer();
                delayTimer.Interval = 3000;
                delayTimer.Tick += DelayTimer_Tick;
                delayTimer.Start();
            }
        }
        private void DelayTimer_Tick(object sender, EventArgs e)
        {
            // Stop the timer
            ((Timer)sender).Stop();
            // Hide the label
            gameOverLabel.Visible = false;
            gameOverLabel.Enabled = false;
            startButton.Enabled = true;
            diffCB.Enabled = true;
        }

        private void gameOverLabel_Click(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Settings.playMenuSelect();
            this.Hide();
            start st = new start();
            st.ShowDialog();
            this.Close();
        }

        private void diffCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void diffCB_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void heart3_Click(object sender, EventArgs e)
        {

        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            keysPressed.Remove(e.KeyCode);
            KeyIsUp(e.KeyCode);
            base.OnKeyUp(e);
        }

        private void KeyIsDown(Keys key)
        {
            if (key == Keys.Left && Settings.directions != "right")
            {
                goLeft = true;
            }
            if (key == Keys.Right && Settings.directions != "left")
            {
                goRight = true;
            }
            if (key == Keys.Up && Settings.directions != "down")
            {
                goUp = true;
            }
            if (key == Keys.Down && Settings.directions != "up")
            {
                goDown = true;
            }
        }

        private void KeyIsUp(Keys key)
        {
            if (key == Keys.Left)
            {
                goLeft = false;
            }
            if (key == Keys.Right)
            {
                goRight = false;
            }
            if (key == Keys.Up)
            {
                goUp = false;
            }
            if (key == Keys.Down)
            {
                goDown = false;
            }
        }
    }

}
