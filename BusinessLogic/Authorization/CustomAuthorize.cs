using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;



namespace BusinessLogic.Authorization {
    public class CustomAuthorize : AuthorizeAttribute {
        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext) {
            filterContext.Result = new RedirectResult("/Error/Unauthorized");
        }

        public override void OnAuthorization(AuthorizationContext filterContext) {
            if (this.AuthorizeCore(filterContext.HttpContext)) {    // Check if user is authenticated
                base.OnAuthorization(filterContext);
            }
            else {
                this.HandleUnauthorizedRequest(filterContext);
            }
        }

    }
}
