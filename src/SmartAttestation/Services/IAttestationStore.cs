using SmartAttestation.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SmartAttestation.Services
{
    public interface IAttestationStore<T>
    {
        Task<bool> AddAttestationAsync(T item);
        Task<T> GetAttestationAsync(string id);
        Task<bool> UpdateAttestationAsync(T item);
        Task<bool> DeleteAttestationAsync(string id);
        Task<IEnumerable<T>> GetAttestationAsync(bool forceRefresh = false);
    }
}
