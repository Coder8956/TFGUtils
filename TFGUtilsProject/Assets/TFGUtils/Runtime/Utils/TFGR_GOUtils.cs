using System.Collections.Generic;
using UnityEngine;

namespace TFGUtils.Runtime.Utils
{
    public class TFGR_UtilsGO
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
                GameObject.Destroy(subGO);
            }
        }

        /// <summary>
        /// 创建子物体
        /// </summary>
        /// <param name="parent">父物体</param>
        /// <param name="subGO">子物体</param>
        /// <param name="count">子物体数量</param>
        public static List<GameObject> CreateSubGO(GameObject parent, GameObject subGO, int count)
        {
            List<GameObject> subObjects = new List<GameObject>();
            for (int i = 0; i < count; i++)
            {
                GameObject newSubGO = GameObject.Instantiate(subGO, parent.transform, false);
                subObjects.Add(newSubGO);
            }

            return subObjects;
        }
    }
}