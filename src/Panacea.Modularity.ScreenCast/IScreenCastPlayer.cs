using Panacea.Modularity.Media;

namespace Panacea.Modularity.ScreenCast
{
    public interface IScreenCastPlayer : IMediaPlayer
    {
        void Play(string url, string name);
        void SetVolume(float value);
    }
}