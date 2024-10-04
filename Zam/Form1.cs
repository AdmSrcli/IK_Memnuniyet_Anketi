namespace Zam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i = 1;
        string[] sorular = { "x", "Maaşınızdan memnunmusunuz?",
            "Şirket ve Yöneticileriniz Size Değer veriyormu?", 
            "Pozisyonunuzdan memnunmusunuz?",
            "Zam Oranlarınızdan memnunmuzunuz?",
            "%50 Üstü enflasyonist ortamda sizce zam oranınız kaç olmalı?",
            "Aynı şartlarda önümüzdeki yıllarda çalışmaya devam etmek istiyormusunuz?"};


        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "SORU" + ":" + i.ToString();
            label2.Text = sorular[i].ToString();
            pictureBox2.Visible = false;
            progressBar1.Value = 0;

            Point p = new Point();
            p.X = 443;
            p.Y = 654;
            btnhayir.Location = p;

            Point p1 = new Point();
            p1.X = 1049;
            p1.Y = 654;
            btnevet.Location = p1;


        }

        private void btnevet_Click(object sender, EventArgs e)

        {          
           

            Point p = new Point();
            p.X = 443;
            p.Y = 654;
            btnhayir.Location = p;

            Point p1 = new Point();
            p1.X = 1049;
            p1.Y = 654;
            btnevet.Location = p1;

            double orn = i * 16.67;
            
                progressBar1.Value = Convert.ToInt16(orn);
                lblmemnuniyet.Text = "Memnuniyet Oranı:" + "  " +"%"+" "+ progressBar1.Value.ToString();
            

            i = i + 1;
            if (i < 7)
            {
               

               


                label1.Text = "SORU" +" "+  i.ToString()+" "+":" ;
                label2.Text = sorular[i].ToString();
                
                if (i == 5)
                {
                    btnevet.Text = "%10 ve Altı";
                    btnhayir.Text = "%50 ve Üstü";
                    btnhayir.AutoSize = true;
                    btnevet.AutoSize = true;
                    btnevet.BackColor=Color.White;
                    btnhayir.BackColor=Color.White;

                }

                if (i == 6)
                {
                    btnevet.Text = "TABİKİ EVET!!!";
                    btnevet.AutoSize= true;
                    btnhayir.Text = "HAYIR";
                }
            }

            else
            {
                label1.ForeColor = Color.Blue;
                label2.ForeColor = Color.White;
                label1.Text = "SONUÇ" + " " + ":";
                label2.Text = "BİZDE AYNEN BÖYLE DÜŞÜNDÜK :)"+ "\n" + "\n"+
                    "Tebrikler tam aradığımız personelsiniz!!!" + "\n" + "\n" + 
                    "İşinize kaldığınız yerden devam edebilirsiniz!" + "\n" + "\n" + 
                    "Sizin Gibi Özverili ve Zeki Bir Çalışan Kolay Bulunmuyor! :)" + "\n" + "\n" +
                    "                       "+                    "SEVGİLERLE İNSAN KAYNAKLARI...";
                btnevet.Visible = false;
                btnhayir.Visible = false;
                pictureBox2.Visible = true;
            }

        }

        private void btnhayir_MouseMove(object sender, MouseEventArgs e)
        {
            Random rd = new Random();
            Point konum=new Point();
            konum.X=rd.Next(250,600);
            konum.Y = rd.Next(50, 600);
            btnhayir.Location = konum;
        }
    }
}
