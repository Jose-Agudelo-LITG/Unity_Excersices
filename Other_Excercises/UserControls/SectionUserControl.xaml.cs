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

namespace Other_Excercises.UserControls
{
    /// <summary>
    /// Lógica de interacción para SectionUserControl.xaml
    /// </summary>
    public partial class SectionUserControl : UserControl
    {
        public SectionUserControl()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("hola");
        }

        private void Section_MouseEnter(object sender, MouseEventArgs e)
        {
            var a = Resources["SectionExpand"] as Storyboard;
            a.Begin();
        }

        private void Section_MouseLeave(object sender, MouseEventArgs e)
        {
            var a = Resources["SectionCollapse"] as Storyboard;
            a.Begin();
        }
    }
}
