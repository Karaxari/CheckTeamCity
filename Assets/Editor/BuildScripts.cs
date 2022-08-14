using System;
using System.IO;
using UnityEditor;
using UnityEngine;

public class BuildScripts : MonoBehaviour
{
    public static void BuildApk()
    {
        Debug.LogError(System.Environment.CurrentDirectory);
        var outdir = System.Environment.CurrentDirectory + "\\TestBuild";
        var outputPath = Path.Combine(outdir, Application.productName + ".exe");
        // Обработка папки
        if (!Directory.Exists(outdir)) Directory.CreateDirectory(outdir);
        if (File.Exists(outputPath)) File.Delete(outputPath);

        // Запускаем проект в один клик
        string[] scenes = new[] { "Assets/FPS/Scenes/MainScene.unity" };
        UnityEditor.BuildPipeline.BuildPlayer(scenes, outputPath, BuildTarget.StandaloneWindows, BuildOptions.None);
        if (File.Exists(outputPath))
        {
            Debug.Log("Build Success :" + outputPath);
        }
        else
        {
            Debug.LogException(new Exception("Build Fail! Please Check the log! "));
        }
    }
}