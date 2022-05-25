namespace MonkeyFinder.Services;

public record MonkeyService(HttpClient HttpClient)
{
    private List<Monkey> monkeyList = new();

    public async Task<List<Monkey>> GetMonkeysAsync()
    {
        if (monkeyList.Count > 0)
        {
            return monkeyList;
        }

        var response = await HttpClient.GetAsync("https://montemagno.com/monkeys.json");

        if (response.IsSuccessStatusCode)
        {
            monkeyList = await response.Content.ReadFromJsonAsync<List<Monkey>>();
        }

        return monkeyList;
    }
}
