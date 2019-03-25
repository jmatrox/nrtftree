"C:\Program Files (x86)\NuGet\nuget.exe" pack nrtftree-library.nuspec
copy /Y nrtftree-library*.nupkg \\nas01\Rilasci\NuGet
del nrtftree-library*.nupkg
pause