using System;

namespace Cigna_DEMO
{
/// <summary>
/// OpenSpan design component.
/// </summary>
// UniversalWebAdapter-8D97C64A810BB90
[OpenSpan.Design.ComponentIdentityAttribute("UniversalWebAdapter-8D97C64A810BB90")]
[System.ComponentModel.ToolboxItemAttribute(false)]
public sealed class OpenGoogle : OpenSpan.Adapters.Web.Universal.UniversalWebAdapter
{
	
	[OpenSpan.Design.ComponentIdentityAttribute("UniversalWebAdapter-8D97C64A810BB90\\WebPage-8D97C65AB205C80")]
	public OpenSpan.Adapters.Web.WebBase.Controls.WebPage Google;
	
	[OpenSpan.Design.ComponentIdentityAttribute("UniversalWebAdapter-8D97C64A810BB90\\Form-8D97C65AB16C312")]
	public OpenSpan.Adapters.Web.WebBase.Controls.Form @__A8SBwfpositionrelativemargin0_aut;
	
	[OpenSpan.Design.ComponentIdentityAttribute("UniversalWebAdapter-8D97C64A810BB90\\TextBox-8D97C65AB05201F")]
	public OpenSpan.Adapters.Web.WebBase.Controls.TextBox SearchBox;
	
	private OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule virtualPropertyMatchRule4;
	
	private OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule virtualPropertyMatchRule3;
	
	private OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule virtualPropertyMatchRule1;
	
	private OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule virtualPropertyMatchRule2;
	
