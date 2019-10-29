using CapaAccesoDatos;
using CapaLogica.Login;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;


namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cliente> lista = new List<Cliente>()
            {
                new Cliente() { nombre = "Hola2", apellidos = "Adios" },
                new Cliente() { nombre = "Hola2", apellidos = "Adios" }
                ,new Cliente() { nombre = "Hola2", apellidos = "Adios" }
            };
            string json = JsonConvert.SerializeObject(lista);
            Console.WriteLine("JSON " + json);

            List<Cliente> c2 = JsonConvert.DeserializeObject<List<Cliente>>(json);
            
            Console.ReadKey();
            if (true) return;
            using (RestaurantEntities context = new RestaurantEntities())
            {
                // LoginManager.Agregar("test", "123", new Trabajador() { id_trabajador = 1004 });
                // Trabajador t = LoginManager.Login("test", "1235");

                CategoriaProducto comida = new CategoriaProducto()
                {
                    nombre_categoria = "Comida"
                };

                // context.CategoriaProducto.Add(comida); // No necesario por el momento se agrega abajo automaticamente

                Producto sopa = new Producto()
                {
                    CategoriaProducto = comida, // Agregar la categoria para que se agregue a la BD
                    nombre_producto = "Sopa tarasca",
                    //  precio = 34.00m // Sufijo m para indicar decimal (money)
                };

                context.Producto.Add(sopa); // Agregamos la sopa

                context.SaveChanges(); // Guardar y subir a la BD

                // Consultar categoria del producto agregado anteriormente, el id se agrega solo al guardar cambios
                CategoriaProducto comidaQuerie = context.CategoriaProducto.SingleOrDefault(cp => cp.id_categoria == comida.id_categoria);

                // Todos los productos que entran en esta categoria
                foreach (Producto p in comidaQuerie.Producto)
                {
                    Console.WriteLine(p.nombre_producto + " id:" + p.id_producto + " es: " + p.CategoriaProducto.nombre_categoria);
                }

                // Eliminar la sopa
                context.Producto.Remove(sopa);
                // Eliminar la categoria
                context.CategoriaProducto.Remove(comidaQuerie);

                // Guardar
                context.SaveChanges();
            }

            Console.ReadKey();
        }
    }
}
