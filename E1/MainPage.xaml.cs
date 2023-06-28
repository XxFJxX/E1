namespace E1;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        int nume1 = Convert.ToInt32(num1.Text);
        int nume2 = Convert.ToInt32(num2.Text);
        int nume3 = Convert.ToInt32(num3.Text);
        int nume4 = Convert.ToInt32(num4.Text);


        num1.Text = Convert.ToString(nume4);
        num2.Text = Convert.ToString(nume3);
        num3.Text = Convert.ToString(nume2);
        num4.Text = Convert.ToString(nume1);
    }
}

