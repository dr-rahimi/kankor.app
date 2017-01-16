using System;
using System.Windows.Forms;

namespace Kankor_beta
{
    public partial class Questions : Form
    {
        double NQ = 20;
        int CurrentQuestion;
        int CurrentNumberOfQuestions;
        double sum=0;
        int[] sumx = new int[21];

        void PresentQuestion(int qstNumber)
        {
            lblQ.Visible = true;
            radioButton1.Checked = radioButton2.Checked = radioButton3.Checked = radioButton4.Checked = false;
            switch (qstNumber)
            {
                case 1:
                    lblQ.Text = "1.	تواریخ حافظ رحمت خانی توسط چه کسی نوشته شده است؟";

                    radioButton1.Text = "قاضی دل محمد خان";
                    radioButton2.Text = "حافظ رحمت خان";
                    radioButton3.Text = "میر محمد فاضل";
                    radioButton4.Text = "محمود الحسینی";
                    break;
                case 2:
                    lblQ.Text = "2.	درجنگ پانی پت تعدادسپاه احمدشاه بابا به چه تعداد میرسید:";

                    radioButton1.Text = "70 هزار";
                    radioButton2.Text = "50 هزار";
                    radioButton3.Text = "60 هزار";
                    radioButton4.Text = "55 هزار";
                    break;
                case 3:
                    lblQ.Text = "3.	کدام مذاکرات بین دولت افغانستان وانگلیس مدت سه ماه رادربرگرفت:";

                    radioButton1.Text = "مونسوری";
                    radioButton2.Text = "لاهور";
                    radioButton3.Text = "کابل";
                    radioButton4.Text = "راولپندی";
                    break;
                case 4:
                    lblQ.Text = "4.	در تابستان سال 1943م نیرو های انگلسی وآمریکای کدام مناطق راتصرف کردند؟";

                    radioButton1.Text = " سیسیل";
                    radioButton2.Text = "لهستان";
                    radioButton3.Text = "اتریش";
                    radioButton4.Text = "همه درست است";
                    break;
                case 5:
                    lblQ.Text = "5.	بعدازمرگ امیرحبیب الله خان، امان الله خان دریکی ازولایات ذیل اعلان سلطنت کرد:";

                    radioButton1.Text = "جلال آباد";
                    radioButton2.Text = "کابل";
                    radioButton3.Text = "وردک";
                    radioButton4.Text = "کندهار";
                    break;
                case 6:
                    lblQ.Text = "6.	شاه محمود یکی ازاشخاص ذیل رابرای سرزنش دوست محمدخان به هرات فرستاد:";

                    radioButton1.Text = "عطامحمدخان";
                    radioButton2.Text = "فیروزالدین";
                    radioButton3.Text = "شاهزاده کامران";
                    radioButton4.Text = "محمد اکبر خان";
                    break;
                case 7:
                    lblQ.Text = "7.	دوره سلطنت سدوزای ها دریکی ازسال های ذیل درکشور آغازگردیده؟";

                    radioButton1.Text = "1709";
                    radioButton2.Text = "1747";
                    radioButton3.Text = "1885";
                    radioButton4.Text = "1818";
                    break;
                case 8:
                    lblQ.Text = "8.	یکی ازحکمرانان ذیل درقصردلکشاه به قتل رسید؟";

                    radioButton1.Text = "محمد نادرشاه";
                    radioButton2.Text = "حبیب الله خان";
                    radioButton3.Text = "شاه شجاع";
                    radioButton4.Text = "شاه زمان";
                    break;
                case 9:
                    lblQ.Text = "9.	جنگ پانی پت دریکی سال های ذیل به وقوع پیوست؟";

                    radioButton1.Text = "1755م";
                    radioButton2.Text = "1757م";
                    radioButton3.Text = "1751م";
                    radioButton4.Text = "هیچکدام";
                    break;
                case 10:
                    lblQ.Text = "10.	در 22 اگست 1944 م کدام شهرتوسط نیرو ها متفقین آزاد شد:";

                    radioButton1.Text = "پاریس";
                    radioButton2.Text = "هیچکدام";
                    radioButton3.Text = "ونیز";
                    radioButton4.Text = "یورکشایر";
                    break;
                case 11:
                    lblQ.Text = "11.	امیرشیرعلی خان درکجا دفن گردید؟";

                    radioButton1.Text = "کندهار";
                    radioButton2.Text = "مزار شریف";
                    radioButton3.Text = "کابل";
                    radioButton4.Text = "هرات";
                    break;
                case 12:
                    lblQ.Text = "12.	کدام شخص درمحلی بنام جلندرتعدادزیادافغان هارکشت؟";

                    radioButton1.Text = "نجیب الدوله";
                    radioButton2.Text = "آدینه بیگ";
                    radioButton3.Text = "میرمنو";
                    radioButton4.Text = "عالمگیر";
                    break;
                case 13:
                    lblQ.Text = "13.	کدام مارک معتبر موتر از جاپان نیست؟";

                    radioButton1.Text = "داستن";
                    radioButton2.Text = "تسلا";
                    radioButton3.Text = "ميتسوبيشى";
                    radioButton4.Text = "نیسان";
                    break;
                case 14:
                    lblQ.Text = "14.	دوران معاصر جاپان در کدام سال آغاز شد؟";

                    radioButton1.Text = "1885م";
                    radioButton2.Text = "1868م";
                    radioButton3.Text = "1912م";
                    radioButton4.Text = "1938م";
                    break;
                case 15:
                    lblQ.Text = "15.	مجلس عوام بریتانیا چند عضو دارد؟";

                    radioButton1.Text = "500";
                    radioButton2.Text = "659";
                    radioButton3.Text = "321";
                    radioButton4.Text = "256";
                    break;
                case 16:
                    lblQ.Text = "16.	اتحاد جماهیر شوروی در کدام سال در افغانستان شکست خورد؟";

                    radioButton1.Text = "1991م";
                    radioButton2.Text = "1978م";
                    radioButton3.Text = "1998م";
                    radioButton4.Text = "1989م";
                    break;
                case 17:
                    lblQ.Text = "17.	جنگ جهانی دوم با تسلیم شدن کدام کشور در سال 1945م ختم شد؟";

                    radioButton1.Text = "ایتالیا";
                    radioButton2.Text = "آلمان";
                    radioButton3.Text = "جاپان";
                    radioButton4.Text = "شوروی";
                    break;
                case 18:
                    lblQ.Text = "18.	بنیان گذار  قدرت و حکومت ازبک ها را در آسیای میانه کی بود؟";

                    radioButton1.Text = "ازبک خان";
                    radioButton2.Text = "شیبک خان (محمد خان)";
                    radioButton3.Text = "ابوالخیر خان";
                    radioButton4.Text = "عبیدالله خان";
                    break;
                case 19:
                    lblQ.Text = "19.	کدام شخص در ایران مامور بود تا رفراندم برای تغییر نظام برگذار کند؟";

                    radioButton1.Text = "امام خمینی";
                    radioButton2.Text = "مهندس بازرگان";
                    radioButton3.Text = "علامه طباطبایی";
                    radioButton4.Text = "محمد مصدق";
                    break;
                case 20:
                    lblQ.Text = "20.	حبیب الله کلکانی به مدت ماه حکمروایی کرد؟";

                    radioButton1.Text = "نه ماه";
                    radioButton2.Text = "یکسال";
                    radioButton3.Text = "هفت ماه";
                    radioButton4.Text = "شش ماه";
                    break;
            }
        }

