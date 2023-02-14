using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_WebAPI_JWT_1.Identity
{
  public class ApplicationRoleStore: RoleStore<ApplicationRole, ApplicationDbContext>
  {
    public ApplicationRoleStore(ApplicationDbContext context, IdentityErrorDescriber errorDescriber) : base(context, errorDescriber)
    {

    }
  }
}
