using System;
using System.Drawing;
using MonoMac.Foundation;
using MonoMac.AppKit;
using MonoMac.ObjCRuntime;
using Cocos2d;

[assembly: MonoMac.RequiredFramework("cocos2d.dylib")]
namespace EffectsTest
{
	public partial class AppDelegate : NSApplicationDelegate
	{
		public AppDelegate ()
		{
			Type t = typeof(CCDirector);
			MonoMac.ObjCRuntime.Runtime.RegisterAssembly(t.Assembly); 
		}

		public override void FinishedLaunching (NSObject notification)
		{
			CCDirector director = CCDirector.SharedDirector ();

			director.View = glView;
			director.DisplayStats = true;

			CCScene scene =  new CCScene();
			TextLayer l = new TextLayer();
			scene.AddChild (l);
			director.RunWithScene (scene);
		}
	}
}

