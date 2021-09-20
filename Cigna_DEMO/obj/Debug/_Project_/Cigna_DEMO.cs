using Cigna_DEMO_OpenGoogle = Cigna_DEMO.OpenGoogle;

using Cigna_DEMO_Google = Cigna_DEMO.Google;

using System;

namespace Cigna_DEMO.Project
{
// Project-8D97C645CB000AD
/// <summary>
/// OpenSpan project.
/// </summary>
[OpenSpan.Design.TargetEnvironmentAttribute(OpenSpan.Design.TargetEnvironment.Driver)]
[OpenSpan.Design.ComponentIdentityAttribute("Project-8D97C645CB000AD")]
[OpenSpan.Design.DeploymentVersionAttribute("1.0")]
[OpenSpan.Design.ProjectDescriptorAttribute(OpenSpan.Design.ProjectDescriptorType.Present)]
[OpenSpan.Design.ProjectDescriptorAttribute(OpenSpan.Design.ProjectDescriptorType.ContainsAdapters)]
public sealed class Cigna_DEMO : OpenSpan.Runtime.RuntimeProject
{
	
	public Cigna_DEMO() : 
			base()
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.Cigna_DEMO_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	public Cigna_DEMO(System.ComponentModel.ISynchronizeInvoke syncObject) : 
			base(syncObject)
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.Cigna_DEMO_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	public Cigna_DEMO(System.IServiceProvider serviceProvider) : 
			base(serviceProvider)
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.Cigna_DEMO_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	public Cigna_DEMO(bool initializeScout) : 
			base(initializeScout)
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.Cigna_DEMO_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	private Cigna_DEMO(System.IServiceProvider serviceProvider, OpenSpan.Runtime.RuntimeHostCommandLineHelper commandLineHelper, OpenSpan.Deployment.DeploymentManifest deploymentManifest) : 
			base(serviceProvider, commandLineHelper, deploymentManifest)
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.Cigna_DEMO_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	private void Cigna_DEMO_Initialize()
	{
		this.mId = new OpenSpan.Design.ComponentIdentity("Project-8D97C645CB000AD");
		this.mVersion = new System.Version("19.1.90.0");
		this.mDeploymentVersion = "1.0";
		this.mTransformationVersion = new System.Version("19.1.0.28");
		this.mTargetEnvironment = OpenSpan.Design.TargetEnvironment.Driver;
	}
	
	// UniversalWebAdapter-8D97C64A810BB90
	public Cigna_DEMO_OpenGoogle OpenGoogle
	{
		get
		{
			return ((Cigna_DEMO_OpenGoogle)(this["OpenGoogle"]));
		}
	}
	
	// Automator-8D97C649C613D5B
	public Cigna_DEMO_Google Google
	{
		get
		{
			return ((Cigna_DEMO_Google)(this["Google"]));
		}
	}
}

}

