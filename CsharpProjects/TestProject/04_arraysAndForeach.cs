/* 
¿Qué es una matriz?
Una matriz es una secuencia de elementos de datos individuales 
a los que se puede acceder a través de un nombre de variable único. 
Se usa un índice numérico de base cero para acceder a cada elemento de una matriz.
*/

// Matriz de cadenas que contiene tres elementos:

using System.Xml;

string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
// fraudulentOrderIDs[3] = "D000";

    Output: // con dotnet build
    Build succeeded.        
    0 Warning(s)        
    0 Error(s)

    Output // con dotnet run
    Error // Corregido al quitar IDs[3]

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

    Output:
    First: A123
    Second: B456
    Third: C789

// Reasignación del valor de una matriz

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

    Output:
    First: A123
    Second: B456
    Third: C789
    Reassign First: F000

// Incialización de una matriz
/*
Puede inicializar una matriz durante la declaración igual que haría con una variable normal. 
Sin embargo, para inicializar los elementos de la matriz, se usa una sintaxis especial 
con llaves.
*/

string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

    Output:
    First: A123
    Second: B456
    Third: C789
    Reassign First: F000

// Uso de la propiedad Length de una matriz
//  Para determinar el tamaño de una matriz, puede usar la propiedad Length.

string[] fraudulentOrderIDs = { "A123", "B456", "C789" };
// int[] myarray = new int[3]; myarray[0] = 1; myarray[1] = 2; myarray[2] = 3;. OTro ejemplo

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

    Output:
    First: A123
    Second: B456
    Third: C789
    Reassign First: F000
    There are 3 fraudulent orders to process.

// Implementación de la instrucción foreach

// Recorrido en bucle de una matriz con "foreach"
/*
La instrucción foreach ofrece una manera sencilla y limpia de iterar los elementos 
de una matriz. La instrucción foreach procesa los elementos de matriz en orden
 creciente de índice, comenzando con el índice 0 y terminando con el índice Length - 1. 
 Usa una variable temporal para contener el valor del elemento de matriz asociado 
 a la iteración actual. Cada iteración ejecutará el bloque de código que se encuentra 
 debajo de la declaración foreach.
 */

string[] names = { "Rowena", "Robin", "Bao"};
foreach (string name in names)
{
    Console.WriteLine(name);
}

    Output:
    Rowena
    Robin
    Bao

/*
Ejercicio:
Imagine que trabaja para una empresa de fabricación. La empresa necesita que complete 
un inventario de su almacén para determinar el número de productos que están listos 
para enviarse. Además del número total de productos terminados, debe informar del número 
de productos terminados almacenados en cada contenedor individual del almacén, 
junto con una suma acumulativa. Esta suma acumulativa se usará para crear una pista 
de auditoría para que pueda comprobar el trabajo e identificar la "reducción".
*/

// Matriz para almacenar el número de productos terminados:

int[] inventory = { 200, 450, 700, 175, 250};

//Agregar una instrucción foreach para recorrer en iteración la matriz.

foreach (int items in inventory)
{

}
// Agregar una variable para sumar el valor de cada elemento de la matriz.

int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
foreach (int items in inventory)
{
    sum += items;
}
// Mostrar el valor final de suma.
Console.WriteLine($"We have {sum} items in inventory");

    Output:
    We have 1775 items in inventory.

/* 
Crear una variable que contenga el número del contenedor actual y que muestre 
la suma acumulativa.

Para cumplir el requisito final del proyecto de informe de inventario, 
es necesario crear una variable que contenga la iteración actual de la instrucción foreach
para que podamos mostrar el contenedor y el número de elementos terminados en ese contenedor, 
junto con la suma acumulativa de todos los elementos de los contenedores 
que se han contabilizado hasta el momento.
*/

int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
int bin = 0; // Usamos bin para almacenar el número del contenedor cuyo inventario se está procesando actualmente.
foreach (int items in inventory)
{
    sum += items;
    bin++; // para incrementar bin cada vez que se ejecuta el bloque de código
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
    // Para notificar el número de contenedor, el número de productos terminados en el contenedor y la suma acumulativa de productos terminados.
}
Console.WriteLine($"We have {sum} items in inventory.");

    Output:
    Bin 1 = 200 items (Running total: 200)
    Bin 2 = 450 items (Running total: 650)
    Bin 3 = 700 items (Running total: 1350)
    Bin 4 = 175 items (Running total: 1525)
    Bin 5 = 250 items (Running total: 1775)
    We have 1775 items in inventory.

// Desafío de código: 
// Notificar los identificadores de pedido que necesitan una investigación más detallada

/*
El equipo ha encontrado un patrón. Los pedidos que comienzan por la letra "B" 
presentan un fraude con una frecuencia 25 veces superior a la normal. 
Deberá escribir otro código que genere el identificador de pedido para los nuevos pedidos 
que empiecen por la letra "B". El equipo antifraude lo usará para investigar 
más en profundidad.
*/

string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

foreach (string orderID in orderIDs)
{
    if (orderID.StartsWith("B")) // Usamos .StarWith() para buscar los que comienzan en B
    {
        Console.WriteLine(orderID);
    }
}

