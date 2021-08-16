using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public bool KazananControl = false;
        public int userpuan1 = 0;
        public int userpuan2 = 0;
        Button[,] Butonlar = new Button[14, 14];
        Panel[,] paneller = new Panel[14, 14];
        int[,] Konumlar = new int[14, 14];
        int[,] User1 = new int[14, 14];

        int[,] satir = new int[14, 14];
        int[,] stun = new int[14, 14];
        int[,] sagcapraz = new int[14, 14];
        int[,] solcapraz = new int[14, 14];
        //int[,] User2 = new int[14, 14];

        bool userControl1 = true;
        bool userControl2 = false;
        public void diziDuzeni(int[,] dizi)
        {

            for (int i = 0; i < 14; i++)
            {
                for (int j = 0; j < 14; j++)
                {
                    dizi[i, j] = 3;

                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            diziDuzeni(User1);
           
            for (int i = 0; i < 14; i++)
            {
                for (int j = 0; j < 14; j++)
                {
                    Button btnS = new Button();
                    btnS.Width = 25;
                    btnS.Height = 50;
                    btnS.Text = "S";
                    btnS.Name = i.ToString() + "-" + j.ToString();
                    Button btnO = new Button();
                    btnO.Left = 25;
                    btnO.Width = 25;
                    btnO.Height = 50;
                    btnO.Text = "O";
                    btnO.Name = i.ToString() + "-" + j.ToString();
                    paneller[i, j] = new Panel();
                    paneller[i, j].Width = 50;
                    paneller[i, j].Height = 50;
                    paneller[i, j].Controls.Add(btnS);
                    paneller[i, j].Controls.Add(btnO);
                    paneller[i, j].Name = i.ToString() + "-" + j.ToString();
                    SiraliPanel.Controls.Add(paneller[i, j]);
                    btnS.Click += new EventHandler(KClick);
                    btnO.Click += new EventHandler(KClick);
                }
            }

        }
        public void KClick(object sender, EventArgs e)
        {
            Button buton = (Button)sender;
            string numara = buton.Name.ToString();

            // string[] parcalar=numara.Split('-');
            // MessageBox.Show(parcalar[0]);
            for (int i = 0; i < 14; i++)
            {
                for (int j = 0; j < 14; j++)
                {
                    if (paneller[i, j].Name.ToString() == numara)
                    {
                        paneller[i, j].Controls.Clear();
                       
                          
                       
                            Butonlar[i, j] = new Button();
                            Butonlar[i, j].Width = 50;
                            Butonlar[i, j].Font = new Font(Butonlar[i, j].Font.FontFamily, 30);
                            Butonlar[i, j].Height = 50;
                            Butonlar[i, j].BackColor = Color.Green;
                            Butonlar[i, j].Text = buton.Text;
                            paneller[i, j].Controls.Add(Butonlar[i, j]);
                        if (userControl1==true)
                        {

                            userControl1 = false;
                            userControl2 = true;
                            label1.BackColor = Color.Red;
                            label2.BackColor = Color.Green;
                        }
                        else
                        {
                            userControl1 = true;
                            userControl2 = false;
                            label1.BackColor = Color.Green;
                            label2.BackColor = Color.Red;
                            


                        }
                       
                            if (Butonlar[i, j].Text == "S")
                            {

                                User1[i, j] = 1;
                                DiziKontrol(User1, i, j, 1);

                            }
                            else
                            {
                                User1[i, j] = 2;
                                DiziKontrol(User1, i, j, 2);
                            }


                        
                       
                    }


                }
            }




        }


        public void DiziKontrol(int[,] Dizi, int Y, int X, int T)
        {
            KazananControl = false;
        
            for (int i=0;i<14; i++)  // Yatayda kontrol ediyor
            {
                for (int j = 0; j < 12; j++)
                {

                    if (Dizi[i, j]==1 && Dizi[i, j+1] == 2 && Dizi[i, j+2] == 1)
                    {
                      
                        if (satir[i, j] == 0 && satir[i, j + 1] == 0 && satir[i, j + 2] == 0)
                        {

                            KazananControl = true;
                            satir[i, j] = 1;
                        satir[i, j+1] = 1;
                        satir[i, j+2] = 1;
                        }


                    }

                }


            }
            for (int i = 0; i < 12; i++)// Dikeyde kontrol ediyor
            {
                for (int j = 0; j < 14; j++)
                {

                    if (Dizi[i, j] == 1 && Dizi[i+1, j ] == 2 && Dizi[i+2, j] == 1)
                    {
                        if (satir[i, j] == 0 && satir[i+1, j] == 0 && satir[i+2, j] == 0)
                        {
                            KazananControl = true;
                            stun[i, j] = 1;
                            stun[i + 1, j] = 1;
                            stun[i + 2, j] = 1;

                        }
                    }

                }


            }

            for (int i = 0; i <12; i++)// sağ alt çaprazı kontrol eidyor
            {
                for (int j=0;j<12;j++)
                {


                    if (Dizi[i, j] == 1 && Dizi[i + 1, j +1] == 2 && Dizi[i + 2, j + 2] == 1)
                    {
                        if (satir[i, j] == 0 && satir[i + 1, j+1] == 0 && satir[i + 2, j+2] == 0)
                        {
                            KazananControl = true;
                            sagcapraz[i, j] = 1;
                            sagcapraz[i + 1, j + 1] = 1;
                            sagcapraz[i + 2, j + 2] = 1;
                        }
                    }
                }
             

            }
         
            for (int i = 13; i > 1; i--)// sağ üst çaprazı kontrol eidyor
            {
                for (int j = 0; j < 12; j++)
                {

                    Console.Write(Dizi[i, j]);
                    if (Dizi[i, j] == 1 && Dizi[i - 1, j + 1] == 2 && Dizi[i - 2, j + 2] == 1)
                    {
                        if (satir[i, j] == 0 && satir[i - 1, j - 1] == 0 && satir[i -2, j - 2] == 0)
                        {
                            KazananControl = true;
                            solcapraz[i, j] = 1;
                            solcapraz[i - 1, j - 1] = 1;
                            solcapraz[i - 2, j - 2] = 1;

                        }
                    }
                }
                


            }


            if (KazananControl == true)
            {
                if (userControl1==true)
                
                {
                 
                    userpuan2++;
                    label4.Text = userpuan2.ToString();
                   
                }
                else
                {
                    userpuan1++;
                    label3.Text = userpuan1.ToString();

                   
                }
            }
          





        }
            



    }
}

