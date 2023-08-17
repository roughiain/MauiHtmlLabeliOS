namespace MauiHtmlLabelPlatformSpike;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
        Label label = new Label
        {
            Text = "This is <strong style=\"color:red\">HTML</strong> text. from c#",
            TextType = TextType.Html
        };
		TheVerticalStackLayout.Children.Add(label);
    }

}