        void CheckAnswer(int qstNumber)
        {
            switch(qstNumber)
            {
                case 1:
                    if      (radioButton1.Checked == true) sumx[1] = 0;
                    else if (radioButton2.Checked == true) sumx[1] = 0;
                    else if (radioButton3.Checked == true) sumx[1] = 1;
                    else if (radioButton4.Checked == true) sumx[1] = 0;
                    break;
                case 2:
                    if      (radioButton1.Checked == true) sumx[2] = 0;
                    else if (radioButton2.Checked == true) sumx[2] = 0;
                    else if (radioButton3.Checked == true) sumx[2] = 1;
                    else if (radioButton4.Checked == true) sumx[2] = 0;
                    break;
                case 3:
                    if      (radioButton1.Checked == true) sumx[3] = 1;
                    else if (radioButton2.Checked == true) sumx[3] = 0;
                    else if (radioButton3.Checked == true) sumx[3] = 0;
                    else if (radioButton4.Checked == true) sumx[3] = 0;
                    break;
                case 4:
                    if (radioButton1.Checked == true) sumx[4] = 1;
                    else if (radioButton2.Checked == true) sumx[4] = 0;
                    else if (radioButton3.Checked == true) sumx[4] = 0;
                    else if (radioButton4.Checked == true) sumx[4] = 0;
                    break;
                case 5:
                    if (radioButton1.Checked == true) sumx[5] = 0;
                    else if (radioButton2.Checked == true) sumx[5] = 1;
                    else if (radioButton3.Checked == true) sumx[5] = 0;
                    else if (radioButton4.Checked == true) sumx[5] = 0;
                    break;
                case 6:
                    if (radioButton1.Checked == true) sumx[6] = 0;
                    else if (radioButton2.Checked == true) sumx[6] = 0;
                    else if (radioButton3.Checked == true) sumx[6] = 1;
                    else if (radioButton4.Checked == true) sumx[6] = 0;
                    break;
                case 7:
                    if (radioButton1.Checked == true) sumx[7] = 0;
                    else if (radioButton2.Checked == true) sumx[7] = 1;
                    else if (radioButton3.Checked == true) sumx[7] = 0;
                    else if (radioButton4.Checked == true) sumx[7] = 0;
                    break;
                case 8:
                    if (radioButton1.Checked == true) sumx[8] = 1;
                    else if (radioButton2.Checked == true) sumx[8] = 0;
                    else if (radioButton3.Checked == true) sumx[8] = 0;
                    else if (radioButton4.Checked == true) sumx[8] = 0;
                    break;
                case 9:
                    if (radioButton1.Checked == true) sumx[9] = 0;
                    else if (radioButton2.Checked == true) sumx[9] = 0;
                    else if (radioButton3.Checked == true) sumx[9] = 0;
                    else if (radioButton4.Checked == true) sumx[9] = 1;
                    break;
                case 10:
                    if (radioButton1.Checked == true) sumx[10] = 1;
                    else if (radioButton2.Checked == true) sumx[10] = 0;
                    else if (radioButton3.Checked == true) sumx[10] = 0;
                    else if (radioButton4.Checked == true) sumx[10] = 0;
                    break;
                case 11:
                    if (radioButton1.Checked == true) sumx[11] = 0;
                    else if (radioButton2.Checked == true) sumx[11] = 1;
                    else if (radioButton3.Checked == true) sumx[11] = 0;
                    else if (radioButton4.Checked == true) sumx[11] = 0;
                    break;
                case 12:
                    if (radioButton1.Checked == true) sumx[12] = 0;
                    else if (radioButton2.Checked == true) sumx[12] = 1;
                    else if (radioButton3.Checked == true) sumx[12] = 0;
                    else if (radioButton4.Checked == true) sumx[12] = 0;
                    break;
                case 13:
                    if (radioButton1.Checked == true) sumx[13] = 0;
                    else if (radioButton2.Checked == true) sumx[13] = 1;
                    else if (radioButton3.Checked == true) sumx[13] = 0;
                    else if (radioButton4.Checked == true) sumx[13] = 0;
                    break;
                case 14:
                    if (radioButton1.Checked == true) sumx[14] = 0;
                    else if (radioButton2.Checked == true) sumx[14] = 1;
                    else if (radioButton3.Checked == true) sumx[14] = 0;
                    else if (radioButton4.Checked == true) sumx[14] = 0;
                    break;
                case 15:
                    if (radioButton1.Checked == true) sumx[15] = 0;
                    else if (radioButton2.Checked == true) sumx[15] = 1;
                    else if (radioButton3.Checked == true) sumx[15] = 0;
                    else if (radioButton4.Checked == true) sumx[15] = 0;
                    break;
                case 16:
                    if (radioButton1.Checked == true) sumx[16] = 0;
                    else if (radioButton2.Checked == true) sumx[16] = 0;
                    else if (radioButton3.Checked == true) sumx[16] = 0;
                    else if (radioButton4.Checked == true) sumx[16] = 1;
                    break;
                case 17:
                    if (radioButton1.Checked == true) sumx[17] = 0;
                    else if (radioButton2.Checked == true) sumx[17] = 0;
                    else if (radioButton3.Checked == true) sumx[17] = 1;
                    else if (radioButton4.Checked == true) sumx[17] = 0;
                    break;
                case 18:
                    if (radioButton1.Checked == true) sumx[18] = 0;
                    else if (radioButton2.Checked == true) sumx[18] = 0;
                    else if (radioButton3.Checked == true) sumx[18] = 1;
                    else if (radioButton4.Checked == true) sumx[18] = 0;
                    break;
                case 19:
                    if (radioButton1.Checked == true) sumx[19] = 0;
                    else if (radioButton2.Checked == true) sumx[19] = 1;
                    else if (radioButton3.Checked == true) sumx[19] = 0;
                    else if (radioButton4.Checked == true) sumx[19] = 0;
                    break;
                case 20:
                    if (radioButton1.Checked == true) sumx[20] = 1;
                    else if (radioButton2.Checked == true) sumx[20] = 0;
                    else if (radioButton3.Checked == true) sumx[20] = 0;
                    else if (radioButton4.Checked == true) sumx[20] = 0;
                    break;
            }

        }
        public Questions()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            sumx[0] = 0;
            if (MessageBox.Show("!آماده اید", "سوالات تاریخ صنف 12 گروپ ویژه نسخه آزمایشی", MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                btnNextQ_Click(sender, e);
                btnPreviousQ.Enabled = false;
            }
            else
            {
                Application.Exit();
            }
        }

