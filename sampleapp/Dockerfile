# Publish application
FROM registry.access.redhat.com/ubi8/dotnet-80:latest AS build-env
USER 0
ENV HOME=/home/build
WORKDIR /src
COPY . ./
RUN dotnet restore .
RUN dotnet publish --no-restore -c Release -o /rootfs/app .
RUN chown -R 1001:0 /rootfs/app && chmod -R g=u /rootfs/app

# Build application image
FROM registry.access.redhat.com/ubi8/dotnet-80-runtime:latest
COPY --from=build-env /rootfs /
ENV ASPNETCORE_URLS=http://*:8080
WORKDIR /app
ENTRYPOINT ["dotnet", "/app/sampleapp.dll"]
