using System.ComponentModel;
using System.Reflection;
using System.Windows;

namespace WpfMVVMAutoPropertyChanged
{
    public class MainWindow_Model : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string Title { get; set; } = nameof(WpfMVVMAutoPropertyChanged);
        public string Version { get; set; } = Assembly.GetExecutingAssembly().GetName().Version.ToString();

        public string FullText
        {
            get => $"{Title} {Version}";
        }

        public Command ClickCommand { get; }

        public MainWindow_Model()
        {
            ClickCommand = new Command(() =>
            {
                MessageBox.Show(FullText);
            });
        }
    }
}