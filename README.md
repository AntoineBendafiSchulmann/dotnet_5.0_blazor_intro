# dotnet_6.0.400_blazor_intro
## Introduction au framework blazor


# un framework utilisé pour les interfaces côté client

## Ce projet à pour but :

- organiser les composants  et leurs intéractions avec l'utilisateurs et leurs données
- concevoir une application simple page en précisant son routage  en gérant les évènements + cycle de vie des composants
+ formulaires

## Attention :

manque compréhensions sur les NuGet (dépendances externes)

+ backend c#



## lancer un projet : 


installer .net6

https://dotnet.microsoft.com/en-us/download

sinon:

```
./dotnet-install.sh --channel 6.0 --runtime aspnetcore     

```


# verifier avec 

```
dotnet --version  

```


```
dotnet new blazorwasm -f net6.0 -o Nom projet

```   

puis lancer le déboguage


## Quelques extensions pratiques sur visual studio code :

# .NET Extension Pack
# .NET Install Tool for Extension Authors
# .NET Interactive Notebooks
# C#

# ressources diverses 

https://goons.fr/deploiement-sur-environnement-de-production



## mémo

1- définition 

le web fonctionne de la manière suivante , lorsque l'utilisateur demande une page cette dernière lui est renvoyée, lorsque l'on clique sur un lien la page disparait , la suivante apparait après un temps d'attente ce qui dégrade l'expérience utilisateur. Language utilisé par touts les navigateurs , le javascript est utile pour les intéractions
sur la page seulement plus les intéractions sont nombreuses plus il y a de code à écrire et maintenir. C'est pour cela qu'on été créés des bibliothèques frontales basées sur les composants (Angular, vue, react).Mais il existe aussi des languages fortement typés et compilés basés sur c# , (chose n'existant pas pour javascript).

c'est pour cela qu'a été créé 

Blazor Server

l'utilisateur vas demander une page qui lui est envoyée , pour permettre des interactions rapides en c# un websocket est ouvert entre le navigateur et le serveur . dans cette connexion permanente, le navigateur enverra les interactions au serveur qui construiras en c# coté serveur des résultats en html qui seront après remplacés dans la page par un petit code javascript qui est toujours le même. Cela assure une stabilité de la connexion mais empêche tout travail déconnecté.

Depuis quelques années tout les navigateurs disposent d'un moyen standardisé w3c d'executer du code compillé Webassembly
Il existe donc une version de blazor depuis 2020, utilisant webassembly appelé 

Blazor WebAssembly

il fonctionne comme Blazor Server à ceci près qu'en plus des feuilles de style et des images la page charge un .Net Wasm  le noyau d'execution .Net codé en webassembly qui serviras à exécuter le code c# compilé qui est ensuite chargé en fichiers dll . les interactions sont ensuite traités coté client par le code c# compilé, aussi rapidement que pour du javascript et ce même si la connexion au serveur est rompue . Blazor Server est donc de moins en moins utilisé.



2-prise en main

mémo (au cas où)

Si l'on veut absolument disposer d'une partie serveur à la création du projet Blazor WebAssembly, quelle option doit-on cocher dans Visual Studio ?

ASP.NET Core Hosted

Grâce à cette option, l'application Blazor WebAssembly sera distribuée par la partie serveur générée. Vous pourrez ensuite la personnaliser.


Quel élément syntaxique trouve-t-on dans un layout, que l'on ne trouve pas dans les autres composants Blazor ?

C'est dans le `@Body` que seront rendues les pages utilisant le layout.


Pour afficher la propriété Nom d'une liste d'acteurs stockée dans une collection Distribution, quel code choisissez -vous ?

@foreach(var acteur in Distribution) { <li>@acteur.Nom</li> }

La variable `acteur` reçoit tour à tour chaque acteur présent dans Distribution et l'expression `@acteur.Nom` accède à la propriété.

Quel type est-il impossible de « binder » à un champ input de type texte ?

Les classes comme StringBuilder, en général, ne peuvent pas être « bindées » sauf si vous fournissez une implémentation de `TypeConverter`.


Sur une calculatrice en Blazor, quel code utiliseriez-vous pour gérer le clic sur la touche 7 ?

@onclick='e=>Touche(7)'

Le @ est nécessaire si le code à appeler est du C# (JavaScript sinon). L'argument 7 impose l'usage d'une lambda.

en JavaScript c'est sans le @ 

Quel est l'en-tête le plus complet d'un layout intégré au site ?

@inherits LayoutComponentBase @layout MainLayout

3 - Intégration de JavaScript

fichier script ds wwww root a appeler ds le fichier html

src: https://code-maze.com/how-to-call-javascript-code-from-net-blazor-webassembly/

