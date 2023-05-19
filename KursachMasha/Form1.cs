namespace KursachMasha;

public partial class Form1 : Form
{
    private readonly LoginForm _loginForm;
    public Form1(LoginForm loginForm)
    {
        _loginForm = loginForm;

        InitializeComponent();
        DateTimePickerMatch.Format = DateTimePickerFormat.Custom;
        DateTimePickerMatch.CustomFormat = "MM.dd.yyyy hh:mm:ss";

        if (!Global.CurrentUser.IsAdmin)
        {
            var butttnos = this.Descendants<Button>().ToArray();
            foreach (var button in butttnos)
                button.Enabled = false;

            var textBoxs = this.Descendants<TextBox>().ToArray();
            foreach (var textBox in textBoxs)
                textBox.Enabled = false;
        }
    }

    private void logoutMenuStrip_Click(object sender, EventArgs e)
    {
        Global.CurrentUser = null;
        _loginForm.Show();
        this.Close();
    }
}
