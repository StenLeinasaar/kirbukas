using ToDoApp.Dtos;
using Microsoft.EntityFrameworkCore;

namespace ToDoApp.Data{
    public class ChatAppDbContext: DbContext{

        public ToDoAppDbContext(DbContextOptions options) : base(options){

        }


        // Creates a table with the property definitions from Dtos
        public DbSet<Task> Tasks { get; set; }

    }
}