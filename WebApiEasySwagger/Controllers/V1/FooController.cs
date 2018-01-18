using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace WebApiEasySwagger.Controllers.V1
{

    public class FooController : Controller
    {

        // api/v1/foo/
        /// <summary>
        /// Get simple information.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route(ApiRoute.ControllerRoute)]
        public async Task<IActionResult> GetAsync() => Content($"{await GetDateTime()} {GetCurrentMethod()}");

        // api/v1/foo/all
        /// <summary>
        /// Get all data.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route(ApiRoute.ControllerRoute + "/all")]
        public async Task<IActionResult> GetAllAsync() => Content($"{await GetDateTime()} {GetCurrentMethod()}");

        // api/v1/foo/7
        /// <summary>
        /// Get info by an id.
        /// </summary>
        /// <param name="id">Identifier that should be an integer.</param>
        /// <returns></returns>
        [HttpGet]
        [Route(ApiRoute.ControllerRoute + "/{id:int}")]
        public async Task<IActionResult> GetByIdAsync(int id) => Content($"{await GetDateTime()} and {id} {GetCurrentMethod()}");


        // ***********************************
        // Private methods added for the demo
        private async Task<string> GetDateTime()
        {
            return await Task.FromResult<string>(DateTime.UtcNow.ToString());
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        private string GetCurrentMethod()
        {
            return new StackTrace().GetFrame(3).GetMethod().Name;
        }
        // ***********************************

    }

}