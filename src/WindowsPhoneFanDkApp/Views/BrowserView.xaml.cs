﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace WindowsPhoneFanDkApp.Views
{
    public partial class BrowserView : PhoneApplicationPage
    {
        public BrowserView()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            string url = "";

            if (NavigationContext.QueryString.TryGetValue("url", out url))
                browser.Navigate(new Uri(url, UriKind.Absolute));

               
        }
    }
}