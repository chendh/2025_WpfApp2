README.md
# Week 3 (2025/9/24)
- ��github��repo�ۻ��ݩ�(pull)�^�ӥ��a��
- WPF��layout����
- Grid
*** RowDefinitions
*** ColumnsDefinitions
** StackPanel
Orientation: Vertical, Horizontal
TextBox��TextChanged�ƥ�
�ഫ���P��ƫ��A����k
Conver.ToInt32()
int.TryParse()
���o�Y����Parent�H�Ψ�S�̤���
                var targetStackPanel = targetTextBox.Parent as StackPanel;
                var targetNameLabel = targetStackPanel.Children[0] as Label;
                var targetPriceLabel = targetStackPanel.Children[1] as Label;
Slider����
Value�ݩ�
IsSnapToTickEnabled�ݩ�
Data Binding
