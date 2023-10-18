﻿using GC.RESUME.CORE.DAL.Entities;
using GC.RESUME.CORE.Extensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
namespace GC.RESUME.CORE.Logic
{
    class education
    {
        public async Task<Contracts.education> FindAsync(Guid entityId)
        {


            ResumeContext context = new ResumeContext();


            var entity = await context.Educations.FirstOrDefaultAsync(p => p.Id == entityId);



            if (entity == null)
                throw new Exception($@"Entity not found for the following ID: {entityId}");



            var contract = entity.ConvertTo<Contracts.education, DAL.Entities.Education>();



            //If Null don't send to esb.
            if (contract == null)
                throw new Exception($@"Contract conversion failed for the following ID: {entityId}");




            return contract;



        }
    }
}
