using Portafolio.Models;

namespace Portafolio.Servicios
{

    public interface IRepositorioExperiencia
    {
        List<ExperienciaDTO> ObtenerExperiencia();
    }

    public class RepositorioExperiencia : IRepositorioExperiencia
    {
        public List<ExperienciaDTO> ObtenerExperiencia()
        {
            return new List<ExperienciaDTO>
            {
                new ExperienciaDTO
                {
                    NombreEmpresa = "IDS Comercial ti",
                    Puesto ="Desarrollador Backend JR",
                    Actividades ="Tuve la oportunidad de incorporarme a esta empresa como Desarrollador Junior, donde estoy sumergiéndome en valiosa experiencia en el desarrollo backend. En este entorno, he tenido la oportunidad de participar activamente en proyectos significativos, contribuyendo no solo al crecimiento de la empresa, sino también a mi propio desarrollo profesional.",
                    Imagen= "/images/ids.jpg",
                    Tiempo= "Noviembre/2023 - Actualmente",
                    Link = "https://www.ids.com.mx/"
                },

                new ExperienciaDTO
                {
                    NombreEmpresa = "ETSAI IT Soulutions",
                    Puesto ="Desarrollador JR",
                    Actividades ="Formé parte del equipo de desarrollo de un sistema de punto de venta destinado a una cadena de farmacias en el país. Durante mi participación en este proyecto, tuve la oportunidad de adentrarme más en el concepto y la implementación del patrón de diseño MVC (Modelo-Vista-Controlador). Este proyecto no solo me permitió contribuir al ámbito tecnológico de la empresa, sino que también amplió significativamente mi comprensión y habilidades en el desarrollo de software utilizando este enfoque arquitectónico.",
                    Imagen= "/images/etsai.jpg",
                    Tiempo= "Septiembre/2023 - Octubre/2023",
                    Link="https://etsai.mx/"
                },

                new ExperienciaDTO
                {
                    NombreEmpresa = "INCMNSZ",
                    Puesto ="Servicio Social",
                    Actividades ="Durante mi servicio social en este instituto, tuve la oportunidad de aplicar mis habilidades en programación al desarrollar dos sistemas que automatizan procesos clave para el personal del INCMNSZ. Este periodo no solo representó una valiosa contribución a la eficiencia interna de la institución, sino también una experiencia enriquecedora que me permitió poner en práctica mis conocimientos en un entorno profesional y de alto impacto.",
                    Imagen= "/images/incmnszLogo.jpg",
                    Tiempo= "Septiembre/2022 – Abril/2023",
                    Link="https://www.incmnsz.mx/opencms/index.html"
                }
            };
        }
    }
}
