using System.Diagnostics;

namespace PresentacionCliente
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new AppShell();
        }

    }
}
