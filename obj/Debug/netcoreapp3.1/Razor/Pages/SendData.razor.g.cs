#pragma checksum "/Users/shukhratkhaydarov/Desktop/PTX/WebApplication1/Pages/SendData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ebfa5e5735f7d5829306a9f2a365b6f9ced4f3d"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApplication1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/shukhratkhaydarov/Desktop/PTX/WebApplication1/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/shukhratkhaydarov/Desktop/PTX/WebApplication1/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/shukhratkhaydarov/Desktop/PTX/WebApplication1/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/shukhratkhaydarov/Desktop/PTX/WebApplication1/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/shukhratkhaydarov/Desktop/PTX/WebApplication1/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/shukhratkhaydarov/Desktop/PTX/WebApplication1/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/shukhratkhaydarov/Desktop/PTX/WebApplication1/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/shukhratkhaydarov/Desktop/PTX/WebApplication1/_Imports.razor"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/shukhratkhaydarov/Desktop/PTX/WebApplication1/_Imports.razor"
using WebApplication1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/shukhratkhaydarov/Desktop/PTX/WebApplication1/_Imports.razor"
using WebApplication1.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/shukhratkhaydarov/Desktop/PTX/WebApplication1/Pages/SendData.razor"
using WebApplication1.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/senddata")]
    public partial class SendData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "form-group");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "label");
            __builder.AddMarkupContent(4, "\r\n        Message:\r\n        ");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "size", "50");
            __builder.AddAttribute(7, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "/Users/shukhratkhaydarov/Desktop/PTX/WebApplication1/Pages/SendData.razor"
                      _messageInput

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _messageInput = __value, _messageInput));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n");
            __builder.OpenElement(12, "button");
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "/Users/shukhratkhaydarov/Desktop/PTX/WebApplication1/Pages/SendData.razor"
                  Send

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(14, "Send");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "/Users/shukhratkhaydarov/Desktop/PTX/WebApplication1/Pages/SendData.razor"
       
    private List<string> _messages = new List<string>();
    private string _messageInput;
    public void Send()
    {
        bool callback=ReservationService.GetReservationAsync(DateTime.Now,_messageInput);
        //Console.WriteLine("Send");
        //ToastMessage();
        if(callback){
             toastService.ShowToast("Created file with: "+ _messageInput, ToastLevel.Info);
        }

    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ReservationService ReservationService { get; set; }
    }
}
#pragma warning restore 1591