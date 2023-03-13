using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProAtividade.Domain.Entities;

namespace ProAtividade.Domain.Interfaces.Repositories
{
    public interface IAtividadeRep
    {
        Task<Atividade[]> GetAllAsync();
        Task<Atividade> GetForIdAsync();
        Task<Atividade> GetForTitleAsync();
    }
}