using Plugin.Maui.Audio;

namespace DogFacts;

public partial class App : Application
{
    private readonly IAudioManager audioManager;
    public App()
	{
		InitializeComponent();

		audioManager = new AudioManager();

		MainPage = new NavigationPage(new MainPage(audioManager));
	}
}
