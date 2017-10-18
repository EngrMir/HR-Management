﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.DAL.HRM;
using ERP.DAL.HRM.Repository;
using ERP.HRM.Domain;
using ERP.Utilities.Infrastructure;
using ERP.Utilities.Infrastructure.Contract;

namespace ERP.BLL.HRM
{

    public partial interface IEmployeeReferenceInformationService:IBaseService<EmployeeReferenceInformationModel ,EmployeeReferenceInformation>
    {
         
    }

    public class EmployeeReferenceInformationService : BaseService<EmployeeReferenceInformationModel, EmployeeReferenceInformation>, IEmployeeReferenceInformationService
    {

        private readonly IEmployeeReferenceInformationRepository _employeeReferenceInformationRepository;

        public EmployeeReferenceInformationService(IEmployeeReferenceInformationRepository employeeReferenceInformationRepository)
            : base(employeeReferenceInformationRepository)
        {
            _employeeReferenceInformationRepository = employeeReferenceInformationRepository;
        }


    }
}