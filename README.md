README.md
# Week 3 (2025/9/24)
- 把github的repo自遠端拉(pull)回來本地端
- WPF的layout元件
- Grid
*** RowDefinitions
*** ColumnsDefinitions
** StackPanel
Orientation: Vertical, Horizontal
TextBox的TextChanged事件
轉換不同資料型態的方法
Conver.ToInt32()
int.TryParse()
取得某元件的Parent以及其兄弟元件
                var targetStackPanel = targetTextBox.Parent as StackPanel;
                var targetNameLabel = targetStackPanel.Children[0] as Label;
                var targetPriceLabel = targetStackPanel.Children[1] as Label;
Slider元件
Value屬性
IsSnapToTickEnabled屬性
Data Binding
