namespace MauiControles;

public partial class GridPrincipal : ContentPage
{
	public GridPrincipal()
	{
		InitializeComponent();
	}

    private  void btn_1_Clicked(object sender, EventArgs e)
    {
         
    }

    private void btn_FormasGeometricas_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new FormasGeometricas());
    }

    private void btn_FormsControls_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new FormControlsDemo());
    }
}