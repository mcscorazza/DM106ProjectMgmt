using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace DM106ProjectMgmt.Shared.Data.Models
{
    // Classe para representar os usuários de acesso no sistema
    public class AccessUser : IdentityUser<int>
    {
    }
}
