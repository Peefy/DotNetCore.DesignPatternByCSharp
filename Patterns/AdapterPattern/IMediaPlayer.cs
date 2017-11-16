
namespace VsCodeProOne.Patterns.AdapterPattern
{
    ///<summary>
    /// 适配器模式使得原本由于接口
    /// 不兼容而不能一起工作的那些类可以一起工作。
    ///</summary>
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