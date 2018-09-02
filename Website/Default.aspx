<%@ Page Language="C#" MasterPageFile="~/Default.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="VerismoTest.Website.DefaultPage" %>

<asp:Content ContentPlaceHolderID="cphContent" runat="server">
	
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

</asp:Content>