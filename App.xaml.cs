using JPEDRAZAT3.LOGIN;

namespace JPEDRAZAT3
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new LOGINPAGE());
        }
    }
}
