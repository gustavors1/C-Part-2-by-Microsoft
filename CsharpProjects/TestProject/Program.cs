// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// diferentes tipos de métodos en la biblioteca de clases .NET

Random dice = new Random();
int roll = dice.Next(1, 7);
Console.WriteLine(roll);

// Métodos sobrecargados

int number = 7;
string text = "seven";

Console.WriteLine(number);
Console.WriteLine();
Console.WriteLine(text);

Random dice2 = new Random();
int roll1 = dice2.Next();
int roll2 = dice2.Next(101);
int roll3 = dice2.Next(50, 101);

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");

// Ejercicio
// Busque un método de la clase System.Math que devuelva el mayor de dos números.

int firstValue = 500;
int secondValue = 600;
int largerValue;
largerValue = Math.Max(firstValue, secondValue);
Console.WriteLine(largerValue);

// Clase 3. Adición de lógica.

// Escritura de código que genera tres números aleatorios y los muestre en la salida.

Random  dice3 = new Random();
int roll4 = dice3.Next(1, 7);
int roll5 = dice3.Next(1, 7);
int roll6 = dice3.Next(1, 7);

int total = roll4 + roll5 + roll6;

Console.WriteLine($"Dice roll: {roll4} + {roll5} + {roll6} = {total}");

/*
Incorporación de otra instrucción if para implementar puntos extra por obtener dobles
*/

if ((roll4 == roll5) || (roll5 == roll6) || (roll4 == roll6)) // condición compuesta. 
/*
Los caracteres de barra vertical || son el operador O lógico, 
que básicamente indica “la expresión a la izquierda O la expresión 
a la derecha deben ser verdaderas para que toda la expresión booleana sea verdadera”.
*/

{
    Console.WriteLine("You rolled doubles! +2 bonus to total!");
    total += 2;
}

// Extra por triples

if ((roll4 == roll5) && (roll5 == roll6)) // Y lógico, que básicamente indica “solo si ambas expresiones son verdaderas, la expresión completa es verdadera”.
{
    Console.WriteLine("You rolled triples! +6 bonus to total!");
    total += 6;
}

/*
Incorporación de una instrucción if para mostrar diferentes mensajes 
según el valor de la variable total
*/

if (total >= 15)
{
    Console.WriteLine("You win!");
}

if (total < 15)
{
    Console.WriteLine("Sorry, you lose");
}

// Incorporación de otra instrucción if para implementar los puntos extra por obtener triples.

/* 
A continuación, puede implementar la siguiente regla: 
"Si los tres dados que tire muestran el mismo valor, obtendrá seis puntos extra 
por obtener un triple".
*/

/*
Resumen
Use una instrucción if para crear una rama en la lógica del código. La instrucción de decisión if ejecutará el código en su bloque de código si su expresión booleana es verdadera. De lo contrario, el runtime omitirá el bloque de código y continuará con la siguiente línea de código después de este.
Una expresión booleana es cualquier expresión que devuelve un valor booleano.
Los operadores booleanos compararán los dos valores a la izquierda y a la derecha para ver si son iguales, para compararlos, etc.
Un bloque de código está delimitado por llaves { }. Recopila líneas de código que deben tratarse como una sola unidad.
El operador Y lógico, &&, agrega dos expresiones y ambas subexpresiones deben ser verdaderas para que toda la expresión sea verdadera.
El operador O lógico, ||, agrega dos expresiones y si alguna de las subexpresiones es verdadera, toda la expresión lo es también.
*/


