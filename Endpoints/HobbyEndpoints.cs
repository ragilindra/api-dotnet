using Microsoft.EntityFrameworkCore;
using api_pertama.Data;
using api_pertama.Models;

namespace api_pertama.Endpoints;

public static class HobbyEndpoints
{
    public static void MapHobbyEndpoints(this WebApplication app)
    {
        app.MapPost("/users/{userId}/hobbies", async (
            int userId,
            Hobby hobby,
            AppDbContext db) =>
        {
            var userExists = await db.Users.AnyAsync(u => u.Id == userId);
            if (!userExists)
                return Results.NotFound("User not found");

            hobby.UserId = userId;
            db.Hobbies.Add(hobby);
            await db.SaveChangesAsync();

            return Results.Ok(hobby);
        });
    }
}