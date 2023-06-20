using ArrowFrogFoundationClient.ViewModels;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace ArrowFrogFoundationClient.Controls;

public partial class FundSharesToken : UserControl
{
    public FundSharesToken()
    {
        InitializeComponent();
        DataContext = new FundSharesTokenViewModel();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}