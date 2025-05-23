#pragma checksum "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Components\States\Results.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "b152094cb43d2ade6cb2ce0b767146f7eaf3900a06cac63d86dde1057fe721a9"
// <auto-generated/>
#pragma warning disable 1591
namespace Microsoft.CST.AttackSurfaceAnalyzer.Cli.Components.States
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\_Imports.razor"
using Microsoft.CST.AttackSurfaceAnalyzer.Cli.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\_Imports.razor"
using Microsoft.CST.OAT.Blazor.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\_Imports.razor"
using Microsoft.CST.OAT.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\_Imports.razor"
using Microsoft.CST.AttackSurfaceAnalyzer.Cli.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\_Imports.razor"
using Microsoft.CST.AttackSurfaceAnalyzer.Cli.Components.States;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\_Imports.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\_Imports.razor"
using Microsoft.CST.AttackSurfaceAnalyzer.Collectors;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Components\States\Results.razor"
using Microsoft.CST.AttackSurfaceAnalyzer.Types;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Components\States\Results.razor"
using Microsoft.CST.AttackSurfaceAnalyzer.Objects;

#line default
#line hidden
#nullable disable
    public partial class Results : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "form-inline pb-3");
            __builder.AddMarkupContent(2, "<label class=\"mr-2\" for=\"ResultType\">Result Type:</label>\n    ");
            __builder.OpenElement(3, "select");
            __builder.AddAttribute(4, "class", "form-control mr-2");
            __builder.AddAttribute(5, "id", "ResultType");
            __builder.AddAttribute(6, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 7 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Components\States\Results.razor"
                                                             SelectedResultType

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SelectedResultType = __value, SelectedResultType));
            __builder.SetUpdatesAttributeName("value");
#nullable restore
#line 8 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Components\States\Results.razor"
         foreach (var resultType in foundResultTypes)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "option");
            __builder.AddAttribute(9, "value", 
#nullable restore
#line 10 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Components\States\Results.razor"
                            resultType.Key

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 10 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Components\States\Results.razor"
__builder.AddContent(10, resultType.Key);

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, " : ");
#nullable restore
#line 10 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Components\States\Results.razor"
__builder.AddContent(12, resultType.Value);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 11 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Components\States\Results.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\n\n    ");
            __builder.AddMarkupContent(14, "<label class=\"mr-2\" for=\"MaxResults\">View:</label>\n    ");
            __builder.OpenElement(15, "select");
            __builder.AddAttribute(16, "class", "form-control");
            __builder.AddAttribute(17, "id", "MaxResults");
            __builder.AddAttribute(18, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Components\States\Results.razor"
                                                        MaxResults

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => MaxResults = __value, MaxResults));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(20, "option");
            __builder.AddAttribute(21, "value", "50");
            __builder.AddContent(22, "50");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\n        ");
            __builder.OpenElement(24, "option");
            __builder.AddAttribute(25, "selected");
            __builder.AddAttribute(26, "value", "100");
            __builder.AddContent(27, "100");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\n        ");
            __builder.OpenElement(29, "option");
            __builder.AddAttribute(30, "value", "250");
            __builder.AddContent(31, "250");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\n        ");
            __builder.OpenElement(33, "option");
            __builder.AddAttribute(34, "value", "500");
            __builder.AddContent(35, "500");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 23 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Components\States\Results.razor"
 if (pageCount > 0)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(36, "p");
#nullable restore
#line 25 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Components\States\Results.razor"
__builder.AddContent(37, foundResultTypes[(RESULT_TYPE)Enum.Parse(typeof(RESULT_TYPE), SelectedResultType)]);

#line default
#line hidden
#nullable disable
            __builder.AddContent(38, " results found for type ");
#nullable restore
#line 25 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Components\States\Results.razor"
__builder.AddContent(39, SelectedResultType);

