﻿using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Aula19_11.DTO
{
    
    public class ServidorDTO
    {
        [Required]
        [MinLength(5, ErrorMessage = "Nome deve ter no mínimo 5 caracteres")]
        public string Nome { get; set; }

        [Required]
        [Length(14,14, ErrorMessage = "O cpf deve ter no mínimo 14 caracteres")]
        public string CPF{ get; set; }

        [Required]
        public int  Siape{ get; set; }

    }
}
