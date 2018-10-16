<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Website.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title>Verismo Test</title>
	<link href="/style/style.css" rel="stylesheet" type="text/css" />
	<link href="/style/bootstrap.min.css" rel="stylesheet" type="text/css" />
	<link href="/style/bootstrap-theme.min.css" rel="stylesheet" type="text/css" />
	<script src="/style/jquery-2.0.3.min.js" type="text/javascript"></script>
	<script src="/style/bootstrap.min.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">
	    <div class="container">
		    <div class="page-header">
			    <h1><img src="style/logo.png" /></h1>
		    </div>
		    <h3>Lista av alla "Tasks"</h3>
		    <p>Det ska gå att lägga till nya, ändra samt ta bort.</p>
		    <p>Inget ändras skarpt innan man har tryckt på "Spara".</p>
		    <hr />
		    <div class="tasks">
			    <div class="row">
				    <div class="col-md-4">
					    <strong>Name</strong>
				    </div>
				    <div class="col-md-2">
					    <strong>DueDate</strong>
				    </div>
				    <div class="col-md-5">
					    <strong>Description</strong>
				    </div>
				    <div class="col-md-1">
					    <input type="button" value="Add row" class="btn btn-primary btn-sm" />
				    </div>
			    </div>
			    <div class="row">
				    <div class="col-md-12">
					    &nbsp;
				    </div>
			    </div>
			    <div class="row">
				    <div class="col-md-4">
					    <input type="text" class="form-control input-sm" />
				    </div>
				    <div class="col-md-2">
					    <input type="text" class="form-control input-sm" />
				    </div>
				    <div class="col-md-5">
					    <input type="text" class="form-control input-sm" />
				    </div>
				    <div class="col-md-1">
					    <input type="button" value="x" class="btn btn-danger btn-sm" />
				    </div>
			    </div>
			    <div class="row">
				    <div class="col-md-12">
					    &nbsp;
				    </div>
			    </div>
			    <div class="row">
				    <div class="col-md-12">
					    &nbsp;
				    </div>
			    </div>
			    <div class="row">
				    <div class="col-md-12 text-center">
					    <input type="button" value="Save" class="btn btn-success btn-sm" />
				    </div>
			    </div>
		    </div>
	    </div>
    </form>
</body>
</html>
