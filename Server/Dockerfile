FROM microsoft/aspnetcore-build as builder
WORKDIR /src
COPY . .
WORKDIR /src/Evo.Web.Api
RUN dotnet restore --packages ./output && dotnet publish --configuration Release --output ./output

FROM microsoft/aspnetcore:2.0 as host
WORKDIR /app
EXPOSE 80
COPY --from=builder /src/Evo.Web.Api/output .
ENTRYPOINT ["dotnet", "Evo.Web.Api.dll"]

