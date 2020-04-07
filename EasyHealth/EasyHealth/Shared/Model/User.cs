namespace EasyHealth.Shared.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.Security.Cryptography;
    using System.Text;

    public class User
    {
        public int Id { get; set; }
        [MaxLength(20)]
        [Required(ErrorMessage = "O campo \"Login\" é obrigatório!")]
        public string Login { get; set; }
        [MaxLength(20)]
        [Required(ErrorMessage = "O campo \"Senha\" é obrigatório!")]
        public string Password { get; private set; }
        
        public void SetPassword()
        {
            StringBuilder keyPassword = new StringBuilder();            
            MD5 md5 = MD5.Create();
            byte[] input = Encoding.ASCII.GetBytes("//" + this.Password);
            byte[] hash = md5.ComputeHash(input);
            
            for (int i = 0; i < hash.Length; i++)
            {
                keyPassword.Append(hash[i].ToString("X2"));
            }

            this.Password = keyPassword.ToString();
        }

    }
}
