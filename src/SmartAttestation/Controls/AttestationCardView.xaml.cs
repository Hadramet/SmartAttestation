using SmartAttestation.Models;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartAttestation.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AttestationCardView : ContentView
    {
        public static readonly BindableProperty ReasonProperty = BindableProperty.Create(nameof(Reason), typeof(OutReason), typeof(AttestationCardView));
        public static readonly BindableProperty CreationDateProperty = BindableProperty.Create(nameof(CreationDate), typeof(String), typeof(AttestationCardView),string.Empty);
        public static readonly BindableProperty CreationTimeProperty = BindableProperty.Create(nameof(CreationTime), typeof(String), typeof(AttestationCardView),string.Empty);
        public static readonly BindableProperty ProfilOwnerProperty = BindableProperty.Create(nameof(ProfilOwner), typeof(String), typeof(AttestationCardView),string.Empty);
        public static readonly BindableProperty BorderColorProperty = BindableProperty.Create(nameof(BorderColor), typeof(Color), typeof(AttestationCardView), Color.DarkGray);
        public static readonly BindableProperty CardColorProperty = BindableProperty.Create(nameof(CardColor), typeof(Color), typeof(AttestationCardView), Color.White);
        

        public OutReason Reason
        {
            get => (OutReason)GetValue(AttestationCardView.ReasonProperty);
            set => SetValue(AttestationCardView.ReasonProperty, value);
        }

        public String CreationDate
        {
            get => (String)GetValue(AttestationCardView.CreationDateProperty);
            set => SetValue(AttestationCardView.CreationDateProperty, value);
        }

        public string CreationTime
        {
            get => (String)GetValue(AttestationCardView.CreationTimeProperty);
            set => SetValue(AttestationCardView.CreationTimeProperty, value);
        }

        public String ProfilOwner
        {
            get => (String)GetValue(AttestationCardView.ProfilOwnerProperty);
            set => SetValue(AttestationCardView.ProfilOwnerProperty, value);
        }

        public Color BorderColor
        {
            get => (Color)GetValue(AttestationCardView.BorderColorProperty);
            set => SetValue(AttestationCardView.BorderColorProperty, value);
        }

        public Color CardColor
        {
            get => (Color)GetValue(AttestationCardView.CardColorProperty);
            set => SetValue(AttestationCardView.CardColorProperty, value);
        }

        public AttestationCardView()
        {
            InitializeComponent();
        }

    }
}