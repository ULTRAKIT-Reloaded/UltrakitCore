﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ULTRAKIT.Core
{
    public static class GraphicsUtilities
    {
        /// <summary>
        /// Creates a sprite of the specified size from an image. The file extension should be changed to `.bytes` prior to loading.
        /// </summary>
        /// <param name="bytes"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns>A sprite</returns>
        public static Sprite CreateSprite(byte[] bytes, int width, int height)
        {
            Texture2D tex = new Texture2D(width, height);
            tex.LoadImage(bytes);
            return Sprite.Create(tex, new Rect(0, 0, width, height), new Vector2(width / 2, height / 2));
        }

        /// <summary>
        /// Renders an object loaded from an asset bundle.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <param name="layer"></param>
        public static void RenderObject<T>(this T obj, LayerMask layer) where T : Component
        {
            foreach (var c in obj.GetComponentsInChildren<Renderer>(true))
            {
                c.gameObject.layer = layer;

                // Why? I have no clue, but it works.
                c.material.shader = Shader.Find(c.material.shader.name);
            }
        }

        public static string BonePath(int start, int end)
        {
            string s = string.Empty;
            for (int i = start; i <= end; i++)
            {
                s += "Bone" + (i < 100 ? "0" + i.ToString() : i.ToString());
                s += "/";
            }
            return s.Substring(0, s.Length - 1);
        }
    }
}
