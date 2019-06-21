using Panacea.Modularity.Media;

namespace Panacea.Modularity.ScreenCast
{
    public interface IScreenCastPlayer : IMediaPlayer
    {
        void Play(string url, MediaItem media);
        void SetVolume(float value);
    }
}