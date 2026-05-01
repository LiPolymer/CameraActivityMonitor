using CommunityToolkit.Mvvm.ComponentModel;

namespace CameraActivityMonitor.Models
{
    public partial class Settings : ObservableObject
    {
        [ObservableProperty]
        private CameraDeviceInfo? _selectedCamera;

        [ObservableProperty]
        private bool _autoStart = true;
    }
}
