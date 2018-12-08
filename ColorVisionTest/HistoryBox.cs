using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ColorVisionTest
{
    public partial class HistoryBox : Form
    {
        public HistoryBox()
        {
            InitializeComponent();
        }

        // khai báo các biến để xử dụng form như 1 messageBox
        static HistoryBox MsgBox;
        static DialogResult result = DialogResult.No;
        public static DialogResult Show(List<string> Text)
        {
            MsgBox = new HistoryBox();
            for (int i = Text.Count - 1; i >= 0; i--)
            {
                var arr = Text[i].Split('-');
                Button[] btn = new Button[3];
                for (int j = 0; j < arr.Length; j++)
                {
                    btn[j] = new Button();
                    btn[j].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    btn[j].BackColor = Color.LightGreen;
                    btn[j].Width = 176;
                    btn[j].Height = 45;
                    btn[j].Text = arr[j].ToString();
                }
                btn[0].Width = 160;
                MsgBox.ScoreLayoutPanel.Controls.Add(btn[0]);
                MsgBox.NameLayoutPanel.Controls.Add(btn[1]);
                MsgBox.DateLayoutPanel.Controls.Add(btn[2]);
            }
            MsgBox.ShowDialog();
            return result;
        }   // viết lại hàm Show để thực hiên hiển thị các điểm đạt được của người dùng


        private void Ok_Click(object sender, EventArgs e)
        {
            result = DialogResult.Yes;
            MsgBox.Close();
        }   // đóng form khi bấm ok

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }//bấm nhầm
    }
}
