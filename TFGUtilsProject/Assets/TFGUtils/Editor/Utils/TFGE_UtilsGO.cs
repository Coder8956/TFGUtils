using System.Collections.Generic;
using UnityEngine;

namespace TFGUtils.Editor.Utils
{
    public class TFGE_UtilsGO
    {
        /// <summary>
        /// 清理子物体
        /// </summary>
        /// <param name="go"></param>
        public static void ClearSubGO(GameObject go)
        {
            List<GameObject> subObjects = new List<GameObject>();
            foreach (Transform t in go.transform)
            {
                subObjects.Add(t.gameObject);
            }

            foreach (var subGO in subObjects)
            {
                GameObject.DestroyImmediate(subGO);
            }
        }
    }
}