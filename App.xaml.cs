namespace MauiControles;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		var pageNavigation = new NavigationPage(new GridPrincipal());

		//MainPage = new AppShell();

		MainPage = pageNavigation;

    }
}
