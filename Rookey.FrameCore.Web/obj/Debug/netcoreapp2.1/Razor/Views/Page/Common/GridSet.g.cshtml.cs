#pragma checksum "D:\.NET CORE\MyCode\OneDll\Rookey.FrameCore\Rookey.FrameCore.Web\Views\Page\Common\GridSet.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a05557f4f939996ebbe1c6dbd004c20a9399a16f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Page_Common_GridSet), @"mvc.1.0.view", @"/Views/Page/Common/GridSet.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Page/Common/GridSet.cshtml", typeof(AspNetCore.Views_Page_Common_GridSet))]
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
#line 4 "D:\.NET CORE\MyCode\OneDll\Rookey.FrameCore\Rookey.FrameCore.Web\Views\Page\Common\GridSet.cshtml"
using Rookey.Frame.Common;

#line default
#line hidden
#line 5 "D:\.NET CORE\MyCode\OneDll\Rookey.FrameCore\Rookey.FrameCore.Web\Views\Page\Common\GridSet.cshtml"
using Rookey.Frame.UIOperate;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a05557f4f939996ebbe1c6dbd004c20a9399a16f", @"/Views/Page/Common/GridSet.cshtml")]
    public class Views_Page_Common_GridSet : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\.NET CORE\MyCode\OneDll\Rookey.FrameCore\Rookey.FrameCore.Web\Views\Page\Common\GridSet.cshtml"
  
    ViewBag.Title = "GridSet";

#line default
#line hidden
#line 6 "D:\.NET CORE\MyCode\OneDll\Rookey.FrameCore\Rookey.FrameCore.Web\Views\Page\Common\GridSet.cshtml"
   UIFrameFactory frameFactory = UIFrameFactory.GetInstance(this.Context.Request);
   Guid moduleId = UIOperate.GetModuleIdByRequest(this.Context.Request);

#line default
#line hidden
            BeginContext(260, 47, false);
#line 8 "D:\.NET CORE\MyCode\OneDll\Rookey.FrameCore\Rookey.FrameCore.Web\Views\Page\Common\GridSet.cshtml"
Write(Html.Raw(frameFactory.GetGridSetHTML(moduleId)));

#line default
#line hidden
            EndContext();
            BeginContext(307, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
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