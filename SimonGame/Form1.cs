using System.Diagnostics;

namespace SimonGame
{
    public partial class Form1 : Form
    {
        int blocksX = 160;
        int blocksY = 80;
        int score = 0;
        int level = 3;

        List<PictureBox> pictureBoxes = new List<PictureBox>();
        List<PictureBox> chosenBoxes = new List<PictureBox>();
        Random rand = new Random();
        Color temp;
        int index = 0;
        int tries = 0;

        int timerLimit = 0;
        bool selectingColors = false;

        string correctOrder = string.Empty;
        string playerOrder = string.Empty;

        public Form1()
        {
            InitializeComponent();
            SetUpBlocks();
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {

        }

        private void BtnClickEvent(object sender, EventArgs e)
        {
            if (score == 3 && level < 7)
            {
                level++;
                score = 0;
            }

            correctOrder = string.Empty;
            playerOrder = string.Empty;
            chosenBoxes.Clear();
            chosenBoxes = pictureBoxes.OrderBy(x => rand.Next()).Take(level).ToList();

            for (int i = 0; i < chosenBoxes.Count; i++)
            {
                correctOrder += chosenBoxes[i].Name + " ";
            }

            foreach (PictureBox x in pictureBoxes)
            {
                x.BackColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
            }

            Debug.WriteLine(correctOrder);
            index = 0;
            timerLimit = 0;
            selectingColors = true;
            GameTimer.Start();
        }

        private void SetUpBlocks()
        {
            for (int i = 1; i < 17; i++)
            {
                PictureBox newPic = new PictureBox();
                newPic.Name = "pic_" + i;
                newPic.Height = 60;
                newPic.Width = 60;
                newPic.BackColor = Color.Black;
                newPic.Left = blocksX;
                newPic.Top = blocksY;
                newPic.Click += CllickOnPictureBox;

                if (i == 4 || i == 8 || i == 12)
                {
                    blocksY += 65;
                    blocksX = 160;
                }
                else
                {
                    blocksX += 65;
                }

                this.Controls.Add(newPic);
                pictureBoxes.Add(newPic);
            }
        }

        private void CllickOnPictureBox(object? sender, EventArgs e)
        {

        }
    }
}
