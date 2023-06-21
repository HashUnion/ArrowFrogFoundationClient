using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace ArrowFrogFoundationClient.Views
{
    public partial class NavBarItem : ContentControl
    {
        public NavBarItem()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}