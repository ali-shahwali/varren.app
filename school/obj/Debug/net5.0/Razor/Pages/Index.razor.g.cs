#pragma checksum "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc3b0b231aa971177310330477b08ed94713e56c"
// <auto-generated/>
#pragma warning disable 1591
namespace school.Pages
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
using school;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\_Imports.razor"
using school.Shared;

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
using school.Pages;

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
using school.Pages.subcomponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\_Imports.razor"
using school.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudContainer>(0);
            __builder.AddAttribute(1, "Class", "mt-16 px-8");
            __builder.AddAttribute(2, "MaxWidth", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.MaxWidth>(
#nullable restore
#line 3 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\Index.razor"
                                           MaxWidth.False

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudGrid>(4);
                __builder2.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudItem>(6);
                    __builder3.AddAttribute(7, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 5 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\Index.razor"
                     12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(8, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 5 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\Index.razor"
                             6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(9, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 5 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\Index.razor"
                                    4

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudPaper>(11);
                        __builder4.AddAttribute(12, "Elevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 6 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\Index.razor"
                                 2

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(13, "Class", "pa-4");
                        __builder4.AddAttribute(14, "Style", "height: 200px;");
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(15, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudItem>(16);
                    __builder3.AddAttribute(17, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 8 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\Index.razor"
                     12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(18, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 8 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\Index.razor"
                             6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(19, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 8 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\Index.razor"
                                    4

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudPaper>(21);
                        __builder4.AddAttribute(22, "Elevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 9 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\Index.razor"
                                 2

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(23, "Class", "pa-4");
                        __builder4.AddAttribute(24, "Style", "height: 200px;");
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(25, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudItem>(26);
                    __builder3.AddAttribute(27, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 11 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\Index.razor"
                     12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(28, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 11 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\Index.razor"
                             12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(29, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 11 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\Index.razor"
                                     4

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudPaper>(31);
                        __builder4.AddAttribute(32, "Elevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 12 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\Index.razor"
                                 2

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(33, "Class", "pa-4");
                        __builder4.AddAttribute(34, "Style", "height: 200px;");
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(35, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudItem>(36);
                    __builder3.AddAttribute(37, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 14 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\Index.razor"
                     12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(38, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 14 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\Index.razor"
                             6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudGrid>(40);
                        __builder4.AddAttribute(41, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudItem>(42);
                            __builder5.AddAttribute(43, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 16 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\Index.razor"
                             12

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(44, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<MudBlazor.MudPaper>(45);
                                __builder6.AddAttribute(46, "Elevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 17 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\Index.razor"
                                         2

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(47, "Class", "pa-4");
                                __builder6.AddAttribute(48, "Style", "height: 200px;");
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(49, "\r\n                ");
                            __builder5.OpenComponent<MudBlazor.MudItem>(50);
                            __builder5.AddAttribute(51, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 19 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\Index.razor"
                             12

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(52, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<MudBlazor.MudPaper>(53);
                                __builder6.AddAttribute(54, "Elevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 20 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\Index.razor"
                                         2

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(55, "Class", "pa-4");
                                __builder6.AddAttribute(56, "Style", "height: 200px;");
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(57, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudItem>(58);
                    __builder3.AddAttribute(59, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 24 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\Index.razor"
                     12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(60, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 24 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\Index.razor"
                             6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(61, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 24 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\Index.razor"
                                    4

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(62, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudPaper>(63);
                        __builder4.AddAttribute(64, "Elevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 25 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\Index.razor"
                                 2

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(65, "Class", "pa-4");
                        __builder4.AddAttribute(66, "Style", "height: 200px;");
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(67, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudItem>(68);
                    __builder3.AddAttribute(69, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 27 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\Index.razor"
                     12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(70, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 27 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\Index.razor"
                             6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(71, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 27 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\Index.razor"
                                    4

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(72, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudPaper>(73);
                        __builder4.AddAttribute(74, "Elevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 28 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\Index.razor"
                                 2

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(75, "Class", "pa-4");
                        __builder4.AddAttribute(76, "Style", "height: 200px;");
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(77, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudItem>(78);
                    __builder3.AddAttribute(79, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 30 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\Index.razor"
                     12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(80, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 30 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\Index.razor"
                             12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(81, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 30 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\Index.razor"
                                     4

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(82, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudPaper>(83);
                        __builder4.AddAttribute(84, "Elevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 31 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\Index.razor"
                                 2

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(85, "Class", "pa-4");
                        __builder4.AddAttribute(86, "Style", "height: 200px;");
                        __builder4.CloseComponent();
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
