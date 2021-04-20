#pragma checksum "C:\Users\Admin\Documents\GitHub\CarSell\CarSell\CarSell.Blazor\Pages\Manufacturers.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c0245d19a98a217f2a2c6ad631288119833f3c4"
// <auto-generated/>
#pragma warning disable 1591
namespace CarSell.Blazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Admin\Documents\GitHub\CarSell\CarSell\CarSell.Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Documents\GitHub\CarSell\CarSell\CarSell.Blazor\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\Documents\GitHub\CarSell\CarSell\CarSell.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\Documents\GitHub\CarSell\CarSell\CarSell.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Admin\Documents\GitHub\CarSell\CarSell\CarSell.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Admin\Documents\GitHub\CarSell\CarSell\CarSell.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Admin\Documents\GitHub\CarSell\CarSell\CarSell.Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Admin\Documents\GitHub\CarSell\CarSell\CarSell.Blazor\_Imports.razor"
using CarSell.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Admin\Documents\GitHub\CarSell\CarSell\CarSell.Blazor\_Imports.razor"
using CarSell.Blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Documents\GitHub\CarSell\CarSell\CarSell.Blazor\Pages\Manufacturers.razor"
using CarSell.Blazor.Components.ManufacturersTable;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\Documents\GitHub\CarSell\CarSell\CarSell.Blazor\Pages\Manufacturers.razor"
using CarSell.Blazor.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/manufacturers")]
    public partial class Manufacturers : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"row\">\r\n\r\n    <div class=\"col-md-2\">\r\n        <a href=\"/createManufacturer\">Create Manufacturer</a>\r\n    </div>\r\n</div>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenComponent<CarSell.Blazor.Components.ManufacturersTable.ManufacturerTable>(7);
            __builder.AddAttribute(8, "Manufacturers", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<CarSell.DAL.DBO.Manufacturer>>(
#nullable restore
#line 13 "C:\Users\Admin\Documents\GitHub\CarSell\CarSell\CarSell.Blazor\Pages\Manufacturers.razor"
                                          manufacturerList

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "OnDeleted", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 13 "C:\Users\Admin\Documents\GitHub\CarSell\CarSell\CarSell.Blazor\Pages\Manufacturers.razor"
                                                                       DeleteManufacturer

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "row");
            __builder.AddMarkupContent(15, "\r\n    ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "col");
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.OpenComponent<CarSell.Blazor.Components.Pagination>(19);
            __builder.AddAttribute(20, "PageParam", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<CarSell.DAL.Parameteres.PageParam>(
#nullable restore
#line 18 "C:\Users\Admin\Documents\GitHub\CarSell\CarSell\CarSell.Blazor\Pages\Manufacturers.razor"
                               PageParameters

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "Spread", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 18 "C:\Users\Admin\Documents\GitHub\CarSell\CarSell\CarSell.Blazor\Pages\Manufacturers.razor"
                                                       2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "SelectedPage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 18 "C:\Users\Admin\Documents\GitHub\CarSell\CarSell\CarSell.Blazor\Pages\Manufacturers.razor"
                                                                        SelectedPage

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(23, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
