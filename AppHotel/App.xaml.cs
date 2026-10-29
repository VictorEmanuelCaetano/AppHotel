using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Animations;

namespace AppHotel
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell())
            {
                Width = 600,
                Height = 800,
                Title = "App Meu Hotel",
            };
        }
    }
}