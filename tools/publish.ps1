if (Test-Path -Path "./CameraActivityMonitor/bin") {
    Remove-Item ./CameraActivityMonitor/bin -recurse
}
dotnet publish -c Release -p:CreateCipx=true
