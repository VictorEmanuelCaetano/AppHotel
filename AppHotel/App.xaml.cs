namespace AppHotel
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // deixa o app sempre no tema claro
            UserAppTheme = AppTheme.Light;
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new NavigationPage(new Views.ContratacaoDaHopedagem()))
            {
                Width = 600,
                Height = 800,
                Title = "App Meu Hotel",
            };
        }
    }
}