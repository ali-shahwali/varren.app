#pragma checksum "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\subcomponents\Tentor_ID1019.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1d3da414eea0e65f2f4ac6baaf9f05dec58a35b"
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
#line 1 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\subcomponents\Tentor_ID1019.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    public partial class Tentor_ID1019 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\subcomponents\Tentor_ID1019.razor"
 if (table == null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<MudBlazor.MudProgressLinear>(0);
            __builder.AddAttribute(1, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 7 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\subcomponents\Tentor_ID1019.razor"
                          Color.Secondary

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "Indeterminate", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 7 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\subcomponents\Tentor_ID1019.razor"
                                                          true

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 8 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\subcomponents\Tentor_ID1019.razor"
}

#line default
#line hidden
#nullable disable
            __Blazor.school.Pages.subcomponents.Tentor_ID1019.TypeInference.CreateMudTable_0(__builder, 3, 4, 
#nullable restore
#line 9 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\subcomponents\Tentor_ID1019.razor"
                        new Func<TableState, Task<TableData<Tenta>>>(ServerReload)

#line default
#line hidden
#nullable disable
            , 5, 
#nullable restore
#line 9 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\subcomponents\Tentor_ID1019.razor"
                                                                                                         true

#line default
#line hidden
#nullable disable
            , 6, 
#nullable restore
#line 9 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\subcomponents\Tentor_ID1019.razor"
                                                                                                                           Breakpoint.Sm

#line default
#line hidden
#nullable disable
            , 7, (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTh>(8);
                __builder2.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(10, "Datum");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(12);
                __builder2.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(14, "Examinator");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(16);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(18);
                __builder2.CloseComponent();
            }
            , 19, (context) => (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTd>(20);
                __builder2.AddAttribute(21, "DataLabel", "Datum");
                __builder2.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(23, 
#nullable restore
#line 17 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\subcomponents\Tentor_ID1019.razor"
                                  context.Datum.Value.ToShortDateString()

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(24, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(25);
                __builder2.AddAttribute(26, "DataLabel", "Examinator");
                __builder2.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(28, 
#nullable restore
#line 18 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\subcomponents\Tentor_ID1019.razor"
                                       context.Examinator

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(30);
                __builder2.AddAttribute(31, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudIconButton>(32);
                    __builder3.AddAttribute(33, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\subcomponents\Tentor_ID1019.razor"
                                      e => GetBytesFromPDF(context.Id, true)

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(34, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\subcomponents\Tentor_ID1019.razor"
                                                                                      Icons.Custom.FileFormats.FilePdf

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(35, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 20 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\subcomponents\Tentor_ID1019.razor"
                                                                                                                               Color.Secondary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(36, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudIconButton>(37);
                    __builder3.AddAttribute(38, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\subcomponents\Tentor_ID1019.razor"
                                      e => NewTabPdf(context.Id)

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(39, "Target", "top");
                    __builder3.AddAttribute(40, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\subcomponents\Tentor_ID1019.razor"
                                                                                       Icons.Material.Filled.OpenInNew

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(41, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 21 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\subcomponents\Tentor_ID1019.razor"
                                                                                                                               Color.Secondary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(42, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(43);
                __builder2.AddAttribute(44, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudIconButton>(45);
                    __builder3.AddAttribute(46, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\subcomponents\Tentor_ID1019.razor"
                                      e => ToggleDeleteBox(context)

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(47, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\subcomponents\Tentor_ID1019.razor"
                                                                             Icons.Material.Filled.Delete

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(48, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 24 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\subcomponents\Tentor_ID1019.razor"
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
            , 49, (__value) => {
#nullable restore
#line 9 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\subcomponents\Tentor_ID1019.razor"
                                                                                           table = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.AddMarkupContent(50, "\r\n\r\n");
            __builder.OpenComponent<MudBlazor.MudMessageBox>(51);
            __builder.AddAttribute(52, "Title", "Warning");
            __builder.AddAttribute(53, "CancelText", "Avbryt");
            __builder.AddAttribute(54, "MessageContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(55, "\r\n        Är du säker?\r\n    ");
            }
            ));
            __builder.AddAttribute(56, "YesButton", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudButton>(57);
                __builder2.AddAttribute(58, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\subcomponents\Tentor_ID1019.razor"
                            Delete

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(59, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 35 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\subcomponents\Tentor_ID1019.razor"
                                             Variant.Filled

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(60, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 35 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\subcomponents\Tentor_ID1019.razor"
                                                                    Color.Error

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(61, "StartIcon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 35 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\subcomponents\Tentor_ID1019.razor"
                                                                                             Icons.Material.Filled.DeleteForever

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(62, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(63, "Ja, Ta bort!");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddComponentReferenceCapture(64, (__value) => {
#nullable restore
#line 30 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\subcomponents\Tentor_ID1019.razor"
                     mbox = (MudBlazor.MudMessageBox)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(65, "\r\n\r\n");
            __builder.OpenComponent<MudBlazor.MudOverlay>(66);
            __builder.AddAttribute(67, "ZIndex", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 40 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\subcomponents\Tentor_ID1019.razor"
                    9999

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(68, "Style", "padding-top: 355px; padding-right: 35px");
            __builder.AddAttribute(69, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 40 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\subcomponents\Tentor_ID1019.razor"
                                                                                   isVisiblePdf

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(70, "DarkBackground", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 40 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\subcomponents\Tentor_ID1019.razor"
                                                                                                                 true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(71, "Absolute", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 40 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\subcomponents\Tentor_ID1019.razor"
                                                                                                                                 true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(72, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<NoJS.PDFViewer.PDFViewer>(73);
                __builder2.AddAttribute(74, "Document", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Byte[]>(
#nullable restore
#line 41 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\subcomponents\Tentor_ID1019.razor"
                                         Pdf

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(75, "DocumentHeight", "940px");
                __builder2.AddAttribute(76, "DocumentName", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 43 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\subcomponents\Tentor_ID1019.razor"
                                             Pdfpath

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(77, "DocumentWidth", "1500px");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(78, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudFab>(79);
                __builder2.AddAttribute(80, "Style", "position: fixed; right: 3px; top: 60px");
                __builder2.AddAttribute(81, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\subcomponents\Tentor_ID1019.razor"
                                                                      e => ToggleOverlayPdf(false)

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(82, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 45 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\subcomponents\Tentor_ID1019.razor"
                                                                                                            Color.Error

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(83, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 45 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\subcomponents\Tentor_ID1019.razor"
                                                                                                                                Icons.Material.Filled.Close

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\subcomponents\Tentor_ID1019.razor"
       
    public MudTable<Tenta> table;

    [Parameter]
    public string Pdfpath { get; set; }

    [Parameter]
    public int Id { get; set; }

    [Parameter]
    public string Type { get; set; }

    [Parameter]
    public string Kurs { get; set; }

    public byte[] Pdf { get; set; }

    public bool isVisiblePdf;

    private MudMessageBox mbox { get; set; }

    private Tenta CurrentTenta { get; set; }

    private string state = "Message box hasn't been opened yet";

    // LOAD DATA FROM DATABASE
    private async Task<TableData<Tenta>> ServerReload(TableState state)
    {
        var results = await _context.Tentamen.Where(x => x.Kursnamn == "ID1019").OrderByDescending(x => x.Datum).ToListAsync();
        StateHasChanged();
        return new TableData<Tenta>() { Items = results };
    }

    // DELETE EXAM
    private async void Delete()
    {
        _context.Tentamen.Remove(CurrentTenta);
        _context.SaveChanges();

        await table.ReloadServerData();
        Snackbar.Add("Deleted", Severity.Normal);
    }

    // LOAD PDF
    private async Task GetBytesFromPDF(int id, bool toggle)
    {
        Tenta tenta = await _context.Tentamen.Where(x => x.Id == id).FirstOrDefaultAsync();
        Pdf = Convert.FromBase64String(tenta.Data);
        if (toggle)
            ToggleOverlayPdf(toggle);
    }

    // OPEN PDF
    private void ToggleOverlayPdf(bool toggle)
    {
        isVisiblePdf = toggle;
        StateHasChanged();
    }

    // OPEN DELETE PROMPT
    private async void ToggleDeleteBox(Tenta tenta)
    {
        CurrentTenta = tenta;
        bool? result = await mbox.Show();
        state = result == null ? "Cancelled" : "Deleted!";
        StateHasChanged();
    }

    protected async Task NewTabPdf(int id)
    {
        Tenta tenta = await _context.Tentamen.Where(x => x.Id == id).FirstOrDefaultAsync();
        Id = tenta.Id;
        Type = "tenta";

        string datum = tenta.Datum.Value.ToShortDateString();
        datum = datum.Replace("/", "");
        Pdfpath = datum + tenta.Examinator;

        Kurs = "ID1019";

        OnParametersSet();
        await _jsRuntime.InvokeVoidAsync("blazorOpen", new object[2] { $"/{Kurs}/{Type}/{Pdfpath}/{Id}", "_blank" });
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
namespace __Blazor.school.Pages.subcomponents.Tentor_ID1019
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
