﻿namespace TowerDefenseGame.Models.Debuffs
{
    public class FreezeDebuff : Debuff
    {
        private const int DebuffDuration = 50;
        private const double DebuffLifePointsEffect = 0;
        private const double DebuffSpeedEffect = 1;

        public FreezeDebuff()
            : base(DebuffDuration, DebuffLifePointsEffect, DebuffSpeedEffect)
        {
        }
    }
}
