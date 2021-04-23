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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp9
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DoubleAnimation _combineanimation;
        private DoubleAnimation animation;

        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _combineanimation = new DoubleAnimation();
            _combineanimation.By = 5;
            _combineanimation.Duration = TimeSpan.FromMilliseconds(1);
            combineAnimation.BeginAnimation(Canvas.LeftProperty, _combineanimation);
            /*animation = new DoubleAnimation();
            animation.Completed += afterComplete;
            animation.By = 500;
            animation.From = 200;
            animation.To = 400;
            animation.Duration = TimeSpan.FromSeconds(5);
            animation.AutoReverse = true;
            animation.FillBehavior = FillBehavior.HoldEnd;
            animation.AccelerationRatio = 0.5;
            btnAnimation.BeginAnimation(Button.WidthProperty, animation);
        }
        private void afterComplete(object sender, EventArgs e)
        {
            btnAnimation.BeginAnimation(Button.WidthProperty, null);
            btnAnimation.Width = 600;
        }*/
        }
    }
}
