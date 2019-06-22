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

namespace VistaPersonalizada.Views
{
    class ColorButton : Button
    {
        public int valor { get; set; }
        public string colorInicial { get; set; }
        public string colorProcesando { get; set; }

        public ColorButton(Context context) : base(context)
        {
            colorInicial = "#ffbf360c";
            colorProcesando = "#11bf360c";
            valor = 100000000;
            Click += OnClicked;
        }   

        public ColorButton(Context context, Android.Util.IAttributeSet attrs) : base(context, attrs)
        {
            Android.Content.Res.TypedArray styled = context.Theme.ObtainStyledAttributes(
            attrs, Resource.Styleable.ColorButton, 0, 0);
            try
            {
                // set the property from the attribute
                valor = styled.GetInt(Resource.Styleable.ColorButton_valor, 100000000);
                colorInicial = styled.GetText(Resource.Styleable.ColorButton_colorInicial);
                colorProcesando = styled.GetText(Resource.Styleable.ColorButton_colorProcesando);
            }
            finally
            {
                // clean up
                styled.Recycle();
                styled.Dispose();
            }
            Click += OnClicked;
        }
            
        private async void OnClicked(object sender, EventArgs e)
        {
            this.SetBackgroundColor(Android.Graphics.Color.ParseColor(colorProcesando));
            await System.Threading.Tasks.Task.Run(Tarea);
            this.SetBackgroundColor(Android.Graphics.Color.ParseColor(colorInicial));
            this.Text = "Boton Clickeado";
        }

        private void Tarea()
        {
            int i = 0;
            while (i < valor) i++;
        }

        public override IParcelable OnSaveInstanceState()
        {
            IParcelable state = base.OnSaveInstanceState();
            ViewState instance = new ViewState(state)
            {
                valor = valor,
                colorInicial = colorInicial,
                colorProcesando = colorProcesando,
                texto = this.Text
            };
            return instance;
        }

        public override void OnRestoreInstanceState(IParcelable state)
        {
            ViewState instance = state as ViewState;
            if (instance == null)
            {
                base.OnRestoreInstanceState(state);
            }
            else
            {
                base.OnRestoreInstanceState(instance.SuperState);
                valor = instance.valor;
                colorInicial = instance.colorInicial;
                colorProcesando = instance.colorProcesando;
                this.Text = instance.texto;
            }
        }

    }
}