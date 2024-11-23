namespace First_Web_Ablication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            

            builder.Services.AddControllersWithViews();
            var app = builder.Build();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseEndpoints(
        (endpoints) =>
{
          endpoints.MapControllerRoute(
                   name: "Default",
                  pattern: "{Controller=Home}/{Action=Index}/{id:int?}"
     );
}
);


            app.Run();
        }
    }
}
