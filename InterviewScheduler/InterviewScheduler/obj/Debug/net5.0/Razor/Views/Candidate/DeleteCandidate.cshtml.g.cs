#pragma checksum "D:\Legacy\InterviewScheduler\InterviewScheduler\Views\Candidate\DeleteCandidate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8276a63e337764e8cf850b113fdee2f2f2736681"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Candidate_DeleteCandidate), @"mvc.1.0.view", @"/Views/Candidate/DeleteCandidate.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8276a63e337764e8cf850b113fdee2f2f2736681", @"/Views/Candidate/DeleteCandidate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59cc314546c06d508ce968c0322558803e92725a", @"/Views/_ViewImports.cshtml")]
    public class Views_Candidate_DeleteCandidate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CandidateAPI.InterviewSchedulerModel.Candidate>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteJob", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Legacy\InterviewScheduler\InterviewScheduler\Views\Candidate\DeleteCandidate.cshtml"
  
    ViewData["Title"] = "DeleteCandidate";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8276a63e337764e8cf850b113fdee2f2f27366814582", async() => {
                WriteLiteral(@"
    <style>
        .content-box {
            background-color: #fafafb;
            box-shadow: 1px 4px 8px rgba(0,0,0,.15);
            transition: all .3s ease-in-out;
            padding: 10px;
            padding-bottom: 0;
            margin-top: 40px;
            margin-bottom: 10px;
            height: 300px;
        }

            .content-box .finbyz-icon {
                height: 100px;
                width: 100px;
                display: inline;
            }

        .noselect {
            -webkit-touch-callout: none;
            -webkit-user-select: none;
            -moz-user-select: none;
            -ms-user-select: none;
            user-select: none;
            -webkit-tap-highlight-color: transparent;
        }

        button {
            width: 150px;
            height: 50px;
            cursor: pointer;
            display: flex;
            align-items: center;
            background: red;
            border: none;
            border-radius: ");
                WriteLiteral(@"5px;
            box-shadow: 1px 1px 3px rgba(0,0,0,0.15);
            background: #e62222;
        }

            button, button span {
                transition: 200ms;
            }

                button .text {
                    transform: translateX(35px);
                    color: white;
                    font-weight: bold;
                }

                button .icon {
                    position: absolute;
                    border-left: 1px solid #c41b1b;
                    transform: translateX(110px);
                    height: 40px;
                    width: 40px;
                    display: flex;
                    align-items: center;
                    justify-content: center;
                }

                button svg {
                    width: 15px;
                    fill: #eee;
                }

                button:hover {
                    background: #ff3636;
                }

                    button:hover .text {
    ");
                WriteLiteral(@"                    color: transparent;
                    }

                    button:hover .icon {
                        width: 150px;
                        border-left: none;
                        transform: translateX(0);
                    }

                button:focus {
                    outline: none;
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8276a63e337764e8cf850b113fdee2f2f27366818033", async() => {
                WriteLiteral(@"
    <div>
        <center>
            <h2 class=""text-center"" style=""display: inline-block; margin-left: auto; font-family: 'Comic Sans MS'"">Are you sure you want to delete this record?</h2>
            <div class=""col-md-6 text-center"" style=""opacity: 1;"">
                <div class=""content-box"">
                    <center>
                        <h5 class=""text-center"" style=""text-decoration: underline; display: inline-block; margin-left: auto; font-family: 'Comic Sans MS'"">Job</h5>
                        <br />
                        <br />
                        <table>
                            <tr>
                                <th>
                                    <h5>
                                        ");
#nullable restore
#line 107 "D:\Legacy\InterviewScheduler\InterviewScheduler\Views\Candidate\DeleteCandidate.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                    </h5>
                                </th>
                                <td>&nbsp;&nbsp;&nbsp;&nbsp;:&nbsp;&nbsp;&nbsp;&nbsp;</td>
                                <td>
                                    <h5>
                                        ");
#nullable restore
#line 113 "D:\Legacy\InterviewScheduler\InterviewScheduler\Views\Candidate\DeleteCandidate.cshtml"
                                   Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </h5>\r\n                                </td>\r\n                                <th>\r\n                                    <h5>\r\n                                        ");
#nullable restore
#line 118 "D:\Legacy\InterviewScheduler\InterviewScheduler\Views\Candidate\DeleteCandidate.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Dob));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                    </h5>
                                </th>
                                <td>&nbsp;&nbsp;&nbsp;&nbsp;:&nbsp;&nbsp;&nbsp;&nbsp;</td>
                                <td>
                                    <h5>
                                        ");
#nullable restore
#line 124 "D:\Legacy\InterviewScheduler\InterviewScheduler\Views\Candidate\DeleteCandidate.cshtml"
                                   Write(Html.DisplayFor(model => model.Dob));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </h5>\r\n                                </td>\r\n                                <th>\r\n                                    <h5>\r\n                                        ");
#nullable restore
#line 129 "D:\Legacy\InterviewScheduler\InterviewScheduler\Views\Candidate\DeleteCandidate.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                    </h5>
                                </th>
                                <td>&nbsp;&nbsp;&nbsp;&nbsp;:&nbsp;&nbsp;&nbsp;&nbsp;</td>
                                <td>
                                    <h5>
                                        ");
#nullable restore
#line 135 "D:\Legacy\InterviewScheduler\InterviewScheduler\Views\Candidate\DeleteCandidate.cshtml"
                                   Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </h5>\r\n                                </td>\r\n                                <th>\r\n                                    <h5>\r\n                                        ");
#nullable restore
#line 140 "D:\Legacy\InterviewScheduler\InterviewScheduler\Views\Candidate\DeleteCandidate.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Mobileno));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                    </h5>
                                </th>
                                <td>&nbsp;&nbsp;&nbsp;&nbsp;:&nbsp;&nbsp;&nbsp;&nbsp;</td>
                                <td>
                                    <h5>
                                        ");
#nullable restore
#line 146 "D:\Legacy\InterviewScheduler\InterviewScheduler\Views\Candidate\DeleteCandidate.cshtml"
                                   Write(Html.DisplayFor(model => model.Mobileno));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </h5>\r\n                                </td>\r\n                                <th>\r\n                                    <h5>\r\n                                        ");
#nullable restore
#line 151 "D:\Legacy\InterviewScheduler\InterviewScheduler\Views\Candidate\DeleteCandidate.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Qualification));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                    </h5>
                                </th>
                                <td>&nbsp;&nbsp;&nbsp;&nbsp;:&nbsp;&nbsp;&nbsp;&nbsp;</td>
                                <td>
                                    <h5>
                                        ");
#nullable restore
#line 157 "D:\Legacy\InterviewScheduler\InterviewScheduler\Views\Candidate\DeleteCandidate.cshtml"
                                   Write(Html.DisplayFor(model => model.Qualification));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </h5>\r\n                                </td>\r\n                                <th>\r\n                                    <h5>\r\n                                        ");
#nullable restore
#line 162 "D:\Legacy\InterviewScheduler\InterviewScheduler\Views\Candidate\DeleteCandidate.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                    </h5>
                                </th>
                                <td>&nbsp;&nbsp;&nbsp;&nbsp;:&nbsp;&nbsp;&nbsp;&nbsp;</td>
                                <td>
                                    <h5>
                                        ");
#nullable restore
#line 168 "D:\Legacy\InterviewScheduler\InterviewScheduler\Views\Candidate\DeleteCandidate.cshtml"
                                   Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </h5>\r\n                                </td>\r\n                                <th>\r\n                                    <h5>\r\n                                        ");
#nullable restore
#line 173 "D:\Legacy\InterviewScheduler\InterviewScheduler\Views\Candidate\DeleteCandidate.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Resume));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                    </h5>
                                </th>
                                <td>&nbsp;&nbsp;&nbsp;&nbsp;:&nbsp;&nbsp;&nbsp;&nbsp;</td>
                                <td>
                                    <h5>
                                        ");
#nullable restore
#line 179 "D:\Legacy\InterviewScheduler\InterviewScheduler\Views\Candidate\DeleteCandidate.cshtml"
                                   Write(Html.DisplayFor(model => model.Resume));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </h5>\r\n                                </td>\r\n                                <th>\r\n                                    <h5>\r\n                                        ");
#nullable restore
#line 184 "D:\Legacy\InterviewScheduler\InterviewScheduler\Views\Candidate\DeleteCandidate.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Job));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                    </h5>
                                </th>
                                <td>&nbsp;&nbsp;&nbsp;&nbsp;:&nbsp;&nbsp;&nbsp;&nbsp;</td>
                                <td>
                                    <h5>
                                        ");
#nullable restore
#line 190 "D:\Legacy\InterviewScheduler\InterviewScheduler\Views\Candidate\DeleteCandidate.cshtml"
                                   Write(Html.DisplayFor(model => model.Job.JobRole));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </h5>\r\n                                </td>\r\n                                <th>\r\n                                    <h5>\r\n                                        ");
#nullable restore
#line 195 "D:\Legacy\InterviewScheduler\InterviewScheduler\Views\Candidate\DeleteCandidate.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Level));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                    </h5>
                                </th>
                                <td>&nbsp;&nbsp;&nbsp;&nbsp;:&nbsp;&nbsp;&nbsp;&nbsp;</td>
                                <td>
                                    <h5>
                                        ");
#nullable restore
#line 201 "D:\Legacy\InterviewScheduler\InterviewScheduler\Views\Candidate\DeleteCandidate.cshtml"
                                   Write(Html.DisplayFor(model => model.Level.Level));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </h5>\r\n                                </td>\r\n                            </tr>\r\n                            \r\n                        </table>\r\n                        <br />\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8276a63e337764e8cf850b113fdee2f2f273668118910", async() => {
                    WriteLiteral("\r\n                            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8276a63e337764e8cf850b113fdee2f2f273668119205", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 209 "D:\Legacy\InterviewScheduler\InterviewScheduler\Views\Candidate\DeleteCandidate.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral(@"
                            <button class=""noselect""><span class='text'>Delete</span><span class=""icon""><svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24""><path d=""M24 20.188l-8.315-8.209 8.2-8.282-3.697-3.697-8.212 8.318-8.31-8.203-3.666 3.666 8.321 8.24-8.206 8.313 3.666 3.666 8.237-8.318 8.285 8.203z"" /></svg></span></button>
                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </center>\r\n                </div>\r\n            </div>\r\n        </center>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CandidateAPI.InterviewSchedulerModel.Candidate> Html { get; private set; }
    }
}
#pragma warning restore 1591
