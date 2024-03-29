﻿using System;

using DefaultWindowsTemplateStudioCSharp.ViewModels;

using Windows.UI.Xaml.Controls;

namespace DefaultWindowsTemplateStudioCSharp.Views
{
    public sealed partial class WebViewPage : Page
    {
        public WebViewViewModel ViewModel { get; } = new WebViewViewModel();

        public WebViewPage()
        {
            InitializeComponent();
            ViewModel.Initialize(webView);
        }
    }
}
