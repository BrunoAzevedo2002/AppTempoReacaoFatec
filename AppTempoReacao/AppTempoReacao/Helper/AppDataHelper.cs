using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AppTempoReacao.Model;

namespace AppTempoReacao.Helper
{
    public class AppDataHelper
    {
        readonly SQLiteAsyncConnection _conn;

        public AppDataHelper(string path)
        {
            _conn = new SQLiteAsyncConnection(path);
            _conn.CreateTableAsync<Model.Tempos>().Wait();
        }

        public Task<int>  Insert(Model.Tempos t)
        {
            return _conn.InsertAsync(t);
        }

        public Task<List<Model.Tempos>> GetAll()
        {
            return _conn.Table<Model.Tempos>().ToListAsync(); 
        }

        public Task<int> Delete(int id)
        {
            return _conn.Table<Model.Tempos>().DeleteAsync(i => i.Id == id);
        }

    }
}
