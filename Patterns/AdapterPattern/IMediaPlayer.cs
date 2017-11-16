
namespace VsCodeProOne.Patterns.AdapterPattern
{
    public interface IMediaPlayer
    {
        void Play(string audioType,string fileName);
    }

    public interface IAdvancedMediaPlayer
    {
        void PlayVlc(string fileName);
        void PlayMp4(string fileName);
    }

}