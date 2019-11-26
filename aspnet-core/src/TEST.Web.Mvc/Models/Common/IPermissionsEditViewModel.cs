using System.Collections.Generic;
using TEST.Roles.Dto;

namespace TEST.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}