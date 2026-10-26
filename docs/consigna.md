# Consigna: agenda con JSON

Armar una aplicación de WinForms que administre una lista de elementos y guarde y cargue los datos desde un archivo JSON.

## Tema

Elegí uno:

- películas (título, director, año)
- productos de un inventario (nombre, precio, stock)
- tareas pendientes (descripción, prioridad, fecha)
- libros (título, autor, año)
- el que quieras, mientras tenga sentido guardarlo como lista

## Requisitos

1. Una clase con **al menos 3 propiedades**.
2. Un `DataGridView` que muestre los datos de la lista.
3. Un botón para **agregar** un elemento.
4. Un botón para **guardar** la lista en un archivo `.json`.
5. Un botón para **cargar** la lista desde un archivo `.json`.

El proyecto `src/ConsignaBase` ya trae la ventana armada con esos controles y los métodos vacíos. Podés partir de ahí o armar tu propio formulario.

## Opcional (suma)

- Eliminar el elemento seleccionado.
- Buscar o filtrar mientras se escribe.
- Elegir el archivo con `OpenFileDialog` y `SaveFileDialog`.
- Manejar el caso de un JSON inválido sin que se cierre la aplicación.
- Evitar contactos repetidos o campos vacíos.

## Qué se mira al corregir

- Que la lista viva en memoria y el archivo sea solo el respaldo (no leer el archivo en cada clic).
- Que el JSON generado se pueda abrir, leer y editar a mano.
- Que al cargar se reemplace lo que había y no se dupliquen los datos.
- Nombres claros y código ordenado, no hace falta que sea largo.

## Entrega

- Individual o de a dos.
- Código en un repositorio de GitHub o una carpeta comprimida.
- Incluir un `.json` de ejemplo con al menos 3 elementos cargados.
- En el README: qué tema eligieron, cómo se ejecuta y una captura de la ventana.
