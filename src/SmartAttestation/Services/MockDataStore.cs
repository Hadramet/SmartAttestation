using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartAttestation.Models;

namespace SmartAttestation.Services
{
    public class MockAttestationDataStore : IAttestationStore<Attestation>
    {
        readonly List<Attestation> attestations;

        public MockAttestationDataStore()
        {
            attestations = new List<Attestation>()
            {
                new Attestation 
                { 
                    Id = Guid.NewGuid().ToString(),
                    FirstName = "Hadramet",
                    LastName = "Sylla",
                    Address = "24 Square des Hautes Chalais",
                    BirthDay = "14/02/1996",
                    PlaceOfBirth = "Conakry",
                    City = "Rennes",
                    ZipCode = "35200",
                    OutTime = "16:20",
                    Reason = OutReason.travail, 
                    Date = "03/11/2020"
                }
            };
        }
        public async Task<bool> AddAttestationAsync(Attestation attestation)
        {
            attestations.Add(attestation);
            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteAttestationAsync(string id)
        {
            var oldAttestation = attestations.Where((Attestation arg) => arg.Id == id).FirstOrDefault();
            attestations.Remove(oldAttestation);

            return await Task.FromResult(true);
        }

        public async Task<Attestation> GetAttestationAsync(string id)
        {
            return await Task.FromResult(attestations.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Attestation>> GetAttestationAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(attestations);
        }

        public async Task<bool> UpdateAttestationAsync(Attestation attestation)
        {
            var oldAttestation = attestations.Where((Attestation arg) => arg.Id == attestation.Id).FirstOrDefault();
            attestations.Remove(oldAttestation);
            attestations.Add(attestation);

            return await Task.FromResult(true);
        }
    };
    public class MockDataStore : IDataStore<Item>
    {
        readonly List<Item> items;

        public MockDataStore()
        {
            items = new List<Item>()
            {
                new Item { Id = Guid.NewGuid().ToString(), Text = "First item", Description="This is an item description." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Second item", Description="This is an item description." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Third item", Description="This is an item description." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Fourth item", Description="This is an item description." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Fifth item", Description="This is an item description." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Sixth item", Description="This is an item description." }
            };


        }

        public async Task<bool> AddItemAsync(Item item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            var oldItem = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}