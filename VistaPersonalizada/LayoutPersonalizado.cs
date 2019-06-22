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
    class LayoutPersonalizado : LinearLayout
    {
        public string colorBotonGuardar { get; set; }
        public string colorBotonActualizar { get; set; }
        public string colorBotonBorrar { get; set; }
        // Constructor para codigo
        public LayoutPersonalizado(Context context) : base(context)
        {
            colorBotonGuardar = "#55FFAA";
            colorBotonActualizar = "#11BF36";
            colorBotonBorrar = "#53FAAA";

            this.Orientation = Orientation.Vertical;

            TextView txtEtiqueta = new TextView(context);
            txtEtiqueta.SetText(Resource.String.etiqueta);
            this.AddView(txtEtiqueta);

            EditText editTexto = new EditText(context);
            editTexto.InputType = Android.Text.InputTypes.ClassText;
            this.AddView(editTexto);

            Button botonGuardar = new Button(context);
            botonGuardar.Text = "Guardar";
            botonGuardar.SetBackgroundColor(Android.Graphics.Color.ParseColor(colorBotonGuardar));
            this.AddView(botonGuardar);

            Button botonActualizar = new Button(context);
            botonActualizar.Text = "Actualizar";
            botonGuardar.SetBackgroundColor(Android.Graphics.Color.ParseColor(colorBotonActualizar));
            this.AddView(botonActualizar);

            Button botonBorrar = new Button(context);
            botonBorrar.Text = "Borrar";
            botonGuardar.SetBackgroundColor(Android.Graphics.Color.ParseColor(colorBotonBorrar));
            this.AddView(botonBorrar);
        }

        // Constructor para XML
        public LayoutPersonalizado(Context context, Android.Util.IAttributeSet attrs) : base(context, attrs)
        {
            Android.Content.Res.TypedArray styled = context.Theme.ObtainStyledAttributes(
            attrs, Resource.Styleable.LayoutPersonalizado, 0, 0);
            try
            {
                // set the property from the attribute
                colorBotonGuardar = styled.GetText(Resource.Styleable.LayoutPersonalizado_colorBotonGuardar);
                colorBotonActualizar = styled.GetText(Resource.Styleable.LayoutPersonalizado_colorBotonActualizar);
                colorBotonBorrar = styled.GetText(Resource.Styleable.LayoutPersonalizado_colorBotonBorrar);

                this.Orientation = Orientation.Vertical;
                TextView txtEtiqueta = new TextView(context);
                txtEtiqueta.SetText(Resource.String.etiqueta);
                this.AddView(txtEtiqueta);

                EditText editTexto = new EditText(context);
                editTexto.InputType = Android.Text.InputTypes.ClassText;
                this.AddView(editTexto);

                Button botonGuardar = new Button(context);
                botonGuardar.Text = "Guardar";
                botonGuardar.SetBackgroundColor(Android.Graphics.Color.ParseColor(colorBotonGuardar));
                this.AddView(botonGuardar);

                Button botonActualizar = new Button(context);
                botonActualizar.Text = "Actualizar";
                botonGuardar.SetBackgroundColor(Android.Graphics.Color.ParseColor(colorBotonActualizar));
                this.AddView(botonActualizar);

                Button botonBorrar = new Button(context);
                botonBorrar.Text = "Borrar";
                botonGuardar.SetBackgroundColor(Android.Graphics.Color.ParseColor(colorBotonBorrar));
                this.AddView(botonBorrar);
            }
            finally
            {
                // clean up
                styled.Recycle();
                styled.Dispose();
            }
        }
    }
}