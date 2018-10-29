﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VirtoCommerce.SubscriptionModule.Data.Resources {
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
    public class SubscriptionResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SubscriptionResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("VirtoCommerce.SubscriptionModule.Data.Resources.SubscriptionResources", typeof(SubscriptionResources).Assembly);
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
        ///   Looks up a localized string similar to Balance changed from &apos;{0:0.00}&apos; to &apos;{1:0.00}&apos;.
        /// </summary>
        public static string BalanceChanged {
            get {
                return ResourceManager.GetString("BalanceChanged", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expiration date changed from &apos;{0}&apos; to &apos;{1}&apos;.
        /// </summary>
        public static string ExpirationDateChanged {
            get {
                return ResourceManager.GetString("ExpirationDateChanged", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Billing interval changed from &apos;{0}&apos; to &apos;{1}&apos;.
        /// </summary>
        public static string IntervalChanged {
            get {
                return ResourceManager.GetString("IntervalChanged", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Billing interval count changed from &apos;{0}&apos; to &apos;{1}&apos;.
        /// </summary>
        public static string IntervalCountChanged {
            get {
                return ResourceManager.GetString("IntervalCountChanged", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to New  recurring order &apos;{0}&apos; created.
        /// </summary>
        public static string NewRecurringOrderCreated {
            get {
                return ResourceManager.GetString("NewRecurringOrderCreated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Subscription {{subscription.number}} with amount {{subscription.customer_order_prototype.total |  round: 2}}{{subscription.customer_order_prototype.currency}} successfully created..
        /// </summary>
        public static string NewSubscriptionEmailNotificationBody {
            get {
                return ResourceManager.GetString("NewSubscriptionEmailNotificationBody", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You are successfully subscribed to new subscription &lt;strong&gt; {{ subscription.number }} &lt;/strong&gt;.
        /// </summary>
        public static string NewSubscriptionEmailNotificationSubject {
            get {
                return ResourceManager.GetString("NewSubscriptionEmailNotificationSubject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Next billing date changed from &apos;{0}&apos; to &apos;{1}&apos;.
        /// </summary>
        public static string NextBillingDateChanged {
            get {
                return ResourceManager.GetString("NextBillingDateChanged", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Outer Id changed from &apos;{0}&apos; to &apos;{1}&apos;.
        /// </summary>
        public static string OuterIdChanged {
            get {
                return ResourceManager.GetString("OuterIdChanged", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Status changed from &apos;{0}&apos; to &apos;{1}&apos;.
        /// </summary>
        public static string StatusChanged {
            get {
                return ResourceManager.GetString("StatusChanged", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Canceled at {0} with comment &apos;{1}&apos;.
        /// </summary>
        public static string SubscriptionCanceled {
            get {
                return ResourceManager.GetString("SubscriptionCanceled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {{subscription.cancel_reason}}.
        /// </summary>
        public static string SubscriptionCanceledEmailNotificationBody {
            get {
                return ResourceManager.GetString("SubscriptionCanceledEmailNotificationBody", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Subscription {{subscription.number}} was canceled..
        /// </summary>
        public static string SubscriptionCanceledEmailNotificationSubject {
            get {
                return ResourceManager.GetString("SubscriptionCanceledEmailNotificationSubject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Trial period changed from &apos;{0}&apos; to &apos;{1}&apos; day(s).
        /// </summary>
        public static string TrialPeriodChanged {
            get {
                return ResourceManager.GetString("TrialPeriodChanged", resourceCulture);
            }
        }
    }
}
