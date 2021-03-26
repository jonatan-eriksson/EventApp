# ASP.NET Core
ASP.NET Core är ett ramverk för att bygga webbapplikationer, APIer och microservices som är snabba, säkra och cross-platform.

Razor är en markup syntax som låter dig skapa dynamiska webbsidor genom en kombination av HTML och C#.

I startup.cs konfigurerar man applikationen, man kopplar olika services som behövs och bestämmer vilka middlewares som inkommande requests ska gå igenom innan den kan returnera ett svar.

wwwroot innehåller applikationens statiska filer som html, css, javascript, bilder.


## RazorPages
RazorPages består två delar PageModel (.cshtml.cs) och Content Page (.cshtml).

PageModel hanterar det logiska på webbsidan och kan reagera på http requests med hjälp av Page Handlers OnGet, OnPost.

Content Page är det visuella på webbsidan och byggs upp med Razor-kod som man sen kopplar ihop med PageModel objektet


## MVC
MVC delar upp ansvarsområden i tre huvudgrupper Model, View och Controller.

Model definierar saker och egenskaper och hanterar regler och logik,

View är det visuella som användaren ser.

Controller hanterar requests från View som den kommunicerar vidare till Model och andra services, och bestämmer också vilken View som ska visas och ger den all Model-data som krävs.
