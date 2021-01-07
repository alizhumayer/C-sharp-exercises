using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Benzinkut
{
    public partial class Form1 : Form
    {
        int db = 0;
        Random r;
        Sor<Label> s95;
        Sor<Label> s98;
        Sor<Label> sd;
        Sor<Label> s106;
        Sor<Label> sa;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //timer
            ta.Enabled = true;
            t95.Enabled = true;
            t98.Enabled = true;
            td.Enabled = true;
            t106.Enabled = true;
            //sorok
            s95 = new Sor<Label>();
            s98 = new Sor<Label>();
            sd = new Sor<Label>();
            s106 = new Sor<Label>();
            sa = new Sor<Label>();
            //random
            r = new Random();
            //combo feltölt
            for (int i = 1; i <= 20; i++)
            {
                cb95.Items.Add(500 * i);
                cb98.Items.Add(500 * i);
                cbd.Items.Add(500 * i);
                cb106.Items.Add(500 * i);
            }
            //combol alap i=0
            cb95.SelectedIndex = 0;
            cb98.SelectedIndex = 0;
            cbd.SelectedIndex = 0;
            cb106.SelectedIndex = 0;
            //alap indítás
            sh95.Value = 5;
            sh98.Value = 5;
            shd.Value = 5;
            sh106.Value = 5;
            sha.Value = 50;
        }

        private void t95_Tick(object sender, EventArgs e)
        {
            if (!s95.UresE())
            {
                t95.Enabled = false;
                Label l = s95.Sorbol();
                l.Dispose();
                //this.Controls.Remove(l);
                for (int i = 0; i < s95.Hossz; i++)
                {
                    s95[i].Top -= 30;
                }
                t95.Enabled = true;
            }
        }

        private void t98_Tick(object sender, EventArgs e)
        {
            if (!s98.UresE())
            {
                t98.Enabled = false;
                Label l = s98.Sorbol();
                l.Dispose();
                for (int i = 0; i < s98.Hossz; i++)
                {
                    s98[i].Top -= 30;
                }
                t98.Enabled = true;
            }
        }

        private void td_Tick(object sender, EventArgs e)
        {
            if (!sd.UresE())
            {
                td.Enabled = false;
                Label l = sd.Sorbol();
                l.Dispose();
                for (int i = 0; i < sd.Hossz; i++)
                {
                    sd[i].Top -= 30;
                }
                td.Enabled = true;
            }
        }
        private void t106_Tick(object sender, EventArgs e)
        {
            if (!s106.UresE())
            {
                t106.Enabled = false;
                Label l = s106.Sorbol();
                l.Dispose();
                for (int i = 0; i < s106.Hossz; i++)
                {
                    s106[i].Top -= 30;
                }
                t106.Enabled = true;
            }
        }
        private void ta_Tick(object sender, EventArgs e)
        {
            if (sa.Hossz < sha.Value)
            {
                ta.Enabled = false;
                //label létrehozása és tulajdonságai
                Label l = new Label();
                l.Parent = gba;
                l.AutoSize = false;
                l.Width = 30;
                l.Height = 30;
                l.Text = (++db).ToString();
                switch (r.Next(1,5))
                {
                    case 1: l.BackColor = Color.Red; break;
                    case 2: l.BackColor = Color.Green; break;
                    case 3: l.BackColor = Color.Blue; break;
                    case 4: l.BackColor = Color.Yellow; break;
                }
                l.TextAlign = ContentAlignment.MiddleCenter;
                l.Left = 20 + sa.Hossz * 30;
                l.Top = 20;
                sa.Sorba(l);
                ta.Enabled = true;
            }
            if (!sa.UresE())
            {
                ta.Enabled = false;
                if (sa.Elso().BackColor == Color.Red)
                {
                    if (s95.Hossz<sh95.Value)
                    {
                        t95.Enabled = false;
                        Label l = sa.Sorbol();
                        l.Parent = gb95;
                        l.Left = 20;
                        l.Top = 20 + s95.Hossz * 30;
                        s95.Sorba(l);
                        for (int i = 0; i < sa.Hossz; i++)
                        {
                            sa[i].Left -= 30;
                        }
                        t95.Enabled = true;
                    }
                }
                else if (sa.Elso().BackColor == Color.Green)
                {
                    if (s98.Hossz < sh98.Value)
                    {
                        t98.Enabled = false;
                        Label l = sa.Sorbol();
                        l.Parent = gb98;
                        l.Left = 20;
                        l.Top = 20 + s98.Hossz * 30;
                        s98.Sorba(l);
                        for (int i = 0; i < sa.Hossz; i++)
                        {
                            sa[i].Left -= 30;
                        }
                        t98.Enabled = true;
                    }
                }
                else if (sa.Elso().BackColor == Color.Blue)
                {
                    if (sd.Hossz < shd.Value)
                    {
                        td.Enabled = false;
                        Label l = sa.Sorbol();
                        l.Parent = gbd;
                        l.Left = 20;
                        l.Top = 20 + sd.Hossz * 30;
                        sd.Sorba(l);
                        for (int i = 0; i < sa.Hossz; i++)
                        {
                            sa[i].Left -= 30;
                        }
                        td.Enabled = true;
                    }
                }
                else if (sa.Elso().BackColor == Color.Yellow)
                {
                    if (s106.Hossz < sh106.Value)
                    {
                        t106.Enabled = false;
                        Label l = sa.Sorbol();
                        l.Parent = gb106;
                        l.Left = 20;
                        l.Top = 20 + s106.Hossz * 30;
                        s106.Sorba(l);
                        for (int i = 0; i < sa.Hossz; i++)
                        {
                            sa[i].Left -= 30;
                        }
                        t106.Enabled = true;
                    }
                }
                ta.Enabled = true;
            }
        }

        private void cb95_SelectedIndexChanged(object sender, EventArgs e)
        {
            t95.Interval = (int)cb95.SelectedItem;
        }

        private void cb98_SelectedIndexChanged(object sender, EventArgs e)
        {
            t98.Interval = (int)cb98.SelectedItem;
        }

        private void cbd_SelectedIndexChanged(object sender, EventArgs e)
        {
            td.Interval = (int)cbd.SelectedItem;
        }

        private void cb106_SelectedIndexChanged(object sender, EventArgs e)
        {
            t106.Interval = (int)cb106.SelectedItem;
        }
    }
}
