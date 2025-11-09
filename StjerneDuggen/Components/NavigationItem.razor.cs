using Microsoft.AspNetCore.Components;
using StjerneDuggen.Domain;

namespace StjerneDuggen.Components
{
    public partial class NavigationItem : ComponentBase
    {
        [Parameter] public NavigationEntry Item { get; set; } = default!;
        [Parameter] public List<NavigationEntry>? SubItems { get; set; }
        [Parameter] public EventCallback OnItemClicked { get; set; }

        [Inject] private NavigationManager Navigation { get; set; } = default!;

        private bool showDropdown = false;

        private async void Navigate()
        {
            if (Item != null && !string.IsNullOrEmpty(Item.Href))
            {
                Navigation.NavigateTo(Item.Href);
                await OnItemClicked.InvokeAsync();
            }
        }

        private async void NavigateTo(string href)
        {
            if (!string.IsNullOrEmpty(href))
            {
                Navigation.NavigateTo(href);
                await OnItemClicked.InvokeAsync();
            }
            showDropdown = false;
        }
    }
}
