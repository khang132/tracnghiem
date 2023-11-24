using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tracnghiem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            selectedAnswers = new string[questions.Length];
            NutChon();
        }
        private void NutChon()
        {
            if (ChonCauHoi >= 0 && ChonCauHoi < questions.Length)
            {
                labelQuestion.Text = questions[ChonCauHoi];
                radioButtonA.Text = answers[ChonCauHoi][0];
                radioButtonB.Text = answers[ChonCauHoi][1];
                radioButtonC.Text = answers[ChonCauHoi][2];
                radioButtonD.Text = answers[ChonCauHoi][3];
                if (selectedAnswers[ChonCauHoi] == "A")
                    radioButtonA.Checked = true;
                else if (selectedAnswers[ChonCauHoi] == "B")
                    radioButtonB.Checked = true;
                else if (selectedAnswers[ChonCauHoi] == "C")
                    radioButtonC.Checked = true;
                else if (selectedAnswers[ChonCauHoi] == "D")
                    radioButtonD.Checked = true;
                else
                {
                    radioButtonA.Checked = false;
                    radioButtonB.Checked = false;
                    radioButtonC.Checked = false;
                    radioButtonD.Checked = false;
                }

                button1.Enabled = ChonCauHoi > 0;
                button2.Enabled = ChonCauHoi < questions.Length - 1;
            }
        }
        private int ChonCauHoi = 0;
        private string[] questions = { "Câu hỏi 1: ban có bận không?", "Câu hỏi 2: ai là người cao nhất?", "Câu 3: Bạn nghĩ kì này bạn có cút môn nào không ?" };
        private string[][] answers = { new string[] { "A. không", "B. có", "C.không có bận", "D. cực bận" }, new string[] { "A. tôi", "B. bạn hàng sớm", "C. anh bạn thân", "D. người lạ" }, new string[] { "A. Lập trình web", "B. Công nghệ NET", "C. Hệ quản trị CSDL", "Trí tuệ nhân tạo" } };
        private string[] correctAnswers = { "B", "A", "A" };
        private string[] selectedAnswers;
        private string[] userAnswers = new string[2];
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButtonA_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonA.Checked)
                selectedAnswers[ChonCauHoi] = "A";
        }

        private void radioButtonB_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonA.Checked)
                selectedAnswers[ChonCauHoi] = "B";
        }

        private void radioButtonC_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonA.Checked)
                selectedAnswers[ChonCauHoi] = "C";
        }

        private void radioButtonD_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonA.Checked)
                selectedAnswers[ChonCauHoi] = "D";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChonCauHoi--;
            NutChon();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChonCauHoi++;
            NutChon();
        }
    }
}
