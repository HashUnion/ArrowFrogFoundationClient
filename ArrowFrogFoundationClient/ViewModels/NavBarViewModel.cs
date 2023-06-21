using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace ArrowFrogFoundationClient.ViewModels;

public class NavBarViewModel : ReactiveObject
{
    [Reactive]
    public string? Color { get; set; } = "#000000";
}