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

namespace WPF_Trial
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

        private void OptionsButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Options Pressed");
        }

        private void ChallengesButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Challenges Pressed");
        }

        private void FreeplayButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Free Play Pressed");
        }
    }
}
