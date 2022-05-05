using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace BlazorAppGuide.Client.Pages
{
    public partial class Counter
    {
        [Inject] IJSRuntime js { get; set; }

        IJSObjectReference module;

        private int currentCount = 0;
        private static int currentCountStatic = 0; // para el ejemplo de como invocar metodos estaticos desde js

        [JSInvokable]
        public async Task IncrementCount()
        {
            module = await js.InvokeAsync<IJSObjectReference>("import", "./js/Counter.js");
            await module.InvokeVoidAsync("showAlert", "Hello world"); //dejar en claro que hacemos uso de la funcion a traves del module y no de la instancia del JSRuntime

            currentCount++;
            currentCountStatic = currentCount;

            await js.InvokeVoidAsync("DotNetStaticMethodTest");
        }

        private async Task IncrementCountJavascript()
        {
            await js.InvokeVoidAsync("DotNetInstanceMethodTest", DotNetObjectReference.Create(this));
        }

        [JSInvokable]
        public static Task<int> GetCurrentCount()
        {
            return Task.FromResult(currentCountStatic);
        }
    }
}
