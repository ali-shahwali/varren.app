#pragma checksum "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\CodePrev.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1afc47532b72ea20851d0f3f39881f53682d6ee"
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
#nullable restore
#line 1 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\CodePrev.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/{Kurs}/view/{Id:int}")]
    public partial class CodePrev : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 8 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\CodePrev.razor"
 if (lang == "html")
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<div class=\"viewerHtml\" id=\"editor\"></div>");
            __builder.AddContent(1, 
#nullable restore
#line 11 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\CodePrev.razor"
      (MarkupString)Code

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 11 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\CodePrev.razor"
                         
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<div class=\"viewer\" id=\"editor\"></div>");
#nullable restore
#line 16 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\CodePrev.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\CodePrev.razor"
       
    [Parameter]
    public int Id { get; set; }

    [Parameter]
    public string Kurs { get; set; }

    public Kod kod { get; set; }

    public string Code;

    public string lang;

    protected override async Task OnInitializedAsync()
    {
        kod = await _context.Code.Where(x => x.Id == Id).FirstOrDefaultAsync();
        Code = kod.Data;
        lang = kod.Lang;
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await _jsRuntime.InvokeVoidAsync("renderViewer", kod.Data);
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
#pragma warning restore 1591
