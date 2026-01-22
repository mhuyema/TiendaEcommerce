using Microsoft.EntityFrameworkCore;
using TiendaNueva.Models;

namespace TiendaNueva.Data
{
    public static class DbSeeder
    {
        public static void Seed(DbContext context) 
        {
            if (context.Set<Categoria>().Any())
            {
                return; 
            }

            var catEmbutirId = Guid.NewGuid();
            var catSuperficieId = Guid.NewGuid();
            var catCajasId = Guid.NewGuid();

            var categorias = new List<Categoria>
        {
            new Categoria
            {
                CategoriaId = catEmbutirId,
                CategoriaName = "Tableros de Embutir",
                Descripcion = "Tableros línea IP40 para embutir en pared, fabricados con materiales termoplásticos resistentes al calor y al fuego. Ideales para instalaciones residenciales y comerciales."
            },
            new Categoria
            {
                CategoriaId = catSuperficieId,
                CategoriaName = "Tableros de Superficie",
                Descripcion = "Tableros línea IP40 para montaje en superficie. Diseño estético con puerta fumé y fácil acceso. Incluyen sistema Easy DIN para montaje cómodo."
            },
            new Categoria
            {
                CategoriaId = catCajasId,
                CategoriaName = "Cajas y Accesorios",
                Descripcion = "Cajas de paso, derivación y gabinetes multiuso para protección de conexiones eléctricas en interiores y exteriores."
            }
        };

            var productos = new List<Producto>
        {
            new Producto
            {
                Nombre = "Tablero 2 a 4 Módulos Embutir",
                Descripcion = "Código: CE 320. Tablero pequeño para embutir. Ideal para térmicas individuales o espacios reducidos. Marco blanco, puerta fumé.",
                PrecioUnitario = 15400.50m,
                URLImage = "https://placehold.co/600x400/0056b3/ffffff?text=Tablero+2-4+Embutir",
                CategoriaId = catEmbutirId
            },
            new Producto
            {
                Nombre = "Tablero 4 a 8 Módulos Embutir",
                Descripcion = "Código: CE 321. Tablero estándar para departamentos. Riel DIN plástico integrado. Resistencia al hilo incandescente.",
                PrecioUnitario = 18200.00m,
                URLImage = "https://placehold.co/600x400/0056b3/ffffff?text=Tablero+4-8+Embutir",
                CategoriaId = catEmbutirId
            },
            new Producto
            {
                Nombre = "Tablero 6 a 12 Módulos Embutir",
                Descripcion = "Código: CE 323. Tablero de capacidad media. Incluye Riel DIN metálico sistema Easy DIN desmontable.",
                PrecioUnitario = 22500.99m,
                URLImage = "https://placehold.co/600x400/0056b3/ffffff?text=Tablero+6-12+Embutir",
                CategoriaId = catEmbutirId
            },
            new Producto
            {
                Nombre = "Tablero 9 a 18 Módulos Embutir",
                Descripcion = "Código: CE 324. Amplia capacidad para distribuciones complejas. Material termoplástico autoextinguible.",
                PrecioUnitario = 28900.50m,
                URLImage = "https://placehold.co/600x400/0056b3/ffffff?text=Tablero+9-18+Embutir",
                CategoriaId = catEmbutirId
            },
            new Producto
            {
                Nombre = "Tablero 12 a 24 Módulos Embutir",
                Descripcion = "Código: CE 326. Doble fila de térmicas. Ideal para viviendas unifamiliares grandes. Puerta fumé reversible.",
                PrecioUnitario = 35600.00m,
                URLImage = "https://placehold.co/600x400/0056b3/ffffff?text=Tablero+12-24+Embutir",
                CategoriaId = catEmbutirId
            },
            new Producto
            {
                Nombre = "Tablero 18 a 36 Módulos Embutir",
                Descripcion = "Código: CE 328. Tablero de gran capacidad. Rieles DIN metálicos reforzados. Espacio para peines de conexión.",
                PrecioUnitario = 42100.75m,
                URLImage = "https://placehold.co/600x400/0056b3/ffffff?text=Tablero+18-36+Embutir",
                CategoriaId = catEmbutirId
            },
            new Producto
            {
                Nombre = "Tablero 30 a 54 Módulos Embutir",
                Descripcion = "Código: CE 325. Máxima capacidad en la línea residencial. Triple fila. Grado de protección IP40.",
                PrecioUnitario = 55800.00m,
                URLImage = "https://placehold.co/600x400/0056b3/ffffff?text=Tablero+30-54+Embutir",
                CategoriaId = catEmbutirId
            },

            // --- Categoría: Tableros de Superficie ---
            new Producto
            {
                Nombre = "Tablero 2 a 4 Módulos Superficie",
                Descripcion = "Código: CS 330. Montaje exterior sin romper pared. Diseño compacto y estético color blanco.",
                PrecioUnitario = 16200.00m,
                URLImage = "https://placehold.co/600x400/e05d06/ffffff?text=Tablero+2-4+Superficie",
                CategoriaId = catSuperficieId
            },
            new Producto
            {
                Nombre = "Tablero 4 a 8 Módulos Superficie",
                Descripcion = "Código: CS 331. Solución rápida para ampliaciones eléctricas. IP40. Material ignífugo.",
                PrecioUnitario = 19500.50m,
                URLImage = "https://placehold.co/600x400/e05d06/ffffff?text=Tablero+4-8+Superficie",
                CategoriaId = catSuperficieId
            },
            new Producto
            {
                Nombre = "Tablero 6 a 12 Módulos Superficie",
                Descripcion = "Código: CS 333. Uno de los más vendidos. Equilibrio perfecto entre tamaño y capacidad. Riel Easy DIN.",
                PrecioUnitario = 24100.00m,
                URLImage = "https://placehold.co/600x400/e05d06/ffffff?text=Tablero+6-12+Superficie",
                CategoriaId = catSuperficieId
            },
            new Producto
            {
                Nombre = "Tablero 9 a 18 Módulos Superficie",
                Descripcion = "Código: CS 334. Para instalaciones que requieren múltiples circuitos. Salida de cables pre-troquelada.",
                PrecioUnitario = 31200.00m,
                URLImage = "https://placehold.co/600x400/e05d06/ffffff?text=Tablero+9-18+Superficie",
                CategoriaId = catSuperficieId
            },
            new Producto
            {
                Nombre = "Tablero 18 a 36 Módulos Superficie",
                Descripcion = "Código: CS 336. Doble fila para montaje en superficie. Ideal oficinas y locales comerciales.",
                PrecioUnitario = 45300.25m,
                URLImage = "https://placehold.co/600x400/e05d06/ffffff?text=Tablero+18-36+Superficie",
                CategoriaId = catSuperficieId
            },
            new Producto
            {
                Nombre = "Tablero 30 a 54 Módulos Superficie",
                Descripcion = "Código: CS 338. Tablero industrial liviano de superficie. Gran espacio interior para cableado.",
                PrecioUnitario = 62000.00m,
                URLImage = "https://placehold.co/600x400/e05d06/ffffff?text=Tablero+30-54+Superficie",
                CategoriaId = catSuperficieId
            },

            // --- Categoría: Cajas y Accesorios ---
            new Producto
            {
                Nombre = "Caja de Paso Estanca 10x10",
                Descripcion = "Caja cuadrada ciega con tornillos de cierre rápido. Protección IP65 contra agua y polvo.",
                PrecioUnitario = 8500.00m,
                URLImage = "https://placehold.co/600x400/28a745/ffffff?text=Caja+Estanca+10x10",
                CategoriaId = catCajasId
            },
            new Producto
            {
                Nombre = "Caja de Paso Estanca 15x15",
                Descripcion = "Caja de derivación de tamaño medio. PVC de alto impacto gris. Gomas pasacables incluidas.",
                PrecioUnitario = 11200.50m,
                URLImage = "https://placehold.co/600x400/28a745/ffffff?text=Caja+Estanca+15x15",
                CategoriaId = catCajasId
            },
            new Producto
            {
                Nombre = "Caja Medidor Monofásico",
                Descripcion = "Gabinete homologado para medidor de energía monofásico. Visor de policarbonato transparente.",
                PrecioUnitario = 25000.00m,
                URLImage = "https://placehold.co/600x400/28a745/ffffff?text=Caja+Medidor+Mono",
                CategoriaId = catCajasId
            },
            new Producto
            {
                Nombre = "Caja Medidor Trifásico",
                Descripcion = "Gabinete homologado para medidor de energía trifásico. Cierre de seguridad tipo perno.",
                PrecioUnitario = 32500.00m,
                URLImage = "https://placehold.co/600x400/28a745/ffffff?text=Caja+Medidor+Tri",
                CategoriaId = catCajasId
            },
            new Producto
            {
                Nombre = "Gabinete Metálico 30x30x15",
                Descripcion = "Gabinete estanco metálico con placa de montaje naranja. Pintura epoxi texturada.",
                PrecioUnitario = 48900.00m,
                URLImage = "https://placehold.co/600x400/28a745/ffffff?text=Gabinete+Metal+30x30",
                CategoriaId = catCajasId
            },
            new Producto
            {
                Nombre = "Gabinete Metálico 40x30x20",
                Descripcion = "Gabinete metálico para tableros generales. Doble cerradura y burlete de poliuretano.",
                PrecioUnitario = 59900.99m,
                URLImage = "https://placehold.co/600x400/28a745/ffffff?text=Gabinete+Metal+40x30",
                CategoriaId = catCajasId
            },
            new Producto
            {
                Nombre = "Kit de Tornillos y Tarugos",
                Descripcion = "Kit de fijación completo para tableros de superficie. Incluye 4 tarugos del 8 y tornillos parker.",
                PrecioUnitario = 1200.00m,
                URLImage = "https://placehold.co/600x400/28a745/ffffff?text=Kit+Fijacion",
                CategoriaId = catCajasId
            }
        };

            // 5. Agregar al contexto y guardar
            context.Set<Categoria>().AddRange(categorias);
            context.Set<Producto>().AddRange(productos);

            context.SaveChanges();
        }
    }
}
