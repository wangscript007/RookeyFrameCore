#pragma checksum "D:\wdx\平台\RookeyFrameCoreOneDLL\Rookey.FrameCore.Web\Views\Bpm\SelectBackNode.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1e9739bc682c2e28b094737fb1a4e972018a29d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bpm_SelectBackNode), @"mvc.1.0.view", @"/Views/Bpm/SelectBackNode.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Bpm/SelectBackNode.cshtml", typeof(AspNetCore.Views_Bpm_SelectBackNode))]
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
#line 10 "D:\wdx\平台\RookeyFrameCoreOneDLL\Rookey.FrameCore.Web\Views\Bpm\SelectBackNode.cshtml"
using Rookey.Frame.Common;

#line default
#line hidden
#line 11 "D:\wdx\平台\RookeyFrameCoreOneDLL\Rookey.FrameCore.Web\Views\Bpm\SelectBackNode.cshtml"
using Rookey.Frame.UIOperate;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1e9739bc682c2e28b094737fb1a4e972018a29d", @"/Views/Bpm/SelectBackNode.cshtml")]
    public class Views_Bpm_SelectBackNode : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\wdx\平台\RookeyFrameCoreOneDLL\Rookey.FrameCore.Web\Views\Bpm\SelectBackNode.cshtml"
  
    ViewBag.Title = "SelectBackNode";
    string r = WebHelper.GetJsModifyTimeStr("/Scripts/Bpm/SelectBackNode.js");

#line default
#line hidden
            DefineSection("scripts", async() => {
                BeginContext(174, 36, true);
                WriteLiteral("\r\n    <script type=\"text/javascript\"");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 210, "\"", 286, 1);
#line 8 "D:\wdx\平台\RookeyFrameCoreOneDLL\Rookey.FrameCore.Web\Views\Bpm\SelectBackNode.cshtml"
WriteAttributeValue("", 216, Url.Content(string.Format("~/Scripts/Bpm/SelectBackNode.js?r={0}",r)), 216, 70, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(287, 12, true);
                WriteLiteral("></script>\r\n");
                EndContext();
            }
            );
#line 12 "D:\wdx\平台\RookeyFrameCoreOneDLL\Rookey.FrameCore.Web\Views\Bpm\SelectBackNode.cshtml"
   UIFrameFactory frameFactory = UIFrameFactory.GetInstance(this.Context.Request);
   Guid todoId = this.Context.Request.Query["todoId"].ObjToGuid();

#line default
#line hidden
            BeginContext(517, 52, false);
#line 14 "D:\wdx\平台\RookeyFrameCoreOneDLL\Rookey.FrameCore.Web\Views\Bpm\SelectBackNode.cshtml"
Write(Html.Raw(frameFactory.GetSelectBackNodeHTML(todoId)));

#line default
#line hidden
            EndContext();
            BeginContext(569, 2, true);
            WriteLiteral("\r\n");
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
