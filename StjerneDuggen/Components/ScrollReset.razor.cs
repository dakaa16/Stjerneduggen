using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace StjerneDuggen.Components
{
    public partial class ScrollReset : ComponentBase
    {
        [Inject] private IJSRuntime JS { get; set; } = default!;

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (!firstRender)
            {
                return;
            }

            await JS.InvokeVoidAsync("scrollReset.resetToTop");
        }
    }
}
