using Ejercicio_1___Historial_de_navegacion;

BrowserHistory history = new BrowserHistory();

// Se visitan tres páginas en secuencia
history.VisitPage("google.com");
history.VisitPage("github.com");
history.VisitPage("docs.microsoft.com");
history.PrintHistory();
// >>> docs.microsoft.com (pagina actual)

// Se navega hacia atras dos veces
Console.WriteLine(history.GoBack()); // >>> github.com
Console.WriteLine(history.GoBack()); // >>> google.com
history.PrintHistory();
// >>> google.com (pagina actual)

//Se intenta ir mas atras (borde: primera pagina)
Console.WriteLine(history.GoBack());

//Se navega hacia adelante una vez
Console.WriteLine(history.GoForward()); // >>> github.com
history.PrintHistory();
// >>> github.com (pagina actual)

Console.ReadKey();
