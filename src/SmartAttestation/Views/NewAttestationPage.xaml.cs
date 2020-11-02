using SmartAttestation.Models;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartAttestation.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewAttestationPage : ContentPage
    {
        public Attestation Attestation { get; set; }
        public NewAttestationPage()
        {
            InitializeComponent();
            Attestation = new Attestation
            {
                Id = "Attestation ID"
            };

            BindingContext = this;
        }

        async void Save_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "AddAttestation", Attestation);
            await Navigation.PopModalAsync();
        }

        async void Cancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}