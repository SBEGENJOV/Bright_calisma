namespace coreAjaxProject.Models.viewModel
{
    public class LoginViewModel
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string ConfirmPassword { get; set; }
        public bool IsActive { get; set; }
        public bool IsRemember { get; set; }
    }
}
