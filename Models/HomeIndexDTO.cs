using System.Reflection.Metadata.Ecma335;

namespace Portafolio.Models
{
    public class HomeIndexDTO
    {

        public IEnumerable<ExperienciaDTO> Experiencia { get; set; }
        public IEnumerable<ProyectoDTO> Proyetos { get; set; }
        
    }
}
