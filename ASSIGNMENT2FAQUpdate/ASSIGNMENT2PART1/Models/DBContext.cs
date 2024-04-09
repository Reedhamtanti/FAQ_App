using Microsoft.EntityFrameworkCore;

namespace ASSIGNMENT2PART1.Models
{
    public class DBContext : DbContext
    {
         public DBContext() { }
        
        public DBContext(DbContextOptions<DBContext> options) : base(options) { }
        
        public DbSet<Topic> Topics { get; set; }
        
        public DbSet<Category> Categories { get; set; }
        
        public DbSet<FAQs> FAQs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Topic>().HasData(
                new Topic
                {
                    Url = "bootstrap",
                    Name = "Bootstrap"
                },
                new Topic
                {
                    Url = "csharp",
                    Name = "C#"
                },
                new Topic
                {
                    Url = "js",
                    Name = "Javascript"
                }
            );

            modelBuilder.Entity<Category>().HasData(
                new Category { 
                    Url = "general", 
                    Name = "General"
                },
                new Category { 
                    Url = "hist", 
                    Name = "History"
                }
            );

              modelBuilder.Entity<FAQs>().HasData(
               new
               {
                   Id = 1,
                   Question = "What is Bootstrap?",
                   Answer = "A CSS framework for creating responsive web apps for multiple screen sizes.",
                   CategoryUrl = "general",
                   TopicUrl = "bootstrap"
               },
                new
                {
                    Id = 2,
                    Question = "When was Bootstrap first released?",
                    Answer = "In 2011.",
                    CategoryUrl = "hist",
                    TopicUrl = "bootstrap"
                },
                new
                {
                    Id = 3,
                    Question = "Is Bootstrap mobile-friendly?",
                    Answer = "Yes, Bootstrap is designed to be mobile-first, meaning that it prioritizes the mobile viewing experience and adapts to different screen sizes and devices.",
                    CategoryUrl = "general",
                    TopicUrl = "bootstrap"
                },
                new
                {
                    Id = 4,
                    Question = "Does Bootstrap support JavaScript functionality?",
                    Answer = "Yes, Bootstrap includes a set of JavaScript plugins that enhance the functionality of its components. ",
                    CategoryUrl = "general",
                    TopicUrl = "bootstrap"
                },
                new
                {
                    Id = 5,
                    Question = "Who created Bootstrap?",
                    Answer = " Bootstrap was created by Mark Otto and Jacob Thornton, both of whom were engineers at Twitter at the time.",
                    CategoryUrl = "hist",
                    TopicUrl = "bootstrap"
                },
                new
                {
                    Id = 6,
                    Question = "What is Javascript?",
                    Answer = "A general purpose scripting language that executes in a web browser.",
                    CategoryUrl = "general",
                    TopicUrl = "js"
                },
                new
                {
                    Id = 7,
                    Question = "When was Javascript first released?",
                    Answer = "In 1995.",
                    CategoryUrl = "hist",
                    TopicUrl = "js"
                },
                new
                {
                    Id = 8,
                    Question = "What was the motivation behind creating JavaScript?",
                    Answer = "The creation of JavaScript was driven by the need for a lightweight scripting language that could be executed on the client-side within web browsers.",
                    CategoryUrl = "hist",
                    TopicUrl = "js"
                },
                new
                {
                    Id = 9,
                    Question = "Is JavaScript the same as Java?",
                    Answer = "No, JavaScript is not the same as Java. Despite the similar names, they are two distinct programming languages with different syntax, semantics, and purposes.",
                    CategoryUrl = "general",
                    TopicUrl = "js"
                },
                new
                {
                    Id = 10,
                    Question = "What is C#?",
                    Answer = "A general purpose object oriented language that executes in a web browser.",
                    CategoryUrl = "general",
                    TopicUrl = "csharp"
                },
                new
                {
                    Id = 11,
                    Question = "When was C# first released?",
                    Answer = "In 2002.",
                    CategoryUrl = "hist",
                    TopicUrl = "csharp"
                }
            );

        }
    }
}
