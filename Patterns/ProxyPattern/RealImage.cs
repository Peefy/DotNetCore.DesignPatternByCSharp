
using System;

namespace VsCodeProOne.Patterns.ProxyPattern
{
    public class RealImage : IImage
    {
        private string _fileName = "";

        public RealImage(string fileName)
        {
            this._fileName = fileName;
            LoadFromDisk(fileName);
        }

        public void Display()
        {
            Console.WriteLine("Display " + _fileName);
        }

        private void LoadFromDisk(string fileName)
        {
            Console.WriteLine("Loading " + fileName);
        }
    }

}
