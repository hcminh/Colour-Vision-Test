using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ColorVisionTest
{

    public partial class Form1 : Form
    {
        //Khởi tạo các biến của class form1
        int[] shiftColor = { 105, 75, 60, 45, 30, 20, 18, 16, 15, 15, 15, 14, 14, 14, 13, 13, 13, 12, 12, 12, 11, 11, 11, 10, 10, 9, 9, 8, 8, 7, 7, 7, 7, 6, 6, 6, 6, 5, 5, 5, 5, 4, 4, 4, 4, 3, 3, 3, 3, 2, 2, 2, 2, 1, 1, 1, 1, 1 };
        bool firstClick = true;
        Button[] btn;
        int timeCount = 16;
        int widthAnimalPanel2;
        int boxGameSize;
        int addMe, redCode, greenCode, blueCode;
        int deviceNum;
        int iCorectBtn;
        int btnSize;
        Random random = new Random();
        Padding padding = new Padding(0);
        int iScore;
        int iError;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            gameStart(); // khi form load sẽ chạy hàm gameStart();
        }

        private void getReadyForGame()
        {
            iScore = 0;
            iError = 0;
            timeCount = 16;
            timeUpdate();
            updateProcessAnimal();
            bestScore.Text = getBestScore().ToString();
            widthAnimalPanel2 = this.gameHolder.Width;
            boxGameSize = this.gameBox.Height;
            btn = new Button[4];
        } // reset các giá trị để cb cho game mới
        private void gameStart()
        {
            getReadyForGame();
            setColorCode();
            Score.Text = iScore.ToString();
            Error.Text = iError.ToString();
            this.gameBox.Controls.Clear();
            createGameBox();
        } // hàm bắt đầu game chạy lần đầu 
        private void update()
        {
            corectClick();
            setColorCode();
            gameLoad();
        }   //update thông số mỗi khi user click button
        private void createGameBox()
        {
            deviceNum = getSizeForButton(iScore);
            btn = new Button[deviceNum * deviceNum];
            iCorectBtn = random.Next(deviceNum * deviceNum);
            btnSize = boxGameSize / deviceNum;
            createButton();
        } // tạo các button cho mỗi level, level càng cao càng nhiều btn
        private void corectClick()
        {
            iScore++;
            updateProcessAnimal();
        }   // hàm sử lí khi user click đúng btn
        private void updateProcessAnimal()
        {
            processAnimal.Size = new Size((widthAnimalPanel2 / 35) * iScore, processAnimal.Height);
        }   // hàm sử lí sự kiện cho khi click đúng btn thì thanh hiển thị động vật update
        private void errorClick()
        {
            iError++;
            Error.Text = iError.ToString();
            timeCount -= 2;
            timeCountDown.Text = timeCount.ToString();
        }   //xử lí sự kiện khi bấm sai btn
        private void gameLoad()
        {
            timeCount = 15;
            Score.Text = iScore.ToString();
            this.gameBox.Controls.Clear();
            createGameBox();
        } // khởi chạy lại các hàm khi qua level
        private void setColorCode()
        {
            addMe = shiftColor[iScore];
            redCode = random.Next(255 - addMe);
            blueCode = random.Next(255 - addMe);
            greenCode = random.Next(255 - addMe);
        }   // tạo random giá trị màu cho các button
        private int getSizeForButton(int level)
        {
            if (level < 2) return 2;
            else if (level < 4) return 3;
            else if (level < 8) return 4;
            else if (level < 13) return 5;
            else if (level < 22) return 6;
            else if (level < 32) return 7;
            else if (level < 36) return 8;
            else if (level < 40) return 9;
            else if (level < 44) return 10;
            else if (level < 48) return 11;
            return 12;
        }   // tạo kích thước cho các btn
        private void timeUpdate()
        {
            timeCount--;
            if (timeCount > 9)
                timeCountDown.ForeColor = Color.Green;
            else if (timeCount <= 9 && timeCount > 4)
                timeCountDown.ForeColor = Color.Yellow;
            else
                timeCountDown.ForeColor = Color.Red;
            timeCountDown.Text = timeCount.ToString();
        }   // xử lí cập nhật thời gian
        private void timeUp()
        {
            timer1.Stop();
            endGame();
        }   // xử lí game khi hết thời gian
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeCount <= 0)
                timeUp();
            else
                timeUpdate();
        }   // hàm được chạy sau mỗi ms, cập nhật xử lí thời gian
        private void refreshGameBtn_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            iScore = 0;
            iError = 0;
            iScore = 0;
            timeCount = 15;
            firstClick = true;
            timeCountDown.Text = timeCount.ToString();
            updateProcessAnimal();
            gameStart();
        }   //xử lí sự kiện khi btn refesh được nhấn
        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://hcminh.github.io");
        }   // xử lí xự kiện khi btn Author được click
        private void createButton()
        {
            int numOfBtn = btn.Length;
            Color color = Color.FromArgb(redCode, greenCode, blueCode);
            for (int i = 0; i < numOfBtn; i++)
            {
                btn[i] = new Button();
                btn[i].BackColor = color;
                btn[i].Height = btn[i].Width = btnSize;
                btn[i].Margin = padding;
                btn[i].Click += gameButtonClick;
            }
            btn[iCorectBtn].BackColor = Color.FromArgb(redCode + addMe, greenCode + addMe, blueCode + addMe);
            btn[iCorectBtn].Name = "rightBtn";
            this.gameBox.Controls.AddRange(btn);
        }   //hàm tạo các btn từ các thông số đã được cập nhật
        private void historyBtn_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(Application.StartupPath + "\\..\\..\\Resources\\score.txt");
            List<string> lines = new List<string>();
            string line = sr.ReadLine();
            while (line != null)
            {
                lines.Add(line.ToString());
                line = sr.ReadLine();
            }
            sr.Close();
            HistoryBox.Show(lines);
        }   //xử lí sự kiện khi btn history được nhấn
        private void gameButtonClick(object sender, EventArgs e)
        {
            if (firstClick)
            {
                timer1.Start();
                firstClick = false;
            }
            Button btn = sender as Button;
            if (btn.Name == "rightBtn")
                update();
            else
                errorClick();
        }   // xử lí xự kiện khi button của game được nhấn
        private void saveScore(string name)
        {
            StreamWriter streamWriter = new StreamWriter(Application.StartupPath + "\\..\\..\\Resources\\score.txt", true);
            Score saveScore = new Score(iScore, name, DateTime.Now);
            streamWriter.WriteLine(saveScore.ToString());
            streamWriter.Close();
        }   //hàm lưu điểm của người chơi
        private int getBestScore()
        {
            int bestScore = 0;
            int sc;
            StreamReader sr = new StreamReader(Application.StartupPath + "\\..\\..\\Resources\\score.txt");
            string line = sr.ReadLine();
            while (line != null)
            {
                sc = int.Parse(line.Split('-')[0]);
                if (bestScore < sc)
                    bestScore = sc;
                line = sr.ReadLine();
            }
            sr.Close();
            return bestScore;
        } // hàm lấy và hiẻn thị số điểm cao nhất đã chơi
        private string getYourProperty(int index)
        {
            StreamReader sr = new StreamReader(Application.StartupPath + "\\..\\..\\Resources\\WhoAreYou.txt");
            string line = sr.ReadLine();
            int i = 0;
            string propertyOfIndex = "";
            while (line != null)
            {
                if (i == index)
                {
                    propertyOfIndex = line.ToString();
                    break;
                }
                line = sr.ReadLine();
                i++;
            }
            sr.Close();
            return propertyOfIndex;
        }   //hiển thị thuộc tính của các con vật mà điểm người dùng đạt được
        private int getYourAnimalIndex()
        {
            if (iScore >= 30)
                return 6;
            else if (iScore < 30 && iScore >= 25)
                return 5;
            else if (iScore < 25 && iScore >= 20)
                return 4;
            else if (iScore < 20 && iScore >= 15)
                return 3;
            else if (iScore < 15 && iScore >= 10)
                return 2;
            else if (iScore < 10 && iScore >= 5)
                return 1;
            return 0;
        }   //lấy vị trí của con vật trong mảng
        private void endGame()
        {
            var name = SaveBox.Show(string.Format("{0}", getYourProperty(getYourAnimalIndex())));
            saveScore(name);
            firstClick = true;
            gameStart();
        } //xử lí khi kết thúc game
    }
}
