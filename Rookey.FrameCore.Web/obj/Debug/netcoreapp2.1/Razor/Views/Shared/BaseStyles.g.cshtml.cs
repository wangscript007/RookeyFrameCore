#pragma checksum "D:\wdx\平台\RookeyFrameCoreOneDLL\Rookey.FrameCore.Web\Views\Shared\BaseStyles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a040e1897498bf71210005e064b7265a76f7485a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_BaseStyles), @"mvc.1.0.view", @"/Views/Shared/BaseStyles.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/BaseStyles.cshtml", typeof(AspNetCore.Views_Shared_BaseStyles))]
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
#line 1 "D:\wdx\平台\RookeyFrameCoreOneDLL\Rookey.FrameCore.Web\Views\Shared\BaseStyles.cshtml"
using Rookey.Frame.UIOperate;

#line default
#line hidden
#line 2 "D:\wdx\平台\RookeyFrameCoreOneDLL\Rookey.FrameCore.Web\Views\Shared\BaseStyles.cshtml"
using Rookey.Frame.Common;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a040e1897498bf71210005e064b7265a76f7485a", @"/Views/Shared/BaseStyles.cshtml")]
    public class Views_Shared_BaseStyles : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\wdx\平台\RookeyFrameCoreOneDLL\Rookey.FrameCore.Web\Views\Shared\BaseStyles.cshtml"
  
    bool isShowFullPath = UIOperate.IsJsShowFullPath(this.Context.Request);
    string domainPath = isShowFullPath ? Globals.GetBaseUrl() : "~/";

#line default
#line hidden
            BeginContext(216, 58, true);
            WriteLiteral("<link class=\"easyuiTheme\" type=\"text/css\" rel=\"Stylesheet\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 274, "\"", 374, 1);
#line 7 "D:\wdx\平台\RookeyFrameCoreOneDLL\Rookey.FrameCore.Web\Views\Shared\BaseStyles.cshtml"
WriteAttributeValue("", 281, Url.Content(string.Format("{0}Scripts/jquery-easyui/themes/default/easyui.css", domainPath)), 281, 93, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(375, 43, true);
            WriteLiteral(" />\r\n<link type=\"text/css\" rel=\"Stylesheet\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 418, "\"", 508, 1);
#line 8 "D:\wdx\平台\RookeyFrameCoreOneDLL\Rookey.FrameCore.Web\Views\Shared\BaseStyles.cshtml"
WriteAttributeValue("", 425, Url.Content(string.Format("{0}Scripts/jquery-easyui/themes/icon.css", domainPath)), 425, 83, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(509, 43, true);
            WriteLiteral(" />\r\n<link type=\"text/css\" rel=\"Stylesheet\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 552, "\"", 643, 1);
#line 9 "D:\wdx\平台\RookeyFrameCoreOneDLL\Rookey.FrameCore.Web\Views\Shared\BaseStyles.cshtml"
WriteAttributeValue("", 559, Url.Content(string.Format("{0}Scripts/jquery-easyui/themes/color.css", domainPath)), 559, 84, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(644, 43, true);
            WriteLiteral(" />\r\n<link type=\"text/css\" rel=\"Stylesheet\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 687, "\"", 783, 1);
#line 10 "D:\wdx\平台\RookeyFrameCoreOneDLL\Rookey.FrameCore.Web\Views\Shared\BaseStyles.cshtml"
WriteAttributeValue("", 694, Url.Content(string.Format("{0}Scripts/jquery-plug/jquery.autocomplete.css", domainPath)), 694, 89, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(784, 43, true);
            WriteLiteral(" />\r\n<link type=\"text/css\" rel=\"Stylesheet\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 827, "\"", 902, 1);
#line 11 "D:\wdx\平台\RookeyFrameCoreOneDLL\Rookey.FrameCore.Web\Views\Shared\BaseStyles.cshtml"
WriteAttributeValue("", 834, Url.Content(string.Format("{0}Css/global.css?r=12345", domainPath)), 834, 68, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(903, 43, true);
            WriteLiteral(" />\r\n<link type=\"text/css\" rel=\"Stylesheet\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 946, "\"", 1011, 1);
#line 12 "D:\wdx\平台\RookeyFrameCoreOneDLL\Rookey.FrameCore.Web\Views\Shared\BaseStyles.cshtml"
WriteAttributeValue("", 953, Url.Content(string.Format("{0}Css/icon.css", domainPath)), 953, 58, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1012, 1282, true);
            WriteLiteral(@" />
<style type=""text/css"">
    /*-------datagrid网格换行显示--------*/
    /*.datagrid-header-row td span:first-child {
        word-break:normal;width:auto;display:block;white-space:pre-wrap;word-wrap:break-word;overflow:hidden;
    }*/
    /*-------datagrid网格超出宽度时显示省略号-----------*/
    .datagrid-cell, .datagrid-cell-group, .datagrid-header-rownumber, .datagrid-cell-rownumber {
        text-overflow: ellipsis;
    }
    /*::-webkit-scrollbar-track{border-radius: 10px;-webkit-box-shadow: inset 0 0 6px rgba(0,0,0,0);}
    ::-webkit-scrollbar-thumb{background-color: rgba(0,0,0,0.05);border-radius: 10px;-webkit-box-shadow: inset 1px 1px 0 rgba(0,0,0,.1);}
    ::-webkit-scrollbar-thumb{background-color: rgba(0,0,0,0.2);border-radius: 10px;-webkit-box-shadow: inset 1px 1px 0 rgba(0,0,0,.1);}
    ::-webkit-scrollbar{width: 16px;height: 16px;}
    ::-webkit-scrollbar-track,
    ::-webkit-scrollbar-thumb{border-radius: 999px;border: 5px solid transparent;}
    ::-webkit-scrollbar-track{box-shadow: 1px 1px ");
            WriteLiteral(@"5px rgba(0,0,0,.2) inset;}
    ::-webkit-scrollbar-thumb{min-height: 20px;background-clip: content-box;box-shadow: 0 0 0 5px rgba(0,0,0,.2) inset;}
    ::-webkit-scrollbar-corner{background: transparent;}*/
</style>
<link type=""text/css"" rel=""Stylesheet""");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2294, "\"", 2367, 1);
#line 32 "D:\wdx\平台\RookeyFrameCoreOneDLL\Rookey.FrameCore.Web\Views\Shared\BaseStyles.cshtml"
WriteAttributeValue("", 2301, Url.Content(string.Format("{0}Css/common/print.css", domainPath)), 2301, 66, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2368, 103, true);
            WriteLiteral(" media=\"print\" />\r\n<link type=\"text/css\" rel=\"stylesheet\" href=\"/Assets/css/rebuildV3.css?r=1211113\" />");
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
