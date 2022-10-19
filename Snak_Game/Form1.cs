namespace Snak_Game
{
    public partial class Form1 : Form
    {
        bool blue = false;
        bool white = false;
        int x1 = 3, y1 = 390, x2 = 3, y2 = 390, count = 1, docevalue;
        public Form1()
        {
            InitializeComponent();


            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox3.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("dice");
            pictureBox3.SizeMode=PictureBoxSizeMode.StretchImage;
            

        }

        private void button1_Click(object sender, EventArgs e)
        {


            docevalue = logics.rolldice(pictureBox3);
            label2.Text = docevalue.ToString();
            if (count % 2 != 0)
            {
                logics.movement_step(ref blue, ref label2, ref x1, ref y1, ref pictureBox4, ref pictureBox1);
                label3.Text = "Player one";
            }
            else
            {
                logics.movement_step(ref white, ref label2, ref x2, ref y2, ref pictureBox5, ref pictureBox2);
                label3.Text = "Player two";
            }
            count++;


        }
    }
}