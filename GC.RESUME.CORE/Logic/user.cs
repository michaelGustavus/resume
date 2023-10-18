using GC.RESUME.CORE.DAL.Entities;
using GC.RESUME.CORE.Extensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace GC.RESUME.CORE.Logic
{
    class user
    {
        public async Task<Contracts.user> FindAsync(Guid entityId)
        {


            ResumeContext context = new ResumeContext();


            var entity = await context.Users.FirstOrDefaultAsync(p => p.Id == entityId);



            if (entity == null)
                throw new Exception($@"Entity not found for the following ID: {entityId}");



            var contract = entity.ConvertTo<Contracts.user, DAL.Entities.User>();



            //If Null don't send to esb.
            if (contract == null)
                throw new Exception($@"Contract conversion failed for the following ID: {entityId}");




            return contract;



        }
    }
}
