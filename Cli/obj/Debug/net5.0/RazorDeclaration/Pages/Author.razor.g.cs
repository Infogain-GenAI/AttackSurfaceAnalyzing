// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Microsoft.CST.AttackSurfaceAnalyzer.Cli.Pages
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\_Imports.razor"
using Microsoft.CST.AttackSurfaceAnalyzer.Cli.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\_Imports.razor"
using Microsoft.CST.AttackSurfaceAnalyzer.Types;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\_Imports.razor"
using Microsoft.CST.OAT.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\_Imports.razor"
using Microsoft.CST.AttackSurfaceAnalyzer.Cli.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\_Imports.razor"
using Microsoft.CST.AttackSurfaceAnalyzer.Cli.Components.States;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\_Imports.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\_Imports.razor"
using Microsoft.CST.AttackSurfaceAnalyzer.Objects;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\_Imports.razor"
using Microsoft.CST.AttackSurfaceAnalyzer.Collectors;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Pages\Author.razor"
using System.Reflection.Metadata;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Pages\Author.razor"
using Microsoft.CodeAnalysis;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Pages\Author.razor"
using System.Reflection;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Pages\Author.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Pages\Author.razor"
using Tewr.Blazor.FileReader;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Pages\Author.razor"
using Microsoft.CST.OAT;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Pages\Author.razor"
using System.Runtime.Loader;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Pages\Author.razor"
using System.Diagnostics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Pages\Author.razor"
using Microsoft.CST.OAT.Blazor.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Pages\Author.razor"
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
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "D:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Pages\Author.razor"
 

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
