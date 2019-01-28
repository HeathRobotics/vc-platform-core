using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using VirtoCommerce.OrdersModule.Core;
using VirtoCommerce.OrdersModule.Core.Model;
using VirtoCommerce.Platform.Core.Common;
using VirtoCommerce.Platform.Core.Security;

namespace VirtoCommerce.OrdersModule.Web.Security
{
    public class OrderStoreRequirement : PermissionScopeRequirement
    {
        public const string PolicyName = "OrderStore";

        private static readonly string[] _availablePermissions = new string[]
        {
            ModuleConstants.Security.Permissions.Read,
            ModuleConstants.Security.Permissions.Update,
        };

        public override IEnumerable<string> GetAvailablePermissions()
        {
            return _availablePermissions;
        }

        public override Dictionary<Type, Func<object, string>> GetSupportedEntityProviders()
        {
            return new Dictionary<Type, Func<object, string>>()
            {
                { typeof(CustomerOrder), x => (x as CustomerOrder)?.StoreId },
            };
        }
    }

    public class OrderStoreAuthorizationHandler : ConditionalAuthorizationHandler<OrderStoreRequirement, CustomerOrder>
    {
        public OrderStoreAuthorizationHandler(UserManager<ApplicationUser> userManager) : base(userManager)
        { }

        protected override bool EvaluateCondition(ApplicationUser user, PermissionScopeRequirement scope, CustomerOrder resource) => scope.Scope?.EqualsInvariant(resource?.StoreId) ?? false;
    }
}