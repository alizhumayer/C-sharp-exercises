using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace EUtazas2020GUI
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            CbMegálló.Items.Add("Válasszon megállót!");
            for (int i = 0; i < 30; i++)
            {
                CbMegálló.Items.Add($"{i}.");
            }
            CbMegálló.SelectedIndex = 0;

            CbTípus.Items.Add("Válasszon típust!");
            CbTípus.Items.Add("FEB");
            CbTípus.Items.Add("TAB");
            CbTípus.Items.Add("NYB");
            CbTípus.Items.Add("NYP");
            CbTípus.Items.Add("RVS");
            CbTípus.Items.Add("GYK");
            CbTípus.SelectedIndex = 0;

            // A felszállás napja legyen az aktuális nap:
            DpFelszállásNap.SelectedDate = DateTime.Now;
        }

        private void SlFelhasználhatóJegy_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            LbFelhasználhatóJegy.Content = SlFelhasználhatóJegy.Value + "db";
        }

        private void TbKártyaAzon_TextChanged(object sender, TextChangedEventArgs e)
        {
            LbSzámjegyDarab.Content = TbKártyaAzon.Text.Length + "db";
        }

        private void RbBérlet_Checked(object sender, RoutedEventArgs e)
        {
            SlFelhasználhatóJegy.Value = 0;
            GbBérlet.Visibility = Visibility.Visible;
            GpJegy.Visibility = Visibility.Hidden;
        }

        private void RbJegy_Checked(object sender, RoutedEventArgs e)
        {
            DpÉrvényes.SelectedDate = null;
            CbTípus.SelectedIndex = 0;
            GbBérlet.Visibility = Visibility.Hidden;
            GpJegy.Visibility = Visibility.Visible;
        }

        private void BtnRögzít_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (CbMegálló.SelectedIndex == 0) throw new Exception("Nem választott megállót!");
                if (DpFelszállásNap.SelectedDate == null) throw new Exception("Nem adott meg dátumot!");
                DateTime felszállásIdeje = DateTime.ParseExact(tbFelszállásIdő.Text, "HH:mm", System.Globalization.CultureInfo.InvariantCulture);
                if (TbKártyaAzon.Text.Length != 7) throw new Exception("A kártya azonosítója nem hét karakter hosszú!");
                uint kártyaAzon = uint.Parse(TbKártyaAzon.Text);
                DateTime? bérletÉrvényes = DpÉrvényes.SelectedDate;
                if ((bool)RbBérlet.IsChecked)
                { // bérletes adatok ellenőrzése
                    if (CbTípus.SelectedIndex == 0)
                    {
                        throw new Exception("Nem adta meg a bérelt típusát!");
                    }
                    if (bérletÉrvényes == null)
                    {
                        throw new Exception("Nem adta meg a bérlet érvényességi idejét!");
                    }
                }
                // Fájlba írás (append)
                // 0 20190326-0700 5695155 FEB 20210101
                // 0 20190326-0700 9031038 JGY 3
                int megállóSsz = CbMegálló.SelectedIndex - 1;
                string felszállIdő = felszállásIdeje.ToString("yyyyMMdd-HHmm");
                string típus = "JGY";
                string last = SlFelhasználhatóJegy.Value.ToString();
                if ((bool)RbBérlet.IsChecked)
                {
                    típus = CbTípus.SelectedItem.ToString();
                    last = DpÉrvényes.SelectedDate.Value.ToString("yyyyMMdd");
                }
                File.AppendAllText("../../utasadat.txt", $"{megállóSsz} {felszállIdő} {kártyaAzon} {típus} {last}");
                // Sikeres írás utáni takarítás:
                CbMegálló.SelectedIndex = 0;
                DpFelszállásNap.SelectedDate = DateTime.Now;
                TbKártyaAzon.Text = "";
                RbBérlet.IsChecked = true;
                CbTípus.SelectedIndex = 0;
                DpÉrvényes.SelectedDate = null;
                SlFelhasználhatóJegy.Value = 0;
                MessageBox.Show("A felszállás tárolása sikeres volt!", "EUtazás 2020");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba!");
            }
        }

    }
}
