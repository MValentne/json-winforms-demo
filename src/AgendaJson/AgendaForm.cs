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
        try
        {
            string nombre = txtNombre.Text.Trim();
            string telefono = txtTelefono.Text.Trim();

            if (nombre.Length == 0 || telefono.Length == 0)
            {
                MostrarEstado("Escribí un nombre y un teléfono antes de agregar.", esError: true);
                txtNombre.Focus();
                return;
            }

            _contactos.Add(new Contacto { Nombre = nombre, Telefono = telefono });

            txtNombre.Clear();
            txtTelefono.Clear();
            txtNombre.Focus();
            MostrarEstado($"{_contactos.Count} contacto(s) en la agenda.");
        }
        catch (Exception ex)
        {
            MostrarEstado($"Error al agregar contacto: {ex.Message}", esError: true);
        }
    }


    private void btnGuardar_Click(object sender, EventArgs e)
    {
        try
        {
            if (_contactos.Count == 0)
            {
                MostrarEstado("No hay contactos para guardar.", esError: true);
                return;
            }
            // Serializar: la lista de objetos se convierte en texto.
            string json = JsonSerializer.Serialize(_contactos.ToList(), OpcionesJson);
            File.WriteAllText(ArchivoJson, json);

            MostrarEstado($"Guardado en {Path.GetFullPath(ArchivoJson)} ({_contactos.Count} contactos).");
        }
        catch (Exception ex) when (ex is IOException or UnauthorizedAccessException)
        {
            MostrarEstado($"No se pudo escribir el archivo: {ex.Message}", esError: true);
        }
    }

    private void btnCargar_Click(object sender, EventArgs e)
    {
        if (!File.Exists(ArchivoJson))
        {
            MostrarEstado($"No hay ningún {ArchivoJson} en esta carpeta. Guardá primero.", esError: true);
            return;
        }


        try
        {
            
            string json = File.ReadAllText(ArchivoJson);
            if (json == "[]")
            {
                MostrarEstado($"El archivo {ArchivoJson} está vacío. Guardá primero.", esError: true);
                return;
            }
            List<Contacto>? cargados = JsonSerializer.Deserialize<List<Contacto>>(json, OpcionesJson);
            


            _contactos.Clear();
            foreach (Contacto contacto in cargados ?? [])
            {
                _contactos.Add(contacto);
            }

            MostrarEstado($"Cargados {_contactos.Count} contactos desde {Path.GetFullPath(ArchivoJson)}.");
        }
        catch (JsonException ex)
        {
            // JsonException trae la línea donde se rompió: sirve para corregir el archivo.
            long linea = (ex.LineNumber ?? 0) + 1;
            MostrarEstado($"El archivo no es un JSON válido (línea {linea}). {ex.Message}", esError: true);
        }
        catch (Exception ex) when (ex is IOException or UnauthorizedAccessException)
        {
            MostrarEstado($"No se pudo leer el archivo: {ex.Message}", esError: true);
        }
    }

    private void MostrarEstado(string mensaje, bool esError = false)
    {
        lblEstado.Text = mensaje;
        lblEstado.ForeColor = esError ? Color.Firebrick : Color.FromArgb(96, 96, 96);
    }

    private void btn_BorrarElemento_Click(object sender, EventArgs e)
    {
        try
        {
            if (gridContactos.SelectedRows.Count == 0)
            {
                MostrarEstado("No hay ningún contacto seleccionado para borrar.", esError: true);
                return;
            }
            DataGridViewSelectedRowCollection filasSeleccionadas = gridContactos.SelectedRows;
            foreach (DataGridViewRow fila in filasSeleccionadas)
            {
                _contactos.RemoveAt(fila.Index);
            }
            string json = JsonSerializer.Serialize(_contactos.ToList(), OpcionesJson);
            File.WriteAllText(ArchivoJson, json);
            MostrarEstado($"{_contactos.Count} contacto(s) en la agenda.");

        }
        catch (Exception ex) when (ex is IOException or UnauthorizedAccessException)
        {
            MostrarEstado($"No se pudo escribir el archivo: {ex.Message}", esError: true);
        }
    }
}
