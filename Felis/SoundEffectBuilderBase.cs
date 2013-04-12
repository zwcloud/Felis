#region Using

using System;

#endregion

namespace Felis
{
    public abstract class SoundEffectBuilderBase : TypeBuilder
    {
        public override string TargetType
        {
            get { return "Microsoft.Xna.Framework.Audio.SoundEffect"; }
        }

        protected SoundEffectBuilderBase() { }

        protected abstract internal void SetFormatSize(uint value);

        protected abstract internal void SetFormat(byte[] values);

        protected abstract internal void SetDataSize(uint value);

        protected abstract internal void SetData(byte[] values);

        protected abstract internal void SetLoopStart(int value);

        protected abstract internal void SetLoopLength(int value);

        protected abstract internal void SetDuration(int value);
    }

    public abstract class SoundEffectBuilderBase<T> : SoundEffectBuilderBase
    {
        public override Type ActualType
        {
            get { return typeof(T); }
        }

        protected SoundEffectBuilderBase() { }
    }
}
