#pragma checksum "C:\Users\Admin\Documents\GitHub\CarSell\CarSell\CarSell.Blazor\Pages\CreatePage\CreateCar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7b92561825058c78284f98a8fc574686d8f4cd0"
// <auto-generated/>
#pragma warning disable 1591
namespace CarSell.Blazor.Pages.CreatePage
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/createCar")]
    public partial class CreateCar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Create Form</h2>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 5 "C:\Users\Admin\Documents\GitHub\CarSell\CarSell\CarSell.Blazor\Pages\CreatePage\CreateCar.razor"
                 _car

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 5 "C:\Users\Admin\Documents\GitHub\CarSell\CarSell\CarSell.Blazor\Pages\CreatePage\CreateCar.razor"
                                      Create

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "class", "card card-body bg-light mt-5");
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(6, "\r\n\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n\r\n    ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "form-group row");
                __builder2.AddMarkupContent(11, "\r\n        ");
                __builder2.AddMarkupContent(12, "<label for=\"CarName\" class=\"col-md-2 col-form-label\">Car Name:</label>\r\n        ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "col-md-10");
                __builder2.AddMarkupContent(15, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(16);
                __builder2.AddAttribute(17, "id", "CarName");
                __builder2.AddAttribute(18, "class", "form-control");
                __builder2.AddAttribute(19, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 12 "C:\Users\Admin\Documents\GitHub\CarSell\CarSell\CarSell.Blazor\Pages\CreatePage\CreateCar.razor"
                                                                      _car.CarName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _car.CarName = __value, _car.CarName))));
                __builder2.AddAttribute(21, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _car.CarName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(22, "\r\n            ");
                __Blazor.CarSell.Blazor.Pages.CreatePage.CreateCar.TypeInference.CreateValidationMessage_0(__builder2, 23, 24, 
#nullable restore
#line 13 "C:\Users\Admin\Documents\GitHub\CarSell\CarSell\CarSell.Blazor\Pages\CreatePage\CreateCar.razor"
                                      () => _car.CarName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(25, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n\r\n    ");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "form-group row");
                __builder2.AddMarkupContent(30, "\r\n        ");
                __builder2.AddMarkupContent(31, "<label for=\"Price\" class=\"col-md-2 col-form-label\">Price:</label>\r\n        ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "col-md-10");
                __builder2.AddMarkupContent(34, "\r\n            ");
                __Blazor.CarSell.Blazor.Pages.CreatePage.CreateCar.TypeInference.CreateInputNumber_1(__builder2, 35, 36, "Price", 37, "form-control", 38, 
#nullable restore
#line 20 "C:\Users\Admin\Documents\GitHub\CarSell\CarSell\CarSell.Blazor\Pages\CreatePage\CreateCar.razor"
                                                                      _car.Price

#line default
#line hidden
#nullable disable
                , 39, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _car.Price = __value, _car.Price)), 40, () => _car.Price);
                __builder2.AddMarkupContent(41, "\r\n            ");
                __Blazor.CarSell.Blazor.Pages.CreatePage.CreateCar.TypeInference.CreateValidationMessage_2(__builder2, 42, 43, 
#nullable restore
#line 21 "C:\Users\Admin\Documents\GitHub\CarSell\CarSell\CarSell.Blazor\Pages\CreatePage\CreateCar.razor"
                                      () => _car.Price

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(44, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n\r\n    ");
                __builder2.OpenElement(47, "div");
                __builder2.AddAttribute(48, "class", "form-group row");
                __builder2.AddMarkupContent(49, "\r\n        ");
                __builder2.AddMarkupContent(50, "<label for=\"imageurl\" class=\"col-md-2 col-form-label\">Image:</label>\r\n        ");
                __builder2.OpenElement(51, "div");
                __builder2.AddAttribute(52, "class", "col-md-10");
                __builder2.AddMarkupContent(53, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(54);
                __builder2.AddAttribute(55, "id", "imageurl");
                __builder2.AddAttribute(56, "class", "form-control");
                __builder2.AddAttribute(57, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "C:\Users\Admin\Documents\GitHub\CarSell\CarSell\CarSell.Blazor\Pages\CreatePage\CreateCar.razor"
                                                                       _car.Image

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(58, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _car.Image = __value, _car.Image))));
                __builder2.AddAttribute(59, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _car.Image));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(60, "\r\n\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(62, "\r\n\r\n    ");
                __builder2.OpenElement(63, "div");
                __builder2.AddAttribute(64, "class", "form-group row");
                __builder2.AddMarkupContent(65, "\r\n        ");
                __builder2.AddMarkupContent(66, "<label for=\"YearOfRelease\" class=\"col-md-2 col-form-label\">Yeara of release:</label>\r\n        ");
                __builder2.OpenElement(67, "div");
                __builder2.AddAttribute(68, "class", "col-md-10");
                __builder2.AddMarkupContent(69, "\r\n            ");
                __Blazor.CarSell.Blazor.Pages.CreatePage.CreateCar.TypeInference.CreateInputNumber_3(__builder2, 70, 71, "YearOfRelease", 72, "form-control", 73, 
#nullable restore
#line 36 "C:\Users\Admin\Documents\GitHub\CarSell\CarSell\CarSell.Blazor\Pages\CreatePage\CreateCar.razor"
                                                                              _car.YearOfRelease

#line default
#line hidden
#nullable disable
                , 74, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _car.YearOfRelease = __value, _car.YearOfRelease)), 75, () => _car.YearOfRelease);
                __builder2.AddMarkupContent(76, "\r\n            ");
                __Blazor.CarSell.Blazor.Pages.CreatePage.CreateCar.TypeInference.CreateValidationMessage_4(__builder2, 77, 78, 
#nullable restore
#line 37 "C:\Users\Admin\Documents\GitHub\CarSell\CarSell\CarSell.Blazor\Pages\CreatePage\CreateCar.razor"
                                      () => _car.YearOfRelease

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(79, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(80, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(81, "\r\n\r\n    ");
                __builder2.OpenElement(82, "div");
                __builder2.AddAttribute(83, "class", "form-group row");
                __builder2.AddMarkupContent(84, "\r\n        ");
                __builder2.AddMarkupContent(85, "<label for=\"region\" class=\"col-md-2 col-form-label\">Region of Sale:</label>\r\n        ");
                __builder2.OpenElement(86, "div");
                __builder2.AddAttribute(87, "class", "col-md-10");
                __builder2.AddMarkupContent(88, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(89);
                __builder2.AddAttribute(90, "id", "region");
                __builder2.AddAttribute(91, "class", "form-control");
                __builder2.AddAttribute(92, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 44 "C:\Users\Admin\Documents\GitHub\CarSell\CarSell\CarSell.Blazor\Pages\CreatePage\CreateCar.razor"
                                                                     _car.Region

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(93, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _car.Region = __value, _car.Region))));
                __builder2.AddAttribute(94, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _car.Region));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(95, "\r\n            ");
                __Blazor.CarSell.Blazor.Pages.CreatePage.CreateCar.TypeInference.CreateValidationMessage_5(__builder2, 96, 97, 
#nullable restore
#line 45 "C:\Users\Admin\Documents\GitHub\CarSell\CarSell\CarSell.Blazor\Pages\CreatePage\CreateCar.razor"
                                      () => _car.Region

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(98, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(99, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(100, "\r\n\r\n    ");
                __builder2.OpenElement(101, "div");
                __builder2.AddAttribute(102, "class", "form-group row");
                __builder2.AddMarkupContent(103, "\r\n        ");
                __builder2.AddMarkupContent(104, "<label for=\"manufacturerid\" class=\"col-md-2 col-form-label\">Manufacturer:</label>\r\n        ");
                __builder2.OpenElement(105, "div");
                __builder2.AddAttribute(106, "class", "col-md-10");
                __builder2.AddMarkupContent(107, "\r\n            ");
                __Blazor.CarSell.Blazor.Pages.CreatePage.CreateCar.TypeInference.CreateInputNumber_6(__builder2, 108, 109, "manufacturerid", 110, "form-control", 111, 
#nullable restore
#line 52 "C:\Users\Admin\Documents\GitHub\CarSell\CarSell\CarSell.Blazor\Pages\CreatePage\CreateCar.razor"
                                                                               _car.ManufacturerId

#line default
#line hidden
#nullable disable
                , 112, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _car.ManufacturerId = __value, _car.ManufacturerId)), 113, () => _car.ManufacturerId);
                __builder2.AddMarkupContent(114, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(115, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(116, "\r\n\r\n\r\n\r\n    ");
                __builder2.AddMarkupContent(117, "<div class=\"row\">\r\n        <div class=\"col-md-12 text-right\">\r\n            <button type=\"submit\" class=\"btn btn-success\">Create</button>\r\n        </div>\r\n    </div>\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(118, "\r\n");
            __builder.OpenComponent<CarSell.Blazor.Shared.SuccessfulNotification>(119);
            __builder.AddComponentReferenceCapture(120, (__value) => {
#nullable restore
#line 64 "C:\Users\Admin\Documents\GitHub\CarSell\CarSell\CarSell.Blazor\Pages\CreatePage\CreateCar.razor"
                              _notification = (CarSell.Blazor.Shared.SuccessfulNotification)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.CarSell.Blazor.Pages.CreatePage.CreateCar
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
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591