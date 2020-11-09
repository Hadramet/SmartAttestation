using SmartAttestation.Models;
using System;
using System.Linq;
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
                Id = Guid.NewGuid().ToString(),
                FirstName = "Hadramet",
                LastName = "Sylla",
                BirthDay = "14/02/1996",
                PlaceOfBirth = "Conakry",
                Address = "24 Square des hautes Chalais",
                Date = DateTime.Now.ToString("dd/MM/yyyy"),
                OutTime = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString(),
                City ="Rennes",
                ZipCode ="35200",
                
            };

            BindingContext = this;
        }

        async void Save_Clicked(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync(            
                "Out Time", "At what time will you be out?",
                "OK",
                "Cancel",
                Attestation.OutTime,-1,null,Attestation.OutTime);

            Attestation.OutTime = (string.IsNullOrEmpty(result)) ? result : Attestation.OutTime ;

            string action = await DisplayActionSheet("Reason: Travail?","","",
                Enum.GetNames(typeof(OutReason)));
            Attestation.Reason = (OutReason)Enum.Parse(typeof(OutReason),action);

            MessagingCenter.Send(this, "AddAttestation", Attestation);
            await Navigation.PopModalAsync();
        }

        async void Cancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}