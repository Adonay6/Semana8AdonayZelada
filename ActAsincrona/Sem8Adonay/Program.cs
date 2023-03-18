using Sem8Adonay.Models;

using AlmacenContext db = new AlmacenContext();

Producto product= new Producto();

Console.Write("Ingrese el nombre del producto -> ");
product.Nombre = Console.ReadLine();

Console.Write("Ingrese una descripcion del producto -> ");
product.Descripcion = Console.ReadLine();

Console.Write("Ingrese el precio del producto -> ");
product.Precio = Convert.ToDecimal(Console.ReadLine());

Console.Write("Ingrese la cantidad de productos existentes -> ");
product.Stock = Convert.ToInt32(Console.ReadLine());

db.Productos.Add(product);
db.SaveChanges();

var ListProductos = db.Productos.ToList();

foreach (var i in ListProductos)
{
    Console.WriteLine($"\nNombre: {i.Nombre}");
    Console.WriteLine($"Descripcion: {i.Descripcion}");
    Console.WriteLine($"Precio: ${i.Precio}");
    Console.WriteLine($"Stock {i.Stock}");
}