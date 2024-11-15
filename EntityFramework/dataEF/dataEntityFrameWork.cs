using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using EntityFramework.models;

namespace EntityFramework.dataEF{

    public class ComputerDataBase : DbContext {
        // we added the nullable ? because we just wanna access the model if it exists
        public DbSet<Computer> ? Computer {get;set;}
        private string _connectionString;
        public ComputerDataBase(IConfiguration configuration){
            _connectionString =configuration["dbConnectionString:DefaultConnection"];
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options){
            // check if the server has been configured
            if(!options.IsConfigured){
                options.UseSqlServer( _connectionString,
                options => options.EnableRetryOnFailure());
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            // change the default schema to "TutorialAppSchema" from dbo
            modelBuilder.HasDefaultSchema("TutorialAppSchema");
            // Computer must be the same table in the database
            modelBuilder.Entity<Computer>()
            //.HasNoKey()
            //.HasKey( C => c.FieldName);
            //.ToTable("Computer","TutorialAppSchema")
            //.ToTable(TableName,Schema)
            ;
        }
    }
}