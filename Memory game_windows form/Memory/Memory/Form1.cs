using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Memory
{
    public partial class Form1 : Form
    {
        public List<pb> kepek= new List<pb>();
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
          
            for (int i = 0; i < 16; i++)
            {
                PictureBox pbox = new PictureBox();
                pbox.Size = new Size(100, 100);
                pbox.Location = new Point(i % 4 * 100+i%4*2, i / 4 * 100+i/4*2);
                try
                {
                    pbox.ImageLocation = "color_blathy.jpg";
                }
                catch (Exception)
                {

                    throw;
                }
                pbox.Name = i.ToString();
                pbox.Click += new EventHandler(pboxClick);
                this.Controls.Add(pbox);
                kepek.Add(new pb(pbox,false,kevertkepek().ToString()));
            }
        }
        void pboxClick(object sender, EventArgs e)
        {
            PictureBox seged = (PictureBox)sender;
            //seged.Visible = false;
            kepek[Convert.ToInt32(seged.Name)].felfed();
            //varakozas(2);
            kepek[Convert.ToInt32(seged.Name)].lathato=true;
            hasonlit();
        }
        public void hasonlit()
        {
            pb[] s=new pb[2];
            int db = 0;
            foreach (pb item in kepek)
            {
                if(item.lathato)
                {
                    s[db] = item;
                    db++;
                }
            }
            if(db>=2)
            {
                //varakozas(10);
                if(s[0].kep.Equals(s[1].kep))
                {
                    s[0].lathato = false;
                    s[1].lathato = false;
                    s[0].box.Visible = false;
                    s[1].box.Visible = false;
                }
                else
                {   
                    s[0].box.ImageLocation = "color_blathy.jpg";
                    s[1].box.ImageLocation = "color_blathy.jpg";
                    s[0].lathato = false;
                    s[1].lathato = false;
                }
            }
        }
        public int kevertkepek()
        {
            int s;
            do
            {
                s = rnd.Next(0, 8);
            } while (benne(s));
            return s;
        }
        public bool benne(int a)
        {
            int i = 0;
            int db = 0;
            while(i<kepek.Count && (Convert.ToInt32(kepek[i].kep)!=a || db<2))
            {
                if(Convert.ToInt32(kepek[i].kep) == a)
                {
                    db++;
                }
                i++;
            }
            return db>=2;
        }
        public void varakozas(int varakozas)
        {
            DateTime start = DateTime.Now;
            
            while ((DateTime.Now-start).TotalSeconds< varakozas) ;
        }
    }
}
