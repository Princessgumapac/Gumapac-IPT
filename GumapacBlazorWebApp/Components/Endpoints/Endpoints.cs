using GumapacBlazorWebApp.Components.Models;

namespace GumapacBlazorWebApp.Components.Endpoints
{
    public static class Endpoints
    {
        public static void MapEndpoints(this WebApplication app)
        {
            app.MapGet("api/name", () =>
            {
                return new myName
                {
                    Name = "Princess Diann Gumapac"
                };
            });

            app.MapGet("api/age", () =>
            {
                return new myAge
                {
                    Age = 20
                };
            });

            app.MapGet("api/birthdate", () =>
            {
                return new myBirthDate
                {
                    BirthDate = "September 13, 2006"
                };
            });

            app.MapGet("api/program", () =>
            {
                return new myProgram
                {
                    Program = "Bachelor of Science in Information Technology"
                };
            });

            app.MapGet("api/email", () =>
            {
                return new myEmail
                {
                    Email = "gumapac.prheu24@southernchristiancollege.edu.ph"
                };
            });

            app.MapGet("api/address", () =>
            {
                return new myAddress
                {
                    Address = "Midsayap, North Cotabato"
                };
            });

            app.MapGet("api/contact", () =>
            {
                return new myContact
                {
                    Contact = "0963-595-4641"
                };
            });
        }
    }
}
