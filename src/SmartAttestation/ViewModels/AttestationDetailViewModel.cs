using SmartAttestation.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartAttestation.ViewModels
{
    public class AttestationDetailViewModel : BaseViewModel
    {
        public Attestation Attestation { get; set; }

        public AttestationDetailViewModel(Attestation attestation = null)
        {
            Title = attestation?.Reason.ToString()+":"+ attestation?.Date+"/"+attestation?.OutTime ;
            Attestation = attestation;
        }
    }
}
