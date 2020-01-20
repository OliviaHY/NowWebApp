FROM microsoft/dotnet:2.2-aspnetcore-runtime
WORKDIR /app

COPY src/NowWebApp/app/ .

ENTRYPOINT ["dotnet","NowWebApp.dll"]