#pragma checksum "C:\Users\Admin\Documents\GitHub\CarSell\CarSell\CarSell.Blazor\Pages\UpdatePage\UpdateManufacturer.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70345b094e31a42dbbe24e6889271dc570e6a965"
// <auto-generated/>
#pragma warning disable 1591
namespace CarSell.Blazor.Pages.UpdatePage
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/updateManufacturer/{id}")]
    public partial class UpdateManufacturer : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Update Form</h2>\r\n\r\n");
#nullable restore
#line 5 "C:\Users\Admin\Documents\GitHub\CarSell\CarSell\CarSell.Blazor\Pages\UpdatePage\UpdateManufacturer.razor"
 if (_manufacturer != null)
{


#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(2);
            __builder.AddAttribute(3, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 8 "C:\Users\Admin\Documents\GitHub\CarSell\CarSell\CarSell.Blazor\Pages\UpdatePage\UpdateManufacturer.razor"
                     _manufacturer

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 8 "C:\Users\Admin\Documents\GitHub\CarSell\CarSell\CarSell.Blazor\Pages\UpdatePage\UpdateManufacturer.razor"
                                                   Update

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "class", "card card-body bg-light mt-5");
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(7, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n\r\n\r\n        ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "form-group row");
                __builder2.AddMarkupContent(12, "\r\n            ");
                __builder2.AddMarkupContent(13, "<label for=\"name\" class=\"col-md-2 col-form-label\">Name:</label>\r\n            ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "col-md-10");
                __builder2.AddMarkupContent(16, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(17);
                __builder2.AddAttribute(18, "id", "name");
                __builder2.AddAttribute(19, "class", "form-control");
                __builder2.AddAttribute(20, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 15 "C:\Users\Admin\Documents\GitHub\CarSell\CarSell\CarSell.Blazor\Pages\UpdatePage\UpdateManufacturer.razor"
                                                                       _manufacturer.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _manufacturer.Name = __value, _manufacturer.Name))));
                __builder2.AddAttribute(22, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _manufacturer.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(23, "\r\n                ");
                __Blazor.CarSell.Blazor.Pages.UpdatePage.UpdateManufacturer.TypeInference.CreateValidationMessage_0(__builder2, 24, 25, 
#nullable restore
#line 16 "C:\Users\Admin\Documents\GitHub\CarSell\CarSell\CarSell.Blazor\Pages\UpdatePage\UpdateManufacturer.razor"
                                          () => _manufacturer.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(26, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n\r\n\r\n\r\n        ");
                __builder2.AddMarkupContent(29, "<div class=\"row\">\r\n            <div class=\"col-md-12 text-right\">\r\n                <button type=\"submit\" class=\"btn btn-success\">Update</button>\r\n            </div>\r\n        </div>\r\n\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(30, "\r\n    ");
            __builder.OpenComponent<CarSell.Blazor.Shared.SuccessfulNotification>(31);
            __builder.AddComponentReferenceCapture(32, (__value) => {
#nullable restore
#line 29 "C:\Users\Admin\Documents\GitHub\CarSell\CarSell\CarSell.Blazor\Pages\UpdatePage\UpdateManufacturer.razor"
                                  _notification = (CarSell.Blazor.Shared.SuccessfulNotification)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(33, "\r\n");
#nullable restore
#line 30 "C:\Users\Admin\Documents\GitHub\CarSell\CarSell\CarSell.Blazor\Pages\UpdatePage\UpdateManufacturer.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.CarSell.Blazor.Pages.UpdatePage.UpdateManufacturer
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591