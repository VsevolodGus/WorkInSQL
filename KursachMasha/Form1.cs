using System.Windows.Forms;

namespace KursachMasha;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        DateTimePickerMatch.Format = DateTimePickerFormat.Custom;
        DateTimePickerMatch.CustomFormat = "MM.dd.yyyy hh:mm:ss";
    }
}
