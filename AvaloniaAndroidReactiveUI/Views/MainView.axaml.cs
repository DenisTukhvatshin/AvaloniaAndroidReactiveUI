using Avalonia.Controls;
using Avalonia.Interactivity;
using AvaloniaAndroidReactiveUI.ViewModels;

namespace AvaloniaAndroidReactiveUI.Views
{
    public partial class MainView : UserControl
    {
        private readonly MainViewModel? _mainViewModel;
        public MainView()
        {
            InitializeComponent();
            _mainViewModel = new MainViewModel();
            DataContext = _mainViewModel;
        }

        private void Button_OnClick(object? sender, RoutedEventArgs e)
        {
            if (_mainViewModel != null) 
                _mainViewModel.Greeting = "It is working OK!";
        }
    }
}