using SmartAttestation.Models;
using SmartAttestation.ViewModels;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartAttestation.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AttestationDetailPage : ContentPage
    {
        AttestationDetailViewModel viewModel;
        public AttestationDetailPage(AttestationDetailViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = this.viewModel = viewModel;
        }

        public AttestationDetailPage()
        {
            InitializeComponent();

            var attestation = new Attestation();

            viewModel = new AttestationDetailViewModel(attestation);
            BindingContext = viewModel;
        }

        
    }
}