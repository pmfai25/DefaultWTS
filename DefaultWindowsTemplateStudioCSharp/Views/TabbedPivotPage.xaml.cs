using System;

using DefaultWindowsTemplateStudioCSharp.ViewModels;

using Windows.UI.Xaml.Controls;

namespace DefaultWindowsTemplateStudioCSharp.Views
{
    public sealed partial class TabbedPivotPage : Page
    {
        public TabbedPivotViewModel ViewModel { get; } = new TabbedPivotViewModel();

        public TabbedPivotPage()
        {
            InitializeComponent();
        }
    }
}
