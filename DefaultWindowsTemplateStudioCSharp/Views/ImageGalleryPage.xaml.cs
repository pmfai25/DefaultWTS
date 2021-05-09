using System;

using DefaultWindowsTemplateStudioCSharp.ViewModels;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace DefaultWindowsTemplateStudioCSharp.Views
{
    public sealed partial class ImageGalleryPage : Page
    {
        public ImageGalleryViewModel ViewModel { get; } = new ImageGalleryViewModel();

        public ImageGalleryPage()
        {
            InitializeComponent();
            Loaded += ImageGalleryPage_Loaded;
        }

        private async void ImageGalleryPage_Loaded(object sender, RoutedEventArgs e)
        {
            await ViewModel.LoadDataAsync();
        }
    }
}
