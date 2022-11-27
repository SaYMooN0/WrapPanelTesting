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

namespace WrapPanel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            sizeChange(this, new EventArgs());
            Button navyB = new Button{ Foreground=Brushes.Navy,Margin = new Thickness(2),Content="Navy"};
            Button blueB = new Button{ Foreground = Brushes.Blue, Margin = new Thickness(2), Content = "Blue" };
            Button aquaB = new Button{ Foreground = Brushes.Aqua, Margin = new Thickness(2), Content = "Aqua" };
            Button tealB = new Button{ Foreground = Brushes.Teal, Margin = new Thickness(2), Content = "Teal" };
            Button oliveB = new Button{ Foreground = Brushes.Olive, Margin = new Thickness(2), Content = "Olive" };
            Button greenB = new Button{ Foreground = Brushes.Green, Margin = new Thickness(2), Content = "Green" };
            Button limeB = new Button { Foreground = Brushes.Lime, Margin = new Thickness(2), Content = "Lime" };
            Button yellowB = new Button { Foreground = Brushes.Yellow, Margin = new Thickness(2), Content = "Yellow" };
            Button orangeB = new Button { Foreground = Brushes.Orange, Margin = new Thickness(2), Content = "Orange" };
            Button redB = new Button { Foreground = Brushes.Red, Margin = new Thickness(2), Content = "Red" };
            Button maroonB = new Button { Foreground = Brushes.Maroon, Margin = new Thickness(2), Content = "Maroon" };
            Button fuchsiaB = new Button { Foreground = Brushes.Fuchsia, Margin = new Thickness(2), Content = "Fuchsia" };
            Button purpleB = new Button { Foreground = Brushes.Purple, Margin = new Thickness(2), Content = "Purple" }; 
            Button blackB = new Button { Foreground = Brushes.Black, Margin = new Thickness(2), Content = "Black" };
            Button grayB = new Button { Foreground = Brushes.Gray, Margin = new Thickness(2), Content = "Gray" };
            Button silverB = new Button { Foreground = Brushes.Silver, Margin = new Thickness(2), Content = "Silver" };
            Button whiteB = new Button { Foreground = Brushes.White, Margin = new Thickness(2), Content = "White" };
            wP.Children.Add(navyB);
            wP.Children.Add(blueB);
            wP.Children.Add(aquaB);
            wP.Children.Add(tealB);
            wP.Children.Add(oliveB);
            wP.Children.Add(greenB);
            wP.Children.Add(limeB);
            wP.Children.Add(yellowB);
            wP.Children.Add(whiteB);
            wP.Children.Add(silverB);
            wP.Children.Add(grayB);
            wP.Children.Add(blackB);
            wP.Children.Add(purpleB);
            wP.Children.Add(fuchsiaB);
            wP.Children.Add(maroonB);
            wP.Children.Add(redB);
            wP.Children.Add(orangeB);   
            this.SizeChanged += sizeChange;
        }
        private void sizeChange(object sender, System.EventArgs e)
        {
            wP.Height = this.Height *2/3;
            wP.Width = this.Width * 2/3;
        }
    }
}
