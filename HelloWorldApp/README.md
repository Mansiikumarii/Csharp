HelloWorldApp
=============

A tiny .NET console app that prints "Hello, World!".

How to run (PowerShell):

```powershell
# from anywhere (uses the project file path)
dotnet run --project "C:\Users\mansi\OneDrive\Desktop\C#\HelloWorldApp\HelloWorldApp.csproj"

# or change directory and run
cd "C:\Users\mansi\OneDrive\Desktop\C#\HelloWorldApp"
dotnet run
```

If dotnet isn't on your PATH, run it with the full path to the SDK, for example:

```powershell
& 'C:\Program Files\dotnet\dotnet.exe' --version
& 'C:\Program Files\dotnet\dotnet.exe' run --project "C:\Users\mansi\OneDrive\Desktop\C#\HelloWorldApp\HelloWorldApp.csproj"
```
