﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ChameleonForms.Templates.TwitterBootstrap3
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    
    #line 1 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
    using System.Web.Mvc;
    
    #line default
    #line hidden
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 2 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
    using Component.Config;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
    using Enums;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.5.4.0")]
    public class TwitterBootstrapHtmlHelpers : System.Web.WebPages.HelperPage
    {

#line 9 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
public static System.Web.WebPages.HelperResult EndForm() {
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 9 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
                   


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    </form>\r\n");


#line 11 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"


#line default
#line hidden
});

#line 11 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
}
#line default
#line hidden

#line 13 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
public static System.Web.WebPages.HelperResult BeginSection(IHtmlString title, IHtmlString leadingHtml, HtmlAttributes htmlAttributes) {
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 13 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
                                                                                                 


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <fieldset");


#line 14 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
WriteTo(__razor_helper_writer, htmlAttributes);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, ">\r\n");

WriteLiteralTo(__razor_helper_writer, "        <legend>");


#line 15 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
WriteTo(__razor_helper_writer, title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</legend>\r\n");

WriteLiteralTo(__razor_helper_writer, "        ");


#line 16 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
WriteTo(__razor_helper_writer, leadingHtml);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n");


#line 17 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"


#line default
#line hidden
});

#line 17 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
}
#line default
#line hidden

#line 19 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
public static System.Web.WebPages.HelperResult EndSection() {
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 19 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
                      


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    </fieldset>\r\n");


#line 21 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"


#line default
#line hidden
});

#line 21 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
}
#line default
#line hidden

#line 23 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
public static System.Web.WebPages.HelperResult BeginNestedSection(IHtmlString title, IHtmlString leadingHtml, HtmlAttributes htmlAttributes)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 24 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
 


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <div class=\"panel panel-default\">\r\n");

WriteLiteralTo(__razor_helper_writer, "        <div class=\"panel-heading\">");


#line 26 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
       WriteTo(__razor_helper_writer, title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</div>\r\n");

WriteLiteralTo(__razor_helper_writer, "        <div class=\"panel-body\">\r\n");


#line 28 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"


#line default
#line hidden

#line 28 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
WriteTo(__razor_helper_writer, leadingHtml);


#line default
#line hidden

#line 28 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
            


#line default
#line hidden
});

#line 29 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
}
#line default
#line hidden

#line 31 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
public static System.Web.WebPages.HelperResult EndNestedSection() {
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 31 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
                            


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        </div>\r\n");

WriteLiteralTo(__razor_helper_writer, "    </div>\r\n");


#line 34 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"


#line default
#line hidden
});

#line 34 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
}
#line default
#line hidden

#line 36 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
public static System.Web.WebPages.HelperResult BeginField(IHtmlString labelHtml, IHtmlString elementHtml, IHtmlString validationHtml, ModelMetadata fieldMetadata, IReadonlyFieldConfiguration fieldConfiguration, bool isValid, IHtmlString requiredDesignator) {
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 36 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
                                                                                                                                                                                                                           


#line default
#line hidden

#line 37 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
WriteTo(__razor_helper_writer, BeginFieldInternal(labelHtml, elementHtml, validationHtml, fieldConfiguration, fieldMetadata, isValid, requiredDesignator));


#line default
#line hidden

#line 37 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
                                                                                                                           


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <div class=\"row nested-fields\">\r\n");

WriteLiteralTo(__razor_helper_writer, "                <div class=\"col-xs-1\"></div>\r\n");

WriteLiteralTo(__razor_helper_writer, "                <div class=\"col-xs-11\">\r\n");


#line 41 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"


#line default
#line hidden
});

#line 41 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
}
#line default
#line hidden

#line 43 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
public static System.Web.WebPages.HelperResult EndField() {
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 43 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
                    


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "                </div>\r\n");

WriteLiteralTo(__razor_helper_writer, "            </div>\r\n");

WriteLiteralTo(__razor_helper_writer, "        </div>\r\n");


#line 47 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"


#line default
#line hidden
});

#line 47 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
}
#line default
#line hidden

#line 49 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
public static System.Web.WebPages.HelperResult GetPrependedHtml(IReadonlyFieldConfiguration fieldConfiguration) {
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 49 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
                                                                          
    if (fieldConfiguration != null) {
        foreach (var html in fieldConfiguration.PrependedHtml) {

#line default
#line hidden

#line 51 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
                                  WriteTo(__razor_helper_writer, html);


#line default
#line hidden

#line 51 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
                                                                     }
    }


#line default
#line hidden
});

#line 53 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
}
#line default
#line hidden

