using System.Timers;

namespace CS_0614_2
{
    public partial class Form1 : Form
    {
        static Random random = new Random();
        int[] vx = new int[100];
        int[] vy = new int[100];
        Label[] labels = new Label[100];//100å¬ÇÃêVÇµÇ¢ÉâÉxÉãÇçÏê¨Ç∑ÇÈóÃàÊ


        /*int vx1 = random.Next(-10, 10);
        int vx2 = random.Next(-10, 10);
        int vx3 = random.Next(-10, 10);
        int vy1 = random.Next(-10, 10);
        int vy2 = random.Next(-10, 10);
        int vy3 = random.Next(-10, 10);*/

        /*int vx1 = 10;
        int vy1 = 10;
        int vx2 = 10;
        int vy2 = 10;
        int vx3 = 10;
        int vy3 = 10;*/
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 100; i++)
            {
                labels[i] = new Label();//1å¬ÇÃÉâÉxÉãÇä«óùÇ∑ÇÈóÃàÊ
                labels[i].AutoSize = true;
                if (i <= 20)
                {
                    labels[i].Text = "Åü";
                }
                else if(i<=40)
                {
                    labels[i].Text = "Å° ";
                }
                else if(i<=60)
                {
                    labels[i].Text = "Åú";
                }
                else if(i<=80)
                {
                    labels[i].Text = "Å£";
                }
                else
                {
                    labels[i].Text = "Å•";
                }
                Controls.Add(labels[i]);
                labels[i].Font = new Font(
                    "Yu Gothic UI",
                    15F,
                    FontStyle.Regular,
                    GraphicsUnit.Point);

                labels[i].Left = random.Next(ClientSize.Width - labels[i].Width);
                labels[i].Top = random.Next(ClientSize.Height - labels[i].Height);
            }



            for (int i = 0; i < 100; i++)
            {
                vx[i] = random.Next(-10, 11);
                vy[i] = random.Next(-10, 11);
            }

            /*vx[0] = random.Next(-10, 11);
            vy[0] = random.Next(-10, 11);
            vx[1] = random.Next(-10, 11);
            vy[1] = random.Next(-10, 11);
            vx[2] = random.Next(-10, 11);
            vy[2] = random.Next(-10, 11);*/
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                labels[i].Left += vx[i];
                labels[i].Top += vy[i];

                if (labels[i].Left < 0)
                {
                    vx[i] = Math.Abs(vx[i]);
                }
                else if (labels[i].Left > (ClientSize.Width - labels[i].Width))
                {
                    vx[i] = -Math.Abs(vx[i]);
                    //timer1.Enabled = false;
                }
                if (labels[i].Top < 0)
                {
                    vy[i] = Math.Abs(vy[i]);
                }
                else if (labels[i].Top > (ClientSize.Height - labels[i].Height))
                {
                    vy[i] = -Math.Abs(vy[i]);
                }
            }


            /*if (timer1.Enabled == false && timer2.Enabled == false && timer3.Enabled == false)
            {
                timer1.Enabled = true;
                timer2.Enabled = true;
                timer3.Enabled = true;
            }*/
            label2.Left += vx[1];
            label2.Top += vy[1];
            if (label2.Left < 0)
            {
                vx[1] = Math.Abs(vx[1]);
            }
            else if (label2.Left > (ClientSize.Width - label2.Width))
            {
                vx[1] = -Math.Abs(vx[1]);
                //timer2.Enabled = false;
            }
            if (label2.Top < 0)
            {
                vy[1] = Math.Abs(vy[1]);
            }
            else if (label2.Top > (ClientSize.Height - label2.Height))
            {
                vy[1] = -Math.Abs(vy[1]);
            }

            /*if (timer1.Enabled == false && timer2.Enabled == false && timer3.Enabled == false)
            {
                timer2.Enabled = true;
            }*/
            label3.Left += vx[2];
            label3.Top += vy[2];
            if (label3.Left < 0)
            {
                vx[2] = Math.Abs(vx[2]);
            }
            else if (label3.Left > (ClientSize.Width - label3.Width))
            {
                vx[2] = -Math.Abs(vx[2]);
                //timer3.Enabled = false;
            }
            if (label3.Top < 0)
            {
                vy[2] = Math.Abs(vx[2]);
            }
            else if (label3.Top > (ClientSize.Height - label3.Height))
            {
                vy[2] = -Math.Abs(vx[2]);
            }

            /*if (timer1.Enabled == false && timer2.Enabled == false && timer3.Enabled == false)
            {
                timer3.Enabled = true;
            }*/
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                MessageBox.Show($"{i}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i;
            for (i = 0; i < 10; i++)
            {
                if (i == 2 || i == 3)
                {
                    continue;
                }
                if (i == 5)
                {
                    break;
                }
                MessageBox.Show(i.ToString());
            }

            MessageBox.Show($"after {i}");
        }
    }
}