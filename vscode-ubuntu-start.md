# Démarrer un projet C# avec la console de vscode

## Créer le projet

```dotnet new console```

"console" est le keyword pour le projet de type simple programme exécuté en console. Vois la liste dans Visual Studio pour les noms de projets existants si besoin.

Par défaut dans le projectInitTemplate, le program.cs est totalement vide à par un console write... Il manque le boilerplate code. Erreur de config de ma part ? A investiguer, mais étrange.

```namespace ProjectInitTemplate{class Program{static void Main(string[] args){Console.WriteLine("Hello, World!");}}}```

Pour une raison, vsode ne veut pas voir "System" référencé en haut de code. Peut tre déjà inclus dans dotnet 6 dans ubuntu ? à voir comment Visual Studio réagit sous windows.

## Run le programme

```dotnet run```

## Problème

Cela fonctionne dans vscode Ubuntu, mais si j'importe tout cela sur windows avec Visual Studio, alors je reçois l'exception suivante:

'Une exception non gérée du type 'System.IO.FileNotFoundException' s'est produite dans Module inconnu.
Impossible de charger le fichier ou l'assembly 'System.Runtime, Version=6.0.0.0, Culture=neutral, PublicKeyToken=##########' ou une de ses dépendances. Le fichier spécifié est introuvable.'

\\###### car je ne sais pas si la publicKey ici est critique.

Je constate que si j'exécute sans débogage, la console me retourne cette erreur:
error NETSDK1045: Le kit .NET SDK actuel ne prend pas en charge le ciblage de .NET 6.0. Vous devez soit cibler .NET 5.0 ou une version antérieure, soit utiliser une version du kit .NET SDK qui prend en charge .NET 6.0.

Donc j'ai installé dotnet 6, mais il n'est pas utlisé par défaut ?
https://docs.microsoft.com/en-us/dotnet/core/versions/selection
"dotnet uses the latest installed SDK if no global.json is found." -> mensonge donc :)

J'ai mis un global.json, mais toujours rien.

J'ai update le fichier app.config de visual Studio qui spécifie d'utiliser la v4. -> toujours pas (j'ai redémarré VS)

BON, je vire VS 2019 et j'installe VS 2022. C'est pas mal comme plan non ? (franchement ça aurait pu faire la mise à jour au lieu d'installer la version la plus récente de 2019 ...)

En attendant, VS code Windows a détécté un fichier init manquant et l'a ajouté. La compilation fonctionne...
VS 2022 fonctionne sans faire d'histoires...

Bon. Vérifier les mises à jour de VS chaque année -.- Le setup est prêt et fonctionnel pour alterner entre toutes les plateformes... KA ?