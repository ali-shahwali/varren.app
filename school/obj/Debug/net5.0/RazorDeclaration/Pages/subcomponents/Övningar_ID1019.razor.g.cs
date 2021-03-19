// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace varren.Pages.subcomponents
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
#line 1 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\subcomponents\Övningar_ID1019.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    public partial class Övningar_ID1019 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\subcomponents\Övningar_ID1019.razor"
       

    public MudTable<Övning> table;

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

    private Övning CurrentÖvning { get; set; }

    private string state = "Message box hasn't been opened yet";

    private async Task<TableData<Övning>> ServerReload(TableState state)
    {
        var results = await _context.Övningar.Where(x => x.Kursnamn == "ID1019").ToListAsync();
        StateHasChanged();
        return new TableData<Övning>() { Items = results };
    }

    private async void Delete()
    {
        _context.Övningar.Remove(CurrentÖvning);
        _context.SaveChanges();

        await table.ReloadServerData();
        Snackbar.Add("Deleted", Severity.Normal);
    }

    public async void GetBytesFromPDF(Övning övning, bool toggle)
    {
        await _context.Övningar.Where(x => x.Id == övning.Id).FirstOrDefaultAsync();
        Pdf = Convert.FromBase64String(övning.Data);
        ToggleOverlayPdf(toggle);
    }

    public void ToggleOverlayPdf(bool toggle)
    {
        isVisiblePdf = toggle;
        StateHasChanged();
    }

    // OPEN DELETE PROMPT
    private async void ToggleDeleteBox(Övning övning)
    {
        CurrentÖvning = övning;
        bool? result = await mbox.Show();
        state = result == null ? "Cancelled" : "Deleted!";
        StateHasChanged();
    }

    protected async void NewTabPdf(int id)
    {
        Övning övning = await _context.Övningar.Where(x => x.Id == id).FirstOrDefaultAsync();
        Id = övning.Id;
        Type = "ovning";

        string ämne = övning.Ämne;
        Pdfpath = ämne;

        Kurs = "ID1019";

        OnParametersSet();
        await _jsRuntime.InvokeVoidAsync("blazorOpen", new object[2] { $"/{Kurs}/{Type}/{Pdfpath}/{Id}", "_blank" });
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime _jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private varren.Data.ApplicationDbContext _context { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDialogService DialogService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar Snackbar { get; set; }
    }
}
#pragma warning restore 1591
