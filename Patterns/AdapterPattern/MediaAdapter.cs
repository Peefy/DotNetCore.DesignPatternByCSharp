
using System;

namespace VsCodeProOne.Patterns.AdapterPattern
{
    public class MediaAdapter : IMediaPlayer
    {

        IAdvancedMediaPlayer _advanceMediaPlayer;

        public MediaAdapter(string audioType)
        {          
            switch(audioType)
            {
                case "vlc": 
                    _advanceMediaPlayer = new VlcPlayer();
                    break;
                case "mp4": 
                    _advanceMediaPlayer = new Mp4Player();
                    break;
                default :
                    throw new Exception(audioType + "is not find");
            }
        }

        public void Play(string audioType, string fileName)
        {
            if(string.IsNullOrEmpty(audioType) 
                && string.IsNullOrEmpty(fileName))
            {
                throw new ArgumentNullException();
            }
            if(_advanceMediaPlayer == null)
                throw new ArgumentNullException();
            switch(audioType)
            {
                case "vlc": 
                    _advanceMediaPlayer.PlayVlc(fileName);
                    break;
                case "mp4": 
                    _advanceMediaPlayer.PlayMp4(fileName);
                    break;
                default :
                    throw new Exception(audioType + "is not find");
            }
        }
    }

}