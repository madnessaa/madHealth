using madHealth.Database;
using madHealth.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace madHealth.API.Models
{
    public class Factory
    {
        private UnitOfWork _unitOfWork;
        public Factory(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public AnalysisTypeModel Create(AnalysisType AType)
        {
            return new AnalysisTypeModel()
            {
                Id = AType.Id,
                Title = AType.Title,
                Description = AType.Description                
            };
        }

        public AnalysisType Create(AnalysisTypeModel model)
        {
            return new AnalysisType()
            {
                Id = model.Id,
                Title = model.Title,
                Description = model.Description
            };
        }


    }
}