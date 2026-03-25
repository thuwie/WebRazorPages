using System.ComponentModel.DataAnnotations;

namespace WebRazorPages.Validation
{
    public class CustomBirthDate : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                DateTime birthDate = (DateTime)value;

                // Logic: Ngày sinh phải nhỏ hơn hoặc bằng ngày hiện tại
                if (birthDate > DateTime.Now)
                {
                    // Trả về lỗi nếu ngày sinh ở tương lai
                    return new ValidationResult(ErrorMessage ?? "Ngày sinh không được lớn hơn ngày hiện tại");
                }
            }

            // Trả về Success nếu mọi thứ hợp lệ
            return ValidationResult.Success;
        }
    }
}
