namespace KursachMasha.Extensions;
internal static class TextBoxExtensions
{
    internal static void ShowMessageBoxIfTextEmpty(this TextBox textBox, string messageBoxText)
    {
        if (string.IsNullOrEmpty(textBox.Text))
            MessageBox.Show(messageBoxText);
    }

    internal static void OnlyDigits_TextBoxChange(KeyPressEventArgs e)
    {
        if (!char.IsDigit(e.KeyChar)
                && e.KeyChar != (char)Keys.Back
                && e.KeyChar != (char)Keys.Delete)
        {
            e.Handled = true;
        }
    }
}
