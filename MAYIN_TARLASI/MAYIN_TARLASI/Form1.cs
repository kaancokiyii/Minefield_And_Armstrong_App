using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAYIN_TARLASI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Button[,] bizim_buton = new Button[5, 5];
        void temizle()
        {

            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    bizim_buton[i, j].Dispose();


        }
        int süre;
        int değer;
        public int _msay;
      //  ipucu ip;
        public int rsayi;
        
        
        Form frm = new Form();
        
        
        public int msay;
        void hileEkran()
        {


            frm.Controls.Clear();
            frm.Width = 290;
            frm.Height = 315;
            Panel frmPanel = new Panel();
            frmPanel.Dock = DockStyle.Fill;
            frmPanel.BackColor = Color.White;
            Button[,] bizim_butonn = new Button[5, 5];

           
                
            int _sayi = 0;
            
           
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {   
                    

                    bizim_butonn[i, j] = new Button();
                    bizim_butonn[i, j].Size = new Size(50, 50);
                    bizim_butonn[i, j].Location = new Point(i * 50 + 5, j * 50 + 5);
                    bizim_butonn[i, j].Name = "KUTU" + (i * 6 + j).ToString();
                    bizim_butonn[i, j].Text = "0";
                    bizim_butonn[i, j].Tag = "0";
                    
                    if(listBox1.Items.Contains(_sayi.ToString()))
                    {
                        bizim_butonn[i, j].BackColor = Color.Red;
                        bizim_butonn[i, j].Tag = "M";

                    }
                    else
                    {
                        bizim_butonn[i, j].BackColor = Color.Green;
                    }
                    frmPanel.Controls.Add(bizim_butonn[i, j]);
                    _sayi++;

                }

            }



            //Mayınların Yazısı 


            int sayi;

            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                {
                    sayi = 0;
                    if (bizim_butonn[i, j].Tag.ToString() != "M" )
                    {
                        if (i != 4)
                        {
                            if (bizim_butonn[i + 1, j].Tag.ToString() == "M")
                            {
                                sayi = Convert.ToInt32(bizim_butonn[i, j].Tag.ToString());
                                sayi++;
                                bizim_butonn[i, j].Tag = sayi.ToString();
                                bizim_butonn[i, j].Text = sayi.ToString();


                            }
                            if (j != 4)
                            {
                                if (bizim_butonn[i + 1, j + 1].Tag.ToString() == "M")
                                {
                                    sayi = Convert.ToInt32(bizim_butonn[i, j].Tag.ToString());
                                    sayi++;
                                    bizim_butonn[i, j].Tag = sayi.ToString();
                                    bizim_butonn[i, j].Text = sayi.ToString();
                                }

                            }
                            if (j != 0)
                            {
                                if (bizim_butonn[i + 1, j - 1].Tag.ToString() == "M")
                                {
                                    sayi = Convert.ToInt32(bizim_butonn[i, j].Tag.ToString());
                                    sayi++;
                                    bizim_butonn[i, j].Tag = sayi.ToString();
                                    bizim_butonn[i, j].Text = sayi.ToString();
                                }

                            }

                        }
                        if (i != 0)
                        {
                            if (bizim_butonn[i - 1, j].Tag.ToString() == "M")
                            {

                                sayi = Convert.ToInt32(bizim_butonn[i, j].Tag.ToString());
                                sayi++;
                                bizim_butonn[i, j].Tag = sayi.ToString();
                                bizim_butonn[i, j].Text = sayi.ToString();
                            }
                            if (j != 4)
                            {
                                if (bizim_butonn[i - 1, j + 1].Tag.ToString() == "M")
                                {
                                    sayi = Convert.ToInt32(bizim_butonn[i, j].Tag.ToString());
                                    sayi++;
                                    bizim_butonn[i, j].Tag = sayi.ToString();
                                    bizim_butonn[i, j].Text = sayi.ToString();
                                }

                            }
                            if (j != 0)
                            {
                                if (bizim_butonn[i - 1, j - 1].Tag.ToString() == "M")
                                {
                                    sayi = Convert.ToInt32(bizim_butonn[i, j].Tag.ToString());
                                    sayi++;
                                    bizim_butonn[i, j].Tag = sayi.ToString();
                                    bizim_butonn[i, j].Text = sayi.ToString();
                                }

                            }
                        }
                        if (j != 0)
                        {
                            if (bizim_butonn[i, j - 1].Tag.ToString() == "M")
                            {
                                sayi = Convert.ToInt32(bizim_butonn[i, j].Tag.ToString());
                                sayi++;
                                bizim_butonn[i, j].Tag = sayi.ToString();
                                bizim_butonn[i, j].Text = sayi.ToString();
                            }
                        }
                        if (j != 4)
                        {
                            if (bizim_butonn[i, j + 1].Tag.ToString() == "M")
                            {
                                sayi = Convert.ToInt32(bizim_butonn[i, j].Tag.ToString());
                                sayi++;
                                bizim_butonn[i, j].Tag = sayi.ToString();
                                bizim_butonn[i, j].Text = sayi.ToString();
                            }
                        }



                    }


                    ////////////////////////////////////////


                    if (bizim_butonn[i, j].Tag.ToString() == "M")
                    {
                        if (i != 4)
                        {
                            if (bizim_butonn[i + 1, j].Tag.ToString() == "M")
                            {
                                
                                sayi = Convert.ToInt32(bizim_butonn[i, j].Text.ToString());
                                sayi++;

                                bizim_butonn[i, j].Text = sayi.ToString();


                            }
                            if (j != 4)
                            {
                                if (bizim_butonn[i + 1, j + 1].Tag.ToString() == "M")
                                {
                                    
                                    sayi = Convert.ToInt32(bizim_butonn[i, j].Text.ToString());
                                    sayi++;

                                    bizim_butonn[i, j].Text = sayi.ToString();
                                }

                            }
                            if (j != 0)
                            {
                                if (bizim_butonn[i + 1, j - 1].Tag.ToString() == "M")
                                {
                                  
                                    sayi = Convert.ToInt32(bizim_butonn[i, j].Text.ToString());
                                    sayi++;
                                    bizim_butonn[i, j].Text = sayi.ToString();
                                }

                            }

                        }
                        if (i != 0)
                        {
                            if (bizim_butonn[i - 1, j].Tag.ToString() == "M")
                            {

                               
                                sayi = Convert.ToInt32(bizim_butonn[i, j].Text.ToString());
                                sayi++;
                                bizim_butonn[i, j].Text = sayi.ToString();
                            }
                            if (j != 4)
                            {
                                if (bizim_butonn[i - 1, j + 1].Tag.ToString() == "M")
                                {
                                    
                                    sayi = Convert.ToInt32(bizim_butonn[i, j].Text.ToString());
                                    sayi++;
                                    bizim_butonn[i, j].Text = sayi.ToString();
                                }

                            }
                            if (j != 0)
                            {
                                if (bizim_butonn[i - 1, j - 1].Tag.ToString() == "M")
                                {
                                  
                                    sayi = Convert.ToInt32(bizim_butonn[i, j].Text.ToString());
                                    sayi++;
                                    bizim_butonn[i, j].Text = sayi.ToString();
                                }

                            }
                        }
                        if (j != 0)
                        {
                            if (bizim_butonn[i, j - 1].Tag.ToString() == "M")
                            {
                                
                                sayi = Convert.ToInt32(bizim_butonn[i, j].Text.ToString());
                                sayi++;
                                bizim_butonn[i, j].Text = sayi.ToString();
                            }
                        }
                        if (j != 4)
                        {
                            if (bizim_butonn[i, j + 1].Tag.ToString() == "M")
                            {
                               
                                sayi = Convert.ToInt32(bizim_butonn[i, j].Text.ToString());
                                sayi++;
                                bizim_butonn[i, j].Text = sayi.ToString();
                            }
                        }



                    }







                    /////////////////////////////////
                }
            frm.Controls.Add(frmPanel);

            frm.Show();


        }
        void mayin()
        {
            
            değer = 1;

            süre = (int)sureNUD.Value;
            label4.Text = süre.ToString();
            timer1.Start();


            msay = (int)mayinSayisiNUD.Value;
            _msay = msay;


            Random rassay = new Random();
            listBox1.Items.Clear();
            try
            {
                temizle();
            }
            catch (Exception)
            {

                //throw;
            }
            
            
            // kutuları oluştur
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                {
                    
                        bizim_buton[i, j] = new Button();
                        bizim_buton[i, j].Size = new Size(50, 50);
                        bizim_buton[i, j].Location = new Point(i * 50 + 5, j * 50 + 5);
                        bizim_buton[i, j].Name = "KUTU" + (i * 6 + j).ToString();
                        bizim_buton[i, j].BackColor = Color.FromArgb(128, 128, 128);
                        bizim_buton[i, j].Tag = "0";
                       
                       
                      

                        


                        //bizim_buton[i, j].Click += Form1_Click;
                        bizim_buton[i, j].MouseDown += Form1_MouseDown;
                        //ip.pnl.Controls.Add(bizim_buton[i, j]);
                        mayinTarlasiPnl.Controls.Add(bizim_buton[i, j]);
                        
                        




                    

                }
            
            // mayınları yerleştir
            for (int i = 0; i < msay; i++)
            {
                do
                {
                    rsayi = rassay.Next(25);

                    //MessageBox.Show(rsayi.ToString());
                } while (listBox1.Items.Contains(rsayi.ToString()));
                listBox1.Items.Add(rsayi.ToString());
                int sat, sut;
                sat = rsayi / 5;
                sut = rsayi % 5;
               
                bizim_buton[sat, sut].Tag = "M";
                
                
                //butonTagDegerLst.Items.Add(btnDeger);

            }
            
            // çeversindeki mayınların yazıyısını yaz
            int sayi;
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                {
                    if (bizim_buton[i, j].Tag.ToString() != "M")
                    {
                        if (i != 4)
                        {
                            if (bizim_buton[i + 1, j].Tag.ToString() == "M")
                            {
                                sayi = Convert.ToInt32(bizim_buton[i, j].Tag.ToString());
                                sayi++;
                                bizim_buton[i, j].Tag = sayi.ToString();
                                

                            }
                            if (j != 4)
                            {
                                if (bizim_buton[i + 1, j + 1].Tag.ToString() == "M")
                                {
                                    sayi = Convert.ToInt32(bizim_buton[i, j].Tag.ToString());
                                    sayi++;
                                    bizim_buton[i, j].Tag = sayi.ToString();
                                  
                                }

                            }
                            if (j != 0)
                            {
                                if (bizim_buton[i + 1, j - 1].Tag.ToString() == "M")
                                {
                                    sayi = Convert.ToInt32(bizim_buton[i, j].Tag.ToString());
                                    sayi++;
                                    bizim_buton[i, j].Tag = sayi.ToString();
                                    
                                }

                            }

                        }
                        if (i != 0)
                        {
                            if (bizim_buton[i - 1, j].Tag.ToString() == "M")
                            {
                                sayi = Convert.ToInt32(bizim_buton[i, j].Tag.ToString());
                                sayi++;
                                bizim_buton[i, j].Tag = sayi.ToString();
                                
                            }
                            if (j != 4)
                            {
                                if (bizim_buton[i - 1, j + 1].Tag.ToString() == "M")
                                {
                                    sayi = Convert.ToInt32(bizim_buton[i, j].Tag.ToString());
                                    sayi++;
                                    bizim_buton[i, j].Tag = sayi.ToString();
                                    ;
                                }

                            }
                            if (j != 0)
                            {
                                if (bizim_buton[i - 1, j - 1].Tag.ToString() == "M")
                                {
                                    sayi = Convert.ToInt32(bizim_buton[i, j].Tag.ToString());
                                    sayi++;
                                    bizim_buton[i, j].Tag = sayi.ToString();
                                    
                                }

                            }
                        }



                        if (j != 0)
                        {
                            if (bizim_buton[i, j - 1].Tag.ToString() == "M")
                            {
                                sayi = Convert.ToInt32(bizim_buton[i, j].Tag.ToString());
                                sayi++;
                                bizim_buton[i, j].Tag = sayi.ToString();
                                
                            }
                        }
                        if (j != 4)
                        {
                            if (bizim_buton[i, j + 1].Tag.ToString() == "M")
                            {
                                sayi = Convert.ToInt32(bizim_buton[i, j].Tag.ToString());
                                sayi++;
                                bizim_buton[i, j].Tag = sayi.ToString();
                                
                            }
                        }

                    }




                }

         

        }
        int d = 0;

        int bulunan_temiz_alan ;
        int toplam_alan ;
        int toplam_mayin_sayisi;
        private void button1_Click(object sender, EventArgs e)
        {
            bulunan_temiz_alan = 0;
          /*  toplam_alan = 25;
            toplam_mayin_sayisi = (int)mayinSayisiNUD.Value;*/
            if (d == 0)
            {
                mayin();
              
              
                d++;
                hileEkran();
                
                //yardimciEkran();
             
            }
            else
            {
                DialogResult mesaj = new DialogResult();
                mesaj = MessageBox.Show("Oyuna Yeniden Başlamak İstediğinize Emin Misiniz ", "Mayın Tarlası", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (mesaj == DialogResult.Yes)
                {
                    mayin();
                    hileEkran();
                    bulunan_temiz_alan = 0;
                    toplam_mayin_sayisi = (int)mayinSayisiNUD.Value;
                    toplam_alan = 25;
                    
                   
                   
                }
                else if (mesaj == DialogResult.No)
                {

                }
            }

        }
     
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {          
            if (e.Button == MouseButtons.Right)
                if ((sender as Button).ImageIndex == -1)
                    (sender as Button).ImageIndex = 0;
                else
                    (sender as Button).ImageIndex = -1;
            else
            {
                
                if ((sender as Button).Tag.ToString() == "M")
                {

                    değer = 0;
                    (sender as Button).ImageIndex = 1;
                    (sender as Button).BackColor = Color.Red;
                    MessageBox.Show("Oyun Bitti");
                    timer1.Stop();
                    // (sender as Button).Enabled = false;



                    //button2_Click(sender, e);
                }
                else
                {
                    
                    (sender as Button).Text = (sender as Button).Tag.ToString();
                    (sender as Button).BackColor = Color.Green;
                    (sender as Button).Enabled = false;
                    bulunan_temiz_alan++;
                    süre = Convert.ToInt32(label4.Text);

                    kazandiKontrol();

                }
                
            }
           

            //throw new NotImplementedException();
        }
        
        void kazandiKontrol()
        {

            toplam_alan = 25;
            toplam_mayin_sayisi = (int) mayinSayisiNUD.Value;
            if ((bulunan_temiz_alan )>= (toplam_alan - toplam_mayin_sayisi))
            {
               
                MessageBox.Show("Kazandınız " );
                   

                timer1.Stop();
               
              


            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            (sender as Button).Text = (sender as Button).Tag.ToString();
           
        }

      /*  void yardimciEkran()
        {
          
            

            Button[,] btn = new Button[5, 5];
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                {
                    if (bizim_buton[i, j].Tag.ToString() == "M")
                    {
                        btn[i, j].Size = new Size(50, 50);
                        btn[i, j].Location = new Point(i * 50 + 5, j * 50 + 5);
                        btn[i, j].Name = "KUTU" + (i * 6 + j).ToString();
                        btn[i, j].BackColor = Color.FromArgb(128, 128, 128);
                        btn[i, j].Tag ="";

                        btn[i, j].Text = "0";
                        btn[i, j].BackColor = Color.Red;
                        btn[i, j].Enabled = false;
                        frmPanel.Controls.Add(btn[i,j]);

                    }
                    else
                    {
                        btn[i, j].Text = bizim_buton[i, j].Tag.ToString();
                        btn[i, j].BackColor = Color.Green;

                    }
                  
                }
            frm.Controls.Add(frmPanel);
            frm.Show();
            
        }*/

        private void button2_Click(object sender, EventArgs e)
        {

            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (süre == 0)
            {
                
                timer1.Stop();
                d = 0;
                MessageBox.Show("Süre Bitti");
                


            }
            süre--;
            süreLbl.Text = süre.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        //Soru 2
        private void bul_Click(object sender, EventArgs e)
        {
            armstrongLst.Items.Clear();
            try { 
            int altDeger = Convert.ToInt32(altSinirTxt.Text);
            int ustDeger = Convert.ToInt32(ustSinirTxt.Text);
            int sayi, mod, sayi1, sayi2, sayi3, arm;
                for (sayi = altDeger; sayi <= ustDeger; sayi++)//Döngüye başlıyoruz
                {
                    sayi1 = sayi / 100;
                    mod = sayi % 100;//burda sayinin son iki basamapı ayrılır
                    sayi2 = mod / 10;//burda onlar basamağı ayrılıyor 
                    sayi3 = mod % 10;//burada da birler basamağı
                    arm = (sayi1 * sayi1 * sayi1) + (sayi2 * sayi2 * sayi2) + (sayi3 * sayi3 * sayi3);//ayrılan basamakların küpleri alınıp ayrılıyor
                    if (sayi == arm)
                    {
                        armstrongLst.Items.Add(arm.ToString());
                    }
                }
               
            }


            catch (Exception err)
            {

            }
        }
    }
}
