// https://forum.unity.com/threads/shortcut-for-clear-console.758525/
#if UNITY_EDITOR
using System.Reflection;
using UnityEngine;
using UnityEditor;
using UnityEditor.ShortcutManagement;

public static class Shortcuts {
	[MenuItem("Window/Clear Console %&v")]
	public static void ClearConsole() {
		var assembly = Assembly.GetAssembly(typeof(SceneView));
		var type = assembly.GetType("UnityEditor.LogEntries");
		var method = type.GetMethod("Clear");
		method.Invoke(new object(), null);
	}
}
#endif
