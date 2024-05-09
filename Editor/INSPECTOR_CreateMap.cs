using System.Collections;using System.Collections.Generic;using System.Linq;using System;
using UnityEngine;
using UnityEditor;



[CustomEditor(typeof(CreateMap))]
public partial class INSPECTOR_CreateMap : Editor
{
    [SerializeField] bool debugging;


    CreateMap my_CreateMap { get { return (CreateMap)target; } }


    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        if(GUILayout.Button("generateMap"))
        {
            my_CreateMap.generateMap(10);
        }
    }
}
