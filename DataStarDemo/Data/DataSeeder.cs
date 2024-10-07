using Bogus;
using DataStarDemo.Models;

namespace DataStarDemo.Data;

public class DataSeeder(ApplicationDbContext applicationDbContext)
{
    public async Task Seed()
    {
        await SeedTodos();
    }

    private async Task SeedTodos()
    {
        // delete all todos
        applicationDbContext.Todos.RemoveRange(applicationDbContext.Todos);
        await applicationDbContext.SaveChangesAsync();

        var faker = new Faker();

        // add 10 todo items
        for (int i = 0; i < 10; i++)
        {
            await applicationDbContext.Todos.AddAsync(new Todo
            {
                Title = faker.Lorem.Sentence(),
                Description = faker.Lorem.Paragraph()
            });
        }

        await applicationDbContext.SaveChangesAsync();
    }
}