
using System;

namespace VsCodeProOne.Patterns.AdapterPattern
{
    public class AudioPlayer : IMediaPlayer
    {
        public void Play(string audioType, string fileName)
        {
            if(audioType == "mp3")
            {
                Console.WriteLine("Playing mp3 file. Name: " + fileName);
            }
            else if(audioType == "vlc" || audioType == "mp4")
            {
                var mediaAdapter = new MediaAdapter(audioType);
                mediaAdapter.Play(audioType,fileName);
            }
            else
            {
                Console.WriteLine("Invalid media type!" + audioType 
                    + " type is not supported");
            }
        }
    }

}