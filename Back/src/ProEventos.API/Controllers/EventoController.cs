using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
    
        public IEnumerable<Evento> _evento = new Evento[] {
            new Evento() {
                EventoId = 1,
                Tema = "Angular 11 e .NET 5",
                Local = "Chapeco",
                Lote = "1º Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString(),
                ImagemURL = "foto.url"
            },
                new Evento() {
                EventoId = 2,
                Tema = "Angular e suas novidades",
                Local = "Chapeco",
                Lote = "2º Lote",
                QtdPessoas = 350,
                DataEvento = DateTime.Now.AddDays(3).ToString("dd/mm/yyyy"),
                ImagemURL = "folder.url"
            }
        };
        

        public EventoController()
        {
            
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
            
        }
        [HttpGet("{id}")]
        public IEnumerable<Evento> Get(int id)
        {
            return _evento.Where(evento => evento.EventoId== id);
            
        }
        
        [HttpPost]
        public string Post()
        {
            return "Exemplo de post";
        }

        
        [HttpPut("{id}")]
        public string Put( int id)
        {
            return $"Exemplo de put com id = {id}";
        }

        
        [HttpDelete("{id}")]
        public string Delete( int id)
        {
            return $"Exemplo de delete com id = {id}";
        }
    }
}
