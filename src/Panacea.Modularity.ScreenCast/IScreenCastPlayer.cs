using Panacea.Modularity.Media;
using System;

namespace Panacea.Modularity.ScreenCast
{
    public interface IScreenCastPlayer : IMediaPlayer
    {
        void SetVolume(int value);

        int Volume { get; }

        event EventHandler VolumeChanged;
    }
}