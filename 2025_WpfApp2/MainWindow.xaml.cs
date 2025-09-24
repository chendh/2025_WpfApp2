using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _2025_WpfApp2
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

        private void OrderButton_Click(object sender, RoutedEventArgs e)
        {

        }

        //private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    var targetTextBox = sender as TextBox;
        //    int amount;
        //    bool success = int.TryParse(targetTextBox.Text, out amount);
        //    if (!success || amount < 0)
        //    {
        //        MessageBox.Show("請輸入正整數", "輸入錯誤");
        //    }
        //    else
        //    {
        //        //MessageBox.Show($"您輸入的數量是 {amount}", "輸入成功");
        //        var targetStackPanel = targetTextBox.Parent as StackPanel;
        //        var targetNameLabel = targetStackPanel.Children[0] as Label;
        //        var targetPriceLabel = targetStackPanel.Children[1] as Label;

        //        MessageBox.Show($"您點的餐點是 {targetNameLabel.Content}，單價是 {targetPriceLabel.Content}，數量是 {amount}", "輸入成功");
        //    }
        //}
    }
}