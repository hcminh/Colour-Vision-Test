using System;

namespace ColorVisionTest
{
    class Score
    {
        //khai báo các thuộc tính của lớp Score
        DateTime dateTime;
        int score;
        string name;
        public Score(int score, string name, DateTime dateTime)
        {
            this.score = score;
            this.dateTime = dateTime;
            this.name = name;
        } // hàm contructor của class Score
        public override string ToString()
        {
            return score + "-" + name + "-" + dateTime.ToString("dd/MM/yyyy");
        } // trả về chuỗi văn bản gồm điểm, tên, thời gian người chơi lưu điểm
    }
}
