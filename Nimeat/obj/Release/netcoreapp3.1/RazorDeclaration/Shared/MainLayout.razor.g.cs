// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Nimeat.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Taemin.K\source\repos\Nimeat\Nimeat\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Taemin.K\source\repos\Nimeat\Nimeat\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Taemin.K\source\repos\Nimeat\Nimeat\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Taemin.K\source\repos\Nimeat\Nimeat\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Taemin.K\source\repos\Nimeat\Nimeat\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Taemin.K\source\repos\Nimeat\Nimeat\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Taemin.K\source\repos\Nimeat\Nimeat\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Taemin.K\source\repos\Nimeat\Nimeat\_Imports.razor"
using Nimeat;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Taemin.K\source\repos\Nimeat\Nimeat\_Imports.razor"
using Nimeat.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Taemin.K\source\repos\Nimeat\Nimeat\_Imports.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Taemin.K\source\repos\Nimeat\Nimeat\_Imports.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Taemin.K\source\repos\Nimeat\Nimeat\_Imports.razor"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Taemin.K\source\repos\Nimeat\Nimeat\_Imports.razor"
using Nimeat.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Taemin.K\source\repos\Nimeat\Nimeat\_Imports.razor"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "C:\Users\Taemin.K\source\repos\Nimeat\Nimeat\Shared\MainLayout.razor"
      
    public void Logout() {
        ((CustomAuthenticationStateProvider)AuthenticationStateProvider).MarkUserAsLoggedOut();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStringLocalizer<App> Localizer { get; set; }
    }
}
#pragma warning restore 1591
