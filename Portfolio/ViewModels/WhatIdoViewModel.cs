namespace Portfolio.ViewModels
{
    public class WhatIdoViewModel
    {
        public int Id { get; set; }
        public string IconURL { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public bool IsActive { get; set; }
        public IFormFile? IconFile { get; set; }
    }
}
