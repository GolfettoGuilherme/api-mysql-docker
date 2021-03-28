using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using Estudo_Api_Com_Banco.Models;
using MySql.Data.MySqlClient;

namespace Estudo_Api_Com_Banco.Service
{
    public class MySqlService
    {
        private readonly MySqlConnection _conn;
        private string _connectionString = "Server=localhost;Port=3306;Database=estudos;Uid=root;Pwd=root;";

        public MySqlService()
        {
            _conn = new MySqlConnection(_connectionString);
        }

        public List<Aluno> List()
        {
            var sql = "SELECT * FROM Alunos";
            var result = this._conn.Query<Aluno>(sql).ToList();
            return result;
        }

        public int Insert(Aluno aluno)
        {
            var sql = "INSERT INTO Alunos(nome, endereco) VALUES (@nome, @endereco)";
            return this._conn.Execute(sql, new { nome = aluno.Nome, endereco = aluno.Endereco });
        }
        
    }
}
    