// =====================
// 1. Variables y Tipos
// =====================

// a) Declarar una variable con el nombre de una empresa y mostrarla por consola.
string empresa = "David";
Console.WriteLine(empresa);
// b) Declarar una variable con la cantidad de empleados y mostrarla por consola.
int empleados = 15;
Console.WriteLine(empleados);
// c) Declarar una variable decimal con el ingreso mensual estimado.
decimal ingresoMensual = 50000.75m;
// d) Mostrar por consola un mensaje que diga el nombre de la empresa, cantidad e empleados e ingreso.
Console.WriteLine("nombre de la empresa es " + empresa + " tiene " + empleados + " empleados y un ingreso de" + ingresoMensual);

// ==============
// 2. Operadores
// ==============

// a) Declarar dos precios de productos y calcular el total de los dos con IVA.
int precio1 = 150;
int precio2 = 45;
float iva = precio1 + precio2 * 21 / 100;
Console.WriteLine(iva);
// b) En base a la siguiente variable -> int ingresoAnual = 1500;
//    Hacer otra variable que represente el ingreso mensual y mostrarla por consola.
int ingresoAnual = 1500;
int ingresoMes = ingresoAnual / 12;
Console.WriteLine(ingresoMes);
// c) Crear una variable que represente si el ingreso anual es mayor a 1000 o no.
bool EsMayoraAMil = ingresoAnual > 1000;
Console.WriteLine(!EsMayoraAMil);
// d) Calcular cuánto gana una empresa por mes si su ingreso anual es 1500
//    y tiene que pagar 12% de impuestos al estado.
int ingresoAnual2 = 1500;
float impuestos = ((ingresoAnual2 * 12) / 1000);
Console.WriteLine(impuestos);


//// ==========================
// 3. Estructuras de Control
// ==========================

// a) En base a la cantidad de empleados de una empresa, mostrar por consola el tamaño de la misma:
//     - Si tiene 10 o menos empleados → "Startup"
//     - Si tiene Entre 11 y 50 → "Pyme"
//     - Si tiene más de 50 → "Big"

int empleado = int.Parse(Console.ReadLine());

if (empleado <= 1)
{
    Console.WriteLine("StartUp");
}
else if (empleado > 11 && empleados <= 50)
{
    Console.WriteLine("Pyme");
}
else
{
    Console.WriteLine("BiG");
}

// b) En base al monto de inversión de una empresa, clasificar la inversión como:
//     - Si es menor a 10,000 → "Baja"
//     - Si está entre 10,000 y 100,000 → "Media"
//     - Si es mayor a 100,000 → "Alta"

// c) Según el tipo de cliente ("mayorista" o "minorista"), mostrar el precio final de un producto con descuento si corresponde:
//     - Si es mayorista → 20% de descuento
//     - Si es minorista → precio completo

// d) Una distribuidora tiene 20 unidades de cerveza en stock. Un cliente solicita 25 unidades.
//    Verificar si hay suficiente stock para concretar la venta:
//     - Si alcanza, mostrar por consola: "Venta confirmada. Cervezas en stock suficientes."
//     - Si no alcanza, mostrar: "No hay suficientes cervezas en stock. Faltan X unidades."
//       (donde X debe calcularse dinámicamente en base a las variables)


// ==========
// 4. Bucles
// ==========

// a) Mostrar los primeros 10 números naturales usando un for.

// b) Dado este array que representa las ventas de una empresa:
//    int[] ventasMensuales = { 1000, 1200, 950, 1100 };
//    Sumar las ventas mensuales con un foreach y mostrar el total por consola.

// c) Hacer una cuenta regresiva del 5 al 1 con while.

// d) Simular un login: pedir usuario hasta que ingrese "admin" con do-while.


// =============
// 5. Funciones
// =============

// a) Crear una función que reciba el ingreso mensual y devuelva el anual.
//    Llamar a la función y mostrar el resultado en consola.

// b) Crear una función que reciba una edad y devuelva si es mayor o menor de edad.
//    Llamar a la función y mostrar el resultado en consola.

// c) Crear una función que reciba el precio y el tipo de cliente y devuelva el precio final con o sin descuento.
//    Llamar a la función y mostrar el resultado en consola.


// ===================
// 6. Listas y arrays
// ===================

// a) Crear un array con nombres de 3 productos y mostrarlos por consola.

// b) Crear un array con los ingresos trimestrales (double) y calcular el total anual.

// c) Mostrar el producto más vendido de un array con cantidades vendidas.

// d) Crear una lista de precios y calcular el promedio.
//    Usar List<double> para practicar con listas.
