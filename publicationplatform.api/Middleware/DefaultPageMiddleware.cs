using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace PublicationPlatform.api.Middleware
{
    public static class DefaultPageMiddleware
    {

        private static string _content;


        private const string RootPage = "wwwroot/index.html";

        private static async Task LoadContentAsync()
        {
            
            try
            {
                _content = await File.ReadAllTextAsync(RootPage);
            }
            catch (Exception)
            {
                _content = $"{RootPage} page is not found"  ;
            }
        }
            
            
        public static void UseDefaultPage(this IApplicationBuilder app)
        {
            app.Use(async (context, next) =>
            {
                if (_content == null)
                    await LoadContentAsync();

                await context.Response.WriteAsync(_content); 

            });
        }
    }
}