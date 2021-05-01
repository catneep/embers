using Microsoft.AspNetCore.Components;
namespace Embers{
    public partial class StyledComponent:ComponentBase
    {
        [Parameter] public string Class { get; set; } = "";
    }
}