/*

Convenciones para los nombres de variables:

* Los nombres de variable deben usar “camel case”, que es un estilo de escritura que usa una letra en minúscula al principio de la primera palabra y una letra en mayúscula al principio de cada palabra siguiente. >Por ejemplo:string thisIsCamelCase;.
* Los nombres de variables deben ser descriptivos y significativos en la aplicación. Debe elegir para la variable un nombre que represente la clase de datos que va a contener (no el tipo de datos). >Por ejemplo: bool orderComplete;, NO bool isComplete;.
* Los nombres de variables deben ser una o varias palabras completas anexadas. No use contracciones, ya que el nombre de la variable puede no quedar claro para otras personas que lean el código. >Por ejemplo: decimal orderAmount;, NO decimal odrAmt;.
* Los nombres de variables no deben incluir el tipo de datos de la variable. Es posible que vea algunas recomendaciones para usar un estilo como string strMyValue;. Era un estilo popular hace algunos años. Sin embargo, la mayoría de los desarrolladores no siguen este consejo y hay buenas razones para no usarla.

Ejemplos de nombres de variables:

char userOption;

int gameScore;

float particlesPerMillion;

bool processedCustomer;

*/


// Creación de comentarios de código efectivos

string firstName = "Bob";
int widgetsPurchased = 7;
// Testing a change to the message
// int widgetsSold = 7;
// Console.WriteLine($"{firstName} sold {widgetsSold}");
Console.WriteLine($"{firstName} purchased {widgetsPurchased} widgets");

// Ahora que estamos satisfechos eliminamos los comentarios y dejamos el código final

string firstName = "Bob";
int widgetsPurchased = 7;
Console.WriteLine($"{firstName} purchased {widgetsPurchased} widgets.");

Random random= new Random();
string[] orderIDs = new string[5];
// Loop trough each blank orderID
for (int i = 0; i < orderIDs.Length; i++)
{
    // Get a random value that equates to ASCII letters A thorugh E
    int prefixValue = random.Next(65, 70);
    // Convert the random value into a char, then a string
    string prefix = Convert.ToChar(prefixValue).ToString();
    // Create a random number, pad with zeores
    string suffix = random.Next(1, 1000).ToString("000");
    // Combine the prefix and suffix together, then assign to current OrderID
    orderIDs[i] = prefix + suffix;
}
// Print out each orderID
foreach(var orderID in orderIDs)
{
    Console.WriteLine(orderID);
}
/*
Observe que hay dos problemas principales con estos comentarios:

1- Los comentarios de código explican innecesariamente la funcionalidad obvia de las líneas 
de código individuales. Se consideran comentarios de baja calidad porque simplemente 
explican cómo funcionan C# o los métodos de la biblioteca de clases .NET. 
Si el lector no está familiarizado con estas ideas, puede buscarlas en learn.microsoft.com 
o IntelliSense.
2- Los comentarios de código no proporcionan ningún contexto sobre el problema que resuelve
el código. Se consideran comentarios de baja calidad porque el lector no obtiene 
información sobre el propósito de este código, especialmente en lo que se refiere 
al sistema en general.
*/

/*
  The following code creates five random OrderIDs
  to test the fraud detection process.  OrderIDs 
  consist of a letter from A to E, and a three
  digit number. Ex. A123.
*/
Random random = new Random();
string[] orderIDs = new string[5];

for (int i = 0; i < orderIDs.Length; i++)
{
    int prefixValue = random.Next(65, 70);
    string prefix = Convert.ToChar(prefixValue).ToString();
    string suffix = random.Next(1, 1000).ToString("000");

    orderIDs[i] = prefix + suffix;
}

foreach (var orderID in orderIDs)
{
    Console.WriteLine(orderID);
}

// Uso del espacio en blanco para facilitar la legibilidad del código

// Example 1:
Console
.
WriteLine
(
"Hello Example 1!"
)
;

// Example 2:
string firstWord="Hello";string lastWord="Example 2";Console.WriteLine(firstWord+" "+lastWord+"!");

/*
Estos dos ejemplos de código ilustran dos ideas fundamentales:

El compilador no tiene en cuenta los espacios en blanco. No obstante…
Los espacios en blanco, cuando se usan correctamente, 
pueden aumentar la facilidad para leer y comprender el código.
*/

Random dice = new Random();
int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);
int total = roll1 + roll2 + roll3;
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");
if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) {
    if ((roll1 == roll2) && (roll2 == roll3)) {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6; 
    } else {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
    }
}

// Actualizado con espacios en blanco 

Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) {
    if ((roll1 == roll2) && (roll2 == roll3)) {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6; 
    } else {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
    }
}

// Actualización de espacios con la palabra if

Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) 
{
    if ((roll1 == roll2) && (roll2 == roll3)) 
    {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6; 
    } 
    else 
    {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
    }
}

// Ejercicio
/*
   This code reverses a message, counts the number of times 
   a particular character appears, then prints the results
   to the console window.
 */

string str = "The quick brown fox jumps over the lazy dog.";

char[] charMessage = str.ToCharArray();
Array.Reverse(charMessage);
int x = 0;
foreach (char i in charMessage) 
{ 
    if (i == 'o') { x++; } 
}
string new_message = new String(charMessage);
    Console.WriteLine(new_message);
    Console.WriteLine($"'o' appears {x} times.");

// Corregido

/*
   This code reverses a message, counts the number of times 
   a particular character appears, then prints the results
   to the console window.
 */

string originalMessage = "The quick brown fox jumps over the lazy dog.";

char[] message = originalMessage.ToCharArray();
Array.Reverse(message);

int letterCount = 0;

foreach (char letter in message)
{
    if (letter == 'o')
    {
        letterCount++;
    }
}

string newMessage = new String(message);

Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {letterCount} times.");