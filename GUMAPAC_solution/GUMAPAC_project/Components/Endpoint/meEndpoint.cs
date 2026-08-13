using GUMAPAC_project.Components.Endpoint;

namespace GUMAPAC_project.Components.Endpoint;

public static class meEndpoint
{
    public static void MapmeEndpoint(this WebApplication app)
    {
        app.MapGet("/api/Me", () =>
        {
            var Me1 = new Models.Me
            {
                fullname = "Princess Gumapac",
                id = 240462,
                course = "Information Technology"
            };
            return Results.Ok(Me1);
        });
    }
}
