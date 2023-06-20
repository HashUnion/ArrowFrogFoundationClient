using ArrowFrogFoundationClient.ViewModels;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Notifications;
using Avalonia.Controls.Primitives;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace ArrowFrogFoundationClient
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        protected override void OnApplyTemplate(TemplateAppliedEventArgs e)
        {
            Global.NotificationManager ??= new WindowNotificationManager(this);
            base.OnApplyTemplate(e);
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
            DataContext = new MainWindowViewModel();
        }

        public void Click(object sender, RoutedEventArgs e)
        {
            var notif = new Avalonia.Controls.Notifications.Notification("title", "message");
            Global.NotificationManager!.Show(notif);
        }
    }
}