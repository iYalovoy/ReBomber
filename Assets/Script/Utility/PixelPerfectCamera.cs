﻿using UnityEngine;

namespace Assets.Script
{
    [ExecuteInEditMode]
    public class PixelPerfectCamera : MonoBehaviour
    {
        public float PixelsPerUnit;

        void Start()
        {

        }

        void Update()
        {

        }

        void FixedUpdate()
        {
            camera.orthographicSize = (Screen.height / PixelsPerUnit / 2f);
        }
    }
}
