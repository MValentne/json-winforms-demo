using System.ComponentModel;
using System.Text.Encodings.Web;
using System.Text.Json;

namespace AgendaJson;

public partial class AgendaForm : Form
{
    // BindingList avisa a la grilla cada vez que la lista cambia:
    // no hay que refrescar el DataGridView a mano.
    private readonly BindingList<Contacto> _contactos = new();

    private static readonly JsonSerializerOptions OpcionesJson = new()
    {
        // Un archivo con saltos de línea e indentación se puede leer y editar a mano.
        WriteIndented = true,
        // Sin esto, los acentos y la ñ se guardan como \u00F1 y nadie entiende nada.
        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
    };

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

    private void btnGuardar_Click(object sender, EventArgs e)
    {
        // Serializar: la lista de objetos se convierte en texto.
        string json = JsonSerializer.Serialize(_contactos.ToList(), OpcionesJson);
        File.WriteAllText(ArchivoJson, json);

        MostrarEstado($"Guardado en {Path.GetFullPath(ArchivoJson)} ({_contactos.Count} contactos).");
    }

    private void btnCargar_Click(object sender, EventArgs e)
    {
        if (!File.Exists(ArchivoJson))
        {
            MostrarEstado($"No hay ningún {ArchivoJson} en esta carpeta. Guardá primero.", esError: true);
            return;
        }

        // Deserializar: el texto vuelve a ser una lista de objetos.
        string json = File.ReadAllText(ArchivoJson);
        List<Contacto>? cargados = JsonSerializer.Deserialize<List<Contacto>>(json, OpcionesJson);

        // Se reemplaza lo que había en la grilla: el archivo manda.
        _contactos.Clear();
        foreach (Contacto contacto in cargados ?? [])
        {
            _contactos.Add(contacto);
        }

        MostrarEstado($"Cargados {_contactos.Count} contactos desde {Path.GetFullPath(ArchivoJson)}.");
    }

    private void MostrarEstado(string mensaje, bool esError = false)
    {
        lblEstado.Text = mensaje;
        lblEstado.ForeColor = esError ? Color.Firebrick : Color.FromArgb(96, 96, 96);
    }
}
