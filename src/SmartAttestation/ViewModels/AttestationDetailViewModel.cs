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
            Title = attestation?.Id;
            Attestation = attestation;
        }
    }
}
