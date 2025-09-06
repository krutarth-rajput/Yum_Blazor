using Microsoft.JSInterop;

namespace YumBlazor.Services.Extensions
{
    public static class IJSRuntimeExtensions
    {

        public static async Task ToastrSuccess(this IJSRuntime jsRuntime, string message) {
            jsRuntime.InvokeVoidAsync("ShowToastr","success", message);
        }

        public static async Task ToastrFailure(this IJSRuntime jsRuntime, string message)
        {
            jsRuntime.InvokeVoidAsync("ShowToastr","error", message);
        }
    }
}
