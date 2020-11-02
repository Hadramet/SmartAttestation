using SmartAttestation.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmartAttestation.Services
{
    public interface IDataStore<T>
    {
        Task<bool> AddItemAsync(T item);
        Task<bool> UpdateItemAsync(T item);
        Task<bool> DeleteItemAsync(string id);
        Task<T> GetItemAsync(string id);
        Task<IEnumerable<T>> GetItemsAsync(bool forceRefresh = false);
        //Task AddAttestationAsync(Attestation newAttestation);
    }

    //http://192.168.67.97:8080/generate.html#f=firstname&l=lastname&b=01%2F01%2F2020&p=Rennes&a=24%20square%20hautes%20chalais&c=Rennes&z=35200&r=travail
}
