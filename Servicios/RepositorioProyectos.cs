using EllipticCurve.Utils;
using Microsoft.VisualBasic;
using Portafolio.Models;

namespace Portafolio.Servicios
{

    public interface IRepositorioProyectos
    {
        List<ProyectoDTO> ObtenerProyectos();
    }

    public class RepositorioProyectos : IRepositorioProyectos
    {
        public List<ProyectoDTO> ObtenerProyectos()
        {
            return new List<ProyectoDTO> {
                new ProyectoDTO
                {
                    Titulo = "Desarrollo de Programa de Auditoría",
                    Descripcion = "Desarrollé un programa utilizando PHP y MySQL que permite realizar auditorías y almacenar los resultados en una base de datos. El programa incluye un formulario interactivo donde se registran los comentarios y validaciones de la auditoría.",
                    link = "http://amazon.com",
                    imagenURL = "/images/audit (2).png"
                },
                new ProyectoDTO
                {
                    Titulo = "Desarrollo de Programa de Monitoreo de Higiene En Tiempo Real",
                    Descripcion = "Desarrollé un programa utilizando C#, ASP.NET 6 y el patrón de diseño Modelo-Vista-Controlador (MVC) para el Instituto Nacional de Ciencias Médicas y Nutrición Salvador Zubirán (INCMNSZ). El programa permite monitorear en tiempo real la higiene del personal del INCMNSZ a través de un panel de control (dashboard) interactivo.",
                    link = "http://amazon.com",
                    imagenURL = "/images/dashboards (2).png"
                },
                new ProyectoDTO
                {
                    Titulo = "Aplicación de Escritorio que Resuelve Ecuaciones",
                    Descripcion = "Desarrollé una aplicación de escritorio que resuelve ecuaciones lineales, ecuaciones cuadraticas y escuaciones cúbicas, utilizando las herramientas de .NET, C# y WPF",
                    link = "http://amazon.com",
                    imagenURL = "/images/problemariomate.png"
                },
                new ProyectoDTO
                {
                    Titulo = "Modelo Constructivo de Costos de Software (COCOMO)",
                    Descripcion = "Tuve la oportunidad de trabajar en un proyecto donde implementé la metodología COCOMO (Constructive Cost Model) para estimar y gestionar los costos y esfuerzos asociados al desarrollo de software. Para llevar a cabo este proyecto, utilicé las tecnologías .NET, C#, Windows Forms y el patrón de diseño MVC (Modelo-Vista-Controlador)",
                    link = "http://amazon.com",
                    imagenURL = "/images/cocomo.png"
                }
            };
        }
    }
}
