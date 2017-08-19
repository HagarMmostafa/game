using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Button[,] btns = new Button[3, 3];
        enum GameType { x, o };
        GameType currentGame = GameType.x;
        int count = 0;
        public Form1()
        {
            InitializeComponent();
            btns[0, 0] = btn1; btns[0, 1] = btn2; btns[0, 2] = btn3;
            btns[1,0] = btn4; btns[1,1] = btn5; btns[1,2] = btn6;
            btns[2,0] = btn7; btns[2,1] = btn8; btns[2,2] = btn9;
            ClearAll();
        }

        private void ClearAll()
        {
            foreach (Button b in btns)
                b.Text = "";
            count = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            if (bt.Text != "") return;
            bt.Text = currentGame.ToString();
            count++;
            if(IsWin())
            {
                MessageBox.Show("You Are A Wineer");
                ClearAll();
                return;
            }
            if(count==9)
            {
                MessageBox.Show("the result is equal");
                ClearAll();
            }
            switchGame();
        }

        private bool IsWin()
        {
           for(int i=0;i<=2;i++)
           {
                int game=0;
               for(int j=0;j<=2;j++)
               {
                   if (btns[i, j].Text == currentGame.ToString())
                       game++;
               }
               if (game == 3)
                   return true;
           }
           for (int j = 0; j <= 2; j++)
           {
               int game = 0;
               for (int i = 0; i <= 2; i++)
               {
                   if (btns[i, j].Text == currentGame.ToString())
                       game++;
               }
               if (game == 3)
                   return true;
           }
            if(btns[0,0].Text==currentGame.ToString() &&
                btns[1,1].Text==currentGame.ToString() &&
                btns[2,2].Text==currentGame.ToString())
                return true;
            if (btns[0, 2].Text == currentGame.ToString() &&
                btns[1, 1].Text == currentGame.ToString() &&
                btns[2, 0].Text == currentGame.ToString())
                return true;
            return false;


        }

        private void switchGame()
        {
            if (currentGame == GameType.x)
            {
                currentGame = GameType.o;
            }
            else
                currentGame = GameType.x;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