	public OpenGoogle()
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Setup field members
		// 
		System.ComponentModel.ComponentResourceManager _resources_ = new System.ComponentModel.ComponentResourceManager(typeof(OpenGoogle));
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		OpenSpan.Adapters.TextMatchData textmatchdata2 = new OpenSpan.Adapters.TextMatchData();
		OpenSpan.Adapters.TextMatchData textmatchdata3 = new OpenSpan.Adapters.TextMatchData();
		OpenSpan.Adapters.TextMatchData textmatchdata4 = new OpenSpan.Adapters.TextMatchData();
		this.Google = new OpenSpan.Adapters.Web.WebBase.Controls.WebPage();
		this.@__A8SBwfpositionrelativemargin0_aut = new OpenSpan.Adapters.Web.WebBase.Controls.Form();
		this.SearchBox = new OpenSpan.Adapters.Web.WebBase.Controls.TextBox();
		this.virtualPropertyMatchRule4 = new OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule();
		this.virtualPropertyMatchRule3 = new OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule();
		this.virtualPropertyMatchRule1 = new OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule();
		this.virtualPropertyMatchRule2 = new OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule();
		// 
		// Initialize design component
		// 
		this.Initialize();
		// 
		// Set design component Id
		// 
		this.Id = new OpenSpan.Design.ComponentIdentity("UniversalWebAdapter-8D97C64A810BB90");
		// 
		// Set component Ids
		// 
		this.SetId(this.Google, new OpenSpan.Design.ComponentIdentity("WebPage-8D97C65AB205C80"));
		this.SetId(this.@__A8SBwfpositionrelativemargin0_aut, new OpenSpan.Design.ComponentIdentity("Form-8D97C65AB16C312"));
		this.SetId(this.SearchBox, new OpenSpan.Design.ComponentIdentity("TextBox-8D97C65AB05201F"));
		this.SetId(this.virtualPropertyMatchRule4, new OpenSpan.Design.ComponentIdentity("VirtualPropertyMatchRule-8D97C65AB7B3FEE"));
		this.SetId(this.virtualPropertyMatchRule3, new OpenSpan.Design.ComponentIdentity("VirtualPropertyMatchRule-8D97C65AB6997BE"));
		this.SetId(this.virtualPropertyMatchRule1, new OpenSpan.Design.ComponentIdentity("VirtualPropertyMatchRule-8D97C65AB486D05"));
		this.SetId(this.virtualPropertyMatchRule2, new OpenSpan.Design.ComponentIdentity("VirtualPropertyMatchRule-8D97C65AB4F9339"));
		// 
		// OpenGoogle
		// 
		this.AdditionalArguments = null;
		this.AdvancedConfiguration = null;
		this.BrowserStopMethod = OpenSpan.Adapters.Web.Universal.UniversalWebAdapter.BrowserStopMethodEnum.StopTrackedDocuments;
		this.BrowserType = OpenSpan.Adapters.Web.Universal.Service.BrowserType.Chrome;
		ComponentInfo.CodeDomData = _resources_.GetString("_OpenGoogle_1_");
		// 
		// Google
		// 
		// 
		// __A8SBwfpositionrelativemargin0_aut
		// 
		// 
		// SearchBox
		// 
		this.SearchBox.ElementId = null;
		this.SearchBox.Extender = null;
		this.SearchBox.ExtensibleTypeName = null;
		this.SearchBox.ForwardObjectExplorerEvent = true;
		this.SearchBox.MatchingIndex = 0;
		// 
		// virtualPropertyMatchRule4
		// 
		this.virtualPropertyMatchRule4.PropertyName = "type";
		textmatchdata1.Text = "text";
		this.virtualPropertyMatchRule4.Text = textmatchdata1;
		this.SearchBox.MatchRules.Add(this.virtualPropertyMatchRule4);
		this.SearchBox.Name = "SearchBox";
		this.SearchBox.PegaId = 0;
		this.SearchBox.TagName = "INPUT";
		this.SearchBox.TargetTypeString = _resources_.GetString("_OpenGoogle_2_");
		this.SearchBox.UseElementId = false;
		this.@__A8SBwfpositionrelativemargin0_aut.Controls.Add(this.SearchBox);
		this.@__A8SBwfpositionrelativemargin0_aut.ElementId = null;
		this.@__A8SBwfpositionrelativemargin0_aut.Extender = null;
		this.@__A8SBwfpositionrelativemargin0_aut.ExtensibleTypeName = null;
		this.@__A8SBwfpositionrelativemargin0_aut.ForwardObjectExplorerEvent = true;
		this.@__A8SBwfpositionrelativemargin0_aut.MatchingIndex = 0;
		// 
		// virtualPropertyMatchRule3
		// 
		this.virtualPropertyMatchRule3.PropertyName = "action";
		textmatchdata2.Text = "https://www.google.com/search";
		this.virtualPropertyMatchRule3.Text = textmatchdata2;
		this.@__A8SBwfpositionrelativemargin0_aut.MatchRules.Add(this.virtualPropertyMatchRule3);
		this.@__A8SBwfpositionrelativemargin0_aut.Name = "__A8SBwfpositionrelativemargin0_aut";
		this.@__A8SBwfpositionrelativemargin0_aut.PegaId = 0;
		this.@__A8SBwfpositionrelativemargin0_aut.TagName = "FORM";
		this.@__A8SBwfpositionrelativemargin0_aut.TargetTypeString = _resources_.GetString("_OpenGoogle_3_");
		this.@__A8SBwfpositionrelativemargin0_aut.UseElementId = false;
		this.Google.Controls.Add(this.@__A8SBwfpositionrelativemargin0_aut);
		this.Google.Extender = null;
		this.Google.ForwardObjectExplorerEvent = true;
		this.Google.IsGlobal = true;
		this.Google.MatchingIndex = 0;
		// 
		// virtualPropertyMatchRule1
		// 
		this.virtualPropertyMatchRule1.PropertyName = "url";
		textmatchdata3.Text = "https://www.google.com/";
		this.virtualPropertyMatchRule1.Text = textmatchdata3;
		// 
		// virtualPropertyMatchRule2
		// 
		this.virtualPropertyMatchRule2.PropertyName = "title";
		textmatchdata4.Text = "Google";
		this.virtualPropertyMatchRule2.Text = textmatchdata4;
		this.Google.MatchRules.Add(this.virtualPropertyMatchRule1);
		this.Google.MatchRules.Add(this.virtualPropertyMatchRule2);
		this.Google.Name = "Google";
		this.Google.PegaId = 0;
		this.Google.TargetTypeString = _resources_.GetString("_OpenGoogle_4_");
		this.Controls.Add(this.Google);
		this.ElectronConfiguration.Path = "";
		this.ElectronConfiguration.TargetPath = null;
		this.ElectronConfiguration.WorkingDirectory = null;
		this.ExpressNativeTypes = null;
		this.Extender = null;
		this.FriendlyName = "OpenGoogle";
		this.IgnoreMainBrowser = false;
		this.Name = "OpenGoogle";
		this.Path = "";
		this.ReasonAdapterNotReady = null;
		this.StartMyDay = OpenSpan.ApplicationFramework.StartMyDay.StartOptions.None;
		this.StartMyDayControls = null;
		this.StartPage = null;
		this.StartTimeout = 20000;
		this.UnmatchOnZeroLocationAndSize = false;
		this.WorkingDirectory = null;
		this.XrayMasterNames = null;
		// 
		// Add components
		// 
		this.mComponents = new System.Collections.Generic.List<System.ComponentModel.IComponent>(20);
		this.Components.Add(this.Google);
		this.Components.Add(this.@__A8SBwfpositionrelativemargin0_aut);
		this.Components.Add(this.SearchBox);
		this.Components.Add(this.virtualPropertyMatchRule4);
		this.Components.Add(this.virtualPropertyMatchRule3);
		this.Components.Add(this.virtualPropertyMatchRule1);
		this.Components.Add(this.virtualPropertyMatchRule2);
	}
	
