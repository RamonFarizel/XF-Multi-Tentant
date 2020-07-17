﻿using Android.App;
using Android.Content.PM;
using XFMultiTenant.Android.Core;
using XFMultiTenant.Common;

namespace XFMultiTenant.Droid
{
    [Activity(Label = "XFMultiTenant", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : MainActivityBase
    {
        protected override ITenant Tenant => Tenants.TenantA.GetTenant();
    }
}