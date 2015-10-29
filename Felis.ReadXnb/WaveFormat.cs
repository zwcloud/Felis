#region Using

using System;

#endregion

namespace Felis.Samples.ReadXnb
{
    /// <summary>
    /// WAVEFORMATEX 構造体。
    /// </summary>
    public struct WaveFormat
    {
        /// <summary>
        /// WORD  wFormatTag
        /// </summary>
        public ushort FormatTag;

        /// <summary>
        /// WORD  nChannels
        /// </summary>
        public ushort Channels;

        /// <summary>
        /// DWORD nSamplesPerSec
        /// </summary>
        public uint SamplesPerSec;

        /// <summary>
        /// DWORD nAvgBytesPerSec
        /// </summary>
        public uint AvgBytesPerSec;

        /// <summary>
        /// WORD  nBlockAlign
        /// </summary>
        public ushort BlockAlign;

        /// <summary>
        /// WORD  wBitsPerSample
        /// </summary>
        public ushort BitsPerSample;

        /// <summary>
        /// WORD  cbSize
        /// </summary>
        public ushort Size;
    }
}
