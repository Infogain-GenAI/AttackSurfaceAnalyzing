#pragma checksum "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Pages\Author.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "78a2b45efbedd83226f0647321b6afa4c80ec0604f018431d7542d3eb77f7832"
// <auto-generated/>
#pragma warning disable 1591
namespace Microsoft.CST.AttackSurfaceAnalyzer.Cli.Pages
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
#line 9 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\_Imports.razor"
using Microsoft.CST.AttackSurfaceAnalyzer.Types;

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
#line 15 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\_Imports.razor"
using Microsoft.CST.AttackSurfaceAnalyzer.Objects;

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
#line 2 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Pages\Author.razor"
using System.Reflection.Metadata;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Pages\Author.razor"
using Microsoft.CodeAnalysis;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Pages\Author.razor"
using System.Reflection;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Pages\Author.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Pages\Author.razor"
using Tewr.Blazor.FileReader;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Pages\Author.razor"
using Microsoft.CST.OAT;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Pages\Author.razor"
using System.Runtime.Loader;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Pages\Author.razor"
using System.Diagnostics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Pages\Author.razor"
using Microsoft.CST.OAT.Blazor.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Pages\Author.razor"
using Microsoft.CST.OAT.Blazor.Components.Inputs;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/author")]
    public partial class Author : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h4>Author</h4>\n\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container-fluid bg-custom my-1 pb-1");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "run-box bg-custom");
            __builder.AddMarkupContent(5, "<h5>Load in JSON serialized rules.</h5>\n        ");
            __builder.OpenComponent<global::Microsoft.CST.OAT.Blazor.Components.Inputs.FileUpload>(6);
            __builder.AddAttribute(7, "ProcessFile", (object)((global::System.Func<System.IO.Stream, System.Threading.Tasks.Task>)(
#nullable restore
#line 22 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Pages\Author.razor"
                                 LoadRules

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(8, "ReadLabel", (object)("Load Rules"));
            __builder.AddAttribute(9, "ClearAction", (object)((global::System.Action)(
#nullable restore
#line 22 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Pages\Author.razor"
                                                                                ClearRules

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(10, "ClearLabel", (object)("Clear Rules"));
            __builder.CloseComponent();
            __builder.AddMarkupContent(11, "\n        <hr>\n        ");
            __builder.OpenElement(12, "button");
            __builder.AddAttribute(13, "class", "btn btn-primary");
            __builder.AddAttribute(14, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Pages\Author.razor"
                                                  AddRule

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(15, "Add Rule");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n        ");
            __builder.OpenElement(17, "button");
            __builder.AddAttribute(18, "class", "btn btn-primary");
            __builder.AddAttribute(19, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Pages\Author.razor"
                                                  RemoveLastRule

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "disabled", 
#nullable restore
#line 25 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Pages\Author.razor"
                                                                            removeDisabled

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(21, "Remove Last Rule");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n        ");
            __builder.OpenElement(23, "button");
            __builder.AddAttribute(24, "class", "btn btn-primary");
            __builder.AddAttribute(25, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Pages\Author.razor"
                                                  ValidateRules

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(26, "Validate Rules");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\n        ");
            __builder.OpenElement(28, "button");
            __builder.AddAttribute(29, "class", "btn btn-primary");
            __builder.AddAttribute(30, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Pages\Author.razor"
                                                  DownloadRules

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(31, "Export Rules to JSON");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\n        ");
            __builder.OpenElement(33, "button");
            __builder.AddAttribute(34, "class", "btn btn-primary");
            __builder.AddAttribute(35, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Pages\Author.razor"
                                                  LoadDefaultRules

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(36, "Load Embedded Rules");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 31 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Pages\Author.razor"
     foreach (var rule in AppState.Rules)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(37, "div");
#nullable restore
#line 34 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Pages\Author.razor"
             if (issues.ContainsKey(rule))
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Pages\Author.razor"
                 foreach (var problem in issues[rule])
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(38, "div");
            __builder.AddMarkupContent(39, "<span class=\"oi oi-warning\"></span>\n                        ");
#nullable restore
#line 40 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Pages\Author.razor"
__builder.AddContent(40, problem.Description);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 42 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Pages\Author.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Pages\Author.razor"
                 if (issues[rule].Count() > 0)
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(41, "<br>");
#nullable restore
#line 46 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Pages\Author.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Pages\Author.razor"
                 
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(42, "<p>Processing Issues for Rule...</p>");
#nullable restore
#line 51 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Pages\Author.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<global::Microsoft.CST.OAT.Blazor.Components.Inputs.RuleInput>(43);
            __builder.AddAttribute(44, "Rule", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.CST.OAT.Rule>(
#nullable restore
#line 53 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Pages\Author.razor"
                             rule

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(45, "CollapsedState", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.CST.OAT.Blazor.Components.ComponentCollapsedState>(
#nullable restore
#line 53 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Pages\Author.razor"
                                                   ComponentCollapsedState.Collapsed

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(46, "Types", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Type[]>(
#nullable restore
#line 53 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Pages\Author.razor"
                                                                                             Types

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 55 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Pages\Author.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "d:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Pages\Author.razor"
 

    void ClearRules()
    {
        AppState.Rules.Clear();
        this.StateHasChanged();
    }

    public bool removeDisabled => AppState.Rules.Count == 0;

    Func<Stream, Task> LoadRules;

    void RefreshPage()
    {
        this.StateHasChanged();
    }

    public void LoadDefaultRules()
    {
        var filters = RuleFile.LoadEmbeddedFilters();
        AppState.DefaultLevels = filters.DefaultLevels;
        AppState.Rules = filters.Rules.ToList();
        ValidateRules();
    }

    public async void DownloadRules()
    {
        await JSRuntime.InvokeAsync<object>(
            "FileSaveAs",
            "Asa-Rules.json",
            "data:text/plain;charset=utf-8,",
            Newtonsoft.Json.JsonConvert.SerializeObject(AppState.Rules)
        );
    }

    Type[] Types = typeof(AsaRule).Assembly.DefinedTypes.Where(x => typeof(CollectObject).IsAssignableFrom(x)).ToArray();

    Analyzer analyzer = new Analyzer();

    void SetLoadRules()
    {
        LoadRules = async stream =>
        {
            try
            {
                using var sr = new StreamReader(stream);
                var RulesFile = Newtonsoft.Json.JsonConvert.DeserializeObject<RuleFile>(await sr.ReadToEndAsync());
                AppState.Rules = RulesFile.Rules.ToList();
                AppState.DefaultLevels = RulesFile.DefaultLevels;
            }
            catch (OperationCanceledException)
            {
                await InvokeAsync(StateHasChanged);
                await Task.Delay(1);
            }
            catch (Exception e)
            {
                var message = e.Message;
                var stackTrace = e.StackTrace;
                var type = e.GetType();
                var name = type.Name;
                type = e.GetType();
                Console.WriteLine(e.Message);
            }
            ValidateRules();
        };
    }

    protected override void OnInitialized()
    {
        SetLoadRules();
        ValidateRules();
        OAT.Utils.Strings.Setup();
        base.OnInitialized();
    }

    Dictionary<AsaRule, IEnumerable<Violation>> issues = new Dictionary<AsaRule, IEnumerable<Violation>>();

    void ValidateRules()
    {
        issues.Clear();
        foreach (var rule in AppState.Rules)
        {
            issues[rule] = analyzer.EnumerateRuleIssues(rule);
        }
        this.StateHasChanged();
    }

    void RemoveLastRule()
    {
        if (AppState.Rules.Count > 0)
        {
            AppState.Rules.RemoveAt(AppState.Rules.Count - 1);
        }
        ValidateRules();
    }

    void AddRule()
    {
        AppState.Rules.Add(new AsaRule("Rule Name Here"));
        ValidateRules();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileReaderService fileReaderService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.CST.AttackSurfaceAnalyzer.Cli.AppData AppState { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.CST.AttackSurfaceAnalyzer.Cli.AppData appData { get; set; }
    }
}
#pragma warning restore 1591
