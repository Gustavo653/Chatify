﻿dotnet restore --Rodar antes de qualquer comando scaffold
Microsoft.NETCore.App
Microsoft.EntityFrameworkCore.Tools
Microsoft.EntityFrameworkCore.Design


Para criar migration:
dotnet ef migrations add Initial -p Chatify.Persistence -s Chatify.API -c ChatifyContext --verbose