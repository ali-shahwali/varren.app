#pragma checksum "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\SkapaTenta.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "270a41f261c78ad71e45eed4a4adfd31317b5692"
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
#nullable restore
#line 2 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\SkapaTenta.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\SkapaTenta.razor"
using System.Text;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/skapa_tenta")]
    public partial class SkapaTenta : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudContainer>(0);
            __builder.AddAttribute(1, "Class", "mt-16");
            __builder.AddAttribute(2, "MaxWidth", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.MaxWidth>(
#nullable restore
#line 6 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\SkapaTenta.razor"
                                      MaxWidth.Medium

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(4);
                __builder2.AddAttribute(5, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 7 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\SkapaTenta.razor"
                      tenta

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(6, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 7 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\SkapaTenta.razor"
                                            OnValidSubmit

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
#line 9 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\SkapaTenta.razor"
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
#line 10 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\SkapaTenta.razor"
                         7

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudText>(17);
                            __builder5.AddAttribute(18, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 11 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\SkapaTenta.razor"
                               Typo.h5

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(19, "GutterBottom", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 11 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\SkapaTenta.razor"
                                                      true

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(21, "Skapa tenta");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(22, "\r\n                ");
                            __builder5.OpenComponent<MudBlazor.MudGrid>(23);
                            __builder5.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<MudBlazor.MudItem>(25);
                                __builder6.AddAttribute(26, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 13 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\SkapaTenta.razor"
                                 12

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.OpenComponent<MudBlazor.MudSelect<string>>(28);
                                    __builder7.AddAttribute(29, "Label", "Kursnamn");
                                    __builder7.AddAttribute(30, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 14 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\SkapaTenta.razor"
                                                           tenta.Kursnamn

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(31, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<string>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tenta.Kursnamn = __value, tenta.Kursnamn))));
                                    __builder7.AddAttribute(32, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder8) => {
                                        __Blazor.varren.Pages.SkapaTenta.TypeInference.CreateMudSelectItem_0(__builder8, 33, 34, 
#nullable restore
#line 15 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\SkapaTenta.razor"
                                                    "ID1019"

#line default
#line hidden
#nullable disable
                                        , 35, (__builder9) => {
                                            __builder9.AddContent(36, " Programmering 2 ");
                                        }
                                        );
                                        __builder8.AddMarkupContent(37, "\r\n                            ");
                                        __Blazor.varren.Pages.SkapaTenta.TypeInference.CreateMudSelectItem_1(__builder8, 38, 39, 
#nullable restore
#line 16 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\SkapaTenta.razor"
                                                    "IK1203"

#line default
#line hidden
#nullable disable
                                        , 40, (__builder9) => {
                                            __builder9.AddMarkupContent(41, " Nätverk och Kommunikation ");
                                        }
                                        );
                                    }
                                    ));
                                    __builder7.CloseComponent();
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(42, "\r\n                    ");
                                __builder6.OpenComponent<MudBlazor.MudItem>(43);
                                __builder6.AddAttribute(44, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 19 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\SkapaTenta.razor"
                                 12

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(45, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.OpenComponent<MudBlazor.MudTextField<string>>(46);
                                    __builder7.AddAttribute(47, "Label", "Examinator");
                                    __builder7.AddAttribute(48, "For", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<string>>>(
#nullable restore
#line 20 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\SkapaTenta.razor"
                                                                                                          () => tenta.Examinator

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(49, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 20 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\SkapaTenta.razor"
                                                                                 tenta.Examinator

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(50, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<string>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tenta.Examinator = __value, tenta.Examinator))));
                                    __builder7.CloseComponent();
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(51, "\r\n                    ");
                                __builder6.OpenComponent<MudBlazor.MudItem>(52);
                                __builder6.AddAttribute(53, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 22 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\SkapaTenta.razor"
                                 12

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(54, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.OpenComponent<MudBlazor.MudDatePicker>(55);
                                    __builder7.AddAttribute(56, "Label", "Datum");
                                    __builder7.AddAttribute(57, "Date", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.DateTime?>(
#nullable restore
#line 23 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\SkapaTenta.razor"
                                                                 tenta.Datum

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(58, "DateChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.DateTime?>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.DateTime?>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tenta.Datum = __value, tenta.Datum))));
                                    __builder7.CloseComponent();
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(59, "\r\n                    ");
                                __builder6.OpenComponent<MudBlazor.MudItem>(60);
                                __builder6.AddAttribute(61, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 25 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\SkapaTenta.razor"
                                 6

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(62, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.OpenComponent<BlazorInputFile.InputFile>(63);
                                    __builder7.AddAttribute(64, "id", "fileInput");
                                    __builder7.AddAttribute(65, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorInputFile.IFileListEntry[]>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorInputFile.IFileListEntry[]>(this, 
#nullable restore
#line 26 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\SkapaTenta.razor"
                                                                            HandleFileSelected

#line default
#line hidden
#nullable disable
                                    )));
                                    __builder7.AddAttribute(66, "hidden", true);
                                    __builder7.CloseComponent();
                                    __builder7.AddMarkupContent(67, "\r\n                        ");
                                    __builder7.OpenComponent<MudBlazor.MudButton>(68);
                                    __builder7.AddAttribute(69, "HtmlTag", "label");
                                    __builder7.AddAttribute(70, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 28 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\SkapaTenta.razor"
                                            Variant.Filled

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(71, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 29 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\SkapaTenta.razor"
                                          Color.Primary

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(72, "StartIcon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 30 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\SkapaTenta.razor"
                                               Icons.Filled.CloudUpload

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(73, "for", "fileInput");
                                    __builder7.AddAttribute(74, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder8) => {
                                        __builder8.AddMarkupContent(75, "\r\n                            Ladda upp\r\n                        ");
                                    }
                                    ));
                                    __builder7.CloseComponent();
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(76, "\r\n                    ");
                                __builder6.OpenComponent<MudBlazor.MudItem>(77);
                                __builder6.AddAttribute(78, "Class", "d-flex justify-end");
                                __builder6.AddAttribute(79, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 34 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\SkapaTenta.razor"
                                                            6

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(80, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.OpenComponent<MudBlazor.MudButton>(81);
                                    __builder7.AddAttribute(82, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.ButtonType>(
#nullable restore
#line 35 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\SkapaTenta.razor"
                                               ButtonType.Submit

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(83, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 35 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\SkapaTenta.razor"
                                                                           Variant.Filled

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(84, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 35 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\SkapaTenta.razor"
                                                                                                  Color.Primary

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(85, "Class", "ml-auto");
                                    __builder7.AddAttribute(86, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder8) => {
                                        __builder8.AddContent(87, "Skapa");
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
#line 44 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\SkapaTenta.razor"
       

    Tenta tenta = new Tenta();

    IFileListEntry file;

    public async void HandleFileSelected(IFileListEntry[] files)
    {
        file = files.FirstOrDefault();

        await GetFileData();

        StateHasChanged();
    }

    private async Task GetFileData()
    {

        using (Stream stream = file.Data)
        {
            
            byte[] bytes = new byte[stream.Length];
            int numBytesToRead = (int)stream.Length;
            int numBytesRead = 0;

            while (numBytesToRead > 0)
            {

                int n = await stream.ReadAsync(bytes, numBytesRead, numBytesToRead);
                if (n == 0)
                    break;

                numBytesRead += n;
                numBytesToRead -= n;
            }

            tenta.Data = Convert.ToBase64String(bytes);
            stream.Close();
        }
    }

    // on valid submit method
    public void OnValidSubmit(EditContext context)
    {
        // build data object
        tenta = new Tenta()
        {
            Kursnamn = tenta.Kursnamn,
            Datum = tenta.Datum,
            Examinator = tenta.Examinator,
            Data = tenta.Data,
        };

        // this is where we will save to the database
        _context.Tentamen.Add(tenta);
        _context.SaveChanges();

        StateHasChanged();
        Snackbar.Add("Fil skapad", Severity.Normal);
        NavigationManager.NavigateTo($"/{tenta.Kursnamn}");

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private varren.Data.ApplicationDbContext _context { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDialogService DialogService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar Snackbar { get; set; }
    }
}
namespace __Blazor.varren.Pages.SkapaTenta
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
