using TutorialesMaui.Pages;

namespace TutorialesMaui;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
		
	}

	private async void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
        /*await Navigation.PushAsync(new Pagina2());*/
/*await Navigation.PopAsync();*/
/*await Navigation.PushModalAsync(new Pagina1()); */

FlyoutPageItem item = new FlyoutPageItem
{
    Title = "Ejemplo Paginas de Navegacion",
    IconSource="contacto.png"
};

/*await Navigation.PushModalAsync(new Pagina2(item));*/
await Navigation.PushAsync(new Pagina2
{
BindingContext = item  
});

}
}

