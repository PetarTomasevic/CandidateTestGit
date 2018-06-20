#pragma checksum "C:\Repos\NewCandidateTest\TestProject\TestProject\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1af36310e51817db292fd0f7691f16417da8e347"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Repos\NewCandidateTest\TestProject\TestProject\Views\_ViewImports.cshtml"
using TestProject;

#line default
#line hidden
#line 2 "C:\Repos\NewCandidateTest\TestProject\TestProject\Views\_ViewImports.cshtml"
using TestProject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1af36310e51817db292fd0f7691f16417da8e347", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5793b3861753add5f6e734f58173abd93064819", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Repos\NewCandidateTest\TestProject\TestProject\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 6922, true);
            WriteLiteral(@"

    <section class=""featured"">
        <div class=""content-wrapper"">
            <hgroup class=""title"">

                <h2>Test project</h2>

                <p>The points listed below illustrate the features to be implemented in the project. <b>For the success of the test, develop at least step one.</b></p>

                <p><strong>Project is organized as follows:</strong></p>
                <ul>
                    <li>
                        We are using Autofac for dependency injections
                    </li>
                    <li>
                        <strong>TestProject.Client</strong>
                        <br />Here you will find views and controllers of main application
                    </li>
                    <li>
                        <strong>TestProject.Contracts</strong>
                        <br />Here you will find Interfaces and Entities
                    </li>
                    <li>
                        <strong>TestProject.Domain</str");
            WriteLiteral(@"ong>
                        <br />Here you will find bussines logic and service layer code
                    </li>
                    <li>
                        <strong>TestProject.Infrastructure</strong>
                        <br />All code which communicates  with database goes here.
                        <br />We are using linq and EF code first
                    </li>
                </ul>

                <p><strong>Some project and development guidelines.:</strong></p>
                <ul>
                    <li>Short explanation how to start work on this project and organize code:
                    <ul>
                        <li>
                            In first step you have task to add method to show catalog details data.
                            <br>We do call to database and get some catalog items details
                           <p>Correct way to finish that will be:
                               <ul>
                                   <li>
          ");
            WriteLiteral(@"                             1. Open Catalog repository in infrastructure project
                                      <br /> 2. Add new method to get catalog details data
                                   </li>
                                   <li>
                                       3. Open Interface for catalog repository in Contract project
                                       <br />4. Add interface for previously added method in repository
                                   </li>
                                   <li>
                                       5. Open Catalog service in Domain project and add new service method to consume
                                       previously created repository method over that method interface
                                       <br />6. Add interface for that catalog service method to ICatalogService inside Contracts project
                                   </li>
                                   <li>
                               ");
            WriteLiteral(@"        7. Open Catalog Controller in Client project
                                      <br /> 8. Setup new method to consume method from catalog service and return Catalog details data
                                   </li>
                                   <li>
                                       8. Build. Run project
                                       <br />9. test if details view in client project correctly returns catalog details.
                                   </li>
                               </ul>
                            </p>
                        </li>
                    </ul>
                    </li>
                    
                </ul>
            </hgroup>

        </div>
    </section>

    <ol class=""round"">

        <h2>Tasks</h2>
        <h4><strong>Step one</strong></h4>
        <li>
            <h5><b>Complete the Catalog view</b> </h5>
            <br />
            <p>by introducing missing features add code  to show catalog detai");
            WriteLiteral(@"ls and add code for deleting catalog items.</p>
        </li>
        <li>
            <h5><b>Add Products handling</b></h5>
            <br />
            <p>We must enable consumer to be able to see Products in the same way as we are showing Catalog</p>
            <p>
                Use Catalog as example to create:
                <ul>
                    <li>-product views</li>
                    <li>-product controllers</li>
                    <li>-show products list</li>
                    <li>-show products details</li>
                    <li>-enable adding new product</li>
                    <li>-enable editing product details</li>
                    <li>-enable deleting product</li>
                </ul>
            </p>
            <p>Additional (but not required) create separate repository and service  classes for products and catalogs.</p>
            <p>
                <font color=""red"">
                    Notice: If you're applying for junior position this is the e");
            WriteLiteral(@"nd of required tasks you must do.
                    <br />Any addition is benefit, but nor required.
                </font>
            </p>
        </li>


        <h4><b>Step two</b></h4>
        <li>
            <h5>In the catalog list view, introduce a function to link the products to the catalog. The new function can open a new view or can expose the data in a popup page, for example with jQuery.</h5>
            <ul>
                <li>
                    Enable Adding Products to Catalogs /Deleting products from catalogs
                </li>
                <li>
                    - One product must have  option to be added to multiple catalogs
                </li>
                <li>
                    - User must have option to Add / Remove product from catalog
                </li>
                <li>
                    - One product can be added only once in one catalog. If product already exists in catalog return warning to user when adding product to catalog.
   ");
            WriteLiteral(@"             </li>
                <li>
                    -use code first migrations to update database.
                </li>
                <li>
                   Additional (not required): 
                    <br />Enable Option to add some pricing strategies for product
                    <br /> Add pricing strategy for products to Catalog
                </li>
            </ul>

        </li>
        <h4>Step tree</h4>
        <li>
            <h5>Add logging errors to service layer (use ILoggerFactory)</h5>
            <br />
            <p></p>
        </li>
        <li>
            <h5>Add unit Test project and cover service methods for Catalog with some tests.</h5>
            <br />
            <p></p>
        </li>

    </ol>
");
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
