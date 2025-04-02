using System.ComponentModel.DataAnnotations;

namespace AdmissionFormUsing_MVC.Models
{
    public class Admission
    {
        //[Required]
        //public string FullName {  get; set; }

        //[Required,EmailAddress]
        //public string Email { get; set; }

        //[Required,Phone]
        //public double MobileNumber { get; set; }

        //[Required]
        //public string Class {  get; set; }

        //[Required]
        //public string CourseName { get; set; }

        //[Required]
        //public string Address {  get; set; }

        //[Required]
        //public string PaymentMethod {  get; set; }



        public string FullName { get; set; }
        public string Email { get; set; }
        public string MobileNumber { get; set; }
        public string Class { get; set; }
        public string CourseName { get; set; }
        public string Address { get; set; }
        public string PaymentMethod { get; set; }

    }
}
