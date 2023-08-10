using System;
using System.Windows;

namespace SpinTheWheel
{
    public partial class MainWindow : Window
    {
        private readonly string[] wheelSections = { "Prize 1", "Prize 2", "Prize 3", "Prize 4", "Prize 5", "Prize 6" };

        public MainWindow()
        {
            InitializeComponent();
        }

        private void SpinButton_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            int index = random.Next(wheelSections.Length);

            string result = wheelSections[index];
            ResultText.Text = result;
        }
    }
}
