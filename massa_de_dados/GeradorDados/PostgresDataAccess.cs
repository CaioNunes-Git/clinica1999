using System.Data;
using Dapper;
using GeradorDados.Models;
using Npgsql;

namespace GeradorDados;

public class PostgresDataAccess
{
    public IDbConnection CreateConnection()
    {
        return new NpgsqlConnection("Host=localhost;Username=postgres;Password=postgres;Database=postgres");
    }

    public void Insert<T>(string sql, T data)
    {
        using var connection = CreateConnection();
        connection.Open();
        connection.Execute(sql, data);
    }
    
    public void BulkInsert<T>(List<T> lista, string sql)
    {
        using (var connection = CreateConnection())
        {
            connection.Open();
            using (var transaction = connection.BeginTransaction())
            {
                try
                {
                    connection.Execute(sql, lista, transaction: transaction);

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception("Falha ao inserir lista: " + ex.Message, ex);
                }
            }
        }
    }
    
    public List<Funcionario> GetAllFuncionarios()
    {
        using var connection = CreateConnection();
        connection.Open();
        using var transaction = connection.BeginTransaction();
        try
        {
            var funcionarios = connection.Query<Funcionario>("SELECT * FROM funcionario", transaction: transaction).ToList();

            transaction.Commit();

            return funcionarios;
        }
        catch (Exception ex)
        {
            transaction.Rollback();
            return [];
        }
    }
    
    public List<Medico> GetAllMedicos()
    {
        using var connection = CreateConnection();
        connection.Open();
        using var transaction = connection.BeginTransaction();
        try
        {
            var medicos = connection.Query<Medico>("SELECT * FROM medico", transaction: transaction).ToList();

            transaction.Commit();

            return medicos;
        }
        catch (Exception ex)
        {
            transaction.Rollback();
            return [];
        }
    }
}