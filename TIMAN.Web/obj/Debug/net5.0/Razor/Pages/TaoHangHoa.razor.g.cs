#pragma checksum "E:\timan\TIMAN.Web\Pages\TaoHangHoa.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ae77cebcf707842e0fe831ee7c5d4f158584495"
// <auto-generated/>
#pragma warning disable 1591
namespace TIMAN.Web.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\timan\TIMAN.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\timan\TIMAN.Web\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\timan\TIMAN.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\timan\TIMAN.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\timan\TIMAN.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\timan\TIMAN.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\timan\TIMAN.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\timan\TIMAN.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\timan\TIMAN.Web\_Imports.razor"
using TIMAN.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\timan\TIMAN.Web\_Imports.razor"
using TIMAN.Web.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/productcreate")]
    public partial class TaoHangHoa : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "bg-white shadow p-3");
            __builder.AddMarkupContent(2, "<h3>Th??m s???n ph???m</h3>\r\n\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(3);
            __builder.AddAttribute(4, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 5 "E:\timan\TIMAN.Web\Pages\TaoHangHoa.razor"
                     Product

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 5 "E:\timan\TIMAN.Web\Pages\TaoHangHoa.razor"
                                             SubmitProduct

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n        ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "form-group");
                __builder2.AddMarkupContent(11, "<label for=\"Name\">T??n</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(12);
                __builder2.AddAttribute(13, "class", "form-control");
                __builder2.AddAttribute(14, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 9 "E:\timan\TIMAN.Web\Pages\TaoHangHoa.razor"
                                                         Product.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Product.Name = __value, Product.Name))));
                __builder2.AddAttribute(16, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Product.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n            ");
                __Blazor.TIMAN.Web.Pages.TaoHangHoa.TypeInference.CreateValidationMessage_0(__builder2, 18, 19, 
#nullable restore
#line 10 "E:\timan\TIMAN.Web\Pages\TaoHangHoa.razor"
                                    ()=>Product.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n        ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "form-group");
                __builder2.AddMarkupContent(23, "<label>Gi??</label>\r\n            ");
                __Blazor.TIMAN.Web.Pages.TaoHangHoa.TypeInference.CreateInputNumber_1(__builder2, 24, 25, "form-control", 26, 
#nullable restore
#line 14 "E:\timan\TIMAN.Web\Pages\TaoHangHoa.razor"
                                                           Product.Price

#line default
#line hidden
#nullable disable
                , 27, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Product.Price = __value, Product.Price)), 28, () => Product.Price);
                __builder2.AddMarkupContent(29, "\r\n            ");
                __Blazor.TIMAN.Web.Pages.TaoHangHoa.TypeInference.CreateValidationMessage_2(__builder2, 30, 31, 
#nullable restore
#line 15 "E:\timan\TIMAN.Web\Pages\TaoHangHoa.razor"
                                    ()=>Product.Price

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n        ");
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "form-group");
                __builder2.AddMarkupContent(35, "<label>H??nh ???nh</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(36);
                __builder2.AddAttribute(37, "class", "form-control");
                __builder2.AddAttribute(38, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "E:\timan\TIMAN.Web\Pages\TaoHangHoa.razor"
                                                         Product.ThumbnailImage

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(39, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Product.ThumbnailImage = __value, Product.ThumbnailImage))));
                __builder2.AddAttribute(40, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Product.ThumbnailImage));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(41, "\r\n            ");
                __Blazor.TIMAN.Web.Pages.TaoHangHoa.TypeInference.CreateValidationMessage_3(__builder2, 42, 43, 
#nullable restore
#line 20 "E:\timan\TIMAN.Web\Pages\TaoHangHoa.razor"
                                    ()=>Product.ThumbnailImage

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n        ");
                __builder2.OpenElement(45, "div");
                __builder2.AddAttribute(46, "class", "form-group");
                __builder2.AddMarkupContent(47, "<label>M?? t???</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(48);
                __builder2.AddAttribute(49, "class", "form-control");
                __builder2.AddAttribute(50, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "E:\timan\TIMAN.Web\Pages\TaoHangHoa.razor"
                                                         Product.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(51, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Product.Description = __value, Product.Description))));
                __builder2.AddAttribute(52, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Product.Description));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(53, "\r\n            ");
                __Blazor.TIMAN.Web.Pages.TaoHangHoa.TypeInference.CreateValidationMessage_4(__builder2, 54, 55, 
#nullable restore
#line 25 "E:\timan\TIMAN.Web\Pages\TaoHangHoa.razor"
                                    ()=>Product.Description

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n        ");
                __builder2.OpenElement(57, "div");
                __builder2.AddAttribute(58, "class", "form-group");
                __builder2.AddMarkupContent(59, "<label>Lo???i</label>\r\n            ");
                __Blazor.TIMAN.Web.Pages.TaoHangHoa.TypeInference.CreateInputSelect_5(__builder2, 60, 61, "form-control", 62, 
#nullable restore
#line 29 "E:\timan\TIMAN.Web\Pages\TaoHangHoa.razor"
                                                           Product.CategoryId

#line default
#line hidden
#nullable disable
                , 63, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Product.CategoryId = __value, Product.CategoryId)), 64, () => Product.CategoryId, 65, (__builder3) => {
                    __builder3.AddMarkupContent(66, "<option>Ch???n lo???i s???n ph???m</option>");
#nullable restore
#line 31 "E:\timan\TIMAN.Web\Pages\TaoHangHoa.razor"
                 if (Categories != null)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "E:\timan\TIMAN.Web\Pages\TaoHangHoa.razor"
                     foreach (var item in Categories)
                    {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(67, "option");
                    __builder3.AddAttribute(68, "value", 
#nullable restore
#line 35 "E:\timan\TIMAN.Web\Pages\TaoHangHoa.razor"
                                        item.Id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(69, 
#nullable restore
#line 35 "E:\timan\TIMAN.Web\Pages\TaoHangHoa.razor"
                                                  item.Name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 36 "E:\timan\TIMAN.Web\Pages\TaoHangHoa.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "E:\timan\TIMAN.Web\Pages\TaoHangHoa.razor"
                     
                }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.AddMarkupContent(70, "\r\n            ");
                __Blazor.TIMAN.Web.Pages.TaoHangHoa.TypeInference.CreateValidationMessage_6(__builder2, 71, 72, 
#nullable restore
#line 39 "E:\timan\TIMAN.Web\Pages\TaoHangHoa.razor"
                                    ()=>Product.CategoryId

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\r\n\r\n        ");
                __builder2.AddMarkupContent(74, "<button type=\"submit\" class=\"btn btn-primary\">L??u</button>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.TIMAN.Web.Pages.TaoHangHoa
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
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
