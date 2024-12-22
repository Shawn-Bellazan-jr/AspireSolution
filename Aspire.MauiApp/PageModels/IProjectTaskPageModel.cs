using Aspire.MauiApp.Models;
using CommunityToolkit.Mvvm.Input;

namespace Aspire.MauiApp.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}