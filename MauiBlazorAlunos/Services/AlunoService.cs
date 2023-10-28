using MauiBlazorAlunos.Data;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiBlazorAlunos.Services
{
    internal class AlunoService : IAlunoService
    {

        private SQLiteAsyncConnection _dbConnection;


        public async Task InitializeAsync()
        {
            await SetUpDb();
        }


        private async Task SetUpDb()
        {
            if (_dbConnection == null)
            {
                string dbPath = Path.Combine(FileSystem.Current.AppDataDirectory, "clientdb.db3");
                _dbConnection = new SQLiteAsyncConnection(dbPath);
                await _dbConnection.CreateTableAsync<Aluno>();
            }
        }

        public async Task<int> AddAluno(Aluno aluno)
        {
            return await _dbConnection.InsertAsync(aluno);
        }


        public async Task<int> DeleteAluno(Aluno aluno)
        {
            return await _dbConnection.DeleteAsync(aluno);
        }


        public async Task<int> UpdateAluno(Aluno aluno)
        {
            return await _dbConnection.UpdateAsync(aluno);
        }



        public async Task<List<Aluno>> GetAlunos()
        {
            return await _dbConnection.Table<Aluno>().ToListAsync();
        }



        public async Task<Aluno> GetAlunoById(int alunoId)
        {
            var aluno = await _dbConnection.QueryAsync<Aluno>($"Select * From {nameof(Aluno)} where AlunoId = {alunoId}");
            
            return aluno.FirstOrDefault();
        }
    }
}
