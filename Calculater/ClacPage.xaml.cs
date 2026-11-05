namespace Calculater;

public partial class ClacPage : ContentPage
{

	private int fnum;

	public ClacPage()
	{
		InitializeComponent();
	}


	private void ButtonDigit_Clicked(object sender, EventArgs e)
	{
		Button button = (Button)sender;
		fnum = int.Parse(button.Text);

        lblResult.Text += button.Text;
    }

	private void ButtonOperator_Clicked(object sender, EventArgs e)
	{
		Button button = (Button)sender;
		lblResult.Text += " " + button.Text + " ";
    }

	private void ButtonDelete_Clicked(object sender, EventArgs e)
	{
		lblResult.Text = string.Empty;
    }

	private void ButtonEqual_Clicked(object sender, EventArgs e)
	{
        
    }
}
