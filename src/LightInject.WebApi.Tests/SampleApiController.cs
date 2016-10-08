namespace LightInject.Tests
{
    using System.Web.Http;

    using LightInject.SampleLibrary;

    public class SampleApiController : ApiController
    {
        private readonly string[] values;

        public SampleApiController(string[] values)
        {
            this.values = values;
        }

        [SampleWebApiActionFilter]
        public string Get(int id)
        {
            return values[id];
        }
    }


    public class AnotherSampleApiController : ApiController
    {                
        [WebApiActionFilterWithFuncDependency]
        public string Get(int id)
        {            
            return "42";
        }
    }



    public class FuncApiController : ApiController
    {                        
        [WebApiActionFilterWithFuncDependency]
        public string Get(int value)
        {
            return value.ToString();
        }
    }
}