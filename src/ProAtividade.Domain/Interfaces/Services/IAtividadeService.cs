using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProAtividade.Domain.Entities;

namespace ProAtividade.Domain.Interfaces.Services
{
    public interface IAtividadeService
    {
        Task<Atividade> AddAtividade(Atividade model);
        Task<Atividade> UpdateAtividade(Atividade model);
        Task<Boolean> DeleteAtividade(int atividadeId);
        Task<Boolean> CompleteAtividade(Atividade atividade);
        Task<Atividade[]> GetAllAtividadeAsync();
        Task<Atividade> GetAtividadeForIdAsync(int atividadeId);
    }
}