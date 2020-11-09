using SmartAttestation.Models;
using SmartAttestation.Services;
using SmartAttestation.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SmartAttestation.ViewModels
{
    public class AttestationsViewModel : BaseViewModel
    {
        public ObservableCollection<Attestation> Attestations { get; set; }
        public Command LoadAttestationsCommand { get; set; }
        public AttestationsViewModel()
        {
            Title = "CreateAttestation";
            Attestations = new ObservableCollection<Attestation>();

            // Commands
            LoadAttestationsCommand = new Command(async () => await ExecuteLoadIAttestationsCommand());

            MessagingCenter.Subscribe<NewAttestationPage, Attestation>(this, "AddAttestation", async (obj, attestation) =>
            {
                var newAttestation = attestation as Attestation;
                Attestations.Add(newAttestation);
                await AttestationDataStore.AddAttestationAsync(newAttestation);
            });

            MessagingCenter.Subscribe<AttestationPage, Attestation>(this, "RemoveAttestation", async (obj, attestation) =>
             {
                 var oldAttestation = attestation as Attestation;
                 Attestations.Remove(oldAttestation);
                 await AttestationDataStore.DeleteAttestationAsync(oldAttestation.Id);
                 await ExecuteLoadIAttestationsCommand();
             });
        }

        private async Task ExecuteLoadIAttestationsCommand()
        {
            IsBusy = true;

            try
            {
                Attestations.Clear();
                var attestations = await AttestationDataStore.GetAttestationAsync(true);
                foreach (var attestation in attestations)
                {
                    Attestations.Add(attestation);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
        //


    }
}
