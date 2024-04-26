using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media;
using Task_4_3.ViewModels;

namespace Task_4_3.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();
    }

    public void ClickHandler(object sender, RoutedEventArgs args)
    {
        message.Text = "Liked!";
    }
}
