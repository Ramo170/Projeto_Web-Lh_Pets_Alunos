namespace Projeto_Web_Lh_Pets_versão_1;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();

        app.MapGet("/", () => "LH Pets - Protótipo 1");

        app.UseStaticFiles();
        app.MapGet("/index", (HttpContext contexto) => {
            contexto.Response.Redirect("index.html", false);
        });

        Banco dba = new Banco();
        app.MapGet("/listaClientes", (HttpContext contexto) => {
            contexto.Response.ContentType = "text/html; charset=utf-8";
            return contexto.Response.WriteAsync(dba.GetListaString());
        });

        app.Run();
    }
}
