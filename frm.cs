using System.Windows.Forms;

public class frm : Form
{
	public static int Main(string[] args)
	{
		frm frmApp = new frm();

		Application.Run(frmApp);

		return 0;
	}

	public frm()
	{
		this.Text = "Hello";
	}
}

