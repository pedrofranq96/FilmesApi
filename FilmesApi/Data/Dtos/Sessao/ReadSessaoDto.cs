using FilmesApi.Models;
using System;

namespace FilmesApi.Data.Dtos
{
    public class ReadSessaoDto
    {
        public int Id { get; set; }
        public Filmes Filme { get; set; }
        public Cinema Cinema { get; set; }
        public DateTime HorarioEncerramento { get; set; }
        public DateTime HorarioInicio { get; set; }
    }
}
