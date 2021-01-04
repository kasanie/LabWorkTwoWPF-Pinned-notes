using System.Windows;
using System.Windows.Controls;

namespace LabWorkTwoWPF
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            ShowText.Items.Add(WriteText.Text);
            WriteText.Clear();
        }
    }
}
