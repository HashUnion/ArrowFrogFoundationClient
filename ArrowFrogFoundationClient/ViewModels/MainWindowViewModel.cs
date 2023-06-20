using ReactiveUI;

namespace ArrowFrogFoundationClient.ViewModels;

public class MainWindowViewModel : ReactiveObject
{
    string text = "Click Me!";

    public string Text
    {
        get => text;
        set
        {
            this.RaiseAndSetIfChanged(ref text, value);
            this.RaisePropertyChanged("SpacerEnabled");
        }
    }

    public void ButtonClicked() => Text = "Hello, Avalonia!";
}