using System.Diagnostics;

namespace MauiControles;

public partial class FormControlsDemo : ContentPage
{
	public FormControlsDemo()
	{
		InitializeComponent();
	}

    private void btntest_Clicked(object sender, EventArgs e)
    {
		DisplayAlert(" Atenção "," clicou "," Certo ");
    }

    private void RadioButton_CheckedChanged(object sender,
        CheckedChangedEventArgs e)
    {

        if (e.Value)
        {
            var rb =  (RadioButton)sender;

            DisplayAlert(" Atenção ", $" clicou {rb.Content} ", " Certo ");
        }

    }

    private void searchControl_SearchButtonPressed(object sender, EventArgs e)
    {
        DisplayAlert(" Atenção ", $" clicou {searchControl.Text} ", " Certo ");
    }

    private void SwipeItem_Invoked(object sender, EventArgs e)
    {
        DisplayAlert(" Atenção ", $" Swipe Tap ", " Certo ");
    }

    private void slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        // DisplayAlert(" Atenção ", $" valor de slider {slider.Value.ToString()} ", " Certo ");
        lblslider.Text = slider.Value.ToString();
    }

    private void stepper_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        if (stepper != null)
            lblStepper.Text = stepper.Value.ToString();
    }

    private void Entry_TextChanged(object sender, TextChangedEventArgs e)
    {
        Debug.WriteLine("change "+txtEntry.Text);
    }

    private void txtEntry_Completed(object sender, EventArgs e)
    {
        Debug.WriteLine("complete "+txtEntry.Text);

    }
}