#pragma checksum "D:\OneDrive\Studying\C#\semestr2\WebUniversity\WebUniversity\Pages\TeacherStudyJoints\ListTeacherStudyJoints.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8b5f88ee29c8819b18f9eccddde03405ac15d51"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WebUniversity.Pages.TeacherStudyJoints
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/listteacherstudyjoints")]
    public partial class ListTeacherStudyJoints : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "D:\OneDrive\Studying\C#\semestr2\WebUniversity\WebUniversity\Pages\TeacherStudyJoints\ListTeacherStudyJoints.razor"
       
    List<TeacherStudyJoint> teacherStudyJoints;

    protected override async Task OnInitializedAsync()
    {
        teacherStudyJoints = await TeacherStudyJointService.GetTeacherStudyJoints();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITeacherStudyJointService TeacherStudyJointService { get; set; }
    }
}
#pragma warning restore 1591
