namespace WebApiEasySwagger
{

    public class ApiRoute
    {

        /// <summary>
        /// <para>api/v1</para>
        /// </summary>
        private const string ApiVersionRoute = "api/v1";

        /// <summary>
        /// <para>api/v1/[controller]</para>
        /// </summary>
        public const string ControllerRoute = ApiVersionRoute + "/[controller]";

    }

}