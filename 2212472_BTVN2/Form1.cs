using System;
using System.Windows.Forms;

namespace SimpleCrosswordGame
{
    public partial class Form1 : Form
    {
        private string[] answers = { "apple", "orange", "banana" };
        private int currentIndex = 0;

        public Form1()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            // Khởi tạo trò chơi
            currentIndex = 0;
            lblHint.Text = "Nhập một loại trái cây: ";
            txtAnswer.Text = string.Empty;
            txtAnswer.Focus();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string userAnswer = txtAnswer.Text.Trim().ToLower();

            if (userAnswer == answers[currentIndex])
            {
                lblResult.Text = "Chính xác!";
                currentIndex++;

                if (currentIndex < answers.Length)
                {
                    lblHint.Text = "Nhập một loại trái cây khác: ";
                    txtAnswer.Text = string.Empty;
                }
                else
                {
                    lblHint.Text = "Chúc mừng! Bạn đã hoàn thành trò chơi.";
                    txtAnswer.Enabled = false;
                    btnCheck.Enabled = false;
                }
            }
            else
            {
                lblResult.Text = "Sai rồi! Thử lại!";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeGame();
        }
    }
}