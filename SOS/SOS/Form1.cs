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
        Button[,] Butonlar = new Button[14,14];
        Panel[,] paneller = new Panel[14, 14];
        int[,] Konumlar = new int[14, 14];
        int[,] User1 = new int[14, 14];
        int[,] User2 = new int[14, 14];
        bool userControl1 = true;
        bool userControl2 = false;


        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i=0;i<14;i++)
            {
                for( int j = 0; j < 14; j++)
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
                btnO.Name = i.ToString() +"-"+ j.ToString();
                paneller[i, j] = new Panel();
                paneller[i, j].Width = 50;
                paneller[i, j].Height = 50;
                paneller[i, j].Controls.Add(btnS);
                paneller[i, j].Controls.Add(btnO);
                paneller[i, j].Name = i.ToString() +"-"+ j.ToString();
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
                    if (paneller[i, j].Name.ToString()==numara)
                    {
                        paneller[i, j].Controls.Clear();
                        if (userControl1==true)
                        {
                            userControl1 = false;
                            userControl2 = true;
                            Butonlar[i,j] = new Button();
                            Butonlar[i, j].Width = 50;
                            Butonlar[i, j].Font = new Font(Butonlar[i, j].Font.FontFamily, 30);
                            Butonlar[i, j].Height = 50;
                            Butonlar[i, j].BackColor = Color.Green;
                            Butonlar[i, j].Text = buton.Text;
                            paneller[i, j].Controls.Add(Butonlar[i, j]);
                            if (Butonlar[i, j].Text == "S")
                            {

                                User1[i, j] = 1;
                                DiziKontrol(User1, 1,1);
                            }
                            else
                            {
                                User1[i, j] = 2;
                                DiziKontrol(User1, 2,1);
                            }
                            
                           
                        }
                        else
                        {
                            userControl1 = true;
                            userControl2 = false;
                            Button butonn = new Button();
                            butonn.Width = 50;
                            butonn.Font = new Font(butonn.Font.FontFamily, 30);
                            butonn.Height = 50;
                            butonn.BackColor = Color.Red;
                            butonn.Text = buton.Text;
                            paneller[i, j].Controls.Add(butonn);
                            if (butonn.Text == "S")
                            {

                                User2[i, j] = 1;
                                DiziKontrol(User2,1,2);
                            }
                            else
                            {
                                User2[i, j] = 2;
                                DiziKontrol(User2, 2, 2);

                            }
                           
                        }
                    }


                }
            }




        }


        public void DiziKontrol(int[,] Dizi,int T,int User)
        {

            for (int i=0;i<14;i++)
            {
                for (int j = 0; j < 14; j++)
                {

                  
                    if (Dizi[i, j]==1 || Dizi[i, j]==2) {

                       

                        for (int h = i-1; h <i+2; h++)
                            {
                                for (int r = j-1; r < j+2; r++)
                                {
                                if (Dizi[i, j]==1)
                                {
                                    if(Butonlar[h, r]==2)
                                    


                                }
                                paneller[h, r].BackColor=Color.Black;


                                 }

                        }








                     


                    }


                }


            }




        }
    }
}
