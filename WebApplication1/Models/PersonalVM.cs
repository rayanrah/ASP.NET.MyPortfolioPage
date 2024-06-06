using System.ComponentModel.DataAnnotations;

namespace MY_PORTFOLIO.Models
{
    public class PersonalVM
    {
        [Display(Name = "ID")]
        public int ID { get; set; }

        [Display(Name = "NAME")]
        public string Name { get; set; }

        [Display(Name = "Surname")]
        public string SurName { get; set; }

        [Display(Name = "City")]
        public string City { get; set; }

        [Display(Name = "Country")]
        public string Country { get; set; }

    }

}
