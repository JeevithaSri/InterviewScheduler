#pragma checksum "D:\Legacy\InterviewScheduler\InterviewScheduler\Views\Candidate\ViewCandidate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16ad5bbe21dca760e311f7708ae20812c228fcde"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Candidate_ViewCandidate), @"mvc.1.0.view", @"/Views/Candidate/ViewCandidate.cshtml")]
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
#line 1 "D:\Legacy\InterviewScheduler\InterviewScheduler\Views\_ViewImports.cshtml"
using InterviewScheduler;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Legacy\InterviewScheduler\InterviewScheduler\Views\_ViewImports.cshtml"
using InterviewScheduler.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16ad5bbe21dca760e311f7708ae20812c228fcde", @"/Views/Candidate/ViewCandidate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59cc314546c06d508ce968c0322558803e92725a", @"/Views/_ViewImports.cshtml")]
    public class Views_Candidate_ViewCandidate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CandidateAPI.InterviewSchedulerModel.Candidate>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateCandidate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteCandidate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddCandidate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Legacy\InterviewScheduler\InterviewScheduler\Views\Candidate\ViewCandidate.cshtml"
  
    ViewData["Title"] = "ViewCandidate";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16ad5bbe21dca760e311f7708ae20812c228fcde4841", async() => {
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css\">\r\n    <style>\r\n        ");
                WriteLiteral(@"@import url(""https://fonts.googleapis.com/css2?family=Poppins&display=swap"");

        .subscription {
            font-family: Arial, Helvetica, sans-serif;
            border-collapse: collapse;
            width: 80%;
            margin-left: 50px;
            margin-right: 50px;
            counter-reset: serial-number; /* Set the serial number counter to 0 */
        }

            .subscription td:first-child:before {
                counter-increment: serial-number; /* Increment the serial number counter */
                content: counter(serial-number); /* Display the counter */
            }
            .subscription td, .subscription th {
                border: 1px solid #ddd;
                padding: 8px;
            }

            .subscription tr:nth-child(even) {
                background-color: #f2f2f2;
            }

            .subscription tr:hover {
                background-color: #ddd;
            }

            .subscription th {
                padding-");
                WriteLiteral(@"top: 12px;
                padding-bottom: 12px;
                text-align: left;
                background-color: #01054d;
                color: white;
            }

        .wrapper {
            display: inline-flex;
        }

            .wrapper .icon {
                position: relative;
                background-color: #ffffff;
                border-radius: 50%;
                border: 1px solid #adc4bf;
                padding: 15px;
                margin: 10px;
                width: 50px;
                height: 50px;
                font-size: 18px;
                display: flex;
                justify-content: center;
                align-items: center;
                flex-direction: column;
                box-shadow: 0 10px 10px rgba(0, 0, 0, 0.1);
                cursor: pointer;
                transition: all 0.2s cubic-bezier(0.68, -0.55, 0.265, 1.55);
            }

            .wrapper .tooltip {
                position: absolute;
               ");
                WriteLiteral(@" top: 0;
                font-size: 14px;
                background-color: #ffffff;
                color: #ffffff;
                padding: 5px 8px;
                border-radius: 5px;
                box-shadow: 0 10px 10px rgba(0, 0, 0, 0.1);
                opacity: 0;
                pointer-events: none;
                transition: all 0.3s cubic-bezier(0.68, -0.55, 0.265, 1.55);
            }

                .wrapper .tooltip::before {
                    position: absolute;
                    content: """";
                    height: 8px;
                    width: 8px;
                    background-color: #ffffff;
                    bottom: -3px;
                    left: 50%;
                    transform: translate(-50%) rotate(45deg);
                    transition: all 0.3s cubic-bezier(0.68, -0.55, 0.265, 1.55);
                }

            .wrapper .icon:hover .tooltip {
                top: -45px;
                opacity: 1;
                visibility: visible;");
                WriteLiteral(@"
                pointer-events: auto;
            }

            .wrapper .icon:hover span,
            .wrapper .icon:hover .tooltip {
                text-shadow: 0px -1px 0px rgba(0, 0, 0, 0.1);
            }

            .wrapper .edit:hover,
            .wrapper .edit:hover .tooltip,
            .wrapper .edit:hover .tooltip::before {
                background-color: #3b5999;
                color: #ffffff;
            }

            .wrapper .delete:hover,
            .wrapper .delete:hover .tooltip,
            .wrapper .delete:hover .tooltip::before {
                background-color: #de463b;
                color: #ffffff;
            }
    </style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<div class=""justify-content-xl-center"" align=""center"">

    <h1>View Candidate</h1>

    <br />
    <table class=""subscription"">
        <thead>
            <tr>
                <th>
                    <label>Sl.No</label>
                </th>
                <th>
                    ");
#nullable restore
#line 134 "D:\Legacy\InterviewScheduler\InterviewScheduler\Views\Candidate\ViewCandidate.cshtml"
               Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 137 "D:\Legacy\InterviewScheduler\InterviewScheduler\Views\Candidate\ViewCandidate.cshtml"
               Write(Html.DisplayNameFor(model => model.Dob));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 140 "D:\Legacy\InterviewScheduler\InterviewScheduler\Views\Candidate\ViewCandidate.cshtml"
               Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 143 "D:\Legacy\InterviewScheduler\InterviewScheduler\Views\Candidate\ViewCandidate.cshtml"
               Write(Html.DisplayNameFor(model => model.Mobileno));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 146 "D:\Legacy\InterviewScheduler\InterviewScheduler\Views\Candidate\ViewCandidate.cshtml"
               Write(Html.DisplayNameFor(model => model.Qualification));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 149 "D:\Legacy\InterviewScheduler\InterviewScheduler\Views\Candidate\ViewCandidate.cshtml"
               Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n\r\n                <th>\r\n                    ");
#nullable restore
#line 153 "D:\Legacy\InterviewScheduler\InterviewScheduler\Views\Candidate\ViewCandidate.cshtml"
               Write(Html.DisplayNameFor(model => model.Resume));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 156 "D:\Legacy\InterviewScheduler\InterviewScheduler\Views\Candidate\ViewCandidate.cshtml"
               Write(Html.DisplayNameFor(model => model.Job));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 159 "D:\Legacy\InterviewScheduler\InterviewScheduler\Views\Candidate\ViewCandidate.cshtml"
               Write(Html.DisplayNameFor(model => model.Level));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>Action</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 165 "D:\Legacy\InterviewScheduler\InterviewScheduler\Views\Candidate\ViewCandidate.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 172 "D:\Legacy\InterviewScheduler\InterviewScheduler\Views\Candidate\ViewCandidate.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 175 "D:\Legacy\InterviewScheduler\InterviewScheduler\Views\Candidate\ViewCandidate.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Dob));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 178 "D:\Legacy\InterviewScheduler\InterviewScheduler\Views\Candidate\ViewCandidate.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 181 "D:\Legacy\InterviewScheduler\InterviewScheduler\Views\Candidate\ViewCandidate.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Mobileno));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 184 "D:\Legacy\InterviewScheduler\InterviewScheduler\Views\Candidate\ViewCandidate.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Qualification));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 187 "D:\Legacy\InterviewScheduler\InterviewScheduler\Views\Candidate\ViewCandidate.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n\r\n                    <td>\r\n                        ");
#nullable restore
#line 191 "D:\Legacy\InterviewScheduler\InterviewScheduler\Views\Candidate\ViewCandidate.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Resume));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 194 "D:\Legacy\InterviewScheduler\InterviewScheduler\Views\Candidate\ViewCandidate.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Job.JobRole));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 197 "D:\Legacy\InterviewScheduler\InterviewScheduler\Views\Candidate\ViewCandidate.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Level.Level));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <div class=\"wrapper\">\r\n                            <div class=\"icon edit\">\r\n                                <div class=\"tooltip\">Update</div>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16ad5bbe21dca760e311f7708ae20812c228fcde17043", async() => {
                WriteLiteral("<span><i class=\"fa fa-edit\" style=\"color: black;\"></i></span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 203 "D:\Legacy\InterviewScheduler\InterviewScheduler\Views\Candidate\ViewCandidate.cshtml"
                                                                  WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""wrapper"">
                            <div class=""icon delete"">
                                <div class=""tooltip"">Delete</div>
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16ad5bbe21dca760e311f7708ae20812c228fcde19559", async() => {
                WriteLiteral("<span><i class=\"fa fa-trash\" style=\"color: black;\"></i></span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 209 "D:\Legacy\InterviewScheduler\InterviewScheduler\Views\Candidate\ViewCandidate.cshtml"
                                                                  WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 215 "D:\Legacy\InterviewScheduler\InterviewScheduler\Views\Candidate\ViewCandidate.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n    <br /><br />\r\n\r\n\r\n    <div class=\"justify-content-xl-center\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16ad5bbe21dca760e311f7708ae20812c228fcde22270", async() => {
                WriteLiteral("Add Candidate");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n\r\n\r\n\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CandidateAPI.InterviewSchedulerModel.Candidate>> Html { get; private set; }
    }
}
#pragma warning restore 1591
