using System.ComponentModel;

namespace AgendaJson;

public partial class AgendaForm : Form
{
    // BindingList avisa a la grilla cada vez que la lista cambia:
    // no hay que refrescar el DataGridView a mano.
    private readonly BindingList<Contacto> _contactos = new();

    public AgendaForm()
    {
        InitializeComponent();

        gridContactos.DataSource = _contactos;
        lblRuta.Text = "Los datos se guardan en: " + Path.Combine(AppContext.BaseDirectory, ArchivoJson);
    }

    private const string ArchivoJson = "contactos.json";

    private void btnAgregar_Click(object sender, EventArgs e)
    {
        string nombre = txtNombre.Text.Trim();
        string telefono = txtTelefono.Text.Trim();

        if (nombre.Length == 0)
        {
            MostrarEstado("Escribí un nombre antes de agregar.", esError: true);
            txtNombre.Focus();
            return;
        }

        _contactos.Add(new Contacto { Nombre = nombre, Telefono = telefono });

        txtNombre.Clear();
        txtTelefono.Clear();
        txtNombre.Focus();
        MostrarEstado($"{_contactos.Count} contacto(s) en la agenda.");
    }

    private void MostrarEstado(string mensaje, bool esError = false)
    {
        lblEstado.Text = mensaje;
        lblEstado.ForeColor = esError ? Color.Firebrick : Color.FromArgb(96, 96, 96);
    }
}
