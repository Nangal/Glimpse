﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Glimpse.Core2 {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Glimpse.Core2.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Initialize method has not been called in the context on the current Glimpse runtime instance. Calls to BeginRequest must be preceded by calls to Initialize..
        /// </summary>
        internal static string BeginRequestOutOfOrderRuntimeMethodCall {
            get {
                return ResourceManager.GetString("BeginRequestOutOfOrderRuntimeMethodCall", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Added {0} of type &apos;{1}&apos; to collection..
        /// </summary>
        internal static string DiscoverableCollectionAdd {
            get {
                return ResourceManager.GetString("DiscoverableCollectionAdd", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cleared {0} collection..
        /// </summary>
        internal static string DiscoverableCollectionClear {
            get {
                return ResourceManager.GetString("DiscoverableCollectionClear", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Discovered {0} of type &apos;{1}&apos; and added it to collection..
        /// </summary>
        internal static string DiscoverableCollectionDiscover {
            get {
                return ResourceManager.GetString("DiscoverableCollectionDiscover", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removed {0} of type &apos;{1}&apos; from collection..
        /// </summary>
        internal static string DiscoverableCollectionRemove {
            get {
                return ResourceManager.GetString("DiscoverableCollectionRemove", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Exception loading &apos;{0}&apos; of type &apos;{1}&apos;..
        /// </summary>
        internal static string DiscoverCreateInstance {
            get {
                return ResourceManager.GetString("DiscoverCreateInstance", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Exception loading assembly at path &apos;{0}&apos;..
        /// </summary>
        internal static string DiscoverLoadAssembly {
            get {
                return ResourceManager.GetString("DiscoverLoadAssembly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to BeginRequest method has not been called in the context of the current HTTP request. Calls to EndRequest must be preceded by calls to BeginRequest..
        /// </summary>
        internal static string EndRequestOutOfOrderRuntimeMethodCall {
            get {
                return ResourceManager.GetString("EndRequestOutOfOrderRuntimeMethodCall", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Exception executing policy of type &apos;{0}&apos;..
        /// </summary>
        internal static string ExecutePolicyWarning {
            get {
                return ResourceManager.GetString("ExecutePolicyWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ambiguous resource with name &apos;{0}&apos; found..
        /// </summary>
        internal static string ExecuteResourceDuplicateError {
            get {
                return ResourceManager.GetString("ExecuteResourceDuplicateError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Resource with name &apos;{0}&apos; could not be found..
        /// </summary>
        internal static string ExecuteResourceMissingError {
            get {
                return ResourceManager.GetString("ExecuteResourceMissingError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Exception executing tab of type &apos;{0}&apos;..
        /// </summary>
        internal static string ExecuteTabError {
            get {
                return ResourceManager.GetString("ExecuteTabError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Exception generating script tag for dynamic IClientScript of type &apos;{0}&apos;..
        /// </summary>
        internal static string GenerateScriptTagsDynamicException {
            get {
                return ResourceManager.GetString("GenerateScriptTagsDynamicException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Exception generating script tag for static IClientScript of type &apos;{0}&apos;..
        /// </summary>
        internal static string GenerateScriptTagsStaticException {
            get {
                return ResourceManager.GetString("GenerateScriptTagsStaticException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Exception generating uri with ResourceEndpointConfiguration of type &apos;{0}&apos;..
        /// </summary>
        internal static string GenerateUriExecutionError {
            get {
                return ResourceManager.GetString("GenerateUriExecutionError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Exception getting ParameterKeys for IResource of type &apos;{0}&apos;..
        /// </summary>
        internal static string GenerateUriParameterKeysWarning {
            get {
                return ResourceManager.GetString("GenerateUriParameterKeysWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Exception initializing pipeline inspector of type &apos;{0}&apos;..
        /// </summary>
        internal static string InitializePipelineInspectorError {
            get {
                return ResourceManager.GetString("InitializePipelineInspectorError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Exception initializing tab of type &apos;{0}&apos;..
        /// </summary>
        internal static string InitializeTabError {
            get {
                return ResourceManager.GetString("InitializeTabError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to instantiate Framework Provider from IServiceLocator: &apos;{0}&apos; or &apos;{1}&apos;..
        /// </summary>
        internal static string InstantiateFrameworkProviderException {
            get {
                return ResourceManager.GetString("InstantiateFrameworkProviderException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to instantiate Resource Endpoint Configuration from IServiceLocator: &apos;{0}&apos; or &apos;{1}&apos;..
        /// </summary>
        internal static string InstantiateResourceEndpointConfigurationException {
            get {
                return ResourceManager.GetString("InstantiateResourceEndpointConfigurationException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to render IClientScript: &apos;{0}&apos;. All IClientScript implementations should also implement either IStaticClientScript or IDynamicClientScript..
        /// </summary>
        internal static string RenderClientScriptImproperImplementationWarning {
            get {
                return ResourceManager.GetString("RenderClientScriptImproperImplementationWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to render IClientScript: &apos;{0}&apos;. No IResource with the Name &apos;{1}&apos; could be found..
        /// </summary>
        internal static string RenderClientScriptMissingResourceWarning {
            get {
                return ResourceManager.GetString("RenderClientScriptMissingResourceWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The input value &apos;{0}&apos; creates path &apos;{1}&apos;, which does not exist..
        /// </summary>
        internal static string SetDiscoveryLocationDirectoryNotFoundMessage {
            get {
                return ResourceManager.GetString("SetDiscoveryLocationDirectoryNotFoundMessage", resourceCulture);
            }
        }
    }
}
