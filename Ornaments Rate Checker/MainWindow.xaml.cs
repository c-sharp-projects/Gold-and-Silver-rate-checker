using System;
using System.Windows;
using System.Windows.Controls;

namespace Ornaments_Rate_Checker
{
    public partial class MainWindow : Window
    {
        private String GoldUrl;
        private String SilverUrl;

        public MainWindow()
        {
            InitializeComponent();
            GoldUrl = "https://www.goodreturns.in/gold-rates/pune.html";
            SilverUrl = "https://www.goodreturns.in/silver-rates/pune.html";
        }

          private void Listener(object sender, RoutedEventArgs e)
          {
            Button btn = (Button)sender;

            try
            {
                switch (btn.Uid)
                {
                    case "Chk":
                        Rate obj = new Rate();
                        GoldRate.Text = obj.GoldRate(GoldUrl);
                        SilverRate.Text = obj.SilverRate(SilverUrl);
                        break;

                    case "Rst":
                        GoldRate.Text = "";
                        SilverRate.Text = "";
                        break;
                }
            }catch (Exception)
            {
                MessageBox.Show("Connection not avalable");
            }
        }

          
        
    }
}
