#pragma checksum "D:\Legacy\InterviewScheduler\InterviewScheduler\Views\HrDashboard\Index1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c97bc5919103dddc86eb29d3d00b1e1ca1920a46"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HrDashboard_Index1), @"mvc.1.0.view", @"/Views/HrDashboard/Index1.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c97bc5919103dddc86eb29d3d00b1e1ca1920a46", @"/Views/HrDashboard/Index1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59cc314546c06d508ce968c0322558803e92725a", @"/Views/_ViewImports.cshtml")]
    public class Views_HrDashboard_Index1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Dashboard.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c97bc5919103dddc86eb29d3d00b1e1ca1920a464111", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c97bc5919103dddc86eb29d3d00b1e1ca1920a464371", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n\n");
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
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c97bc5919103dddc86eb29d3d00b1e1ca1920a466251", async() => {
                WriteLiteral(@"
    <div class=""justify-content-xl-center"" align=""center"">
        <br />
        <section class=""tiles"">
            <div class=""container"">
                <h1 style=""font-family: 'Comic Sans MS'"">HR Dashboard</h1>
                <br /><br />
                      <div class=""row"">
                          <div class=""col-md-3"">

                              <div class=""link-tiles"" style=""border-radius: 10px;"">
                                  <div class=""row"" style=""padding: 50px;"">
                                      <div class=""col-sm-1"">
                                          <i class=""bi bi-briefcase-fill""></i>

                                          <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-briefcase-fill"" viewBox=""0 0 16 16"">
                                              <path d=""M6.5 1A1.5 1.5 0 0 0 5 2.5V3H1.5A1.5 1.5 0 0 0 0 4.5v1.384l7.614 2.03a1.5 1.5 0 0 0 .772 0L16 5.884V4.5A1.5 1.5 0 0 0 14.5 3H11v-.5A1.5 1.5 0 0 0 9.5 1h-3zm0");
                WriteLiteral(@" 1h3a.5.5 0 0 1 .5.5V3H6v-.5a.5.5 0 0 1 .5-.5z"" />
                                              <path d=""M0 12.5A1.5 1.5 0 0 0 1.5 14h13a1.5 1.5 0 0 0 1.5-1.5V6.85L8.129 8.947a.5.5 0 0 1-.258 0L0 6.85v5.65z"" />
                                          </svg>
                                      </div>
                                      <div class=""col-sm-1"">

                                          ");
#nullable restore
#line 29 "D:\Legacy\InterviewScheduler\InterviewScheduler\Views\HrDashboard\Index1.cshtml"
                                     Write(Html.ActionLink("Jobs", "ViewJob", "Job"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

                                      </div>
                                  </div>
                              </div>
                          </div>

                          <div class=""col-md-3"">


                              <div class=""link-tiles"" style=""border-radius: 10px;"">
                                  <div class=""row"" style=""padding: 50px;"">
                                      <div class=""col-sm-1"">
                                          <i class=""bi bi-bar-chart-steps""></i>
                                          <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-bar-chart-steps"" viewBox=""0 0 16 16"">
                                              <path d=""M.5 0a.5.5 0 0 1 .5.5v15a.5.5 0 0 1-1 0V.5A.5.5 0 0 1 .5 0zM2 1.5a.5.5 0 0 1 .5-.5h4a.5.5 0 0 1 .5.5v1a.5.5 0 0 1-.5.5h-4a.5.5 0 0 1-.5-.5v-1zm2 4a.5.5 0 0 1 .5-.5h7a.5.5 0 0 1 .5.5v1a.5.5 0 0 1-.5.5h-7a.5.5 0 0 1-.5-.5v-1zm2 4a.5.5 0 0 1 .5-.5h6a.5.5 0 0 1 .5.5v1a.5.5 0 0 1-.5.5h-6");
                WriteLiteral(@"a.5.5 0 0 1-.5-.5v-1zm2 4a.5.5 0 0 1 .5-.5h7a.5.5 0 0 1 .5.5v1a.5.5 0 0 1-.5.5h-7a.5.5 0 0 1-.5-.5v-1z"" />
                                          </svg>
                                      </div>
                                      <div class=""col-sm-1"">
                                          ");
#nullable restore
#line 48 "D:\Legacy\InterviewScheduler\InterviewScheduler\Views\HrDashboard\Index1.cshtml"
                                     Write(Html.ActionLink("Interview Level", "ViewLevel", "Level"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                      </div>
                                  </div>
                              </div>
                          </div>
                          <div class=""col-md-3"">
                              <div class=""link-tiles"" style=""border-radius: 10px;"">
                                  <div class=""row"" style=""padding: 50px;"">
                                      <div class=""col-sm-1"">
                                          <i class=""bi bi-file-person""></i>


                                          <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-file-person"" viewBox=""0 0 16 16"">
                                              <path d=""M12 1a1 1 0 0 1 1 1v10.755S12 11 8 11s-5 1.755-5 1.755V2a1 1 0 0 1 1-1h8zM4 0a2 2 0 0 0-2 2v12a2 2 0 0 0 2 2h8a2 2 0 0 0 2-2V2a2 2 0 0 0-2-2H4z"" />
                                              <path d=""M8 10a3 3 0 1 0 0-6 3 3 0 0 0 0 6z"" />
                                          </svg>
  ");
                WriteLiteral("                                    </div>\n                                      <div class=\"col-sm-1\">\n\n                                          ");
#nullable restore
#line 67 "D:\Legacy\InterviewScheduler\InterviewScheduler\Views\HrDashboard\Index1.cshtml"
                                     Write(Html.ActionLink("Panel", "ViewPanel", "Panel"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                      </div>
                                  </div>
                              </div>
                          </div>
                          <div class=""col-md-3"">
                              <div class=""link-tiles"" style=""border-radius: 10px;"">
                                  <div class=""row"" style=""padding: 50px;"">
                                      <div class=""col-sm-1"">
                                          <i class=""bi bi-person-circle""></i>

                                          <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-person-circle"" viewBox=""0 0 16 16"">
                                              <path d=""M11 6a3 3 0 1 1-6 0 3 3 0 0 1 6 0z"" />
                                              <path fill-rule=""evenodd"" d=""M0 8a8 8 0 1 1 16 0A8 8 0 0 1 0 8zm8-7a7 7 0 0 0-5.468 11.37C3.242 11.226 4.805 10 8 10s4.757 1.225 5.468 2.37A7 7 0 0 0 8 1z"" />
                                          </sv");
                WriteLiteral("g>\n                                      </div>\n                                      <div class=\"col-sm-1\">\n\n                                          ");
#nullable restore
#line 85 "D:\Legacy\InterviewScheduler\InterviewScheduler\Views\HrDashboard\Index1.cshtml"
                                     Write(Html.ActionLink("Candidate", "ViewCandidate", "Candidate"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                      </div>
                                  </div>
                              </div>
                          </div>
                          <div class=""col-md-3"">
                              <div class=""link-tiles"" style=""border-radius: 10px;"">
                                  <div class=""row"" style=""padding: 50px;"">
                                      <div class=""col-sm-1"">
                                          <i class=""bi bi-calendar-check""></i>

                                          <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-calendar-check"" viewBox=""0 0 16 16"">
                                              <path d=""M10.854 7.146a.5.5 0 0 1 0 .708l-3 3a.5.5 0 0 1-.708 0l-1.5-1.5a.5.5 0 1 1 .708-.708L7.5 9.793l2.646-2.647a.5.5 0 0 1 .708 0z"" />
                                              <path d=""M3.5 0a.5.5 0 0 1 .5.5V1h8V.5a.5.5 0 0 1 1 0V1h1a2 2 0 0 1 2 2v11a2 2 0 0 1-2 2H2a2 2 0 0 1-2-2V3a2 2 0");
                WriteLiteral(@" 0 1 2-2h1V.5a.5.5 0 0 1 .5-.5zM1 4v10a1 1 0 0 0 1 1h12a1 1 0 0 0 1-1V4H1z"" />
                                          </svg>
                                      </div>
                                      <div class=""col-sm-1"">

                                          ");
#nullable restore
#line 103 "D:\Legacy\InterviewScheduler\InterviewScheduler\Views\HrDashboard\Index1.cshtml"
                                     Write(Html.ActionLink("Candidate Availability", "ViewCandidateAvailability", "CandidateAvailability"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                      </div>
                                  </div>
                              </div>
                          </div>
                          <div class=""col-md-3"">
                              <div class=""link-tiles"" style=""border-radius: 10px;"">
                                  <div class=""row"" style=""padding: 50px;"">
                                      <div class=""col-sm-1"">
                                          <i class=""bi bi-calendar-check""></i>

                                          <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-calendar-check"" viewBox=""0 0 16 16"">
                                              <path d=""M10.854 7.146a.5.5 0 0 1 0 .708l-3 3a.5.5 0 0 1-.708 0l-1.5-1.5a.5.5 0 1 1 .708-.708L7.5 9.793l2.646-2.647a.5.5 0 0 1 .708 0z"" />
                                              <path d=""M3.5 0a.5.5 0 0 1 .5.5V1h8V.5a.5.5 0 0 1 1 0V1h1a2 2 0 0 1 2 2v11a2 2 0 0 1-2 2H2a2 2 0 0 1-2-2V3a2 2 0");
                WriteLiteral(@" 0 1 2-2h1V.5a.5.5 0 0 1 .5-.5zM1 4v10a1 1 0 0 0 1 1h12a1 1 0 0 0 1-1V4H1z"" />
                                          </svg>
                                      </div>
                                      <div class=""col-sm-1"">

                                          ");
#nullable restore
#line 121 "D:\Legacy\InterviewScheduler\InterviewScheduler\Views\HrDashboard\Index1.cshtml"
                                     Write(Html.ActionLink("Panel Availability", "ViewPanelAvailability", "PanelAvailability"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                      </div>
                                  </div>
                              </div>
                          </div>
                          <div class=""col-md-3"">
                              <div class=""link-tiles"" style=""border-radius: 10px;"">
                                  <div class=""row"" style=""padding: 50px;"">
                                      <div class=""col-sm-1"">
                                          <i class=""bi bi-calendar3""></i>

                                          <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-calendar3"" viewBox=""0 0 16 16"">
                                              <path d=""M14 0H2a2 2 0 0 0-2 2v12a2 2 0 0 0 2 2h12a2 2 0 0 0 2-2V2a2 2 0 0 0-2-2zM1 3.857C1 3.384 1.448 3 2 3h12c.552 0 1 .384 1 .857v10.286c0 .473-.448.857-1 .857H2c-.552 0-1-.384-1-.857V3.857z"" />
                                              <path d=""M6.5 7a1 1 0 1 0 0-2 1 1 0 0 0 0 2zm3 0a1 1 0 1 0 0-2");
                WriteLiteral(@" 1 1 0 0 0 0 2zm3 0a1 1 0 1 0 0-2 1 1 0 0 0 0 2zm-9 3a1 1 0 1 0 0-2 1 1 0 0 0 0 2zm3 0a1 1 0 1 0 0-2 1 1 0 0 0 0 2zm3 0a1 1 0 1 0 0-2 1 1 0 0 0 0 2zm3 0a1 1 0 1 0 0-2 1 1 0 0 0 0 2zm-9 3a1 1 0 1 0 0-2 1 1 0 0 0 0 2zm3 0a1 1 0 1 0 0-2 1 1 0 0 0 0 2zm3 0a1 1 0 1 0 0-2 1 1 0 0 0 0 2z"" />
                                          </svg>
                                      </div>
                                      <div class=""col-sm-1"">

                                          ");
#nullable restore
#line 139 "D:\Legacy\InterviewScheduler\InterviewScheduler\Views\HrDashboard\Index1.cshtml"
                                     Write(Html.ActionLink("Interview Schedule", "ViewSchedule", "Schedule"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                      </div>
                                  </div>
                              </div>
                          </div>
                          <div class=""col-md-3"">
                              <div class=""link-tiles"" style=""border-radius: 10px;"">
                                  <div class=""row"" style=""padding: 50px;"">
                                      <div class=""col-sm-1"">
                                          <i class=""bi bi-stickies""></i>

                                          <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-stickies"" viewBox=""0 0 16 16"">
                                              <path d=""M1.5 0A1.5 1.5 0 0 0 0 1.5V13a1 1 0 0 0 1 1V1.5a.5.5 0 0 1 .5-.5H14a1 1 0 0 0-1-1H1.5z"" />
                                              <path d=""M3.5 2A1.5 1.5 0 0 0 2 3.5v11A1.5 1.5 0 0 0 3.5 16h6.086a1.5 1.5 0 0 0 1.06-.44l4.915-4.914A1.5 1.5 0 0 0 16 9.586V3.5A1.5 1.5 0 0 0 14.5 2h-11zM3 3.5a.5.");
                WriteLiteral(@"5 0 0 1 .5-.5h11a.5.5 0 0 1 .5.5V9h-4.5A1.5 1.5 0 0 0 9 10.5V15H3.5a.5.5 0 0 1-.5-.5v-11zm7 11.293V10.5a.5.5 0 0 1 .5-.5h4.293L10 14.793z"" />
                                          </svg>
                                      </div>
                                      <div class=""col-sm-1"">

                                          ");
#nullable restore
#line 157 "D:\Legacy\InterviewScheduler\InterviewScheduler\Views\HrDashboard\Index1.cshtml"
                                     Write(Html.ActionLink("Interview Status", "ViewInterviewStatus", "InterviewStatus"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                                      </div>\n                                  </div>\n                              </div>\n                          </div>\n                      </div>\n            </div>\n        </section>\n        \n    </div>\n");
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
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
