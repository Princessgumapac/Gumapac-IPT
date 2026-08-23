using GumapacAPI.Components.Database;
using GumapacAPI.Components.Endpoint;
using GumapacAPI.Components.Model;
namespace GumapacAPI.Components.Endpoint
{
    public static class endpoints
    {
        public static void mapendpoints(this WebApplication app)
        {
            app.MapGet("/api/get", () =>
            {
                return Results.Ok(fakedatabase.student);
            });

            app.MapPost("/api/post", (gumapacModel modelcutie) =>
            {
                fakedatabase.student = modelcutie;
                return Results.Ok("Successfully mine");
            })
            .DisableAntiforgery();
        }
    }
}
