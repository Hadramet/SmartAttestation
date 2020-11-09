using SmartAttestation.Models;
using SmartAttestation.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SmartAttestation.ViewModels
{
    public class AttestationDetailViewModel : BaseViewModel
    {
        public Attestation Attestation { get; set; }
        //public Command DeleteAttestationCommand { get; set; }
        public AttestationDetailViewModel(Attestation attestation = null)
        {
            Title = attestation?.Reason.ToString()+":"+ attestation?.Date+"/"+attestation?.OutTime ;
            Attestation = attestation;
            
        }

    }
}
