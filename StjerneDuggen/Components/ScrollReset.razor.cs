using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace StjerneDuggen.Components
{
    public partial class ScrollReset : ComponentBase
    {
        [Inject] private IJSRuntime JS { get; set; }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
                await JS.InvokeVoidAsync("window.scrollTo", 0, 0);
        }
    }
}
