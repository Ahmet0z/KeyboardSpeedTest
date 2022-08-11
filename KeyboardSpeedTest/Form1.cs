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
            "her","kullanýlmak","su","hemen","sorun","anlamak","ev","güzel","ama","bazý","süre","ara","kim","anne","bakmak","böyle","baþ","genç","ne","görmek",
            "ön","zor","yýl","sýra","sahip","insan","biz","söylemek","yapmak","verilmek","orta","alýnmak","ancak","bunu","biraz","olay","saðlamak","bile",
            "çalýþmak","veya","devlet","bunlar","biri","alt","þimdi","zaman","söz","iyi","için","býrakmak","iþte","yemek","birlikte","neden","olmak","çok",
            "yeni","koymak","yaþ","taraf","baþlamak","yol","þu","çocuk","göstermek","siz","ülke","geçmek","hiç","ad","bugün","hiçbir","girmek","uzun","iþ",
            "baþka","hep","küçük","kalmak","yazmak","diye","bilgi","saat","çýkarmak","o","deðil","ses","ben","kadýn","sadece","ya","sormak","düþmek","az",
            "burada","yaþamak","el","þekil","gelmek","almak","karþý","içinde","bütün","ay","yüzde","sen","düþünmek","nasýl","gece","ayný","duymak","büyük",
            "tüm","alan","yani","hayat","göz","etmek","daha","an","kadar","vermek","ki","açmak","anlatmak","dünya","hal","dönem","getirmek","yüz","var","yine",
            "durmak","gitmek","tutmak","çünkü","diðer","yer","sistem","ile","öyle","bunun","kitap","fazla","baba","iç","hem","kapý","son","bir","birbiri","þey",
            "onun","yok","en","üzerinde","tek","artýk","ilk","yan","gibi","sonra","önemli","çekmek","ve","gerekmek","doðru","üzerine","dönmek","beklemek",
            "onlar","durum","sonuç","bulunmak","adam","ise","iki","istemek","kullanmak","bulmak","konuþmak","önce","demek","kendi","gün","göre","kýz","arkadaþ",
            "dýþ","sevmek","konu","kiþi","çýkmak","bilmek","para","oturmak","atmak","ürün","bu"
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