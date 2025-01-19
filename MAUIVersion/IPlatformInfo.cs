using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#if ANDROID
using Android.App;
using Android.Content.Res;
using Android.Util;
#endif
using Microsoft.Maui.ApplicationModel;
namespace MAUIVersion
{
    interface IPlatformInfo
    {
        double GetStatusBarHeight();
        double GetNavigationBarHeight();
    }
}
