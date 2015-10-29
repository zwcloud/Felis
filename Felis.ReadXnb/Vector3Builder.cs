﻿#region Using

using System;

#endregion

namespace Felis.Samples.ReadXnb
{
    public sealed class Vector3Builder : Vector3BuilderBase<Vector3>
    {
        Vector3 instance;

        protected override void SetValues(float x, float y, float z)
        {
            instance.X = x;
            instance.Y = y;
            instance.Z = z;
        }

        protected override void Begin()
        {
            instance = new Vector3();
        }

        protected override object End()
        {
            return instance;
        }
    }
}
