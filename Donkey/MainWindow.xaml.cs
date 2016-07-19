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

namespace Donkey
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Farmyard fy = new Farmyard();

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Farmyard Simulator");
            sb.AppendLine("Dogs go: " + fy.PlaySound("dog"));
            sb.AppendLine("Cats go: " + fy.PlaySound("cat"));
            sb.AppendLine("Donkeys go: " + fy.PlaySound("donkey"));

            Label_Text.Content = sb.ToString();
        }
    }
}
