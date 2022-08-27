#pragma checksum "D:\gitlab-repo\Assignment 5 - MVC\TSEventApp.Web\Views\Event\ViewDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b25e5024f6e7677f89cfcd5605152886cd66679"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Event_ViewDetails), @"mvc.1.0.view", @"/Views/Event/ViewDetails.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\gitlab-repo\Assignment 5 - MVC\TSEventApp.Web\Views\_ViewImports.cshtml"
using TSEventApp.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\gitlab-repo\Assignment 5 - MVC\TSEventApp.Web\Views\_ViewImports.cshtml"
using TSEventApp.Core.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\gitlab-repo\Assignment 5 - MVC\TSEventApp.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b25e5024f6e7677f89cfcd5605152886cd66679", @"/Views/Event/ViewDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d132f9d95a98e70773a3876bd0f1c58bfcfc755", @"/Views/_ViewImports.cshtml")]
    public class Views_Event_ViewDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EventViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Event", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateEvent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\gitlab-repo\Assignment 5 - MVC\TSEventApp.Web\Views\Event\ViewDetails.cshtml"
  
    ViewData["Title"] = "ViewDetails";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"event-wrapper pt-4\">\r\n    <div class=\"d-flex justify-content-between align-items-center\">\r\n        <h1 class=\"text-center\">");
