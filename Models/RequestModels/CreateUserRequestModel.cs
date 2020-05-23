namespace DemoWebApp.Models.RequestModels 
{
    public class CreateUserRequestModel
    {
        public string Email {get;set;}
        public string Password {get; set;}
        public string ConfirmPassword {get; set;}
    }
}