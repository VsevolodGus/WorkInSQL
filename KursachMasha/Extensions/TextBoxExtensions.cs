namespace KursachMasha.Extensions;
internal static class TextBoxExtensions
{
    internal static void ShowMessageBoxIfTextEmpty(this TextBox textBox, string messageBoxText)
    {
        if (string.IsNullOrEmpty(textBox.Text))
            MessageBox.Show(messageBoxText);
    }
}