#line 55 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
public static System.Web.WebPages.HelperResult GetAppendedHtml(IReadonlyFieldConfiguration fieldConfiguration) {
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 55 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
                                                                         
    if (fieldConfiguration != null) {
        foreach (var html in fieldConfiguration.AppendedHtml) {

#line default
#line hidden

#line 57 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
                                 WriteTo(__razor_helper_writer, html);


#line default
#line hidden

#line 57 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
                                                                    }
    }


#line default
#line hidden
});

#line 59 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
}
#line default
#line hidden

#line 61 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
public static System.Web.WebPages.HelperResult GetHint(IReadonlyFieldConfiguration fieldConfiguration) {
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 61 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
                                                                 
    if (fieldConfiguration != null && fieldConfiguration.Hint != null) {

#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "<div");

WriteLiteralTo(__razor_helper_writer, " class=\"help-block form-hint\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 62 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
                                                                            WriteTo(__razor_helper_writer, fieldConfiguration.Hint);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</div>");


#line 62 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
                                                                                                                                        }


#line default
#line hidden
});

#line 63 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
}
#line default
#line hidden

#line 65 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
public static System.Web.WebPages.HelperResult GetRequiredDesignator(bool isRequired, bool isCheckboxControl, bool isRadioList, IHtmlString requiredDesignator) {
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 65 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
                                                                                                                          
    if(isRadioList) { return; }
    if(isRequired && !isCheckboxControl){

#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "<div");

WriteLiteralTo(__razor_helper_writer, " class=\"input-group-addon required\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 67 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
                                                   WriteTo(__razor_helper_writer, requiredDesignator);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</div>");


#line 67 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
                                                                                                          }
    if(isCheckboxControl && isRequired) {

#line default
#line hidden

#line 68 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
           WriteTo(__razor_helper_writer, requiredDesignator);


#line default
#line hidden

#line 68 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
                                                            }


#line default
#line hidden
});

#line 69 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
}
#line default
#line hidden

#line 71 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
public static System.Web.WebPages.HelperResult RequiredDesignator(IReadonlyFieldConfiguration fieldConfiguration) {
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 71 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
                                                                            


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "<em");

WriteLiteralTo(__razor_helper_writer, " class=\"required\"");

WriteLiteralTo(__razor_helper_writer, " title=\"Required\"");

WriteLiteralTo(__razor_helper_writer, ">&lowast;</em>\r\n");


#line 73 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"


#line default
#line hidden
});

#line 73 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
}
#line default
#line hidden

#line 75 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
public static System.Web.WebPages.HelperResult GetLabelHtml(IHtmlString labelHtml, bool hasLabel, bool isCheckboxControl, bool isRadioList, bool isRequired, IHtmlString requiredDesignator) {
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 75 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
                                                                                                                                                       
    var wrapLabel = !hasLabel && !isCheckboxControl;
    if (wrapLabel) {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        ");

WriteLiteralTo(__razor_helper_writer, "<span class=\"control-label\">\r\n");


#line 79 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
    }
    

#line default
#line hidden

#line 80 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
WriteTo(__razor_helper_writer, labelHtml);


#line default
#line hidden

#line 80 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
              
    if (isRadioList && isRequired) {
        

#line default
#line hidden

#line 82 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
WriteTo(__razor_helper_writer, requiredDesignator);


#line default
#line hidden

#line 82 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
                           
    }
    if (wrapLabel) {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        ");

WriteLiteralTo(__razor_helper_writer, "</span>\r\n");


#line 86 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
    }


#line default
#line hidden
});

#line 87 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
}
#line default
#line hidden

#line 89 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
public static System.Web.WebPages.HelperResult BeginFieldInternal(IHtmlString labelHtml, IHtmlString elementHtml, IHtmlString validationHtml, IReadonlyFieldConfiguration fieldConfiguration, ModelMetadata fieldMetadata, bool isValid, IHtmlString requiredDesignator) {
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 89 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
                                                                                                                                                                                                                                   
    var isCheckboxControl = fieldConfiguration.GetBagData<bool>("IsCheckboxControl");
    var isRadioList = fieldConfiguration.GetBagData<bool>("IsRadioList");
    var isRequired = fieldMetadata != null && fieldMetadata.IsRequired;
    var isInputGroup = !isCheckboxControl && !isRadioList && isRequired;


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <div class=\"");


#line 94 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
WriteTo(__razor_helper_writer, isCheckboxControl ? "checkbox" : "form-group");


#line default
#line hidden

#line 94 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
                                             WriteTo(__razor_helper_writer, !isValid ? " has-error" : string.Empty);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\">\r\n");


#line 95 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
              

#line default
#line hidden

