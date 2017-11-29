namespace VsCodeProOne.Patterns.TemplatePattern
{
    public abstract class Game
    {
        public abstract void Initialize();
        public abstract void StartPlay();
        public abstract void EndPlay();

        public virtual void Play()
        {
            Initialize();
            StartPlay();
            EndPlay();
        }

    }

}
