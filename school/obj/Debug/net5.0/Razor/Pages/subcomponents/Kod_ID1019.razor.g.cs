#pragma checksum "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\subcomponents\Kod_ID1019.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45866f29fe4eba533b0a5956316352080f18c556"
// <auto-generated/>
#pragma warning disable 1591
namespace school.Pages.subcomponents
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
#nullable restore
#line 1 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\subcomponents\Kod_ID1019.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    public partial class Kod_ID1019 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\subcomponents\Kod_ID1019.razor"
 if (table == null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<MudBlazor.MudProgressLinear>(0);
            __builder.AddAttribute(1, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 7 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\subcomponents\Kod_ID1019.razor"
                              Color.Secondary

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "Indeterminate", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 7 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\subcomponents\Kod_ID1019.razor"
                                                              true

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 8 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\subcomponents\Kod_ID1019.razor"
}

#line default
#line hidden
#nullable disable
            __Blazor.school.Pages.subcomponents.Kod_ID1019.TypeInference.CreateMudTable_0(__builder, 3, 4, 
#nullable restore
#line 9 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\subcomponents\Kod_ID1019.razor"
                        new Func<TableState, Task<TableData<Kod>>>(ServerReload)

#line default
#line hidden
#nullable disable
            , 5, 
#nullable restore
#line 9 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\subcomponents\Kod_ID1019.razor"
                                                                                                       true

#line default
#line hidden
#nullable disable
            , 6, 
#nullable restore
#line 9 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\subcomponents\Kod_ID1019.razor"
                                                                                                                         Breakpoint.Sm

#line default
#line hidden
#nullable disable
            , 7, (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTh>(8);
                __builder2.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(10, "Syfte");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(12);
                __builder2.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(14, "Skapare");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(16);
                __builder2.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(18, "Språk");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(20);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(21, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(22);
                __builder2.CloseComponent();
            }
            , 23, (context) => (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTd>(24);
                __builder2.AddAttribute(25, "DataLabel", "Syfte");
                __builder2.AddAttribute(26, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(27, 
#nullable restore
#line 18 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\subcomponents\Kod_ID1019.razor"
                                  context.Syfte

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(28, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(29);
                __builder2.AddAttribute(30, "DataLabel", "Skapare");
                __builder2.AddAttribute(31, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(32, 
#nullable restore
#line 19 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\subcomponents\Kod_ID1019.razor"
                                    context.Skapare

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(33, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(34);
                __builder2.AddAttribute(35, "DataLabel", "Språk");
                __builder2.AddAttribute(36, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(37, 
#nullable restore
#line 20 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\subcomponents\Kod_ID1019.razor"
                                  context.Lang

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(38, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(39);
                __builder2.AddAttribute(40, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudIconButton>(41);
                    __builder3.AddAttribute(42, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\subcomponents\Kod_ID1019.razor"
                                      e => OpenNewTab(context.Id)

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(43, "Variant", "Variant.Filled");
                    __builder3.AddAttribute(44, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\subcomponents\Kod_ID1019.razor"
                                                                                                    Icons.Custom.FileFormats.FileCode

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(45, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 22 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\subcomponents\Kod_ID1019.razor"
                                                                                                                                              Color.Primary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(46, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(47);
                __builder2.AddAttribute(48, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudIconButton>(49);
                    __builder3.AddAttribute(50, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\subcomponents\Kod_ID1019.razor"
                                      e => ToggleDeleteBox(context)

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(51, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\subcomponents\Kod_ID1019.razor"
                                                                             Icons.Material.Filled.Delete

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(52, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 25 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\subcomponents\Kod_ID1019.razor"
                                                                                                                  Color.Error

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            , 53, (__value) => {
#nullable restore
#line 9 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\subcomponents\Kod_ID1019.razor"
                                                                                         table = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.AddMarkupContent(54, "\r\n\r\n\r\n\r\n");
            __builder.OpenComponent<MudBlazor.MudMessageBox>(55);
            __builder.AddAttribute(56, "Title", "Varning");
            __builder.AddAttribute(57, "CancelText", "Avbryt");
            __builder.AddAttribute(58, "MessageContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(59, "\r\n        Är du säker?\r\n    ");
            }
            ));
            __builder.AddAttribute(60, "YesButton", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudButton>(61);
                __builder2.AddAttribute(62, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\subcomponents\Kod_ID1019.razor"
                            Delete

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(63, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 38 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\subcomponents\Kod_ID1019.razor"
                                             Variant.Filled

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(64, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 38 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\subcomponents\Kod_ID1019.razor"
                                                                    Color.Error

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(65, "StartIcon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 38 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\subcomponents\Kod_ID1019.razor"
                                                                                             Icons.Material.Filled.DeleteForever

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(66, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(67, "Ja, Ta bort!");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddComponentReferenceCapture(68, (__value) => {
#nullable restore
#line 33 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\subcomponents\Kod_ID1019.razor"
                     mbox = (MudBlazor.MudMessageBox)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\subcomponents\Kod_ID1019.razor"
       
    public MudTable<Kod> table;

    private Kod CurrentKod;

    private MudMessageBox mbox { get; set; }

    private string state = "Message box hasn't been opened yet";

    private string Code;

    [Parameter]
    public int Id { get; set; }

    [Parameter]
    public string Kurs { get; set; }

    // LOAD DATA FROM DATABASE
    private async Task<TableData<Kod>> ServerReload(TableState state)
    {
        var results = await _context.Code.Where(x => x.Kursnamn == "ID1019").OrderByDescending(x => x.Lang).ToListAsync();
        StateHasChanged();
        return new TableData<Kod>() { Items = results };
    }

    // DELETE EXAM
    private async void Delete()
    {
        _context.Code.Remove(CurrentKod);
        _context.SaveChanges();

        await table.ReloadServerData();
        Snackbar.Add("Deleted", Severity.Normal);
    }

    // OPEN DELETE PROMPT
    private async void ToggleDeleteBox(Kod kod)
    {
        CurrentKod = kod;
        bool? result = await mbox.Show();
        state = result == null ? "Cancelled" : "Deleted!";
        StateHasChanged();
    }

    private async Task OpenNewTab(int id)
    {
        Kod kod = await _context.Code.Where(x => x.Id == id).FirstOrDefaultAsync();
        Kurs = kod.Kursnamn;
        Id = id;
        await _jsRuntime.InvokeVoidAsync("blazorOpen", new object[2] { $"/{Kurs}/{Id}/", "_blank" });
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private school.Data.ApplicationDbContext _context { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime _jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDialogService DialogService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar Snackbar { get; set; }
    }
}
namespace __Blazor.school.Pages.subcomponents.Kod_ID1019
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTable_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Func<global::MudBlazor.TableState, global::System.Threading.Tasks.Task<global::MudBlazor.TableData<T>>> __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::MudBlazor.Breakpoint __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment<T> __arg4, int __seq5, global::System.Action<global::MudBlazor.MudTable<T>> __arg5)
        {
        __builder.OpenComponent<global::MudBlazor.MudTable<T>>(seq);
        __builder.AddAttribute(__seq0, "ServerData", __arg0);
        __builder.AddAttribute(__seq1, "Hover", __arg1);
        __builder.AddAttribute(__seq2, "Breakpoint", __arg2);
        __builder.AddAttribute(__seq3, "HeaderContent", __arg3);
        __builder.AddAttribute(__seq4, "RowTemplate", __arg4);
        __builder.AddComponentReferenceCapture(__seq5, (__value) => { __arg5((global::MudBlazor.MudTable<T>)__value); });
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
