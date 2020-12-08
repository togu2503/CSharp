#pragma checksum "D:\OneDrive\Studying\C#\semestr2\WebUniversity\WebUniversity\Pages\Posts\ListPosts.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "615f304aae806cd09b9bc8dd2696ac33602013ff"
// <auto-generated/>
#pragma warning disable 1591
namespace WebUniversity.Pages.Posts
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\OneDrive\Studying\C#\semestr2\WebUniversity\WebUniversity\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\OneDrive\Studying\C#\semestr2\WebUniversity\WebUniversity\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\OneDrive\Studying\C#\semestr2\WebUniversity\WebUniversity\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\OneDrive\Studying\C#\semestr2\WebUniversity\WebUniversity\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\OneDrive\Studying\C#\semestr2\WebUniversity\WebUniversity\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\OneDrive\Studying\C#\semestr2\WebUniversity\WebUniversity\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\OneDrive\Studying\C#\semestr2\WebUniversity\WebUniversity\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\OneDrive\Studying\C#\semestr2\WebUniversity\WebUniversity\_Imports.razor"
using WebUniversity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\OneDrive\Studying\C#\semestr2\WebUniversity\WebUniversity\_Imports.razor"
using WebUniversity.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\OneDrive\Studying\C#\semestr2\WebUniversity\WebUniversity\_Imports.razor"
using WebUniversity.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\OneDrive\Studying\C#\semestr2\WebUniversity\WebUniversity\_Imports.razor"
using WebUniversity.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/listposts")]
    public partial class ListPosts : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Posts</h2>\r\n");
            __builder.AddMarkupContent(1, "<p>\r\n    <a href=\"/addpost\">Create New Post</a>\r\n</p>\r\n");
#nullable restore
#line 8 "D:\OneDrive\Studying\C#\semestr2\WebUniversity\WebUniversity\Pages\Posts\ListPosts.razor"
 if (posts == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.AddMarkupContent(3, "<p>Loading page...</p>\r\n");
#nullable restore
#line 11 "D:\OneDrive\Studying\C#\semestr2\WebUniversity\WebUniversity\Pages\Posts\ListPosts.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "table");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.AddMarkupContent(8, "<thead>\r\n            <tr>\r\n                <th>Id</th>\r\n                <th>Title</th>\r\n                <th>Salary</th>\r\n                <th>Actions</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(9, "tbody");
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 24 "D:\OneDrive\Studying\C#\semestr2\WebUniversity\WebUniversity\Pages\Posts\ListPosts.razor"
             foreach (var post in posts)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "                ");
            __builder.OpenElement(12, "tr");
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 27 "D:\OneDrive\Studying\C#\semestr2\WebUniversity\WebUniversity\Pages\Posts\ListPosts.razor"
                         post.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 28 "D:\OneDrive\Studying\C#\semestr2\WebUniversity\WebUniversity\Pages\Posts\ListPosts.razor"
                         post.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 29 "D:\OneDrive\Studying\C#\semestr2\WebUniversity\WebUniversity\Pages\Posts\ListPosts.razor"
                         post.Salary

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.OpenElement(23, "td");
            __builder.AddMarkupContent(24, "\r\n                        ");
            __builder.OpenElement(25, "a");
            __builder.AddAttribute(26, "href", "/editpost/" + (
#nullable restore
#line 31 "D:\OneDrive\Studying\C#\semestr2\WebUniversity\WebUniversity\Pages\Posts\ListPosts.razor"
                                            post.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(27, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                        ");
            __builder.OpenElement(29, "a");
            __builder.AddAttribute(30, "href", "/deletepost/" + (
#nullable restore
#line 32 "D:\OneDrive\Studying\C#\semestr2\WebUniversity\WebUniversity\Pages\Posts\ListPosts.razor"
                                              post.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(31, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n");
#nullable restore
#line 35 "D:\OneDrive\Studying\C#\semestr2\WebUniversity\WebUniversity\Pages\Posts\ListPosts.razor"

            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(35, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n");
#nullable restore
#line 39 "D:\OneDrive\Studying\C#\semestr2\WebUniversity\WebUniversity\Pages\Posts\ListPosts.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "D:\OneDrive\Studying\C#\semestr2\WebUniversity\WebUniversity\Pages\Posts\ListPosts.razor"
       
    List<Post> posts;

    protected override async Task OnInitializedAsync()
    {
        posts = await PostService.GetPosts();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPostService PostService { get; set; }
    }
}
#pragma warning restore 1591
