using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// 빈 페이지 항목 템플릿에 대한 설명은 https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x412에 나와 있습니다.

namespace FumigatingDatabase
{
    /// <summary>
    /// 자체적으로 사용하거나 프레임 내에서 탐색할 수 있는 빈 페이지입니다.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void btnON_Click(object sender, RoutedEventArgs e)
        {
            BlankPage1 _dlg = new BlankPage1();
            _dlg.ShowDialog();
           }

        private void btnOFF_Click(object sender, RoutedEventArgs e)
        {
            BlankPage2 _dlg = new BlankPage2();
            _dlg.ShowDialog();

        }
    }
}
