﻿using Microsoft.Web.WebView2.Core;

namespace Bluebird.Pages.SettingPages;

public sealed partial class About : Page
{
    public About()
    {
        this.InitializeComponent();
        string appversion = AppVersion.GetAppVersion();
        string coreversion = CoreWebView2Environment.GetAvailableBrowserVersionString();
        VersionText.Text = $"Bluebird {appversion} (core: {coreversion})";
    }

    private void SettingsBlockControl_Loaded(object sender, RoutedEventArgs e)
    {

    }
}
