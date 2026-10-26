namespace AgendaJson;

/// <summary>
/// Un contacto de la agenda.
/// Las propiedades públicas son las que System.Text.Json escribe y lee del archivo.
/// </summary>
public class Contacto
{
    public string Nombre { get; set; } = "";

    public string Telefono { get; set; } = "";
}
