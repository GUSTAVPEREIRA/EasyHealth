#pragma checksum "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\Client\Pages\Cadastro\HospitalSupply\HospitalSupplyForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b061573da8b72ef707b6e65c7c96a75e859890b"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace EasyHealth.Client.Pages.Cadastro.HospitalSupply
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\Client\_Imports.razor"
using EasyHealth.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\Client\_Imports.razor"
using EasyHealth.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\Client\_Imports.razor"
using EasyHealth.Shared.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\Client\_Imports.razor"
using EasyHealth.Client.Shared.Buttons;

#line default
#line hidden
#nullable disable
    public partial class HospitalSupplyForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\Client\Pages\Cadastro\HospitalSupply\HospitalSupplyForm.razor"
       

    protected override void OnInitialized()
    {
        if (hospitalSupply == null)
        {
            this.hospitalSupply = new HospitalSupply();
            this._selected = false;
        }
        else
        {
            this._selected = this.hospitalSupply.SupplyCategory != null ? true : false;
        }
    }

    private bool _selected { get; set; }

    [Inject]
    public NavigationManager navigator { get; set; }

    [Parameter]
    public HospitalSupply hospitalSupply { get; set; }

    [Parameter]
    public string ButtonTextSubmit { get; set; } = "Salvar";

    [Parameter]
    public string ButtonTextCancel { get; set; } = "Cancelar";

    [Parameter]
    public EventCallback OnValidSubmit { get; set; }

    [Parameter]
    public List<SupplyCategory> SupplyCategories { get; set; } = new List<SupplyCategory>();


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
