using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using StjerneDuggen.Domain;

namespace StjerneDuggen.Components;

public partial class NavigationMenu : ComponentBase, IAsyncDisposable
{
    private string navClass = "nav-menu nav-large";
    private DotNetObjectReference<NavigationMenu>? _objRef;
    [Inject] private IJSRuntime JS { get; set; } = default!;
    [Inject] private NavigationManager Navigation { get; set; } = default!;

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            _objRef = DotNetObjectReference.Create(this);
            await JS.InvokeVoidAsync("navScroll.init", _objRef);
            await JS.InvokeVoidAsync("setNavHeightVar", "12vh"); // initialize
        }
    }

    private bool IsMenuOpen;

    private List<NavEntryWithSubEntries> NavigationEntries = new List<NavEntryWithSubEntries>()
    {
        new NavEntryWithSubEntries(new NavigationEntry("Pædagogiske Tanker", "thoughts"), null),
        new NavEntryWithSubEntries(new NavigationEntry("Vores hverdag", "routine"), null),
        new NavEntryWithSubEntries(new NavigationEntry("Omgivelser", null),
            new List<NavigationEntry>()
            {
                new NavigationEntry("Inde", "inside"),
                new NavigationEntry("Ude", "outside")
            }),
        new NavEntryWithSubEntries(new NavigationEntry("Finansiering", "finance"), null),
        new NavEntryWithSubEntries(new NavigationEntry("Indskrivning", "registration"), null),
        new NavEntryWithSubEntries(new NavigationEntry("Praktisk info", "practical"), null),
    };

    private void NavigateHome()
    {
        CloseMenu();
        Navigation.NavigateTo("/");
    }

    [JSInvokable]
    public async Task OnWindowScroll(double scrollY)
    {
        if (scrollY > 50 && navClass != "nav-menu nav-small")
        {
            navClass = "nav-menu nav-small";
            await JS.InvokeVoidAsync("setNavHeightVar", "6vh");
            await InvokeAsync(StateHasChanged);
        }
        else if (scrollY <= 50 && navClass != "nav-menu nav-large")
        {
            navClass = "nav-menu nav-large";
            await JS.InvokeVoidAsync("setNavHeightVar", "12vh");
            await InvokeAsync(StateHasChanged);
        }
    }

    [JSInvokable]
    public Task CloseMenu()
    {
        IsMenuOpen = false;
        StateHasChanged();
        return Task.CompletedTask;
    }

    private async void ToggleMenu()
    {
        IsMenuOpen = !IsMenuOpen;

        if (IsMenuOpen)
            await JS.InvokeVoidAsync("navClick.addOutsideClickListener", DotNetObjectReference.Create(this));
        else
            await JS.InvokeVoidAsync("navClick.removeOutsideClickListener");

        StateHasChanged();
    }

    public async ValueTask DisposeAsync()
    {
        if (_objRef is not null)
        {
            await JS.InvokeVoidAsync("navScroll.cleanup");
            await JS.InvokeVoidAsync("navClick.removeOutsideClickListener");
            _objRef.Dispose();
        }
    }

    public record NavEntryWithSubEntries(NavigationEntry NavigationEntry, List<NavigationEntry>? SubEntries);
}