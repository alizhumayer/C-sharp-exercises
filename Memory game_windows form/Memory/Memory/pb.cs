using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory
{
    public class pb
    {
        public PictureBox box;
        public bool lathato;
        public string kep;
        public pb()
        {

        }
        public pb(PictureBox a, bool b, string c)
        {
            box = a;
            lathato = b;
            kep = c;
        }
        public void felfed()
        {
            box.ImageLocation = kep+".jpg";
        }
    }
}
