#pragma checksum "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\SkapaKod.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aadbf2fed97014c1824981b397f0cc686a30334a"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/skapa_kod")]
    public partial class SkapaKod : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudContainer>(0);
            __builder.AddAttribute(1, "Class", "mt-16");
            __builder.AddAttribute(2, "MaxWidth", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.MaxWidth>(
#nullable restore
#line 5 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\SkapaKod.razor"
                                      MaxWidth.Large

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(4);
                __builder2.AddAttribute(5, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 6 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\SkapaKod.razor"
                      kod

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(6, "OnSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 6 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\SkapaKod.razor"
                                     OnSubmit

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(8);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(9, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudGrid>(10);
                    __builder3.AddAttribute(11, "Spacing", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 8 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\SkapaKod.razor"
                          6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(12, "Class", "mt-16");
                    __builder3.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudItem>(14);
                        __builder4.AddAttribute(15, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 9 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\SkapaKod.razor"
                         3

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudText>(17);
                            __builder5.AddAttribute(18, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 10 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\SkapaKod.razor"
                               Typo.h5

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(19, "GutterBottom", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 10 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\SkapaKod.razor"
                                                      true

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(21, "Skapa kod");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(22, "\r\n                ");
                            __builder5.OpenComponent<MudBlazor.MudGrid>(23);
                            __builder5.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<MudBlazor.MudItem>(25);
                                __builder6.AddAttribute(26, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 12 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\SkapaKod.razor"
                                 12

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.OpenComponent<MudBlazor.MudSelect<string>>(28);
                                    __builder7.AddAttribute(29, "Label", "Kursnamn");
                                    __builder7.AddAttribute(30, "For", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<string>>>(
#nullable restore
#line 13 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\SkapaKod.razor"
                                                                                                 () => kod.Kursnamn

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(31, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 13 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\SkapaKod.razor"
                                                           kod.Kursnamn

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(32, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<string>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => kod.Kursnamn = __value, kod.Kursnamn))));
                                    __builder7.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder8) => {
                                        __Blazor.school.Pages.SkapaKod.TypeInference.CreateMudSelectItem_0(__builder8, 34, 35, 
#nullable restore
#line 14 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\SkapaKod.razor"
                                                    "ID1019"

#line default
#line hidden
#nullable disable
                                        , 36, (__builder9) => {
                                            __builder9.AddContent(37, " Programmering 2 ");
                                        }
                                        );
                                        __builder8.AddMarkupContent(38, "\r\n                            ");
                                        __Blazor.school.Pages.SkapaKod.TypeInference.CreateMudSelectItem_1(__builder8, 39, 40, 
#nullable restore
#line 15 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\SkapaKod.razor"
                                                    "IK1203"

#line default
#line hidden
#nullable disable
                                        , 41, (__builder9) => {
                                            __builder9.AddMarkupContent(42, " Nätverk och Kommunikation ");
                                        }
                                        );
                                    }
                                    ));
                                    __builder7.CloseComponent();
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(43, "\r\n                    ");
                                __builder6.OpenComponent<MudBlazor.MudItem>(44);
                                __builder6.AddAttribute(45, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 18 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\SkapaKod.razor"
                                 12

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(46, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.OpenComponent<MudBlazor.MudTextField<string>>(47);
                                    __builder7.AddAttribute(48, "Label", "Skapare");
                                    __builder7.AddAttribute(49, "For", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<string>>>(
#nullable restore
#line 19 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\SkapaKod.razor"
                                                                                                  () => kod.Skapare

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(50, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 19 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\SkapaKod.razor"
                                                                              kod.Skapare

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(51, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<string>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => kod.Skapare = __value, kod.Skapare))));
                                    __builder7.CloseComponent();
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(52, "\r\n                    ");
                                __builder6.OpenComponent<MudBlazor.MudItem>(53);
                                __builder6.AddAttribute(54, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 21 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\SkapaKod.razor"
                                 12

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(55, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.OpenComponent<MudBlazor.MudTextField<string>>(56);
                                    __builder7.AddAttribute(57, "Label", "Syfte");
                                    __builder7.AddAttribute(58, "For", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<string>>>(
#nullable restore
#line 22 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\SkapaKod.razor"
                                                                                              () => kod.Syfte

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(59, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 22 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\SkapaKod.razor"
                                                                            kod.Syfte

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(60, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<string>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => kod.Syfte = __value, kod.Syfte))));
                                    __builder7.CloseComponent();
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(61, "\r\n                    ");
                                __builder6.OpenComponent<MudBlazor.MudItem>(62);
                                __builder6.AddAttribute(63, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 24 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\SkapaKod.razor"
                                 12

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(64, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.OpenComponent<MudBlazor.MudAutocomplete<string>>(65);
                                    __builder7.AddAttribute(66, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<string>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, 
#nullable restore
#line 25 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\SkapaKod.razor"
                                                         (string s) => Refresh(s)

#line default
#line hidden
#nullable disable
                                    )));
                                    __builder7.AddAttribute(67, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 25 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\SkapaKod.razor"
                                                                                            kod.Lang

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(68, "MaxItems", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#nullable restore
#line 25 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\SkapaKod.razor"
                                                                                                                 langs.Length

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(69, "Label", "Välj språk");
                                    __builder7.AddAttribute(70, "SearchFunc", new System.Func<System.String, System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<string>>>(
#nullable restore
#line 25 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\SkapaKod.razor"
                                                                                                                                                                          Search

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.CloseComponent();
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(71, "\r\n                    ");
                                __builder6.OpenComponent<MudBlazor.MudItem>(72);
                                __builder6.AddAttribute(73, "Class", "d-flex justify-end");
                                __builder6.AddAttribute(74, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 27 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\SkapaKod.razor"
                                                            6

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(75, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.OpenComponent<MudBlazor.MudButton>(76);
                                    __builder7.AddAttribute(77, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.ButtonType>(
#nullable restore
#line 28 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\SkapaKod.razor"
                                               ButtonType.Submit

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(78, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 28 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\SkapaKod.razor"
                                                                           Variant.Filled

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(79, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 28 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\SkapaKod.razor"
                                                                                                  Color.Primary

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(80, "Class", "ml-auto");
                                    __builder7.AddAttribute(81, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder8) => {
                                        __builder8.AddContent(82, "Skapa");
                                    }
                                    ));
                                    __builder7.CloseComponent();
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(83, "\r\n            ");
                        __builder4.OpenComponent<MudBlazor.MudItem>(84);
                        __builder4.AddAttribute(85, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 32 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\SkapaKod.razor"
                         9

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(86, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudText>(87);
                            __builder5.AddAttribute(88, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(89, 
#nullable restore
#line 33 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\SkapaKod.razor"
                          kod.Lang

#line default
#line hidden
#nullable disable
                                );
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(90, "\r\n                ");
                            __builder5.OpenComponent<MudBlazor.MudItem>(91);
                            __builder5.AddAttribute(92, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 34 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\SkapaKod.razor"
                             12

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(93, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(94, "<div id=\"editor\"></div>");
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
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
#nullable restore
#line 45 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\SkapaKod.razor"
       
    Kod kod = new Kod();

    string codeData;

    private string[] langs =
{
        "java", "javascript", "python", "C", "C++", "csharp", "elixir", "erlang", "PHP", "R", "Rust",
        "Ruby", "Haskell", "fortran", "F#", "Scala", "golang", "Swift", "matlab", "Perl", "julia",
        "Assembly", "Pascal", "prolog", "html", "razor", "css"
    };

    private async Task<IEnumerable<string>> Search(string value)
    {
        // In real life use an asynchronous function for fetching data from an api.
        await Task.Delay(5);

        // if text is null or empty, show complete list
        if (string.IsNullOrEmpty(value))
            return langs;
        return langs.Where(x => x.Contains(value, StringComparison.InvariantCultureIgnoreCase));
    }

    // on valid submit method
    public async Task OnSubmit(EditContext context)
    {
        kod.Data = await _jsRuntime.InvokeAsync<string>("getEditorData");

        // build data object
        kod = new Kod()
        {
            Kursnamn = kod.Kursnamn,
            Skapare = kod.Skapare,
            Lang = kod.Lang,
            Syfte = kod.Syfte,
            Data = kod.Data,
        };

        // this is where we will save to the database
        _context.Code.Add(kod);
        _context.SaveChanges();

        StateHasChanged();
        Snackbar.Add("Fil skapad", Severity.Normal);
        NavigationManager.NavigateTo($"/{kod.Kursnamn}");
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await _jsRuntime.InvokeVoidAsync("renderEditor");
    }

    private async Task Refresh(string lang)
    {
        kod.Lang = lang;
        await _jsRuntime.InvokeVoidAsync("setLang", kod.Lang);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime _jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private school.Data.ApplicationDbContext _context { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDialogService DialogService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar Snackbar { get; set; }
    }
}
namespace __Blazor.school.Pages.SkapaKod
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudSelectItem_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::MudBlazor.MudSelectItem<T>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateMudSelectItem_1<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::MudBlazor.MudSelectItem<T>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
