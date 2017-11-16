
using System;

namespace VsCodeProOne.Patterns.AdapterPattern
{
    public class VlcPlayer : IAdvancedMediaPlayer
    {
        public void PlayMp4(string fileName)
        {
            
        }

        public void PlayVlc(string fileName)
        {
            Console.WriteLine($"Playing vlc file. Name: {fileName}");
        }
    }

    public class Mp4Player : IAdvancedMediaPlayer
    {
        public void PlayMp4(string fileName)
        {
            Console.WriteLine($"Playing mp4 file. Name: {fileName}");
        }

        public void PlayVlc(string fileName)
        {
            
        }
    }

}