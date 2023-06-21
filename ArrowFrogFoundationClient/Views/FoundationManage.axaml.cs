using ArrowFrogFoundationClient.ViewModels;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;

namespace ArrowFrogFoundationClient.Views;

public partial class FoundationManage : ReactiveUserControl<FoundationManageViewModel>
{
    public FoundationManage()
    {
        InitializeComponent();
        ViewModel = new FoundationManageViewModel();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}