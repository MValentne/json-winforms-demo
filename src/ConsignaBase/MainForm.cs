using System.ComponentModel;
using System.Text.Encodings.Web;
using System.Text.Json;

namespace ConsignaBase;

public partial class MainForm : Form
{
    private readonly BindingList<Elemento> _elementos = new();

    private static readonly JsonSerializerOptions OpcionesJson = new()
    {
        WriteIndented = true,
        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
    };

    public MainForm()
    {
        InitializeComponent();
        gridElementos.DataSource = _elementos;
    }

    private void btnAgregar_Click(object sender, EventArgs e)
    {
        // TODO 1: validar los campos, crear un Elemento y agregarlo a _elementos.
        // Ayuda: int.TryParse(txtCantidad.Text, out int cantidad) dice si el número está bien.
        // La grilla se actualiza sola porque está enlazada a la BindingList.
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
        // TODO 2: serializar la lista y escribirla en "datos.json".
        // Ayuda: JsonSerializer.Serialize(_elementos.ToList(), OpcionesJson) + File.WriteAllText.
    }

    private void btnCargar_Click(object sender, EventArgs e)
    {
        // TODO 3: leer "datos.json", deserializar y reemplazar el contenido de _elementos.
        // Ayuda: JsonSerializer.Deserialize<List<Elemento>>(json, OpcionesJson) puede devolver null.
        // Revisar File.Exists antes y envolver en try/catch (JsonException, IOException).
    }
}
