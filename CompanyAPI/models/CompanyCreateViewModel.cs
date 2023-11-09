﻿using System.ComponentModel.DataAnnotations;

namespace CompanyAPI.models
{
    public class CompanyCreateViewModel
    {
        [Required(ErrorMessage = "Name is required"), MaxLength(80, ErrorMessage = "Name can have a maximum of 80 characters")]
        public string Name { get; set; }

        [MaxLength(160, ErrorMessage = "Description can have a maximum of 160 characters")]
        public string Description { get; set; }

        [Required(ErrorMessage = "GroupId is required")]
        public long GroupId { get; set; }

        public string Image { get; set; }

        [Required(ErrorMessage = "Sector is required"), MaxLength(80, ErrorMessage = "Sector can have a maximum of 80 characters")]
        public string Sector { get; set; }
    }
}
