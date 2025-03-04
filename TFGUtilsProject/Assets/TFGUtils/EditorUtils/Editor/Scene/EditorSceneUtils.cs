﻿using TFGUtils.EditorUtils.Editor.Const;
using UnityEditor;
using UnityEditor.SceneManagement;

namespace TFGUtils.EditorUtils.Editor.Scene
{
    public class EditorSceneUtils
    {
        public class GotoScene
        {
            private const string LAUNCHER_SCENE = "Assets/Scenes/launch.unity";

            [MenuItem(TFGEditorConst.MenuRootTitle + "/Scene/Main")]
            private static void OpenMainScene()
            {
                OpenScene("Assets/Scenes/Main.unity");
            }

            [MenuItem(TFGEditorConst.MenuRootTitle + "/Scene/Launch")]
            private static void OpenLauncherScene()
            {
                OpenScene(LAUNCHER_SCENE);
            }

            [MenuItem(TFGEditorConst.MenuRootTitle + "/Scene/LaunchAndPlay", priority = 0)]
            private static void PlayGame()
            {
                if (EditorApplication.isPlaying) return;

                OpenScene(LAUNCHER_SCENE);

                if (!EditorApplication.isPlaying)
                    EditorApplication.isPlaying = true;
            }

            private static void OpenScene(string scenePath)
            {
                if (EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo())
                    EditorSceneManager.OpenScene(scenePath);
            }
        }
    }
}
//
// public static class EditorTools
// {
//     [MenuItem("Assets/GameStart #F5", false, 999)] // 使用快捷键Shift+F5进入或退出Play模式
//     static void PlayGame()
//     {
//         if (EditorApplication.isPlaying) return;
//
//         var mainScene = "Assets/Scenes/Init.unity";
//
//         if (EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo())
//             EditorSceneManager.OpenScene(mainScene);
//
//         if (!EditorApplication.isPlaying)
//             EditorApplication.isPlaying = true;
//     }
//
//     [MenuItem("Assets/Open Hotfix Sln #F9", false, 998)]
//     public static void OpenHotfixSln()
//     {
//         var path = Directory.GetParent(Application.dataPath) + "\\HotUpdateScripts\\HotUpdateScripts.sln";
//         System.Diagnostics.Process.Start(path);
//     }
// }