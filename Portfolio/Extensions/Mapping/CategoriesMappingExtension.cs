using Portfolio.Models;
using Portfolio.ViewModels;
namespace Portfolio.Extensions.Mapping
{
    public static class CategoriesMappingExtension
    {

        public static Categories ToModel(this CategoriesViewModel model)
        {
            return new Categories
            {

                Id = model.Id,
                IsActive = model.IsActive,
                CategoryName=model.CategoryName
            };


        }


        public static CategoriesViewModel ToViewModel(this Categories model)
        {
            return new CategoriesViewModel
            {
                Id = model.Id,
                IsActive = model.IsActive,
                CategoryName = model.CategoryName
            };

        }
        public static List<CategoriesViewModel> ToViewModelList(this List<Categories> model)
        {
            return model.Select(x => x.ToViewModel()).ToList();

        }

        public static List<Categories> ToModelList(this List<CategoriesViewModel> model)
        {

            return model.Select(x => x.ToModel()).ToList();
        }
    }
}
