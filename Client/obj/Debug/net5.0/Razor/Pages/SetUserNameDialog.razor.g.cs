#pragma checksum "C:\Users\kengh\OneDrive\Desktop\KH Stuff\Projects\ChatApplication\Client\Pages\SetUserNameDialog.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f8c9bdcd95a1c0f9b0ce2fb82ebda6227cb7fab"
// <auto-generated/>
#pragma warning disable 1591
namespace ChatApplication.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\kengh\OneDrive\Desktop\KH Stuff\Projects\ChatApplication\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kengh\OneDrive\Desktop\KH Stuff\Projects\ChatApplication\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kengh\OneDrive\Desktop\KH Stuff\Projects\ChatApplication\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\kengh\OneDrive\Desktop\KH Stuff\Projects\ChatApplication\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\kengh\OneDrive\Desktop\KH Stuff\Projects\ChatApplication\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\kengh\OneDrive\Desktop\KH Stuff\Projects\ChatApplication\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\kengh\OneDrive\Desktop\KH Stuff\Projects\ChatApplication\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\kengh\OneDrive\Desktop\KH Stuff\Projects\ChatApplication\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\kengh\OneDrive\Desktop\KH Stuff\Projects\ChatApplication\Client\_Imports.razor"
using ChatApplication.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\kengh\OneDrive\Desktop\KH Stuff\Projects\ChatApplication\Client\_Imports.razor"
using ChatApplication.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\kengh\OneDrive\Desktop\KH Stuff\Projects\ChatApplication\Client\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
    public partial class SetUserNameDialog : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudDialog>(0);
            __builder.AddAttribute(1, "DialogContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(2, "div");
                __builder2.AddAttribute(3, "class", "d-flex flex-column py-1");
                __Blazor.ChatApplication.Client.Pages.SetUserNameDialog.TypeInference.CreateMudTextField_0(__builder2, 4, 5, "Set Name", 6, 
#nullable restore
#line 4 "C:\Users\kengh\OneDrive\Desktop\KH Stuff\Projects\ChatApplication\Client\Pages\SetUserNameDialog.razor"
                                                                           Variant.Outlined

#line default
#line hidden
#nullable disable
                , 7, 
#nullable restore
#line 4 "C:\Users\kengh\OneDrive\Desktop\KH Stuff\Projects\ChatApplication\Client\Pages\SetUserNameDialog.razor"
                                       UserName

#line default
#line hidden
#nullable disable
                , 8, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => UserName = __value, UserName)));
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(9, "DialogActions", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudButton>(10);
                __builder2.AddAttribute(11, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 8 "C:\Users\kengh\OneDrive\Desktop\KH Stuff\Projects\ChatApplication\Client\Pages\SetUserNameDialog.razor"
                          Color.Primary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\kengh\OneDrive\Desktop\KH Stuff\Projects\ChatApplication\Client\Pages\SetUserNameDialog.razor"
                                                  Save

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(14, "Set");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "C:\Users\kengh\OneDrive\Desktop\KH Stuff\Projects\ChatApplication\Client\Pages\SetUserNameDialog.razor"
       
    [CascadingParameter] MudDialogInstance MudDialog { get; set; }
    public string UserName { get; set; }

    void Save() => MudDialog.Close(DialogResult.Ok(UserName));

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.ChatApplication.Client.Pages.SetUserNameDialog
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTextField_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Variant __arg1, int __seq2, T __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg3)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Variant", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
