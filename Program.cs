using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using practica28_04.models;

namespace practica28_04
{
    public class Program
    {
        List<Producto> productos = new List<Producto>
        {
            new Producto { Id = 1, Nombre = "Laptop HP", Categoria = "Electrónica", Precio = 3500, Stock = 10, ProveedorId = 1 },
            new Producto { Id = 2, Nombre = "Mouse Logitech", Categoria = "Electrónica", Precio = 150, Stock = 50, ProveedorId = 2 },
            new Producto { Id = 3, Nombre = "Silla de Oficina", Categoria = "Muebles", Precio = 800, Stock = 5, ProveedorId = 3 },
            new Producto { Id = 4, Nombre = "Cafetera Oster", Categoria = "Electrodomésticos", Precio = 600, Stock = 0, ProveedorId = 4 },
            new Producto { Id = 5, Nombre = "Escritorio Moderno", Categoria = "Muebles", Precio = 1200, Stock = 7, ProveedorId = 3 },
            new Producto { Id = 6, Nombre = "Monitor Samsung", Categoria = "Electrónica", Precio = 2500, Stock = 8, ProveedorId = 1 },
            new Producto { Id = 7, Nombre = "Teclado Mecánico", Categoria = "Electrónica", Precio = 400, Stock = 15, ProveedorId = 2 },
            new Producto { Id = 8, Nombre = "Aspiradora LG", Categoria = "Electrodomésticos", Precio = 1100, Stock = 2, ProveedorId = 4 }
        
        };


        List<Proveedor> proveedores = new List<Proveedor>
        {
            new Proveedor { Id = 1, Nombre = "TechSupply" },
            new Proveedor { Id = 2, Nombre = "Accesorios PC" },
            new Proveedor { Id = 3, Nombre = "Muebles XYZ" },
            new Proveedor { Id = 4, Nombre = "ElectroHome" }
        };

        public static void Main(string[] args){
            Program program = new Program();

        #region 1
            // var resultado = from prod in program.productos 
            //                 where prod.Stock > 0    
            //                 select prod;
            // resultado.ToList().ForEach(n => Console.WriteLine($"{n.Nombre} {n.Stock}"));

       
       #endregion
     #region 2
        // SelectMany ejemplo adicional
        Random rnd = new();
            var productosConEtiquetas = new List<(string Producto, List<string> Etiquetas)>
            {
                ("Laptop HP", new List<string> { "Electrónica", "Computadores", "Trabajo" }),
                ("Silla de Oficina", new List<string> { "Muebles", "Confort", "Oficina" }),
                ("Cafetera Oster", new List<string> { "Cocina", "Electrodomésticos", "Café" })
            };

            Console.WriteLine("\nTodas las etiquetas:");
           int mindex = rnd.Next(productosConEtiquetas.Count);
           var productoAleatorio = productosConEtiquetas[mindex];

            Console.WriteLine($"Producto aleatorio: {productoAleatorio.Producto}");
            Console.WriteLine("\nTodas las etiquetas: ");
            var todasEtiquetas = productosConEtiquetas.SelectMany(p => p.Etiquetas).Distinct().ToList();
            foreach (var etiqueta in todasEtiquetas)
            {
                Console.WriteLine(etiqueta);
            }
            Console.WriteLine("Escriba una etiqueta: ");
            string userOption = Console.ReadLine().ToUpper();

            if (userOption == productoAleatorio.Producto.ToUpper()){
                Console.WriteLine("Acertaste");
            }else{
                Console.WriteLine("F era: "+productoAleatorio.Producto);
            }
            // foreach (var etiqueta in todasEtiquetas)
            //     Console.WriteLine(etiqueta);

            #endregion


        }

      
         }
          }

