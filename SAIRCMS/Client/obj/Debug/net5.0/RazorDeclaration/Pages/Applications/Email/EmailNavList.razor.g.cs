// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SAIRCMS.Client.Pages.Applications.Email
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Aayush - My Files\Phoe\Aayush\SaiRc\SAIRCMS\SAIRCMS\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Aayush - My Files\Phoe\Aayush\SaiRc\SAIRCMS\SAIRCMS\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Aayush - My Files\Phoe\Aayush\SaiRc\SAIRCMS\SAIRCMS\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Aayush - My Files\Phoe\Aayush\SaiRc\SAIRCMS\SAIRCMS\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Aayush - My Files\Phoe\Aayush\SaiRc\SAIRCMS\SAIRCMS\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Aayush - My Files\Phoe\Aayush\SaiRc\SAIRCMS\SAIRCMS\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Aayush - My Files\Phoe\Aayush\SaiRc\SAIRCMS\SAIRCMS\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Aayush - My Files\Phoe\Aayush\SaiRc\SAIRCMS\SAIRCMS\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Aayush - My Files\Phoe\Aayush\SaiRc\SAIRCMS\SAIRCMS\Client\_Imports.razor"
using SAIRCMS.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Aayush - My Files\Phoe\Aayush\SaiRc\SAIRCMS\SAIRCMS\Client\_Imports.razor"
using SAIRCMS.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Aayush - My Files\Phoe\Aayush\SaiRc\SAIRCMS\SAIRCMS\Client\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Aayush - My Files\Phoe\Aayush\SaiRc\SAIRCMS\SAIRCMS\Client\_Imports.razor"
using MudBlazor.ThemeManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Aayush - My Files\Phoe\Aayush\SaiRc\SAIRCMS\SAIRCMS\Client\_Imports.razor"
using MudBlazor.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Aayush - My Files\Phoe\Aayush\SaiRc\SAIRCMS\SAIRCMS\Client\_Imports.razor"
using SAIRCMS.Domain.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Aayush - My Files\Phoe\Aayush\SaiRc\SAIRCMS\SAIRCMS\Client\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
    public partial class EmailNavList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "D:\Aayush - My Files\Phoe\Aayush\SaiRc\SAIRCMS\SAIRCMS\Client\Pages\Applications\Email\EmailNavList.razor"
       

    [Parameter] public string folder { get; set; }

    public string GetClass(string _folder)
    {
        if (folder == _folder)
        {
            return "my-2 rounded mud-primary-text";
        }
        else
        {
            return "my-2 rounded";
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
