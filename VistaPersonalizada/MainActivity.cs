using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using VistaPersonalizada.Views;

namespace VistaPersonalizada
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);

            if (savedInstanceState != null)
                SupportActionBar.Title = savedInstanceState.GetString("LLAVE_GUARDADA");

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            
            RelativeLayout relativeLayout = FindViewById<RelativeLayout>(Resource.Id.relativeLayout);
            ColorButton myColorButton = new ColorButton(this);
            myColorButton.Text = "My Color Button";
            myColorButton.Id = 100;

            RelativeLayout.LayoutParams layoutParams = new RelativeLayout.LayoutParams(RelativeLayout.LayoutParams.WrapContent, RelativeLayout.LayoutParams.WrapContent);
            layoutParams.AddRule(LayoutRules.Below, Resource.Id.linearPersonalizado);
            myColorButton.LayoutParameters = layoutParams;
            relativeLayout.AddView(myColorButton);

            LayoutPersonalizado linearPersonalizado = new LayoutPersonalizado(this);
            RelativeLayout.LayoutParams layoutParams2 = new RelativeLayout.LayoutParams(RelativeLayout.LayoutParams.WrapContent, RelativeLayout.LayoutParams.WrapContent);
            layoutParams2.AddRule(LayoutRules.Below, Resource.Id.linearPersonalizado);
            linearPersonalizado.LayoutParameters = layoutParams2;
            relativeLayout.AddView(linearPersonalizado);
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }


        protected override void OnSaveInstanceState(Bundle outState)
        {
            base.OnSaveInstanceState(outState);
            outState.PutString("LLAVE_GUARDADA", "Llave guardada");
        }
    }
}