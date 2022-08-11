namespace KeyboardSpeedTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        bool isStarted;
        int startMinute, startSecond;
        int endMinute, endSecond;
        int trueWord, falseWord, generatedNumber;
        //199
        string[] words = new string[]
        {
            "her","kullan�lmak","su","hemen","sorun","anlamak","ev","g�zel","ama","baz�","s�re","ara","kim","anne","bakmak","b�yle","ba�","gen�","ne","g�rmek",
            "�n","zor","y�l","s�ra","sahip","insan","biz","s�ylemek","yapmak","verilmek","orta","al�nmak","ancak","bunu","biraz","olay","sa�lamak","bile",
            "�al��mak","veya","devlet","bunlar","biri","alt","�imdi","zaman","s�z","iyi","i�in","b�rakmak","i�te","yemek","birlikte","neden","olmak","�ok",
            "yeni","koymak","ya�","taraf","ba�lamak","yol","�u","�ocuk","g�stermek","siz","�lke","ge�mek","hi�","ad","bug�n","hi�bir","girmek","uzun","i�",
            "ba�ka","hep","k���k","kalmak","yazmak","diye","bilgi","saat","��karmak","o","de�il","ses","ben","kad�n","sadece","ya","sormak","d��mek","az",
            "burada","ya�amak","el","�ekil","gelmek","almak","kar��","i�inde","b�t�n","ay","y�zde","sen","d���nmek","nas�l","gece","ayn�","duymak","b�y�k",
            "t�m","alan","yani","hayat","g�z","etmek","daha","an","kadar","vermek","ki","a�mak","anlatmak","d�nya","hal","d�nem","getirmek","y�z","var","yine",
            "durmak","gitmek","tutmak","��nk�","di�er","yer","sistem","ile","�yle","bunun","kitap","fazla","baba","i�","hem","kap�","son","bir","birbiri","�ey",
            "onun","yok","en","�zerinde","tek","art�k","ilk","yan","gibi","sonra","�nemli","�ekmek","ve","gerekmek","do�ru","�zerine","d�nmek","beklemek",
            "onlar","durum","sonu�","bulunmak","adam","ise","iki","istemek","kullanmak","bulmak","konu�mak","�nce","demek","kendi","g�n","g�re","k�z","arkada�",
            "d��","sevmek","konu","ki�i","��kmak","bilmek","para","oturmak","atmak","�r�n","bu"
        };



        private void StartButton_Click(object sender, EventArgs e)
        {
            inputText.Enabled = true;
            isStarted = true;
            startMinute = DateTime.Now.Minute;
            startSecond = DateTime.Now.Second;
            endMinute = startMinute + 1;
            endSecond = startSecond;
            generatedNumber = rnd.Next(0, 199);
            wordArea.Text = words[generatedNumber];
            falseWord = 0;
            trueWord = 0;
            timer1.Start();

            inputText.Focus();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            trueCount.Text = trueWord.ToString();
            falseCount.Text = falseWord.ToString();

            if (endMinute == DateTime.Now.Minute && endSecond == DateTime.Now.Second)
            {
                timer1.Stop();
                isStarted = false;
                wordArea.Text = "Time is UP \n" + "Your score is : " + (trueWord - falseWord).ToString();
                inputText.Enabled = false;
            }

        }

        private void keyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter && !isStarted)
            {
                StartButton_Click(sender, e);
            }

            if (e.KeyCode == Keys.Space && isStarted)
            {
                

                if (inputText.Text.Trim() == wordArea.Text)
                {
                    trueWord++;

                }
                else
                {
                    falseWord++;
                }
                generatedNumber = rnd.Next(0, 200);
                wordArea.Text = words[generatedNumber];
                inputText.Clear();


            }
        }


    }
}