using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;
using WebGIS.EfCore;
using WebGIS.Model;
using WebGIS.Parser;

namespace WebGIS.Controllers
{
    [ApiController]
    public class WeatherForecast : ControllerBase
    {
        private readonly DbHelper _db;
        public WeatherForecast(EF_DataContext eF_DataContext)
        {
            _db = new DbHelper(eF_DataContext);
        }
        // GET: api/<GmlAPIController>
        [HttpGet]
        [Route("api/[controller]/GetAnoCestice")]
        public IActionResult GetAnoCestice()
        {
            ResponseType type = ResponseType.Success;
            try
            {
                IEnumerable<AnoCesticeModel> data = _db.GetAnoCestice();

                if (!data.Any())
                {
                    type = ResponseType.NotFound;
                }
                return Ok(ResponseHandler.GetAppResponse(type, data));
            }
            catch (Exception ex)
            {

                return BadRequest(ResponseHandler.GetExceptionResponse(ex));
            }
        }

        // GET: api/<GmlAPIController>
        [HttpGet]
        [Route("api/[controller]/GetIdentifikacije")]
        public IActionResult GetIdentifikacije()
        {
            ResponseType type = ResponseType.Success;
            try
            {
                IEnumerable<IdentifikacijeModel> data = _db.GetIdentifikacije();

                if (!data.Any())
                {
                    type = ResponseType.NotFound;
                }
                return Ok(ResponseHandler.GetAppResponse(type, data));
            }
            catch (Exception ex)
            {

                return BadRequest(ResponseHandler.GetExceptionResponse(ex));
            }
        }

        // GET: api/<GmlAPIController>
        [HttpGet]
        [Route("api/[controller]/GetCestice")]
        public IActionResult GetCestice()
        {
            ResponseType type = ResponseType.Success;
            try
            {
                IEnumerable<CesticeModel> data = _db.GetCestice();

                if (!data.Any())
                {
                    type = ResponseType.NotFound;
                }
                return Ok(ResponseHandler.GetAppResponse(type, data));
            }
            catch (Exception ex)
            {

                return BadRequest(ResponseHandler.GetExceptionResponse(ex));
            }
        }

        // GET: api/<GmlAPIController>
        [HttpGet]
        [Route("api/[controller]/GetKatastarskeOpcine")]
        public IActionResult GetKatastarskeOpcine()
        {
            ResponseType type = ResponseType.Success;
            try
            {
                IEnumerable<KatastarskeOpcineModel> data = _db.GetKatastarskeOpcine();

                if (!data.Any())
                {
                    type = ResponseType.NotFound;
                }
                return Ok(ResponseHandler.GetAppResponse(type, data));
            }
            catch (Exception ex)
            {

                return BadRequest(ResponseHandler.GetExceptionResponse(ex));
            }
        }

        // GET: api/<GmlAPIController>
        [HttpGet]
        [Route("api/[controller]/GetNaciniUporabe")]
        public IActionResult GetNaciniUporabe()
        {
            ResponseType type = ResponseType.Success;
            try
            {
                IEnumerable<NaciniUporabeModel> data = _db.GetNaciniUporabe();

                if (!data.Any())
                {
                    type = ResponseType.NotFound;
                }
                return Ok(ResponseHandler.GetAppResponse(type, data));
            }
            catch (Exception ex)
            {

                return BadRequest(ResponseHandler.GetExceptionResponse(ex));
            }
        }

        // GET: api/<GmlAPIController>
        [HttpGet]
        [Route("api/[controller]/GetMedjeCestica")]
        public IActionResult GetMedjeCestica()
        {
            ResponseType type = ResponseType.Success;
            try
            {
                IEnumerable<MedjeCesticaModel> data = _db.GetMedjeCestica();

                if (!data.Any())
                {
                    type = ResponseType.NotFound;
                }
                return Ok(ResponseHandler.GetAppResponse(type, data));
            }
            catch (Exception ex)
            {

                return BadRequest(ResponseHandler.GetExceptionResponse(ex));
            }
        }

        // GET: api/<GmlAPIController>
        [HttpGet]
        [Route("api/[controller]/GetCesticeZgrade")]
        public IActionResult GetCesticeZgrade()
        {
            ResponseType type = ResponseType.Success;
            try
            {
                IEnumerable<CesticeZgradeModel> data = _db.GetCesticeZgrade();

                if (!data.Any())
                {
                    type = ResponseType.NotFound;
                }
                return Ok(ResponseHandler.GetAppResponse(type, data));
            }
            catch (Exception ex)
            {

                return BadRequest(ResponseHandler.GetExceptionResponse(ex));
            }
        }

        // DELETE api/<GmlAPIController>/5
        [HttpDelete]
        [Route("api/[controller]/DeleteCestice/{id}")]
        public IActionResult DeleteCestice(int id)
        {
            try
            {
                ResponseType type = ResponseType.Success;

                // Delete Cestice
                _db.DeleteCestice(id);

                return Ok(ResponseHandler.GetAppResponse(type, null));
            }
            catch (Exception ex)
            {
                return BadRequest(ResponseHandler.GetExceptionResponse(ex));
            }
        }

        // DELETE api/<GmlAPIController>/5
        [HttpDelete]
        [Route("api/[controller]/DeleteKatastarskeOpcine/{id}")]
        public IActionResult DeleteKatastarskeOpcine(int id)
        {
            try
            {
                ResponseType type = ResponseType.Success;

                // Delete KatastarskeOpcine
                _db.DeleteKatastarskeOpcine(id);

                return Ok(ResponseHandler.GetAppResponse(type, null));
            }
            catch (Exception ex)
            {
                return BadRequest(ResponseHandler.GetExceptionResponse(ex));
            }
        }

