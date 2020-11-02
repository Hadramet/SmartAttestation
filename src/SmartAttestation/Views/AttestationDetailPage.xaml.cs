using SmartAttestation.Models;
using SmartAttestation.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            var attestation = new Attestation
            {
                Id = "Id1"
            };

            viewModel = new AttestationDetailViewModel(attestation);
            BindingContext = viewModel;
        }

        private void DeleteAttestation_Clicked(object sender, EventArgs e)
        {
            new NotImplementedException();
        }
    }
}