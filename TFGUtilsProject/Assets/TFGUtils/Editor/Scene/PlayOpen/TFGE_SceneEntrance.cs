using TFGUtils.Editor.Scene.Common;
using TFGUtils.Editor.Scene.Const;
using UnityEditor;

namespace TFGUtils.Editor.Scene.PlayOpen
{
    public class TFGE_SceneEntrance
    {
        private const string TitleName = "Entrance";
        private const string ScenePath = "Assets/Demo/Scenes/Launch.unity";
        private const string MenuPlayTitle = TFGE_SceneConst.MenuTitlePlay + TitleName;
        private const string MenuOpenTitle = TFGE_SceneConst.MenuTitleOpen + TitleName;

        /// <summary>
        /// 运行场景
        /// </summary>
        [MenuItem(MenuPlayTitle, priority = TFGE_SceneConst.PlayTitlePriority)]
        private static void PlayScene()
        {
            if (EditorApplication.isPlaying) return;

            TFGE_SceneCommon.OpenScene(ScenePath);

            if (!EditorApplication.isPlaying)
                EditorApplication.isPlaying = true;
        }

        /// <summary>
        /// 打开场景
        /// </summary>
        [MenuItem(MenuOpenTitle, priority = TFGE_SceneConst.OpenTitlePriority)]
        private static void OpenScene()
        {
            if (EditorApplication.isPlaying) return;
            TFGE_SceneCommon.OpenScene(ScenePath);
        }
    }
}