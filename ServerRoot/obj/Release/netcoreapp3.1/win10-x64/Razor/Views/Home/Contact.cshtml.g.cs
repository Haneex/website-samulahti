#pragma checksum "C:\Users\Samu Lahti\OneDrive\GitHub\website-samulahti-updated\ServerRoot\Views\Home\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81e6f3a1ad3dc444e14045193e25c18930debf95"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81e6f3a1ad3dc444e14045193e25c18930debf95", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c66e443ba81bfd444e2b1c1ae94c4deedf2b8d44", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<!-- Navigation Menu Bar for the website -->
<nav class=""Top-Navigation-Bar slide-in-down"" data-scrolldown-class=""reduced"">

    <!-- Contents -->
    <div>
        <!-- Signature -->
        <a href=""/"">
            <img src=""/Assets/Images/Signature_White.png""/>
        </a>

        <!-- Hamburger menu -->
        <div class=""hamburger hamburger--collapse""");
            BeginWriteAttribute("hamburger-menu-active", " hamburger-menu-active=\"", 374, "\"", 398, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            <a href=""#topmenu"">
            <div class=""hamburger-box"">
                <div class=""hamburger-inner""></div>
            </div>
            </a>
        </div>

        <!-- Navigation links on top menu -->
        <ul data-topmenu-class="""" data-scroll-into-view=""slide-in-up-group"">
            <li><a href=""/Aboutme"">About Me</a></li>
            <li><a href=""/CV"">CV</a></li>
            <li><a href=""/contact"">Contact</a></li>
            <p>Copyright © 2020 Samu Lahti</p>
        </ul>
    </div>
</nav>

<main class=""contact"">   
        <!-- Contact by email -->
        <section class=""container single-vcenter background-mail"" >
            <div class=""site-width"">
                <div class=""grid"">
                    <div class=""col"">
                        <header>
                            <!-- Be careful with <br>! ion-android-drafts-->
                            <p>Easiest way to contact me is by email:<br>
                                <a href=""mailto");
            WriteLiteral(@":contact@samulahti.com"">contact@samulahti.com</a>.</p><br>
                                <p>If you feel that email is too complicated, you can also find me in LinkedIn:<br></p>
                                <a href=""https://fi.linkedin.com/in/samulahti"" class=""ion-social-linkedin linkedin-icon""></a>
                        </header>
                    </div>
                </div>
            </div>
        </section>
</main>


");
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
