ME TOCA LA PAGINA 20
###
# Fundamentals Of Programming
# Capítulo 1
## File Prologue
Todos los programas que codifiques, deberían tener un file prologue. La estructura es la siguiente: 
```C#
//Program 1
//CS 1400 Sectio 001
//Instructor: Prof debr
//Contents: source code for example 1
//Date last modified: 08/28/2021
//Version 1.0
//Author: Carlos Che

```

## Código 
### Main Method 
Es el método principal del programa, todos los programas deben tenerlo, y tiene las declaraciones de que es lo que se desea que el programa haga.  Estructura:  
``` c#
static void Main(){

}
```

### Comentarios
Existen dos tipos de comentarios, los de una línea que ignoran todo lo que este escrito hasta encontrar un salto de línea, y los multilineas que ignoran todo lo escrito en las lineas comentadas. Estructura de ambos:

```c#
//COMENTARIO DE UNA LINEA

/* ESTE 
ES UN 
COMENTARIO 
MULTILINEA 
...
*/

```
## Términos
* <b>namespace </b> es similar a un folder. Por ejemplo si tenemos un folder de ciencias con un archivo llamado clase 1 y otro folder de matemáticas con otro archivo llamado clase 1, el archivo clase 1 no se confunde ya que estan en folders distintos. 
Es igual para los namespace, al escribir código debemos especificar que namespace se esta utilizando para que el programa no confunda los nombre de otros archivos.

* <b>Clase </b> Todos los programas de C# deben tener al menos una clase, estas siempre incian con el nombre clase y luego "{" "}" donde dentro de las llaves va todo el código del programa a escribir. 

* <b> Variables locales y globales </b> Las variables locales son las que estan dentro de un método y solo pueden ser accedidas dentro de ese método. Las globales se encuentran fuera del main y pueden ser accedidas desde cualquier parte.

* <b>Statements </b> Son lineas de instrucciones, usualmente terminan con ";" 



## Conocimientos Generales
* Un algoritmo es una descripción paso a paso de cómo resolver un problema
* Un compilador es un programa que convierte tu código en un lenguaje de programación a código máquina que tu computadora entiende.
* UML or Unified Modeling Language es usado por los programadores para crear un modelo visual del problema a resolver.
* Un IDE es una herramienta de desarrollo de software que tiene todo en un solo paquete. Tiene un editor de código, un compilador, herramientas para hace debbug, y más.
* La memoria de la computadora está dividida en 4 segmentos: segmento de código, segmento de datos, heap, stack.

