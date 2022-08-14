using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Test
{
    [MenuItem("Build/BuildApk")]
    public static void BuildApk()
    {
        Debug.Log("Kurva");
        TestBuild.BuildApk();
    }
}
