namespace MonkeyFinder.ViewModel;

[QueryProperty("Monkey", "Monkey")]
public partial class MonkeyDetailsViewModel : BaseViewModel
{
    [ObservableProperty]
    private Monkey monkey;

    public MonkeyDetailsViewModel(Monkey monkey) => this.monkey = monkey;
}
