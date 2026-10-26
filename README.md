# json-winforms-demo

Aplicación de agenda en WinForms para la clase de **JSON con C#**: cargar un archivo, mostrarlo en una grilla y volver a guardarlo.

El repositorio tiene dos proyectos:

| Proyecto | Para qué |
| --- | --- |
| `src/AgendaJson` | Demo terminada. Es la que se muestra en clase paso a paso. |
| `src/ConsignaBase` | Proyecto base con la interfaz armada y la lógica sin hacer, para la consigna. |

## Requisitos

- .NET 8 SDK
- Visual Studio 2022 con la carga de trabajo **Desarrollo de escritorio de .NET**
- Windows (WinForms no corre en Linux ni macOS)

No hay paquetes que instalar: `System.Text.Json` viene con .NET.

## Cómo abrir la demo

```bash
git clone https://github.com/MValentne/json-winforms-demo.git
cd json-winforms-demo
start src\AgendaJson\AgendaJson.csproj
```

O abrir `json-winforms-demo.sln` en Visual Studio y ejecutar con `F5`.

La aplicación guarda `contactos.json` en la carpeta de salida del ejecutable. La ruta completa se muestra debajo del título de la ventana, así que no hay que buscarla.

## Paso a paso de la demo

Cada paso de la clase es un commit con su tag. Si algo falla en vivo, `git checkout` a un tag deja el proyecto en un estado que compila.

| Tag | Qué agrega |
| --- | --- |
| `paso-1-modelo` | La clase `Contacto` y el formulario vacío. |
| `paso-2-formulario` | Grilla enlazada a los datos y botón **Agregar**. |
| `paso-3-guardar` | Serializar a `contactos.json` con `JsonSerializer.Serialize`. |
| `paso-4-cargar` | Leer el archivo con `JsonSerializer.Deserialize` y llenar la grilla. |
| `paso-5-errores` | `try/catch` para JSON inválido y errores de archivo. |

```bash
git checkout paso-3-guardar     # volver a un paso
git checkout main               # volver a la versión final
```

## Estructura

```
json-winforms-demo/
├── docs/
│   ├── presentacion.md    guion y cronograma de la clase
│   └── consigna.md        enunciado completo para los alumnos
├── ejemplos/
│   └── contactos.json     archivo de ejemplo para probar la carga
├── src/
│   ├── AgendaJson/        demo terminada
│   └── ConsignaBase/      punto de partida de la consigna
└── json-winforms-demo.sln
```

## El JSON que se genera

```json
[
  {
    "Nombre": "Ana Gómez",
    "Telefono": "221 555-0134"
  }
]
```

El formato lo decide `JsonSerializerOptions`: `WriteIndented` para que se lea y `UnsafeRelaxedJsonEscaping` para que los acentos y la ñ se guarden tal cual en vez de como `\u00F1`.

## Recursos

- [System.Text.Json en .NET](https://learn.microsoft.com/dotnet/standard/serialization/system-text-json/overview)
- [Especificación de JSON (en español)](https://www.json.org/json-es.html)
- [jsonlint](https://jsonlint.com) para validar un archivo a mano
