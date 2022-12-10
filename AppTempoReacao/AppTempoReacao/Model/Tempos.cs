using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace AppTempoReacao.Model
{
    public class Tempos
    {
        [AutoIncrement,PrimaryKey]
        public int Id { get; set; }
        public string Tempo { get; set; }
        public DateTime Data { get; set; }
    }
}
