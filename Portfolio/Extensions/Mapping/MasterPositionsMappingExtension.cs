using Portfolio.Models;
using Portfolio.ViewModels;

namespace Portfolio.Extensions.Mapping
{
    public static class MasterPositionsMappingExtension
    {
        public static MasterPositions ToModel(this MasterPositionsViewModel model)
        {
            return new MasterPositions
            {

                Id = model.Id,
                IsActive = model.IsActive,
                IsPrimary = model.IsPrimary,
                Name = model.Name,
            };


        }


        public static MasterPositionsViewModel ToViewModel(this MasterPositions model)
        {
            return new MasterPositionsViewModel
            {
                Id = model.Id,
                IsActive = model.IsActive,
                IsPrimary = model.IsPrimary,
                Name = model.Name,
            };

        }
        public static List<MasterPositionsViewModel> ToViewModelList(this List<MasterPositions> model)
        {
            return model.Select(x => x.ToViewModel()).ToList();

        }

        public static List<MasterPositions> ToModelList(this List<MasterPositionsViewModel> model)
        {

            return model.Select(x => x.ToModel()).ToList();
        }
    }
}
