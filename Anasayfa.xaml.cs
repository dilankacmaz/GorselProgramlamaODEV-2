namespace TodoOdev;

public partial class Anasayfa : ContentPage
{
    int count = 0;

    public Anasayfa()
    {
        InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;

        if (count == 1)
            CounterBtn.Text = $"Clicked {count} time";
        else
            CounterBtn.Text = $"Clicked {count} times";

        SemanticScreenReader.Announce(CounterBtn.Text);
    }
   
        

        private async void GoToMainPage(object sender, EventArgs e)
        {
         
            await Navigation.PushAsync(new MainPage());
        }
    

}