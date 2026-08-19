using Portfolio.Models;
using Portfolio.ViewModels;
using static Microsoft.Extensions.Logging.EventSource.LoggingEventSource;

namespace Portfolio.Extensions.Mapping
{
    public static class MasterTitlesMappingExtension
    {
        public static MasterTitles ToModel(this MasterTitleViewModel model)
        {
            return new MasterTitles
            {

                Id = model.Id,
                IsActive = model.IsActive,
                Keyword = model.Keyword,
                Title = model.Title,
            };


        }


        public static MasterTitleViewModel ToViewModel(this MasterTitles model)
        {
            return new MasterTitleViewModel
            {
                Id = model.Id,
                IsActive = model.IsActive,
                Keyword = model.Keyword,
                Title = model.Title,
            };

        }
        public static List<MasterTitleViewModel> ToViewModelList(this List<MasterTitles> model)
        {
            return model.Select(x => x.ToViewModel()).ToList();

        }

        public static List<MasterTitles> ToModelList(this List<MasterTitleViewModel> model)
        {

            return model.Select(x => x.ToModel()).ToList();
        }


    }
}
