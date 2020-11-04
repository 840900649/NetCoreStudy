#FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster AS base
FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY *.csproj ./src/

#自定义第三方源
#RUN dotnet nuget add source http://nexus.adq.xin -n nuget.org
RUN dotnet restore
COPY . ./
RUN dotnet publish -c release  -o out

#FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS runtime
EXPOSE 80
WORKDIR /app
COPY --from=build /src/out ./
ENTRYPOINT ["dotnet", "DevopsBase.dll"]