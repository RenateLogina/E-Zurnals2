#pragma checksum "C:\Users\User\Desktop\Accenture-projekti\E-Zurnals2\EZurnals\Views\Grade\ViewSubjectGrades.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3fc4d451f3d0c97ab14adf08bb4ab6db72e7d398"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Grade_ViewSubjectGrades), @"mvc.1.0.view", @"/Views/Grade/ViewSubjectGrades.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Grade/ViewSubjectGrades.cshtml", typeof(AspNetCore.Views_Grade_ViewSubjectGrades))]
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
#line 1 "C:\Users\User\Desktop\Accenture-projekti\E-Zurnals2\EZurnals\Views\_ViewImports.cshtml"
using EZurnals;

#line default
#line hidden
#line 2 "C:\Users\User\Desktop\Accenture-projekti\E-Zurnals2\EZurnals\Views\_ViewImports.cshtml"
using EZurnals.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3fc4d451f3d0c97ab14adf08bb4ab6db72e7d398", @"/Views/Grade/ViewSubjectGrades.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ee669dd2761f1585a574b232baaeed8638f367b", @"/Views/_ViewImports.cshtml")]
    public class Views_Grade_ViewSubjectGrades : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GradeModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\User\Desktop\Accenture-projekti\E-Zurnals2\EZurnals\Views\Grade\ViewSubjectGrades.cshtml"
  
    ViewData["Title"] = "Vērtējumi";

#line default
#line hidden
            BeginContext(70, 24, true);
            WriteLiteral("\r\n<h2>Vērtējumi</h2>\r\n\r\n");
            EndContext();
#line 8 "C:\Users\User\Desktop\Accenture-projekti\E-Zurnals2\EZurnals\Views\Grade\ViewSubjectGrades.cshtml"
 if (Model.Count > 0)
{

#line default
#line hidden
            BeginContext(120, 207, true);
            WriteLiteral("    <table class=\"table table-striped\">\r\n        <tr>\r\n            <th>Skolēna uzvārds</th>\r\n            <th>Skolēna vārds</th>\r\n            <th>Apraksts</th>\r\n            <th>Vērtējums</th>\r\n        </tr>\r\n");
            EndContext();
#line 17 "C:\Users\User\Desktop\Accenture-projekti\E-Zurnals2\EZurnals\Views\Grade\ViewSubjectGrades.cshtml"
         foreach (var grade in Model)
        {

#line default
#line hidden
            BeginContext(377, 22, true);
            WriteLiteral("    <tr>\r\n        <td>");
            EndContext();
            BeginContext(400, 20, false);
#line 20 "C:\Users\User\Desktop\Accenture-projekti\E-Zurnals2\EZurnals\Views\Grade\ViewSubjectGrades.cshtml"
       Write(grade.StudentSurname);

#line default
#line hidden
            EndContext();
            BeginContext(420, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(440, 17, false);
#line 21 "C:\Users\User\Desktop\Accenture-projekti\E-Zurnals2\EZurnals\Views\Grade\ViewSubjectGrades.cshtml"
       Write(grade.StudentName);

#line default
#line hidden
            EndContext();
            BeginContext(457, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(477, 13, false);
#line 22 "C:\Users\User\Desktop\Accenture-projekti\E-Zurnals2\EZurnals\Views\Grade\ViewSubjectGrades.cshtml"
       Write(grade.Comment);

#line default
#line hidden
            EndContext();
            BeginContext(490, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(510, 11, false);
#line 23 "C:\Users\User\Desktop\Accenture-projekti\E-Zurnals2\EZurnals\Views\Grade\ViewSubjectGrades.cshtml"
       Write(grade.Grade);

#line default
#line hidden
            EndContext();
            BeginContext(521, 18, true);
            WriteLiteral("</td>\r\n    </tr>\r\n");
            EndContext();
#line 25 "C:\Users\User\Desktop\Accenture-projekti\E-Zurnals2\EZurnals\Views\Grade\ViewSubjectGrades.cshtml"
        }

#line default
#line hidden
            BeginContext(550, 14, true);
            WriteLiteral("    </table>\r\n");
            EndContext();
#line 27 "C:\Users\User\Desktop\Accenture-projekti\E-Zurnals2\EZurnals\Views\Grade\ViewSubjectGrades.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(576, 44, true);
            WriteLiteral("    <div>Šajā priekšmetā atzīmju nav</div>\r\n");
            EndContext();
#line 31 "C:\Users\User\Desktop\Accenture-projekti\E-Zurnals2\EZurnals\Views\Grade\ViewSubjectGrades.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<GradeModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
