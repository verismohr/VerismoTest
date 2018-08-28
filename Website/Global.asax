<%@ Application Language="C#" %>

<%@ Import Namespace="System.Web.Http" %>
<%@ Import Namespace="System.Web.Routing" %>

<script RunAt="server">

	void Application_Start(object sender, EventArgs e)
	{
		GlobalConfiguration.Configuration.Formatters.XmlFormatter.SupportedMediaTypes.Remove(GlobalConfiguration.Configuration.Formatters.XmlFormatter.SupportedMediaTypes.FirstOrDefault(t => t.MediaType == "application/xml"));
		GlobalConfiguration.Configuration.MapHttpAttributeRoutes();
		GlobalConfiguration.Configuration.Routes.MapHttpRoute(name: "api", routeTemplate: "api/{controller}/{id}", defaults: new { id = System.Web.Http.RouteParameter.Optional });
		GlobalConfiguration.Configuration.EnsureInitialized();
	}

</script>