using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Poke
{
    public enum Suit
    {
        Club,
        Spade,
        Heart,
        Diamond
    }
    public enum Rank
    {
        Ace,
        Deuce,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }
    public partial class CardControl : UserControl
    {
        
        public CardControl()
        {
            InitializeComponent();
        }
        private Suit suit;
        [Category("Poker Card")]
        public Suit Suit
        {
            set
            {
                suit = value;
                this.Refresh();
            }
            get
            {
                return suit;
            }
        }
        [Category("Poker Card")]
        private Rank rank; 
        public Rank Rank
        {
            set
            {
                rank = value;
                this.Refresh();
            }
            get 
            {
                return rank;
            }
        }
        //显示背面
        [Category("Poker Card")]
        private  bool showBack;
        public bool ShowBack
        {
            set
            {
                showBack = value;
                this.Refresh();
            }
            get
            {
                return showBack;
            }
        }
        private void CardControl_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            if(showBack)
            {
                g.DrawImage(Properties.Resources.back, 0, 0);
            }
            else
            {          
                Image cardsImage = Properties.Resources.cards;
                var srcRect = new Rectangle(73*(int)rank, 98*(int)suit, 73, 98);
                var destRect = new Rectangle(0, 0, 73, 98);
                g.DrawImage(cardsImage, destRect, srcRect, GraphicsUnit.Pixel);
            }
        }

        private void CardControl_Resize(object sender, EventArgs e)
        {
            this.Size = new Size(73, 98);
        }


    }
}
