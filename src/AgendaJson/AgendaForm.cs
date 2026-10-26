namespace AgendaJson;

public partial class AgendaForm : Form
{
    public AgendaForm()
    {
        Text = "Agenda de contactos";
        ClientSize = new Size(776, 520);
        StartPosition = FormStartPosition.CenterScreen;
        MinimumSize = new Size(700, 480);
    }
}
