using System.Web.Http;

class WebApiConfig
{
    public static void Register(HttpConfiguration configuration)
    {
        var json = configuration.Formatters.JsonFormatter;
        json.SerializerSettings.PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.Objects;
        configuration.Formatters.Remove(configuration.Formatters.XmlFormatter);



        configuration.Routes.MapHttpRoute("API Default", "api/{controller}/{id}",
            new { id = RouteParameter.Optional });
    }
}