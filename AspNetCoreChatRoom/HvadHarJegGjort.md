# AspNetCoreChatRoom
AspNetCoreChatRoom is simple WebSocket based chat room that works in browser. It is built on ASP.NET Core using Visual Studio 2017. This project has no business purpose and I'm using it as a support material for some of my presentations and blog posts.

Jeg forsøger at opgradere den til en nyere version af .Net Core.
Og så vil jeg prøve at lave en .Net core klient i stedet for en .html, som det er nu.

Microsoft har dokumenteret en lang række opgraderinger af Asp.Net Core:
https://docs.microsoft.com/en-us/aspnet/core/migration/20_21?view=aspnetcore-3.0

I .csproj står der netcoreapp2.0, så det må være en .Net Core 2.0.
Så jeg starter med 2.0 til 2.1 migrering (https://docs.microsoft.com/en-us/aspnet/core/migration/20_21?view=aspnetcore-2.1):
  - opdatere .csproj fra netcoreapp2.0 to netcoreapp2.1.
  - jeg har opdateret alle asp net nugets version fra 2.0.x og så til den højeste, der hedder noget med 2.1.x.
  - jeg har lavet de første 3 trin (det sidste var at fjerne version attribut på nuget microsoft.aspnetcore.app i .csproj)
  - så har jeg ændret Program.cs, så nu er der en CreateWebHostBuilder metode.
  - Jeg har lavet nogle af de andre ændringer også, men kun nogle af dem. Jeg har ikke enabled https f.eks.
Efter at jeg har lavet ændringerne fra .Net Core 2.0 til 2.1, så kan jeg stadig F5 fra Visual Studio og chatte imellem 2 tabs i browseren.


