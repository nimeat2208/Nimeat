#pragma checksum "C:\Users\tmkim\Source\Repos\nimeat2208\Nimeat\Nimeat\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1db5dd852c6763964af7f5349c7d2ebe9356737f"
// <auto-generated/>
#pragma warning disable 1591
namespace Nimeat.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\tmkim\Source\Repos\nimeat2208\Nimeat\Nimeat\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tmkim\Source\Repos\nimeat2208\Nimeat\Nimeat\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\tmkim\Source\Repos\nimeat2208\Nimeat\Nimeat\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\tmkim\Source\Repos\nimeat2208\Nimeat\Nimeat\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\tmkim\Source\Repos\nimeat2208\Nimeat\Nimeat\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\tmkim\Source\Repos\nimeat2208\Nimeat\Nimeat\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\tmkim\Source\Repos\nimeat2208\Nimeat\Nimeat\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\tmkim\Source\Repos\nimeat2208\Nimeat\Nimeat\_Imports.razor"
using Nimeat;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\tmkim\Source\Repos\nimeat2208\Nimeat\Nimeat\_Imports.razor"
using Nimeat.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\tmkim\Source\Repos\nimeat2208\Nimeat\Nimeat\_Imports.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\tmkim\Source\Repos\nimeat2208\Nimeat\Nimeat\_Imports.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\tmkim\Source\Repos\nimeat2208\Nimeat\Nimeat\_Imports.razor"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\tmkim\Source\Repos\nimeat2208\Nimeat\Nimeat\_Imports.razor"
using Nimeat.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\tmkim\Source\Repos\nimeat2208\Nimeat\Nimeat\_Imports.razor"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 id=\"logo\"><a href>Nimeat</a></h1>\r\n\r\n");
            __builder.OpenElement(1, "nav");
            __builder.AddAttribute(2, "id", "nav");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "ul");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "li");
            __builder.AddMarkupContent(7, "\r\n            ");
            __builder.OpenComponent<Nimeat.Shared.LanguageComboBox>(8);
            __builder.CloseComponent();
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.OpenElement(11, "li");
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(13);
            __builder.AddAttribute(14, "href", "");
            __builder.AddAttribute(15, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 13 "C:\Users\tmkim\Source\Repos\nimeat2208\Nimeat\Nimeat\Shared\NavMenu.razor"
                                    NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(17, "\r\n                ");
                __builder2.AddContent(18, 
#nullable restore
#line 14 "C:\Users\tmkim\Source\Repos\nimeat2208\Nimeat\Nimeat\Shared\NavMenu.razor"
                 Localizer["Home"]

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(19, "\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n        ");
            __builder.OpenElement(22, "li");
            __builder.AddMarkupContent(23, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(24);
            __builder.AddAttribute(25, "href", "lettercounter");
            __builder.AddAttribute(26, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(27, "\r\n                ");
                __builder2.AddContent(28, 
#nullable restore
#line 19 "C:\Users\tmkim\Source\Repos\nimeat2208\Nimeat\Nimeat\Shared\NavMenu.razor"
                 Localizer["Letter Counter"]

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(29, "\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(30, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(32);
            __builder.AddAttribute(33, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(34, "\r\n                ");
                __builder2.OpenElement(35, "li");
                __builder2.AddMarkupContent(36, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(37);
                __builder2.AddAttribute(38, "href", "counter");
                __builder2.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(40, "\r\n                        ");
                    __builder3.AddContent(41, 
#nullable restore
#line 26 "C:\Users\tmkim\Source\Repos\nimeat2208\Nimeat\Nimeat\Shared\NavMenu.razor"
                         Localizer["Counter"]

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(42, "\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(43, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n                ");
                __builder2.OpenElement(45, "li");
                __builder2.AddMarkupContent(46, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(47);
                __builder2.AddAttribute(48, "href", "fetchdata");
                __builder2.AddAttribute(49, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(50, "\r\n                        ");
                    __builder3.AddContent(51, 
#nullable restore
#line 31 "C:\Users\tmkim\Source\Repos\nimeat2208\Nimeat\Nimeat\Shared\NavMenu.razor"
                         Localizer["Fetch data"]

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(52, "\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(53, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n                ");
                __builder2.OpenElement(55, "li");
                __builder2.AddMarkupContent(56, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(57);
                __builder2.AddAttribute(58, "href", "mousemgmt");
                __builder2.AddAttribute(59, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(60, "\r\n                        ");
                    __builder3.AddContent(61, 
#nullable restore
#line 36 "C:\Users\tmkim\Source\Repos\nimeat2208\Nimeat\Nimeat\Shared\NavMenu.razor"
                         Localizer["Mouse Management"]

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(62, "\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(63, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n                ");
                __builder2.OpenElement(65, "li");
                __builder2.OpenElement(66, "a");
                __builder2.AddAttribute(67, "href", "login");
                __builder2.AddAttribute(68, "class", "button primary");
                __builder2.AddAttribute(69, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "C:\Users\tmkim\Source\Repos\nimeat2208\Nimeat\Nimeat\Shared\NavMenu.razor"
                                                                     (() => Logout())

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(70, 
#nullable restore
#line 39 "C:\Users\tmkim\Source\Repos\nimeat2208\Nimeat\Nimeat\Shared\NavMenu.razor"
                                                                                        Localizer["Logout"]

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\r\n            ");
            }
            ));
            __builder.AddAttribute(72, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(73, "\r\n                ");
                __builder2.OpenElement(74, "li");
                __builder2.OpenElement(75, "a");
                __builder2.AddAttribute(76, "href", "login");
                __builder2.AddAttribute(77, "class", "button primary");
                __builder2.AddContent(78, 
#nullable restore
#line 42 "C:\Users\tmkim\Source\Repos\nimeat2208\Nimeat\Nimeat\Shared\NavMenu.razor"
                                                            Localizer["Login"]

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(79, "\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(80, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "C:\Users\tmkim\Source\Repos\nimeat2208\Nimeat\Nimeat\Shared\NavMenu.razor"
      
    public void Logout()
    {
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
