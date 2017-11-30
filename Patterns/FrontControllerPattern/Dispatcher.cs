
using System;

namespace VsCodeProOne.Patterns.FrontControllerPattern
{
    public class Dispatcher
    {
        StudentView studentView;
        HomeView homeView;

        public Dispatcher()
        {
            studentView = new StudentView();
            homeView = new HomeView();
        }

        public void Dispatch(string request)
        {
            if(string.Equals(request, "Student", 
                StringComparison.OrdinalIgnoreCase))
            {
                studentView.Show();
            }
            else
                homeView.Show();
        }

    }    

}
