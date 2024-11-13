using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;

namespace HelloWorld.data{
 public class DataQuery{
    private string _connectionString="Server=localhost;Database=DotNetCourseDatabase;TrustServerCertificate=true;Trusted_Connection=true";
    // The database connection (instance variable)
    private IDbConnection _dbConnection;

    // Constructor to initialize the database connection
    public DataQuery()
    {
        _dbConnection = new SqlConnection(_connectionString); // Correcting reference to instance variable
    }

    public IEnumerable<T> QueryData<T>(string sql){
        return _dbConnection.Query<T>(sql);
    }

    public T QuerySingleData<T>(string sql){
        return _dbConnection.QuerySingle<T>(sql);
    }

    public bool ExecSql(string sql){
        
        return (_dbConnection.Execute(sql)>0);
    }


 }
}