	private System.Collections.Generic.List<System.ComponentModel.IComponent> mComponents;
	
	public System.Collections.Generic.List<System.ComponentModel.IComponent> Components
	{
		get
		{
			return this.mComponents;
		}
	}
	
	/// <summary>
	/// Start design component.
	/// </summary>
	public override void Start()
	{
		base.Start();
	}
	
	/// <summary>
	/// Stop design component.
	/// </summary>
	public override void Stop()
	{
		base.Stop();
	}
	
	internal OpenSpan.Adapters.Web.WebBase.Controls.WebPage Create_Google(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		System.ComponentModel.ComponentResourceManager _resources_ = new System.ComponentModel.ComponentResourceManager(typeof(OpenGoogle));
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.WebBase.Controls.WebPage Google = new OpenSpan.Adapters.Web.WebBase.Controls.WebPage();
		this.SetId(Google, new OpenSpan.Design.ComponentIdentity("WebPage-8D97C65AB205C80"));
		OpenSpan.Adapters.Web.WebBase.Controls.Form @__A8SBwfpositionrelativemargin0_aut;
		@__A8SBwfpositionrelativemargin0_aut = new OpenSpan.Adapters.Web.WebBase.Controls.Form();
		// 
		// __A8SBwfpositionrelativemargin0_aut
		// 
		OpenSpan.Adapters.Web.WebBase.Controls.TextBox SearchBox;
		SearchBox = new OpenSpan.Adapters.Web.WebBase.Controls.TextBox();
		// 
		// SearchBox
		// 
		SearchBox.ElementId = null;
		SearchBox.Extender = null;
		SearchBox.ExtensibleTypeName = null;
		SearchBox.ForwardObjectExplorerEvent = true;
		SearchBox.MatchingIndex = 0;
		OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule virtualPropertyMatchRule4;
		virtualPropertyMatchRule4 = new OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule();
		// 
		// virtualPropertyMatchRule4
		// 
		virtualPropertyMatchRule4.PropertyName = "type";
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "text";
		virtualPropertyMatchRule4.Text = textmatchdata1;
		SearchBox.MatchRules.Add(virtualPropertyMatchRule4);
		SearchBox.Name = "SearchBox";
		SearchBox.PegaId = 0;
		SearchBox.TagName = "INPUT";
		SearchBox.TargetTypeString = _resources_.GetString("_OpenGoogle_2_");
		SearchBox.UseElementId = false;
		@__A8SBwfpositionrelativemargin0_aut.Controls.Add(SearchBox);
		@__A8SBwfpositionrelativemargin0_aut.ElementId = null;
		@__A8SBwfpositionrelativemargin0_aut.Extender = null;
		@__A8SBwfpositionrelativemargin0_aut.ExtensibleTypeName = null;
		@__A8SBwfpositionrelativemargin0_aut.ForwardObjectExplorerEvent = true;
		@__A8SBwfpositionrelativemargin0_aut.MatchingIndex = 0;
		OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule virtualPropertyMatchRule3;
		virtualPropertyMatchRule3 = new OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule();
		// 
		// virtualPropertyMatchRule3
		// 
		virtualPropertyMatchRule3.PropertyName = "action";
		OpenSpan.Adapters.TextMatchData textmatchdata2 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata2.Text = "https://www.google.com/search";
		virtualPropertyMatchRule3.Text = textmatchdata2;
		@__A8SBwfpositionrelativemargin0_aut.MatchRules.Add(virtualPropertyMatchRule3);
		@__A8SBwfpositionrelativemargin0_aut.Name = "__A8SBwfpositionrelativemargin0_aut";
		@__A8SBwfpositionrelativemargin0_aut.PegaId = 0;
		@__A8SBwfpositionrelativemargin0_aut.TagName = "FORM";
		@__A8SBwfpositionrelativemargin0_aut.TargetTypeString = _resources_.GetString("_OpenGoogle_3_");
		@__A8SBwfpositionrelativemargin0_aut.UseElementId = false;
		Google.Controls.Add(@__A8SBwfpositionrelativemargin0_aut);
		Google.Extender = null;
		Google.ForwardObjectExplorerEvent = true;
		Google.IsGlobal = true;
		Google.MatchingIndex = 0;
		OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule virtualPropertyMatchRule1;
		virtualPropertyMatchRule1 = new OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule();
		// 
		// virtualPropertyMatchRule1
		// 
		virtualPropertyMatchRule1.PropertyName = "url";
		OpenSpan.Adapters.TextMatchData textmatchdata3 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata3.Text = "https://www.google.com/";
		virtualPropertyMatchRule1.Text = textmatchdata3;
		OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule virtualPropertyMatchRule2;
		virtualPropertyMatchRule2 = new OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule();
		// 
		// virtualPropertyMatchRule2
		// 
		virtualPropertyMatchRule2.PropertyName = "title";
		OpenSpan.Adapters.TextMatchData textmatchdata4 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata4.Text = "Google";
		virtualPropertyMatchRule2.Text = textmatchdata4;
		Google.MatchRules.Add(virtualPropertyMatchRule1);
		Google.MatchRules.Add(virtualPropertyMatchRule2);
		Google.Name = "Google";
		Google.PegaId = 0;
		Google.TargetTypeString = _resources_.GetString("_OpenGoogle_4_");
		// 
		// Set designComp Ids
		// 
		this.SetId(@__A8SBwfpositionrelativemargin0_aut, new OpenSpan.Design.ComponentIdentity("Form-8D97C65AB16C312"));
		this.SetId(SearchBox, new OpenSpan.Design.ComponentIdentity("TextBox-8D97C65AB05201F"));
		this.SetId(virtualPropertyMatchRule4, new OpenSpan.Design.ComponentIdentity("VirtualPropertyMatchRule-8D97C65AB7B3FEE"));
		this.SetId(virtualPropertyMatchRule3, new OpenSpan.Design.ComponentIdentity("VirtualPropertyMatchRule-8D97C65AB6997BE"));
		this.SetId(virtualPropertyMatchRule1, new OpenSpan.Design.ComponentIdentity("VirtualPropertyMatchRule-8D97C65AB486D05"));
		this.SetId(virtualPropertyMatchRule2, new OpenSpan.Design.ComponentIdentity("VirtualPropertyMatchRule-8D97C65AB4F9339"));
		// 
		// Add components
		// 
		components.Add(@__A8SBwfpositionrelativemargin0_aut);
		components.Add(SearchBox);
		components.Add(virtualPropertyMatchRule4);
		components.Add(virtualPropertyMatchRule3);
		components.Add(virtualPropertyMatchRule1);
		components.Add(virtualPropertyMatchRule2);
		// 
		// Result
		// 
		return Google;
	}
	
