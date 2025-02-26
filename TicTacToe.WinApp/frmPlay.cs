using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe.Data;

namespace TicTacToe.WinApp
{
    public partial class frmPlay : Form
    {
        private NonPlayable nonPlayable;
        private Players player;

        int counter = 0;

        public frmPlay(NonPlayable nonPlayable, Players player)
        {
            InitializeComponent();
            this.player = player;
            this.nonPlayable = nonPlayable;
        }

        private void frmPlay_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Helpers.Extensions.ToImage(Resources.Resource1.Play);
            this.BackgroundImageLayout = ImageLayout.Stretch;

            pbPlayer.Image = Helpers.Extensions.ToImage(player.Picture);
            pbEnemy.Image = Helpers.Extensions.ToImage(nonPlayable.Picture);

            lblEnemy.Text = nonPlayable.Name;
            lblPlayer.Text = player.Username;

        }

        private void LoadMove(object sender)
        {
            Button button = sender as Button;

            if (button.Text=="")
            {
                if (counter % 2 == 0)
                {
                    
                    
                        button.Text = "X";
                        counter++;
                        CheckWin();
                    


                        if (nonPlayable.Id == 1)
                        {
                            EnemyMoveEasy();
                            CheckWin();
                            counter++;
                        }
                        else if (nonPlayable.Id == 2)
                        {

                        }
                        else
                        {

                        }
                      

                        
                    

                    

                }
           
            }

            
        }

        private void EnemyMoveEasy()
        {
            if (CheckDraw() || button1.Enabled==false) { return; }
            Random rnd= new Random();
            int random=rnd.Next(1,10);

            switch (random)
            {
                case 1:
                    if (button1.Text == "")
                    {
                        button1.Text = "Y";
                    }
                    else
                    {
                        EnemyMoveEasy();
                    }
                        break;
                case 2:
                    if (button2.Text == "")
                    {
                        button2.Text = "Y";
                    }
                    else
                    {
                        EnemyMoveEasy();
                    }
                    break;
                case 3:
                    if (button3.Text == "")
                    {
                        button3.Text = "Y";
                    }
                    else
                    {
                        EnemyMoveEasy();
                    }
                    break;
                case 4:
                    if (button4.Text == "")
                    {
                        button4.Text = "Y";
                    }
                    else
                    {
                        EnemyMoveEasy();
                    }
                    break;
                case 5:
                    if (button5.Text == "")
                    {
                        button5.Text = "Y";
                    }
                    else
                    {
                        EnemyMoveEasy();
                    }
                    break;
                case 6:
                    if (button6.Text == "")
                    {
                        button6.Text = "Y";
                    }
                    else
                    {
                        EnemyMoveEasy();
                    }
                    break;
                case 7:
                    if (button7.Text == "")
                    {
                        button7.Text = "Y";
                    }
                    else
                    {
                        EnemyMoveEasy();
                    }
                    break;
                case 8:
                    if (button8.Text == "")
                    {
                        button8.Text = "Y";
                    }
                    else
                    {
                        EnemyMoveEasy();
                    }
                    break;
                case 9:
                    if (button9.Text == "")
                    {
                        button9.Text = "Y";
                    }
                    else
                    {
                        EnemyMoveEasy();
                    }
                    break;
                default:
                    MessageBox.Show("ERROR");
                    break;

            }
                



        }

        private void GameEnd(string v)
        {
            if (button1.Enabled == false) {  return; }  
               foreach(Control control in Controls)
                {
                    if(control is Button)
                    {
                        var button=control as Button;
                        button.Enabled = false;
                    }
                }

            if (v == "X")
            {
                MessageBox.Show("YOU WON!");
            }
            else
            {
                MessageBox.Show("YOU LOST!");
            }

            
            Close();
        }

        private void CheckWin()
        {
            CheckRows(button1, button2, button3);
            CheckRows(button4, button5, button6);
            CheckRows(button7, button8, button9);

            CheckColumns(button1, button4, button7);
            CheckColumns(button2, button5, button8);
            CheckColumns(button3, button6, button9);

            CheckDiagonal(button1,button5,button9);
            CheckDiagonal(button3, button5, button7);

            
        }

        private bool CheckDraw()
        {
            if (button1.Text != "" && button2.Text != "" && button3.Text != "" && button4.Text != "" && button5.Text != "" && button6.Text != "" && button7.Text != "" && button8.Text != "" && button9.Text != "" )
            {
                foreach (Control control in Controls)
                {
                    if (control is Button)
                    {
                        
                        var button = control as Button;
                        if (button.BackColor == Color.Green)
                        {
                            return false;
                        }
                        button.Enabled = false;
                    }
                }

                MessageBox.Show("DRAW");
                Close();
                return true;
            }
            return false;
        }

        private void CheckDiagonal(Button button1, Button button5, Button button9)
        {
            if (button1.Text != "")
            {
                if (button1.Text == button5.Text && button5.Text == button9.Text && button1.Text=="X")
                {
                    button1.BackColor = Color.Green;
                    button5.BackColor = Color.Green;
                    button9.BackColor = Color.Green;
                 
                    GameEnd("X");
                }
                else if(button1.Text == button5.Text && button5.Text == button9.Text && button1.Text == "Y")
                {
                    button1.BackColor = Color.Green;
                    button5.BackColor = Color.Green;
                    button9.BackColor = Color.Green;

                    GameEnd("Y");
                }
            }
        }

        private void CheckColumns(Button button1, Button button4, Button button7)
        {
            if (button1.Text != "")
            {
                if (button1.Text == button4.Text && button4.Text == button7.Text&& button1.Text=="X")
                {
                    button1.BackColor = Color.Green;
                    button4.BackColor = Color.Green;
                    button7.BackColor = Color.Green;
                    GameEnd("X");
                }
                else if(button1.Text == button4.Text && button4.Text == button7.Text && button1.Text == "Y")
                {
                    button1.BackColor = Color.Green;
                    button4.BackColor = Color.Green;
                    button7.BackColor = Color.Green;
                    GameEnd("Y");
                }
            }
        }
      

        private void CheckRows(Button button1, Button button2, Button button3)
        {
            if (button1.Text != "")
            {
                if (button1.Text==button2.Text && button2.Text== button3.Text&&button1.Text=="X")
                {
                    button1.BackColor = Color.Green;
                    button2.BackColor = Color.Green;
                    button3.BackColor = Color.Green;
                    GameEnd("X");
                }
                else if(button1.Text == button2.Text && button2.Text == button3.Text && button1.Text == "Y")
                {
                    button1.BackColor = Color.Green;
                    button2.BackColor = Color.Green;
                    button3.BackColor = Color.Green;
                    GameEnd("Y");
                }
            }
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            LoadMove(sender);
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            LoadMove(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadMove(sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LoadMove(sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoadMove(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadMove(sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            LoadMove(sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            LoadMove(sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LoadMove(sender);
        }
    }
}
