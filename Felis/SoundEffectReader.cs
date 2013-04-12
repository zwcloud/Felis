#region Using

using System;

#endregion

namespace Felis
{
    public sealed class SoundEffectReader : TypeReader
    {
        SoundEffectBuilderBase builder;

        public override string TargetType
        {
            get { return "Microsoft.Xna.Framework.Audio.SoundEffect"; }
        }

        public override string ReaderName
        {
            get { return "Microsoft.Xna.Framework.Content.SoundEffectReader"; }
        }

        protected internal override void Initialize(TypeReaderManager manager)
        {
            builder = manager.GetTypeBuilderByTargetType(TargetType) as SoundEffectBuilderBase;

            base.Initialize(manager);
        }

        protected internal override object Read(ContentReader input)
        {
            builder.Begin(input.DeviceContext);

            // Format size
            var formatSize = input.ReadUInt32();
            builder.SetFormatSize(formatSize);

            // Format
            builder.SetFormat(input.ReadBytes((int) formatSize));

            // Data size
            var dataSize = input.ReadUInt32();
            builder.SetDataSize(dataSize);

            // Data
            builder.SetData(input.ReadBytes((int) dataSize));

            // Loop start
            builder.SetLoopStart(input.ReadInt32());

            // Loop length
            builder.SetLoopLength(input.ReadInt32());

            // Duration
            builder.SetDuration(input.ReadInt32());

            return builder.End();
        }
    }
}
