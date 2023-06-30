

namespace Portafolio.Models.Servicios
{
    public class RepositorioProyectos
    {
        public List<ProyectosViewModel> ObtenerProyectos()
        {
            return new List<ProyectosViewModel>() {
             new ProyectosViewModel
            {
                Titulo= "Amazon",
                Descripcion = "E-Commerce realizado en ASP.NET Core",
                Link = "https://www.amazon.com/",
                ImagenURL = "/imagenes/amazon.png"
            },
             new ProyectosViewModel
            {
                Titulo= "New York Times",
                Descripcion = "Pagina de noticias en React",
                Link = "https://www.nytimes.com/es/",
                ImagenURL = "/imagenes/the-new-york-times.png"
            },
             new ProyectosViewModel
            {
                Titulo= "Reddit",
                Descripcion = "Red social para compartir en comunidades",
                Link = "https://www.reddit.com/",
                ImagenURL = "/imagenes/reddit.png"
            },
             new ProyectosViewModel
            {
                Titulo= "Steam",
                Descripcion = "ReTienda en linea para comprar videojuegos",
                Link = "https://store.steampowered.com/?l=spanish",
                ImagenURL = "/imagenes/steem.png"
            }


            };
        }
    }
}
