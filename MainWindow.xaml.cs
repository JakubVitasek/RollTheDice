using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace rollTheDice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }


        int zivoty1 = 5;
        int score1 = 0;
        private void restart_Click(object sender, RoutedEventArgs e)
        {

            zivoty.Text = "5";
            score.Text = "0";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random ran = new Random();
            int cislo = ran.Next(1, 7);
            int cislo1 = Convert.ToInt32(input.Text);
            MessageBox.Show($"Padlo čislo:{cislo}");
            MessageBox.Show($"Ty jsi hádal: {cislo1}");
            if(cislo == cislo1)
            {
                MessageBox.Show("Pecka,uhádl si to <3");
                score1 = score1 + 1;
                string score11 = Convert.ToString(score1);
                score.Text = score11 ;

            }
            else
            {
                MessageBox.Show("Bohužel,nauhádl si to :( ");
                zivoty1 = zivoty1 -1;
                string zivoty11 = Convert.ToString(zivoty1);
                zivoty.Text = zivoty11;
            }
            input.Clear();
        } 
        
    }
}
