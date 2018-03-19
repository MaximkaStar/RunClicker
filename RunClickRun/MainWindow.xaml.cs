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

namespace RunClickRun
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private new void MouseMove(object sender, MouseEventArgs e)
        {
            if (Run.HorizontalAlignment != HorizontalAlignment.Left)
            {
                Run.HorizontalAlignment = HorizontalAlignment.Left;
            }
            else
            {
                Run.HorizontalAlignment = HorizontalAlignment.Right;
            }

            if (Run.VerticalAlignment != VerticalAlignment.Bottom)
            {
                Run.VerticalAlingment = VerticalAlignment.Bottom;
            }
            else
            {
                Run.VerticalAlignment = VerticalAlignment.Top;
            }
        }
    }
}
