using Library.Core.Models;
using Library.Core.Repositories;
using Library.Core.Service;
using Library.Core.UnitofWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Service.Service
{
    public class LoanService: Service<Loan>, ILoanService
    {
        private readonly ILoanRepository _loanRepository;
        public LoanService(IGenericRepository<Loan> repository, IUnitOfWork unitOfWork, ILoanRepository loanRepository) : base(repository, unitOfWork)
        {
            _loanRepository = loanRepository;
        }


    }
}

