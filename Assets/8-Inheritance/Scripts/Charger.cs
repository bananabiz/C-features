﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Inheritance
{
    public class Charger : Enemy
    {
        [Header("Charger")]
        public float impactForce = 10f;
        public float knockBack = 10f;

        public override void Attack()
        {
            base.Attack();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}