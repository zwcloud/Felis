#region Using

using System;

#endregion

namespace Felis.Samples.ReadXnb
{
    public sealed class RectangleBuilder : RectangleBuilderBase<Rectangle>
    {
        Rectangle instance;

        protected override void SetValues(int x, int y, int width, int height)
        {
            instance.X = x;
            instance.Y = y;
            instance.Width = width;
            instance.Height = height;
        }

        protected override void Begin()
        {
            instance = new Rectangle();
        }

        protected override object End()
        {
            return instance;
        }
    }
}
