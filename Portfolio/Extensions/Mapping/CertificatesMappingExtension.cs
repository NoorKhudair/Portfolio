using Portfolio.Models;
using Portfolio.ViewModels;

namespace Portfolio.Extensions.Mapping
{
    public static class CertificatesMappingExtension
    {

        public static Certificates ToModel(this CertificatesViewModel model)
        {
            return new Certificates
            {

                Id = model.Id,
                IsActive = model.IsActive,
                LogoURL =model.LogoURL,
                Title = model.Title,
                MembershipNumber=model.MembershipNumber,
                Date = model.Date
            };


        }


        public static CertificatesViewModel ToViewModel(this Certificates model)
        {
            return new CertificatesViewModel
            {
                Id = model.Id,
                IsActive = model.IsActive,
                LogoURL = model.LogoURL,
                Title = model.Title,
                MembershipNumber = model.MembershipNumber,
                Date = model.Date
            };

        }
        public static List<CertificatesViewModel> ToViewModelList(this List<Certificates> model)
        {
            return model.Select(x => x.ToViewModel()).ToList();

        }

        public static List<Certificates> ToModelList(this List<CertificatesViewModel> model)
        {

            return model.Select(x => x.ToModel()).ToList();
        }

    }
}
