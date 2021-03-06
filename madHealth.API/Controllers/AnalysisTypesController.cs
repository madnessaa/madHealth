﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using madHealth.Repository;
using madHealth.API.Models;
using madHealth.Database;

namespace madHealth.API.Controllers
{
    [RoutePrefix("api/analysistypes")]
    public class AnalysisTypesController : BaseController
    {
        [Route("")]
        public IHttpActionResult Get()
        {
            try
            {
                return Ok(UnitOfWork.AnalysisTypes.Get().ToList().Select(x => Factory.Create(x)).ToList());
            }
            catch (Exception ex)
            {                
                return BadRequest(ex.Message);
            }
        }

        [Route("{title}")]
        public IHttpActionResult Get(string title)
        {
            return Ok(UnitOfWork.AnalysisTypes.Get().Where(x => x.Title.Contains(title)).ToList().Select(x => Factory.Create(x)).ToList());
        }

        [Route("{id:int}")]
        public IHttpActionResult Get(int id)
        {
            try
            {
                AnalysisType type = UnitOfWork.AnalysisTypes.Get(id);
                if (type == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(Factory.Create(type));
                }
            }
            catch (Exception ex)
            {
                
                return BadRequest(ex.Message);
            }
        }

        [Route("")]
        public IHttpActionResult Post(AnalysisTypeModel model)
        {
            try
            {
                AnalysisType type = Factory.Create(model);
                UnitOfWork.AnalysisTypes.Insert(type);
                UnitOfWork.Commit();
                return Ok(Factory.Create(type));
            }
            catch (Exception ex)
            {
               
                return BadRequest(ex.Message);
            }
        }

        [Route("{id}")]
        public IHttpActionResult Put(int id, AnalysisTypeModel model)
        {
            try
            {
                AnalysisType type = Factory.Create(model);
                UnitOfWork.AnalysisTypes.Update(type, id);
                UnitOfWork.Commit();
                return Ok(Factory.Create(type));
            }
            catch (Exception ex)
            {                
                return BadRequest(ex.Message);
            }
        }

        [Route("{id}")]
        public IHttpActionResult Delete(int id)
        {
            try
            {
                AnalysisType entity = UnitOfWork.AnalysisTypes.Get(id);
                if (entity == null) return NotFound();
                UnitOfWork.AnalysisTypes.Delete(id);
                UnitOfWork.Commit();
                return Ok();
            }
            catch (Exception ex)
            {                
                return BadRequest(ex.Message);
            }
        }
    }
}
