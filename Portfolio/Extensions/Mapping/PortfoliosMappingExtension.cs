using Portfolio.Models;
using Portfolio.ViewModels;

namespace Portfolio.Extensions.Mapping
{
    public static class PortfoliosMappingExtension

    {

        public static Portfolios ToModel(this PortfoliosViewModel model)
        {
            return new Portfolios
            {

                Id = model.Id,
                IsActive = model.IsActive,
                ThumbnailImage = model.ThumbnailImage,
                FullImage = model.FullImage,
                Title = model.Title,
                CategoriesId = model.CategoriesId
            };


        }


        public static PortfoliosViewModel ToViewModel(this Portfolios model)
        {
            return new PortfoliosViewModel
            {
                Id = model.Id,
                IsActive = model.IsActive,
                ThumbnailImage = model.ThumbnailImage,
                FullImage = model.FullImage,
                Title = model.Title,
                CategoriesId = model.CategoriesId
            };

        }
        public static List<PortfoliosViewModel> ToViewModelList(this List<Portfolios> model)
        {
            return model.Select(x => x.ToViewModel()).ToList();

        }

        public static List<Portfolios> ToModelList(this List<PortfoliosViewModel> model)
        {

            return model.Select(x => x.ToModel()).ToList();
        }
    }
}