	internal OpenSpan.Adapters.Web.WebBase.Controls.Form Create___A8SBwfpositionrelativemargin0_aut(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		System.ComponentModel.ComponentResourceManager _resources_ = new System.ComponentModel.ComponentResourceManager(typeof(OpenGoogle));
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.WebBase.Controls.Form @__A8SBwfpositionrelativemargin0_aut = new OpenSpan.Adapters.Web.WebBase.Controls.Form();
		this.SetId(@__A8SBwfpositionrelativemargin0_aut, new OpenSpan.Design.ComponentIdentity("Form-8D97C65AB16C312"));
		OpenSpan.Adapters.Web.WebBase.Controls.TextBox SearchBox;
		SearchBox = new OpenSpan.Adapters.Web.WebBase.Controls.TextBox();
		// 
		// SearchBox
		// 
		SearchBox.ElementId = null;
		SearchBox.Extender = null;
		SearchBox.ExtensibleTypeName = null;
		SearchBox.ForwardObjectExplorerEvent = true;
		SearchBox.MatchingIndex = 0;
		OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule virtualPropertyMatchRule4;
		virtualPropertyMatchRule4 = new OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule();
		// 
		// virtualPropertyMatchRule4
		// 
		virtualPropertyMatchRule4.PropertyName = "type";
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "text";
		virtualPropertyMatchRule4.Text = textmatchdata1;
		SearchBox.MatchRules.Add(virtualPropertyMatchRule4);
		SearchBox.Name = "SearchBox";
		SearchBox.PegaId = 0;
		SearchBox.TagName = "INPUT";
		SearchBox.TargetTypeString = _resources_.GetString("_OpenGoogle_2_");
		SearchBox.UseElementId = false;
		@__A8SBwfpositionrelativemargin0_aut.Controls.Add(SearchBox);
		@__A8SBwfpositionrelativemargin0_aut.ElementId = null;
		@__A8SBwfpositionrelativemargin0_aut.Extender = null;
		@__A8SBwfpositionrelativemargin0_aut.ExtensibleTypeName = null;
		@__A8SBwfpositionrelativemargin0_aut.ForwardObjectExplorerEvent = true;
		@__A8SBwfpositionrelativemargin0_aut.MatchingIndex = 0;
		OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule virtualPropertyMatchRule3;
		virtualPropertyMatchRule3 = new OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule();
		// 
		// virtualPropertyMatchRule3
		// 
		virtualPropertyMatchRule3.PropertyName = "action";
		OpenSpan.Adapters.TextMatchData textmatchdata2 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata2.Text = "https://www.google.com/search";
		virtualPropertyMatchRule3.Text = textmatchdata2;
		@__A8SBwfpositionrelativemargin0_aut.MatchRules.Add(virtualPropertyMatchRule3);
		@__A8SBwfpositionrelativemargin0_aut.Name = "__A8SBwfpositionrelativemargin0_aut";
		@__A8SBwfpositionrelativemargin0_aut.PegaId = 0;
		@__A8SBwfpositionrelativemargin0_aut.TagName = "FORM";
		@__A8SBwfpositionrelativemargin0_aut.TargetTypeString = _resources_.GetString("_OpenGoogle_3_");
		@__A8SBwfpositionrelativemargin0_aut.UseElementId = false;
		// 
		// Set designComp Ids
		// 
		this.SetId(SearchBox, new OpenSpan.Design.ComponentIdentity("TextBox-8D97C65AB05201F"));
		this.SetId(virtualPropertyMatchRule4, new OpenSpan.Design.ComponentIdentity("VirtualPropertyMatchRule-8D97C65AB7B3FEE"));
		this.SetId(virtualPropertyMatchRule3, new OpenSpan.Design.ComponentIdentity("VirtualPropertyMatchRule-8D97C65AB6997BE"));
		// 
		// Add components
		// 
		components.Add(SearchBox);
		components.Add(virtualPropertyMatchRule4);
		components.Add(virtualPropertyMatchRule3);
		// 
		// Result
		// 
		return @__A8SBwfpositionrelativemargin0_aut;
	}
	
