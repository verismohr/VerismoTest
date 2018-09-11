<%@ Application Language="C#" %>

<%@ Import Namespace="System.Web.Http" %>
<%@ Import Namespace="System.Web.Routing" %>

<script RunAt="server">

	void Application_Start(object sender, EventArgs e)
	{
		GlobalConfiguration.Configuration.Formatters.XmlFormatter.SupportedMediaTypes.Remove(GlobalConfiguration.Configuration.Formatters.XmlFormatter.SupportedMediaTypes.FirstOrDefault(t => t.MediaType == "application/xml"));
		GlobalConfiguration.Configuration.EnableCors();
		GlobalConfiguration.Configuration.MapHttpAttributeRoutes();
		GlobalConfiguration.Configuration.EnsureInitialized();
	}

</script>