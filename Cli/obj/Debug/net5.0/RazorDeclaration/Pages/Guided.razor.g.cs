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
#line 1 "D:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Pages\Guided.razor"
using Microsoft.CST.OAT.Blazor.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Pages\Guided.razor"
using Microsoft.CST.AttackSurfaceAnalyzer.Types;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Pages\Guided.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Pages\Guided.razor"
using Microsoft.CST.AttackSurfaceAnalyzer.Objects;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Pages\Guided.razor"
using Microsoft.CST.AttackSurfaceAnalyzer.Collectors;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/guided")]
    public partial class Guided : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 71 "D:\sonarcube_projects\AttackSurfaceAnalyzer\Cli\Pages\Guided.razor"
      
    enum PageState
    {
        Options,
        Scanning,
        Monitoring,
        MonitorFlushing,
        Analyzing,
        Results,
        Error
    }

    bool UseTimestamp = true;
    string RunIdInput = "";

    PageState pageState = PageState.Options;

    async void BeginGuided()
    {
        appData.RunId = UseTimestamp ? DateTime.Now.ToString() : RunIdInput;
        timer = new System.Threading.Timer((_) => InvokeAsync(() => StateHasChanged()), null, 0, 100);
        appData.CollectOptions.RunId = appData.FirstRunId;
        if (await BeginScan() == ASA_ERROR.NONE)
        {
            appData.MonitorOptions.RunId = appData.MonitorRunId;
            await BeginMonitor();
            AttackSurfaceAnalyzerClient.ClearCollectors();
        }
        else
        {
            pageState = PageState.Error;
        }
    }

    async void ContinueGuided()
    {
        pageState = PageState.MonitorFlushing;
        this.StateHasChanged();
        AttackSurfaceAnalyzerClient.StopMonitors();
        while (AttackSurfaceAnalyzerClient.DatabaseManager.HasElements)
        {
            Thread.Sleep(1);
        }

        appData.CollectOptions.RunId = appData.SecondRunId;
        await BeginScan();

        appData.ExportCollectCommandOptions.SaveToDatabase = true;
        appData.ExportCollectCommandOptions.FirstRunId = appData.FirstRunId;
        appData.ExportCollectCommandOptions.SecondRunId = appData.SecondRunId;
        await BeginAnalyze();
        pageState = PageState.Results;
    }

    System.Threading.Timer timer;

    async Task<ASA_ERROR> BeginScan()
    {
        pageState = PageState.Scanning;
        this.StateHasChanged();
        return await Task.Factory.StartNew(() => AttackSurfaceAnalyzerClient.RunCollectCommand(appData.CollectOptions));
    }

    async Task<ASA_ERROR> BeginMonitor()
    {
        pageState = PageState.Monitoring;
        this.StateHasChanged();
        return await Task.Factory.StartNew(() => AttackSurfaceAnalyzerClient.RunGuiMonitorCommand(appData.MonitorOptions));
    }

    async Task<ASA_ERROR> BeginAnalyze()
    {
        pageState = PageState.Analyzing;

        await Task.Factory.StartNew(() =>
        {
            var CompareOneOptions = appData.CompareCommandOptions;
            CompareOneOptions.FirstRunId = appData.ExportCollectCommandOptions.FirstRunId;
            CompareOneOptions.SecondRunId = appData.ExportCollectCommandOptions.SecondRunId ?? string.Empty;
            var results = AttackSurfaceAnalyzerClient.CompareRuns(CompareOneOptions);
            AttackSurfaceAnalyzerClient.InsertCompareResults(results, appData.ExportCollectCommandOptions.FirstRunId, appData.ExportCollectCommandOptions.SecondRunId ?? string.Empty, appData.CompareCommandOptions.AnalysesFile?.GetHash() ?? "");
        });

        await Task.Factory.StartNew(() =>
        {
            var CompareTwoOptions = appData.CompareCommandOptions;

            CompareTwoOptions.FirstRunId = null;
            CompareTwoOptions.SecondRunId = appData.MonitorRunId;
            var results = AttackSurfaceAnalyzerClient.CompareRuns(CompareTwoOptions);
            AttackSurfaceAnalyzerClient.InsertCompareResults(results, null, appData.MonitorRunId, appData.CompareCommandOptions.AnalysesFile?.GetHash() ?? "");
        });
        return ASA_ERROR.NONE;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.CST.AttackSurfaceAnalyzer.Cli.AppData appData { get; set; }
    }
}
#pragma warning restore 1591
