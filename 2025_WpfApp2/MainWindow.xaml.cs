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
        string buy_type = "外帶";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void OrderButton_Click(object sender, RoutedEventArgs e)
        {
            orders.Clear();

            for (int i = 0; i < DrinkMenu_StackPanel.Children.Count; i++)
            {
                var sp = DrinkMenu_StackPanel.Children[i] as StackPanel;
                var cb = sp.Children[0] as CheckBox;
                var drinkName = cb.Content.ToString();
                var sl = sp.Children[2] as Slider;
                var amount = (int)sl.Value;

                if (cb.IsChecked == true && amount > 0) orders.Add(drinkName, amount);
            }

            int total = 0;
            int index = 0;
            Result_TextBlock.Text = $"購買方式：{buy_type}\n";
            Result_TextBlock.Text += "飲料訂單如下：\n";
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


        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton targetRadioButton = sender as RadioButton;
            buy_type = targetRadioButton.Content.ToString();
        }
    }
}