using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Widget;

namespace AndroidCustomGridView
{
    [Activity(Label = "AndroidCustomGridView", MainLauncher = true, Icon = "@drawable/icon",Theme ="@style/MyTheme")]
    public class MainActivity : AppCompatActivity
    {
        GridView gridView;
        string[] gridViewString = {
            "Location","Sound","Note","List",
             "Location","Sound","Note","List",
              "Location","Sound","Note","List"
        };

        int[] imageId = {
            Resource.Drawable.location,Resource.Drawable.sound,Resource.Drawable.note,Resource.Drawable.list,
             Resource.Drawable.location,Resource.Drawable.sound,Resource.Drawable.note,Resource.Drawable.list,
              Resource.Drawable.location,Resource.Drawable.sound,Resource.Drawable.note,Resource.Drawable.list
        };
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);
            SupportActionBar.Title = "Custom Grid View";

            CustomGridViewAdapter adapter = new CustomGridViewAdapter(this, gridViewString, imageId);
            gridView = FindViewById<GridView>(Resource.Id.grid_view_image_text);
            gridView.Adapter = adapter;
            gridView.ItemClick += (s, e) => {
                Toast.MakeText(this, "GridView Item: " + gridViewString[e.Position], ToastLength.Short).Show();
            };
        }
    }
}