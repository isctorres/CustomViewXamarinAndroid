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
using static Android.Preferences.Preference;

namespace VistaPersonalizada
{
    class ViewState : BaseSavedState
    {
        public ViewState(IParcelable superState) : base(superState)
        {
        }
        public ViewState(Parcel parcel) : base(parcel)
        {
            valor = parcel.ReadInt();
            colorInicial = parcel.ReadString();
            colorProcesando = parcel.ReadString();
            texto = parcel.ReadString();
        }
        public int valor { get; set; }
        public string colorInicial { get; set; }
        public string colorProcesando { get; set; }
        public string texto { get; set; }

        public override void WriteToParcel(Parcel dest, ParcelableWriteFlags flags)
        {
            base.WriteToParcel(dest, flags);
            dest.WriteInt(valor);
            dest.WriteString(colorInicial);
            dest.WriteString(colorProcesando);
            dest.WriteString(texto);
        }

        [Java.Interop.ExportField("CREATOR")]
        private static ViewStateCreator InitializeCreator()
        {
            return new ViewStateCreator();
        }

    }
}