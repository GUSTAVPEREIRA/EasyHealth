#pragma checksum "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\EasyHealth\Client\Shared\Buttons\CancelButton.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3c03b572950e1af25ab82e8f7c8a372a423ddfa"
// <auto-generated/>
#pragma warning disable 1591
namespace EasyHealth.Client.Shared.Buttons
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\EasyHealth\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\EasyHealth\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\EasyHealth\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\EasyHealth\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\EasyHealth\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\EasyHealth\Client\_Imports.razor"
using EasyHealth.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\EasyHealth\Client\_Imports.razor"
using EasyHealth.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\EasyHealth\Client\_Imports.razor"
using EasyHealth.Shared.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\EasyHealth\Client\_Imports.razor"
using EasyHealth.Client.Shared.Buttons;

#line default
#line hidden
#nullable disable
    public partial class CancelButton : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "a");
            __builder.AddAttribute(1, "class", "btn btn-warning text-white buttons-border-radius");
            __builder.AddAttribute(2, "href", 
#nullable restore
#line 1 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\EasyHealth\Client\Shared\Buttons\CancelButton.razor"
                                                                   Url

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 1 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\EasyHealth\Client\Shared\Buttons\CancelButton.razor"
                                                                                  OnClick

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(4, 
#nullable restore
#line 1 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\EasyHealth\Client\Shared\Buttons\CancelButton.razor"
                                                                                            Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(5, " ");
            __builder.OpenElement(6, "span");
            __builder.AddAttribute(7, "class", "icon-margin" + " " + (
#nullable restore
#line 1 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\EasyHealth\Client\Shared\Buttons\CancelButton.razor"
                                                                                                                           Icon

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 3 "C:\Users\gugup\OneDrive\Área de Trabalho\C#\Projetos\EasyHealth\EasyHealth\EasyHealth\EasyHealth\Client\Shared\Buttons\CancelButton.razor"
       
    [Parameter] public string Name { get; set; } = "";
    [Parameter] public string Icon { get; set; } = "";
    [Parameter] public string Url { get; set; }
    [Parameter] public EventCallback OnClick { get; set; }
    [Parameter] public string Css { get; set; } = "";

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
