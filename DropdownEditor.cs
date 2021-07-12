using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(DropDown))]
public class DropdownEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        DropDown script = (DropDown)target;

        GUIContent arrayLabel = new GUIContent("MyArray");
        script.arrayIdx = EditorGUILayout.Popup(arrayLabel, script.arrayIdx, script.MyArray);

        GUIContent arrayList = new GUIContent("MyList");
        script.listIdx = EditorGUILayout.Popup(arrayList, script.listIdx, script.MyList.ToArray());
    }
}