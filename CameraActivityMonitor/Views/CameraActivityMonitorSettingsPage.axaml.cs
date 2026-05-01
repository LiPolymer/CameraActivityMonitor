using ClassIsland.Core.Abstractions.Controls;
using ClassIsland.Core.Attributes;
using ClassIsland.Core.Enums.SettingsWindow;

namespace CameraActivityMonitor;

[SettingsPageInfo(
    "CameraActivityMonitorSettingsPage",   // 设置页面 id
    "CameraActivityMonitor",  // 设置页面名称
    "\uE392",   // 未选中时设置页面图标
    "\uE391",  // 选中时设置页面图标
    SettingsPageCategory.External  // 设置页面类别
)]
public partial class CameraActivityMonitorSettingsPage : SettingsPageBase
{
    private readonly SettingsPageViewModel _viewModel;

    public CameraActivityMonitorSettingsPage(SettingsPageViewModel viewModel)
    {
        InitializeComponent();
        _viewModel = viewModel;
        DataContext = _viewModel;
        Loaded += async (_, _) => await _viewModel.InitializeAsync();
    }
}