using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace WSECU
{
	[TestFixture(Platform.Android)]
	[TestFixture(Platform.iOS)]
	public class Tests
	{
		IApp app;
		Platform platform;

		public Tests(Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest()
		{
			app = AppInitializer.StartApp(platform);
			app.Screenshot("App Launched");
		}

		[Test]
		public void AppLaunches()
		{
			app.Repl();
		}

		[Test]
		public void IDNoPassword()
		{
			app.Tap("loginEdit");
			app.Screenshot("Let's start by Tapping on the 'Login' Text Edit Field");
			app.EnterText("CaroleWashburn@wsecu.com");
			app.Screenshot("Then we entered our email, 'CaroleWashburn@wsecu.com'");
			app.DismissKeyboard();
			app.Screenshot("Dismissed Keyboard");
			app.Tap("signin_button");
			app.Screenshot("Then we Tapped the 'Sign In' Button");
		}

		[Test]
		public void PasswordNoID()
		{
			app.Tap("password_edit");
			app.Screenshot("We Tapped on the 'Password' Text Edit Field");
			app.EnterText("CaroleWashburn");
			app.Screenshot("Next we entered our password, 'CaroleWashburn'");
			app.DismissKeyboard();
			app.Screenshot("Dismissed Keyboard");
			app.Tap("signin_button");
		}

	}
}
