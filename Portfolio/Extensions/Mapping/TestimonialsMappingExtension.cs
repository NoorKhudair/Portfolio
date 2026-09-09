using Portfolio.Models;
using Portfolio.ViewModels;

namespace Portfolio.Extensions.Mapping
{
    public static class TestimonialsMappingExtension

    {

        public static Testimonials ToModel(this TestimonialsViewModel model)
        {
            return new Testimonials
            {

                Id = model.Id,
                IsActive = model.IsActive,
                ImageURL = model.ImageURL,
                Name = model.Name,
                Desc = model.Desc,
                Position = model.Position,
                IconURL = model.IconURL,
            };


        }


        public static TestimonialsViewModel ToViewModel(this Testimonials model)
        {
            return new TestimonialsViewModel
            {
                Id = model.Id,
                IsActive = model.IsActive,
                ImageURL = model.ImageURL,
                Name = model.Name,
                Desc = model.Desc,
                Position = model.Position,
                IconURL = model.IconURL,
            };

        }
        public static List<TestimonialsViewModel> ToViewModelList(this List<Testimonials> model)
        {
            return model.Select(x => x.ToViewModel()).ToList();

        }

        public static List<Testimonials> ToModelList(this List<TestimonialsViewModel> model)
        {

            return model.Select(x => x.ToModel()).ToList();
        }
    }
}
