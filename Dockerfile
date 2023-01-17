FROM mcr.microsoft.com/dotnet/sdk:6.0
WORKDIR /teste
COPY . .
RUN dotnet restore
CMD ["dotnet", "test"]