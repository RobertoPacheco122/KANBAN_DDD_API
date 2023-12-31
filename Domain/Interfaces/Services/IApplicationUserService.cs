﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services {
    public interface IApplicationUserService {
        Task<bool> Delete(int id);
        Task<List<ApplicationUserEntity>> GetAll();
        Task<ApplicationUserEntity> GetSingle(int id);
        Task<ApplicationUserEntity> Insert(ApplicationUserEntity aluno);
        Task<ApplicationUserEntity> Update(ApplicationUserEntity aluno);
    }
}
