namespace Calculater;

public partial class ClacPage : ContentPage
{
    private int firstNum;
	private int secondNum;
    private char equal = ' ';
    private int digit;
	private double result;
	private bool isFinished= false;
	



    public ClacPage()
	{
		InitializeComponent();
	}


	private void ButtonDigit_Clicked(object sender, EventArgs e)
	{
		Button button = (Button)sender;

		if (isFinished) 
		{ 
			lblResult.Text = string.Empty;
            firstNum = 0;
            secondNum = 0;
            result = 0;
            equal = ' ';
			isFinished = false;

        }
		if (equal == ' ')
		{
			firstNum = firstNum*10 + int.Parse(button.Text);
		}
		else
		{
			secondNum = secondNum*10 + int.Parse(button.Text);
		}
			

        lblResult.Text += button.Text;

    }

	private void ButtonOperator_Clicked(object sender, EventArgs e)
	{
		Button button = (Button)sender;
		equal = button.Text[0];
		lblResult.Text += " " + button.Text + " ";
    }

	private void ButtonDelete_Clicked(object sender, EventArgs e)
	{
		lblResult.Text = string.Empty;
		firstNum = 0;
		secondNum = 0;
		result=0;
		equal = ' ';
    }

	private void ButtonEqual_Clicked(object sender, EventArgs e)
	{
		

		if (equal == '+')
		{
            result= firstNum + secondNum;

        }
        else if (equal == '-')
		{
			result= firstNum - secondNum;
		}
        else if (equal == '*')
		{
			result= firstNum * secondNum;
		}
        else if (equal == '/')
		{
			result= firstNum / secondNum;
		}

		lblResult.Text += " = " + result.ToString();
		isFinished = true;

    }



}


