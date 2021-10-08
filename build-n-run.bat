@echo off
echo Building...
echo ---------------------------------------
dotnet build -c Release -r win-x64
echo Running built program
echo ---------------------------------------
.\bin\Release\net5.0\win-x64\sorting-algorithms.exe