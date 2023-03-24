//using Sem8Adonay.Models;

//using AlmacenContext db = new AlmacenContext();

//Producto product= new Producto();

//Console.Write("Ingrese el nombre del producto -> ");
//product.Nombre = Console.ReadLine();

//Console.Write("Ingrese una descripcion del producto -> ");
//product.Descripcion = Console.ReadLine();

//Console.Write("Ingrese el precio del producto -> ");
//product.Precio = Convert.ToDecimal(Console.ReadLine());

//Console.Write("Ingrese la cantidad de productos existentes -> ");
//product.Stock = Convert.ToInt32(Console.ReadLine());

//db.Productos.Add(product);
//db.SaveChanges();

//var ListProductos = db.Productos.ToList();

//foreach (var i in ListProductos)
//{
//    Console.WriteLine($"\nNombre: {i.Nombre}");
//    Console.WriteLine($"Descripcion: {i.Descripcion}");
//    Console.WriteLine($"Precio: ${i.Precio}");
//    Console.WriteLine($"Stock {i.Stock}");
//}

using Sem8Adonay.Models;
using Sem8Adonay.CRU;

ProdCrud CrudProducto = new ProdCrud();
Producto product = new Producto();


Console.Write("Bienvienido Usuario \n");

Console.WriteLine(@"
MENU
Presione 0 para ingresar un nuevo producto que desee
Presione 1 para salir");

var Menu = Convert.ToInt32(Console.ReadLine());

switch (Menu)
{
    case 0:
        bool bucle = true;
        while (bucle == true)
        {
            Console.Write("Escriba el nombre del nuevo producto: ");
            product.Nombre = Console.ReadLine();
            Console.Write("Escriba la descripcion  del nuevo producto: ");
            product.Descripcion = Console.ReadLine();
            Console.Write("Ingrese  el precio del nuevo producto: $");
            product.Precio = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Escriba la cantidad  del nuevo producto: ");
            product.Stock = Convert.ToInt32(Console.ReadLine());

            CrudProducto.AgregueProduct(product);
            Console.WriteLine(@"
El producto nuevo ya esta registrado

Ingrese 0 para ingresar un nuevo producto 
Ingrese 1 para salir
");
            var Menu1 = Convert.ToInt32(Console.ReadLine());

            switch (Menu1)
            {
                case 0:
                    bucle = true;
                    break;
                case 1:
                    bucle = false;
                    break;

            }




        }
        break;

    case 1:
        Console.WriteLine("Agradecemos su confianza de usar nuestro programa, lo esperamos");
        break;
}