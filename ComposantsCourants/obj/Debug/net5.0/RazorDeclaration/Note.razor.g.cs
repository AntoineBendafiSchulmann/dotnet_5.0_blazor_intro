// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ComposantsCourants
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/antoinebendafi/Sites/localhost/dotnet_6.0.400_blazor_intro/ComposantsCourants/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
    public partial class Note : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 5 "/Users/antoinebendafi/Sites/localhost/dotnet_6.0.400_blazor_intro/ComposantsCourants/Note.razor"
       
    [Parameter]
    public int NbEtoiles { get; set; } = 5;

    [Parameter]
    public int Hauteur { get; set; } = 15;

    [Parameter]
    public string Unite { get; set; } = "px";

    [Parameter]
    public double Valeur { get; set; } = 2.5;

    private string ValeurUnite => $"{(int)(Valeur * (double)Largeur / (double)NbEtoiles)}{Unite}";

    public int Largeur => Hauteur * NbEtoiles;

    public string LargeurUnite => $"{Largeur}{Unite}";
    public string HauteurUnite => $"{Hauteur}{Unite}";

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
