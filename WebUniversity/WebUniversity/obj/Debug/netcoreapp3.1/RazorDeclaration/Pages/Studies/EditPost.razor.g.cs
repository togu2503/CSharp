#pragma checksum "D:\OneDrive\WebUniversity\WebUniversity\Pages\Studies\EditPost.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94d61e92936ee92363af73ebf74e119264526b90"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WebUniversity.Pages.Studies
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\OneDrive\WebUniversity\WebUniversity\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\OneDrive\WebUniversity\WebUniversity\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\OneDrive\WebUniversity\WebUniversity\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\OneDrive\WebUniversity\WebUniversity\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\OneDrive\WebUniversity\WebUniversity\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\OneDrive\WebUniversity\WebUniversity\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\OneDrive\WebUniversity\WebUniversity\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\OneDrive\WebUniversity\WebUniversity\_Imports.razor"
using WebUniversity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\OneDrive\WebUniversity\WebUniversity\_Imports.razor"
using WebUniversity.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\OneDrive\WebUniversity\WebUniversity\_Imports.razor"
using WebUniversity.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\OneDrive\WebUniversity\WebUniversity\_Imports.razor"
using WebUniversity.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\OneDrive\WebUniversity\WebUniversity\_Imports.razor"
using WebUniversity.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/editpost/{id}")]
    public partial class EditPost : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "D:\OneDrive\WebUniversity\WebUniversity\Pages\Studies\EditPost.razor"
       

    [Parameter]
    public string id { get; set; }

    study study = new study();

    protected override async Task OnInitializedAsync()
    {
        study = await PostService.SinglePost(Convert.ToInt64(id));
    }

    protected async Task UpdateEmployee()
    {
        await PostService.EditPost(Convert.ToInt64(id), study);
        NavigationManager.NavigateTo("listposts");
    }

    void Cancel()
    {
        NavigationManager.NavigateTo("listposts");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPostService PostService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