#nullable restore
#line 8 "D:\gitlab-repo\Assignment 5 - MVC\TSEventApp.Web\Views\Event\ViewDetails.cshtml"
                           Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 9 "D:\gitlab-repo\Assignment 5 - MVC\TSEventApp.Web\Views\Event\ViewDetails.cshtml"
         if (Model.Date >= DateTime.Now)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b25e5024f6e7677f89cfcd5605152886cd666795128", async() => {
                WriteLiteral("Edit <i class=\"fa-solid fa-pen-to-square\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 11 "D:\gitlab-repo\Assignment 5 - MVC\TSEventApp.Web\Views\Event\ViewDetails.cshtml"
                                                                                                    WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n");
#nullable restore
#line 12 "D:\gitlab-repo\Assignment 5 - MVC\TSEventApp.Web\Views\Event\ViewDetails.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n \r\n    <hr />\r\n    <div class=\"row pt-3\">\r\n        <div class=\"col-sm-6\">\r\n            <h4>Description</h4>\r\n");
#nullable restore
#line 20 "D:\gitlab-repo\Assignment 5 - MVC\TSEventApp.Web\Views\Event\ViewDetails.cshtml"
             if (Model.Description != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>");
#nullable restore
#line 22 "D:\gitlab-repo\Assignment 5 - MVC\TSEventApp.Web\Views\Event\ViewDetails.cshtml"
              Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 23 "D:\gitlab-repo\Assignment 5 - MVC\TSEventApp.Web\Views\Event\ViewDetails.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>No Description</p>\r\n");
#nullable restore
#line 27 "D:\gitlab-repo\Assignment 5 - MVC\TSEventApp.Web\Views\Event\ViewDetails.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h5>Other Details</h5>\r\n");
#nullable restore
#line 29 "D:\gitlab-repo\Assignment 5 - MVC\TSEventApp.Web\Views\Event\ViewDetails.cshtml"
             if (Model.OtherDetails != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>");
#nullable restore
#line 31 "D:\gitlab-repo\Assignment 5 - MVC\TSEventApp.Web\Views\Event\ViewDetails.cshtml"
              Write(Model.OtherDetails);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 32 "D:\gitlab-repo\Assignment 5 - MVC\TSEventApp.Web\Views\Event\ViewDetails.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>No Details</p>\r\n");
#nullable restore
#line 36 "D:\gitlab-repo\Assignment 5 - MVC\TSEventApp.Web\Views\Event\ViewDetails.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"col-sm-6\">\r\n            <ul class=\"list-group\">\r\n                <li class=\"list-group-item\"><i class=\"fa-solid fa-calendar\"></i> <span>Date</span> ");
#nullable restore
#line 40 "D:\gitlab-repo\Assignment 5 - MVC\TSEventApp.Web\Views\Event\ViewDetails.cshtml"
                                                                                              Write(Model.Date.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 41 "D:\gitlab-repo\Assignment 5 - MVC\TSEventApp.Web\Views\Event\ViewDetails.cshtml"
                 if (Model.StartTime != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"list-group-item\"><i class=\"fa-solid fa-clock\"></i> <span>Start Time</span> ");
#nullable restore
#line 43 "D:\gitlab-repo\Assignment 5 - MVC\TSEventApp.Web\Views\Event\ViewDetails.cshtml"
                                                                                                     Write(Model.StartTime.ToShortTimeString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 44 "D:\gitlab-repo\Assignment 5 - MVC\TSEventApp.Web\Views\Event\ViewDetails.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"list-group-item\"><i class=\"fa-solid fa-location-dot\"></i> <span>Location</span> ");
#nullable restore
#line 45 "D:\gitlab-repo\Assignment 5 - MVC\TSEventApp.Web\Views\Event\ViewDetails.cshtml"
                                                                                                      Write(Model.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 46 "D:\gitlab-repo\Assignment 5 - MVC\TSEventApp.Web\Views\Event\ViewDetails.cshtml"
                 if (Model.DurationInHours != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"list-group-item\"><i class=\"fa-solid fa-stopwatch\"></i> <span>Duration</span> ");
#nullable restore
#line 48 "D:\gitlab-repo\Assignment 5 - MVC\TSEventApp.Web\Views\Event\ViewDetails.cshtml"
                                                                                                       Write(Model.DurationInHours);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 49 "D:\gitlab-repo\Assignment 5 - MVC\TSEventApp.Web\Views\Event\ViewDetails.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"list-group-item\"><i class=\"fa-solid fa-lock\"></i>  <span>Type</span> ");
#nullable restore
#line 50 "D:\gitlab-repo\Assignment 5 - MVC\TSEventApp.Web\Views\Event\ViewDetails.cshtml"
                                                                                           Write(Model.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 51 "D:\gitlab-repo\Assignment 5 - MVC\TSEventApp.Web\Views\Event\ViewDetails.cshtml"
                 if (Model.InviteByEmail != null)
                {
                    var count = Model.InviteByEmail.Split(',').Count();

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"list-group-item\"><i class=\"fa-solid fa-user-group\"></i>  <span>Total Invitees</span> ");
#nullable restore
#line 54 "D:\gitlab-repo\Assignment 5 - MVC\TSEventApp.Web\Views\Event\ViewDetails.cshtml"
                                                                                                               Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 55 "D:\gitlab-repo\Assignment 5 - MVC\TSEventApp.Web\Views\Event\ViewDetails.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"list-group-item\"><i class=\"fa-solid fa-user-tie\"></i>  <span>Organiser</span> ");
#nullable restore
#line 56 "D:\gitlab-repo\Assignment 5 - MVC\TSEventApp.Web\Views\Event\ViewDetails.cshtml"
                                                                                                    Write(Model.Organiser);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            </ul>\r\n        </div>\r\n    </div>\r\n    <div class=\"row py-4\">\r\n        <div class=\"col d-flex flex-column\">\r\n            <h1>Comments</h1>\r\n            <hr />\r\n            <div class=\"row\">\r\n                <div class=\"col-sm-6\">\r\n");
#nullable restore
#line 66 "D:\gitlab-repo\Assignment 5 - MVC\TSEventApp.Web\Views\Event\ViewDetails.cshtml"
                     using (Html.BeginForm("PostComment", "Comment", new { EventId = Model.Id }))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""row"">
                            <div class=""col d-flex mb-3 align-items-center"">
                                <img src=""https://image.ibb.co/jw55Ex/def_face.jpg"" class=""img img-rounded img-fluid"" width=""50"" />
                                <p class=""ms-2 pt-2 fw-bold"">");
#nullable restore
#line 71 "D:\gitlab-repo\Assignment 5 - MVC\TSEventApp.Web\Views\Event\ViewDetails.cshtml"
                                                        Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                            </div>

                        </div>
                        <div class=""row"">
                            <div class=""col mb-3"">
                                <textarea class=""form-control"" name=""comment"" id=""comment"" rows=""3""></textarea>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col"">
                                <button class=""btn btn-sm btn-success"" type=""submit"" value=""Post"" id=""submitComment""> Post comment</button>
                            </div>
                        </div>
");
#nullable restore
#line 85 "D:\gitlab-repo\Assignment 5 - MVC\TSEventApp.Web\Views\Event\ViewDetails.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <div class=\"col-sm-6\">\r\n");
#nullable restore
#line 88 "D:\gitlab-repo\Assignment 5 - MVC\TSEventApp.Web\Views\Event\ViewDetails.cshtml"
                     if (Model.Comments.Count != 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"row py-3\">\r\n                            <h3>Previous Comments</h3>\r\n");
#nullable restore
#line 92 "D:\gitlab-repo\Assignment 5 - MVC\TSEventApp.Web\Views\Event\ViewDetails.cshtml"
                             foreach (var i in Model.Comments)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""row pt-2"">
                                    <div class=""col"">
                                        <ul class=""list-group"">
                                            <li class=""list-group-item list-group-item-success""><i class=""fa-solid fa-comment""></i> ");
#nullable restore
#line 97 "D:\gitlab-repo\Assignment 5 - MVC\TSEventApp.Web\Views\Event\ViewDetails.cshtml"
                                                                                                                               Write(i.comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                        </ul>\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 101 "D:\gitlab-repo\Assignment 5 - MVC\TSEventApp.Web\Views\Event\ViewDetails.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n");
#nullable restore
#line 103 "D:\gitlab-repo\Assignment 5 - MVC\TSEventApp.Web\Views\Event\ViewDetails.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n            \r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EventViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591