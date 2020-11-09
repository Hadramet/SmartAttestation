using SmartAttestation.Models;
using SmartAttestation.ViewModels;
using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace SmartAttestation.Views
{
    [DesignTimeVisible(false)]
    public partial class AttestationPage : ContentPage
    {
        AttestationsViewModel viewModel;
        public AttestationPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new AttestationsViewModel();
        }

        async void OnAttestationSelected(object sender, EventArgs args)
        {
            var layout = (BindableObject)sender;
            var attestation = (Attestation)layout.BindingContext;
            await Navigation.PushAsync(new AttestationDetailPage(new AttestationDetailViewModel(attestation)));
        }

        async void AddAttestation_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new NewAttestationPage()));
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Attestations.Count == 0)
                viewModel.IsBusy = true;
        }

        void DeleteAttestion_Cliked(object sender, EventArgs e)
        {
            var layout = (BindableObject)sender;
            var attestation = (Attestation)layout.BindingContext;
            MessagingCenter.Send(this, "RemoveAttestation", attestation);
        }
    }
}