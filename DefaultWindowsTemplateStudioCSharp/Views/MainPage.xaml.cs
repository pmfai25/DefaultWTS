using System;

using DefaultWindowsTemplateStudioCSharp.ViewModels;

using Windows.UI.Xaml.Controls;

namespace DefaultWindowsTemplateStudioCSharp.Views
{
    public sealed partial class MainPage : Page
    {
        public MainViewModel ViewModel { get; } = new MainViewModel();

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
