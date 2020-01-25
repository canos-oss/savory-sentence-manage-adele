FROM mcr.microsoft.com/dotnet/core/sdk:3.0 AS DOTNET_CORE_TOOL_CHAIN

COPY ./ /tmp/

WORKDIR /tmp/SavorySenteceManage

RUN dotnet publish -c Release


FROM mcr.microsoft.com/dotnet/core/aspnet:3.0

MAINTAINER harriszhang@live.cn

COPY --from=DOTNET_CORE_TOOL_CHAIN /tmp/SavorySenteceManage/bin/Release/netcoreapp3.0/publish /app

WORKDIR /app

ENTRYPOINT ["dotnet", "Savory.SentenceManage.dll"]