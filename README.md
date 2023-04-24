# Universidad Católica del Uruguay
<img src="https://ucu.edu.uy/sites/all/themes/univer/logo.png">

## Facultad de Ingeniería y Tecnologías
### Programación II

## Ejercicio de testing de DateFormat

Uno de los ejercicios que hicimos para aprender a hacer en C# las cosas que sabíamos hacer en Python fue convertir una función `DataFormat` en Python a la correspondiente en C#. Aquí te dejamos la solución a ese ejercicio.

Tu deberás ahora agregar casos de prueba al código existente. Para ello:

1. Crea la carpeta `tests` y muévete a esa carpeta para que sea la carpeta actual.
2. Crea en la carpeta que acabas de crear un proyecto de prueba NUnit con el comando `dotnet new nunit --name Library.Tests`. La convención es que haya un proyecto de prueba para cada librería del proyecto, con el mismo nombre, y el sufijo `.Tests`; la librería que te damos es `Library`, por lo tanto el proyecto de prueba es `Library.Tests`.
3. Renombra el archivo `UnitTests1.cs` creado por el comando anterior a `DataFormatterTests` y la clase que contiene de `Tests` a `DateFormatterTests`. La convención es que haya una clase de prueba para cada clase a probar con el mismo nombre, y el sufijo `Tests`. Como la clase a probar es `DateFormatter`, la clase de prueba es `DateFormatterTests`, y el archivo `DateFormatterTests.cs` porque, también por convención, el archivo tiene el nombre de la clase que contiene.
4. Genera una referencia en Library.Tests.csproj hacia Library.csproj, para eso ejecuta el siguiente comando parado en la carpeta de tests:
`dotnet add ./Library.Tests/Library.Tests.csproj reference ../src/Library/Library.csproj`.
5. Haz uno o más casos de prueba que comprueben que la función está bien implementada. Incluye casos de prueba para, al menos, los siguientes casos:
    - Una fecha en formato correcto
    - Una fecha que no tenga el formato correcto
    - Una fecha en blanco
6. Vas a encontrar errores con tus casos de prueba, porque la función que te damos no los contempla todos. Corrige el código provisto, para que pasen tus casos de prueba.
