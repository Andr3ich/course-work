using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UkrainianCultureQuizGame
{
    public partial class Form1 : Form
    {

        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;

        public Form1()
        {
            InitializeComponent();

            askQuestion(questionNumber);

            totalQuestions = 10;
        }

        private void lblQuestion_Click(object sender, EventArgs e)
        {

        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if(buttonTag == correctAnswer)
            {
                score++;
            }

            if(questionNumber == totalQuestions)
            {

                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);

                MessageBox.Show(
                    "Вiкторину завершено!" + Environment.NewLine +
                    "Ви вiдповiли на " + score + " питань правильно." + Environment.NewLine +
                    "Вiдсоток правильних вiдповiдей - " +percentage + "%" + Environment.NewLine +
                    "Натиснiть OK щоб грати знову"
                    );

                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);
            }

            questionNumber++;
            askQuestion(questionNumber);

        }

        private void askQuestion(int qnum)
        {

            switch (qnum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.question1;

                    lblQuestion.Text = "Вiдтворена гетьманська резиденцiя ХVII ст. знаходиться у містi:";

                    button1.Text = "Чигирин";
                    button2.Text = "Глухiв";
                    button3.Text = "Батурин";
                    button4.Text = "Канiв";

                    correctAnswer = 1;

                    break;

                case 2:
                    pictureBox1.Image = Properties.Resources.question2;

                    lblQuestion.Text = "Де встановлено цей пам'ятник козакам та селянам повстанцям?";

                    button1.Text = "в урочищi Холодний яр";
                    button2.Text = "на територiї Нацiонального iсторико-меморiального заповiдника «Поле Берестецької битви»";
                    button3.Text = "на островi Хортиця";
                    button4.Text = "в мiстi Чигирин";

                    correctAnswer = 2;

                    break;

                case 3:
                    pictureBox1.Image = Properties.Resources.question3;

                    lblQuestion.Text = "За цiєю свiтлиною можна впiзнати мiсто-музей";

                    button1.Text = "Київ";
                    button2.Text = "Чернiгiв";
                    button3.Text = "Одеса";
                    button4.Text = "Львiв";

                    correctAnswer = 2;

                    break;

                case 4:
                    pictureBox1.Image = Properties.Resources.question4;

                    lblQuestion.Text = "Ймовiрне мiсце загибелi Святослава Хороброго знаходиться на територiї:";

                    button1.Text = "Дунайського бiосферного заповiдника";
                    button2.Text = "Карпатського бiосферного заповiдника";
                    button3.Text = "Нацiональний заповiдник Хортиця";
                    button4.Text = "Канiвського природного заповiдника";

                    correctAnswer = 3;

                    break;

                case 5:
                    pictureBox1.Image = Properties.Resources.question5;

                    lblQuestion.Text = "На фото зображено:";

                    button1.Text = "Дендропарк «Олександрiя»";
                    button2.Text = "Нацiональний дендрологiчний парк «Софiївка»";
                    button3.Text = "Бiосферний заповiдник «Асканiя-Нова»";
                    button4.Text = "Державний дендрологiчний парк «Тростянець» НАН України";

                    correctAnswer = 2;

                    break;

                case 6:
                    pictureBox1.Image = Properties.Resources.question6;

                    lblQuestion.Text = "Назва об'єкта культурної спадщини:";

                    button1.Text = "Обелiск венедiв";
                    button2.Text = "Збручанський iдол";
                    button3.Text = "Половецька баба";
                    button4.Text = "Скiфський перун";

                    correctAnswer = 2;

                    break;

                case 7:
                    pictureBox1.Image = Properties.Resources.question7;

                    lblQuestion.Text = "Один iз мостiв через Днiпро у Києвi. Перший у свiтi суцiльнозварний мiст завдовжки 1543 метри?";

                    button1.Text = "Пiвденний мiст";
                    button2.Text = "Мiст iменi Патона";
                    button3.Text = "Мерефо-Херсонський мiст";
                    button4.Text = "Дев’ятиарковий мiст";

                    correctAnswer = 2;

                    break;

                case 8:
                    pictureBox1.Image = Properties.Resources.question8;

                    lblQuestion.Text = "Один iз найдавнiших в Українi замкiв, iмовiрно, побудований одним iз синiв галицько-волинського князя Юрiя Львовича на плато пагорба, який височить серед заплави р. Лiберцiя. Його назва:";

                    button1.Text = "Олеський";
                    button2.Text = "Корецький";
                    button3.Text = "Меджибiзький";
                    button4.Text = "Високий";

                    correctAnswer = 1;

                    break;

                case 9:
                    pictureBox1.Image = Properties.Resources.question9;

                    lblQuestion.Text = "Цей пам'ятник Т.Г.Шевченку вважається найкрасивiшим в Європi памятником Кобзарю. Вiн знаходиться у мiстi-музеї:";

                    button1.Text = "Київ";
                    button2.Text = "Полтава";
                    button3.Text = "Харкiв";
                    button4.Text = "Львiв";

                    correctAnswer = 3;

                    break;

                case 10:
                    pictureBox1.Image = Properties.Resources.question10;

                    lblQuestion.Text = "Центральна площа мiста має форму кiльця, посеред якого розташований Корпусний сад iз монументом Слави. Це мiсто-музей:";

                    button1.Text = "Днiпро";
                    button2.Text = "Полтава";
                    button3.Text = "Харкiв";
                    button4.Text = "Одеса";

                    correctAnswer = 2;

                    break;
            }
        }

    }
}
