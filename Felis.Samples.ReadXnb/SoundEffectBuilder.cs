#region Using

using System;
using System.Runtime.InteropServices;

#endregion

namespace Felis.Samples.ReadXnb
{
    public sealed class SoundEffectBuilder : SoundEffectBuilderBase<SoundEffect>
    {
        SoundEffect instance;

        protected override void SetFormatSize(uint value) { }

        protected override void SetFormat(byte[] values)
        {
            var gcHandle = GCHandle.Alloc(values, GCHandleType.Pinned);
            var pointer = gcHandle.AddrOfPinnedObject();

            instance.WaveFormat = (WaveFormat) Marshal.PtrToStructure(pointer, typeof(WaveFormat));

            gcHandle.Free();
        }

        protected override void SetDataSize(uint value) { }

        protected override void SetData(byte[] values)
        {
            instance.WaveData = values;
        }

        protected override void SetLoopStart(int value)
        {
            instance.LoopStart = value;
        }

        protected override void SetLoopLength(int value)
        {
            instance.LoopLength = value;
        }

        protected override void SetDuration(int value)
        {
            instance.Duration = value;
        }

        protected override void Begin(object deviceContext)
        {
            instance = new SoundEffect();
        }

        protected override object End()
        {
            return instance;
        }
    }
}
