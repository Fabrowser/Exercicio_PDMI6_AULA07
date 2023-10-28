using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiBlazorAlunos.Data
{
    internal class Aluno
    {

        [PrimaryKey, AutoIncrement]
        public int AlunoId { get; set; }
        [Required]

        public string Nome { get; set; }
        [Required]

        public string Email { get; set; }
        [Required]

        public string Endereco { get; set; }
        [Required]

        public string Genero { get; set; }

    }
}
