using MControls.ViewModel;
using MyDemo.ViewModel;
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

namespace MyDemo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
         private MxViewModel mxViewModel;

        public MainWindow()
        {
            InitializeComponent();
            InitControlViewModel();
        }

        private void InitControlViewModel()
        {
            mxViewModel = (MxViewModel)mxC.DataContext;
        }

        // Todo:想想Click事件如何通过MainViewModel定义Command实现。
        private void btnTest_Click(object sender, RoutedEventArgs e)
        {
            mxViewModel.MxInfo.Content += "Message from main form!\r\n";
        }
    }
}
