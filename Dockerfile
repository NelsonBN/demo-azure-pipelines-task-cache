FROM mcr.microsoft.com/dotnet/aspnet:7.0.0

EXPOSE 80
WORKDIR /app

COPY ./src/Demo.Api/bin/publish .

ENTRYPOINT ["dotnet", "Demo.Api.dll"]
