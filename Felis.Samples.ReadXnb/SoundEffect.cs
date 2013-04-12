#region Using

using System;

#endregion

namespace Felis.Samples.ReadXnb
{
    public sealed class SoundEffect
    {
        public WaveFormat WaveFormat;

        public byte[] WaveData;

        public int LoopStart;

        public int LoopLength;

        public int Duration;
    }
}
