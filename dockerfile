FROM microsoft/dotnet:sdk AS build-env
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY ./Admin.Dashboard.sln ./nuget.config ./
COPY ./Admin.Dashboard.Models/Admin.Dashboard.Models.csproj ./Admin.Dashboard.Models/Admin.Dashboard.Models.csproj
COPY ./Admin.Dashboard.Service/Admin.Dashboard.Service.csproj ./Admin.Dashboard.Service/Admin.Dashboard.Service.csproj
RUN dotnet restore

# Copy everything else and build
COPY . ./
RUN dotnet publish "./Admin.Dashboard.Service/Admin.Dashboard.Service.csproj" -c Release -o "../out" --no-restore

# Build runtime image
FROM microsoft/dotnet:aspnetcore-runtime
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "Admin.Dashboard.Service.dll"]