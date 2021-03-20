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
#line 1 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\subcomponents\Kod_IK1203.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    public partial class Kod_IK1203 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "C:\Users\ali_z\source\repos\ali-shahwali\school-blazor\school\Pages\subcomponents\Kod_IK1203.razor"
       
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
        var results = await _context.Code.Where(x => x.Kursnamn == "IK1203").OrderByDescending(x => x.Lang).ToListAsync();
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

    private async Task ViewNewTab(int id)
    {
        Kod kod = await _context.Code.Where(x => x.Id == id).FirstOrDefaultAsync();
        Kurs = kod.Kursnamn;
        Id = id;
        await _jsRuntime.InvokeVoidAsync("blazorOpen", new object[2] { $"/{Kurs}/view/{Id}/", "_blank" });
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
#pragma warning restore 1591
