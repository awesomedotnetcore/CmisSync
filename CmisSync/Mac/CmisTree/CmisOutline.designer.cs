// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoMac.Foundation;
using System.CodeDom.Compiler;

namespace CmisSync
{
	[Register ("CmisOutlineController")]
	partial class CmisOutlineController
	{
		[Outlet]
		MonoMac.AppKit.NSOutlineView Outline { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (Outline != null) {
				Outline.Dispose ();
				Outline = null;
			}
		}
	}

	[Register ("CmisOutline")]
	partial class CmisOutline
	{
		
		void ReleaseDesignerOutlets ()
		{
		}
	}
}
