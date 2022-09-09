using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
public class GameDataObjectEditorWindows : EditorWindow
{
    public static void Open(GameDataObject dataObj)
    {
        GameDataObjectEditorWindows windows = GetWindow<GameDataObjectEditorWindows>("Game data Editor");

    }

    [MenuItem("Window/Example")]
    static void ShowWindow()
    {
        EditorWindow.GetWindow<GameDataObjectEditorWindows>("Example windows");
    }

    private void OnGUI()
    {
        GUILayout.Label("1231231");

        EditorGUILayout.TextField("name", "1231");
    }
}