        private void btnNextQ_Click(object sender, EventArgs e)
        {
            CurrentNumberOfQuestions++;
            CheckAnswer(CurrentQuestion);
            btnPreviousQ.Enabled = true;

            CurrentQuestion++;

            sum = 0;
            foreach (int i in sumx)
            {
                sum += i;
            }

            if (CurrentQuestion == 21)
            {
                groupBox1.Visible = false;
                btnNextQ.Enabled = false;
                lblQ.Text = " شما" + sum + " نمره از " + NQ + " نمره گرفتید."+"\n" + sum / NQ * 100 + " %";
                MessageBox.Show("!سوالات تمام شد" + "\n.نتیجه شما " + sum + " از " + NQ + " است"+"\n"+ sum / NQ * 100 + " %");
            }
            else
            {
                PresentQuestion(CurrentQuestion);
            }
        }

        private void btnPreviousQ_Click(object sender, EventArgs e)
        {
            CurrentNumberOfQuestions--;
            CheckAnswer(CurrentQuestion);

            lblQ.Visible = true;
            groupBox1.Visible = true;
            btnNextQ.Enabled = true;

            CurrentQuestion--;

            if (CurrentQuestion == 0)
            {
                btnPreviousQ.Enabled = false;
            }
            else
            {
                PresentQuestion(CurrentQuestion);
            }
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            MessageBox.Show(".نتیجه شما "+sum+" از "+ NQ+" است"+ "\n" + sum / NQ * 100 + " %");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
