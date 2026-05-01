namespace CameraActivityMonitor.Models;

public sealed class CameraDeviceInfo
{
    public required string Id { get; init; }
    public required string Name { get; init; }

    public override string ToString()
    {
        return Name;
    }
}