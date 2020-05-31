using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Domain.IRepository;

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
    }
}