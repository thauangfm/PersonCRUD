public static class PersonRoute
{
    public static void PersonRoutes(this WebApplication app){
        app.MapGet("person", () => "Hello person!");
    }
}