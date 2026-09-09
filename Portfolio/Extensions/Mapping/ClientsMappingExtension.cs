using Portfolio.Models;
using Portfolio.ViewModels;
namespace Portfolio.Extensions.Mapping
{
    public static class ClientsMappingExtension

    {

        public static Clients ToModel(this ClientsViewModel model)
        {
            return new Clients
            {

                Id = model.Id,
                IsActive = model.IsActive,
                ImageURL = model.ImageURL,
                altText = model.altText,
                TitleText = model.TitleText,
                Link = model.Link
         
            }; 


        }


        public static ClientsViewModel ToViewModel(this Clients model)
        {
            return new ClientsViewModel
            {

                Id = model.Id,
                IsActive = model.IsActive,
                ImageURL = model.ImageURL,
                altText = model.altText,
                TitleText = model.TitleText,
                Link = model.Link
            };

        }
        public static List<ClientsViewModel> ToViewModelList(this List<Clients> model)
        {
            return model.Select(x => x.ToViewModel()).ToList();

        }

        public static List<Clients> ToModelList(this List<ClientsViewModel> model)
        {

            return model.Select(x => x.ToModel()).ToList();
        }
    }
}
