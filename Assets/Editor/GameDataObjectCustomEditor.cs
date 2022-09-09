using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Callbacks;
using UnityEngine;

public class AssetHandler
{
    [OnOpenAsset()]
    public static bool OpenEditor(int instanceId, int line)
    {
        GameDataObject obj = EditorUtility.InstanceIDToObject(instanceId) as GameDataObject;
        if(obj!= null)
        {
            GameDataObjectEditorWindows.Open(obj);
            return true;
        }

        return false;
    }
}




[CustomEditor(typeof(GameDataObject))]
public class GameDataObjectCustomEditor : Editor
{
    public override void OnInspectorGUI()
    {
        if (GUILayout.Button("open Editor"))
        {
            GameDataObjectEditorWindows.Open((GameDataObject)target);
        }
    }
}
