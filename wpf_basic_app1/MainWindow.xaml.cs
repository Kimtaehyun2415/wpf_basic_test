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
using wpf_basic_app1.ViewModel;

namespace wpf_basic_app1
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if(txtInput != null && txtInput.Text.Length >= 3)
            {
                e.CanExecute = true;
            }
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("실행할 코드를 3자리 이상 입력하시오");
        }

        private void btn_up_Click(object sender, RoutedEventArgs e)
        {
            BindingExpression source_clickevent = txtTarget.GetBindingExpression(TextBox.TextProperty);
            source_clickevent.UpdateSource();
        }
    }
}
