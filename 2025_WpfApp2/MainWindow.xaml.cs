using System.Windows;
using System.Windows.Controls;

namespace _2025_WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Dictionary<string, int> drinks = new Dictionary<string, int> 
        {
            {"紅茶大杯", 60 },
            {"紅茶小杯", 40 },
            {"綠茶大杯", 60 },
            {"綠茶小杯", 40 },
            {"可樂大杯", 40 },
            {"可樂小杯", 20 },
        };

        Dictionary<string, int> orders = new Dictionary<string, int>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void OrderButton_Click(object sender, RoutedEventArgs e)
        {
            int total = 0;
            int index = 0;
            Result_TextBlock.Text = "飲料訂單如下：\n";
            foreach (var item in orders)
            {
                string drinkitem = item.Key;
                int amount = item.Value;
                int price = drinks[drinkitem];

                if (amount > 0)
                {
                    index++;
                    int subtotal = price * amount;
                    Result_TextBlock.Text += $"{index}：{drinkitem} {price}元 x {amount}杯 = {subtotal}元\n";
                    total += subtotal;
                }
            }
            Result_TextBlock.Text += $"\n總計：{total}元";

            int sellPrice = total;
            string discount_message = "無折扣";
            if (total >= 500)
            {
                sellPrice = (int)(total * 0.8);
                discount_message = "八折";
            }
            else if (total >= 300)
            {
                sellPrice = (int)(total * 0.85);
                discount_message = "八五折";
            }
            else if (total >= 200)
            {
                sellPrice = (int)(total * 0.9);
                discount_message = "九折";
            }
            else discount_message = "未達到折扣條件";
            Result_TextBlock.Text += $"\n折扣：{discount_message}，售價{sellPrice}元\n";
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var targetSlider = sender as Slider;
            int amount = (int)targetSlider.Value;
            var targetStackPanel = targetSlider.Parent as StackPanel;
            var targetNameLabel = targetStackPanel.Children[0] as Label;
            var drinkName = targetNameLabel.Content.ToString();

            //MessageBox.Show($"您點的餐點是 {drinkName}，單價是 {drinks[drinkName]}，數量是 {amount}", "輸入成功");

            if (orders.ContainsKey(drinkName)) orders[drinkName] = amount;
            else orders.Add(drinkName, amount);
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