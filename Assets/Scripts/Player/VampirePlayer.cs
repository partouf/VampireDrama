﻿namespace VampireDrama
{
    using UnityEngine;

    public class VampirePlayer : MovingAnimation
    {
        public string Name;
        private float lastInput;

        public int Experience;
        public int Hunger;

        private SpriteRenderer playerRenderer;

        protected override void Start()
        {
            base.Start();
            playerRenderer = GetComponent<SpriteRenderer>();

            lastInput = Time.time;
        }

        public override void Update()
		{
            base.Update();
            if (isMoving) return;

            var timeNow = Time.time;
            if (timeNow - lastInput < 0.2f) return;

            if (Input.GetButtonDown("Fire1"))
            {
                // do something
            }

            int hor = (int)Input.GetAxisRaw("Horizontal");
            int ver = (int)Input.GetAxisRaw("Vertical");

            RaycastHit2D hit;
            bool hitSomething = false;

            if ((ver == 0) && (hor != 0))
            {
                hitSomething = !Move(hor, ver, out hit);
                lastInput = timeNow;
            }
            else if ((hor == 0) && (ver != 0))
            {
                hitSomething = !Move(hor, ver, out hit);
                lastInput = timeNow;
            }

            if (hitSomething)
            {
                // now what?
            }
        }
    }
}
