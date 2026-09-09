using Portfolio.Models;
using Portfolio.ViewModels;

namespace Portfolio.Extensions.Mapping
{
    public static class ContactFormMappingExtension

    {

        public static ContactForm ToModel(this ContactFormViewModel model)
        {
            return new ContactForm
            {

                Id = model.Id,
                IsActive = model.IsActive,
                Name = model.Name,
                Email = model.Email,
                subject = model.subject,
                Message = model.Message,
            };


        }


        public static ContactFormViewModel ToViewModel(this ContactForm model)
        {
            return new ContactFormViewModel
            {
                Id = model.Id,
                IsActive = model.IsActive,
                Name = model.Name,
                Email = model.Email,
                subject = model.subject,
                Message = model.Message,
            };

        }
        public static List<ContactFormViewModel> ToViewModelList(this List<ContactForm> model)
        {
            return model.Select(x => x.ToViewModel()).ToList();

        }

        public static List<ContactForm> ToModelList(this List<ContactFormViewModel> model)
        {

            return model.Select(x => x.ToModel()).ToList();
        }
    }
}
