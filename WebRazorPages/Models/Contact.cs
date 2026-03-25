using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using WebRazorPages.Validation;

namespace WebRazorPages.Models
{
    public class Contact
    {
        [BindProperty]
        [DisplayName("Id cua ban")]
        [Range(1,100,ErrorMessage ="Nhap sai")]
        public int ContactId { get; set; }
        [BindProperty]
        public string FisrtName { get; set; }
        [BindProperty]
        public string LastName { get; set; }
        [BindProperty]

        [DataType(DataType.Date)]
        [CustomBirthDate(ErrorMessage = "Ngay sinh nho hon hoac bang ngay hien tai")]
        public DateTime DateOfBirth { get; set; }
        [BindProperty]
        [EmailAddress(ErrorMessage = "Ngay sinh nho hon hoac bang ngay hien tai")]
        public string Email { get; set; }
    }
}