	internal OpenSpan.Adapters.Web.WebBase.Controls.TextBox Create_SearchBox(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		System.ComponentModel.ComponentResourceManager _resources_ = new System.ComponentModel.ComponentResourceManager(typeof(OpenGoogle));
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.WebBase.Controls.TextBox SearchBox = new OpenSpan.Adapters.Web.WebBase.Controls.TextBox();
		this.SetId(SearchBox, new OpenSpan.Design.ComponentIdentity("TextBox-8D97C65AB05201F"));
		SearchBox.ElementId = null;
		SearchBox.Extender = null;
		SearchBox.ExtensibleTypeName = null;
		SearchBox.ForwardObjectExplorerEvent = true;
		SearchBox.MatchingIndex = 0;
		OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule virtualPropertyMatchRule4;
		virtualPropertyMatchRule4 = new OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule();
		// 
		// virtualPropertyMatchRule4
		// 
		virtualPropertyMatchRule4.PropertyName = "type";
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "text";
		virtualPropertyMatchRule4.Text = textmatchdata1;
		SearchBox.MatchRules.Add(virtualPropertyMatchRule4);
		SearchBox.Name = "SearchBox";
		SearchBox.PegaId = 0;
		SearchBox.TagName = "INPUT";
		SearchBox.TargetTypeString = _resources_.GetString("_OpenGoogle_2_");
		SearchBox.UseElementId = false;
		// 
		// Set designComp Ids
		// 
		this.SetId(virtualPropertyMatchRule4, new OpenSpan.Design.ComponentIdentity("VirtualPropertyMatchRule-8D97C65AB7B3FEE"));
		// 
		// Add components
		// 
		components.Add(virtualPropertyMatchRule4);
		// 
		// Result
		// 
		return SearchBox;
	}
	
