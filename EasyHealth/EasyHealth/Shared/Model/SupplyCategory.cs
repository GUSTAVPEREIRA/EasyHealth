namespace EasyHealth.Shared.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class SupplyCategory
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo \"Nome\" é obrigatório!")]
        [MaxLength(150, ErrorMessage = "O campo \"Nome\" não pode ultrapassar 150 caracteres")]
        public string Name { get; set; }

        [MaxLength(150, ErrorMessage = "O campo \"Descrição\" não pode ultrapassar 500 caracteres")]
        [Required(ErrorMessage = "O campo \"Descrição\" é obrigatório!")]
        public string Description { get; set; }

        public List<HospitalSupply> HospitalSupplies { get; set; }
    }
}
