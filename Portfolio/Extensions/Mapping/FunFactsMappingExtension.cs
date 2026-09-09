using Portfolio.Models;
using Portfolio.ViewModels;

namespace Portfolio.Extensions.Mapping
{
    public static class FunFactsMappingExtension
    
        
    {

        public static FunFacts ToModel(this FunFactsViewModel model)
        {
            return new FunFacts
            {

                Id = model.Id,
                IsActive = model.IsActive,
                IconURL = model.IconURL,
                Title = model.Title,
                Count = model.Count,
            };


        }


        public static FunFactsViewModel ToViewModel(this FunFacts model)
        {
            return new FunFactsViewModel
            {
                Id = model.Id,
                IsActive = model.IsActive,
                IconURL = model.IconURL,
                Title = model.Title,
                Count = model.Count,
            };

        }
        public static List<FunFactsViewModel> ToViewModelList(this List<FunFacts> model)
        {
            return model.Select(x => x.ToViewModel()).ToList();

        }

        public static List<FunFacts> ToModelList(this List<FunFactsViewModel> model)
        {

            return model.Select(x => x.ToModel()).ToList();
        }
    
}
}
