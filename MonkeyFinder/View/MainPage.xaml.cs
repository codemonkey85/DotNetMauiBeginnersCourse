namespace MonkeyFinder.View;

public partial class MainPage : ContentPage
{
    public MainPage(MonkeysViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        if (BindingContext is MonkeysViewModel viewModel)
        {
            viewModel.IsRefreshing = true;
        }
    }
}
