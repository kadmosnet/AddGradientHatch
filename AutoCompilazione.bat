@echo off

echo Compilazione di AddGradientHatch release in modalita' batch

if "%PROCESSOR_ARCHITECTURE%" == "AMD64" "%ProgramFiles(x86)%\Microsoft Visual Studio\2017\Community\Common7\IDE\devenv" /Build Release AddGradientHatch.sln


pause