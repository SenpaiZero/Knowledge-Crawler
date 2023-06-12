using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Drawing.Imaging; // add this for the JPG compressor
using System.Data.SqlClient;
using Guna.UI2.WinForms;
using System.Collections;

namespace Knowledge_Crawler
{
    public partial class gameForm : Form
    {

        private List<Circle> Snake = new List<Circle>();
        private Circle[] food ={new Circle(), new Circle(), new Circle()};

        int maxWidth;
        int maxHeight;

        int score;
        int highScore;

        Random rand = new Random();

        bool goLeft, goRight, goDown, goUp;
        string correctAnswer = "A";
        string question = "";
        static int index = 0;
        static int maxIndex = 0;
        static string[] letter = new string[3];
        static string hiddenAnswer = "";
        List<string> finishedQuestion = new List<string>();
        public gameForm()
        {
            InitializeComponent();
            new Settings();
            this.KeyDown += KeyIsDown;
            this.KeyUp += KeyIsUp;
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

            return randomLetter.ToString();
        }

        private void UpdatePictureBoxGraphics(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            Brush snakeColour;

            for (int i = 0; i < Snake.Count; i++)
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
            newQuestion();
            letter[0] = correctAnswer[index].ToString();
            letter[1] = randLetter();
            letter[2] = randLetter();

            maxWidth = picCanvas.Width / Settings.Width - 1;
            maxHeight = picCanvas.Height / Settings.Height - 1;

            Snake.Clear();

            startButton.Enabled = false;
            score = 0;
            txtScore.Text = "SCOREe: " + score;

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
            Environment.Exit(0);
        }

        private void guna2Shapes2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void EatFood()
        {

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
                score += 1;
                txtScore.Text = "Score: " + score;
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
                letter[0] = correctAnswer[index].ToString();
                letter[1] = randLetter();
                letter[2] = randLetter();

            }
        }

        private void GameOver()
        {
            gameTimer.Stop();
            startButton.Enabled = true;

            if (score > highScore)
            {
                highScore = score;

                txtHighScore.Text = "HIGH SCORE: " + highScore;
                txtHighScore.ForeColor = Color.FromArgb(220, 130, 56);
                txtHighScore.TextAlign = ContentAlignment.MiddleCenter;
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
                if (correctAnswer[i] == ' ')
                    hiddenAnswer += " ";
                else
                    hiddenAnswer += "●";
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
