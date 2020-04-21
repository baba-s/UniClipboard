using UnityEngine;

namespace UniClipboard
{
	public static class Clipboard
	{
		public static string GetText()
		{
			return GUIUtility.systemCopyBuffer;
		}

		public static void SetText( string text )
		{
			GUIUtility.systemCopyBuffer = text;
		}

		public static void SetText<T>( T target )
		{
			SetText( target.ToString() );
		}
	}
}