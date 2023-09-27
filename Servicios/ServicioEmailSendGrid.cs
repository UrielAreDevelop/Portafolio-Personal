﻿using Portafolio.Models;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.Net.Mail;

namespace Portafolio.Servicios
{

    public interface IServicioEmail
    {
        Task Enviar(ContactoDTO contacto);
    }
    public class ServicioEmailSendGrid : IServicioEmail
    {
        private readonly IConfiguration configuration;

        public ServicioEmailSendGrid(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public async Task Enviar(ContactoDTO contacto)
        {
            var apiKey = configuration.GetValue<string>("SENDGRID_API_KEY");
            var email = configuration.GetValue<string>("SENDGRID_FROM");
            var nombre = configuration.GetValue<string>("SENDGRID_NOMBRE");

            var cliente = new SendGridClient(apiKey);
            var from = new EmailAddress(email, nombre);
            var subject = $"El cliente {contacto.Email} quiere contactarte";
            var to = new EmailAddress(email, nombre);
            var mensajeTextoPlano = contacto.Mensaje;
            var Contenidohtml = @$"De: {contacto.Nombre} - 
Email: {contacto.Email} 
Mensaje:{contacto.Mensaje}";
            var singleEmail = MailHelper.CreateSingleEmail(from, to, subject, mensajeTextoPlano, Contenidohtml);
            var respuesta = await cliente.SendEmailAsync(singleEmail);

        }
    }
}
