using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace netFrameworkSecurityMain
{
    class CustomCodeAccessSecurity : CodeAccessPermission,IUnrestrictedPermission

    {
        public bool IsUnrestricted()
        {
            throw new NotImplementedException();
        }

        public override IPermission Copy()
        {
            throw new NotImplementedException();
        }

        public override void FromXml(SecurityElement elem)
        {
            throw new NotImplementedException();
        }

        public override IPermission Intersect(IPermission target)
        {
            throw new NotImplementedException();
        }

        public override bool IsSubsetOf(IPermission target)
        {
            throw new NotImplementedException();
        }

        public override SecurityElement ToXml()
        {
            throw new NotImplementedException();
        }
    }
}
