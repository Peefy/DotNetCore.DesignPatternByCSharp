
using System;

namespace VsCodeProOne.Patterns.AdapterPattern
{
    public class VlcPlayer : IAdvancedMediaPlayer
    {
        public void PlayMp4(string fileName)
        {
            Console.WriteLine($"Playing vlc file. Name: {fileName}")
        }

        public void PlayVlc(string fileName)
        {
            
            
        }
    }

}