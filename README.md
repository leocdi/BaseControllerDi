# BaseControllerDi

Exemple d'obtention de service via la méthode `HttpContext.RequestServices.GetService<T>`

### Avantages

Permet d'hériter d'un controller de base contenant des services accessibles sans avoir a injecter les services dans les controllers enfants.

### Inconvénients

Si HttpContext n'est pas accessible l'accès au service ne sera pas possible.