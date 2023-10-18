using GC.RESUME.CORE.DAL.Entities;
using GC.RESUME.CORE.Extensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace GC.RESUME.CORE.Logic
{
    class Profile
    {
        public async Task<Contracts.profile> FindAsync(Guid entityId)
        {


            ResumeContext context = new ResumeContext();


            var entity = await context.Profiles.FirstOrDefaultAsync(p => p.Id == entityId);



            if (entity == null)
                throw new Exception($@"Entity not found for the following ID: {entityId}");



            var contract = entity.ConvertTo<Contracts.profile, DAL.Entities.Profile>();



            //If Null don't send to esb.
            if (contract == null)
                throw new Exception($@"Contract conversion failed for the following ID: {entityId}");




            return contract;



        }
    }
}
