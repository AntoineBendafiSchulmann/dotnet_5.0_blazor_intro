// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace VoyagesFront.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/antoinebendafi/Sites/localhost/dotnet_6.0.400_blazor_intro/VoyagesFront/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/antoinebendafi/Sites/localhost/dotnet_6.0.400_blazor_intro/VoyagesFront/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/antoinebendafi/Sites/localhost/dotnet_6.0.400_blazor_intro/VoyagesFront/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/antoinebendafi/Sites/localhost/dotnet_6.0.400_blazor_intro/VoyagesFront/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/antoinebendafi/Sites/localhost/dotnet_6.0.400_blazor_intro/VoyagesFront/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/antoinebendafi/Sites/localhost/dotnet_6.0.400_blazor_intro/VoyagesFront/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/antoinebendafi/Sites/localhost/dotnet_6.0.400_blazor_intro/VoyagesFront/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/antoinebendafi/Sites/localhost/dotnet_6.0.400_blazor_intro/VoyagesFront/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/antoinebendafi/Sites/localhost/dotnet_6.0.400_blazor_intro/VoyagesFront/_Imports.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/antoinebendafi/Sites/localhost/dotnet_6.0.400_blazor_intro/VoyagesFront/_Imports.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/antoinebendafi/Sites/localhost/dotnet_6.0.400_blazor_intro/VoyagesFront/_Imports.razor"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/antoinebendafi/Sites/localhost/dotnet_6.0.400_blazor_intro/VoyagesFront/_Imports.razor"
using VoyagesFront;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/antoinebendafi/Sites/localhost/dotnet_6.0.400_blazor_intro/VoyagesFront/_Imports.razor"
using VoyagesFront.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/Users/antoinebendafi/Sites/localhost/dotnet_6.0.400_blazor_intro/VoyagesFront/_Imports.razor"
using Voyages;

#line default
#line hidden
#nullable disable
    public partial class Passagers : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "/Users/antoinebendafi/Sites/localhost/dotnet_6.0.400_blazor_intro/VoyagesFront/Shared/Passagers.razor"
       

    private uint Nbpassagers 
    { 
        get => Nombre;
        set
        {
            Nombre = value;
            NombreChanged.InvokeAsync(value);
        } 
    }
    [Parameter]
    public uint Nombre 
    { 
        get; set; 
    }
    [Parameter]
    public EventCallback<uint> NombreChanged 
    { 
        get; set; 
    }



#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
