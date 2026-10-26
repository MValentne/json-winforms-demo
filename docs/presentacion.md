# Guion de la clase

Duración: 45 minutos. Materia: Programación. Tema: JSON con C# y WinForms.

| Minutos | Bloque | Diapositiva |
| --- | --- | --- |
| 3 | Presentación y objetivo | 1–2 |
| 4 | Qué es JSON | 3 |
| 4 | Estructura: objetos, arreglos, valores | 4 |
| 3 | Errores que se cometen siempre | 5 |
| 7 | JSON en C#: serializar y deserializar | 6 |
| 14 | Demostración en vivo | 7 |
| 4 | Consigna | 8 |
| 6 | Resumen y preguntas | 9–10 |

## 1. Portada

Presentarme: quién soy, qué hago, por qué esta clase. Una frase nada más, sin currículum.

Preguntar al curso: **¿dónde creen que se usa JSON?** Dejar que respondan sin corregir; la mayoría va a decir "en una API" o "en un juego". Anotar dos o tres respuestas: al final de la clase se vuelve sobre ellas.

## 2. Objetivo

Al terminar la clase tienen que poder hacer tres cosas:

1. Reconocer JSON y saber si está bien escrito.
2. Pasar de un objeto de C# a JSON y de vuelta.
3. Guardar y cargar datos reales en una aplicación de escritorio.

Lo que **no** entra: bases de datos, APIs HTTP, `async`. Se menciona para que no queden dudas.

## 3. Qué es JSON

- Es texto. No es un lenguaje de programación, no se ejecuta.
- Se usa para guardar datos y para mandarlos de un programa a otro.
- Nació de JavaScript, pero hoy lo lee casi todo: C#, Python, Java, una planilla, un celular.
- Es un formato de intercambio: lo que está guardado no depende del programa que lo escribió.

Decir dónde lo van a ver de verdad: configuración de VS Code (`package.json`, `launch.json`), respuestas de una API, guardado de partidas, el `.json` de un trabajo práctico.

## 4. Estructura

Sobre el ejemplo de la diapositiva:

- `{ }` objeto: pares de clave y valor. La clave va entre comillas dobles.
- `[ ]` arreglo: lista ordenada de valores.
- Valores: texto entre comillas dobles, número sin comillas, `true`/`false`, `null`.
- No hay comentarios. Se anidan objetos y arreglos sin límite.

Preguntar antes de mostrar la respuesta: **¿qué tipo de valor es `"20"`?** Es texto, no número. Es el malentendido más común.

## 5. Errores comunes

Los tres que aparecen siempre, con el mensaje que tira el validador:

- Comillas simples: `'nombre'` → inválido.
- Coma de más antes de la llave: `{ "a": 1, }` → inválido en JSON (en JavaScript sí vale).
- Llave o corchete sin cerrar, o de más.
- Clave sin comillas: `{ nombre: "Ana" }` → inválido.

Consejo práctico: pegar el archivo en jsonlint antes de preguntar por qué no carga. Muestra la línea exacta.

## 6. JSON en C#

`System.Text.Json` viene incluido en .NET, no hay que instalar nada.

- **Serializar**: objeto → texto.
- **Deserializar**: texto → objeto.

Mostrar la clase `Contacto` y nombrar la regla: las propiedades públicas son las que se guardan. Los nombres del JSON salen de las propiedades (`Nombre`, `Telefono`).

Opciones que se usan en la demo:

- `WriteIndented = true`: el archivo se lee.
- `UnsafeRelaxedJsonEscaping`: deja los acentos y la ñ tal cual, en vez de `\u00F1`.

Aclarar que el archivo es texto plano: se puede abrir con el Bloc de notas y editarlo, y eso es una ventaja para depurar.

## 7. Demostración

App: agenda de contactos. `DataGridView`, dos `TextBox` y tres botones.

1. Clonar el repo y abrirlo en Visual Studio.
2. Mostrar `Contacto` y el formulario.
3. **Agregar** dos contactos en la grilla.
4. **Guardar**: abrir el `contactos.json` generado en el Bloc de notas y mostrar que coincide con lo que se cargó.
5. **Cargar**: cerrar la app, abrirla de nuevo, cargar el archivo y ver los datos en la grilla.
6. Editar el `.json` a mano (agregar un contacto), recargar y mostrar que aparece.
7. Romper el JSON a propósito (sacar una coma) y mostrar el error. Después mostrar el `try/catch` que lo evita.

Volver a los tags si algo se rompió: `git checkout paso-3-guardar`.

## 8. Consigna

Leer los cinco requisitos. Aclarar dos cosas:

- El archivo es el respaldo, no la base de datos: la lista vive en memoria y se guarda cuando el usuario lo pide.
- Elegir el tema ahora, en clase. El que se queda pensando el tema pierde la clase.

Dejar el link al repo y a `docs/consigna.md`.

## 9. Resumen

Tres ideas, una por línea:

1. JSON es texto con una forma fija: objetos, arreglos y valores.
2. Serializar es objeto → texto; deserializar es texto → objeto.
3. En WinForms, la lista enlazada a la grilla es la fuente de verdad; el archivo, el respaldo.

Volver a las respuestas de la primera diapositiva y ver cuáles eran correctas.

## 10. Recursos y cierre

Documentación, especificación y validador. Preguntas.

## Antes de presentar

- [ ] Probar la demo completa de punta a punta y cronometrarla.
- [ ] Clonar el repo en la PC de la presentación y compilar ahí, no solo en la mía.
- [ ] Zoom de Visual Studio a 130–150 % para que se lea desde el fondo.
- [ ] Desactivar notificaciones de Windows.
- [ ] Video corto de respaldo de la demo, por si falla el proyector o la compilación.
- [ ] Tener `git checkout paso-5-errores` a mano.
