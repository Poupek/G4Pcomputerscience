﻿using System;
using System.Collections.Generic;

namespace G4Pcs
{
    class Bone : Object
    {
        public static List<Bone> boneList = new List<Bone>();

        private double length;
        private Joint joint1, joint2;
        public Bone(double mass, Joint joint1, Joint joint2) : base(mass)
        {
            this.joint1 = joint1;
            this.joint2 = joint2;
            length = Math.Sqrt(Math.Pow(joint1.getPosition().X-joint2.getPosition().X, 2)+ Math.Pow(joint1.getPosition().Y - joint2.getPosition().Y, 2));
        }

        public void updateLength()
        {
            length = Math.Sqrt(Math.Pow(joint1.getPosition().X - joint2.getPosition().X, 2) + Math.Pow(joint1.getPosition().Y - joint2.getPosition().Y, 2));
        }

        public Joint getJoint1() => joint1;
        public Joint getJoint2() => joint2;
        public double getLength() => length;
    }
}
