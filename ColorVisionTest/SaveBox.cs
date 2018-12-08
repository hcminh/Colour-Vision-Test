using System;
using System.Windows.Forms;

namespace ColorVisionTest
{
    public partial class SaveBox : Form
    {
        public SaveBox()
        {
            InitializeComponent();
        }
        // khai báo các biến để xử dụng 
        static SaveBox MsgBox;
        public static string Show(string Text)
        {
            MsgBox = new SaveBox();
            MsgBox.YourProperty.Text = Text;
            MsgBox.ShowDialog();
            return MsgBox.YourName.Text;
        } // trả về chuỗi văn bản của thuộc tính con vật và trả về tên người dùng nhập 


        private void Ok_Click(object sender, EventArgs e)
        {
            MsgBox.Close();
        }// đóng form khi bấm ok
    }
}
