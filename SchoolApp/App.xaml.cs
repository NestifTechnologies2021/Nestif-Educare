using SchoolApp.Models;

namespace SchoolApp
{
    public partial class App : Application
    {
        public static UserInfo? UserInfo;
        public App()
        {
            InitializeComponent();
            MainPage = new AppShell();
        }

        //protected override Window CreateWindow(IActivationState? activationState)
        //{
        //    return new Window(new AppShell());
        //}
        protected override Window CreateWindow(IActivationState activationState)
        {
            // Workaround for: 'Either set MainPage or override CreateWindow.'??
            if (this.MainPage == null)
            {
                this.MainPage = new MainPage();
            }

            return base.CreateWindow(activationState);
        }
    }
}