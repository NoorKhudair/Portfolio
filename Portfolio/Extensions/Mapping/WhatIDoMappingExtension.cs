using Portfolio.Models;
using Portfolio.ViewModels;

namespace Portfolio.Extensions.Mapping
{
    public static class WhatIDoMappingExtension

    {

        public static WhatIDo ToModel(this WhatIdoViewModel model)
        {
            return new WhatIDo
            {

                Id = model.Id,
                IsActive = model.IsActive,
                IconURL = model.IconURL,
                Title = model.Title,
                Desc = model.Desc,

            };


        }


        public static WhatIdoViewModel ToViewModel(this WhatIDo model)
        {
            return new WhatIdoViewModel
            {

                Id = model.Id,
                IsActive = model.IsActive,
                IconURL = model.IconURL,
                Title = model.Title,
                Desc = model.Desc,
            };

        }
        public static List<WhatIdoViewModel> ToViewModelList(this List<WhatIDo> model)
        {
            return model.Select(x => x.ToViewModel()).ToList();

        }

        public static List<WhatIDo> ToModelList(this List<WhatIdoViewModel> model)
        {

            return model.Select(x => x.ToModel()).ToList();
        }
    }
}
