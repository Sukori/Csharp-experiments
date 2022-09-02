# Démarrer un projet C# avec la console de vscode

## Créer le projet

```dotnet new console```

"console" est le keyword pour le projet de type simple programme exécuté en console. Vois la liste dans Visual Studio pour les noms de projets existants si besoin.

Par défaut dans le projectInitTemplate, le program.cs est totalement vide à par un console write... Il manque le boilerplate code. Erreur de config de ma part ? A investiguer, mais étrange.

```namespace ProjectInitTemplate{class Program{static void Main(string[] args){Console.WriteLine("Hello, World!");}}}```

Pour une raison, vsode ne veut pas voir "System" référencé en haut de code. Peut tre déjà inclus dans dotnet 6 dans ubuntu ? à voir comment Visual Studio réagit sous windows.

## Run le programme

```dotnet run```