namespace Kursach.Extensions;
internal static class TextBoxExtensions
{
    internal static bool ShowMessageBoxIfNoCorrect(this TextBox textBox, string messageBoxText)
    {
        if (!string.IsNullOrEmpty(textBox.Text))
            return true;

        MessageBox.Show(messageBoxText);
        return false;
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
