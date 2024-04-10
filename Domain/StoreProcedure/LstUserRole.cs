using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models.StoreProcedure
{
    public class LstUserRole
    {
        //		ALTER PROCEDURE[dbo].[LstUserRole]
        //		@id nvarchar(450)
        //AS
        //BEGIN


        //	SELECT 
        //	1 Checked, A.RoleId, B.Name 
        //	--A.*, B.*
        //	FROM AspNetUserRoles A
        //	INNER JOIN AspNetRoles B on A.RoleId = B.Id
        //	WHERE A.UserId = @Id

        //UNION
        //SELECT 
        //	0 Checked, A.Id, A.Name
        //	FROM (
        //	SELECT X.*, Y.RoleId NullIs FROM AspNetRoles X
        //	LEFT OUTER JOIN
        //	(SELECT A.RoleId FROM AspNetUserRoles A WHERE A.UserId = @Id) Y
        //	ON X.Id = Y.RoleId ) A
        //	WHERE A.NullIs is null

        //END

    }
}
