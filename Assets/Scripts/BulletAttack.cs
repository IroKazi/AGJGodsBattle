﻿using UnityEngine;
public class BulletAttack : AttackAnimation
{
    //public Vector3 ForceDirection;
    public float Force = 5000f;

    public override void FinalAnimation()
    {
        base.FinalAnimation();
        populationManager.SetForceAll(this.transform.up, Force);
    }
    //private void OnValidate()
    //{
    //    ForceDirection.Normalize();
    //}
}