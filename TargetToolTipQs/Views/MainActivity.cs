using Android.App;
using Android.Widget;
using Android.OS;
using IT.Sephiroth.Android.Library.Tooltip;
using System;
using Android.Support.V7.App;

namespace TargetToolTipQs
{
    [Activity(Label = "TargetToolTipQs", MainLauncher = true, Icon = "@drawable/icon",Theme = "@style/AppTheme")]
    public class MainActivity : AppCompatActivity
    {
        private Button btShowToolTip;
        private Tooltip.ITooltipView tooltip;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            btShowToolTip = FindViewById<Button>(Resource.Id.bt_show_tooltip);
            btShowToolTip.Click += (s, e) =>
            {
                Tooltip.Make(
                this,
                new Tooltip.Builder(101)
                    .Anchor((Button)s, Tooltip.Gravity.Bottom)
                    .ClosePolicy(Tooltip.ClosePolicy.TouchAnywhereNoConsume, 3000)
                    .Text("Tooltip on a TabLayout child...")
                    .FadeDuration(200)
                    .FitToScreen(false)
                    .MaxWidth(400)
                    .ShowDelay(400)
                    .ToggleArrow(true)
                    .Build()
            ).Show();
            };
        }
    }
}

