using System;
using System.Collections.Generic;
using System.Text;

namespace SmartAttestation.Models
{
    public class Attestation
    {
        public String Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String BirthDay { get; set; }
        public String PlaceOfBirth { get; set; }
        public String Address { get; set; }
        public String ZipCode { get; set; }
        public String City { get; set; }
        public String Date { get; set; }
        public OutReason Reason { get; set; }
        public String OutTime { get; set; }
    };

    public enum OutReason
    {
        travail,
        achats,
        enfants,
        sport_animaux,
        sante,
        famille,
        handicap,
        convocation,
        missions
    }
}
