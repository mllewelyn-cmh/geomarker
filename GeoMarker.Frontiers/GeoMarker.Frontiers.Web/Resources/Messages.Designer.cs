﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GeoMarker.Frontiers.Web.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Messages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Messages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("GeoMarker.Frontiers.Web.Resources.Messages", typeof(Messages).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Authorization on the request is missing one or more of the required scopes: {0}.
        /// </summary>
        public static string AuthController_InvalidScope {
            get {
                return ResourceManager.GetString("AuthController.InvalidScope", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The {0} service is currently unavailable. Please try again later. If the issue persists please contact support..
        /// </summary>
        public static string GatewayController_ServiceUnavailable {
            get {
                return ResourceManager.GetString("GatewayController.ServiceUnavailable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error has occurred while attempting to GeoCode: {0}.
        /// </summary>
        public static string GeoCode_Error {
            get {
                return ResourceManager.GetString("GeoCode.Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Successfully started the GetGeocode job..
        /// </summary>
        public static string GeoCode_StartSuccess {
            get {
                return ResourceManager.GetString("GeoCode.StartSuccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error has occured with operation {0}, Message: {1}.
        /// </summary>
        public static string HomeController_Error {
            get {
                return ResourceManager.GetString("HomeController.Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File is required..
        /// </summary>
        public static string HomeController_FileRequired {
            get {
                return ResourceManager.GetString("HomeController.FileRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An unknown error has occurred while processing your request..
        /// </summary>
        public static string HomeController_GeneralError {
            get {
                return ResourceManager.GetString("HomeController.GeneralError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No request was found for GUID: {0}.
        /// </summary>
        public static string HomeController_NoRequest {
            get {
                return ResourceManager.GetString("HomeController.NoRequest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No result was found for GUID: {0}.
        /// </summary>
        public static string HomeController_NoResult {
            get {
                return ResourceManager.GetString("HomeController.NoResult", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The selected operation is not supported..
        /// </summary>
        public static string HomeController_NotSupported {
            get {
                return ResourceManager.GetString("HomeController.NotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error has occurred validating the request. Message: {0}.
        /// </summary>
        public static string HomeController_ServerValidationFailure {
            get {
                return ResourceManager.GetString("HomeController.ServerValidationFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The operation has successfully started..
        /// </summary>
        public static string HomeController_StartSuccess {
            get {
                return ResourceManager.GetString("HomeController.StartSuccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error has occurned while fetching user requests..
        /// </summary>
        public static string HomeController_UserRequestError {
            get {
                return ResourceManager.GetString("HomeController.UserRequestError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The operation you have selected is not currently supported..
        /// </summary>
        public static string NotSupported {
            get {
                return ResourceManager.GetString("NotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Refreshed.
        /// </summary>
        public static string Refreshed {
            get {
                return ResourceManager.GetString("Refreshed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error has occurred while attempting to de-serialize session data..
        /// </summary>
        public static string Session_SerializationError {
            get {
                return ResourceManager.GetString("Session.SerializationError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please refresh and contact support if this issue persists..
        /// </summary>
        public static string UiController_LoadFailureMessage {
            get {
                return ResourceManager.GetString("UiController.LoadFailureMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please select one or more request types..
        /// </summary>
        public static string UiController_NoTypeSelected {
            get {
                return ResourceManager.GetString("UiController.NoTypeSelected", resourceCulture);
            }
        }
    }
}
