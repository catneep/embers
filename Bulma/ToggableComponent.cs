using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace Embers.Bulma{
    public partial class ToggableComponent:ComponentBase{
        [Parameter] public string Class { get; set; } = "";
        protected string Status = String.Empty;
        protected async Task toggleState(){
            await Task.Delay(10);
            if (Status == String.Empty)
                Status = "is-active";
            else
                Status = String.Empty;
            StateHasChanged();
        }
    }
}