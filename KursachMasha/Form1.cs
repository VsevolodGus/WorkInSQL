using KursachMasha.DAL.Players;

namespace KursachMasha;

public partial class Form1 : Form
{
    private readonly LoginForm _loginForm;
    private readonly PlayerRepository _playerRepository;
    public Form1(LoginForm loginForm)
    {
        _loginForm = loginForm;

        _playerRepository = new PlayerRepository();
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
        this.tabPage2.Select();
    }

    private void logoutMenuStrip_Click(object sender, EventArgs e)
    {
        Global.CurrentUser = null;
        _loginForm.Show();
        this.Close();
    }
}
