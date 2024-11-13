using Microsoft.EntityFrameworkCore;
using EntityFramework.models;

namespace EntityFramework.dataEF{

    public class ComputerDataBase : DbContext {
        // we added the nullable ? because we just wanna access the model if it exists
        public DbSet<Computer> ? Computer {get;set;}
        protected override void OnConfiguring(DbContextOptionsBuilder options){
            // check if the server has been configured
            if(!options.IsConfigured){
                options.UseSqlServer("Server=localhost;Database=DotNetCourseDatabase;TrustServerCertificate=true;Trusted_Connection=true",
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