using Ejercicio_1___Historial_de_navegacion;

BrowserHistory history = new BrowserHistory();

// Se visitan tres páginas en secuencia
history.VisitPage("google.com");
history.VisitPage("github.com");
history.VisitPage("docs.microsoft.com");
history.PrintHistory();
