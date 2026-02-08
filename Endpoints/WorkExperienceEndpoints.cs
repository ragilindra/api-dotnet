using Microsoft.EntityFrameworkCore;
using api_pertama.Data;
using api_pertama.Models;

namespace api_pertama.Endpoints;

public static class WorkExperienceEndpoints
{
    public static void MapWorkExperienceEndpoints(this WebApplication app)
    {
        app.MapPost("/users/{userId}/works", async (
            int userId,
            WorkExperience work,
            AppDbContext db) =>
        {
            var userExists = await db.Users.AnyAsync(u => u.Id == userId);
            if (!userExists)
                return Results.NotFound("User not found");

            work.UserId = userId;
            db.WorkExperiences.Add(work);
            await db.SaveChangesAsync();

            return Results.Ok(work);
        });
    }
}