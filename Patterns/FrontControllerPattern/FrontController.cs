
using System;

namespace VsCodeProOne.Patterns.FrontControllerPattern
{
    public class FrontController
    {
        Dispatcher dispatcher;

        public FrontController()
        {
            dispatcher = new Dispatcher();
        }

        private bool IsAuthenticUser()
        {
            Console.WriteLine("User is authenticated successfully.");
            return true;
        }

        public void TrackRequest(string request)
        {
            Console.WriteLine("Page requested: " + request);
        }

        public void DispatchRequest(string request)
        {
            TrackRequest(request);
            if(IsAuthenticUser())
            {
                dispatcher.Dispatch(request);
            }
        }

    }

}
