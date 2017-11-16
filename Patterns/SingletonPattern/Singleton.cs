namespace VsCodeProOne.Patterns.SingletonPattern
{
    public static class Singleton
    {
        public static void Test()
        {
            SingleObject.Instance.ShowMessage();
            ServiceLocator.Instance.ShowMessage();
        }
    }

}
