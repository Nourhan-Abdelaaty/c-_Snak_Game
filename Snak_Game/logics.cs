using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snak_Game
{
    internal class logics
    {

        //// method for roll
        public static int rolldice(PictureBox px)
        {
            int dice = 0;
            Random r = new Random();
            dice = r.Next(1, 7);
            px.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("d"+dice);
            px.SizeMode = PictureBoxSizeMode.StretchImage;

            // px.Image = Image.FromFile(@"E:\AA_ITI_Resourses\c# .net framework\labs\WindowsFormsApp3\WindowsFormsApp3\Resources\imgs\p_200820_06993.jpg");
          //  px.SizeMode = PictureBoxSizeMode.StretchImage;
            return dice;

        } /////// roll method end ////////

        ///// method for snak and ladder 

        public static void move(ref int a, ref int b, ref PictureBox p1)
        {
            if (a == 203 && b == 390)
            {
                Application.DoEvents();
                Thread.Sleep(1000);
                b = 90;
                p1.Location = new Point(a, b);
            }

            else if (a == 403 && b == 390)
            {
                Application.DoEvents();
                Thread.Sleep(1000);
                b = 290;
                p1.Location = new Point(a, b);
            }
            else if (a == 103 && b == 290)
            {
                Application.DoEvents();
                Thread.Sleep(1000);
                b = -10;
                p1.Location = new Point(a, b);
            }
            else if (a == 403 && b == 90)
            {
                Application.DoEvents();
                Thread.Sleep(1000);
                b = -10;
                p1.Location = new Point(a, b);
            }
            else if (a == 203 && b == -10)
            {
                Application.DoEvents();
                Thread.Sleep(1000);
                a = 3;
                b = 390;
                p1.Location = new Point(a, b);
            }
            else if (a == 303 && b == 90)
            {
                Application.DoEvents();
                Thread.Sleep(1000);
                b = 290;
                p1.Location = new Point(a, b);
            }
            else if (a == 403 && b == 190)
            {
                Application.DoEvents();
                Thread.Sleep(500);
                a = 303;
                b = 390;
                p1.Location = new Point(a, b);
            }
            else if (a == 503 && b == 90)
            {
                Application.DoEvents();
                Thread.Sleep(1000);
                b = 290;
                p1.Location = new Point(a, b);
            }
            if (b < -10 || (b == -10 && a == 503))
            {
                a = 503;
                b = -10;
                p1.Location = new Point(a, b);
                MessageBox.Show("Congratolation....");
            }


        }

        ////// end method 



        ////// method to move step by step
        public static void movement_step(ref bool player, ref Label lab, ref int x, ref int y, ref PictureBox pic, ref PictureBox pic2)
        {
            if (player == true)
            {
                int val = int.Parse(lab.Text);
                for (int i = 0; i < val; i++)
                {
                    Application.DoEvents();
                    Thread.Sleep(500);
                    x += 100;
                    if (x > 550)
                    {
                        x = 3;
                        y -= 100;
                    }
                    pic.Location = new Point(x, y);
                    if (y < -10)
                    { i = val; }
                }
                logics.move(ref x, ref y, ref pic);
            }

            if (lab.Text == "6" && player == false)
            {
                pic.Visible = true;
                pic2.Visible = false;
                player = true;
                pic.Location = new Point(x, y);
            }




        }


    }
}
