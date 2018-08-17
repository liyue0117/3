# 李越的作业扑克游戏
## 作用或达成效果
需要点击牌面使之翻转，当两牌一样时，牌面变回保持翻转过后的状态，直到所有牌面都被翻转游戏结束
## 如何运行
运行Poke.sln即可。
## 运行结果
！[成功]（屏幕快照.png)
## 代码
```using System;
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

namespace Poke
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnOK = new System.Windows.Forms.Button();
            this.CardPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbltimes = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnCancle = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(30, 207);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(90, 38);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "开始游戏";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.button1_Click);
            // 
            // CardPanel
            // 
            this.CardPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.CardPanel.Location = new System.Drawing.Point(0, 0);
            this.CardPanel.Name = "CardPanel";
            this.CardPanel.Size = new System.Drawing.Size(506, 393);
            this.CardPanel.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbltimes);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.btnCancle);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Location = new System.Drawing.Point(509, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(143, 393);
            this.panel1.TabIndex = 3;
            // 
            // lbltimes
            // 
            this.lbltimes.AutoSize = true;
            this.lbltimes.Location = new System.Drawing.Point(93, 84);
            this.lbltimes.Name = "lbltimes";
            this.lbltimes.Size = new System.Drawing.Size(11, 12);
            this.lbltimes.TabIndex = 4;
            this.lbltimes.Text = "0";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(93, 40);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(11, 12);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "0";
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(29, 270);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(90, 38);
            this.btnCancle.TabIndex = 2;
            this.btnCancle.Text = "结束游戏";
            this.btnCancle.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "时间：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "次数：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 393);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CardPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.FlowLayoutPanel CardPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbltimes;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Poke
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}```
