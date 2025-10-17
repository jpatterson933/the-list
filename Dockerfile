WORKDIR /app

COPY *.csproj ./
RUN dotnet restore

COPY . ./
RUN dotnet publish -c Release -o out

WORKDIR /app
COPY --from=build /app/out .

ENV ASPNETCORE_URLS=http://+:$PORT

ENTRYPOINT ["dotnet", "LaAdventuresList.dll"]
