#pragma checksum "E:\timan\TIMAN.Web\Pages\ChinhSuaHangHoa.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a6de9e3d4c24b49fc159c1f9473e301697f9999"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/productedit/{id}")]
    public partial class ChinhSuaHangHoa : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 2 "E:\timan\TIMAN.Web\Pages\ChinhSuaHangHoa.razor"
 if (Product != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "bg-white shadow p-3");
            __builder.OpenElement(2, "h3");
            __builder.AddMarkupContent(3, "Sửa ");
            __builder.AddContent(4, 
#nullable restore
#line 5 "E:\timan\TIMAN.Web\Pages\ChinhSuaHangHoa.razor"
                 Product.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(6);
            __builder.AddAttribute(7, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 7 "E:\timan\TIMAN.Web\Pages\ChinhSuaHangHoa.razor"
                         Product

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 7 "E:\timan\TIMAN.Web\Pages\ChinhSuaHangHoa.razor"
                                                 SubmitProduct

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(10);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n            ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "form-group");
                __builder2.AddMarkupContent(14, "<label for=\"Name\">Tên</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(15);
                __builder2.AddAttribute(16, "class", "form-control");
                __builder2.AddAttribute(17, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 11 "E:\timan\TIMAN.Web\Pages\ChinhSuaHangHoa.razor"
                                                             Product.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Product.Name = __value, Product.Name))));
                __builder2.AddAttribute(19, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Product.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\r\n                ");
                __Blazor.TIMAN.Web.Pages.ChinhSuaHangHoa.TypeInference.CreateValidationMessage_0(__builder2, 21, 22, 
#nullable restore
#line 12 "E:\timan\TIMAN.Web\Pages\ChinhSuaHangHoa.razor"
                                        ()=>Product.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n            ");
                __builder2.OpenElement(24, "div");
                __builder2.AddAttribute(25, "class", "form-group");
                __builder2.AddMarkupContent(26, "<label>Giá</label>\r\n                ");
                __Blazor.TIMAN.Web.Pages.ChinhSuaHangHoa.TypeInference.CreateInputNumber_1(__builder2, 27, 28, "form-control", 29, 
#nullable restore
#line 16 "E:\timan\TIMAN.Web\Pages\ChinhSuaHangHoa.razor"
                                                               Product.Price

#line default
#line hidden
#nullable disable
                , 30, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Product.Price = __value, Product.Price)), 31, () => Product.Price);
                __builder2.AddMarkupContent(32, "\r\n                ");
                __Blazor.TIMAN.Web.Pages.ChinhSuaHangHoa.TypeInference.CreateValidationMessage_2(__builder2, 33, 34, 
#nullable restore
#line 17 "E:\timan\TIMAN.Web\Pages\ChinhSuaHangHoa.razor"
                                        ()=>Product.Price

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n            ");
                __builder2.OpenElement(36, "div");
                __builder2.AddAttribute(37, "class", "form-group");
                __builder2.AddMarkupContent(38, "<label>Hình ảnh</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(39);
                __builder2.AddAttribute(40, "class", "form-control");
                __builder2.AddAttribute(41, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "E:\timan\TIMAN.Web\Pages\ChinhSuaHangHoa.razor"
                                                             Product.ThumbnailImage

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(42, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Product.ThumbnailImage = __value, Product.ThumbnailImage))));
                __builder2.AddAttribute(43, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Product.ThumbnailImage));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(44, "\r\n                ");
                __Blazor.TIMAN.Web.Pages.ChinhSuaHangHoa.TypeInference.CreateValidationMessage_3(__builder2, 45, 46, 
#nullable restore
#line 22 "E:\timan\TIMAN.Web\Pages\ChinhSuaHangHoa.razor"
                                        ()=>Product.ThumbnailImage

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n            ");
                __builder2.OpenElement(48, "div");
                __builder2.AddAttribute(49, "class", "form-group");
                __builder2.AddMarkupContent(50, "<label>Mô tả</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(51);
                __builder2.AddAttribute(52, "class", "form-control");
                __builder2.AddAttribute(53, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "E:\timan\TIMAN.Web\Pages\ChinhSuaHangHoa.razor"
                                                             Product.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(54, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Product.Description = __value, Product.Description))));
                __builder2.AddAttribute(55, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Product.Description));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(56, "\r\n                ");
                __Blazor.TIMAN.Web.Pages.ChinhSuaHangHoa.TypeInference.CreateValidationMessage_4(__builder2, 57, 58, 
#nullable restore
#line 27 "E:\timan\TIMAN.Web\Pages\ChinhSuaHangHoa.razor"
                                        ()=>Product.Description

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n            ");
                __builder2.OpenElement(60, "div");
                __builder2.AddAttribute(61, "class", "form-group");
                __builder2.AddMarkupContent(62, "<label>Loại</label>\r\n                ");
                __Blazor.TIMAN.Web.Pages.ChinhSuaHangHoa.TypeInference.CreateInputSelect_5(__builder2, 63, 64, "form-control", 65, 
#nullable restore
#line 31 "E:\timan\TIMAN.Web\Pages\ChinhSuaHangHoa.razor"
                                                               Product.CategoryId

#line default
#line hidden
#nullable disable
                , 66, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Product.CategoryId = __value, Product.CategoryId)), 67, () => Product.CategoryId, 68, (__builder3) => {
                    __builder3.AddMarkupContent(69, "<option>Chọn loại sản phẩm</option>");
#nullable restore
#line 33 "E:\timan\TIMAN.Web\Pages\ChinhSuaHangHoa.razor"
                     if (Categories != null)
                        {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "E:\timan\TIMAN.Web\Pages\ChinhSuaHangHoa.razor"
                         foreach (var item in Categories)
                            {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(70, "option");
                    __builder3.AddAttribute(71, "value", 
#nullable restore
#line 37 "E:\timan\TIMAN.Web\Pages\ChinhSuaHangHoa.razor"
                                            item.Id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(72, 
#nullable restore
#line 37 "E:\timan\TIMAN.Web\Pages\ChinhSuaHangHoa.razor"
                                                      item.Name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 38 "E:\timan\TIMAN.Web\Pages\ChinhSuaHangHoa.razor"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "E:\timan\TIMAN.Web\Pages\ChinhSuaHangHoa.razor"
                             
                        }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.AddMarkupContent(73, "\r\n                ");
                __Blazor.TIMAN.Web.Pages.ChinhSuaHangHoa.TypeInference.CreateValidationMessage_6(__builder2, 74, 75, 
#nullable restore
#line 41 "E:\timan\TIMAN.Web\Pages\ChinhSuaHangHoa.razor"
                                        ()=>Product.CategoryId

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\r\n\r\n            ");
                __builder2.AddMarkupContent(77, "<button type=\"submit\" class=\"btn btn-primary\">Lưu</button>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 59 "E:\timan\TIMAN.Web\Pages\ChinhSuaHangHoa.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(78, "<div>Loading...</div>");
#nullable restore
#line 63 "E:\timan\TIMAN.Web\Pages\ChinhSuaHangHoa.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.TIMAN.Web.Pages.ChinhSuaHangHoa
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
