using Plugin.Maui.Audio;
using DogFacts.ViewModel;
using System.Net.Http.Json;
using DogFacts.Model;

namespace DogFacts;

public partial class MainPage : ContentPage
{
    private readonly IAudioManager audioManager;

    public MainPage(IAudioManager audioManager)
	{
		InitializeComponent();
        this.audioManager = audioManager;
	}

    private async void ImageButton_Clicked(object sender, EventArgs e)
    {
        var player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("dog_barking_1.wav"));
        player.Play();
    }

    private async void ImageButton_Clicked_1(object sender, EventArgs e)
    {
        var player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("dog_barking_2.wav"));
        player.Play();
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        var client = new HttpClient();
        client.BaseAddress = new Uri("https://dog-api.kinduff.com");
        var response = await client.GetFromJsonAsync<Facts>("/api/facts");
        model.Fact = response.Fact[0];
        int n = new Random().Next(1, 21);
        bigImg.Source = $"a{n}.png";
    }
}

