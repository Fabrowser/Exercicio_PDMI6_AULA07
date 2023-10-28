using MauiBlazorAlunos.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiBlazorAlunos.Services
{
    internal interface IAlunoService
    {

        Task InitializeAsync();

        Task<List<Aluno>> GetAlunos();

        Task<Aluno> GetAlunoById(int alunoId);

        Task<int> AddAluno(Aluno aluno);

        Task<int> UpdateAluno(Aluno auno);

        Task<int> DeleteAluno(Aluno auno);

    }
}