        // DELETE api/<GmlAPIController>/5
        [HttpDelete]
        [Route("api/[controller]/DeleteIdentifikacije/{id}")]
        public IActionResult DeleteIdentifikacije(int id)
        {
            try
            {
                ResponseType type = ResponseType.Success;

                // Delete Identifikacije
                _db.DeleteIdentifikacije(id);

                return Ok(ResponseHandler.GetAppResponse(type, null));
            }
            catch (Exception ex)
            {
                return BadRequest(ResponseHandler.GetExceptionResponse(ex));
            }
        }

        // DELETE api/<GmlAPIController>/5
        [HttpDelete]
        [Route("api/[controller]/DeleteNaciniUporabe/{id}")]
        public IActionResult DeleteNaciniUporabe(int id)
        {
            try
            {
                ResponseType type = ResponseType.Success;

                // Delete NaciniUporabe
                _db.DeleteNaciniUporabe(id);

                return Ok(ResponseHandler.GetAppResponse(type, null));
            }
            catch (Exception ex)
            {
                return BadRequest(ResponseHandler.GetExceptionResponse(ex));
            }
        }

        // DELETE api/<GmlAPIController>/5
        [HttpDelete]
        [Route("api/[controller]/DeleteCesticeZgrade/{id}")]
        public IActionResult DeleteCesticeZgrade(int id)
        {
            try
            {
                ResponseType type = ResponseType.Success;

                // Delete CesticeZgrade
                _db.DeleteCesticeZgrade(id);

                return Ok(ResponseHandler.GetAppResponse(type, null));
            }
            catch (Exception ex)
            {
                return BadRequest(ResponseHandler.GetExceptionResponse(ex));
            }
        }

        // DELETE api/<GmlAPIController>/5
        [HttpDelete]
        [Route("api/[controller]/DeleteMedjeCestica/{id}")]
        public IActionResult DeleteMedjeCestica(int id)
        {
            try
            {
                ResponseType type = ResponseType.Success;

                // Delete MedjeCestica
                _db.DeleteMedjeCestica(id);

                return Ok(ResponseHandler.GetAppResponse(type, null));
            }
            catch (Exception ex)
            {
                return BadRequest(ResponseHandler.GetExceptionResponse(ex));
            }
        }

        // DELETE api/<GmlAPIController>/5
        [HttpDelete]
        [Route("api/[controller]/DeleteAnoCestice/{id}")]
        public IActionResult DeleteAnoCestice(int id)
        {
            try
            {
                ResponseType type = ResponseType.Success;

                // Delete AnoCestice
                _db.DeleteAnoCestice(id);

                return Ok(ResponseHandler.GetAppResponse(type, null));
            }
            catch (Exception ex)
            {
                return BadRequest(ResponseHandler.GetExceptionResponse(ex));
            }
        }

        // POST api/<GmlAPIController>
        [HttpPost]
        [Route("api/[controller]/SaveFeature")]
        public IActionResult Post(IFormFile gmlFile)
        {
            try
            {
                List<object> updatedFeatures = new List<object>();
                // Read the contents of the file
                using (var reader = new StreamReader(gmlFile.OpenReadStream()))
                {
                    string gmlContent = reader.ReadToEnd();
                    // Parse the GML content using GmlParserService
                    updatedFeatures = GmlParserService.GmlParser(gmlContent);
                }

                var feature = updatedFeatures.FirstOrDefault();
                if (feature != null)
                {
                    var featureProperties = feature.GetType().GetProperties();

                    if (featureProperties.Any(p => p.Name == "AnoCesticaId"))
                    {
                        _db.SaveAnoCestice(updatedFeatures.Cast<AnoCesticeModel>().ToList());
                    }
                    else if (featureProperties.Any(p => p.Name == "CesticaIzvorId"))
                    {
                        _db.SaveCestice(updatedFeatures.Cast<CesticeModel>().ToList());
                    }
                    else if (featureProperties.Any(p => p.Name == "ZgradaId"))
                    {
                        _db.SaveCesticeZgrade(updatedFeatures.Cast<CesticeZgradeModel>().ToList());
                    }
                    else if (featureProperties.Any(p => p.Name == "ZkCesticaId"))
                    {
                        _db.SaveIdentifikacije(updatedFeatures.Cast<IdentifikacijeModel>().ToList());
                    }
                    else if (featureProperties.Any(p => p.Name == "KatastarskaOpcinaId"))
                    {
                        _db.SaveKatastarskeOpcine(updatedFeatures.Cast<KatastarskeOpcineModel>().ToList());
                    }
                    else if (featureProperties.Any(p => p.Name == "MedjaCesticeId"))
                    {
                        _db.SaveMedjeCestica(updatedFeatures.Cast<MedjeCesticaModel>().ToList());
                    }
                    else if (featureProperties.Any(p => p.Name == "NacinUporabeId"))
                    {
                        _db.SaveNaciniUporabe(updatedFeatures.Cast<NaciniUporabeModel>().ToList());
                    }
                }

                ResponseType type = ResponseType.Success;
                return Ok(ResponseHandler.GetAppResponse(type, updatedFeatures));
            }
            catch (Exception ex)
            {
                return BadRequest(ResponseHandler.GetExceptionResponse(ex));
            }
        }


    }
}
