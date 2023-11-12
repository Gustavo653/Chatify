# Introdução 
Chatify API

# Como executar o projeto?
docker run -d --name postgresql --restart always -e POSTGRES_PASSWORD=UL^q^84Vcm83fYdgGdZu -v /usr/postgresql:/var/lib/postgresql/data -p 5432:5432 postgres:latest

# Como criar uma migration?
dotnet ef migrations add Initial -p Chatify.Persistence -s Chatify.API -c ChatifyContext --verbose
