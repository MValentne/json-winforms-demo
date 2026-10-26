namespace ConsignaBase;

/// <summary>
/// Cambiá esta clase por la de tu tema: películas, inventario, tareas, libros.
/// Necesita al menos 3 propiedades públicas; son las que se guardan en el JSON.
/// </summary>
public class Elemento
{
    public string Nombre { get; set; } = "";

    public string Categoria { get; set; } = "";

    public int Cantidad { get; set; }
}
