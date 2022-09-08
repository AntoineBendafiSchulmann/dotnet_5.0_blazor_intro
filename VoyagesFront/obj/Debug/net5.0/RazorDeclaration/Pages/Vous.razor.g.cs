// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace VoyagesFront.Pages
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
#nullable restore
#line 3 "/Users/antoinebendafi/Sites/localhost/dotnet_6.0.400_blazor_intro/VoyagesFront/Pages/Vous.razor"
using System.Text;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/vous")]
    public partial class Vous : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "/Users/antoinebendafi/Sites/localhost/dotnet_6.0.400_blazor_intro/VoyagesFront/Pages/Vous.razor"
       
    private Sejour sejour = new Sejour(DateTime.Now.Date + TimeSpan.FromDays(7));

    private string TexteDuree()
    {
        (string terminaison, string pluriel) = (sejour.Duree.TotalDays == 1) ? ("t", "") : ("ent", "s");
        return $"soient {sejour.Duree.TotalDays} jour{pluriel}";
        
    }

    private string Resume 
    {
        get
        {
            StringBuilder sb = new StringBuilder("Bienvenue");

            if (sejour.Nom.Length>0)
            {
                sb.Append($" {sejour.Prenom}");
            }
            sb.Append($", nous vous attendons pour un séjour inoubliable");
            if (sejour.Nbpassagers == 2)
            {
                sb.Append(", vous et la personne qui vous accompagne");
            }
            else if (sejour.Nbpassagers > 2)
            {
                sb.Append(" avec votre \"tribu\"");
            }
            sb.Append(".");
            return sb.ToString();

            
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
