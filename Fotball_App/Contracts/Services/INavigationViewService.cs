﻿using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;

namespace Fotball_App.Contracts.Services
{
    public interface INavigationViewService
    {
        IList<object> MenuItems { get; }

        object SettingsItem { get; }

        void Initialize(NavigationView navigationView);

        void UnregisterEvents();

        NavigationViewItem GetSelectedItem(Type pageType);
    }
}
