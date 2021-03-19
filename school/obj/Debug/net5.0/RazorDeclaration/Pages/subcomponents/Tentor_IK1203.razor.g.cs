// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace school.Pages.subcomponents
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "c:\varren.app\school\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\varren.app\school\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\varren.app\school\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\varren.app\school\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\varren.app\school\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\varren.app\school\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\varren.app\school\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\varren.app\school\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\varren.app\school\_Imports.razor"
using school;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "c:\varren.app\school\_Imports.razor"
using school.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "c:\varren.app\school\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "c:\varren.app\school\_Imports.razor"
using school.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "c:\varren.app\school\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "c:\varren.app\school\_Imports.razor"
using school.Pages.subcomponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "c:\varren.app\school\_Imports.razor"
using school.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "c:\varren.app\school\Pages\subcomponents\Tentor_IK1203.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    public partial class Tentor_IK1203 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "c:\varren.app\school\Pages\subcomponents\Tentor_IK1203.razor"
       
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
        var results = await _context.Tentamen.Where(x => x.Kursnamn == "IK1203").OrderByDescending(x => x.Datum).ToListAsync();
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

    protected async void NewTabPdf(int id)
    {
        Tenta tenta = await _context.Tentamen.Where(x => x.Id == id).FirstOrDefaultAsync();
        Id = tenta.Id;
        Type = "tenta";

        string datum = tenta.Datum.Value.ToShortDateString();
        datum = datum.Replace("/", "");
        Pdfpath = datum + tenta.Examinator;

        Kurs = "IK1203";

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
#pragma warning restore 1591