#line 95 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
WriteTo(__razor_helper_writer, GetLabelHtml(labelHtml, fieldConfiguration.HasLabel, isCheckboxControl, isRadioList, isRequired, requiredDesignator));


#line default
#line hidden

#line 95 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
                                                                                                                                   
              if (isInputGroup)
              {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <div class=\"input-group\">\r\n");


#line 99 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
              }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            ");


#line 100 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
WriteTo(__razor_helper_writer, GetPrependedHtml(fieldConfiguration));


#line default
#line hidden

#line 100 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
                     WriteTo(__razor_helper_writer, elementHtml);


#line default
#line hidden

#line 100 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
                                 WriteTo(__razor_helper_writer, GetRequiredDesignator(isRequired, isCheckboxControl, isRadioList, requiredDesignator));


#line default
#line hidden

#line 100 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
                                                                                                                       WriteTo(__razor_helper_writer, GetAppendedHtml(fieldConfiguration));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n");


#line 101 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
              if (isInputGroup)
              {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            </div>\r\n");


#line 104 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
              }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            ");


#line 105 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
WriteTo(__razor_helper_writer, GetHint(fieldConfiguration));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " ");


#line 105 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
             WriteTo(__razor_helper_writer, validationHtml);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n");


#line 106 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"


#line default
#line hidden
});

#line 106 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
}
#line default
#line hidden

#line 108 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
public static System.Web.WebPages.HelperResult Field(IHtmlString labelHtml, IHtmlString elementHtml, IHtmlString validationHtml, ModelMetadata fieldMetadata, IReadonlyFieldConfiguration fieldConfiguration, bool isValid, IHtmlString requiredDesignator) {
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 108 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
                                                                                                                                                                                                                      


#line default
#line hidden

#line 109 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
WriteTo(__razor_helper_writer, BeginFieldInternal(labelHtml, elementHtml, validationHtml, fieldConfiguration, fieldMetadata, isValid, requiredDesignator));


#line default
#line hidden

#line 109 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
                                                                                                                           


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            </div>\r\n");


#line 111 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"


#line default
#line hidden
});

#line 111 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
}
#line default
#line hidden

#line 113 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
public static System.Web.WebPages.HelperResult BeginMessage(TwitterAlertType messageType, IHtmlString heading) {
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 113 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
                                                                         


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "      <div class=\"panel ");


#line 114 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
WriteTo(__razor_helper_writer, string.Format("panel-{0}", messageType.ToString().ToLower()));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\">\r\n");


#line 115 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
            if (!string.IsNullOrEmpty(heading.ToHtmlString()))
            {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "          <div class=\"panel-heading\"><h4 class=\"panel-title\">");


#line 117 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
                                 WriteTo(__razor_helper_writer, heading);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</h4></div>\r\n");


#line 118 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
            }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "          <div class=\"panel-body\">\r\n");


#line 120 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"


#line default
#line hidden
});

#line 120 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
}
#line default
#line hidden

#line 122 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
public static System.Web.WebPages.HelperResult EndMessage() {
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 122 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
                      


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "          </div>\r\n");

WriteLiteralTo(__razor_helper_writer, "      </div>\r\n");


#line 125 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"


#line default
#line hidden
});

#line 125 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
}
#line default
#line hidden

#line 127 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
public static System.Web.WebPages.HelperResult BeginNavigation() {
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 127 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
                           


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <div class=\"btn-group\">\r\n");


#line 129 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"


#line default
#line hidden
});

#line 129 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
}
#line default
#line hidden

#line 131 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
public static System.Web.WebPages.HelperResult EndNavigation() {
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 131 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
                         


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        </div>\r\n");


#line 133 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"


#line default
#line hidden
});

#line 133 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
}
#line default
#line hidden

#line 135 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
public static System.Web.WebPages.HelperResult RadioList(IEnumerable<IHtmlString> items, bool isCheckbox) {
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 135 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
                                                                    
    foreach (var item in items) {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <div");

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 5171), Tuple.Create("\"", 5215)

#line 137 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
, Tuple.Create(Tuple.Create("", 5179), Tuple.Create<System.Object, System.Int32>(isCheckbox ? "checkbox" : "radio"

#line default
#line hidden
, 5179), false)
);

WriteLiteralTo(__razor_helper_writer, ">");


#line 137 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
                            WriteTo(__razor_helper_writer, item);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</div>\r\n");


#line 138 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
    }


#line default
#line hidden
});

#line 139 "..\..\Templates\TwitterBootstrap3\TwitterBootstrapHtmlHelpers.cshtml"
}
#line default
#line hidden

    }
}
#pragma warning restore 1591
