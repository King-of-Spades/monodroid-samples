using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Views;

namespace CameraProject.Android
{
	[Activity(Label = "MonoGame"
		, Theme = "@android:style/Theme.Black.NoTitleBar.Fullscreen"
		, MainLauncher = true
		, Icon = "@drawable/icon"
		, AlwaysRetainTaskState = true
		, LaunchMode = LaunchMode.SingleInstance
		, ScreenOrientation = ScreenOrientation.SensorLandscape
		, ConfigurationChanges = ConfigChanges.Orientation | 
		ConfigChanges.Keyboard | 
		ConfigChanges.KeyboardHidden)]
	public class GameActivity : Microsoft.Xna.Framework.AndroidGameActivity
	{
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate (bundle);
			CameraProject.Game1.Activity = this;
			var g = new CameraProject.Game1 ();
			SetContentView (g.Window);
			g.Run ();
		}
	}
}
