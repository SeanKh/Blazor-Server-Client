#pragma checksum "/home/skhaydarov/projects/BlazorProject/Blazor-Server-Client/Pages/SendData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5ce364477fbaf2b538a56b9b651f6b676d2ce65"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WebApplication1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/skhaydarov/projects/BlazorProject/Blazor-Server-Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/skhaydarov/projects/BlazorProject/Blazor-Server-Client/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/skhaydarov/projects/BlazorProject/Blazor-Server-Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/skhaydarov/projects/BlazorProject/Blazor-Server-Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/skhaydarov/projects/BlazorProject/Blazor-Server-Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/skhaydarov/projects/BlazorProject/Blazor-Server-Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/skhaydarov/projects/BlazorProject/Blazor-Server-Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/skhaydarov/projects/BlazorProject/Blazor-Server-Client/_Imports.razor"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/skhaydarov/projects/BlazorProject/Blazor-Server-Client/_Imports.razor"
using WebApplication1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/skhaydarov/projects/BlazorProject/Blazor-Server-Client/_Imports.razor"
using WebApplication1.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/skhaydarov/projects/BlazorProject/Blazor-Server-Client/Pages/SendData.razor"
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
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "/home/skhaydarov/projects/BlazorProject/Blazor-Server-Client/Pages/SendData.razor"
       
    private List<string> _messages = new List<string>();
    private string _messageInput;
    public void Send()
    {
        bool callback=ReservationService.GetReservationAsync(DateTime.Now,_messageInput);
        //Console.WriteLine("Send");
        //ToastMessage();
        if(callback){
             toastService.ShowToast("Created type1.txt with: "+ _messageInput, ToastLevel.Info);
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
