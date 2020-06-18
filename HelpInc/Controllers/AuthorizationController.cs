using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Domain.IRepository;
using Domain.Entity;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace HelpInc.Controllers
{
    public class AuthorizationController : Controller
    {
        private readonly ICompanyRepository _companyRepository;
        private readonly IProviderRepository _providerRepository;
        private readonly IConsumerRepository _consumerRepository;

        public AuthorizationController(ICompanyRepository companyRepository, IProviderRepository providerRepository, IConsumerRepository consumerRepository)
        {
            _companyRepository = companyRepository;
            _providerRepository = providerRepository;
            _consumerRepository = consumerRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login(long loginId, string type)
        {
            Company company = new Company();
            Consumer consumer = new Consumer();

            switch (type)
            {
                case "Consumer":
                    consumer = _consumerRepository.GetbyId(loginId);
                    return RedirectToAction("Principal", consumer);
                case "Provider":
                    break;
                case "Company":
                    company = _companyRepository.GetbyId(loginId);
                    return RedirectToAction("Principal", company);
            }

            return View();
        }
    }
}