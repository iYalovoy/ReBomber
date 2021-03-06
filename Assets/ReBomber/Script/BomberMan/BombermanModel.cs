﻿using UnityEngine.SocialPlatforms.Impl;

namespace Assets.Script
{
    public class BombermanModel
    {
        //Normal
        public int BombCount = 1;
        public int Radius = 1;
        public bool FlamePass;
        public bool Invincible;
        public bool RemoteControl;
        public float Speed = Constants.BasePlayerSpeed;
        public int Lifes = 2;
        public int Score;
        public bool WallPass;
        public bool BombPass;

        public void Godlike()
        {
            BombCount = 100;
            Radius = 100;
            FlamePass = true;
            Invincible = true;
            RemoteControl = true;
            Speed = 5f;
            WallPass = true;
            BombPass = true;
        }

        public void LosePower()
        {
            if (FlamePass)
                FlamePass = false;
            else if (RemoteControl)
                RemoteControl = false;
            else if (WallPass)
                WallPass = false;
            if (BombPass)
                BombPass = false;
        }

        public void Reset()
        {
            BombCount = 1;
            Radius = 1;
            FlamePass = false;
            Invincible = false;
            RemoteControl = false;
            WallPass = false;
            BombPass = false;
            Speed = Constants.BasePlayerSpeed;
        }

        public void Reload()
        {
            Lifes = 2;
            Score = 0;
        }
    }
}