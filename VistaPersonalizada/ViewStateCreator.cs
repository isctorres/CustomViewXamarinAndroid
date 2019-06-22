using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace VistaPersonalizada
{
    class ViewStateCreator : Java.Lang.Object, IParcelableCreator
    {
        public Java.Lang.Object CreateFromParcel(Parcel source)
        {
            return new ViewState(source);
        }
        public Java.Lang.Object[] NewArray(int size)
        {
            return new ViewState[size];
        }

    }
}