#pragma checksum "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\IK1203.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0645e04601d46e3b4ada84b62ef59f4d37e4e93c"
// <auto-generated/>
#pragma warning disable 1591
namespace varren.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\_Imports.razor"
using varren;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\_Imports.razor"
using varren.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\_Imports.razor"
using varren.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\_Imports.razor"
using varren.Pages.subcomponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\_Imports.razor"
using varren.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/IK1203")]
    public partial class IK1203 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudTabs>(0);
            __builder.AddAttribute(1, "Elevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 3 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\IK1203.razor"
                    4

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "Centered", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 3 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\IK1203.razor"
                                 true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 3 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\IK1203.razor"
                                               Color.Primary

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTabPanel>(5);
                __builder2.AddAttribute(6, "Text", "Tentor");
                __builder2.AddAttribute(7, "ToolTip", "ToolTip One");
                __builder2.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<varren.Pages.subcomponents.Tentor_IK1203>(9);
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(10, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudTabPanel>(11);
                __builder2.AddAttribute(12, "Text", "Övningar");
                __builder2.AddAttribute(13, "ToolTip", "ToolTip Two");
                __builder2.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<varren.Pages.subcomponents.Övningar_IK1203>(15);
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudTabPanel>(17);
                __builder2.AddAttribute(18, "Text", "Labbar");
                __builder2.AddAttribute(19, "ToolTip", "ToolTip Three");
                __builder2.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudText>(21);
                    __builder3.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(23, "Labbar");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDialogService DialogService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar Snackbar { get; set; }
    }
}
#pragma warning restore 1591