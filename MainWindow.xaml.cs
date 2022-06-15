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

namespace WpfApp1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void keyboard(object sender, KeyEventArgs e)
        {
            UIElementCollection children = grid.Children;
            Border curborder = null;
            foreach (UIElement item in children)
            {
                if ((item is Border) && ((item as Border).Background as SolidColorBrush).Color.Equals(Colors.White))//遍历grid的子元素 并找出白色的那个border
                {
                    curborder = item as Border;
                }
                ((item as Border).Background as SolidColorBrush).Color.Equals(Colors.Transparent);
            }

            if (e.Key.Equals(Key.Up))//row -1
            {
                if ((int)curborder.GetValue(Grid.RowProperty) > 0)
                {
                    curborder.SetValue(Grid.RowProperty, (int)curborder.GetValue(Grid.RowProperty) - 1);
                }
            }
            if (e.Key.Equals(Key.Down))//row +1
            {
                if ((int)curborder.GetValue(Grid.RowProperty) < 2 )
                {
                    curborder.SetValue(Grid.RowProperty, (int)curborder.GetValue(Grid.RowProperty) + 1);
                }
            }
            if (e.Key.Equals(Key.Left))//column -1
            {
                if ((int)curborder.GetValue(Grid.ColumnProperty) > 0)
                {
                    curborder.SetValue(Grid.ColumnProperty, (int)curborder.GetValue(Grid.ColumnProperty) - 1);
             
                }
            }
            if (e.Key.Equals(Key.Right))//column +1
            {
                if ((int)curborder.GetValue(Grid.ColumnProperty) < 2)
                {
                    curborder.SetValue(Grid.ColumnProperty, (int)curborder.GetValue(Grid.ColumnProperty) + 1);

                }
            }
        }
    }
}
