using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using Portafolio.Servicios;
using System.Diagnostics;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepositorioProyectos repositorioProyectos;
        private readonly IRepositorioExperiencia repositorioExperiencia;
        private readonly IServicioEmail servicioEmail;

        public HomeController(IRepositorioProyectos repositorioProyectos, IServicioEmail servicioEmail, IRepositorioExperiencia repositorioExperiencia)
        {
            this.repositorioProyectos = repositorioProyectos;
            this.servicioEmail = servicioEmail;
            this.repositorioExperiencia = repositorioExperiencia;
        }

        public IActionResult Index()
        {
            var proyectos = repositorioProyectos.ObtenerProyectos().Take(5).ToList();
            var experiencia = repositorioExperiencia.ObtenerExperiencia().Take(4).ToList();
            var modelo = new HomeIndexDTO()
            {
                Experiencia = experiencia,
                Proyetos = proyectos
            };
            return View(modelo);
        }


        public IActionResult Experiencia() 
        {
            var experiencia = repositorioExperiencia.ObtenerExperiencia();

            return View(experiencia);
        }
        public IActionResult Proyectos()
        {
            var proyectos = repositorioProyectos.ObtenerProyectos();

            return View(proyectos);
        }

        [HttpGet]
        public IActionResult Contacto()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Contacto(ContactoDTO contactoDTO)
        {

            await servicioEmail.Enviar(contactoDTO);
            return RedirectToAction("Gracias");
         
        }

        public IActionResult Gracias()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}