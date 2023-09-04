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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox txt_log = sender as TextBox;


            if (true)
            {
                txt_log.Text = txt_log.Text.Trim();
                txt_log.Text = "Button_log_Click";
            }
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            MessageBox.Show($"{btn.Name} 클릭 되었습니다.");

            Func<bool, bool, bool> func_cmd = NetworkFunction;

        }

        public static bool NetworkFunction(bool input_btn, bool output_btn)
        {
            bool btn_log_start = input_btn;
            return btn_log_start;
        }
    }
}
