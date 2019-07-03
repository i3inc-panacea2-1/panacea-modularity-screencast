using Panacea.Modularity.Media;

namespace Panacea.Modularity.ScreenCast
{
    public interface IScreenCastPlayer : IMediaPlayer
    {
        void Play(MediaItem media);
        void SetVolume(int value);
    }
}