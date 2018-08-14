using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Poke
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double time = 1;
        int times = 1;
        int click=0;
        int End=0;
        CardControl lastcard1 = new CardControl();
        CardControl lastcard2 = new CardControl();
        private void button1_Click(object sender, EventArgs e)
        {
            CardPanel.Controls.Clear();
            timer1.Start();
            var cards = new List<CardControl>();
            for (int suit = 0; suit < 4; suit++)
            {
                for (int rank = 0; rank < 13; rank++)
                {
                    var card = new CardControl();
                    card.Suit = (Suit)suit;
                    card.Rank = (Rank)rank;
                    card.ShowBack = true;
                    card.Click += cardControl1_Click;
                    cards.Add(card);
                    //CardPanel.Controls.Add(card);
                }
            }
            var random = new Random();
            var adress1 = new List<CardControl>();
            var adress2 = new List<CardControl>();
            for (int i = 0,j=0; j<12; i++,j++)
            {
                int index = random.Next(52 - i);
                var card = new CardControl();
                adress1.Add(cards[index]);
                card.Suit = cards[index].Suit;
                card.Rank = cards[index].Rank;
                card.ShowBack = cards[index].ShowBack;
                card.Click += cardControl1_Click;
                adress2.Add(card);
               // CardPanel.Controls.Add(cards[index]);
                cards.RemoveAt(index);
            }
            for (int i = 0; i < 12; i++)
            {
                int index1 = random.Next(12 - i);
                CardPanel.Controls.Add(adress1[index1]);
                adress1.RemoveAt(index1);
                int index2 = random.Next(12 - i);
                CardPanel.Controls.Add(adress2[index2]);
                adress2.RemoveAt(index2);
            } 
        }

        private void cardControl1_Click(object sender, EventArgs e)
        {
            var card = (CardControl)sender;
            if (!card.ShowBack) return;
            card.ShowBack = !card.ShowBack;
            lbltimes.Text = times++.ToString();
            if (click == 2)
            {
                lastcard1.ShowBack = !lastcard1.ShowBack;
                lastcard2.ShowBack = !lastcard2.ShowBack;
                lastcard1 = card;
                click = 1;
                return;
            }
            if (click == 0)
            {
                click++;
                lastcard1 = card;     
            }
            else if (click == 1)
            {
                //Thread.Sleep(500);
                if (lastcard1.Suit == card.Suit && lastcard1.Rank == card.Rank)
                {
                    click = 0;
                    End++;
                }
                else
                {
                    lastcard2 = card;
                    click++;
                }
            } 
            if (End == 12)
                MessageBox.Show("You win！");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lblTime.Text = time++.ToString();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
