#pragma checksum "D:\Aayush - My Files\Phoe\Aayush\SaiRc\SAIRCMS\SAIRCMS\Client\Pages\Applications\Email\EmailNavList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60d3d4a8fc86315d095e95a3b37f0851b251a67f"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.OpenComponent<MudBlazor.MudList>(0);
            __builder.AddAttribute(1, "Clickable", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 1 "D:\Aayush - My Files\Phoe\Aayush\SaiRc\SAIRCMS\SAIRCMS\Client\Pages\Applications\Email\EmailNavList.razor"
                    true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudListItem>(3);
                __builder2.AddAttribute(4, "Href", "/application/email/inbox");
                __builder2.AddAttribute(5, "Text", "Inbox");
                __builder2.AddAttribute(6, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 2 "D:\Aayush - My Files\Phoe\Aayush\SaiRc\SAIRCMS\SAIRCMS\Client\Pages\Applications\Email\EmailNavList.razor"
                                                                     Icons.Material.Outlined.Inbox

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(7, "Dense", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 2 "D:\Aayush - My Files\Phoe\Aayush\SaiRc\SAIRCMS\SAIRCMS\Client\Pages\Applications\Email\EmailNavList.razor"
                                                                                                           true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(8, "Class", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 2 "D:\Aayush - My Files\Phoe\Aayush\SaiRc\SAIRCMS\SAIRCMS\Client\Pages\Applications\Email\EmailNavList.razor"
                                                                                                                         GetClass("inbox")

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\n    ");
                __builder2.OpenComponent<MudBlazor.MudListItem>(10);
                __builder2.AddAttribute(11, "Href", "/application/email/sent");
                __builder2.AddAttribute(12, "Text", "Sent");
                __builder2.AddAttribute(13, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 3 "D:\Aayush - My Files\Phoe\Aayush\SaiRc\SAIRCMS\SAIRCMS\Client\Pages\Applications\Email\EmailNavList.razor"
                                                                   Icons.Material.Outlined.Send

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "Dense", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 3 "D:\Aayush - My Files\Phoe\Aayush\SaiRc\SAIRCMS\SAIRCMS\Client\Pages\Applications\Email\EmailNavList.razor"
                                                                                                        true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "Class", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 3 "D:\Aayush - My Files\Phoe\Aayush\SaiRc\SAIRCMS\SAIRCMS\Client\Pages\Applications\Email\EmailNavList.razor"
                                                                                                                      GetClass("sent")

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\n    ");
                __builder2.OpenComponent<MudBlazor.MudListItem>(17);
                __builder2.AddAttribute(18, "Href", "/application/email/drafts");
                __builder2.AddAttribute(19, "Text", "Drafts");
                __builder2.AddAttribute(20, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 4 "D:\Aayush - My Files\Phoe\Aayush\SaiRc\SAIRCMS\SAIRCMS\Client\Pages\Applications\Email\EmailNavList.razor"
                                                                       Icons.Material.Outlined.Drafts

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "Dense", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 4 "D:\Aayush - My Files\Phoe\Aayush\SaiRc\SAIRCMS\SAIRCMS\Client\Pages\Applications\Email\EmailNavList.razor"
                                                                                                              true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "Class", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 4 "D:\Aayush - My Files\Phoe\Aayush\SaiRc\SAIRCMS\SAIRCMS\Client\Pages\Applications\Email\EmailNavList.razor"
                                                                                                                            GetClass("drafts")

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(23, "\n    ");
                __builder2.OpenComponent<MudBlazor.MudListItem>(24);
                __builder2.AddAttribute(25, "Href", "/application/email/starred");
                __builder2.AddAttribute(26, "Text", "Starred");
                __builder2.AddAttribute(27, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 5 "D:\Aayush - My Files\Phoe\Aayush\SaiRc\SAIRCMS\SAIRCMS\Client\Pages\Applications\Email\EmailNavList.razor"
                                                                         Icons.Material.Outlined.StarRate

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "Dense", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 5 "D:\Aayush - My Files\Phoe\Aayush\SaiRc\SAIRCMS\SAIRCMS\Client\Pages\Applications\Email\EmailNavList.razor"
                                                                                                                  true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "Class", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 5 "D:\Aayush - My Files\Phoe\Aayush\SaiRc\SAIRCMS\SAIRCMS\Client\Pages\Applications\Email\EmailNavList.razor"
                                                                                                                                GetClass("starred")

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(30, "\n    ");
                __builder2.OpenComponent<MudBlazor.MudListItem>(31);
                __builder2.AddAttribute(32, "Href", "/application/email/trash");
                __builder2.AddAttribute(33, "Text", "Trash");
                __builder2.AddAttribute(34, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 6 "D:\Aayush - My Files\Phoe\Aayush\SaiRc\SAIRCMS\SAIRCMS\Client\Pages\Applications\Email\EmailNavList.razor"
                                                                     Icons.Material.Outlined.Delete

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "Dense", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 6 "D:\Aayush - My Files\Phoe\Aayush\SaiRc\SAIRCMS\SAIRCMS\Client\Pages\Applications\Email\EmailNavList.razor"
                                                                                                            true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(36, "Class", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 6 "D:\Aayush - My Files\Phoe\Aayush\SaiRc\SAIRCMS\SAIRCMS\Client\Pages\Applications\Email\EmailNavList.razor"
                                                                                                                          GetClass("trash")

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(37, "\n    ");
                __builder2.OpenComponent<MudBlazor.MudListSubheader>(38);
                __builder2.AddAttribute(39, "Class", "mt-6 mb-n4");
                __builder2.AddAttribute(40, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(41, "\n        Labels\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(42, "\n    ");
                __builder2.OpenComponent<MudBlazor.MudListItem>(43);
                __builder2.AddAttribute(44, "Text", "Work");
                __builder2.AddAttribute(45, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 10 "D:\Aayush - My Files\Phoe\Aayush\SaiRc\SAIRCMS\SAIRCMS\Client\Pages\Applications\Email\EmailNavList.razor"
                                    Icons.Material.Outlined.Label

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(46, "IconColor", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 10 "D:\Aayush - My Files\Phoe\Aayush\SaiRc\SAIRCMS\SAIRCMS\Client\Pages\Applications\Email\EmailNavList.razor"
                                                                              Color.Info

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(47, "Dense", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 10 "D:\Aayush - My Files\Phoe\Aayush\SaiRc\SAIRCMS\SAIRCMS\Client\Pages\Applications\Email\EmailNavList.razor"
                                                                                                 true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(48, "Class", "my-2 rounded");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(49, "\n    ");
                __builder2.OpenComponent<MudBlazor.MudListItem>(50);
                __builder2.AddAttribute(51, "Text", "Invoices");
                __builder2.AddAttribute(52, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 11 "D:\Aayush - My Files\Phoe\Aayush\SaiRc\SAIRCMS\SAIRCMS\Client\Pages\Applications\Email\EmailNavList.razor"
                                        Icons.Material.Outlined.Label

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(53, "IconColor", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 11 "D:\Aayush - My Files\Phoe\Aayush\SaiRc\SAIRCMS\SAIRCMS\Client\Pages\Applications\Email\EmailNavList.razor"
                                                                                  Color.Success

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(54, "Dense", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 11 "D:\Aayush - My Files\Phoe\Aayush\SaiRc\SAIRCMS\SAIRCMS\Client\Pages\Applications\Email\EmailNavList.razor"
                                                                                                        true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(55, "Class", "my-2 rounded");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(56, "\n    ");
                __builder2.OpenComponent<MudBlazor.MudListItem>(57);
                __builder2.AddAttribute(58, "Text", "Social");
                __builder2.AddAttribute(59, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 12 "D:\Aayush - My Files\Phoe\Aayush\SaiRc\SAIRCMS\SAIRCMS\Client\Pages\Applications\Email\EmailNavList.razor"
                                      Icons.Material.Outlined.Label

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(60, "IconColor", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 12 "D:\Aayush - My Files\Phoe\Aayush\SaiRc\SAIRCMS\SAIRCMS\Client\Pages\Applications\Email\EmailNavList.razor"
                                                                                Color.Warning

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(61, "Dense", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 12 "D:\Aayush - My Files\Phoe\Aayush\SaiRc\SAIRCMS\SAIRCMS\Client\Pages\Applications\Email\EmailNavList.razor"
                                                                                                      true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(62, "Class", "my-2 rounded");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(63, "\n    ");
                __builder2.OpenComponent<MudBlazor.MudListItem>(64);
                __builder2.AddAttribute(65, "Text", "Orders");
                __builder2.AddAttribute(66, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 13 "D:\Aayush - My Files\Phoe\Aayush\SaiRc\SAIRCMS\SAIRCMS\Client\Pages\Applications\Email\EmailNavList.razor"
                                      Icons.Material.Outlined.Label

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(67, "IconColor", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 13 "D:\Aayush - My Files\Phoe\Aayush\SaiRc\SAIRCMS\SAIRCMS\Client\Pages\Applications\Email\EmailNavList.razor"
                                                                                Color.Error

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(68, "Dense", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 13 "D:\Aayush - My Files\Phoe\Aayush\SaiRc\SAIRCMS\SAIRCMS\Client\Pages\Applications\Email\EmailNavList.razor"
                                                                                                    true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(69, "Class", "my-2 rounded");
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
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
