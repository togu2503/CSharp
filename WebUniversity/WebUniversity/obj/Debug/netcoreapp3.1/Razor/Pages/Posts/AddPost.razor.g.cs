#pragma checksum "D:\OneDrive\Studying\C#\semestr2\WebUniversity\WebUniversity\Pages\Posts\AddPost.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "160a8c4b63532f6af95173156afe64ba5d8e2904"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/addpost")]
    public partial class AddPost : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Create Post</h2>\r\n<hr>\r\n");
            __builder.OpenElement(1, "form");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-md-8");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "form-group");
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.AddMarkupContent(12, "<label for=\"Id\" class=\"control-label\">Id</label>\r\n                ");
            __builder.OpenElement(13, "input");
            __builder.AddAttribute(14, "for", "Id");
            __builder.AddAttribute(15, "class", "form-control");
            __builder.AddAttribute(16, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "D:\OneDrive\Studying\C#\semestr2\WebUniversity\WebUniversity\Pages\Posts\AddPost.razor"
                                                             post.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => post.Id = __value, post.Id));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "form-group");
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.AddMarkupContent(23, "<label for=\"Title\" class=\"control-label\">Title</label>\r\n                ");
            __builder.OpenElement(24, "input");
            __builder.AddAttribute(25, "for", "Title");
            __builder.AddAttribute(26, "class", "form-control");
            __builder.AddAttribute(27, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "D:\OneDrive\Studying\C#\semestr2\WebUniversity\WebUniversity\Pages\Posts\AddPost.razor"
                                                                post.Title

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => post.Title = __value, post.Title));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "form-group");
            __builder.AddMarkupContent(33, "\r\n                ");
            __builder.AddMarkupContent(34, "<label for=\"Salary\" class=\"control-label\">Salary</label>\r\n                ");
            __builder.OpenElement(35, "input");
            __builder.AddAttribute(36, "for", "Salary");
            __builder.AddAttribute(37, "class", "form-control");
            __builder.AddAttribute(38, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "D:\OneDrive\Studying\C#\semestr2\WebUniversity\WebUniversity\Pages\Posts\AddPost.razor"
                                                                 post.Salary

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => post.Salary = __value, post.Salary));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n    ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "row");
            __builder.AddMarkupContent(46, "\r\n        ");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "col-md-4");
            __builder.AddMarkupContent(49, "\r\n            ");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "form-group");
            __builder.AddMarkupContent(52, "\r\n                ");
            __builder.OpenElement(53, "input");
            __builder.AddAttribute(54, "type", "button");
            __builder.AddAttribute(55, "class", "btn btn-primary");
            __builder.AddAttribute(56, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "D:\OneDrive\Studying\C#\semestr2\WebUniversity\WebUniversity\Pages\Posts\AddPost.razor"
                                                                        CreatePost

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(57, "value", "Save");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                ");
            __builder.OpenElement(59, "input");
            __builder.AddAttribute(60, "type", "button");
            __builder.AddAttribute(61, "class", "btn");
            __builder.AddAttribute(62, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "D:\OneDrive\Studying\C#\semestr2\WebUniversity\WebUniversity\Pages\Posts\AddPost.razor"
                                                            Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(63, "value", "Cancel");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "D:\OneDrive\Studying\C#\semestr2\WebUniversity\WebUniversity\Pages\Posts\AddPost.razor"
       

    Post post = new Post();

    protected async Task CreatePost()
    {
        await PostService.CreatePost(post);
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
