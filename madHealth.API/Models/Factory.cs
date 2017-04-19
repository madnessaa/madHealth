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


        public AnalysisResultModel Create(AnalysisResult AResult)
        {
            return new AnalysisResultModel()
            {
                Id = AResult.Id,
                Title = AResult.Title,
                Description = AResult.Description,
                Status = (AnalysisStatus)AResult.Status,               
                AppointmentID = AResult.AppointmentID,
                Type = AResult.Type.Id
            };
        }

        public AnalysisResult Create(AnalysisResultModel model)
        {
            return new AnalysisResult()
            {
                Id = model.Id,
                Title = model.Title,
                Description = model.Description,
                Status = (AnalysisStatus)model.Status,
                AppointmentID = model.AppointmentID,
                Type = _unitOfWork.AnalysisTypes.Get(model.Type)
                // AppointmentID = _unitOfWork.AnalysisResults.Get(model.AppointmentID),
            };
        }

    }
}