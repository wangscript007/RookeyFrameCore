#pragma checksum "D:\wdx\平台\RookeyFrameCoreOneDLL\Rookey.FrameCore.Web\Views\Page\Common\Grid.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c882215375351b5e6823478be4ef8165e09f5a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Page_Common_Grid), @"mvc.1.0.view", @"/Views/Page/Common/Grid.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Page/Common/Grid.cshtml", typeof(AspNetCore.Views_Page_Common_Grid))]
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
#line 4 "D:\wdx\平台\RookeyFrameCoreOneDLL\Rookey.FrameCore.Web\Views\Page\Common\Grid.cshtml"
using Rookey.Frame.UIOperate;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c882215375351b5e6823478be4ef8165e09f5a1", @"/Views/Page/Common/Grid.cshtml")]
    public class Views_Page_Common_Grid : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\wdx\平台\RookeyFrameCoreOneDLL\Rookey.FrameCore.Web\Views\Page\Common\Grid.cshtml"
  
    ViewBag.Title = "Grid";

#line default
#line hidden
            BeginContext(69, 53, false);
#line 5 "D:\wdx\平台\RookeyFrameCoreOneDLL\Rookey.FrameCore.Web\Views\Page\Common\Grid.cshtml"
Write(Html.Raw(UIOperate.GetGridHTML(this.Context.Request)));

#line default
#line hidden
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
