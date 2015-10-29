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
            // TODO
            //
            // XNB 仕様の説明に従って WAVEFORMATEX へデシリアライズさせているが、
            // WAVEFORMATEXTENSIBLE 未対応なのかどうかが不明。
            // WAVEFORMATEXTENSIBLE 未対応ならば、WAVEFORMATEX.cbSize は
            // 常に 0 であり、拡張データの読み込みは不要であろうが、
            // WAVEFORMATEXTENSIBLE 対応ならば拡張データのデシリアライズも必要であり、
            // WaveFormat 構造体へのバイト列コピーが失敗するかもしれない。

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

        protected override void Begin()
        {
            instance = new SoundEffect();
        }

        protected override object End()
        {
            return instance;
        }
    }
}