#line default
#line hidden
#nullable disable
            __builder.AddContent(40, ".");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\n    ");
            __builder.OpenElement(42, "nav");
            __builder.AddAttribute(43, "aria-label", "Paged results navigation");
            __builder.OpenElement(44, "ul");
            __builder.AddAttribute(45, "class", "pagination");
            __builder.OpenElement(46, "li");
            __builder.AddAttribute(47, "class", "page-item");
            __builder.OpenElement(48, "a");
            __builder.AddAttribute(49, "class", "page-link page-step");
            __builder.AddAttribute(50, "aria-label", "Previous page");
            __builder.AddAttribute(51, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Components\States\Results.razor"
                                                                                    () => GetResultsPageByOffset(-1)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(52, "<span aria-hidden=\"true\">&lt;</span>\n                    ");
            __builder.AddMarkupContent(53, "<span class=\"sr-only\">Previous</span>");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 34 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Components\States\Results.razor"
             for (int i = 1; i <= pageCount; i++)
            {
                var pageNum = i;

#line default
#line hidden
#nullable disable
            __builder.OpenElement(54, "li");
            __builder.AddAttribute(55, "class", "page-item" + " " + (
#nullable restore
#line 37 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Components\States\Results.razor"
                                      GetPageState(i)

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(56, "a");
            __builder.AddAttribute(57, "class", "page-link");
            __builder.AddAttribute(58, "aria-label", "Page-" + (
#nullable restore
#line 37 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Components\States\Results.razor"
                                                                                              pageNum

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(59, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Components\States\Results.razor"
                                                                                                                 () => GetResultsPage(pageNum)

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line 37 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Components\States\Results.razor"
__builder.AddContent(60, pageNum);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 38 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Components\States\Results.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(61, "li");
            __builder.AddAttribute(62, "class", "page-item");
            __builder.OpenElement(63, "a");
            __builder.AddAttribute(64, "class", "page-link page-step");
            __builder.AddAttribute(65, "aria-label", "Next page");
            __builder.AddAttribute(66, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Components\States\Results.razor"
                                                                                () => GetResultsPageByOffset(1)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(67, "<span aria-hidden=\"true\">&gt;</span>\n                    ");
            __builder.AddMarkupContent(68, "<span class=\"sr-only\">Next</span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 48 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Components\States\Results.razor"
     for (int i = 0; i < analysisResults.Count; i++)
    {
        var result = analysisResults[i];
        var resultNumber = offset + i + 1;

#line default
#line hidden
#nullable disable
            __builder.OpenElement(69, "div");
            __builder.AddAttribute(70, "class", "pb-3");
            __builder.OpenElement(71, "div");
            __builder.OpenElement(72, "span");
            __builder.AddAttribute(73, "class", "result-number");
#nullable restore
#line 54 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Components\States\Results.razor"
__builder.AddContent(74, resultNumber);

#line default
#line hidden
#nullable disable
            __builder.AddContent(75, ". ");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\n                ");
            __builder.OpenElement(77, "span");
            __builder.AddAttribute(78, "class", "result-text");
#nullable restore
#line 55 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Components\States\Results.razor"
__builder.AddContent(79, result.Analysis);

#line default
#line hidden
#nullable disable
            __builder.AddContent(80, ": ");
#nullable restore
#line 55 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Components\States\Results.razor"
__builder.AddContent(81, result.Identity);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 57 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Components\States\Results.razor"
             foreach (var rule in result.Rules)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(82, "div");
            __builder.AddAttribute(83, "class", "rule-text");
#nullable restore
#line 59 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Components\States\Results.razor"
__builder.AddContent(84, rule.Name);

#line default
#line hidden
#nullable disable
            __builder.AddContent(85, ": ");
#nullable restore
#line 59 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Components\States\Results.razor"
__builder.AddContent(86, rule.Description);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 60 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Components\States\Results.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 62 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Components\States\Results.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Components\States\Results.razor"
     
}
else 
{ 

#line default
#line hidden
#nullable disable
            __builder.OpenElement(87, "p");
            __builder.AddContent(88, "0 results found for type ");
#nullable restore
#line 66 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Components\States\Results.razor"
__builder.AddContent(89, SelectedResultType);

#line default
#line hidden
#nullable disable
            __builder.AddContent(90, ".");
            __builder.CloseElement();
#nullable restore
#line 67 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Components\States\Results.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 69 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Components\States\Results.razor"
       
    string _firstRunId = string.Empty;
    string _secondRundId = string.Empty;
    string _analysesHash = string.Empty;
    string _monitorRunId = string.Empty;

    [Parameter]
    public string FirstRunId { get { return _firstRunId; } set { _firstRunId = value; OnInitialized(); } }
    [Parameter]
    public string SecondRunId { get { return _secondRundId; } set { _secondRundId = value; OnInitialized(); } }
    [Parameter]
    public string AnalysesHash { get { return _analysesHash; } set { _analysesHash = value; OnInitialized(); } }
    [Parameter]
    public string MonitorRunId { get { return _monitorRunId; } set { _monitorRunId = value; OnInitialized(); } }

    protected override void OnInitialized()
    {
        ParseOptsToResultTypes();
        UpdatePageCount();
        GetResultsPage(1);
        base.OnInitialized();
    }

    Dictionary<RESULT_TYPE, int> foundResultTypes = new Dictionary<RESULT_TYPE, int>();
    public List<CompareResult> analysisResults = new List<CompareResult>();
    int offset = 0;
    int currentPage = 1;
    int pageCount = 0;

    int _maxResults = 100;
    int MaxResults
    {
        get { return _maxResults; }
        set
        {
            _maxResults = value;
            UpdatePageCount();
            GetResultsPage(1);
        }
    }

    string _selectedResultType = "FILEMONITOR";
    string SelectedResultType
    {
        get { return _selectedResultType; }
        set
        {
            _selectedResultType = value;
            UpdatePageCount();
            GetResultsPage(1);
        }
    }

    void GetResultsPage(int selectedPage)
    {
        if (pageCount < 1) { return; }
        currentPage = selectedPage;
        offset = MaxResults * (selectedPage - 1);
        GetAnalysisResults();
        this.StateHasChanged();
    }

    void GetResultsPageByOffset(int pageOffset)
    {
        var selectedPage = currentPage + pageOffset;
        if (selectedPage < 1) { selectedPage = 1;}
        else if (selectedPage > pageCount) { selectedPage = pageCount; }
        GetResultsPage(selectedPage);
    }

    string GetPageState(int selectedPage)
    {
        return selectedPage == currentPage ? "active" : "";
    }

    public void UpdatePageCount()
    {
        var resultType = (RESULT_TYPE)Enum.Parse(typeof(RESULT_TYPE), SelectedResultType);
        var found = foundResultTypes[resultType];      
        pageCount = (int)Math.Ceiling((double)found / MaxResults);
        currentPage = 1;
    }

    public void GetAnalysisResults()
    {
        if (AttackSurfaceAnalyzerClient.DatabaseManager is null)
        {
            analysisResults = new List<CompareResult>();
            return;
        }
        var resultType = (RESULT_TYPE)Enum.Parse(typeof(RESULT_TYPE), SelectedResultType);
        switch (resultType)
        {
            case RESULT_TYPE.FILEMONITOR:
                analysisResults = AttackSurfaceAnalyzerClient.DatabaseManager.GetComparisonResults(string.Empty, MonitorRunId, AnalysesHash, resultType, offset, MaxResults);
                break;
            default:
                analysisResults = AttackSurfaceAnalyzerClient.DatabaseManager.GetComparisonResults(FirstRunId, SecondRunId, AnalysesHash, resultType, offset, MaxResults);
                break;
        }
    }

    public void ParseOptsToResultTypes()
    {
        foundResultTypes.Clear();
        if (AttackSurfaceAnalyzerClient.DatabaseManager is null)
        {
            return;
        }        
        foreach (var resultType in Enum.GetValues(typeof(RESULT_TYPE)))
        {
            var found = AttackSurfaceAnalyzerClient.DatabaseManager.GetComparisonResultsCount(FirstRunId, SecondRunId, AnalysesHash, (int)resultType);
            if (found == 0)
            {
                found = AttackSurfaceAnalyzerClient.DatabaseManager.GetComparisonResultsCount(string.Empty, MonitorRunId, AnalysesHash, (int)resultType);
            }
            foundResultTypes.Add((RESULT_TYPE)resultType, found);
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.CST.AttackSurfaceAnalyzer.Cli.AppData appData { get; set; }
    }
}
#pragma warning restore 1591