	internal OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule Create_virtualPropertyMatchRule4(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule virtualPropertyMatchRule4 = new OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule();
		this.SetId(virtualPropertyMatchRule4, new OpenSpan.Design.ComponentIdentity("VirtualPropertyMatchRule-8D97C65AB7B3FEE"));
		virtualPropertyMatchRule4.PropertyName = "type";
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "text";
		virtualPropertyMatchRule4.Text = textmatchdata1;
		// 
		// Result
		// 
		return virtualPropertyMatchRule4;
	}
	
	internal OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule Create_virtualPropertyMatchRule3(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule virtualPropertyMatchRule3 = new OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule();
		this.SetId(virtualPropertyMatchRule3, new OpenSpan.Design.ComponentIdentity("VirtualPropertyMatchRule-8D97C65AB6997BE"));
		virtualPropertyMatchRule3.PropertyName = "action";
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "https://www.google.com/search";
		virtualPropertyMatchRule3.Text = textmatchdata1;
		// 
		// Result
		// 
		return virtualPropertyMatchRule3;
	}
	
	internal OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule Create_virtualPropertyMatchRule1(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule virtualPropertyMatchRule1 = new OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule();
		this.SetId(virtualPropertyMatchRule1, new OpenSpan.Design.ComponentIdentity("VirtualPropertyMatchRule-8D97C65AB486D05"));
		virtualPropertyMatchRule1.PropertyName = "url";
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "https://www.google.com/";
		virtualPropertyMatchRule1.Text = textmatchdata1;
		// 
		// Result
		// 
		return virtualPropertyMatchRule1;
	}
	
	internal OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule Create_virtualPropertyMatchRule2(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule virtualPropertyMatchRule2 = new OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule();
		this.SetId(virtualPropertyMatchRule2, new OpenSpan.Design.ComponentIdentity("VirtualPropertyMatchRule-8D97C65AB4F9339"));
		virtualPropertyMatchRule2.PropertyName = "title";
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "Google";
		virtualPropertyMatchRule2.Text = textmatchdata1;
		// 
		// Result
		// 
		return virtualPropertyMatchRule2;
	}
}

}

