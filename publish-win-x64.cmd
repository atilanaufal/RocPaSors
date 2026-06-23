@echo off
setlocal

dotnet publish RocPaSors.csproj -c Release -r win-x64 --self-contained true -p:PublishSingleFile=false -o publish\win-x64

echo.
echo Publish selesai. Jalankan publish\win-x64\RocPaSors.exe
echo Copy seluruh folder publish\win-x64 kalau mau dipindah ke komputer lain.
pause
