﻿using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos
{
    public class CreateFilmeDto
    {
        [Required(ErrorMessage = "O campo Título é Obrigatório!")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O campo Diretor é Obrigatório!")]
        public string Diretor { get; set; }
        [StringLength(30, ErrorMessage = "O Genero não pode passar de 30 caracteres")]
        public string Genero { get; set; }
        [Range(1, 600, ErrorMessage = "A duração deve ter no mínimo 1 e no máximo 600 minutos")]
        public int Duracao { get; set; }
    }
}
