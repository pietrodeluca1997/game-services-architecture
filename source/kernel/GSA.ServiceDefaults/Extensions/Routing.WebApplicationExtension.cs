using Microsoft.AspNetCore.Builder;

namespace GSA.ServiceDefaults.Extensions;

public static partial class WebApplicationExtensions
{
    public static WebApplication UseDefaultRouting(this WebApplication webApplication)
    {
        webApplication.UsePathBase("/api/");

        webApplication.UseRouting();

        webApplication.MapControllers();

        return webApplication;
    }
}
